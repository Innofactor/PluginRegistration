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
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using Microsoft.Xrm.Sdk;
    using Xrm.Sdk.PluginRegistration.Controls;
    using Entities;
    using Xrm.Sdk.PluginRegistration.Helpers;
    using Wrappers;
    using System.Threading.Tasks;

    public partial class PluginRegistrationForm : Form
    {
        private CrmOrganization m_org;
        private string m_lastAssemblyFileName;
        private CrmPluginAssembly m_currentAssembly;
        private MainControl m_orgControl;
        private ProgressIndicator m_progRegistration;
        private List<CrmPlugin> m_registeredPluginList;
        private bool m_assemblyLoaded = false;

        public PluginRegistrationForm(CrmOrganization org, MainControl orgControl, CrmPluginAssembly assembly)
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

            m_org = org;
            m_orgControl = orgControl;
            m_progRegistration = new ProgressIndicator(ProgressIndicatorInit, ProgressIndicatorComplete,
                ProgressIndicatorAddText, ProgressIndicatorSetText,
                ProgressIndicatorIncrement, null);
            m_currentAssembly = assembly;

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
                m_registeredPluginList = new List<CrmPlugin>();

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

                Text = string.Format("Update Assembly: {0}", assembly.Name);
                btnRegister.Text = "Update Selected Plugins";
            }

            EnableRegistrationControls();
        }

        #region Control Events
        private void AssemblyPathControl_BrowseCompleted(object sender, EventArgs e)
        {
            btnLoadAssembly.PerformClick();
        }

        private void AssemblyPathControl_PathChanged(object sender, EventArgs e)
        {
            btnLoadAssembly.Enabled = AssemblyPathControl.HasFileName;
            EnableRegistrationControls();

            if (AssemblyPathControl.FileExists)
            {
                string fileName = Path.GetFileName(AssemblyPathControl.FileName);

                //Only want to change the server file name if it is the same as the assembly's file name
                //If it isn't, then the user changed the file name
                if (txtServerFileName.TextLength == 0 || string.Equals(txtServerFileName.Text, m_lastAssemblyFileName))
                {
                    txtServerFileName.Text = fileName;
                }

                m_lastAssemblyFileName = fileName;
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
            m_assemblyLoaded = true;
            chkUpdateAssembly.Checked = true;
            if (null != m_currentAssembly)
            {
                chkUpdateAssembly.Visible = true;
            }

            //Enable the controls
            EnableRegistrationControls();
        }

        private void chkSelectAll_Click(object sender, EventArgs e)
        {
            trvPlugins.CheckAllNodes(chkSelectAll.Checked);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            const string ERROR_CAPTION = "Registration Error";
            string ERROR_MESSAGE;
            if (m_currentAssembly == null)
            {
                ERROR_MESSAGE = "There was an error while registering the selected plugins. Please check the Registration Log for more information.";
            }
            else
            {
                ERROR_MESSAGE = "There was an error while updating the selected plugins. Please check the Registration Log for more information.";
            }

            #region Extract Plugin Registration Information
            m_progRegistration.Complete(true); //Just in case it has incorrect information

            //Determine the source type. If we are talking about an assembly on disk, verify that it exists
            if (GetAssemblySourceType() == CrmAssemblySourceType.Disk)
            {
                if (string.IsNullOrEmpty(txtServerFileName.Text.Trim()))
                {
                    MessageBox.Show("If the Registration Location is Disk, the \"File Name on Server\" must be specified",
                        "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    m_progRegistration.Complete(false);
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
                assembly = (CrmPluginAssembly)m_currentAssembly.Clone(false);
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

            // Ensure the checked items were all found in the assembly
            var registerPluginList = new List<CrmPlugin>();
            var pluginList = new List<CrmPlugin>();
            var removedPluginList = new List<CrmPlugin>();
            var missingPluginList = new List<CrmPlugin>();

            try
            {
                Parallel.ForEach(assembly.Plugins.Values, (currentPlugin) => {
                    var foundPlugin = m_registeredPluginList.Where(x => x.TypeName.ToLowerInvariant() == currentPlugin.TypeName.ToLowerInvariant()).FirstOrDefault();
                    var alreadyExisted = (m_registeredPluginList != null && foundPlugin != null);

                    if (alreadyExisted)
                    {
                        currentPlugin.AssemblyId = m_currentAssembly.AssemblyId;
                        currentPlugin.PluginId = foundPlugin.PluginId;
                    }

                    if (checkedPluginList.ContainsKey(currentPlugin.TypeName))
                    {
                        registerPluginList.Add(currentPlugin);

                        if (currentPlugin.PluginType == CrmPluginType.Plugin)
                        {
                            pluginList.Add(currentPlugin);
                        }
                    }
                    else if (alreadyExisted)
                    {
                        removedPluginList.Add(currentPlugin);
                    }
                });

                if (m_registeredPluginList != null)
                {
                    Parallel.ForEach(m_registeredPluginList, (currentRecord) => {
                        if (!assembly.Plugins.Values.ToList().Any(x => x.TypeName.ToLowerInvariant() == currentRecord.TypeName.ToLowerInvariant()))
                        {
                            ;
                        }
                    });
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
            if (m_currentAssembly != null)
            {
                assembly.AssemblyId = m_currentAssembly.AssemblyId;
            }
            #endregion

            #region Register Plugin
            m_progRegistration.Initialize(registerPluginList.Count + removedPluginList.Count, "Preparing Registration");

            int registeredAssemblies = 0;
            int ignoredAssemblies = 0;
            int updatedAssemblies = 0;
            bool createAssembly;

            //Check whether the plugin exists. If it exists, should we use the existing one?
            var retrieveDateList = new List<ICrmEntity>();
            try
            {
                Guid pluginAssemblyId = Guid.Empty;
                if (m_currentAssembly != null)
                {
                    if (chkUpdateAssembly.Checked)
                    {
                        string originalGroupName = RegistrationHelper.GenerateDefaultGroupName(m_currentAssembly.Name, new Version(m_currentAssembly.Version));
                        string newGroupName = RegistrationHelper.GenerateDefaultGroupName(assembly.Name, new Version(assembly.Version));

                        var updateGroupNameList = new List<PluginType>();
                        foreach (var plugin in m_currentAssembly.Plugins)
                        {
                            if (plugin.PluginType == CrmPluginType.WorkflowActivity && string.Equals(plugin.WorkflowActivityGroupName, originalGroupName))
                            {
                                updateGroupNameList.Add(new PluginType()
                                {
                                    Id = plugin.PluginId,
                                    WorkflowActivityGroupName = newGroupName
                                });
                            }
                        }

                        //Do the actual update to the assembly
                        RegistrationHelper.UpdateAssembly(m_org, assemblyPath, assembly, updateGroupNameList.ToArray());

                        m_currentAssembly.Name = assembly.Name;
                        m_currentAssembly.Culture = assembly.Culture;
                        m_currentAssembly.CustomizationLevel = assembly.CustomizationLevel;
                        m_currentAssembly.PublicKeyToken = assembly.PublicKeyToken;
                        m_currentAssembly.ServerFileName = assembly.ServerFileName;
                        m_currentAssembly.SourceType = assembly.SourceType;
                        m_currentAssembly.Version = assembly.Version;
                        m_currentAssembly.IsolationMode = assembly.IsolationMode;

                        retrieveDateList.Add(m_currentAssembly);

                        foreach (var type in updateGroupNameList)
                        {
                            var plugin = m_currentAssembly.Plugins[type.Id];

                            plugin.WorkflowActivityGroupName = type.WorkflowActivityGroupName;
                            retrieveDateList.Add(plugin);
                        }

                        updatedAssemblies++;
                    }
                    else if (!chkUpdateAssembly.Visible && assembly.IsolationMode != m_currentAssembly.IsolationMode)
                    {
                        var updateAssembly = new PluginAssembly()
                        {
                            Id = assembly.AssemblyId,
                            IsolationMode = new OptionSetValue((int)assembly.IsolationMode)
                        };

                        m_org.OrganizationService.Update(updateAssembly);

                        m_currentAssembly.ServerFileName = assembly.ServerFileName;
                        m_currentAssembly.SourceType = assembly.SourceType;
                        m_currentAssembly.IsolationMode = assembly.IsolationMode;

                        retrieveDateList.Add(m_currentAssembly);

                        updatedAssemblies++;
                    }

                    assembly = m_currentAssembly;

                    createAssembly = false;
                    m_progRegistration.Increment();

                    m_orgControl.RefreshAssembly(m_currentAssembly, false);
                }
                else
                {
                    createAssembly = true;
                    m_progRegistration.Increment();
                }
            }
            catch (Exception ex)
            {
                m_progRegistration.Increment("ERROR: Occurred while checking whether the assembly exists");

                ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                m_progRegistration.Complete(false);
                return;
            }

            //Register the assembly (if needed)
            if (createAssembly)
            {
                try
                {
                    assembly.AssemblyId = RegistrationHelper.RegisterAssembly(m_org, assemblyPath, assembly);
                    assembly.Organization = m_org;

                    retrieveDateList.Add(assembly);
                }
                catch (Exception ex)
                {
                    m_progRegistration.Increment("ERROR: Error occurred while registering the assembly");

                    ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                    m_progRegistration.Complete(false);
                    return;
                }

                registeredAssemblies++;
                m_progRegistration.Increment("SUCCESS: Plugin Assembly was registered");
            }
            else if (m_currentAssembly == null)
            {
                ignoredAssemblies++;
                m_progRegistration.Increment("INFORMATION: Assembly was not registered");
            }
            else
            {
                if (chkUpdateAssembly.Checked)
                {
                    m_progRegistration.Increment("SUCCESS: Assembly was updated");
                }
                else
                {
                    m_progRegistration.Increment("INFORMATION: Assembly was not updated");
                }
            }

            //Check to see if the assembly needs to be added to the list
            if (!m_org.Assemblies.ContainsKey(assembly.AssemblyId))
            {
                m_org.AddAssembly(assembly);

                //Update the Main Form
                try
                {
                    m_orgControl.AddAssembly(assembly);
                    m_progRegistration.Increment();
                }
                catch (Exception ex)
                {
                    m_progRegistration.Increment("ERROR: Error occurred while updating the Main form for the assembly");

                    ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                    m_progRegistration.Complete(false);
                    return;
                }
            }
            else
            {
                m_progRegistration.Increment();
            }

            // Register the Plugin
            bool createPlugin;
            int registeredPlugins = 0;
            int ignoredPlugins = 0;
            int errorsPlugins = 0;

            foreach (var currentPlugin in registerPluginList)
            {
                currentPlugin.AssemblyId = assembly.AssemblyId;

                //Check if the plugin exists
                bool pluginUpdate = m_registeredPluginList != null && m_registeredPluginList.Any(x => x.TypeName.ToLowerInvariant() == currentPlugin.TypeName.ToLowerInvariant());
                try
                {
                    Guid pluginTypeId = Guid.Empty;

                    if (pluginUpdate || (!createAssembly && RegistrationHelper.PluginExists(m_org, currentPlugin.TypeName, assembly.AssemblyId, out pluginTypeId)))
                    {
                        if (pluginUpdate)
                        {
                            createPlugin = false;
                        }
                        else
                        {
                            m_progRegistration.AppendText(string.Format("INFORMATION: Plugin Type Name is already being used by PluginType {0}.", pluginTypeId));

                            switch (MessageBox.Show(string.Format("The specified name \"{0}\" is already registered. Skip the registration of this plugin?\n\nPlease note the plugins may not be the same.", currentPlugin.TypeName),
                                "Plugin Already Exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                            {
                                case DialogResult.Yes:
                                    createPlugin = false;

                                    currentPlugin.PluginId = pluginTypeId;
                                    currentPlugin.Organization = assembly.Organization;
                                    break;
                                case DialogResult.No:
                                    createPlugin = true;
                                    break;
                                case DialogResult.Cancel:
                                    m_progRegistration.AppendText("ABORTED: Plugin Registration has been aborted by the user.");
                                    m_progRegistration.Complete(false);
                                    return;
                                default:
                                    throw new NotImplementedException();
                            }
                        }

                        m_progRegistration.Increment();
                    }
                    else
                    {
                        createPlugin = true;
                        m_progRegistration.Increment();
                    }
                }
                catch (Exception ex)
                {
                    m_progRegistration.Increment(string.Format("ERROR: Occurred while checking if {0} is already registered.",
                        currentPlugin.TypeName));

                    ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                    m_progRegistration.Complete(false);
                    return;
                }

                //Create the plugin (if necessary)
                if (createPlugin)
                {
                    try
                    {
                        Guid pluginId = currentPlugin.PluginId;
                        currentPlugin.PluginId = RegistrationHelper.RegisterPlugin(m_org, currentPlugin);
                        currentPlugin.Organization = m_org;

                        if (pluginId != currentPlugin.PluginId && assembly.Plugins.ContainsKey(pluginId))
                        {
                            assembly.RemovePlugin(pluginId);
                        }

                        retrieveDateList.Add(currentPlugin);

                        m_progRegistration.Increment(string.Format("SUCCESS: Plugin {0} was registered.",
                            currentPlugin.TypeName));

                        registeredPlugins++;
                    }
                    catch (Exception ex)
                    {
                        m_progRegistration.Increment(2, string.Format("ERROR: Occurred while registering {0}.",
                            currentPlugin.TypeName));

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

                    m_progRegistration.Increment();
                }

                //Check if the plugin needs to be added to the list
                if (!assembly.Plugins.ContainsKey(currentPlugin.PluginId))
                {
                    assembly.AddPlugin(currentPlugin);

                    //Update the main form
                    try
                    {
                        m_orgControl.AddPlugin(currentPlugin);
                        m_progRegistration.Increment();
                    }
                    catch (Exception ex)
                    {
                        m_progRegistration.Increment(string.Format("ERROR: Occurred while updating the Main form for {0}.",
                            currentPlugin.TypeName));

                        ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                        m_progRegistration.Complete(false);
                        return;
                    }
                }
                else
                {
                    m_progRegistration.Increment();
                }
            }

            // Unregister plugins that were unchecked
            int updatedPlugins = 0;
            foreach (var currectPlugin in removedPluginList)
            {
                //Check if the plugin exists
                try
                {
                    RegistrationHelper.Unregister(m_org, currectPlugin);
                    m_progRegistration.Increment(3, string.Format("SUCCESS: Plugin {0} was unregistered.", currectPlugin.TypeName));
                    m_orgControl.RemovePlugin(currectPlugin.PluginId);

                    updatedPlugins++;
                }
                catch (Exception ex)
                {
                    m_progRegistration.Increment(3, string.Format("ERROR: Occurred while unregistering {0}.", currectPlugin.TypeName));

                    ErrorMessageForm.ShowErrorMessageBox(this, ERROR_MESSAGE, ERROR_CAPTION, ex);

                    errorsPlugins++;
                }
            }

            //Update the entities whose Created On / Modified On dates changed
            try
            {
                OrganizationHelper.UpdateDates(m_org, retrieveDateList);
                m_progRegistration.Increment("SUCCESS: Created On / Modified On dates updated");
            }
            catch (Exception ex)
            {
                m_progRegistration.Increment("ERROR: Unable to update Created On / Modified On dates");

                ErrorMessageForm.ShowErrorMessageBox(this, "Unable to update Created On / Modified On dates", "Update Error", ex);
            }
            #endregion

            m_progRegistration.AppendText("SUCCESS: Selected Plugins have been registered");
            m_progRegistration.Complete(false);

            MessageBox.Show(string.Format("The selected Plugins have been registered.\n{0} Assembly Registered\n{1} Assembly Ignored\n{2} Assembly Updated\n{3} Plugin(s) Registered\n{4} Plugin(s) Ignored\n{5} Plugin(s) Encountered Errors\n{6} Plugin(s) Removed",
                registeredAssemblies, ignoredAssemblies, updatedAssemblies, registeredPlugins, ignoredPlugins, errorsPlugins, updatedPlugins),
                "Registered Plugins", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (errorsPlugins == 0)
            {
                Close();
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
            if (m_assemblyLoaded)
            {
                btnRegister.Enabled = true;
                grpRegLoc.Enabled = true;
            }
            else if (null != m_currentAssembly)
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
            bool loadTypeId = (m_currentAssembly != null && !checkExisting && m_registeredPluginList != null);
            bool checkRecord = (checkExisting && m_currentAssembly != null && m_registeredPluginList != null);

            //Loop through and add the data to the form
            trvPlugins.LoadNodes(new ICrmTreeNode[] { assembly });

            foreach (var currentPlugin in assembly.Plugins.Values)
            {
                if (loadTypeId && !m_registeredPluginList.Any(x => x.TypeName.ToLowerInvariant() == currentPlugin.TypeName.ToLowerInvariant()))
                {
                    m_registeredPluginList.Add(currentPlugin);
                }

                if (!checkRecord || m_registeredPluginList.Any(x => x.TypeName.ToLowerInvariant() == currentPlugin.TypeName.ToLowerInvariant()))
                {
                    trvPlugins.CheckNode(currentPlugin.PluginId, true);
                }
                else
                {
                    trvPlugins.CheckNode(currentPlugin.PluginId, false);
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
                m_progRegistration.ClearText();
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
            EnableRegistrationControls();
            btnCancel.Enabled = true;

            barRegistration.Value = barRegistration.Minimum;
        }
        #endregion
    }
}
