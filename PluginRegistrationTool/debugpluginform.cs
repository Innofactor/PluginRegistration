//// =====================================================================
////
////  This file is part of the Microsoft Dynamics CRM SDK code samples.
////
////  Copyright (C) Microsoft Corporation.  All rights reserved.
////
////  This source code is intended only as a supplement to Microsoft
////  Development Tools and/or on-line documentation.  See these other
////  materials for detailed information regarding Microsoft code samples.
////
////  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
////  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
////  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
////  PARTICULAR PURPOSE.
////
//// =====================================================================
//using System;
//using System.Diagnostics;
//using System.Globalization;
//using System.ServiceModel;
//using System.Windows.Forms;

//using Microsoft.Xrm.Sdk;

//using PluginProfiler.Library;
//using PluginProfiler.Library.Reporting;
//using PluginProfiler.Plugins;

//namespace PluginRegistrationTool
//{
//    public sealed partial class DebugPluginForm : Form
//    {
//        private CrmOrganization m_org;
//        private ProfilerPluginReport m_report;

//        public DebugPluginForm(CrmOrganization org)
//        {
//            InitializeComponent();

//            this.m_org = org;

//            using (Process p = Process.GetCurrentProcess())
//            {
//                this.ExecutePluginDescriptionLabel.Text = string.Format(CultureInfo.InvariantCulture,
//                    this.ExecutePluginDescriptionLabel.Text, p.ProcessName, p.Id);
//            }

//            #region Populate the Isolation Mode List
//            IsolationModeComboBox.Items.Add(new ComboBoxItem<PluginPermissions>() { Text = "Based on Profile", Value = PluginPermissions.Sandbox });
//            IsolationModeComboBox.Items.Add(new ComboBoxItem<PluginPermissions>() { Text = "None", Value = PluginPermissions.NonIsolated });
//            IsolationModeComboBox.Items.Add(new ComboBoxItem<PluginPermissions>() { Text = "Sandbox", Value = PluginPermissions.Sandbox });

//            IsolationModeComboBox.SelectedIndex = 0;
//            #endregion

//            #region Load the Images & Icons from the Resource File
//            try
//            {
//                RefreshPluginsButton.Image = CrmResources.LoadImage("Refresh");
//            }
//            catch (ArgumentException) //Thrown if the image is not in the list
//            {
//            }
//            #endregion
//        }

//        #region Control Events
//        private void CloseButton_Click(object sender, EventArgs e)
//        {
//            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.Close();
//        }

//        private void LogPathControl_PathChanged(object sender, EventArgs e)
//        {
//            this.EnableDisableButtons();

//            //Parse the report based on the given path. The report has to be parsed since the path has changed.
//            this.ParseReport(requireReportParse: true);
//        }

//        private void AssemblyPathControl_PathChanged(object sender, EventArgs e)
//        {
//            this.EnableDisableButtons();
//            this.PopulatePlugins(true);
//        }

//        private void ExecutePluginButton_Click(object sender, EventArgs e)
//        {
//            //In the case where the underlying assembly no longer exists (edge case)
//            if (!AssemblyPathControl.FileExists)
//            {
//                MessageBox.Show(this, "The specified assembly no longer exists.", "Assembly Missing", MessageBoxButtons.OK,
//                    MessageBoxIcon.Warning);
//                this.EnableDisableButtons();
//                return;
//            }

//            //Reparse the report in case Execute is being clicked multiple times
//            string typeName = null;
//            if (!this.ParseReport(true))
//            {
//                this.EnableDisableButtons();
//                return;
//            }
//            else if (PluginComboBox.Enabled)
//            {
//                typeName = (string)PluginComboBox.SelectedItem;
//            }

//            PluginTracesBox.Clear();
//            Application.DoEvents();

//            //Extract the permissions from the Settings tab
//            PluginPermissions permissions = ((ComboBoxItem<PluginPermissions>)IsolationModeComboBox.SelectedItem).Value;

//            PluginConfiguration plugin = new PluginConfiguration(AssemblyPathControl.FileName, typeName, LogPathControl.FileName,
//                txtUnsecureConfiguration.Text, txtSecureConfiguration.Text);
//            DebugTracingService tracing = new DebugTracingService(this);
//            ProfilerReportingConfiguration reporting = new ProfilerReportingConfiguration(tracing);

//            ProfilerExecutionReport report;

//            try
//            {
//                if (null == this.m_org)
//                {
//                    report = ProfilerExecutionUtility.Replay(permissions, plugin, reporting, tracing);
//                }
//                else
//                {
//                    report = ProfilerExecutionUtility.Execute(permissions, plugin, reporting, this.m_org.OrganizationService,
//                        tracing);
//                }
//            }
//            catch (Exception ex)
//            {
//                ErrorMessage.ShowErrorMessageBox(this, "An error occurred while initializing the plug-in.", "Error", ex);
//                return;
//            }

