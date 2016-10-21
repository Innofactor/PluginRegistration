namespace Xrm.Sdk.PluginRegistration
{
    partial class MainControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mnuContextNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextNodeAssemblyRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeStepRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeImageRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextNodeSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextNodeEnable = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextNodeUnregister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuContextGeneralAssemblyRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGeneralStepRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGeneralImageRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGeneralSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuContextGeneralRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContextGeneralSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.grvData = new System.Windows.Forms.DataGridView();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolRegister = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolAssemblyRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStepRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolImageRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolServiceEndpointRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolView = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolViewAssembly = new System.Windows.Forms.ToolStripMenuItem();
            this.toolViewEntity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolViewMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolProfilerSep = new System.Windows.Forms.ToolStripSeparator();
            this.toolProfilerInstall = new System.Windows.Forms.ToolStripButton();
            this.toolProfilerDebug = new System.Windows.Forms.ToolStripButton();
            this.toolProfilerEnable = new System.Windows.Forms.ToolStripButton();
            this.toolSepCommon1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolEnable = new System.Windows.Forms.ToolStripButton();
            this.toolUnregister = new System.Windows.Forms.ToolStripButton();
            this.toolCommonSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolSearch = new System.Windows.Forms.ToolStripButton();
            this.toolCommonSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolClose = new System.Windows.Forms.ToolStripButton();
            this.imlEnableImages = new System.Windows.Forms.ImageList(this.components);
            this.splitterDisplay = new System.Windows.Forms.SplitContainer();
            this.grpPlugins = new System.Windows.Forms.GroupBox();
            this.trvPlugins = new Xrm.Sdk.PluginRegistration.Controls.CrmTreeControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.propGridEntity = new System.Windows.Forms.PropertyGrid();
            this.mnuContextNode.SuspendLayout();
            this.mnuContextGeneral.SuspendLayout();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitterDisplay)).BeginInit();
            this.splitterDisplay.Panel1.SuspendLayout();
            this.splitterDisplay.Panel2.SuspendLayout();
            this.splitterDisplay.SuspendLayout();
            this.grpPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuContextNode
            // 
            this.mnuContextNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextNodeAssemblyRegister,
            this.mnuContextNodeStepRegister,
            this.mnuContextNodeImageRegister,
            this.mnuContextNodeSep1,
            this.mnuContextNodeSearch,
            this.mnuContextNodeRefresh,
            this.mnuContextNodeSep2,
            this.mnuContextNodeEnable,
            this.mnuContextNodeUpdate,
            this.mnuContextNodeUnregister});
            this.mnuContextNode.Name = "mnuContextNode";
            this.mnuContextNode.Size = new System.Drawing.Size(198, 192);
            // 
            // mnuContextNodeAssemblyRegister
            // 
            this.mnuContextNodeAssemblyRegister.Name = "mnuContextNodeAssemblyRegister";
            this.mnuContextNodeAssemblyRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeAssemblyRegister.Text = "Register New &Assembly";
            this.mnuContextNodeAssemblyRegister.Click += new System.EventHandler(this.toolAssemblyRegister_Click);
            // 
            // mnuContextNodeStepRegister
            // 
            this.mnuContextNodeStepRegister.Name = "mnuContextNodeStepRegister";
            this.mnuContextNodeStepRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeStepRegister.Text = "Register New S&tep";
            this.mnuContextNodeStepRegister.Click += new System.EventHandler(this.toolStepRegister_Click);
            // 
            // mnuContextNodeImageRegister
            // 
            this.mnuContextNodeImageRegister.Name = "mnuContextNodeImageRegister";
            this.mnuContextNodeImageRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeImageRegister.Text = "Register New &Image";
            this.mnuContextNodeImageRegister.Click += new System.EventHandler(this.toolImageRegister_Click);
            // 
            // mnuContextNodeSep1
            // 
            this.mnuContextNodeSep1.Name = "mnuContextNodeSep1";
            this.mnuContextNodeSep1.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuContextNodeSearch
            // 
            this.mnuContextNodeSearch.Name = "mnuContextNodeSearch";
            this.mnuContextNodeSearch.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeSearch.Text = "&Search";
            this.mnuContextNodeSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // mnuContextNodeRefresh
            // 
            this.mnuContextNodeRefresh.Name = "mnuContextNodeRefresh";
            this.mnuContextNodeRefresh.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeRefresh.Text = "Re&fresh";
            this.mnuContextNodeRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // mnuContextNodeSep2
            // 
            this.mnuContextNodeSep2.Name = "mnuContextNodeSep2";
            this.mnuContextNodeSep2.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuContextNodeEnable
            // 
            this.mnuContextNodeEnable.Name = "mnuContextNodeEnable";
            this.mnuContextNodeEnable.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeEnable.Text = "&Disable";
            this.mnuContextNodeEnable.Click += new System.EventHandler(this.toolEnable_Click);
            // 
            // mnuContextNodeUpdate
            // 
            this.mnuContextNodeUpdate.Name = "mnuContextNodeUpdate";
            this.mnuContextNodeUpdate.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeUpdate.Text = "&Update";
            this.mnuContextNodeUpdate.Click += new System.EventHandler(this.toolUpdate_Click);
            // 
            // mnuContextNodeUnregister
            // 
            this.mnuContextNodeUnregister.Name = "mnuContextNodeUnregister";
            this.mnuContextNodeUnregister.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuContextNodeUnregister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextNodeUnregister.Text = "U&nregister";
            this.mnuContextNodeUnregister.Click += new System.EventHandler(this.toolUnregister_Click);
            // 
            // mnuContextGeneral
            // 
            this.mnuContextGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuContextGeneralAssemblyRegister,
            this.mnuContextGeneralStepRegister,
            this.mnuContextGeneralImageRegister,
            this.mnuContextGeneralSep1,
            this.mnuContextGeneralRefresh,
            this.mnuContextGeneralSearch});
            this.mnuContextGeneral.Name = "mnuContextTree";
            this.mnuContextGeneral.Size = new System.Drawing.Size(198, 142);
            // 
            // mnuContextGeneralAssemblyRegister
            // 
            this.mnuContextGeneralAssemblyRegister.Name = "mnuContextGeneralAssemblyRegister";
            this.mnuContextGeneralAssemblyRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextGeneralAssemblyRegister.Text = "Register New &Assembly";
            this.mnuContextGeneralAssemblyRegister.Click += new System.EventHandler(this.toolAssemblyRegister_Click);
            // 
            // mnuContextGeneralStepRegister
            // 
            this.mnuContextGeneralStepRegister.Name = "mnuContextGeneralStepRegister";
            this.mnuContextGeneralStepRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextGeneralStepRegister.Text = "Register New S&tep";
            this.mnuContextGeneralStepRegister.Click += new System.EventHandler(this.toolStepRegister_Click);
            // 
            // mnuContextGeneralImageRegister
            // 
            this.mnuContextGeneralImageRegister.Name = "mnuContextGeneralImageRegister";
            this.mnuContextGeneralImageRegister.Size = new System.Drawing.Size(197, 22);
            this.mnuContextGeneralImageRegister.Text = "Register New &Image";
            this.mnuContextGeneralImageRegister.Click += new System.EventHandler(this.toolImageRegister_Click);
            // 
            // mnuContextGeneralSep1
            // 
            this.mnuContextGeneralSep1.Name = "mnuContextGeneralSep1";
            this.mnuContextGeneralSep1.Size = new System.Drawing.Size(194, 6);
            // 
            // mnuContextGeneralRefresh
            // 
            this.mnuContextGeneralRefresh.Name = "mnuContextGeneralRefresh";
            this.mnuContextGeneralRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuContextGeneralRefresh.Size = new System.Drawing.Size(197, 22);
            this.mnuContextGeneralRefresh.Text = "Re&fresh";
            this.mnuContextGeneralRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // mnuContextGeneralSearch
            // 
            this.mnuContextGeneralSearch.Name = "mnuContextGeneralSearch";
            this.mnuContextGeneralSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuContextGeneralSearch.Size = new System.Drawing.Size(197, 22);
            this.mnuContextGeneralSearch.Text = "&Search";
            this.mnuContextGeneralSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // grpGrid
            // 
            this.grpGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGrid.Controls.Add(this.grvData);
            this.grpGrid.Location = new System.Drawing.Point(0, 737);
            this.grpGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpGrid.Size = new System.Drawing.Size(1268, 335);
            this.grpGrid.TabIndex = 1;
            this.grpGrid.TabStop = false;
            // 
            // grvData
            // 
            this.grvData.AllowUserToAddRows = false;
            this.grvData.AllowUserToDeleteRows = false;
            this.grvData.AllowUserToOrderColumns = true;
            this.grvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grvData.Location = new System.Drawing.Point(9, 18);
            this.grvData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grvData.Name = "grvData";
            this.grvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvData.ShowCellErrors = false;
            this.grvData.ShowEditingIcon = false;
            this.grvData.ShowRowErrors = false;
            this.grvData.Size = new System.Drawing.Size(1250, 308);
            this.grvData.TabIndex = 1;
            this.grvData.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvData_RowEnter);
            this.grvData.DoubleClick += new System.EventHandler(this.grvData_DoubleClick);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolRegister,
            this.toolView,
            this.toolProfilerSep,
            this.toolProfilerInstall,
            this.toolProfilerDebug,
            this.toolProfilerEnable,
            this.toolSepCommon1,
            this.toolUpdate,
            this.toolEnable,
            this.toolUnregister,
            this.toolCommonSep2,
            this.toolRefresh,
            this.toolSearch,
            this.toolCommonSep3,
            this.toolClose});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolBar.Size = new System.Drawing.Size(1276, 25);
            this.toolBar.TabIndex = 9;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolRegister
            // 
            this.toolRegister.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAssemblyRegister,
            this.toolStepRegister,
            this.toolImageRegister,
            this.toolServiceEndpointRegister});
            this.toolRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRegister.Name = "toolRegister";
            this.toolRegister.Size = new System.Drawing.Size(62, 22);
            this.toolRegister.Text = "&Register";
            // 
            // toolAssemblyRegister
            // 
            this.toolAssemblyRegister.Name = "toolAssemblyRegister";
            this.toolAssemblyRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolAssemblyRegister.Size = new System.Drawing.Size(274, 22);
            this.toolAssemblyRegister.Text = "Register New &Assembly";
            this.toolAssemblyRegister.Click += new System.EventHandler(this.toolAssemblyRegister_Click);
            // 
            // toolStepRegister
            // 
            this.toolStepRegister.Name = "toolStepRegister";
            this.toolStepRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.toolStepRegister.Size = new System.Drawing.Size(274, 22);
            this.toolStepRegister.Text = "Register New S&tep";
            this.toolStepRegister.Click += new System.EventHandler(this.toolStepRegister_Click);
            // 
            // toolImageRegister
            // 
            this.toolImageRegister.Name = "toolImageRegister";
            this.toolImageRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.toolImageRegister.Size = new System.Drawing.Size(274, 22);
            this.toolImageRegister.Text = "Register New &Image";
            this.toolImageRegister.Click += new System.EventHandler(this.toolImageRegister_Click);
            // 
            // toolServiceEndpointRegister
            // 
            this.toolServiceEndpointRegister.Name = "toolServiceEndpointRegister";
            this.toolServiceEndpointRegister.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolServiceEndpointRegister.Size = new System.Drawing.Size(274, 22);
            this.toolServiceEndpointRegister.Text = "Register New Service &Endpoint";
            // 
            // toolView
            // 
            this.toolView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolViewAssembly,
            this.toolViewEntity,
            this.toolViewMessage});
            this.toolView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolView.Name = "toolView";
            this.toolView.Size = new System.Drawing.Size(45, 22);
            this.toolView.Text = "View";
            // 
            // toolViewAssembly
            // 
            this.toolViewAssembly.Name = "toolViewAssembly";
            this.toolViewAssembly.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.toolViewAssembly.Size = new System.Drawing.Size(256, 22);
            this.toolViewAssembly.Text = "Display by &Assembly";
            this.toolViewAssembly.Click += new System.EventHandler(this.toolView_Click);
            // 
            // toolViewEntity
            // 
            this.toolViewEntity.Name = "toolViewEntity";
            this.toolViewEntity.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.toolViewEntity.Size = new System.Drawing.Size(256, 22);
            this.toolViewEntity.Text = "Display by &Entity";
            this.toolViewEntity.Click += new System.EventHandler(this.toolView_Click);
            // 
            // toolViewMessage
            // 
            this.toolViewMessage.Name = "toolViewMessage";
            this.toolViewMessage.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.toolViewMessage.Size = new System.Drawing.Size(256, 22);
            this.toolViewMessage.Text = "Display by &Message";
            this.toolViewMessage.Click += new System.EventHandler(this.toolView_Click);
            // 
            // toolProfilerSep
            // 
            this.toolProfilerSep.Name = "toolProfilerSep";
            this.toolProfilerSep.Size = new System.Drawing.Size(6, 25);
            this.toolProfilerSep.Visible = false;
            // 
            // toolProfilerInstall
            // 
            this.toolProfilerInstall.Name = "toolProfilerInstall";
            this.toolProfilerInstall.Size = new System.Drawing.Size(83, 22);
            this.toolProfilerInstall.Text = "Install Pr&ofiler";
            this.toolProfilerInstall.Visible = false;
            // 
            // toolProfilerDebug
            // 
            this.toolProfilerDebug.Name = "toolProfilerDebug";
            this.toolProfilerDebug.Size = new System.Drawing.Size(46, 22);
            this.toolProfilerDebug.Text = "D&ebug";
            this.toolProfilerDebug.Visible = false;
            // 
            // toolProfilerEnable
            // 
            this.toolProfilerEnable.Name = "toolProfilerEnable";
            this.toolProfilerEnable.Size = new System.Drawing.Size(87, 22);
            this.toolProfilerEnable.Text = "Enable Pro&filer";
            this.toolProfilerEnable.Visible = false;
            // 
            // toolSepCommon1
            // 
            this.toolSepCommon1.Name = "toolSepCommon1";
            this.toolSepCommon1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolUpdate
            // 
            this.toolUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUpdate.Name = "toolUpdate";
            this.toolUpdate.Size = new System.Drawing.Size(49, 22);
            this.toolUpdate.Text = "&Update";
            this.toolUpdate.Visible = false;
            this.toolUpdate.Click += new System.EventHandler(this.toolUpdate_Click);
            // 
            // toolEnable
            // 
            this.toolEnable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEnable.Name = "toolEnable";
            this.toolEnable.Size = new System.Drawing.Size(49, 22);
            this.toolEnable.Text = "&Disable";
            this.toolEnable.Visible = false;
            this.toolEnable.Click += new System.EventHandler(this.toolEnable_Click);
            // 
            // toolUnregister
            // 
            this.toolUnregister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolUnregister.Name = "toolUnregister";
            this.toolUnregister.Size = new System.Drawing.Size(65, 22);
            this.toolUnregister.Text = "U&nregister";
            this.toolUnregister.Click += new System.EventHandler(this.toolUnregister_Click);
            // 
            // toolCommonSep2
            // 
            this.toolCommonSep2.Name = "toolCommonSep2";
            this.toolCommonSep2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRefresh
            // 
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(50, 22);
            this.toolRefresh.Text = "Re&fresh";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // toolSearch
            // 
            this.toolSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSearch.Name = "toolSearch";
            this.toolSearch.Size = new System.Drawing.Size(46, 22);
            this.toolSearch.Text = "&Search";
            this.toolSearch.Click += new System.EventHandler(this.toolSearch_Click);
            // 
            // toolCommonSep3
            // 
            this.toolCommonSep3.Name = "toolCommonSep3";
            this.toolCommonSep3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolClose
            // 
            this.toolClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(40, 22);
            this.toolClose.Text = "Clos&e";
            this.toolClose.ToolTipText = "Close Tool (Ctrl+F4)";
            this.toolClose.Click += new System.EventHandler(this.toolClose_Click);
            // 
            // imlEnableImages
            // 
            this.imlEnableImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlEnableImages.ImageSize = new System.Drawing.Size(16, 16);
            this.imlEnableImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitterDisplay
            // 
            this.splitterDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterDisplay.Location = new System.Drawing.Point(0, 43);
            this.splitterDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterDisplay.Name = "splitterDisplay";
            // 
            // splitterDisplay.Panel1
            // 
            this.splitterDisplay.Panel1.Controls.Add(this.grpPlugins);
            // 
            // splitterDisplay.Panel2
            // 
            this.splitterDisplay.Panel2.Controls.Add(this.btnSave);
            this.splitterDisplay.Panel2.Controls.Add(this.propGridEntity);
            this.splitterDisplay.Size = new System.Drawing.Size(1272, 685);
            this.splitterDisplay.SplitterDistance = 844;
            this.splitterDisplay.SplitterWidth = 6;
            this.splitterDisplay.TabIndex = 11;
            // 
            // grpPlugins
            // 
            this.grpPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPlugins.Controls.Add(this.trvPlugins);
            this.grpPlugins.Location = new System.Drawing.Point(0, 0);
            this.grpPlugins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlugins.Name = "grpPlugins";
            this.grpPlugins.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPlugins.Size = new System.Drawing.Size(840, 680);
            this.grpPlugins.TabIndex = 1;
            this.grpPlugins.TabStop = false;
            this.grpPlugins.Text = "Registered Plugins && Custom Workflow Activities";
            // 
            // trvPlugins
            // 
            this.trvPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPlugins.AutoExpand = false;
            this.trvPlugins.ContextMenuStrip = this.mnuContextNode;
            this.trvPlugins.CrmTreeNodeSorter = null;
            this.trvPlugins.LabelEdit = true;
            this.trvPlugins.Location = new System.Drawing.Point(9, 22);
            this.trvPlugins.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.trvPlugins.Name = "trvPlugins";
            this.trvPlugins.SelectedNode = null;
            this.trvPlugins.ShowNodeToolTips = false;
            this.trvPlugins.Size = new System.Drawing.Size(822, 649);
            this.trvPlugins.TabIndex = 0;
            this.trvPlugins.SelectionChanged += new System.EventHandler<Xrm.Sdk.PluginRegistration.Controls.CrmTreeNodeTreeEventArgs>(this.trvPlugins_SelectionChanged);
            this.trvPlugins.NodeRemoved += new System.EventHandler<Xrm.Sdk.PluginRegistration.Controls.CrmTreeNodeEventArgs>(this.trvPlugins_NodeRemoved);
            this.trvPlugins.DoubleClick += new System.EventHandler<Xrm.Sdk.PluginRegistration.Controls.CrmTreeNodeEventArgs>(this.trvPlugins_DoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(297, 635);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // propGridEntity
            // 
            this.propGridEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propGridEntity.Location = new System.Drawing.Point(0, 0);
            this.propGridEntity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.propGridEntity.Name = "propGridEntity";
            this.propGridEntity.Size = new System.Drawing.Size(411, 626);
            this.propGridEntity.TabIndex = 4;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.mnuContextGeneral;
            this.Controls.Add(this.splitterDisplay);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.grpGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1276, 1072);
            this.mnuContextNode.ResumeLayout(false);
            this.mnuContextGeneral.ResumeLayout(false);
            this.grpGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.splitterDisplay.Panel1.ResumeLayout(false);
            this.splitterDisplay.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitterDisplay)).EndInit();
            this.splitterDisplay.ResumeLayout(false);
            this.grpPlugins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.DataGridView grvData;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripDropDownButton toolRegister;
        private System.Windows.Forms.ToolStripMenuItem toolAssemblyRegister;
        private System.Windows.Forms.ToolStripMenuItem toolStepRegister;
        private System.Windows.Forms.ToolStripMenuItem toolImageRegister;
        private System.Windows.Forms.ToolStripSeparator toolSepCommon1;
        private System.Windows.Forms.ToolStripButton toolUpdate;
        private System.Windows.Forms.ToolStripButton toolEnable;
        private System.Windows.Forms.ToolStripButton toolUnregister;
        private System.Windows.Forms.ToolStripSeparator toolCommonSep2;
        private System.Windows.Forms.ToolStripDropDownButton toolView;
        private System.Windows.Forms.ToolStripMenuItem toolViewEntity;
        private System.Windows.Forms.ToolStripMenuItem toolViewMessage;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolViewAssembly;
        private System.Windows.Forms.ContextMenuStrip mnuContextNode;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeAssemblyRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeStepRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeImageRegister;
        private System.Windows.Forms.ToolStripSeparator mnuContextNodeSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeEnable;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeUnregister;
        private System.Windows.Forms.ContextMenuStrip mnuContextGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGeneralAssemblyRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGeneralStepRegister;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGeneralImageRegister;
        private System.Windows.Forms.ImageList imlEnableImages;
        private System.Windows.Forms.ToolStripSeparator mnuContextGeneralSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGeneralRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuContextGeneralSearch;
        private System.Windows.Forms.ToolStripButton toolSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuContextNodeRefresh;
        private System.Windows.Forms.ToolStripSeparator mnuContextNodeSep2;
        private System.Windows.Forms.SplitContainer splitterDisplay;
        private System.Windows.Forms.GroupBox grpPlugins;
        private Xrm.Sdk.PluginRegistration.Controls.CrmTreeControl trvPlugins;
        private System.Windows.Forms.PropertyGrid propGridEntity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem toolServiceEndpointRegister;
        private System.Windows.Forms.ToolStripButton toolProfilerInstall;
        private System.Windows.Forms.ToolStripSeparator toolProfilerSep;
        private System.Windows.Forms.ToolStripButton toolProfilerEnable;
        private System.Windows.Forms.ToolStripButton toolProfilerDebug;
        private System.Windows.Forms.ToolStripSeparator toolCommonSep3;
        private System.Windows.Forms.ToolStripButton toolClose;
    }
}
