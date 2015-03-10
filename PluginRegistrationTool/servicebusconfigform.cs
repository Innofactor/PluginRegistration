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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using AuthProviderType = Microsoft.Xrm.Sdk.Client.AuthenticationProviderType;

namespace PluginRegistrationTool
{
	using CrmSdk;
	using Microsoft.Xrm.Sdk.Messages;
	using Microsoft.AccessControl.Samples.AcmTool;
	using Microsoft.AccessControl.Samples.AcmTool.Commands;
	using Microsoft.AccessControl.Samples.AcmTool.Resources;
	using System.Threading;

	public partial class ServiceBusConfigForm : Form
	{
		private CrmOrganization m_org;

		private OrganizationControl m_orgControl;

		private CrmServiceEndpoint m_currentServiceEndpoint = null;

		public ServiceBusConfigForm(CrmOrganization org, OrganizationControl orgControl, CrmServiceEndpoint serviceEndpoint)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			if (orgControl == null)
			{
				throw new ArgumentNullException("orgControl");
			}

			InitializeComponent();
			this.m_org = org;
			this.m_orgControl = orgControl;
			m_currentServiceEndpoint = serviceEndpoint;

			if (cmbContract.Items.Count == 0)
			{
				cmbContract.Items.Add(CrmServiceEndpointContract.OneWay);
				cmbContract.Items.Add(CrmServiceEndpointContract.Queue);
				cmbContract.Items.Add(CrmServiceEndpointContract.TwoWay);
				cmbContract.Items.Add(CrmServiceEndpointContract.Rest);
				cmbContract.SelectedItem = CrmServiceEndpointContract.OneWay;
			}

