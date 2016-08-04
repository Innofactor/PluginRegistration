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

namespace Xrm.Sdk.PluginRegistration
{
    using McTools.Xrm.Connection;
    using Xrm.Sdk.PluginRegistration.Controls;
    using Xrm.Sdk.PluginRegistration.Forms;
    using Xrm.Sdk.PluginRegistration.Helpers;
    using Xrm.Sdk.PluginRegistration.Wrappers;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using XrmToolBox.Extensibility;
    using XrmToolBox.Extensibility.Interfaces;
    using XrmToolBox.Extensibility.Args;

    public partial class MainControl : PluginControlBase, IStatusBarMessager
    {
        private const string SYSTEM_ERROR_MESSAGE = "The selected item is required for the Microsoft Dynamics CRM system to work correctly.";
        private const string SYSTEM_ERROR_CAPTION = "Microsoft Dynamics CRM";
        private CrmViewType m_currentView;
        private ConnectionDetail m_con;
        private CrmOrganization m_org;
        private static CrmEntitySorter m_entitySorter;
        private Dictionary<Guid, Guid> m_stepEntityMap = new Dictionary<Guid, Guid>();
        private Dictionary<string, CrmTreeNode> m_rootNodeList = null;
        private Dictionary<Guid, Guid> m_viewNodeList = null;
        private Dictionary<Guid, Guid> m_stepParentList = null;
        private ProgressIndicator m_progressIndicator = null;

        public MainControl()
        {
            InitializeComponent();

            #region Load the Images & Icons from the Resource File
            Dictionary<CrmTreeNodeImageType, Image> nodeImageList = null;
            try
            {
                nodeImageList = CrmResources.LoadImage(
                    CrmTreeNodeImageType.Assembly, CrmTreeNodeImageType.Image,
                    CrmTreeNodeImageType.Message, CrmTreeNodeImageType.MessageEntity,
                    CrmTreeNodeImageType.StepDisabled, CrmTreeNodeImageType.StepEnabled,
                    CrmTreeNodeImageType.ServiceEndpoint);

                toolServiceEndpointRegister.Image = nodeImageList[CrmTreeNodeImageType.ServiceEndpoint];
                mnuContextNodeServiceEndpointRegister.Image = toolServiceEndpointRegister.Image;
                mnuContextGeneralServiceEndpointRegister.Image = toolServiceEndpointRegister.Image;

                toolAssemblyRegister.Image = nodeImageList[CrmTreeNodeImageType.Assembly];
                mnuContextNodeAssemblyRegister.Image = toolAssemblyRegister.Image;
                mnuContextGeneralAssemblyRegister.Image = toolAssemblyRegister.Image;

                toolStepRegister.Image = nodeImageList[CrmTreeNodeImageType.StepEnabled];
                mnuContextNodeStepRegister.Image = toolStepRegister.Image;
                mnuContextGeneralStepRegister.Image = toolStepRegister.Image;

                toolImageRegister.Image = nodeImageList[CrmTreeNodeImageType.Image];
                mnuContextNodeImageRegister.Image = toolImageRegister.Image;
                mnuContextGeneralImageRegister.Image = toolImageRegister.Image;

                toolViewAssembly.Image = toolAssemblyRegister.Image;
                toolViewEntity.Image = nodeImageList[CrmTreeNodeImageType.MessageEntity];
                toolViewMessage.Image = nodeImageList[CrmTreeNodeImageType.Message];

                imlEnableImages.Images.Add("enableStep", nodeImageList[CrmTreeNodeImageType.StepEnabled]);
                imlEnableImages.Images.Add("disableStep", nodeImageList[CrmTreeNodeImageType.StepDisabled]);

                this.UpdateEnableButton(true);
            }
            catch (Exception)
            {
                if (nodeImageList != null)
                {
                    foreach (Image img in nodeImageList.Values)
                    {
                        if (img != null)
                        {
                            img.Dispose();
                        }
                    }
                }

                throw;
            }

            Dictionary<string, Image> imageList = null;
            try
            {
                imageList = CrmResources.LoadImage(
                    "ImportExport", 
                    "EditLabel", 
                    "Update", 
                    "Register", 
                    "Refresh", 
                    "Delete",
                    "Import", 
                    "Export", 
                    "View", 
                    "Search", 
                    "Errors", 
                    "InstallProfiler", 
                    "EnableProfiler", 
                    "DisableProfiler",
                    "UninstallProfiler", 
                    "Debug", 
                    "Close");

                toolRegister.Image = imageList["Register"];
                toolView.Image = imageList["View"];

                toolUpdate.Image = imageList["Update"];
                mnuContextNodeUpdate.Image = toolUpdate.Image;

                toolUnregister.Image = imageList["Delete"];
                mnuContextNodeUnregister.Image = toolUnregister.Image;

                toolSearch.Image = imageList["Search"];
                mnuContextNodeSearch.Image = toolSearch.Image;
                mnuContextGeneralSearch.Image = toolSearch.Image;

                toolRefresh.Image = imageList["Refresh"];
                mnuContextNodeRefresh.Image = toolRefresh.Image;
                mnuContextGeneralRefresh.Image = toolRefresh.Image;

                toolProfilerDebug.Image = imageList["Debug"];
                toolClose.Image = imageList["Close"];

                imlEnableImages.Images.Add("installProfiler", imageList["InstallProfiler"]);
                imlEnableImages.Images.Add("enableProfiler", imageList["EnableProfiler"]);
                imlEnableImages.Images.Add("disableProfiler", imageList["DisableProfiler"]);
                imlEnableImages.Images.Add("uninstallProfiler", imageList["UninstallProfiler"]);
            }
            catch (Exception)
            {
                foreach (Image img in imageList.Values)
                {
                    img.Dispose();
                }

                throw;
            }
            #endregion

            //Set the view types on the menu items. The Designer's auto code generation keeps overwriting this
            toolViewAssembly.Tag = CrmViewType.Assembly;
            toolViewEntity.Tag = CrmViewType.Entity;
            toolViewMessage.Tag = CrmViewType.Message;

            if (m_entitySorter == null)
            {
                m_entitySorter = new CrmEntitySorter();
            }
            trvPlugins.CrmTreeNodeSorter = m_entitySorter;

            //this.RefreshProfilerGeneralMenu();

            //Update the shortcut keys
            mnuContextNodeAssemblyRegister.ShortcutKeys = toolAssemblyRegister.ShortcutKeys;
            mnuContextGeneralAssemblyRegister.ShortcutKeys = toolAssemblyRegister.ShortcutKeys;

            mnuContextNodeStepRegister.ShortcutKeys = toolStepRegister.ShortcutKeys;
            mnuContextGeneralStepRegister.ShortcutKeys = toolStepRegister.ShortcutKeys;

            mnuContextNodeImageRegister.ShortcutKeys = toolImageRegister.ShortcutKeys;
            mnuContextGeneralImageRegister.ShortcutKeys = toolImageRegister.ShortcutKeys;

            mnuContextNodeRefresh.ShortcutKeys = mnuContextGeneralRefresh.ShortcutKeys;

            mnuContextNodeSearch.ShortcutKeys = mnuContextGeneralSearch.ShortcutKeys;

            mnuContextNodeSearch.ShortcutKeys = mnuContextGeneralSearch.ShortcutKeys;

            //Setup splitter panel 2 min distance because form designer keeps putting properties in incorrect order
            splitterDisplay.Panel2MinSize = 230;

            ConnectionUpdated += OrganizationControl_ConnectionUpdated;

            m_progressIndicator = new ProgressIndicator(new Action<StatusBarMessageEventArgs>((message) =>
            {
                if (SendMessageToStatusBar != null)
                {
                    SendMessageToStatusBar(this, message);
                }
            }));
        }

