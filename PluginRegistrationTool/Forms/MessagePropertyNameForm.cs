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

namespace PluginRegistrationTool.Forms
{
    using System;
    using System.Globalization;
    using System.Windows.Forms;

	public partial class MessagePropertyNameForm : Form
	{
		private CrmMessage _message;
		private RadioButton[] _buttonList;

		private MessagePropertyNameForm(CrmMessage message)
		{
			if (null == message)
			{
				throw new ArgumentNullException("message");
			}

			InitializeComponent();

			this._message = message;
			grpMessageProperties.Text = string.Format(CultureInfo.InvariantCulture, grpMessageProperties.Text,
				message.Name);

			//Create the list
			this._buttonList = new RadioButton[message.ImageMessagePropertyNames.Count];

			//Add the radio buttons to the list
			int radioSpace = radTemplateItem.Margin.Top + radTemplateItem.Height;
			int radioTop = radTemplateItem.Top + radioSpace;
			for (int i = 0; i < message.ImageMessagePropertyNames.Count; i++)
			{
				RadioButton button;
				if (0 == i)
				{
					button = radTemplateItem;
				}
				else
				{
					button = new RadioButton();
					button.Left = radTemplateItem.Left;
					button.Top = radioTop;
					grpMessageProperties.Controls.Add(button);

					radioTop += radioSpace;
				}

				ImageMessagePropertyName property = message.ImageMessagePropertyNames[i];
				button.Text = property.Label;
				button.Tag = property;
				button.CheckedChanged += new EventHandler(ButtonCheckedChanged);

				this._buttonList[i] = button;
			}

			radTemplateItem.Visible = true;
			radTemplateItem.Checked = true;
		}

		#region Methods
		public static string SelectMessagePropertyName(CrmMessage message)
		{
			if (null == message)
			{
				throw new ArgumentNullException("message");
			}

			// Handle the basic cases
			if (0 == message.ImageMessagePropertyNames.Count)
			{
				return null;
			}
			else if (1 == message.ImageMessagePropertyNames.Count)
			{
				return message.ImageMessagePropertyNames[0].Name;
			}

			// For multiple properties, display the selection form.
			using (MessagePropertyNameForm selectPropertyForm = new MessagePropertyNameForm(message))
			{
				if (selectPropertyForm.ShowDialog() == DialogResult.OK &&
					null != selectPropertyForm.SelectedMessagePropertyName)
				{
					return selectPropertyForm.SelectedMessagePropertyName.Name;
				}
			}

			return null;
		}
		#endregion

		#region Properties
		public ImageMessagePropertyName SelectedMessagePropertyName
		{
			get
			{
				if (0 == this._buttonList.Length)
				{
					return null;
				}

				for (int i = 0; i < this._buttonList.Length; i++)
				{
					if (this._buttonList[i].Checked)
					{
						return (ImageMessagePropertyName)this._buttonList[i].Tag;
					}
				}

				return null;
			}
		}
		#endregion

		#region Event Handlers
		private void btnOK_Click(object sender, EventArgs e)
		{
			if (null == this.SelectedMessagePropertyName)
			{
				MessageBox.Show("No Message Property has been checked. Check at least one or click Cancel",
					"Message Properties", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				this.DialogResult = DialogResult.None;
				return;
			}

			this.DialogResult = DialogResult.OK;
		}

		private void ButtonCheckedChanged(object sender, EventArgs e)
		{
			RadioButton button = sender as RadioButton;
			if (null == button)
			{
				txtDescription.Clear();
			}
			else
			{
				txtDescription.Text = ((ImageMessagePropertyName)button.Tag).Description;
			}
		}
		#endregion
	}
}
