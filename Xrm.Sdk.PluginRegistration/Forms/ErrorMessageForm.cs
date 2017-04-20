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

namespace Xrm.Sdk.PluginRegistration.Forms
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;
    using Microsoft.Xrm.Sdk;

    public partial class ErrorMessageForm : Form
    {
        private string _message = string.Empty;
        private bool _loaded = false;

        public ErrorMessageForm()
        {
            InitializeComponent();
        }

        public string Message
        {
            get
            {
                return _message;
            }

            set
            {
                if (value == null)
                {
                    _message = null;
                }
                else
                {
                    _message = value.Trim().Replace("\r\n", "\n").Replace("\n", "\r\n");
                }

                if (_loaded)
                {
                    txtErrorMessage.Text = _message;
                    txtErrorMessage.SelectAll();
                }
            }
        }

        private void ErrorMessage_Load(object sender, EventArgs e)
        {
            txtErrorMessage.Text = _message;
            txtErrorMessage.SelectAll();
            _loaded = true;
        }

        private void CloseErrorMessage(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
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
                var dlg = new ErrorMessageForm();
                
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Message = exceptionMessage;
                dlg.ShowDialog();
                dlg.BringToFront();
            }
        }

        /// <summary>
        /// Build readable representation of exception happened
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static string StringizeException(Exception ex)
        {
            var builder = new StringBuilder(1024);

            var prefix = "Unhandled ";
            var current = ex;

            while (current != null)
            {
                builder.AppendFormat(CultureInfo.InvariantCulture, $"{prefix}Exception of type: {current.GetType().Name}");

                builder.Append(Environment.NewLine);
                builder.Append(Environment.NewLine);

                if (current.Message.Length > 0)
                {
                    builder.AppendFormat(CultureInfo.InvariantCulture, $"{current.Message}");
                }

                builder.Append(Environment.NewLine);
                builder.Append(Environment.NewLine);

                if ((current is FaultException<OrganizationServiceFault> faultException) && (faultException.Detail != null))
                {
                    builder.AppendFormat(CultureInfo.InvariantCulture, $"Detail: {Environment.NewLine}{Environment.NewLine}{ConvertDataContractToString(faultException.Detail)}");
                }

                builder.Append(Environment.NewLine);
                builder.Append(Environment.NewLine);

                builder.Append(current.StackTrace);

                builder.Append(Environment.NewLine);
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
