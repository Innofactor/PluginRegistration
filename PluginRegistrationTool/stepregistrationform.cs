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
using System.Windows.Forms;

using PluginProfiler.Plugins;

namespace PluginRegistrationTool
{
	using CrmSdk;

	public partial class StepRegistrationForm : Form
	{
		private CrmOrganization m_org;
		private OrganizationControl m_orgControl;
		private CrmPluginStep m_currentStep;
		private bool m_secureConfigurationIdIsInvalid = false;

		public StepRegistrationForm(CrmOrganization org, OrganizationControl orgControl, CrmPlugin plugin, CrmPluginStep step, CrmServiceEndpoint serviceEndpoint)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}
			else if (orgControl == null)
			{
				throw new ArgumentNullException("control");
			}

			InitializeComponent();

			this.m_org = org;
			this.m_orgControl = orgControl;
			this.m_currentStep = step;

			crmFilteringAttributes.Organization = org;

			//Initialize the auto-complete on the Message field
			AutoCompleteStringCollection msgList = new AutoCompleteStringCollection();
			foreach (CrmMessage msg in org.Messages.Values)
			{
				msgList.Add(msg.Name);
			}
			txtMessageName.AutoCompleteCustomSource = msgList;

			//Check whether system plugins should be added to the list			
			if (step != null && org[step.AssemblyId][step.PluginId].IsSystemCrmEntity && (!OrganizationHelper.AllowStepRegistrationForPlugin(plugin)))
			{
				cmbPlugins.Enabled = false;
			}
			else if ((plugin != null) && (!OrganizationHelper.AllowStepRegistrationForPlugin(plugin)))
			{
				plugin = null;
			}

			//Add the plugins
			CrmPlugin selectPlugin = null;
			foreach (CrmPluginAssembly assembly in org.Assemblies.Values)
			{
				foreach (CrmPlugin pluginType in assembly.Plugins.Values)
				{
					if (pluginType.PluginType == CrmPluginType.Plugin &&
						OrganizationHelper.AllowStepRegistrationForPlugin(pluginType))
					{
						if (serviceEndpoint == null && pluginType.TypeName == CrmServiceEndpoint.ServiceBusPluginName && pluginType.CustomizationLevel == 0)
						{
							continue;
							// Donot add OOB Service Bus plugin to the list when it it is not a Service Bus Step
						}
						else
						{
							if (plugin != null && plugin.PluginId == pluginType.PluginId)
							{
								selectPlugin = pluginType;
								cmbPlugins.Items.Add(pluginType);
							}
							else
							{
								cmbPlugins.Items.Add(pluginType);
							}
						}
					}
				}
			}

			if (cmbPlugins.Items.Count != 0)
			{
				if (selectPlugin == null)
				{
					cmbPlugins.SelectedIndex = 0;
				}
				else
				{
					cmbPlugins.SelectedItem = selectPlugin;
				}
			}

			//Create a user that represents the current user
			CrmUser callingUser = new CrmUser(org);
			callingUser.UserId = Guid.Empty;
			callingUser.Name = "Calling User";
			callingUser.Enabled = true;
			cmbUsers.Items.Add(callingUser);

			//Add the users. We do not want to sort because the users list is sorted already and then the calling user
			//will not be at the beginning of the list
			cmbUsers.Sorted = false;
			foreach (CrmUser user in org.Users.Values)
			{
				// Added this check to to prevent OutofMemoryExcetion - When an org is imported, the administrator
				// does not have a name associated with it, Adding Null Names to ComboBox throws OutofMemoryExcetion
				if (null != user && user.Enabled == true && user.Name != null)
				{
					cmbUsers.Items.Add(user);
				}
				// Special case to add System user
				if (user.Name == "SYSTEM" && user.Enabled == false)
				{
					cmbUsers.Items.Add(user);
				}
			}

			if (cmbUsers.Items.Count != 0)
			{
				cmbUsers.SelectedIndex = 0;
			}

			CrmServiceEndpoint selectServiceEndpoint = null;
			foreach (CrmServiceEndpoint currentServiceEndpoint in org.ServiceEndpoints.Values)
			{

				if (serviceEndpoint != null && serviceEndpoint.ServiceEndpointId == currentServiceEndpoint.ServiceEndpointId)
				{
					selectServiceEndpoint = currentServiceEndpoint;
				}
				cmbServiceEndpoint.Items.Add(currentServiceEndpoint);
			}