        public event EventHandler<StatusBarMessageEventArgs> SendMessageToStatusBar;

        void OrganizationControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            var instruction = new WorkAsyncInfo()
            {
                Message = "Loading assemblies information...",
                Work = (worker, argument) =>
                {
                    argument.Result = new CrmOrganization(ConnectionDetail, m_progressIndicator);
                },
                PostWorkCallBack = (argument) =>
                {
                    Init((CrmOrganization)argument.Result);
                }
            };
            
            WorkAsync(instruction);
        }

        public void Init(CrmOrganization org)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (org.ConnectionDetail == null)
            {
                throw new ArgumentNullException("org.ConnectionDetail");
            }

            this.m_org = org;
            this.m_con = org.ConnectionDetail;
            this.m_currentView = CrmViewType.Assembly;
            this.LoadNodes();
        }

        #region Control Event Handlers
        private void toolAssemblyRegister_Click(object sender, EventArgs e)
        {
            PluginRegistrationForm regForm = new PluginRegistrationForm(this.Organization, this, null);
            regForm.ShowDialog(this.ParentForm);
        }
        private void toolServiceEndpointRegister_Click(object sender, EventArgs e)
        {
            //ServiceBusConfigForm serviceBusConfigForm = new ServiceBusConfigForm(this.Organization, this, null);
            //serviceBusConfigForm.ShowDialog();
        }
        private void toolStepRegister_Click(object sender, EventArgs e)
        {
            //Check if we can extract a plugin from the Tree
            CrmPlugin plugin = null;
            CrmServiceEndpoint serviceEndpoint = null;

            if (trvPlugins.SelectedNode != null)
            {
                Guid pluginId;
                Guid serviceEndpointId = Guid.Empty;
                switch (trvPlugins.SelectedNode.NodeType)
                {
                    case CrmTreeNodeType.Assembly:
                    case CrmTreeNodeType.Message:
                    case CrmTreeNodeType.MessageEntity:

                        pluginId = Guid.Empty;
                        break;

                    case CrmTreeNodeType.Plugin:
                    case CrmTreeNodeType.WorkflowActivity:

                        pluginId = trvPlugins.SelectedNode.NodeId;
                        break;
                    case CrmTreeNodeType.Step:

                        pluginId = ((CrmPluginStep)trvPlugins.SelectedNode).PluginId;
                        break;
                    case CrmTreeNodeType.Image:

                        pluginId = ((CrmPluginImage)trvPlugins.SelectedNode).PluginId;
                        break;
                    case CrmTreeNodeType.ServiceEndpoint:

                        pluginId = ((CrmServiceEndpoint)trvPlugins.SelectedNode).PluginId;
                        serviceEndpointId = ((CrmServiceEndpoint)trvPlugins.SelectedNode).NodeId;
                        break;
                    default:
                        throw new NotImplementedException("NodeType = " + trvPlugins.SelectedNode.NodeType.ToString());
                }

                if (Guid.Empty != pluginId)
                {
                    plugin = this.m_org.Plugins[pluginId];
                }
                if (Guid.Empty != serviceEndpointId)
                {
                    serviceEndpoint = this.m_org.ServiceEndpoints[serviceEndpointId];
                }
            }

            StepRegistrationForm regForm = new StepRegistrationForm(this.Organization, this, plugin, null, serviceEndpoint);
            regForm.ShowDialog();
        }

        private void trvPlugins_SelectionChanged(object sender, CrmTreeNodeTreeEventArgs e)
        {
            this.SelectItem(e.Node);
        }

        private void toolUnregister_Click(object sender, EventArgs e)
        {
            if (trvPlugins.SelectedNode == null)
            {
                return;
            }
            else if (this.IsNodeSystemItem(trvPlugins.SelectedNode))
            {
                this.ShowSystemItemError("It cannot be unregistered.");
                return;
            }

            //If this is the profiler plug-in, then it needs to be unregistered.
            CrmPlugin plugin = trvPlugins.SelectedNode as CrmPlugin;
            if (null != plugin && plugin.IsProfilerPlugin)
            {
                toolProfilerInstall_Click(sender, e);
                return;
            }

            Guid nodeId = trvPlugins.SelectedNode.NodeId;
            if (MessageBox.Show("Are you sure you want to unregister this item?", "Unregister",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Enabled = false;
                // this.MainForm.EnableToolBar(false);

                try
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (KeyValuePair<string, int> stat in RegistrationHelper.Unregister(this.m_org, (ICrmEntity)this.trvPlugins.SelectedNode))
                    {
                        builder.AppendLine(string.Format("{0} {1} Unregistered Successfully", stat.Value, stat.Key));
                    }

                    this.trvPlugins.RemoveNode(this.trvPlugins.SelectedNode.NodeId);

                    MessageBox.Show(builder.ToString(), "Unregister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    ErrorMessageForm.ShowErrorMessageBox(this, "Unable to unregister this item an error occurred.", "Unregister Error", ex);
                }
                finally
                {
                    if (trvPlugins.HasNode(nodeId))
                    {
                        trvPlugins.RefreshNode(nodeId, true);
                        this.SelectItem(trvPlugins.SelectedNode);
                    }

                    this.Enabled = true;
                    // this.MainForm.EnableToolBar(true);
                }

                trvPlugins.Focus();
            }
            else
            {
                trvPlugins.Focus();
                return;
            }
        }

        private void toolEnable_Click(object sender, EventArgs e)
        {
            if (trvPlugins.SelectedNode.NodeType != CrmTreeNodeType.Step)
            {
                return;
            }
            else if (this.IsNodeSystemItem(trvPlugins.SelectedNode))
            {
                this.ShowSystemItemError("The step cannot be enabled or disabled.");
                return;
            }

            CrmPluginStep step = (CrmPluginStep)trvPlugins.SelectedNode;
            string captionItem, messageItem;
            if (step.Enabled)
            {
                captionItem = "Disable";
                messageItem = "disable";
            }
            else
            {
                captionItem = "Enable";
                messageItem = "enable";
            }

            if (MessageBox.Show(string.Format("Are you sure you want to {0} this step?", messageItem),
                string.Format("{0} Step", captionItem),
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            this.Enabled = false;
            try
            {
                RegistrationHelper.UpdateStepStatus(this.m_org, step.StepId, !step.Enabled);
                step.Enabled = !step.Enabled;
                UpdateEnableButton(step.Enabled);
                trvPlugins.RefreshNode(trvPlugins.SelectedNode.NodeId);

                MessageBox.Show(string.Format("Step {0}d successfully.", messageItem),
                    string.Format("{0} Step", captionItem), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorMessageForm.ShowErrorMessageBox(this,
                    string.Format("Unable to {0} this item at ths time. An error occurred.", messageItem),
                    string.Format("{0} Step", captionItem), ex);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private void toolUpdate_Click(object sender, EventArgs e)
        {
            if (this.IsNodeSystemItem(trvPlugins.SelectedNode))
            {
                this.ShowSystemItemError("The assembly cannot be updated.");
                return;
            }

            switch (trvPlugins.SelectedNode.NodeType)
            {
                case CrmTreeNodeType.ServiceEndpoint:
                    {
                        //ServiceBusConfigForm serForm = new ServiceBusConfigForm(this.Organization, this, (CrmServiceEndpoint)trvPlugins.SelectedNode);
                        //serForm.ShowDialog();
                    }
                    break;
                case CrmTreeNodeType.Assembly:
                    {
                        PluginRegistrationForm regForm = new PluginRegistrationForm(this.Organization, this, (CrmPluginAssembly)trvPlugins.SelectedNode);
                        regForm.ShowDialog(this.ParentForm);
                    }
                    break;
                case CrmTreeNodeType.Step:
                    {
                        CrmPluginStep step = (CrmPluginStep)trvPlugins.SelectedNode;
                        CrmPlugin plugin = this.m_org[step.AssemblyId][step.PluginId];

                        CrmServiceEndpoint serviceEndpoint = null;
                        if (step.ServiceBusConfigurationId != Guid.Empty)
                        {
                            serviceEndpoint = this.m_org.ServiceEndpoints[step.ServiceBusConfigurationId];
                        }

                        StepRegistrationForm regForm = new StepRegistrationForm(this.Organization, this, plugin, step, serviceEndpoint);
                        regForm.ShowDialog();
                    }
                    break;
                case CrmTreeNodeType.Image:
                    {
                        ImageRegistrationForm regForm = new ImageRegistrationForm(this.m_org, this,
                            trvPlugins.RootNodes, (CrmPluginImage)trvPlugins.SelectedNode, trvPlugins.SelectedNode.NodeId);
                        regForm.ShowDialog();
                    }
                    break;
                default:
                    throw new NotImplementedException("NodeType = " + trvPlugins.SelectedNode.NodeType.ToString());
            }

            ICrmTreeNode node = trvPlugins.SelectedNode;
            if (node != null)
            {
                trvPlugins_SelectionChanged(sender, new CrmTreeNodeTreeEventArgs(node, TreeViewAction.Unknown));
            }
        }

        private int m_dataRowIndex = -1;
        private Guid m_dataRowId = Guid.Empty;
        private void grvData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == m_dataRowIndex)
            {
                return;
            }
            this.m_dataRowIndex = e.RowIndex;

            Guid rowId = (Guid)grvData.Rows[m_dataRowIndex].Cells["Id"].Value;
            this.m_dataRowId = rowId;

            //Check for special cases
            switch (trvPlugins.SelectedNode.NodeType)
            {
                case CrmTreeNodeType.Message:
                case CrmTreeNodeType.MessageEntity:

                    //The Id presented in the DataGrid is not the id of the node in the tree
                    if (this.m_viewNodeList.ContainsKey(rowId))
                    {
                        this.m_dataRowId = this.m_viewNodeList[rowId];
                    }
                    break;
            }
        }

        private void grvData_DoubleClick(object sender, EventArgs e)
        {
            if (trvPlugins.HasNode(this.m_dataRowId))
            {
                trvPlugins.SelectedNode = trvPlugins[this.m_dataRowId];
            }
        }

        private void toolImageRegister_Click(object sender, EventArgs e)
        {
            Guid nodeId = Guid.Empty;
            if (trvPlugins.SelectedNode != null && trvPlugins.SelectedNode.NodeType != CrmTreeNodeType.Image)
            {
                nodeId = trvPlugins.SelectedNode.NodeId;
            }

            // TODO : Ajith
            // Do Validations if the Image is valid on the Step -Message and then Launch the Wizard

            var regForm = new ImageRegistrationForm(this.m_org, this, trvPlugins.RootNodes, null, nodeId);
            regForm.ShowDialog();
        }

        private void toolView_Click(object sender, EventArgs e)
        {
            if (sender != null && sender.GetType().IsSubclassOf(typeof(ToolStripItem)))
            {
                ToolStripItem item = (ToolStripItem)sender;
                if (item.Tag != null && item.Tag.GetType() == typeof(CrmViewType))
                {
                    propGridEntity.SelectedObject = null;
                    this.LoadNodes((CrmViewType)item.Tag);
                }
            }
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            var instruction = new WorkAsyncInfo()
            {
                Message = "Refreshing assemblies information...",
                Work = (worker, argument) =>
                {
                    try
                    {
                        OrganizationHelper.RefreshConnection(m_org, OrganizationHelper.LoadMessages(m_org), m_progressIndicator);
                        Invoke(new Action(() =>
                        {
                            propGridEntity.SelectedObject = null;
                            LoadNodes();
                        }));
                    }
                    catch (Exception ex)
                    {
                        Invoke(new Action(() =>
                        {
                            ErrorMessageForm.ShowErrorMessageBox(this, "Unable to the refresh the organization. Connection must close.", "Connection Error", ex);
                        }));
                    }
                }
            };
            WorkAsync(instruction);
        }

        private void trvPlugins_DoubleClick(object sender, CrmTreeNodeEventArgs e)
        {
            if (toolUpdate.Visible && toolUpdate.Enabled)
            {
                trvPlugins.SelectedNode = e.Node;
                if (toolUpdate.Visible && toolUpdate.Enabled)
                {
                    this.toolUpdate_Click(sender, e);
                }
            }
            else
            {
                //If the selected step is the Plug-in Profiler plug-in, the PluginRegistrationForm should be displayed.
                //This will allow the consumer the ability to change the isolation mode of the Plug-in Profiler.
                CrmPlugin plugin = trvPlugins.SelectedNode as CrmPlugin;
                if (null != plugin && plugin.IsProfilerPlugin)
                {
                    //Display the Plug-in Registration form
                    using (PluginRegistrationForm form = new PluginRegistrationForm(this.Organization, this,
                        this.Organization.Assemblies[plugin.AssemblyId]))
                    {
                        form.ShowDialog(this.ParentForm);
                    }

                    //Update the tree based on the selected node
                    ICrmTreeNode node = trvPlugins.SelectedNode;
                    if (node != null)
                    {
                        trvPlugins_SelectionChanged(sender, new CrmTreeNodeTreeEventArgs(node, TreeViewAction.Unknown));
                    }
                }
            }
        }

        private void trvPlugins_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && toolUpdate.Enabled && toolUpdate.Visible)
            {
                toolUpdate_Click(sender, e);
            }
        }

        private void toolSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchForm(Organization, this, trvPlugins.RootNodes, trvPlugins.SelectedNode);
            searchForm.StartPosition = FormStartPosition.CenterParent;
            searchForm.ShowDialog(this);
        }

        private void trvPlugins_NodeRemoved(object sender, CrmTreeNodeEventArgs e)
        {
            switch (e.Node.NodeType)
            {
                case CrmTreeNodeType.Step:
                    {
                        Guid stepId = e.Node.NodeId;
                        if (null != this.m_stepParentList && this.m_stepParentList.ContainsKey(stepId))
                        {
                            CrmTreeNode node = (CrmTreeNode)trvPlugins[this.m_stepParentList[stepId]];
                            node.RemoveChild(stepId);
                            this.m_stepParentList.Remove(stepId);

                            this.RemoveCrmTreeNodesCascadeUp(node);
                        }
                    }
                    break;
                default:
                    return;
            }

            if (null == trvPlugins.SelectedNode)
            {
                propGridEntity.SelectedObject = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.trvPlugins != null && this.trvPlugins.SelectedNode != null)
                {
                    switch (this.trvPlugins.SelectedNode.NodeType)
                    {
                        case CrmTreeNodeType.Assembly:
                            CrmPluginAssembly assembly = (CrmPluginAssembly)this.trvPlugins.SelectedNode;
                            RegistrationHelper.UpdateAssembly(m_org, assembly.Description, assembly.AssemblyId);
                            trvPlugins.RefreshNode(assembly.AssemblyId, false, false);
                            MessageBox.Show("Assembly has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case CrmTreeNodeType.Plugin:
                        case CrmTreeNodeType.WorkflowActivity:
                            CrmPlugin plugin = (CrmPlugin)this.trvPlugins.SelectedNode;
                            RegistrationHelper.UpdatePlugin(m_org, plugin);
                            trvPlugins.RefreshNode(plugin.PluginId, false, false);
                            MessageBox.Show("Plug-in has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            MessageBox.Show("A valid object has not been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("A valid object has not been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.ShowErrorMessageBox(this, "Unable to Update the Assembly /Plugin due to an error.", "Update", ex);
            }
        }

        private void toolProfilerInstall_Click(object sender, EventArgs e)
        {
            //if (true/*!OrganizationHelper.IsProfilerSupported*/)
            //{
            //    return;
            //}

            //if (null != this.m_org.ProfilerPlugin)
            //{
            //    if (DialogResult.Yes != MessageBox.Show(this, "This will delete all previously collected profiling sessions. Continue?", "Profiler Installation",
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2))
            //    {
            //        return;
            //    }

            //    try
            //    {
            //        //Guid nodeId = OrganizationHelper.UninstallProfiler(this.m_org);
            //        if (trvPlugins.HasNode(nodeId))
            //        {
            //            trvPlugins.RemoveNode(nodeId);
            //        }

            //        trvPlugins.RefreshNodes(false);
            //    }
            //    catch (Exception ex)
            //    {
            //        ErrorMessage.ShowErrorMessageBox(this, "Unable to Uninstall the Profiler", "Profiler Installation Error", ex);
            //        return;
            //    }

            //    MessageBox.Show(this, "Profiler Uninstalled Successfully", "Profiler Installation",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    try
            //    {
            //        //trvPlugins.AddNode(Guid.Empty, OrganizationHelper.InstallProfiler(this.m_org));
            //    }
            //    catch (Exception ex)
            //    {
            //        ErrorMessage.ShowErrorMessageBox(this, "Unable to Install the Profiler", "Profiler Installation Error", ex);
            //        return;
            //    }

            //    MessageBox.Show(this, "Profiler Installed Successfully", "Profiler Installation",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //if (null != trvPlugins.SelectedNode)
            //{
            //    this.SelectItem(trvPlugins.SelectedNode);
            //}
            //this.RefreshProfilerGeneralMenu();
        }

        private void toolProfilerEnable_Click(object sender, EventArgs e)
        {
            //if (true/*!OrganizationHelper.IsProfilerSupported*/)
            //{
            //    return;
            //}

            //CrmPluginStep step = trvPlugins.SelectedNode as CrmPluginStep;
            //if (null == step)
            //{
            //    return;
            //}

            //if (step.IsProfiled)
            //{
            //    //Update the status on the server
            //    //OrganizationHelper.DisableProfiler(step);

            //    //Retrieve the new status for the step
            //    OrganizationHelper.RefreshStep(step.Organization, step);
            //    if (null != step.Organization.ProfilerPlugin)
            //    {
            //        OrganizationHelper.RefreshPlugin(step.Organization, step.Organization.ProfilerPlugin);
            //    }

            //    //Update the profiler status
            //    step.ProfilerStepId = null;

            //    //Refresh the node on the tree
            //    trvPlugins.RefreshNode(step.NodeId);
            //}
            //else
            //{
            //    //Update the status on the server
            //    //Guid profilerStepId = OrganizationHelper.EnableProfiler(step);

            //    //Retrieve the new status for the step (first ensure that the profiler plug-in is known).
            //    if (null == step.Organization.ProfilerPlugin)
            //    {
            //        this.toolRefresh_Click(sender, e);
            //        return;
            //    }
            //    else
            //    {
            //        OrganizationHelper.RefreshPlugin(step.Organization, step.Organization.ProfilerPlugin);
            //        OrganizationHelper.RefreshStep(step.Organization, step);

            //        //Update the profiler status
            //        step.ProfilerStepId = profilerStepId;

            //        //Refresh the node on the tree
            //        trvPlugins.RefreshNode(step.NodeId);
            //        trvPlugins.RefreshNode(step.Organization.ProfilerPlugin.NodeId);
            //    }
            //}

            //this.SelectItem(step);
        }

        private void toolProfilerDebug_Click(object sender, EventArgs e)
        {
            //using (DebugPluginForm form = new DebugPluginForm(this.m_org))
            //{
            //    form.Text = "Debug Existing Plug-in";
            //    form.ShowDialog(this);
            //}
        }
        #endregion

        #region Properties
        public IComparer<ICrmTreeNode> CrmTreeNodeSorter
        {
            get
            {
                return m_entitySorter;
            }
        }

        public ConnectionDetail Connection
        {
            get
            {
                return this.m_con;
            }
        }

        public CrmOrganization Organization
        {
            get
            {
                return this.m_org;
            }
        }

        public bool IsAutoExpanded
        {
            get
            {
                return this.trvPlugins.AutoExpand;
            }
        }

        #endregion

        #region Public Methods
        public void AddServiceEndpoint(CrmServiceEndpoint serviceEndpoint)
        {
            if (serviceEndpoint == null)
            {
                throw new ArgumentNullException("serviceEndpoint");
            }

            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.AddNode(Guid.Empty, serviceEndpoint);
            }
        }
        public void AddAssembly(CrmPluginAssembly assembly)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.AddNode(Guid.Empty, assembly);
            }
        }

        public void RefreshServiceEndpoint(CrmServiceEndpoint serviceEndpoint)
        {
            if (serviceEndpoint == null)
            {
                throw new ArgumentNullException("serviceEndpoint");
            }

            this.trvPlugins.RefreshNode(serviceEndpoint.NodeId, true);
            this.SelectItem(this.trvPlugins.SelectedNode);
        }
        public void RefreshAssembly(CrmPluginAssembly assembly, bool reloadChildren)
        {
            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.RefreshNode(assembly.NodeId, reloadChildren);
                this.SelectItem(this.trvPlugins.SelectedNode);
            }
        }

        public void RemoveAssembly(Guid assemblyId)
        {
            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.RemoveNode(assemblyId);
                this.SelectItem(trvPlugins.SelectedNode);
            }
        }

        public void AddPlugin(CrmPlugin reg)
        {
            if (reg == null)
            {
                throw new ArgumentNullException("reg");
            }

            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.AddNode(reg.AssemblyId, reg);
                if (trvPlugins.SelectedNode != null && trvPlugins.SelectedNode.NodeId == reg.AssemblyId)
                {
                    this.SelectItem(trvPlugins.SelectedNode);
                }
            }
        }

        public void RefreshPlugin(CrmPlugin plugin)
        {
            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.RefreshNode(plugin.NodeId, true);
                this.SelectItem(this.trvPlugins.SelectedNode);
            }
        }

        public void RemovePlugin(Guid pluginId)
        {
            if (this.m_currentView == CrmViewType.Assembly)
            {
                this.trvPlugins.RemoveNode(pluginId);
                this.SelectItem(trvPlugins.SelectedNode);
            }
        }

        public void AddStep(CrmPluginStep step)
        {
            if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            Guid parentId;
            switch (this.m_currentView)
            {
                case CrmViewType.Assembly:
                    if (step.ServiceBusConfigurationId == Guid.Empty)
                    {
                        parentId = step.PluginId;
                    }
                    else
                    {
                        parentId = step.ServiceBusConfigurationId;
                    }

                    break;
                case CrmViewType.Entity:
                case CrmViewType.Message:
                    parentId = CreateCrmTreeNodes(this.m_currentView, step.MessageId, step.MessageEntityId, true).NodeId;

                    //Add to the step parent id list
                    if (!this.m_stepParentList.ContainsKey(step.StepId))
                    {
                        this.m_stepParentList.Add(step.StepId, parentId);
                    }

                    //Add to the CrmTreeNode
                    ((CrmTreeNode)trvPlugins[parentId]).AddChild(step);
                    break;
                default:
                    throw new NotImplementedException("View = " + this.m_currentView.ToString());
            }

            this.trvPlugins.AddNode(parentId, step);
            if (trvPlugins.SelectedNode != null && trvPlugins.SelectedNode.NodeId == parentId)
            {
                this.SelectItem(trvPlugins.SelectedNode);
            }
        }

        public void RefreshStep(CrmPluginStep step)
        {
            if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            this.trvPlugins.RefreshNode(step.NodeId, true);
            this.SelectItem(this.trvPlugins.SelectedNode);
        }

        public void RemoveStep(Guid stepId)
        {
            CrmPluginStep step = (CrmPluginStep)trvPlugins[stepId];

            this.trvPlugins.RemoveNode(stepId);
            this.SelectItem(trvPlugins.SelectedNode);
        }

        public void AddImage(CrmPluginImage image)
        {
            if (image == null)
            {
                throw new ArgumentNullException("image");
            }

            this.trvPlugins.AddNode(image.StepId, image);
            if (trvPlugins.SelectedNode != null && trvPlugins.SelectedNode.NodeId == image.StepId)
            {
                this.SelectItem(trvPlugins.SelectedNode);
            }
        }

        public void RefreshImage(CrmPluginImage image)
        {
            if (image == null)
            {
                throw new ArgumentNullException("image");
            }

            this.trvPlugins.RefreshNode(image.NodeId, true);
            this.SelectItem(this.trvPlugins.SelectedNode);
        }

        public void RemoveImage(Guid imageId)
        {
            this.trvPlugins.RemoveNode(imageId);
            this.SelectItem(trvPlugins.SelectedNode);
        }

        public bool IsNodeSystemItem(ICrmTreeNode node)
        {
            CrmTreeNode internalNode = node as CrmTreeNode;
            if (null != internalNode)
            {
                return true;
            }

            ICrmEntity entity = node as ICrmEntity;
            if (null != entity)
            {
                return entity.IsSystemCrmEntity;
            }
            else
            {
                return false;
            }
        }

        public void ShowSystemItemError(string text)
        {
            if (text == null)
            {
                MessageBox.Show(SYSTEM_ERROR_MESSAGE, SYSTEM_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(string.Format("{0}\n{1}", SYSTEM_ERROR_MESSAGE, text),
                    SYSTEM_ERROR_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectNode(Guid nodeId)
        {
            if (!trvPlugins.HasNode(nodeId))
            {
                throw new ArgumentException("Node is not in the tree", "nodeId");
            }

            trvPlugins.SelectedNode = trvPlugins[nodeId];
        }

        public void UpdateAutoExpand(bool newValue)
        {
            trvPlugins.AutoExpand = newValue;
        }
        #endregion

        #region Private Helper Methods
        private void SelectItem(ICrmTreeNode node)
        {
            //Reset the visibility and enabled properties because we don't what is enabled
            this.toolUpdate.Visible = false;
            this.mnuContextNodeUpdate.Visible = false;

            this.toolEnable.Visible = false;
            this.mnuContextNodeEnable.Visible = false;

            this.RefreshProfilerNodeMenu(null);

            bool isSystemNode = this.IsNodeSystemItem(trvPlugins.SelectedNode);
            if (node == null)
            {
                mnuContextNodeUnregister.Enabled = false;
                toolUnregister.Enabled = false;
                mnuContextNodeUnregister.Enabled = false;
                return;
            }
            else
            {
                //It should only be possible to unregister non-system components
                mnuContextNodeUnregister.Enabled = !isSystemNode;
                toolUnregister.Enabled = !isSystemNode;
            }

            DataTable gridTable = null;
            switch (node.NodeType)
            {
                case CrmTreeNodeType.ServiceEndpoint:
                    {
                        CrmServiceEndpoint serviceEndpoint = (CrmServiceEndpoint)node;

                        this.toolUpdate.Visible = true;
                        this.mnuContextNodeUpdate.Visible = true;
                        btnSave.Enabled = false;
                        //Load the data table and display information
                        gridTable = OrganizationHelper.CreateDataTable<CrmPluginStep>(CrmPluginStep.Columns, serviceEndpoint.Steps);
                    }
                    break;
                case CrmTreeNodeType.Assembly:
                    if (!isSystemNode)
                    {
                        CrmPluginAssembly assembly = (CrmPluginAssembly)node;

                        this.toolUpdate.Visible = true;
                        this.mnuContextNodeUpdate.Visible = true;
                        btnSave.Enabled = true;
                        //Load the data table and display information
                        gridTable = OrganizationHelper.CreateDataTable<CrmPlugin>(CrmPlugin.Columns, assembly.Plugins);
                    }
                    break;
                case CrmTreeNodeType.Plugin:
                case CrmTreeNodeType.WorkflowActivity:
                    {
                        CrmPlugin plugin = (CrmPlugin)node;
                        btnSave.Enabled = true;
                        //Load the data table and display information
                        gridTable = OrganizationHelper.CreateDataTable<CrmPluginStep>(CrmPluginStep.Columns, plugin.Steps);
                    }
                    break;
                case CrmTreeNodeType.Step:
                    {
                        CrmPluginStep step = (CrmPluginStep)node;
                        btnSave.Enabled = false;
                        this.UpdateEnableButton(step.Enabled);

                        if (true/*!OrganizationHelper.IsProfilerSupported*/ ||
                            !(step.IsProfiled || step.Organization.Plugins[step.PluginId].IsProfilerPlugin))
                        {
                            this.toolEnable.Visible = true;
                            this.mnuContextNodeEnable.Visible = true;
                        }

                        this.toolUpdate.Visible = true;
                        this.mnuContextNodeUpdate.Visible = true;

                        this.RefreshProfilerNodeMenu(step);

                        //Load the data table and display information
                        gridTable = OrganizationHelper.CreateDataTable<CrmPluginImage>(CrmPluginImage.Columns, step.Images);
                    }
                    break;
                case CrmTreeNodeType.Image:
                    {
                        this.toolUpdate.Visible = true;
                        this.mnuContextNodeUpdate.Visible = true;
                        CrmPluginImage image = (CrmPluginImage)node;
                        btnSave.Enabled = false;
                        //Load the data table and display information
                        gridTable = null;
                    }
                    break;
                case CrmTreeNodeType.Message:
                case CrmTreeNodeType.MessageEntity:
                    {
                        toolUnregister.Enabled = false;
                        mnuContextNodeUnregister.Enabled = false;
                        btnSave.Enabled = false;
                        CrmTreeNode treeNode = (CrmTreeNode)node;
                        switch (treeNode.ChildNodeType)
                        {
                            case CrmTreeNodeType.Message:
                                {
                                    gridTable = OrganizationHelper.CreateDataTable<CrmMessage>(CrmMessage.Columns,
                                        (CrmMessage[])treeNode.ToEntityArray(CrmTreeNodeType.Message));
                                }
                                break;
                            case CrmTreeNodeType.MessageEntity:
                                {
                                    gridTable = OrganizationHelper.CreateDataTable<CrmMessageEntity>(CrmMessageEntity.Columns,
                                        (CrmMessageEntity[])treeNode.ToEntityArray(CrmTreeNodeType.MessageEntity));
                                }
                                break;
                            case CrmTreeNodeType.Step:
                                {
                                    gridTable = OrganizationHelper.CreateDataTable<CrmPluginStep>(CrmPluginStep.Columns,
                                        (CrmPluginStep[])treeNode.ToEntityArray(CrmTreeNodeType.Step));
                                }
                                break;
                            default:
                                gridTable = null;
                                break;
                        }
                    }
                    break;
                default:

                    throw new NotImplementedException("NodeType = " + node.NodeType.ToString());
            }

            //Update the properties grid
            {
                CrmTreeNode treeNode = node as CrmTreeNode;
                if (null == treeNode)
                {
                    this.propGridEntity.SelectedObject = node;
                }
                else
                {
                    this.propGridEntity.SelectedObject = treeNode.Entity;
                }
            }

            this.m_dataRowIndex = -1;
            this.m_dataRowId = Guid.Empty;
            if (gridTable == null)
            {
                grpGrid.Visible = false;
                splitterDisplay.Height = grpGrid.Bottom - splitterDisplay.Top;
            }
            else
            {
                grpGrid.Visible = true;
                splitterDisplay.Height = grpGrid.Top - grpPlugins.Margin.Bottom - grpGrid.Margin.Top - splitterDisplay.Top;

                //Create the list of values

                //Create the new DataSet
                DataSet set = new DataSet("Grid");
                set.Tables.Add(gridTable);

                grvData.DataSource = set.DefaultViewManager;
                grvData.DataMember = gridTable.TableName;
                grvData.Columns["Id"].Visible = false;
            }
        }

        private void LoadNodes()
        {
            this.LoadNodes(this.m_currentView);
        }

        private void LoadNodes(CrmViewType view)
        {
            ToolStripItem currentCheckedItem = null;
            ToolStripItem newCheckedItem = null;

            foreach (ToolStripItem item in toolView.DropDownItems)
            {
                if (item.Tag != null && item.Tag.GetType() == typeof(CrmViewType))
                {
                    var checkedProp = item.GetType().GetProperty("Checked", typeof(bool));
                    if (checkedProp != null)
                    {
                        if ((bool)checkedProp.GetValue(item, null))
                        {
                            currentCheckedItem = item;
                        }
                        else if ((CrmViewType)item.Tag == view)
                        {
                            newCheckedItem = item;
                        }
                    }
                }

                if (currentCheckedItem != null && newCheckedItem != null)
                {
                    break;
                }
            }

            // Create the new view
            this.Enabled = false;
            try
            {
                switch (view)
                {
                    case CrmViewType.Assembly:
                        this.m_rootNodeList = null;
                        this.m_stepParentList = null;
                        this.m_viewNodeList = null;

                        List<ICrmTreeNode> nodes = new List<ICrmTreeNode>();
                        foreach (CrmPluginAssembly assembly in this.Organization.Assemblies)
                        {
                            // If the same assembly name used for any other custom plugin assembly then that need to be added
                            if ((CrmServiceEndpoint.ServiceBusPluginAssemblyName != assembly.Name || 0 != assembly.CustomizationLevel) &&
                                !assembly.IsProfilerAssembly)
                            {
                                nodes.Add(assembly);
                            }
                        }

                        nodes.AddRange(this.Organization.ServiceEndpoints.ToArray());

                        if (null != this.Organization.ProfilerPlugin)
                        {
                            nodes.Add(this.Organization.ProfilerPlugin);
                        }

                        trvPlugins.LoadNodes(nodes.ToArray());
                        break;
                    case CrmViewType.Entity:
                    case CrmViewType.Message:
                        {
                            //Create the Root Node List
                            if (null == this.m_rootNodeList)
                            {
                                this.m_rootNodeList = new Dictionary<string, CrmTreeNode>();
                            }
                            else
                            {
                                this.m_rootNodeList.Clear();
                            }

                            //Create the Step Parent Node List
                            if (null == this.m_stepParentList)
                            {
                                this.m_stepParentList = new Dictionary<Guid, Guid>();
                            }
                            else
                            {
                                this.m_stepParentList.Clear();
                            }

                            //Create the View Node List
                            if (null == this.m_viewNodeList)
                            {
                                this.m_viewNodeList = new Dictionary<Guid, Guid>();
                            }
                            else
                            {
                                this.m_viewNodeList.Clear();
                            }

                            //Retrieve the of steps
                            foreach (var step in this.Organization.Steps)
                            {
                                if (step.MessageId != Guid.Empty)
                                {
                                    CrmTreeNode parentNode = this.CreateCrmTreeNodes(view, step.MessageId, step.MessageEntityId, false);

                                    parentNode.AddChild(step);
                                    this.m_stepParentList.Add(step.StepId, parentNode.NodeId);
                                }
                            }

                            var nodeList = new CrmTreeNode[this.m_rootNodeList.Count];
                            this.m_rootNodeList.Values.CopyTo(nodeList, 0);

                            trvPlugins.LoadNodes(nodeList);
                        }
                        break;
                    default:
                        throw new NotImplementedException("View = " + view.ToString());
                }

                this.m_currentView = view;

                if (currentCheckedItem != null)
                {
                    currentCheckedItem.GetType().GetProperty("Checked",
                        typeof(bool)).SetValue(currentCheckedItem, false, null);
                }

                if (newCheckedItem != null)
                {
                    newCheckedItem.GetType().GetProperty("Checked",
                        typeof(bool)).SetValue(newCheckedItem, true, null);
                }
            }
            catch (Exception ex)
            {
                ErrorMessageForm.ShowErrorMessageBox(this, "Unable to change the view", "View Error", ex);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private CrmTreeNode CreateCrmTreeNodes(CrmViewType view, Guid messageId, Guid messageEntityId, bool addToTree)
        {
            if (Guid.Empty == messageId)
            {
                throw new ArgumentException("Invalid Guid", "messageId");
            }

            CrmTreeNode rootNode, childNode;
            switch (view)
            {
                case CrmViewType.Message:
                    {
                        rootNode = new CrmTreeNode(this.m_org.Messages[messageId]);
                        if (Guid.Empty == messageEntityId)
                        {
                            childNode = new CrmTreeNode(new CrmMessageEntity(Organization, messageId, Guid.Empty,
                                "none", "none", CrmPluginStepDeployment.Both, null, null));
                        }
                        else
                        {
                            childNode = new CrmTreeNode(this.m_org.MessageEntities[messageEntityId]);
                        }
                    }
                    break;
                case CrmViewType.Entity:
                    {
                        if (Guid.Empty == messageEntityId)
                        {
                            rootNode = new CrmTreeNode(new CrmMessageEntity(Organization, messageId, Guid.Empty, "none", "none",
                                CrmPluginStepDeployment.Both, null, null));
                        }
                        else
                        {
                            rootNode = new CrmTreeNode(this.m_org.MessageEntities[messageEntityId]);
                        }
                        childNode = new CrmTreeNode(this.m_org.Messages[messageId]);
                    }
                    break;
                default:
                    throw new NotImplementedException("View = " + view.ToString());
            }

            Guid rootNodeId = rootNode.NodeId;
            Guid childNodeId = childNode.NodeId;

            if (this.m_rootNodeList.ContainsKey(rootNode.NodeText))
            {
                rootNode = this.m_rootNodeList[rootNode.NodeText];
            }
            else
            {
                rootNode.NodeId = Guid.NewGuid();
                this.m_rootNodeList.Add(rootNode.NodeText, rootNode);

                if (addToTree)
                {
                    trvPlugins.AddNode(Guid.Empty, rootNode);
                }
            }

            if (rootNode.HasChild(childNode.NodeText))
            {
                childNode = (CrmTreeNode)rootNode[childNode.NodeText];
            }
            else
            {
                childNode.NodeId = Guid.NewGuid();
                rootNode.AddChild(childNode);

                if (addToTree)
                {
                    trvPlugins.AddNode(rootNode.NodeId, childNode);
                }
            }

            if (!this.m_viewNodeList.ContainsKey(rootNodeId))
            {
                this.m_viewNodeList.Add(rootNodeId, rootNode.NodeId);
            }

            if (!this.m_viewNodeList.ContainsKey(childNodeId))
            {
                this.m_viewNodeList.Add(childNodeId, childNode.NodeId);
            }

            return childNode;
        }

        private void UpdateEnableButton(bool currentlyEnabled)
        {
            string imageKey;
            if (currentlyEnabled)
            {
                toolEnable.Text = "&Disable";
                imageKey = "disableStep";
            }
            else
            {
                toolEnable.Text = "&Enable";
                imageKey = "enableStep";
            }

            toolEnable.Image = imlEnableImages.Images[imageKey];

            mnuContextNodeEnable.Text = toolEnable.Text;
            mnuContextNodeEnable.Image = toolEnable.Image;
        }

        /// <summary>
        /// Removes the given CrmTreeNode. If its parent does not have any other children, it will also be removed.
        /// </summary>
        /// <param name="nodeId">Node to be removed</param>
        private void RemoveCrmTreeNodesCascadeUp(CrmTreeNode node)
        {
            if (null == node)
            {
                throw new ArgumentNullException("node");
            }

            //Check if we are going to be removing this node
            while (null != node && 0 == node.ChildCount)
            {
                //Retrieve the parent node
                CrmTreeNode parentNode;
                if (Guid.Empty == node.ParentNodeId)
                {
                    parentNode = null;

                    //This is a root element, remove it from the list
                    if (this.m_rootNodeList.ContainsKey(node.NodeText))
                    {
                        this.m_rootNodeList.Remove(node.NodeText);
                    }
                }
                else
                {
                    parentNode = (CrmTreeNode)trvPlugins[node.ParentNodeId];
                    parentNode.RemoveChild(node.NodeText);
                }

                //Remove the node from the tree
                trvPlugins.RemoveNode(node.NodeId);

                //Set the current node to be the parent node
                node = parentNode;
            }
        }

        private void RefreshProfilerGeneralMenu()
        {
            if (false/*OrganizationHelper.IsProfilerSupported*/)
            {
                mnuContextGeneralProfilerInstall.Visible = true;
                mnuContextGeneralSepProfiler.Visible = true;

                toolProfilerInstall.Visible = true;
                toolProfilerSep.Visible = true;
                toolProfilerDebug.Visible = true;

                if (null != this.m_org.ProfilerPlugin)
                {
                    mnuContextGeneralProfilerInstall.Text = "Stop All P&rofiling && Uninstall Profiler";
                    mnuContextGeneralProfilerInstall.Image = imlEnableImages.Images["UninstallProfiler"];

                    toolProfilerInstall.Image = imlEnableImages.Images["UninstallProfiler"];
                    toolProfilerInstall.Text = "Uninstall Pr&ofiler";
                }
                else
                {
                    mnuContextGeneralProfilerInstall.Text = "Install P&rofiler";
                    mnuContextGeneralProfilerInstall.Image = imlEnableImages.Images["InstallProfiler"];

                    toolProfilerInstall.Image = imlEnableImages.Images["InstallProfiler"];
                    toolProfilerInstall.Text = "Install Pr&ofiler";
                }
            }
            else
            {
                mnuContextGeneralProfilerInstall.Visible = false;
                mnuContextGeneralSepProfiler.Visible = false;

                toolProfilerInstall.Visible = false;
                toolProfilerDebug.Visible = false;
                toolProfilerSep.Visible = false;
            }
        }

        private void RefreshProfilerNodeMenu(CrmPluginStep step)
        {
            mnuContextNodeProfilerEnable.Visible = false;
            mnuContextNodeSepProfiler.Visible = false;

            toolProfilerEnable.Visible = false;

            if (false/*OrganizationHelper.IsProfilerSupported*/ && null != step &&
                null != step.Organization && null != step.Organization.ProfilerPlugin)
            {
                if (!step.Organization.Plugins[step.PluginId].IsProfilerPlugin &&
                    (step.IsProfiled || step.Enabled))
                {
                    mnuContextNodeProfilerEnable.Visible = true;
                    mnuContextNodeSepProfiler.Visible = true;

                    toolProfilerEnable.Visible = true;

                    if (step.IsProfiled)
                    {
                        mnuContextNodeProfilerEnable.Text = "Stop P&rofiling";
                        mnuContextNodeProfilerEnable.Image = imlEnableImages.Images["DisableProfiler"];

                        toolProfilerEnable.Text = "Stop Pro&filing";
                        toolProfilerEnable.Image = imlEnableImages.Images["DisableProfiler"];
                    }
                    else
                    {
                        mnuContextNodeProfilerEnable.Text = "Start P&rofiling";
                        mnuContextNodeProfilerEnable.Image = imlEnableImages.Images["EnableProfiler"];

                        toolProfilerEnable.Text = "Pro&file";
                        toolProfilerEnable.Image = imlEnableImages.Images["EnableProfiler"];
                    }
                }
            }
        }
        #endregion

        #region Private Classes & Enums
        private sealed class CrmEntitySorter : IComparer<ICrmTreeNode>
        {
            public int Compare(ICrmTreeNode node1, ICrmTreeNode node2)
            {
                if (node1 == null)
                {
                    return -1;
                }
                else if (node2 == null)
                {
                    return 1;
                }
                else if (node1.NodeType != node2.NodeType)
                {
                    return ((int)node1.NodeType - (int)node2.NodeType);
                }
                else if (node1.NodeType == CrmTreeNodeType.Step)
                {
                    CrmPluginStep step1 = (CrmPluginStep)node1;
                    CrmPluginStep step2 = (CrmPluginStep)node2;

                    if (step1.Rank == step2.Rank)
                    {
                        if (step1.CreatedOn == null && step2.CreatedOn == null)
                        {
                            return 0;
                        }
                        else if (step1.CreatedOn == null)
                        {
                            return -1;
                        }
                        else if (step2.CreatedOn == null)
                        {
                            return 1;
                        }
                        else
                        {
                            return DateTime.Compare((DateTime)step1.CreatedOn, (DateTime)step2.CreatedOn);
                        }
                    }
                    else if (step1.Rank < step2.Rank)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return string.Compare(GetNodeText(node1), GetNodeText(node2), false);
                }
            }

            #region Private Helper Methods
            private string GetNodeText(ICrmTreeNode node)
            {
                if (node == null || node.NodeText == null)
                {
                    return null;
                }
                else
                {
                    return node.NodeText;
                }
            }
            #endregion
        }

        private enum CrmViewType
        {
            Assembly,
            Message,
            Entity
        }

        private sealed class CrmTreeNode : ICrmTreeNode
        {
            private ICrmEntity m_entity;
            private Guid m_parentNodeId = Guid.Empty;
            private Guid m_origNodeId;
            private Guid m_nodeId;
            private string m_nodeText;
            private CrmTreeNodeType m_type;
            private string m_typeLabel;
            private CrmTreeNodeImageType m_imageType;
            private CrmTreeNodeImageType m_selectedImageType;

            private CrmTreeNodeType m_childType = CrmTreeNodeType.None;
            private Dictionary<string, CrmTreeNode> m_childList = null;
            private Dictionary<Guid, CrmPluginStep> m_stepList = null;

            public CrmTreeNode(CrmMessage message)
            {
                if (message == null)
                {
                    throw new ArgumentNullException("message");
                }

                this.m_entity = message;
                this.m_nodeId = message.MessageId;
                this.m_nodeText = message.Name;
                this.m_type = CrmTreeNodeType.Message;
                this.m_typeLabel = "Message";
                this.m_imageType = CrmTreeNodeImageType.Message;
                this.m_selectedImageType = CrmTreeNodeImageType.MessageSelected;

                this.m_origNodeId = this.m_nodeId;

                this.UpdateNodeText();
            }

            public CrmTreeNode(CrmMessageEntity msgEntity)
            {
                if (msgEntity == null)
                {
                    throw new ArgumentNullException("entity");
                }

                this.m_entity = msgEntity;
                this.m_nodeId = msgEntity.MessageEntityId;
                if (string.IsNullOrEmpty(msgEntity.PrimaryEntity))
                {
                    this.m_nodeText = "No Entity";
                }
                else if (string.IsNullOrEmpty(msgEntity.SecondaryEntity) ||
                    msgEntity.SecondaryEntity.Equals("none", StringComparison.CurrentCultureIgnoreCase))
                {
                    this.m_nodeText = msgEntity.PrimaryEntity;
                }
                else
                {
                    this.m_nodeText = string.Format("{0} / {1}", msgEntity.PrimaryEntity, msgEntity.SecondaryEntity);
                }
                this.m_type = CrmTreeNodeType.MessageEntity;
                this.m_typeLabel = "Entity";
                this.m_imageType = CrmTreeNodeImageType.MessageEntity;
                this.m_selectedImageType = CrmTreeNodeImageType.MessageEntitySelected;

                this.m_origNodeId = this.m_nodeId;

                this.UpdateNodeText();
            }

            public CrmTreeNode(Guid nodeId, string text, CrmTreeNodeType type,
                CrmTreeNodeImageType imageType, CrmTreeNodeImageType selectedImageType)
            {
                if (text == null)
                {
                    throw new ArgumentNullException("text");
                }

                this.m_entity = null;
                this.m_nodeId = nodeId;
                this.m_nodeText = text;
                this.m_type = type;
                this.m_imageType = imageType;
                this.m_selectedImageType = selectedImageType;

                this.m_origNodeId = this.m_nodeId;

                this.UpdateNodeText();
            }

            public void AddChild(CrmPluginStep node)
            {
                if (node == null)
                {
                    throw new ArgumentNullException("node");
                }
                else if (this.m_childType != CrmTreeNodeType.None && this.m_childType != node.NodeType)
                {
                    throw new ArgumentException("Child Node Type has already been determined");
                }
                else if (this.m_childType == CrmTreeNodeType.None)
                {
                    this.m_childType = node.NodeType;
                    this.m_stepList = new Dictionary<Guid, CrmPluginStep>();
                }

                this.m_stepList.Add(node.NodeId, node);
            }

            public void AddChild(CrmTreeNode node)
            {
                if (node == null)
                {
                    throw new ArgumentNullException("node");
                }
                else if (this.m_childType != CrmTreeNodeType.None && this.m_childType != node.NodeType)
                {
                    throw new ArgumentException("Child Node Type has already been determined");
                }
                else if (this.m_childType == CrmTreeNodeType.None)
                {
                    this.m_childType = node.NodeType;
                    this.m_childList = new Dictionary<string, CrmTreeNode>();
                }

                node.m_parentNodeId = this.m_nodeId;
                this.m_childList.Add(node.NodeText, node);
            }

            public void RemoveChild(Guid key)
            {
                if (this.m_stepList == null)
                {
                    throw new ArgumentException("Id is not in the list");
                }
                else
                {
                    this.m_stepList.Remove(key);
                }
            }

            public void RemoveChild(string key)
            {
                if (this.m_childList == null)
                {
                    throw new ArgumentException("Id is not in the list");
                }
                else
                {
                    this.m_childList.Remove(key);
                }
            }

            public bool HasChild(Guid id)
            {
                if (this.m_stepList != null)
                {
                    return this.m_stepList.ContainsKey(id);
                }
                else
                {
                    return false;
                }
            }

            public bool HasChild(string nodeText)
            {
                if (this.m_childList != null)
                {
                    return this.m_childList.ContainsKey(nodeText);
                }
                else
                {
                    return false;
                }
            }

            public CrmPluginStep this[Guid id]
            {
                get
                {
                    return this.m_stepList[id];
                }
            }

            public CrmTreeNode this[string text]
            {
                get
                {
                    return this.m_childList[text];
                }
            }

            public CrmTreeNodeType ChildNodeType
            {
                get
                {
                    return this.m_childType;
                }
            }

            public ICrmEntity[] ToEntityArray(CrmTreeNodeType type)
            {
                if (this.m_childType == CrmTreeNodeType.None)
                {
                    this.m_childType = type;
                }
                else if (this.m_childType != type)
                {
                    throw new ArgumentNullException("Child type already determined");
                }

                ICrmEntity[] childList;
                int childIndex = 0;
                switch (type)
                {
                    case CrmTreeNodeType.Message:
                        childList = new CrmMessage[this.m_childList.Count];
                        foreach (CrmTreeNode childNode in this.m_childList.Values)
                        {
                            childList[childIndex++] = (CrmMessage)childNode.Entity;
                        }
                        break;
                    case CrmTreeNodeType.MessageEntity:
                        childList = new CrmMessageEntity[this.m_childList.Count];
                        foreach (CrmTreeNode childNode in this.m_childList.Values)
                        {
                            childList[childIndex++] = (CrmMessageEntity)childNode.Entity;
                        }
                        break;
                    case CrmTreeNodeType.Step:
                        childList = new CrmPluginStep[this.m_stepList.Count];
                        this.m_stepList.Values.CopyTo((CrmPluginStep[])childList, 0);
                        break;
                    default:
                        throw new NotImplementedException("Type = " + type.ToString());
                }

                return childList;
            }

            public Guid ParentNodeId
            {
                get
                {
                    return this.m_parentNodeId;
                }
            }

            public Guid OriginalNodeId
            {
                get
                {
                    return this.m_origNodeId;
                }
            }

            public int ChildCount
            {
                get
                {
                    if (null != this.m_childList)
                    {
                        return this.m_childList.Count;
                    }
                    else if (null != this.m_stepList)
                    {
                        return this.m_stepList.Count;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }

            #region ICrmTreeNode Members
            public ICrmEntity Entity
            {
                get
                {
                    return this.m_entity;
                }
            }

            public Guid NodeId
            {
                get
                {
                    return this.m_nodeId;
                }
                set
                {
                    this.m_nodeId = value;

                    if (null != this.m_childList)
                    {
                        foreach (CrmTreeNode childNode in this.m_childList.Values)
                        {
                            childNode.m_parentNodeId = value;
                        }
                    }
                }
            }

            public string NodeText
            {
                get
                {
                    return this.m_nodeText;
                }
            }

            public CrmTreeNodeType NodeType
            {
                get
                {
                    return this.m_type;
                }
            }

            public string NodeTypeLabel
            {
                get
                {
                    return this.m_typeLabel;
                }
            }

            public ICrmTreeNode[] NodeChildren
            {
                get
                {
                    if (this.m_stepList != null)
                    {
                        CrmPluginStep[] nodeList = new CrmPluginStep[this.m_stepList.Count];
                        this.m_stepList.Values.CopyTo(nodeList, 0);

                        return nodeList;
                    }
                    else if (this.m_childList != null)
                    {
                        CrmTreeNode[] nodeList = new CrmTreeNode[this.m_childList.Count];
                        this.m_childList.Values.CopyTo(nodeList, 0);

                        return nodeList;
                    }
                    else
                    {
                        return new ICrmTreeNode[0];
                    }
                }
            }

            public CrmTreeNodeImageType NodeImageType
            {
                get
                {
                    return this.m_imageType;
                }
            }

            public CrmTreeNodeImageType NodeSelectedImageType
            {
                get
                {
                    return this.m_selectedImageType;
                }
            }
            #endregion

            #region Private Helpers
            private void UpdateNodeText()
            {
                string prefix;
                switch (this.m_type)
                {
                    case CrmTreeNodeType.Message:
                        prefix = "Message";
                        break;
                    case CrmTreeNodeType.MessageEntity:
                        prefix = "Entity";
                        break;
                    default:
                        throw new NotImplementedException("NodeType = " + this.m_type.ToString());
                }

                this.m_nodeText = string.Format("({0}) {1}", prefix, this.m_nodeText);
            }
            #endregion
        }
        #endregion

        private void toolClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }
    }
}
