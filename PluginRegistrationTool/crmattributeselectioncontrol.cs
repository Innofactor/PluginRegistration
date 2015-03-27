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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using PluginRegistrationTool.Forms;
using PluginRegistrationTool.Helpers;

namespace PluginRegistrationTool
{
	[Designer(typeof(DocumentDesigner), typeof(IRootDesigner))]
	public partial class CrmAttributeSelectionControl : UserControl
	{
		private bool m_allAttributes;
		private Collection<string> m_attributeList = new Collection<string>();
		private CrmOrganization m_org;
		private string m_entityName;

		public event EventHandler<EventArgs> AttributesChanged;

		public CrmAttributeSelectionControl()
		{
			InitializeComponent();
		}

		[Browsable(false)]
		public CrmOrganization Organization
		{
			get
			{
				return this.m_org;
			}
			set
			{
				this.m_org = value;
				btnSelect.Enabled = (this.m_org != null && this.m_entityName != null);
			}
		}

		[Browsable(true)]
		public bool WordWrap
		{
			get
			{
				return txtAttributes.WordWrap;
			}

			set
			{
				txtAttributes.WordWrap = value;
			}
		}

		[Browsable(true)]
		public ScrollBars ScrollBars
		{
			get
			{
				return txtAttributes.ScrollBars;
			}

			set
			{
				txtAttributes.ScrollBars = value;
			}
		}

		[Browsable(true)]
		public string EntityName
		{
			get
			{
				return this.m_entityName;
			}
			set
			{
				if (!string.Equals(this.m_entityName, value, StringComparison.CurrentCulture))
				{
					this.m_entityName = value;
					btnSelect.Enabled = (this.m_org != null && this.m_entityName != null);
				}
			}
		}

		[Browsable(true)]
		public string Attributes
		{
			get
			{
				if (this.m_allAttributes)
				{
					return null;
				}
				else
				{
					return this.AttributeString;
				}
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_allAttributes = true;
					this.m_attributeList.Clear();

					txtAttributes.Text = "All Attributes";
				}
				else
				{
					this.m_allAttributes = false;
					this.AttributeString = value;

					txtAttributes.Text = string.Join(", ", this.AttributeCollectionToArray());
				}
			}
		}

		[Browsable(false)]
		public bool AllAttributes
		{
			get
			{
				return this.m_allAttributes;
			}
		}

		[Browsable(false)]
		public bool HasAttributes
		{
			get
			{
				return (this.m_allAttributes || this.m_attributeList.Count != 0);
			}
		}

		/// <summary>
		/// Shows this message when the control is disabled
		/// </summary>
		[Browsable(true)]
		public string DisabledMessage
		{
			get
			{
				return txtDisabledMessage.Text;
			}

			set
			{
				txtDisabledMessage.Text = value;
				this.DisplayDisabledMessage();
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			if (!this.Organization.IsEntityAttributesLoaded(this.EntityName))
			{
				WebServiceProgressForm progForm = new WebServiceProgressForm(this);
				OrganizationHelper.LoadAttributeList(this.Organization, this.EntityName, progForm.ProgressIndicator);

				if (this.Organization.AttributeLoadException != null)
				{
					ErrorMessageForm.ShowErrorMessageBox(this, "Unable to load attribute list", "Attribute List Error",
						this.Organization.AttributeLoadException);
					return;
				}
			}

			AttributeSelectionForm selectorForm = new AttributeSelectionForm(this.UpdateParameters, this.m_org,
				this.Organization.RetrieveEntityAttributes(this.EntityName), this.m_attributeList, this.m_allAttributes);
			selectorForm.ShowDialog();
		}

		private void CrmAttributeSelectionControl_EnabledChanged(object sender, EventArgs e)
		{
			this.DisplayDisabledMessage();
		}

		#region Public Helper Methods
		public void ClearAttributes()
		{
			this.UpdateParameters(null, false);
		}
		#endregion

		#region Private Helper Methods
		private string AttributeString
		{
			get
			{
				if (this.m_attributeList.Count == 0)
				{
					return string.Empty;
				}
				else
				{
					return string.Join(",", this.AttributeCollectionToArray());
				}
			}
			set
			{
				this.m_attributeList.Clear();
				if (!string.IsNullOrEmpty(value))
				{
					string[] attributeList = value.Split(',');
					foreach (string attribute in attributeList)
					{
						if (!string.IsNullOrEmpty(attribute))
						{
							this.m_attributeList.Add(attribute.Trim());
						}
					}
				}
			}
		}

		private string[] AttributeCollectionToArray()
		{
			return this.AttributeCollectionToArray(this.m_attributeList);
		}

		private string[] AttributeCollectionToArray(Collection<string> attributes)
		{
			if (attributes == null)
			{
				return new string[0];
			}
			else
			{
				string[] attributeList = new string[attributes.Count];
				attributes.CopyTo(attributeList, 0);

				return attributeList;
			}
		}

		private void UpdateParameters(Collection<string> attributes, bool allAttributes)
		{
			string newText;
			if (allAttributes)
			{
				newText = "All Attributes";
				this.m_allAttributes = true;
			}
			else
			{
				newText = string.Join(", ", this.AttributeCollectionToArray(attributes));
				this.m_allAttributes = false;
			}

			if (allAttributes != this.AllAttributes || !string.Equals(this.txtAttributes.Text, newText, StringComparison.CurrentCulture))
			{
				txtAttributes.Text = newText;
				this.m_allAttributes = allAttributes;

				this.m_attributeList.Clear();
				if (attributes != null && attributes.Count != 0)
				{
					foreach (string attribute in attributes)
					{
						this.m_attributeList.Add(attribute);
					}
				}

				if (this.AttributesChanged != null)
				{
					this.AttributesChanged(this, new EventArgs());
				}
			}
		}

		private void DisplayDisabledMessage()
		{
			bool visibleDisabledMessage = !(this.Enabled || txtDisabledMessage.TextLength == 0);

			txtDisabledMessage.Visible = visibleDisabledMessage;
			txtAttributes.Visible = !visibleDisabledMessage;
			btnSelect.Visible = !visibleDisabledMessage;
		}
		#endregion
	}
}