			if (selectServiceEndpoint != null)
			{
				cmbServiceEndpoint.SelectedItem = selectServiceEndpoint;
			}
			else
			{
				if (cmbServiceEndpoint.Items.Count != 0)
				{
					cmbServiceEndpoint.SelectedIndex = 0;
				}
			}

			if (serviceEndpoint != null)
			{
				UpdatePluginEventHandlerControls(true);
			}
			else
			{
				UpdatePluginEventHandlerControls(false);
			}

			if (this.m_currentStep != null)
			{
				txtMessageName.Text = this.m_org.Messages[this.m_currentStep.MessageId].Name;

				if (org.MessageEntities.ContainsKey(this.m_currentStep.MessageEntityId))
				{
					CrmMessageEntity msgEntity = this.Message[this.m_currentStep.MessageEntityId];
					txtPrimaryEntity.Text = msgEntity.PrimaryEntity;
					txtSecondaryEntity.Text = msgEntity.SecondaryEntity;
				}
				else
				{
					txtPrimaryEntity.Text = "none";
					txtSecondaryEntity.Text = "none";
				}

				cmbPlugins.SelectedItem = this.m_org[this.m_currentStep.AssemblyId][this.m_currentStep.PluginId];

				if (this.m_currentStep.ServiceBusConfigurationId != Guid.Empty)
				{
					cmbServiceEndpoint.SelectedItem = this.m_org.ServiceEndpoints[this.m_currentStep.ServiceBusConfigurationId];
				}

				if (this.m_currentStep.ImpersonatingUserId == Guid.Empty)
				{
					cmbUsers.SelectedIndex = 0;
				}
				else
				{
					cmbUsers.SelectedItem = this.m_org.Users[this.m_currentStep.ImpersonatingUserId];
				}
				txtRank.Text = this.m_currentStep.Rank.ToString();
				switch (this.m_currentStep.Stage)
				{
					case CrmPluginStepStage.PreValidation:
						this.radStagePreValidation.Checked = true;
						break;
					case CrmPluginStepStage.PreOperation:
						this.radStagePreOperation.Checked = true;
						break;
					case CrmPluginStepStage.PostOperation:
						this.radStagePostOperation.Checked = true;
						break;
					case CrmPluginStepStage.PostOperationDeprecated:
						this.radStagePostOperationDeprecated.Checked = true;
						break;
					default:
						throw new NotImplementedException("CrmPluginStepStage = " + this.m_currentStep.Stage.ToString());
				}

				switch (this.m_currentStep.Mode)
				{
					case CrmPluginStepMode.Asynchronous:

						radModeAsync.Checked = true;
						break;
					case CrmPluginStepMode.Synchronous:

						radModeSync.Checked = true;
						break;

					default:
						throw new NotImplementedException("Mode = " + this.m_currentStep.Mode.ToString());
				}

				switch (this.m_currentStep.Deployment)
				{
					case CrmPluginStepDeployment.Both:

						chkDeploymentOffline.Checked = true;
						chkDeploymentServer.Checked = true;
						break;
					case CrmPluginStepDeployment.ServerOnly:

						chkDeploymentOffline.Checked = false;
						chkDeploymentServer.Checked = true;
						break;
					case CrmPluginStepDeployment.OfflineOnly:

						chkDeploymentOffline.Checked = true;
						chkDeploymentServer.Checked = false;
						break;
					default:
						throw new NotImplementedException("Deployment = " + this.m_currentStep.Deployment.ToString());
				}

				switch (this.m_currentStep.InvocationSource)
				{
					case null:
					case CrmPluginStepInvocationSource.Parent:

						radInvocationParent.Checked = true;
						break;
					case CrmPluginStepInvocationSource.Child:

						radInvocationChild.Checked = true;
						break;
					default:
						throw new NotImplementedException("InvocationSource = " + this.m_currentStep.InvocationSource.ToString());
				}

				txtDescription.Text = this.m_currentStep.Description;

				txtSecureConfig.Text = this.m_currentStep.SecureConfiguration;

				string stepName;
				if (this.m_currentStep.IsProfiled && org.Plugins[this.m_currentStep.PluginId].IsProfilerPlugin)
				{
					//If the current step is a profiler step, the form that is displayed should use the configuration from the original step.
					ProfilerConfiguration profilerConfig = OrganizationHelper.RetrieveProfilerConfiguration(this.m_currentStep);
					stepName = profilerConfig.OriginalEventHandlerName;
					txtUnsecureConfiguration.Text = profilerConfig.Configuration;
				}
				else
				{
					txtUnsecureConfiguration.Text = this.m_currentStep.UnsecureConfiguration;
					stepName = this.m_currentStep.Name;
				}

				if (stepName == this.GenerateDescription())
				{
					this.m_stepName = this.GenerateDescription();
				}
				else
				{
					this.m_stepName = null;
					txtName.Text = stepName;
				}

				if (this.MessageEntity != null)
				{
					crmFilteringAttributes.EntityName = this.MessageEntity.PrimaryEntity;
				}

				crmFilteringAttributes.Attributes = this.m_currentStep.FilteringAttributes;
				chkDeleteAsyncOperationIfSuccessful.Checked = this.m_currentStep.DeleteAsyncOperationIfSuccessful;
				chkDeleteAsyncOperationIfSuccessful.Enabled = (this.m_currentStep.Mode == CrmPluginStepMode.Asynchronous);

				this.Text = "Update Existing Step";
				btnRegister.Text = "Update";

				this.CheckAttributesSupported();
			}
			else if (!radStagePostOperation.Enabled && radStagePostOperationDeprecated.Enabled)
			{
				radStagePostOperationDeprecated.Checked = true;
			}

