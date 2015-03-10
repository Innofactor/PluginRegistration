namespace PluginRegistrationTool
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewConnections = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuViewSep = new System.Windows.Forms.ToolStripSeparator();
			this.mnuViewAutoExpand = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMain = new System.Windows.Forms.ToolStrip();
			this.toolConnectionNew = new System.Windows.Forms.ToolStripButton();
			this.toolConnectionRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolConnectionRemove = new System.Windows.Forms.ToolStripButton();
			this.toolSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolProfilerReplay = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.statusOrganizationInformation = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.imlImages = new System.Windows.Forms.ImageList(this.components);
			this.toolPluginProfile = new System.Windows.Forms.ToolStripButton();
			this.menuMain.SuspendLayout();
			this.toolMain.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.mnuView,
            this.mnuHelp});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(1081, 24);
			this.menuMain.TabIndex = 0;
			this.menuMain.Text = "MenuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
			// 
			// mnuView
			// 
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewConnections,
            this.mnuViewStatusBar,
            this.mnuViewToolbar,
            this.mnuViewSep,
            this.mnuViewAutoExpand});
			this.mnuView.Name = "mnuView";
			this.mnuView.Size = new System.Drawing.Size(44, 20);
			this.mnuView.Text = "&View";
			// 
			// mnuViewConnections
			// 
			this.mnuViewConnections.Checked = true;
			this.mnuViewConnections.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuViewConnections.Name = "mnuViewConnections";
			this.mnuViewConnections.Size = new System.Drawing.Size(206, 22);
			this.mnuViewConnections.Text = "Connections";
			this.mnuViewConnections.CheckedChanged += new System.EventHandler(this.mnuViewConnections_CheckedChanged);
			this.mnuViewConnections.Click += new System.EventHandler(this.mnuViewConnections_Click);
			// 
			// mnuViewStatusBar
			// 
			this.mnuViewStatusBar.Checked = true;
			this.mnuViewStatusBar.CheckOnClick = true;
			this.mnuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuViewStatusBar.Name = "mnuViewStatusBar";
			this.mnuViewStatusBar.Size = new System.Drawing.Size(206, 22);
			this.mnuViewStatusBar.Text = "&Status Bar";
			// 
			// mnuViewToolbar
			// 
			this.mnuViewToolbar.Checked = true;
			this.mnuViewToolbar.CheckOnClick = true;
			this.mnuViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuViewToolbar.Name = "mnuViewToolbar";
			this.mnuViewToolbar.Size = new System.Drawing.Size(206, 22);
			this.mnuViewToolbar.Text = "&Toolbar";
			// 
			// mnuViewSep
			// 
			this.mnuViewSep.Name = "mnuViewSep";
			this.mnuViewSep.Size = new System.Drawing.Size(203, 6);
			// 
			// mnuViewAutoExpand
			// 
			this.mnuViewAutoExpand.CheckOnClick = true;
			this.mnuViewAutoExpand.Name = "mnuViewAutoExpand";
			this.mnuViewAutoExpand.Size = new System.Drawing.Size(206, 22);
			this.mnuViewAutoExpand.Text = "Start trees fully expanded";
			this.mnuViewAutoExpand.CheckedChanged += new System.EventHandler(this.mnuViewAutoExpand_CheckedChanged);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(44, 20);
			this.mnuHelp.Text = "&Help";
			// 
			// mnuHelpAbout
			// 
			this.mnuHelpAbout.Name = "mnuHelpAbout";
			this.mnuHelpAbout.Size = new System.Drawing.Size(119, 22);
			this.mnuHelpAbout.Text = "&About ...";
			this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
			// 
			// toolMain
			// 
			this.toolMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolConnectionNew,
            this.toolConnectionRefresh,
            this.toolConnectionRemove,
            this.toolSep1,
            this.toolProfilerReplay,
            this.toolPluginProfile});
			this.toolMain.Location = new System.Drawing.Point(0, 24);
			this.toolMain.Name = "toolMain";
			this.toolMain.Size = new System.Drawing.Size(1081, 25);
			this.toolMain.TabIndex = 1;
			this.toolMain.Text = "ToolStrip";
			// 
			// toolConnectionNew
			// 
			this.toolConnectionNew.Name = "toolConnectionNew";
			this.toolConnectionNew.Size = new System.Drawing.Size(137, 22);
			this.toolConnectionNew.Text = "Create New Connection";
			this.toolConnectionNew.ToolTipText = "New Connection";
			this.toolConnectionNew.Click += new System.EventHandler(this.toolConnectionNew_Click);
			// 
			// toolConnectionRefresh
			// 
			this.toolConnectionRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolConnectionRefresh.Name = "toolConnectionRefresh";
			this.toolConnectionRefresh.Size = new System.Drawing.Size(123, 22);
			this.toolConnectionRefresh.Text = "Reload Organizations";
			this.toolConnectionRefresh.Click += new System.EventHandler(this.toolConnectionRefresh_Click);
			// 
			// toolConnectionRemove
			// 
			this.toolConnectionRemove.Name = "toolConnectionRemove";
			this.toolConnectionRemove.Size = new System.Drawing.Size(119, 22);
			this.toolConnectionRemove.Text = "Remove Connection";
			this.toolConnectionRemove.Click += new System.EventHandler(this.toolConnectionRemove_Click);
			// 
			// toolSep1
			// 
			this.toolSep1.Name = "toolSep1";
			this.toolSep1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolProfilerReplay
			// 
			this.toolProfilerReplay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolProfilerReplay.Name = "toolProfilerReplay";
			this.toolProfilerReplay.Size = new System.Drawing.Size(142, 22);
			this.toolProfilerReplay.Text = "Replay Plug-in Execution";
			this.toolProfilerReplay.Click += new System.EventHandler(this.toolProfilerReplay_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.statusProgress,
            this.statusOrganizationInformation});
			this.statusStrip.Location = new System.Drawing.Point(0, 711);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1081, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// statusLabel
			// 
			this.statusLabel.Name = "statusLabel";
			this.statusLabel.Size = new System.Drawing.Size(35, 17);
			this.statusLabel.Text = "Done";
			// 
			// statusProgress
			// 
			this.statusProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.statusProgress.Name = "statusProgress";
			this.statusProgress.Size = new System.Drawing.Size(200, 16);
			this.statusProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.statusProgress.Visible = false;
			// 
			// statusOrganizationInformation
			// 
			this.statusOrganizationInformation.Name = "statusOrganizationInformation";
			this.statusOrganizationInformation.Size = new System.Drawing.Size(1031, 17);
			this.statusOrganizationInformation.Spring = true;
			this.statusOrganizationInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.statusOrganizationInformation.Visible = false;
			// 
			// imlImages
			// 
			this.imlImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imlImages.ImageSize = new System.Drawing.Size(16, 16);
			this.imlImages.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// toolPluginProfile
			// 
			this.toolPluginProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolPluginProfile.Name = "toolPluginProfile";
			this.toolPluginProfile.Size = new System.Drawing.Size(115, 22);
			this.toolPluginProfile.Text = "View Plug-in Profile";
			this.toolPluginProfile.Click += new System.EventHandler(this.toolPluginProfile_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1081, 733);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolMain);
			this.Controls.Add(this.menuMain);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuMain;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Plugin Registration Tool";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.toolMain.ResumeLayout(false);
			this.toolMain.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStrip toolMain;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripSeparator toolSep1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel;
		private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuView;
		private System.Windows.Forms.ToolStripMenuItem mnuViewToolbar;
		private System.Windows.Forms.ToolStripMenuItem mnuViewStatusBar;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripButton toolConnectionNew;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.ToolStripMenuItem mnuViewConnections;
		private System.Windows.Forms.ToolStripProgressBar statusProgress;
		private System.Windows.Forms.ToolStripButton toolConnectionRemove;
		private System.Windows.Forms.ImageList imlImages;
		private System.Windows.Forms.ToolStripButton toolConnectionRefresh;
		private System.Windows.Forms.ToolStripSeparator mnuViewSep;
		private System.Windows.Forms.ToolStripMenuItem mnuViewAutoExpand;
		private System.Windows.Forms.ToolStripStatusLabel statusOrganizationInformation;
		private System.Windows.Forms.ToolStripButton toolProfilerReplay;
		private System.Windows.Forms.ToolStripButton toolPluginProfile;
	}
}