//            if (null != report.Fault)
//            {
//                ErrorMessage.ShowErrorMessageBox(this, "An error occurred during the plug-in execution.", "Error",
//                    new FaultException<OrganizationServiceFault>(report.Fault, new FaultReason(report.Fault.Message)));
//            }
//        }

//        private void RefreshPluginsButton_Click(object sender, EventArgs e)
//        {
//            this.PopulatePlugins(true);
//        }

//        private void PluginComboBox_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            this.EnableDisableButtons();
//        }

//        private void UseSpecifiedUnsecureConfigurationBox_CheckedChanged(object sender, EventArgs e)
//        {
//            if (UseCustomUnsecureConfigurationBox.Checked)
//            {
//                txtUnsecureConfiguration.ReadOnly = false;
//            }
//            else
//            {
//                txtUnsecureConfiguration.ReadOnly = true;

//                //If the box was checked (and now is unchecked), the value from the report is supposed to be used again.
//                if (null != this.m_report)
//                {
//                    txtUnsecureConfiguration.Text = this.m_report.Configuration;
//                }
//            }
//        }

//        private void UseSpecifiedSecureConfigurationBox_CheckedChanged(object sender, EventArgs e)
//        {
//            if (UseCustomSecureConfigurationBox.Checked)
//            {
//                txtSecureConfiguration.ReadOnly = false;
//            }
//            else
//            {
//                txtSecureConfiguration.ReadOnly = true;

//                //If the box was checked (and now is unchecked), the value from the report is supposed to be used again.
//                if (null != this.m_report)
//                {
//                    txtSecureConfiguration.Text = this.m_report.SecureConfiguration;
//                }
//            }
//        }
//        #endregion

//        #region Private Helper Methods
//        private void EnableDisableButtons()
//        {
//            if (LogPathControl.FileExists && AssemblyPathControl.FileExists)
//            {
//                //If a plug-in must be selected (in the case of context replay), the Execute button should not be enabled until
//                //a plug-in is selected.
//                if (!PluginComboBox.Enabled || null != PluginComboBox.SelectedItem)
//                {
//                    ExecutePluginButton.Enabled = true;
//                }
//                else
//                {
//                    ExecutePluginButton.Enabled = false;
//                }
//            }
//            else
//            {
//                ExecutePluginButton.Enabled = false;
//            }
//        }

//        private bool ParseReport(bool requireReportParse)
//        {
//            bool isReportSet = (null != this.m_report);

//            if (OrganizationHelper.ParseReportOrShowError(this, this.LogPathControl, requireReportParse, ref this.m_report))
//            {
//                //If this is a Replay form (no connection to the organization will be available), context replay is not supported.
//                //Replay relies on a sequence of calls to the SDK being replayed back to the plug-in. In the case of a context replay,
//                //the plug-in profiler step will not record any SDK calls.
//                if (null == this.m_org && this.m_report.IsContextReplay)
//                {
//                    MessageBox.Show(this, "Replay is only supported when the Profile was not generated from a step registered on the Plug-in Profiler. For those cases, use Debug.", "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//                    this.m_report = null;
//                    return false;
//                }

//                //If the report has been parsed, then the plug-in should be selected
//                if (!isReportSet || requireReportParse)
//                {
//                    this.SelectPluginFromProfile();

//                    //Set the default isolation mode
//                    PluginPermissions defaultPermissions;
//                    switch (this.m_report.IsolationMode.GetValueOrDefault())
//                    {
//                        case 0: //Unknown
//                        case 2: //Sandbox
//                            defaultPermissions = PluginPermissions.Sandbox;
//                            break;
//                        case 1: //Non-Isolated
//                            defaultPermissions = PluginPermissions.NonIsolated;
//                            break;
//                        default:
//                            throw new NotImplementedException("IsolationMode = " + this.m_report.IsolationMode);
//                    }

//                    ((ComboBoxItem<PluginPermissions>)IsolationModeComboBox.Items[0]).Value = defaultPermissions;

//                    //Refresh the configuration
//                    if (!UseCustomUnsecureConfigurationBox.Checked)
//                    {
//                        txtUnsecureConfiguration.Text = this.m_report.Configuration;
//                    }
//                    if (!UseCustomSecureConfigurationBox.Checked)
//                    {
//                        txtSecureConfiguration.Text = this.m_report.SecureConfiguration;
//                    }
//                }

