// =====================================================================
//
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// =====================================================================
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml;

using Microsoft.Xrm.Sdk;

namespace PluginRegistrationTool
{
	public partial class ErrorMessage : Form
	{
		private string _message = string.Empty;
		private bool _loaded = false;

		public ErrorMessage()
		{
			InitializeComponent();
		}

		public string Message
		{
			get
			{
				return this._message;
			}

			set
			{
				if (value == null)
				{
					this._message = null;
				}
				else
				{
					this._message = value.Trim().Replace("\r\n", "\n").Replace("\n", "\r\n");
				}

				if (this._loaded)
				{
					txtErrorMessage.Text = _message;
					txtErrorMessage.SelectAll();
				}
			}
		}

		private void ErrorMessage_Load(object sender, EventArgs e)
		{
			txtErrorMessage.Text = this._message;
			txtErrorMessage.SelectAll();
			this._loaded = true;
		}

		private void CloseErrorMessage(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}

		public static void ShowErrorMessageBox(IWin32Window owner, string message, string caption, Exception ex)
		{
			ShowErrorMessageBox(owner, message, caption, StringizeException(ex));
		}

		public static void ShowErrorMessageBox(IWin32Window owner, string message, string caption, string exceptionMessage)
		{
			string boxMessage = "Would you like to see the details for this error?";
			if (!string.IsNullOrEmpty(message))
			{
				boxMessage = string.Format("{0}\n\n{1}", message, boxMessage);
			}

			if (MessageBox.Show(owner, boxMessage, caption, MessageBoxButtons.YesNo,
				MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				ErrorMessage dlg = new ErrorMessage();
				dlg.Message = exceptionMessage;
				dlg.ShowDialog();
			}
		}

		public static string StringizeException(Exception ex)
		{
			StringBuilder builder = new StringBuilder(1024);

			string prefix = "Unhandled ";
			Exception current = ex;

			while (current != null)
			{
				builder.AppendFormat(
					CultureInfo.InvariantCulture,
					"{0}Exception: {1}",
					prefix,
					current.GetType().FullName);

				if (current.Message.Length > 0)
				{
					builder.AppendFormat(
						CultureInfo.InvariantCulture,
						": {0}",
						current.Message);
				}

				builder.Append(Environment.NewLine);

				FaultException<OrganizationServiceFault> faultException = current as FaultException<OrganizationServiceFault>;
				if ((faultException != null) && (faultException.Detail != null))
				{
					builder.AppendFormat(
						CultureInfo.InvariantCulture,
						"Detail: {1}{0}",
						Environment.NewLine,
						ConvertDataContractToString(faultException.Detail));
				}

				builder.Append(current.StackTrace);
				builder.Append(Environment.NewLine);

				prefix = "Inner ";
				current = current.InnerException;
			}

			return builder.ToString();
		}

		/// <summary>
		/// Converts an object (that is a data contract) to a string
		/// </summary>
		/// <param name="value">Value to be converted to a string</param>
		/// <returns>Data contract in a serialized string format</returns>
		public static string ConvertDataContractToString(object value)
		{
			if (null == value)
			{
				throw new ArgumentNullException("value");
			}

			//Retrieve the type for the value
			Type valueType = value.GetType();

			//Verify that this is a data contract
			DataContractAttribute[] contractAttributeList =
				(DataContractAttribute[])valueType.GetCustomAttributes(typeof(DataContractAttribute), true);
			if (null == contractAttributeList || 0 == contractAttributeList.Length)
			{
				throw new ArgumentException("The argument does not have a DataContract attribute.", "value");
			}

			//Create the stream
			using (MemoryStream stream = new MemoryStream())
			{
				//Create the serializer for the object
				DataContractSerializer serializer = new DataContractSerializer(valueType);

				//Write the object to the stream
				serializer.WriteObject(stream, value);

				//In order to format the XML document (since this is being output), it has to go
				//through the XmlWriter. The MemoryStream can be reused to create a string
				//Reset the stream's position
				stream.Seek(0, SeekOrigin.Begin);

				//Create an XML document from the stream
				XmlDocument doc = new XmlDocument();
				doc.Load(stream);

				//Create the writer settings
				XmlWriterSettings settings = new XmlWriterSettings();
				settings.Indent = true;
				settings.OmitXmlDeclaration = true;

				//Write the data
				using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
				{
					using (XmlWriter writer = XmlWriter.Create(stringWriter, settings))
					{
						doc.Save(writer);
					}

					//Return the writer's contents
					return stringWriter.ToString();
				}
			}
		}
	}
}