			if (cmbUserClaim.Items.Count == 0)
			{
				cmbUserClaim.Items.Add(CrmServiceEndpointUserClaim.None);
				cmbUserClaim.Items.Add(CrmServiceEndpointUserClaim.UserId);
				switch (m_org.OrganizationService.ServiceConfiguration.AuthenticationType)
				{
					case AuthProviderType.LiveId:
					case AuthProviderType.OnlineFederation:
						break;				
					default:
						cmbUserClaim.Items.Add(CrmServiceEndpointUserClaim.UserInfo);
						break;
				}						
				
				cmbUserClaim.SelectedItem = CrmServiceEndpointUserClaim.None;
			}
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			bool isError = SaveServiceEndpoint();
			if (isError)
			{
				this.DialogResult = DialogResult.None;
				return;
			}
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private bool SaveServiceEndpoint()
		{
			bool isError = false;
			try
			{
				CrmServiceEndpoint sbc = PrepareServiceBusConfiguration();
				string errMsg = ValidateSbc(sbc);
				if (string.IsNullOrEmpty(errMsg))
				{
					if (this.m_currentServiceEndpoint == null)
					{
						sbc.ServiceEndpointId = RegistrationHelper.RegisterServiceEndpoint(m_org, sbc);
						List<ICrmEntity> serviceEndpoints = new List<ICrmEntity>();
						serviceEndpoints.Add(sbc);
						OrganizationHelper.UpdateDates(m_org, serviceEndpoints);
						m_org.AddServiceEndpoint(sbc);
						m_currentServiceEndpoint = m_org.ServiceEndpoints[sbc.ServiceEndpointId];
						m_orgControl.AddServiceEndpoint(sbc);
						txtConfigId.Text = m_currentServiceEndpoint.ServiceEndpointId.ToString();
					}
					else
					{
						//Update
						RegistrationHelper.UpdateServiceEndpoint(m_org, sbc);
						this.m_currentServiceEndpoint.SolutionNamespace = sbc.SolutionNamespace;
						this.m_currentServiceEndpoint.UserClaim = sbc.UserClaim;
						this.m_currentServiceEndpoint.Name = sbc.Name;
						this.m_currentServiceEndpoint.ConnectionMode = sbc.ConnectionMode;
						this.m_currentServiceEndpoint.Contract = sbc.Contract;
						this.m_currentServiceEndpoint.Description = sbc.Description;
						this.m_currentServiceEndpoint.Path = sbc.Path;
						List<ICrmEntity> serviceEndpoints = new List<ICrmEntity>();
						serviceEndpoints.Add(m_currentServiceEndpoint);
						OrganizationHelper.UpdateDates(m_org, serviceEndpoints);

						// Refreshes Node in the Org Control after the update
						m_orgControl.RefreshServiceEndpoint(m_currentServiceEndpoint);
					}
				}
				else
				{
					isError = true;
					MessageBox.Show(errMsg,
						"Invalid configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				return isError;
			}
			catch (Exception ex)
			{
				isError = true;
				ErrorMessage.ShowErrorMessageBox(this, "Error while updating the Service Bus Configuration",
					"Service Bus", ex);
				return isError;
			}
		}

		private string ValidateSbc(CrmServiceEndpoint sbc)
		{
			StringBuilder sb = new StringBuilder();
			if (string.IsNullOrEmpty(sbc.SolutionNamespace))
			{
				sb.AppendLine("SolutionName is required. ");
			}

			if (string.IsNullOrEmpty(sbc.Path))
			{
				sb.AppendLine("Path is required. ");
			}

			if (sbc.Contract == CrmServiceEndpointContract.Rest && sbc.ConnectionMode == CrmServiceEndpointConnectionMode.Federated)
			{
				sb.AppendLine("Federated mode not suppored for REST contract. ");
			}

			return sb.ToString();
		}

		private CrmServiceEndpoint PrepareServiceBusConfiguration()
		{
			CrmServiceEndpoint sbc = new CrmServiceEndpoint(this.m_org);
			if (m_currentServiceEndpoint != null)
			{
				sbc.ServiceEndpointId = m_currentServiceEndpoint.ServiceEndpointId;
			}
			sbc.Name = txtName.Text;
			sbc.SolutionNamespace = txtSolution.Text;
			sbc.Path = txtPath.Text;

			sbc.Contract = (CrmServiceEndpointContract)cmbContract.SelectedItem;
			sbc.UserClaim = (CrmServiceEndpointUserClaim)cmbUserClaim.SelectedItem;
			sbc.Description = txtDescription.Text;
			if (chkFederatedMode.Checked)
			{
				sbc.ConnectionMode = CrmServiceEndpointConnectionMode.Federated;
			}
			else
			{
				sbc.ConnectionMode = CrmServiceEndpointConnectionMode.Normal;
			}

			return sbc;
		}
		private void LoadConfig()
		{
			if (this.m_currentServiceEndpoint != null)
			{
				cmbContract.SelectedItem = m_currentServiceEndpoint.Contract;
				cmbUserClaim.SelectedItem = m_currentServiceEndpoint.UserClaim;

				chkFederatedMode.Checked = (m_currentServiceEndpoint.ConnectionMode == CrmServiceEndpointConnectionMode.Federated);
				txtName.Text = m_currentServiceEndpoint.Name;
				txtDescription.Text = m_currentServiceEndpoint.Description;
				txtSolution.Text = m_currentServiceEndpoint.SolutionNamespace;
				txtPath.Text = m_currentServiceEndpoint.Path;
				txtConfigId.Text = m_currentServiceEndpoint.ServiceEndpointId.ToString();
			}
		}

		private void ServiceBusConfigForm_Load(object sender, EventArgs e)
		{
			LoadConfig();
		}

		private void btnVerifyAuthentication_Click(object sender, EventArgs e)
		{
			bool isError = SaveServiceEndpoint();
			if (isError)
			{
				this.DialogResult = DialogResult.None;
				return;
			}
			ACSAuthenticationStatusForm serviceBusConfigForm = new ACSAuthenticationStatusForm(this.m_currentServiceEndpoint.ServiceEndpointId, this.m_org);
			serviceBusConfigForm.ShowDialog();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void btnConfigureACS_Click(object sender, EventArgs e)
		{
			bool isError = SaveServiceEndpoint();
			if (isError)
			{
				this.DialogResult = DialogResult.None;
				return;
			}

			ACSConfigurationForm acsConfigurationForm = new ACSConfigurationForm(this.m_org, this.m_currentServiceEndpoint);
			acsConfigurationForm.ShowDialog();
		}

	}

}