//                this.PopulatePlugins(false);
//                return true;
//            }

//            return false;
//        }

//        private void PopulatePlugins(bool assemblyPathHasChanged)
//        {
//            //If the assembly path has changed, the plug-ins should be cleared
//            if (assemblyPathHasChanged)
//            {
//                PluginComboBox.Items.Clear();
//            }

//            //If this is not a context replay or an assembly has not specified, the drop-down does not need to be populated
//            if (AssemblyPathControl.FileExists)
//            {
//                PluginLabel.Enabled = true;
//                PluginComboBox.Enabled = true;
//                RefreshPluginsButton.Enabled = true;

//                //Since the Assembly's Path hasn't changed, there is no need to do any additional processing
//                if (!assemblyPathHasChanged)
//                {
//                    return;
//                }
//            }
//            else
//            {
//                PluginLabel.Enabled = false;
//                PluginComboBox.Enabled = false;
//                RefreshPluginsButton.Enabled = false;
//                return;
//            }

//            //Load the assembly to retrieve its list of plug-ins
//            CrmPluginAssembly assembly;
//            try
//            {
//                assembly = RegistrationHelper.RetrievePluginsFromAssembly(AssemblyPathControl.FileName);
//            }
//            catch (Exception ex)
//            {
//                ErrorMessage.ShowErrorMessageBox(this, "Unable to load the specified plug-in assembly.", "Assembly Load Failure", ex);
//                return;
//            }

//            //Loop through the plug-ins and add them to the drop-down
//            foreach (CrmPlugin plugin in assembly.Plugins)
//            {
//                PluginComboBox.Items.Add(plugin.TypeName);
//            }

//            this.SelectPluginFromProfile();
//        }

//        private void SelectPluginFromProfile()
//        {
//            //If there are no items or no report, then the plug-in cannot be found from the profile
//            if (null == this.m_report || 0 == this.PluginComboBox.Items.Count)
//            {
//                PluginComboBox.SelectedItem = null;
//            }
//            else if (this.m_report.IsContextReplay)
//            {
//                //For Context replay, a plug-in type is not known. In those cases, the first plug-in should be selected.
//                PluginComboBox.SelectedIndex = 0;
//            }
//            else if (!string.IsNullOrWhiteSpace(this.m_report.TypeName) && PluginComboBox.Items.Contains(this.m_report.TypeName))
//            {
//                //The Type for which the profile was initially collected still exists
//                PluginComboBox.SelectedItem = this.m_report.TypeName;
//            }
//            else
//            {
//                PluginComboBox.SelectedItem = null;
//            }
//        }
//        #endregion

//        #region Private Classes
//        private sealed class DebugTracingService : MarshalByRefObject, ITracingService, IProfilerTracingService
//        {
//            private readonly DebugPluginForm Form;

//            public DebugTracingService(DebugPluginForm form)
//            {
//                if (null == form)
//                {
//                    throw new ArgumentNullException("form");
//                }

//                this.Form = form;
//                this.Form.PluginTracesBox.Clear();
//            }

//            void ITracingService.Trace(string format, params object[] args)
//            {
//                string line;
//                if (null == args || 0 == args.Length)
//                {
//                    line = format;
//                }
//                else
//                {
//                    line = string.Format(CultureInfo.InvariantCulture, format, args);
//                }

//                this.OutputLine("Plug-in", line);
//            }

//            void IProfilerTracingService.Trace(string format, params object[] args)
//            {
//                string line;
//                if (null == args || 0 == args.Length)
//                {
//                    line = format;
//                }
//                else
//                {
//                    line = string.Format(CultureInfo.InvariantCulture, format, args);
//                }

//                this.OutputLine("Profiler", line);
//            }

//            #region Private Methods
//            private void OutputLine(string type, string line)
//            {
//                string newLineValue = null;
//                if (this.Form.PluginTracesBox.TextLength > 0)
//                {
//                    newLineValue = Environment.NewLine;
//                }

//                this.Form.PluginTracesBox.AppendText(string.Format(CultureInfo.InvariantCulture,
//                    "{2}{0}> {1}", type, line, newLineValue));
//                this.Form.PluginTracesBox.SelectionStart = this.Form.PluginTracesBox.TextLength;
//                this.Form.PluginTracesBox.SelectionLength = 0;
//            }
//            #endregion
//        }

//        private sealed class ComboBoxItem<T>
//        {
//            #region Methods
//            public override string ToString()
//            {
//                return this.Text;
//            }
//            #endregion

//            #region Properties
//            public string Text { get; set; }

//            public T Value { get; set; }
//            #endregion
//        }
//        #endregion
//    }
//}
