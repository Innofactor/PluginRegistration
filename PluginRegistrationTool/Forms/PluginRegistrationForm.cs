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
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using CrmSdk;
    using Microsoft.Xrm.Sdk;
    using PluginRegistrationTool.Controls;
    using PluginRegistrationTool.Helpers;
    using PluginRegistrationTool.Wrappers;

	public partial class PluginRegistrationForm : Form
	{
		private CrmOrganization m_org;
		private string m_lastAssemblyFileName;
		private CrmPluginAssembly m_currentAssembly;
		private OrganizationControl m_orgControl;
		private ProgressIndicator m_progRegistration;
		private Dictionary<string, Guid> m_typeIdList;
		private bool m_assemblyLoaded = false;

		public PluginRegistrationForm(CrmOrganization org, OrganizationControl orgControl, CrmPluginAssembly assembly)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}
			else if (orgControl == null)
			{
				throw new ArgumentNullException("orgControl");
			}

			InitializeComponent();

			this.m_org = org;
			this.m_orgControl = orgControl;
			this.m_progRegistration = new ProgressIndicator(this.ProgressIndicatorInit, this.ProgressIndicatorComplete,
				this.ProgressIndicatorAddText, this.ProgressIndicatorSetText,
				this.ProgressIndicatorIncrement, null);
			this.m_currentAssembly = assembly;

			trvPlugins.CrmTreeNodeSorter = orgControl.CrmTreeNodeSorter;

			//Check if this is a known assembly
			if (null == assembly)
			{
				//If this is a known assembly, check for the default isolation mode for each authentication type
				if (null != org.ConnectionDetail)
				{
                    // TODO: Come back
                    //switch (org.ConnectionDetail.GetDiscoveryService().ServiceConfiguration.AuthenticationType)
                    //{
                    //    case Microsoft.Xrm.Sdk.Client.AuthenticationProviderType.ActiveDirectory:
                    //        radIsolationNone.Checked = true;
                    //        break;
                    //    default:
                    //        radIsolationSandbox.Checked = true;
                    //        break;
                    //}
				}
			}
			else
			{
				this.m_typeIdList = new Dictionary<string, Guid>();

				LoadAssembly(assembly, false);

				switch (assembly.IsolationMode)
				{
					case CrmAssemblyIsolationMode.Sandbox:
						radIsolationSandbox.Checked = true;
						break;
					case CrmAssemblyIsolationMode.None:
						radIsolationNone.Checked = true;
						break;
					default:
						throw new NotImplementedException("IsolationMode = " + assembly.IsolationMode.ToString());
				}

				switch (assembly.SourceType)
				{
					case CrmAssemblySourceType.Database:
						radDB.Checked = true;
						break;
					case CrmAssemblySourceType.Disk:
						radDisk.Checked = true;
						break;
					case CrmAssemblySourceType.GAC:
						radGAC.Checked = true;
						break;
					default:
						throw new NotImplementedException("SourceType = " + assembly.SourceType.ToString());
				}

				txtServerFileName.Text = assembly.ServerFileName;

				this.Text = string.Format("Update Assembly: {0}", assembly.Name);
				btnRegister.Text = "Update Selected Plugins";
			}

			this.EnableRegistrationControls();
		}

		#region Control Events
		private void AssemblyPathControl_BrowseCompleted(object sender, EventArgs e)
		{
			btnLoadAssembly.PerformClick();
		}

		private void AssemblyPathControl_PathChanged(object sender, EventArgs e)
		{
			btnLoadAssembly.Enabled = AssemblyPathControl.HasFileName;
			this.EnableRegistrationControls();

			if (AssemblyPathControl.FileExists)
			{
				string fileName = Path.GetFileName(AssemblyPathControl.FileName);

				//Only want to change the server file name if it is the same as the assembly's file name
				//If it isn't, then the user changed the file name
				if (txtServerFileName.TextLength == 0 || string.Equals(txtServerFileName.Text, this.m_lastAssemblyFileName))
				{
					txtServerFileName.Text = fileName;
				}

				this.m_lastAssemblyFileName = fileName;
			}
		}

		private void btnLoadAssembly_Click(object sender, EventArgs e)
		{
			if (!AssemblyPathControl.FileExists)
			{
				MessageBox.Show("Error: Unable to locate the specified file. Please ensure that it exists",
					"Plugin Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//Load the assembly
			CrmPluginAssembly assembly;
			try
			{
				assembly = RegistrationHelper.RetrievePluginsFromAssembly(AssemblyPathControl.FileName);
			}
			catch (Exception ex)
			{
				ErrorMessageForm.ShowErrorMessageBox(this, "Unable to load the specified Plugin Assembly", "Plugins", ex);
				return;
			}

			LoadAssembly(assembly, true);

			//Mark the assembly as having been loaded
			this.m_assemblyLoaded = true;
			this.chkUpdateAssembly.Checked = true;
			if (null != this.m_currentAssembly)
			{
				chkUpdateAssembly.Visible = true;
			}

			//Enable the controls
			this.EnableRegistrationControls();
		}

		private void chkSelectAll_Click(object sender, EventArgs e)
		{
			trvPlugins.CheckAllNodes(chkSelectAll.Checked);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			const string ERROR_CAPTION = "Registration Error";
			string ERROR_MESSAGE;
			if (this.m_currentAssembly == null)
			{
				ERROR_MESSAGE = "There was an error while registering the selected plugins. Please check the Registration Log for more information.";
			}
			else
			{
				ERROR_MESSAGE = "There was an error while updating the selected plugins. Please check the Registration Log for more information.";
			}

			#region Extract Plugin Registration Information
			this.m_progRegistration.Complete(true); //Just in case it has incorrect information

			//Determine the source type. If we are talking about an assembly on disk, verify that it exists
			if (GetAssemblySourceType() == CrmAssemblySourceType.Disk)
			{
				if (string.IsNullOrEmpty(txtServerFileName.Text.Trim()))
				{
					MessageBox.Show("If the Registration Location is Disk, the \"File Name on Server\" must be specified",
						"Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					this.m_progRegistration.Complete(false);
					return;
				}
			}

			//Create a list of currently selected plugins
			bool assemblyCanBeIsolated = true;
			Dictionary<string, CrmPlugin> checkedPluginList = new Dictionary<string, CrmPlugin>();
			foreach (ICrmTreeNode node in trvPlugins.CheckedNodes)
			{
				if (node.NodeType == CrmTreeNodeType.Plugin || node.NodeType == CrmTreeNodeType.WorkflowActivity)
				{
					CrmPlugin plugin = (CrmPlugin)node;
					if (CrmPluginIsolatable.No == plugin.Isolatable)
					{
						assemblyCanBeIsolated = false;
					}

					checkedPluginList.Add(plugin.TypeName, plugin);
				}
			}

			//Check if there are any plugins selected
			if (checkedPluginList.Count == 0)
			{
				MessageBox.Show("No plugins have been selected from the list. Please select at least one and try again.",
					"No Plugins Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//Verify that a valid isolation mode has been selected
			if (radIsolationSandbox.Checked && !assemblyCanBeIsolated)
			{
				MessageBox.Show("Since some of the plug-ins cannot be isolated, the assembly cannot be marked as Isolated.",
					"Isolation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			//Reload the assembly
			string assemblyPath = AssemblyPathControl.FileName;
			CrmPluginAssembly assembly;
			if (string.IsNullOrEmpty(assemblyPath))
			{
				//Clone the existing assembly
				assembly = (CrmPluginAssembly)this.m_currentAssembly.Clone(false);
			}
			else
			{
				assembly = RegistrationHelper.RetrievePluginsFromAssembly(assemblyPath);

				//Retrieve the source type and determine if the 
				assembly.SourceType = GetAssemblySourceType();
				if (CrmAssemblySourceType.Disk != assembly.SourceType)
				{
					assembly.ServerFileName = null;
				}
				else
				{
					assembly.ServerFileName = txtServerFileName.Text;
				}
			}

			//Ensure the checked items were all found in the assembly
			List<CrmPlugin> registerPluginList = new List<CrmPlugin>();
			List<CrmPlugin> pluginList = new List<CrmPlugin>();
			List<CrmPlugin> removedList = new List<CrmPlugin>();
			try
			{
				foreach (CrmPlugin reg in assembly.Plugins.Values)
				{
					bool alreadyExisted = (this.m_typeIdList != null && this.m_typeIdList.ContainsKey(reg.TypeName.ToLowerInvariant()));

					if (alreadyExisted)
					{
						reg.AssemblyId = this.m_currentAssembly.AssemblyId;
						reg.PluginId = this.m_typeIdList[reg.TypeName.ToLowerInvariant()];
					}

					if (checkedPluginList.ContainsKey(reg.TypeName))
					{
						registerPluginList.Add(reg);

						if (reg.PluginType == CrmPluginType.Plugin)
						{
							pluginList.Add(reg);
						}
					}
					else if (alreadyExisted)
					{
						removedList.Add(reg);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorMessageForm.ShowErrorMessageBox(this, "Unable to load the specified Plugin Assembly", "Plugins", ex);
				return;
			}

			//Update the assembly with the information specified by the user
			assembly.IsolationMode = GetIsolationMode();

			//An assembly with plugins must be strongly signed
			if (pluginList.Count != 0)
			{
				if (string.IsNullOrEmpty(assembly.PublicKeyToken))
				{
					MessageBox.Show("Assemblies containing Plugins must be strongly signed. Sign the Assembly using a KeyFile.",
						"Strong Names Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			//Check if there are any plugins selected that were in the assembly.
			if (registerPluginList.Count == 0)
			{
				MessageBox.Show("No plugins have been selected from the list. Please select at least one and try again.",
					"No Plugins Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				assembly.ClearPlugins();
			}

			//If we are doing an Update, do some special processing
			if (this.m_currentAssembly != null)
			{
				assembly.AssemblyId = this.m_currentAssembly.AssemblyId;
			}
			#endregion

			#region Register Plugin
			this.m_progRegistration.Initialize(registerPluginList.Count +
				removedList.Count, "Preparing Registration");

			int registeredAssemblies = 0;
			int ignoredAssemblies = 0;
			int updatedAssemblies = 0;
			bool createAssembly;

			//Check whether the plugin exists. If it exists, should we use the existing one?
			List<ICrmEntity> retrieveDateList = new List<ICrmEntity>();
			try
			{
				Guid pluginAssemblyId = Guid.Empty;
				if (this.m_currentAssembly != null)
				{
					if (chkUpdateAssembly.Checked)
					{
						string originalGroupName = RegistrationHelper.GenerateDefaultGroupName(
							this.m_currentAssembly.Name, new Version(this.m_currentAssembly.Version));
						string newGroupName = RegistrationHelper.GenerateDefaultGroupName(assembly.Name, new Version(assembly.Version));

						List<PluginType> updateGroupNameList = new List<PluginType>();
						foreach (CrmPlugin plugin in this.m_currentAssembly.Plugins)
						{
							if (plugin.PluginType == CrmPluginType.WorkflowActivity &&
								string.Equals(plugin.WorkflowActivityGroupName, originalGroupName))
							{
								updateGroupNameList.Add(new PluginType()
								{
									Id = plugin.PluginId,
									WorkflowActivityGroupName = newGroupName
								});
							}
						}

						//Do the actual update to the assembly
						RegistrationHelper.UpdateAssembly(this.m_org, assemblyPath, assembly, updateGroupNameList.ToArray());

						this.m_currentAssembly.Name = assembly.Name;
						this.m_currentAssembly.Culture = assembly.Culture;
						this.m_currentAssembly.CustomizationLevel = assembly.CustomizationLevel;
						this.m_currentAssembly.PublicKeyToken = assembly.PublicKeyToken;
						this.m_currentAssembly.ServerFileName = assembly.ServerFileName;
						this.m_currentAssembly.SourceType = assembly.SourceType;
						this.m_currentAssembly.Version = assembly.Version;
						this.m_currentAssembly.IsolationMode = assembly.IsolationMode;

						retrieveDateList.Add(this.m_currentAssembly);

						foreach (PluginType type in updateGroupNameList)
						{
							CrmPlugin plugin = this.m_currentAssembly.Plugins[type.Id];

							plugin.WorkflowActivityGroupName = type.WorkflowActivityGroupName;
							retrieveDateList.Add(plugin);
						}

						updatedAssemblies++;
					}
					else if (!chkUpdateAssembly.Visible && assembly.IsolationMode != this.m_currentAssembly.IsolationMode)
					{
						PluginAssembly updateAssembly = new PluginAssembly()
						{
							Id = assembly.AssemblyId,
							IsolationMode = new OptionSetValue((int)assembly.IsolationMode)
						};

						this.m_org.OrganizationService.Update(updateAssembly);

						this.m_currentAssembly.ServerFileName = assembly.ServerFileName;
						this.m_currentAssembly.SourceType = assembly.SourceType;
						this.m_currentAssembly.IsolationMode = assembly.IsolationMode;

						retrieveDateList.Add(this.m_currentAssembly);

						updatedAssemblies++;
					}

					assembly = this.m_currentAssembly;

					createAssembly = false;
					this.m_progRegistration.Increment();

					this.m_orgControl.RefreshAssembly(this.m_currentAssembly, false);
				}
				else
				{
					createAssembly = true;
					this.m_progRegistration.Increment();
				}
			}
			catch (Exception ex)
			{
				this.m_progRegistration.Increment("ERROR: Occurred while checking whether the assembly exists");

				ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

				this.m_progRegistration.Complete(false);
				return;
			}

			//Register the assembly (if needed)
			if (createAssembly)
			{
				try
				{
					assembly.AssemblyId = RegistrationHelper.RegisterAssembly(this.m_org, assemblyPath, assembly);
					assembly.Organization = this.m_org;

					retrieveDateList.Add(assembly);
				}
				catch (Exception ex)
				{
					this.m_progRegistration.Increment("ERROR: Error occurred while registering the assembly");

					ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

					this.m_progRegistration.Complete(false);
					return;
				}

				registeredAssemblies++;
				this.m_progRegistration.Increment("SUCCESS: Plugin Assembly was registered");
			}
			else if (this.m_currentAssembly == null)
			{
				ignoredAssemblies++;
				this.m_progRegistration.Increment("INFORMATION: Assembly was not registered");
			}
			else
			{
				if (chkUpdateAssembly.Checked)
				{
					this.m_progRegistration.Increment("SUCCESS: Assembly was updated");
				}
				else
				{
					this.m_progRegistration.Increment("INFORMATION: Assembly was not updated");
				}
			}

			//Check to see if the assembly needs to be added to the list
			if (!this.m_org.Assemblies.ContainsKey(assembly.AssemblyId))
			{
				this.m_org.AddAssembly(assembly);

				//Update the Main Form
				try
				{
					this.m_orgControl.AddAssembly(assembly);
					this.m_progRegistration.Increment();
				}
				catch (Exception ex)
				{
					this.m_progRegistration.Increment("ERROR: Error occurred while updating the Main form for the assembly");

					ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

					this.m_progRegistration.Complete(false);
					return;
				}
			}
			else
			{
				this.m_progRegistration.Increment();
			}

			// Register the Plugin
			bool createPlugin;
			int registeredPlugins = 0;
			int ignoredPlugins = 0;
			int errorsPlugins = 0;
			foreach (CrmPlugin reg in registerPluginList)
			{
				reg.AssemblyId = assembly.AssemblyId;

				//Check if the plugin exists
				bool pluginUpdate = this.m_typeIdList != null && this.m_typeIdList.ContainsKey(reg.TypeName.ToLowerInvariant());
				try
				{
					Guid pluginTypeId = Guid.Empty;

					if (pluginUpdate || (!createAssembly && RegistrationHelper.PluginExists(this.m_org, reg.TypeName, assembly.AssemblyId, out pluginTypeId)))
					{
						if (pluginUpdate)
						{
							createPlugin = false;
						}
						else
						{
							this.m_progRegistration.AppendText(string.Format("INFORMATION: Plugin Type Name is already being used by PluginType {0}.",
								pluginTypeId));

							switch (MessageBox.Show(string.Format("The specified name \"{0}\" is already registered. Skip the registration of this plugin?\n\nPlease note the plugins may not be the same.", reg.TypeName),
								"Plugin Already Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
							{
								case DialogResult.Yes:
									createPlugin = false;

									reg.PluginId = pluginTypeId;
									reg.Organization = assembly.Organization;
									break;
								case DialogResult.No:
									createPlugin = true;
									break;
								case DialogResult.Cancel:
									this.m_progRegistration.AppendText("ABORTED: Plugin Registration has been aborted by the user.");
									this.m_progRegistration.Complete(false);
									return;
								default:
									throw new NotImplementedException();
							}
						}

						this.m_progRegistration.Increment();
					}
					else
					{
						createPlugin = true;
						this.m_progRegistration.Increment();
					}
				}
				catch (Exception ex)
				{
					this.m_progRegistration.Increment(string.Format("ERROR: Occurred while checking if {0} is already registered.",
						reg.TypeName));

					ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

					this.m_progRegistration.Complete(false);
					return;
				}

				//Create the plugin (if necessary)
				if (createPlugin)
				{
					try
					{
						Guid pluginId = reg.PluginId;
						reg.PluginId = RegistrationHelper.RegisterPlugin(this.m_org, reg);
						reg.Organization = this.m_org;

						if (pluginId != reg.PluginId && assembly.Plugins.ContainsKey(pluginId))
						{
							assembly.RemovePlugin(pluginId);
						}

						retrieveDateList.Add(reg);

						this.m_progRegistration.Increment(string.Format("SUCCESS: Plugin {0} was registered.",
							reg.TypeName));

						registeredPlugins++;
					}
					catch (Exception ex)
					{
						this.m_progRegistration.Increment(2, string.Format("ERROR: Occurred while registering {0}.",
							reg.TypeName));

						ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

						errorsPlugins++;
						continue;
					}
				}
				else
				{
					if (!pluginUpdate)
					{
						ignoredPlugins++;
					}

					this.m_progRegistration.Increment();
				}

				//Check if the plugin needs to be added to the list
				if (!assembly.Plugins.ContainsKey(reg.PluginId))
				{
					assembly.AddPlugin(reg);

					//Update the main form
					try
					{
						this.m_orgControl.AddPlugin(reg);
						this.m_progRegistration.Increment();
					}
					catch (Exception ex)
					{
						this.m_progRegistration.Increment(string.Format("ERROR: Occurred while updating the Main form for {0}.",
							reg.TypeName));

						ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

						this.m_progRegistration.Complete(false);
						return;
					}
				}
				else
				{
					this.m_progRegistration.Increment();
				}
			}

			// Unregister plugins that were unchecked
			int updatedPlugins = 0;
			foreach (CrmPlugin reg in removedList)
			{
				//Check if the plugin exists
				try
				{
					RegistrationHelper.Unregister(this.m_org, reg);
					this.m_progRegistration.Increment(3, string.Format("SUCCESS: Plugin {0} was unregistered.",
						reg.TypeName));
					this.m_orgControl.RemovePlugin(reg.PluginId);

					updatedPlugins++;
				}
				catch (Exception ex)
				{
					this.m_progRegistration.Increment(3, string.Format("ERROR: Occurred while unregistering {0}.",
						reg.TypeName));

					ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

					errorsPlugins++;
				}
			}

			//Update the entities whose Created On / Modified On dates changed
			try
			{
				OrganizationHelper.UpdateDates(this.m_org, retrieveDateList);
				this.m_progRegistration.Increment("SUCCESS: Created On / Modified On dates updated");
			}
			catch (Exception ex)
			{
				this.m_progRegistration.Increment("ERROR: Unable to update Created On / Modified On dates");

				ErrorMessageForm.ShowErrorMessageBox(this, "Unable to update Created On / Modified On dates", "Update Error", ex);
			}
			#endregion

			this.m_progRegistration.AppendText("SUCCESS: Selected Plugins have been registered");
			this.m_progRegistration.Complete(false);

			MessageBox.Show(string.Format("The selected Plugins have been registered.\n{0} Assembly Registered\n{1} Assembly Ignored\n{2} Assembly Updated\n{3} Plugin(s) Registered\n{4} Plugin(s) Ignored\n{5} Plugin(s) Encountered Errors\n{6} Plugin(s) Removed",
				registeredAssemblies, ignoredAssemblies, updatedAssemblies, registeredPlugins, ignoredPlugins, errorsPlugins, updatedPlugins),
				"Registered Plugins", MessageBoxButtons.OK, MessageBoxIcon.Information);

			if (errorsPlugins == 0)
			{
				this.Close();
			}
		}

		private void radDisk_CheckedChanged(object sender, EventArgs e)
		{
			lblServerFileName.Enabled = radDisk.Checked;
			txtServerFileName.Enabled = radDisk.Checked;
		}

		private void trvPlugins_CheckStateChanged(object sender, CrmTreeNodeEventArgs e)
		{
			chkSelectAll.Checked = trvPlugins.AllNodesChecked;
		}
		#endregion

		#region Helper Methods
		private void EnableRegistrationControls()
		{
			//Check if there are any nodes in the tree. If there are, the assembly must have been loaded or it is an update
			if (this.m_assemblyLoaded)
			{
				btnRegister.Enabled = true;
				grpRegLoc.Enabled = true;
			}
			else if (null != this.m_currentAssembly)
			{
				btnRegister.Enabled = true;
				grpRegLoc.Enabled = false;
			}
			else
			{
				btnRegister.Enabled = false;
				grpRegLoc.Enabled = true;
			}
		}

		private CrmAssemblyIsolationMode GetIsolationMode()
		{
			if (radIsolationNone.Checked)
			{
				return CrmAssemblyIsolationMode.None;
			}
			else if (radIsolationSandbox.Checked)
			{
				return CrmAssemblyIsolationMode.Sandbox;
			}
			else
			{
				throw new NotImplementedException("Unknown Isolation Mode");
			}
		}

		private CrmAssemblySourceType GetAssemblySourceType()
		{
			if (radDB.Checked)
			{
				return CrmAssemblySourceType.Database;
			}
			else if (radDisk.Checked)
			{
				return CrmAssemblySourceType.Disk;
			}
			else if (radGAC.Checked)
			{
				return CrmAssemblySourceType.GAC;
			}
			else
			{
				throw new NotImplementedException("Unknown Source Type");
			}
		}

		private void LoadAssembly(CrmPluginAssembly assembly, bool checkExisting)
		{
			bool loadTypeId = (this.m_currentAssembly != null && !checkExisting && this.m_typeIdList != null);
			bool checkRecord = (checkExisting && this.m_currentAssembly != null && this.m_typeIdList != null);

			//Loop through and add the data to the form
			trvPlugins.LoadNodes(new ICrmTreeNode[] { assembly });

			foreach (CrmPlugin reg in assembly.Plugins.Values)
			{
				if (loadTypeId && !this.m_typeIdList.ContainsKey(reg.TypeName))
				{
					this.m_typeIdList.Add(reg.TypeName.ToLowerInvariant(), reg.PluginId);
				}

				if (!checkRecord || this.m_typeIdList.ContainsKey(reg.TypeName.ToLowerInvariant()))
				{
					trvPlugins.CheckNode(reg.PluginId, true);
				}
				else
				{
					trvPlugins.CheckNode(reg.PluginId, false);
					chkSelectAll.Checked = false;
				}
			}
		}
		#endregion

		#region ProgressIndicator Implementation
		private void ProgressIndicatorInit(int min, int pluginCount, int initialValue)
		{
			const int STEPS_REGISTRATION_SETUP = 0;
			const int STEPS_REGISTRATION_ASSEMBLY = 3;
			const int STEPS_REGISTRATION_PLUGIN = 3;
			const int STEPS_REGISTRATION_FINAL = 1;

			//Total number of plugin steps:
			//- Initial Steps
			int totalSteps = STEPS_REGISTRATION_SETUP +

				//- Check Each Assembly Exist
				//- Register Each Assembly
				//- Update Main Form
				STEPS_REGISTRATION_ASSEMBLY +

				//- Check Each Plugin Exist
				//- Register Each Plugin (or Skip) 
				//- Update Main Form
				(STEPS_REGISTRATION_PLUGIN * pluginCount) +

				//- Final Steps
				STEPS_REGISTRATION_FINAL;

			if (totalSteps <= 0)
			{
				this.m_progRegistration.ClearText();
				return;
			}

			//Update the progress bar
			barRegistration.Minimum = min;
			barRegistration.Value = initialValue;
			barRegistration.Maximum = totalSteps;
			txtProgress.Clear();

			grpPath.Enabled = false;
			grpPlugins.Enabled = false;
			grpIsolationMode.Enabled = false;
			grpRegLoc.Enabled = false;
			btnRegister.Enabled = false;
			btnCancel.Enabled = false;
		}

		private void ProgressIndicatorIncrement(int value)
		{
			barRegistration.Value += value;
		}

		private void ProgressIndicatorAddText(string message)
		{
			if (txtProgress.TextLength == 0)
			{
				txtProgress.Text = message;
			}
			else
			{
				txtProgress.AppendText(string.Format("\r\n{0}", message));
			}

			txtProgress.SelectionStart = txtProgress.TextLength;
			txtProgress.SelectionLength = 0;
		}

		private void ProgressIndicatorSetText(string message)
		{
			txtProgress.Text = message;
		}

		private void ProgressIndicatorComplete()
		{
			grpPath.Enabled = true;
			grpPlugins.Enabled = true;
			grpIsolationMode.Enabled = true;
			grpRegLoc.Enabled = true;
			this.EnableRegistrationControls();
			btnCancel.Enabled = true;

			barRegistration.Value = barRegistration.Minimum;
		}
		#endregion
	}
}