			//Check if permissions for the secure configuration was denied
			if (org.SecureConfigurationPermissionDenied)
			{
				picAccessDenied.Visible = true;
				lblAccessDenied.Visible = true;
				txtSecureConfig.Visible = false;

				picAccessDenied.Image = CrmResources.LoadImage("AccessDenied");

				lblAccessDenied.Left = picAccessDenied.Right;

				int groupLeft = (grpSecureConfiguration.ClientSize.Width - (lblAccessDenied.Right - picAccessDenied.Left)) / 2;
				int groupTop = (grpSecureConfiguration.ClientSize.Height - lblAccessDenied.Height) / 2;

				picAccessDenied.Top = groupTop;
				lblAccessDenied.Top = groupTop;

				picAccessDenied.Left = groupLeft;
				lblAccessDenied.Left = picAccessDenied.Right;
			}
			else if (null != step && step.SecureConfigurationRecordIdInvalid)
			{
				picInvalidSecureConfigurationId.Visible = true;
				lblInvalidSecureConfigurationId.Visible = true;
				lnkInvalidSecureConfigurationId.Visible = true;
				txtSecureConfig.Visible = false;

				picInvalidSecureConfigurationId.Image = CrmResources.LoadImage("AccessDenied");
				lblInvalidSecureConfigurationId.Left = picInvalidSecureConfigurationId.Right;

				int groupLeft = (grpSecureConfiguration.ClientSize.Width - (lblInvalidSecureConfigurationId.Right - picInvalidSecureConfigurationId.Left)) / 2;
				int groupTop = (grpSecureConfiguration.ClientSize.Height - (lnkInvalidSecureConfigurationId.Bottom - picInvalidSecureConfigurationId.Top)) / 2;

				picInvalidSecureConfigurationId.Top = groupTop;
				lblInvalidSecureConfigurationId.Top = groupTop;
				lnkInvalidSecureConfigurationId.Top = lblInvalidSecureConfigurationId.Bottom + 6;

				picInvalidSecureConfigurationId.Left = groupLeft;
				lblInvalidSecureConfigurationId.Left = picAccessDenied.Right;
				lnkInvalidSecureConfigurationId.Left = lblInvalidSecureConfigurationId.Left;

				this.m_secureConfigurationIdIsInvalid = true;
			}

