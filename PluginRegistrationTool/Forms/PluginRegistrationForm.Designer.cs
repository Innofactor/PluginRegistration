namespace PluginRegistrationTool.Forms
{
	partial class PluginRegistrationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginRegistrationForm));
			this.grpPath = new System.Windows.Forms.GroupBox();
			this.chkUpdateAssembly = new System.Windows.Forms.CheckBox();
			this.btnLoadAssembly = new System.Windows.Forms.Button();
			this.openAssemblyDialog = new System.Windows.Forms.OpenFileDialog();
			this.grpPlugins = new System.Windows.Forms.GroupBox();
			this.chkSelectAll = new System.Windows.Forms.CheckBox();
			this.tipMain = new System.Windows.Forms.ToolTip(this.components);
			this.grpRegLoc = new System.Windows.Forms.GroupBox();
			this.lblServerFileName = new System.Windows.Forms.Label();
			this.txtServerFileName = new System.Windows.Forms.TextBox();
			this.lblGAC = new System.Windows.Forms.Label();
			this.radGAC = new System.Windows.Forms.RadioButton();
			this.lblDisk = new System.Windows.Forms.Label();
			this.radDisk = new System.Windows.Forms.RadioButton();
			this.lblDatabase = new System.Windows.Forms.Label();
			this.radDB = new System.Windows.Forms.RadioButton();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpProgress = new System.Windows.Forms.GroupBox();
			this.txtProgress = new System.Windows.Forms.TextBox();
			this.barRegistration = new System.Windows.Forms.ProgressBar();
			this.grpIsolationMode = new System.Windows.Forms.GroupBox();
			this.lblIsolated = new System.Windows.Forms.Label();
			this.radIsolationSandbox = new System.Windows.Forms.RadioButton();
			this.radIsolationNone = new System.Windows.Forms.RadioButton();
			this.trvPlugins = new PluginRegistrationTool.Controls.CrmTreeControl();
			this.AssemblyPathControl = new PluginRegistrationTool.FileBrowserControl();
			this.grpPath.SuspendLayout();
			this.grpPlugins.SuspendLayout();
			this.grpRegLoc.SuspendLayout();
			this.grpProgress.SuspendLayout();
			this.grpIsolationMode.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPath
			// 
			this.grpPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpPath.Controls.Add(this.AssemblyPathControl);
			this.grpPath.Controls.Add(this.chkUpdateAssembly);
			this.grpPath.Controls.Add(this.btnLoadAssembly);
			this.grpPath.Location = new System.Drawing.Point(5, 5);
			this.grpPath.Name = "grpPath";
			this.grpPath.Size = new System.Drawing.Size(618, 75);
			this.grpPath.TabIndex = 0;
			this.grpPath.TabStop = false;
			this.grpPath.Text = "Step #1: Specify the Location of the Assembly to Analyze";
			// 
			// chkUpdateAssembly
			// 
			this.chkUpdateAssembly.AutoSize = true;
			this.chkUpdateAssembly.Location = new System.Drawing.Point(7, 49);
			this.chkUpdateAssembly.Name = "chkUpdateAssembly";
			this.chkUpdateAssembly.Size = new System.Drawing.Size(207, 17);
			this.chkUpdateAssembly.TabIndex = 3;
			this.chkUpdateAssembly.Text = "Update Assembly Properties && Content";
			this.chkUpdateAssembly.UseVisualStyleBackColor = true;
			this.chkUpdateAssembly.Visible = false;
			// 
			// btnLoadAssembly
			// 
			this.btnLoadAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLoadAssembly.Enabled = false;
			this.btnLoadAssembly.Location = new System.Drawing.Point(479, 45);
			this.btnLoadAssembly.Name = "btnLoadAssembly";
			this.btnLoadAssembly.Size = new System.Drawing.Size(97, 23);
			this.btnLoadAssembly.TabIndex = 2;
			this.btnLoadAssembly.Text = "Load Assembly";
			this.btnLoadAssembly.UseVisualStyleBackColor = true;
			this.btnLoadAssembly.Click += new System.EventHandler(this.btnLoadAssembly_Click);
			// 
			// openAssemblyDialog
			// 
			this.openAssemblyDialog.DefaultExt = "*.dll";
			this.openAssemblyDialog.Filter = "Assembly Files (*.dll)|*.dll|All Files (*.*)|*.*";
			this.openAssemblyDialog.Title = "Select Plugin Assembly";
			// 
			// grpPlugins
			// 
			this.grpPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpPlugins.Controls.Add(this.trvPlugins);
			this.grpPlugins.Controls.Add(this.chkSelectAll);
			this.grpPlugins.Location = new System.Drawing.Point(5, 86);
			this.grpPlugins.Name = "grpPlugins";
			this.grpPlugins.Size = new System.Drawing.Size(618, 177);
			this.grpPlugins.TabIndex = 1;
			this.grpPlugins.TabStop = false;
			this.grpPlugins.Text = "Step #2: Select the Plugins && Workflow Activities to Register";
			// 
			// chkSelectAll
			// 
			this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkSelectAll.AutoSize = true;
			this.chkSelectAll.Checked = true;
			this.chkSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSelectAll.Location = new System.Drawing.Point(474, 19);
			this.chkSelectAll.Name = "chkSelectAll";
			this.chkSelectAll.Size = new System.Drawing.Size(137, 17);
			this.chkSelectAll.TabIndex = 0;
			this.chkSelectAll.Text = "Select &All / Deselect All";
			this.chkSelectAll.UseVisualStyleBackColor = true;
			this.chkSelectAll.Click += new System.EventHandler(this.chkSelectAll_Click);
			// 
			// grpRegLoc
			// 
			this.grpRegLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpRegLoc.Controls.Add(this.lblServerFileName);
			this.grpRegLoc.Controls.Add(this.txtServerFileName);
			this.grpRegLoc.Controls.Add(this.lblGAC);
			this.grpRegLoc.Controls.Add(this.radGAC);
			this.grpRegLoc.Controls.Add(this.lblDisk);
			this.grpRegLoc.Controls.Add(this.radDisk);
			this.grpRegLoc.Controls.Add(this.lblDatabase);
			this.grpRegLoc.Controls.Add(this.radDB);
			this.grpRegLoc.Location = new System.Drawing.Point(5, 358);
			this.grpRegLoc.Name = "grpRegLoc";
			this.grpRegLoc.Size = new System.Drawing.Size(618, 194);
			this.grpRegLoc.TabIndex = 3;
			this.grpRegLoc.TabStop = false;
			this.grpRegLoc.Text = "Step #4: Specify the Location where the Assembly should be stored";
			// 
			// lblServerFileName
			// 
			this.lblServerFileName.AutoSize = true;
			this.lblServerFileName.Enabled = false;
			this.lblServerFileName.Location = new System.Drawing.Point(4, 129);
			this.lblServerFileName.Name = "lblServerFileName";
			this.lblServerFileName.Size = new System.Drawing.Size(106, 13);
			this.lblServerFileName.TabIndex = 7;
			this.lblServerFileName.Text = "&File Name on Server:";
			// 
			// txtServerFileName
			// 
			this.txtServerFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtServerFileName.Enabled = false;
			this.txtServerFileName.Location = new System.Drawing.Point(117, 126);
			this.txtServerFileName.Name = "txtServerFileName";
			this.txtServerFileName.Size = new System.Drawing.Size(493, 20);
			this.txtServerFileName.TabIndex = 6;
			// 
			// lblGAC
			// 
			this.lblGAC.Location = new System.Drawing.Point(4, 174);
			this.lblGAC.Name = "lblGAC";
			this.lblGAC.Size = new System.Drawing.Size(579, 18);
			this.lblGAC.TabIndex = 5;
			this.lblGAC.Text = "File is placed in the GAC of each server where it will used.";
			// 
			// radGAC
			// 
			this.radGAC.AutoSize = true;
			this.radGAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radGAC.Location = new System.Drawing.Point(7, 154);
			this.radGAC.Name = "radGAC";
			this.radGAC.Size = new System.Drawing.Size(50, 17);
			this.radGAC.TabIndex = 4;
			this.radGAC.Text = "GAC";
			this.radGAC.UseVisualStyleBackColor = true;
			// 
			// lblDisk
			// 
			this.lblDisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblDisk.Location = new System.Drawing.Point(3, 94);
			this.lblDisk.Name = "lblDisk";
			this.lblDisk.Size = new System.Drawing.Size(602, 32);
			this.lblDisk.TabIndex = 3;
			this.lblDisk.Text = resources.GetString("lblDisk.Text");
			// 
			// radDisk
			// 
			this.radDisk.AutoSize = true;
			this.radDisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radDisk.Location = new System.Drawing.Point(6, 74);
			this.radDisk.Name = "radDisk";
			this.radDisk.Size = new System.Drawing.Size(50, 17);
			this.radDisk.TabIndex = 2;
			this.radDisk.Text = "Disk";
			this.radDisk.UseVisualStyleBackColor = true;
			this.radDisk.CheckedChanged += new System.EventHandler(this.radDisk_CheckedChanged);
			// 
			// lblDatabase
			// 
			this.lblDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblDatabase.Location = new System.Drawing.Point(3, 43);
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new System.Drawing.Size(607, 28);
			this.lblDatabase.TabIndex = 1;
			this.lblDatabase.Text = resources.GetString("lblDatabase.Text");
			// 
			// radDB
			// 
			this.radDB.AutoSize = true;
			this.radDB.Checked = true;
			this.radDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radDB.Location = new System.Drawing.Point(7, 23);
			this.radDB.Name = "radDB";
			this.radDB.Size = new System.Drawing.Size(79, 17);
			this.radDB.TabIndex = 0;
			this.radDB.TabStop = true;
			this.radDB.Text = "Database";
			this.radDB.UseVisualStyleBackColor = true;
			// 
			// btnRegister
			// 
			this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRegister.Enabled = false;
			this.btnRegister.Location = new System.Drawing.Point(401, 703);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(141, 23);
			this.btnRegister.TabIndex = 5;
			this.btnRegister.Text = "&Register Selected Plugins";
			this.btnRegister.UseVisualStyleBackColor = true;
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(548, 703);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Close";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// grpProgress
			// 
			this.grpProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpProgress.Controls.Add(this.txtProgress);
			this.grpProgress.Controls.Add(this.barRegistration);
			this.grpProgress.Location = new System.Drawing.Point(5, 558);
			this.grpProgress.Name = "grpProgress";
			this.grpProgress.Size = new System.Drawing.Size(618, 139);
			this.grpProgress.TabIndex = 4;
			this.grpProgress.TabStop = false;
			this.grpProgress.Text = "Log";
			// 
			// txtProgress
			// 
			this.txtProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtProgress.Location = new System.Drawing.Point(7, 19);
			this.txtProgress.Multiline = true;
			this.txtProgress.Name = "txtProgress";
			this.txtProgress.ReadOnly = true;
			this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtProgress.Size = new System.Drawing.Size(603, 89);
			this.txtProgress.TabIndex = 7;
			// 
			// barRegistration
			// 
			this.barRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.barRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.barRegistration.Location = new System.Drawing.Point(6, 114);
			this.barRegistration.Name = "barRegistration";
			this.barRegistration.Size = new System.Drawing.Size(604, 19);
			this.barRegistration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.barRegistration.TabIndex = 6;
			// 
			// grpIsolationMode
			// 
			this.grpIsolationMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpIsolationMode.Controls.Add(this.lblIsolated);
			this.grpIsolationMode.Controls.Add(this.radIsolationSandbox);
			this.grpIsolationMode.Controls.Add(this.radIsolationNone);
			this.grpIsolationMode.Location = new System.Drawing.Point(5, 269);
			this.grpIsolationMode.Name = "grpIsolationMode";
			this.grpIsolationMode.Size = new System.Drawing.Size(618, 83);
			this.grpIsolationMode.TabIndex = 2;
			this.grpIsolationMode.TabStop = false;
			this.grpIsolationMode.Text = "Step #3: Specify the Isolation Mode";
			// 
			// lblIsolated
			// 
			this.lblIsolated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblIsolated.Location = new System.Drawing.Point(4, 39);
			this.lblIsolated.Name = "lblIsolated";
			this.lblIsolated.Size = new System.Drawing.Size(607, 16);
			this.lblIsolated.TabIndex = 1;
			this.lblIsolated.Text = "All code in this assembly will be run in a secure sandbox (reduced functionality)" +
				"";
			// 
			// radIsolationSandbox
			// 
			this.radIsolationSandbox.AutoSize = true;
			this.radIsolationSandbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radIsolationSandbox.Location = new System.Drawing.Point(8, 19);
			this.radIsolationSandbox.Name = "radIsolationSandbox";
			this.radIsolationSandbox.Size = new System.Drawing.Size(74, 17);
			this.radIsolationSandbox.TabIndex = 0;
			this.radIsolationSandbox.Text = "Sandbox";
			this.radIsolationSandbox.UseVisualStyleBackColor = true;
			// 
			// radIsolationNone
			// 
			this.radIsolationNone.AutoSize = true;
			this.radIsolationNone.Checked = true;
			this.radIsolationNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radIsolationNone.Location = new System.Drawing.Point(8, 58);
			this.radIsolationNone.Name = "radIsolationNone";
			this.radIsolationNone.Size = new System.Drawing.Size(55, 17);
			this.radIsolationNone.TabIndex = 2;
			this.radIsolationNone.TabStop = true;
			this.radIsolationNone.Text = "None";
			this.radIsolationNone.UseVisualStyleBackColor = true;
			// 
			// trvPlugins
			// 
			this.trvPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trvPlugins.AutoExpand = false;
			this.trvPlugins.CheckBoxes = true;
			this.trvPlugins.CrmTreeNodeSorter = null;
			this.trvPlugins.LabelEdit = false;
			this.trvPlugins.Location = new System.Drawing.Point(8, 42);
			this.trvPlugins.Name = "trvPlugins";
			this.trvPlugins.SelectedNode = null;
			this.trvPlugins.ShowNodeToolTips = false;
			this.trvPlugins.Size = new System.Drawing.Size(604, 129);
			this.trvPlugins.TabIndex = 1;
			this.trvPlugins.CheckStateChanged += new System.EventHandler<PluginRegistrationTool.Controls.CrmTreeNodeEventArgs>(this.trvPlugins_CheckStateChanged);
			// 
			// AssemblyPathControl
			// 
			this.AssemblyPathControl.BackColor = System.Drawing.Color.Transparent;
			this.AssemblyPathControl.DefaultExtension = "*.dll";
			this.AssemblyPathControl.FileName = "";
			this.AssemblyPathControl.Filter = "Assembly Files (*.dll)|*.dll|All Files (*.*)|*.*";
			this.AssemblyPathControl.InitialDirectory = "";
			this.AssemblyPathControl.Location = new System.Drawing.Point(7, 19);
			this.AssemblyPathControl.Name = "AssemblyPathControl";
			this.AssemblyPathControl.Size = new System.Drawing.Size(605, 20);
			this.AssemblyPathControl.TabIndex = 4;
			this.AssemblyPathControl.BrowseCompleted += new System.EventHandler<System.EventArgs>(this.AssemblyPathControl_BrowseCompleted);
			this.AssemblyPathControl.PathChanged += new System.EventHandler<System.EventArgs>(this.AssemblyPathControl_PathChanged);
			// 
			// PluginRegistrationForm
			// 
			this.AcceptButton = this.btnRegister;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(628, 732);
			this.Controls.Add(this.grpIsolationMode);
			this.Controls.Add(this.grpProgress);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.grpRegLoc);
			this.Controls.Add(this.grpPlugins);
			this.Controls.Add(this.grpPath);
			this.Name = "PluginRegistrationForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Register New Plugin";
			this.grpPath.ResumeLayout(false);
			this.grpPath.PerformLayout();
			this.grpPlugins.ResumeLayout(false);
			this.grpPlugins.PerformLayout();
			this.grpRegLoc.ResumeLayout(false);
			this.grpRegLoc.PerformLayout();
			this.grpProgress.ResumeLayout(false);
			this.grpProgress.PerformLayout();
			this.grpIsolationMode.ResumeLayout(false);
			this.grpIsolationMode.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpPath;
		private System.Windows.Forms.Button btnLoadAssembly;
		private System.Windows.Forms.OpenFileDialog openAssemblyDialog;
		private System.Windows.Forms.GroupBox grpPlugins;
		private System.Windows.Forms.ToolTip tipMain;
		private System.Windows.Forms.CheckBox chkSelectAll;
		private System.Windows.Forms.GroupBox grpRegLoc;
		private System.Windows.Forms.Label lblDatabase;
		private System.Windows.Forms.RadioButton radDB;
		private System.Windows.Forms.RadioButton radDisk;
		private System.Windows.Forms.Label lblGAC;
		private System.Windows.Forms.RadioButton radGAC;
		private System.Windows.Forms.Label lblDisk;
		private System.Windows.Forms.Button btnRegister;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblServerFileName;
		private System.Windows.Forms.TextBox txtServerFileName;
		private System.Windows.Forms.GroupBox grpProgress;
		private System.Windows.Forms.TextBox txtProgress;
		private System.Windows.Forms.ProgressBar barRegistration;
		private PluginRegistrationTool.Controls.CrmTreeControl trvPlugins;
		private System.Windows.Forms.GroupBox grpIsolationMode;
		private System.Windows.Forms.Label lblIsolated;
		private System.Windows.Forms.RadioButton radIsolationNone;
		private System.Windows.Forms.RadioButton radIsolationSandbox;
		private System.Windows.Forms.CheckBox chkUpdateAssembly;
		private FileBrowserControl AssemblyPathControl;
	}
}