			this.LoadEntities();
			this.CheckDeploymentSupported();
		}

		private void UpdatePluginEventHandlerControls(bool isServiceEndpoint)
		{
			cmbServiceEndpoint.Location = cmbPlugins.Location;
			cmbServiceEndpoint.Size = cmbPlugins.Size;

			grpStage.Enabled = !isServiceEndpoint;

			cmbPlugins.Enabled = !isServiceEndpoint;
			cmbPlugins.Visible = !isServiceEndpoint;

			cmbServiceEndpoint.Visible = isServiceEndpoint;
			cmbServiceEndpoint.Enabled = isServiceEndpoint;

			txtUnsecureConfiguration.Enabled = !isServiceEndpoint;
			txtSecureConfig.Enabled = !isServiceEndpoint;

			grpDeployment.Enabled = !isServiceEndpoint;
			grpMode.Enabled = !isServiceEndpoint;

			if (isServiceEndpoint)
			{
				chkDeploymentOffline.Checked = false;
				chkDeploymentServer.Checked = true;
				radStagePostOperation.Checked = true;
				radModeAsync.Checked = true;
			}
		}

		#region Events
		private void btnRegister_Click(object sender, EventArgs e)
		{
			CrmPluginStep step = new CrmPluginStep(this.m_org);

			bool isDeploymentOfflineChecked = (chkDeploymentOffline.Enabled && chkDeploymentOffline.Checked);

			//The Server Deployment box should be considered "Checked" when it is enabled and checked OR when it is a service
			//endpoint Step (this is the case when the combo box is enabled)
			bool isDeploymentServerChecked = (chkDeploymentServer.Enabled && chkDeploymentServer.Checked) || cmbServiceEndpoint.Visible;

			#region Extract Information
			//Validate information
			if (!isDeploymentOfflineChecked && !isDeploymentServerChecked)
			{
				MessageBox.Show("At least one Step Deployment must be specified", "Step Registration",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				chkDeploymentServer.Focus();
				return;
			}
			else if (this.Message == null)
			{
				MessageBox.Show("Invalid Message Name specified. Please re-enter the message name",
					"Invalid Message Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtMessageName.Focus();
				return;
			}
			else if (this.radModeAsync.Checked && !(radStagePostOperation.Checked || radStagePostOperationDeprecated.Checked))
			{
				MessageBox.Show("Asynchronous Execution Mode requires registration in one of the Post Stages. Please change the Mode or the Stage.",
					"Step Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else if (txtName.TextLength == 0)
			{
				MessageBox.Show("Name is a required field.", "Step Registration",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtName.Focus();
				return;
			}
			else if (this.MessageEntity == null)
			{
				MessageBox.Show("Invalid Primary Entity or Secondary Entity specified. Please re-enter the data.",
					"Invalid Entity Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPrimaryEntity.Focus();
				return;
			}
			else if (this.MessageEntity.PrimaryEntity != txtPrimaryEntity.Text && txtPrimaryEntity.Text.Length > 0)
			{
				MessageBox.Show("Invalid Primary Entity specified. Please re-enter the data.",
					"Invalid Entity Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtPrimaryEntity.Focus();
				return;
			}
			else if (this.MessageEntity.SecondaryEntity != txtSecondaryEntity.Text && txtSecondaryEntity.Text.Length > 0)
			{
				MessageBox.Show("Invalid Secondary Entity specified. Please re-enter the data.",
					"Invalid Entity Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtSecondaryEntity.Focus();
				return;
			}
			else if (cmbPlugins.SelectedIndex < 0)
			{
				MessageBox.Show("Plugin was not specified. This a required field.", "Step Registration",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbPlugins.Focus();
				return;
			}
			else if (cmbUsers.SelectedIndex < 0)
			{
				MessageBox.Show("User was not specified. This a required field.", "Step Registration",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmbUsers.Focus();
				return;
			}
			else if (txtName.TextLength == 0)
			{
				txtName.Text = this.GenerateDescription();
			}
			else if (isDeploymentOfflineChecked &&
				txtSecureConfig.TextLength != 0 && txtSecureConfig.Text.Trim().Length != 0)
			{
				MessageBox.Show(this, "Secure Configuration is not supported for Steps deployed Offline.",
					"Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			CrmPlugin plugin = (CrmPlugin)cmbPlugins.SelectedItem;

			if (cmbServiceEndpoint.Visible)
			{
				if ((radModeSync.Checked))
				{
					MessageBox.Show("Only asynchronous steps are supported for Service Endpoint plug-ins.",
						"Step Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if (cmbServiceEndpoint.SelectedIndex < 0)
				{
					MessageBox.Show("Service Endpoint must be selected for Service Endpoint plug-ins.",
						"Step Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			step.MessageId = this.Message.MessageId;
			step.MessageEntityId = this.MessageEntity.MessageEntityId;
			step.AssemblyId = plugin.AssemblyId;
			step.FilteringAttributes = crmFilteringAttributes.Attributes;
			step.PluginId = plugin.PluginId;
			step.ImpersonatingUserId = ((CrmUser)cmbUsers.SelectedItem).UserId;
			step.Name = txtName.Text;
			step.UnsecureConfiguration = txtUnsecureConfiguration.Text;
			step.Description = txtDescription.Text;

			if (txtSecureConfig.Visible)
			{
				step.SecureConfiguration = txtSecureConfig.Text;
			}

			if (cmbServiceEndpoint.Visible)
			{
				step.ServiceBusConfigurationId = ((CrmServiceEndpoint)this.cmbServiceEndpoint.SelectedItem).ServiceEndpointId;
			}
			else
			{
				step.ServiceBusConfigurationId = Guid.Empty;
			}

			step.Rank = int.Parse(txtRank.Text);
			step.Mode = (radModeAsync.Checked ? CrmPluginStepMode.Asynchronous : CrmPluginStepMode.Synchronous);

			if (radStagePreValidation.Checked)
			{
				step.Stage = CrmPluginStepStage.PreValidation;
			}
			else if (radStagePreOperation.Checked)
			{
				step.Stage = CrmPluginStepStage.PreOperation;
			}
			else if (radStagePostOperation.Checked)
			{
				step.Stage = CrmPluginStepStage.PostOperation;
			}
			else if (radStagePostOperationDeprecated.Checked)
			{
				step.Stage = CrmPluginStepStage.PostOperationDeprecated;
			}
			else
			{
				throw new NotImplementedException("Unkown Plug-in Stage checked");
			}

			if (null != this.m_currentStep)
			{
				step.Enabled = this.m_currentStep.Enabled;
			}

			if (isDeploymentServerChecked && isDeploymentOfflineChecked)
			{
				step.Deployment = CrmPluginStepDeployment.Both;
			}
			else if (isDeploymentOfflineChecked)
			{
				step.Deployment = CrmPluginStepDeployment.OfflineOnly;
			}
			else
			{
				step.Deployment = CrmPluginStepDeployment.ServerOnly;
			}

			if (grpInvocation.Enabled)
			{
				step.InvocationSource = (radInvocationParent.Checked ? CrmPluginStepInvocationSource.Parent : CrmPluginStepInvocationSource.Child);
			}
			else
			{
				step.InvocationSource = null;
			}

			if (step.Mode == CrmPluginStepMode.Asynchronous)
			{
				step.DeleteAsyncOperationIfSuccessful = chkDeleteAsyncOperationIfSuccessful.Checked;
			}
			else
			{
				step.DeleteAsyncOperationIfSuccessful = false;
			}

			if (plugin.IsProfilerPlugin)
			{
				step.ProfilerStepId = step.StepId;
				step.UnsecureConfiguration = OrganizationHelper.UpdateWithStandaloneConfiguration(step).ToString();
			}
			else if (null != this.m_currentStep)
			{
				step.ProfilerOriginalStepId = this.m_currentStep.ProfilerOriginalStepId;
				step.ProfilerStepId = this.m_currentStep.ProfilerStepId;
			}
			#endregion

			#region Register the Step
			bool rankChanged = false;
			try
			{
				if (this.m_currentStep != null)
				{
					Guid? secureConfigurationId = this.m_currentStep.SecureConfigurationId;
					if (this.m_currentStep.SecureConfigurationRecordIdInvalid)
					{
						if (this.m_secureConfigurationIdIsInvalid)
						{
							secureConfigurationId = null;
						}
						else
						{
							secureConfigurationId = Guid.Empty;
						}
					}

					// If the message has changed, the images may need to change as well
					List<CrmPluginImage> updateImages = null;
					if (this.m_currentStep.MessageId != step.MessageId)
					{
						// Add the images for the current step to the list
						updateImages = new List<CrmPluginImage>(this.m_currentStep.Images.Count);
						updateImages.AddRange(this.m_currentStep.Images.Values);
					}

					step.StepId = this.m_currentStep.StepId;
					if (!RegistrationHelper.UpdateStep(this.m_org, step, secureConfigurationId, updateImages))
					{
						this.DialogResult = System.Windows.Forms.DialogResult.None;
						return;
					}

					//Refresh the profiler step to have the same settings
					if (step.IsProfiled)
					{
						OrganizationHelper.RefreshProfilerStep(step);
					}

					rankChanged = (this.m_currentStep.Rank != step.Rank);

					this.m_currentStep.SecureConfigurationRecordIdInvalid = this.m_secureConfigurationIdIsInvalid;
					this.m_currentStep.Deployment = step.Deployment;
					this.m_currentStep.Name = step.Name;
					this.m_currentStep.ImpersonatingUserId = step.ImpersonatingUserId;
					this.m_currentStep.InvocationSource = step.InvocationSource;
					this.m_currentStep.MessageEntityId = step.MessageEntityId;
					this.m_currentStep.MessageId = step.MessageId;
					this.m_currentStep.FilteringAttributes = step.FilteringAttributes;
					this.m_currentStep.Mode = step.Mode;
					this.m_currentStep.Rank = step.Rank;
					this.m_currentStep.DeleteAsyncOperationIfSuccessful = step.DeleteAsyncOperationIfSuccessful;
					if (txtSecureConfig.Visible)
					{
						this.m_currentStep.SecureConfiguration = step.SecureConfiguration;
						this.m_currentStep.SecureConfigurationId = step.SecureConfigurationId;
					}
					this.m_currentStep.Stage = step.Stage;
					this.m_currentStep.UnsecureConfiguration = step.UnsecureConfiguration;
					this.m_currentStep.Description = step.Description;
					this.m_currentStep.ProfilerStepId = step.ProfilerStepId;

					List<ICrmEntity> stepList = new List<ICrmEntity>(new ICrmEntity[] { step });
					OrganizationHelper.UpdateDates(this.m_org, stepList);

					if (this.m_currentStep.PluginId != step.PluginId)
					{
						this.m_orgControl.RemoveStep(step.NodeId);
						this.m_org.Assemblies[this.m_currentStep.AssemblyId][this.m_currentStep.PluginId].RemoveStep(step.StepId);

						this.m_currentStep.AssemblyId = step.AssemblyId;
						this.m_currentStep.PluginId = step.PluginId;
						this.m_org.Assemblies[step.AssemblyId][step.PluginId].AddStep(step);
						this.m_orgControl.AddStep(step);
					}
					else if (this.m_currentStep.ServiceBusConfigurationId != step.ServiceBusConfigurationId)
					{
						this.m_orgControl.RemoveStep(step.NodeId);
						this.m_org.Assemblies[this.m_currentStep.AssemblyId][this.m_currentStep.PluginId].RemoveStep(step.StepId);

						this.m_currentStep.ServiceBusConfigurationId = step.ServiceBusConfigurationId;
						this.m_org.Assemblies[step.AssemblyId][step.PluginId].AddStep(step);
						this.m_orgControl.AddStep(step);
					}
					else
					{
						this.m_orgControl.RefreshStep(this.m_currentStep);
					}

					step = this.m_currentStep;


				}
				else
				{
					step.StepId = RegistrationHelper.RegisterStep(this.m_org, step);

					List<ICrmEntity> stepList = new List<ICrmEntity>(new ICrmEntity[] { step });
					OrganizationHelper.UpdateDates(this.m_org, stepList);

					plugin.AddStep(step);
					this.m_orgControl.AddStep(step);
					OrganizationHelper.RefreshStep(m_org, step);
				}
			}
			catch (Exception ex)
			{
				ErrorMessage.ShowErrorMessageBox(this, "Error occurred while registering the step", "Registration Error", ex);
				return;
			}
			#endregion

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void txtMessageName_Validating(object sender, CancelEventArgs e)
		{
			if (txtMessageName.TextLength != 0 && this.Message == null)
			{
				MessageBox.Show("Invalid Message Name specified. Please re-enter the message name",
					"Invalid Message Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				e.Cancel = true;
			}
			else if (this.Message != null)
			{
				this.LoadEntities();
			}
		}

		private void txtRank_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private string m_stepName = string.Empty;
		private void MessageData_TextChanged(object sender, EventArgs e)
		{
			if (this.m_stepName != null)
			{
				this.m_stepName = this.GenerateDescription();
				txtName.Text = this.m_stepName;
			}
		}

		private void MessageEntityData_Leave(object sender, EventArgs e)
		{
			if (this.MessageEntity != null)
			{
				if (!string.Equals(crmFilteringAttributes.EntityName, this.MessageEntity))
				{
					crmFilteringAttributes.EntityName = this.MessageEntity.PrimaryEntity;
				}
			}

			this.CheckDeploymentSupported();
		}

		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if (this.m_stepName != null &&
				!this.m_stepName.Equals(txtName.Text, StringComparison.InvariantCultureIgnoreCase))
			{
				this.m_stepName = this.GenerateDescription();
			}
		}

		private void txtMessageName_Leave(object sender, EventArgs e)
		{
			this.LoadEntities();
			this.CheckAttributesSupported();
		}

		private void txtName_Leave(object sender, EventArgs e)
		{
			if (txtName.TextLength == 0)
			{
				this.m_stepName = string.Empty;
				txtName.Text = this.m_stepName;
			}
		}

		private void radInvocationChild_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.m_stepName != null)
			{
				this.m_stepName = this.GenerateDescription();
				txtName.Text = this.m_stepName;
			}
		}

		private void radInvocationParent_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.m_stepName != null)
			{
				this.m_stepName = this.GenerateDescription();
				txtName.Text = this.m_stepName;
			}
		}

		private void radMode_CheckedChanged(object sender, EventArgs e)
		{
			chkDeleteAsyncOperationIfSuccessful.Enabled = radModeAsync.Checked;
		}

		private void cmbPlugins_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Determine the version of the SDK that this plug-in depends on
			Version sdkVersion;
			CrmPlugin plugin = (CrmPlugin)cmbPlugins.SelectedItem;
			if (null == plugin)
			{
				sdkVersion = null;
			}
			else
			{
				sdkVersion = plugin.Organization.Assemblies[plugin.AssemblyId].SdkVersion;
			}

			//Determine what boxes to enable
			bool enableV4Controls = true;
			bool enable2011Controls = true;
			if (null != sdkVersion)
			{
				switch (sdkVersion.Major)
				{
					case 4:
						enable2011Controls = false;
						break;
					case 5:
						enableV4Controls = false;
						break;
				}
			}

			//Enable the correct controls
			grpInvocation.Enabled = enableV4Controls;
			radStagePreOperation.Enabled = enable2011Controls;
			radStagePostOperation.Enabled = enable2011Controls;
			radStagePostOperationDeprecated.Enabled = enableV4Controls;
		}

		private void lnkInvalidSecureConfigurationId_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "The current value of the secure configuration will be overwritten when this step is saved. Continue?",
					"Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
			{
				return;
			}

			this.m_secureConfigurationIdIsInvalid = false;

			txtSecureConfig.Visible = true;
			txtSecureConfig.Text = null;

			picInvalidSecureConfigurationId.Visible = false;
			lblInvalidSecureConfigurationId.Visible = false;
			lnkInvalidSecureConfigurationId.Visible = false;
		}
		#endregion

		#region Properties
		private string m_messageRetrieved = null;
		private CrmMessage m_message = null;
		public CrmMessage Message
		{
			get
			{
				if (txtMessageName.TextLength != 0)
				{
					string message = txtMessageName.Text.Trim();
					if (!message.Equals(this.m_messageRetrieved, StringComparison.InvariantCultureIgnoreCase))
					{
						this.m_messageRetrieved = message;
						this.m_message = this.m_org.FindMessage(message);

						this.m_messageEntityPrimaryRetrieved = null;
						this.m_messageEntitySecondaryRetrieved = null;
						this.m_messageEntityRetrieved = null;
					}
				}
				else
				{
					this.m_messageRetrieved = null;
					this.m_message = null;
					this.m_messageEntityPrimaryRetrieved = null;
					this.m_messageEntitySecondaryRetrieved = null;
					this.m_messageEntityRetrieved = null;
				}

				return this.m_message;
			}
		}

		private string m_messageEntityPrimaryRetrieved = null;
		private string m_messageEntitySecondaryRetrieved = null;
		private CrmMessageEntity m_messageEntityRetrieved = null;
		public CrmMessageEntity MessageEntity
		{
			get
			{
				if (this.Message != null)
				{
					string primaryEntity = txtPrimaryEntity.Text.Trim();
					if (string.IsNullOrEmpty(primaryEntity))
					{
						primaryEntity = "none";
					}

					string secondaryEntity = txtSecondaryEntity.Text.Trim();
					if (string.IsNullOrEmpty(secondaryEntity))
					{
						secondaryEntity = "none";
					}

					if (!string.Equals(primaryEntity, this.m_messageEntityPrimaryRetrieved, StringComparison.InvariantCultureIgnoreCase) ||
						!string.Equals(secondaryEntity, this.m_messageEntitySecondaryRetrieved, StringComparison.InvariantCultureIgnoreCase))
					{
						this.m_messageEntityPrimaryRetrieved = primaryEntity;
						this.m_messageEntitySecondaryRetrieved = secondaryEntity;
						this.m_messageEntityRetrieved = this.Message.FindMessageEntity(primaryEntity, secondaryEntity);
					}
				}
				else
				{
					this.m_messageEntityPrimaryRetrieved = null;
					this.m_messageEntitySecondaryRetrieved = null;
					this.m_messageEntityRetrieved = null;
				}

				return this.m_messageEntityRetrieved;
			}
		}
		#endregion

		#region Private Helper Methods
		private CrmMessage m_messageLoaded = null;
		private void LoadEntities()
		{
			if (this.m_messageLoaded == this.Message)
			{
				return;
			}
			else
			{
				this.m_messageLoaded = this.Message;
			}

			Control activeControl = this.ActiveControl;

			if (this.Message == null)
			{
				txtPrimaryEntity.AutoCompleteCustomSource = new AutoCompleteStringCollection();
				txtSecondaryEntity.AutoCompleteCustomSource = new AutoCompleteStringCollection();

				if (activeControl != null)
				{
					activeControl.Focus();
				}
				return;
			}
			else
			{
				AutoCompleteStringCollection primaryList = new AutoCompleteStringCollection();
				AutoCompleteStringCollection secondaryList = new AutoCompleteStringCollection();
				foreach (CrmMessageEntity entity in this.Message.FindMessageEntities(null, null))
				{
					if (!string.IsNullOrEmpty(entity.PrimaryEntity))
					{
						primaryList.Add(entity.PrimaryEntity);
					}

					if (!string.IsNullOrEmpty(entity.SecondaryEntity))
					{
						secondaryList.Add(entity.SecondaryEntity);
					}
				}

				txtPrimaryEntity.AutoCompleteCustomSource = primaryList;
				txtSecondaryEntity.AutoCompleteCustomSource = secondaryList;

				if (activeControl != null)
				{
					activeControl.Focus();
				}
			}
		}

		private string GenerateDescription()
		{
			//Retrieve metadata about the filter
			string messageName;
			string primaryEntity = txtPrimaryEntity.Text;
			string secondaryEntity = txtSecondaryEntity.Text;
			if (this.Message == null)
			{
				messageName = txtMessageName.Text;
			}
			else
			{
				messageName = this.Message.Name;

				if (this.MessageEntity != null)
				{
					primaryEntity = this.MessageEntity.PrimaryEntity;
					secondaryEntity = this.MessageEntity.SecondaryEntity;
				}
			}

			//Retrieve the name of the type
			string typeName;
			if (cmbServiceEndpoint.Visible)
			{
				if (null == cmbServiceEndpoint.SelectedItem)
				{
					typeName = null;
				}
				else
				{
					typeName = ((CrmServiceEndpoint)cmbServiceEndpoint.SelectedItem).Name;
				}
			}
			else
			{
				if (null == cmbPlugins.SelectedItem)
				{
					typeName = null;
				}
				else
				{
					CrmPlugin plugin = ((CrmPlugin)cmbPlugins.SelectedItem);
					if (plugin.IsProfilerPlugin)
					{
						typeName = "Plug-in Profiler";
					}
					else
					{
						typeName = ((CrmPlugin)cmbPlugins.SelectedItem).TypeName;
					}
				}
			}

			return RegistrationHelper.GenerateStepDescription(typeName, messageName, primaryEntity, secondaryEntity);
		}

		private void CheckAttributesSupported()
		{
			//Check if we should disable the message
			if (null != this.Message && !this.Message.SupportsFilteredAttributes)
			{
				crmFilteringAttributes.Enabled = false;
				crmFilteringAttributes.DisabledMessage = "Message does not support Filtered Attributes";
			}
			else
			{
				crmFilteringAttributes.Enabled = true;
				crmFilteringAttributes.DisabledMessage = null;
			}
		}

		private void CheckDeploymentSupported()
		{
			if (this.MessageEntity == null)
			{
				chkDeploymentOffline.Enabled = true;
				chkDeploymentServer.Enabled = true;
			}
			else
			{
				switch (this.MessageEntity.Availability)
				{
					case CrmPluginStepDeployment.OfflineOnly:
						chkDeploymentOffline.Enabled = true;
						chkDeploymentServer.Enabled = false;
						break;
					case CrmPluginStepDeployment.ServerOnly:
						chkDeploymentOffline.Enabled = false;
						chkDeploymentServer.Enabled = true;
						break;
					case CrmPluginStepDeployment.Both:
						chkDeploymentOffline.Enabled = true;
						chkDeploymentServer.Enabled = true;
						break;
					default:
						throw new NotImplementedException("CrmPluginStepDeployment = " + this.MessageEntity.Availability);
				}
			}
		}
		#endregion
	}
}