//namespace PluginRegistrationTool
//{
//    partial class DebugPluginForm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.grpStep1 = new System.Windows.Forms.GroupBox();
//            this.LogPathControl = new PluginRegistrationTool.FileBrowserControl();
//            this.LogPathLabel = new System.Windows.Forms.Label();
//            this.LogCollectionLabel = new System.Windows.Forms.Label();
//            this.grpStep2 = new System.Windows.Forms.GroupBox();
//            this.RefreshPluginsButton = new System.Windows.Forms.Button();
//            this.PluginComboBox = new System.Windows.Forms.ComboBox();
//            this.PluginLabel = new System.Windows.Forms.Label();
//            this.AssemblyPathControl = new PluginRegistrationTool.FileBrowserControl();
//            this.AssemblyPathLabel = new System.Windows.Forms.Label();
//            this.grpStep3 = new System.Windows.Forms.GroupBox();
//            this.ExecutePluginButton = new System.Windows.Forms.Button();
//            this.ExecutePluginDescriptionLabel = new System.Windows.Forms.Label();
//            this.PluginTracesBox = new System.Windows.Forms.TextBox();
//            this.grpTracing = new System.Windows.Forms.GroupBox();
//            this.CloseButton = new System.Windows.Forms.Button();
//            this.ProfilerConfigurationTabs = new System.Windows.Forms.TabControl();
//            this.tabSetup = new System.Windows.Forms.TabPage();
//            this.tabUnsecureConfiguration = new System.Windows.Forms.TabPage();
//            this.UseCustomUnsecureConfigurationBox = new System.Windows.Forms.CheckBox();
//            this.txtUnsecureConfiguration = new System.Windows.Forms.TextBox();
//            this.tabSecureConfiguration = new System.Windows.Forms.TabPage();
//            this.UseCustomSecureConfigurationBox = new System.Windows.Forms.CheckBox();
//            this.txtSecureConfiguration = new System.Windows.Forms.TextBox();
//            this.tabSettings = new System.Windows.Forms.TabPage();
//            this.IsolationModeLabel = new System.Windows.Forms.Label();
//            this.IsolationModeComboBox = new System.Windows.Forms.ComboBox();
//            this.grpStep1.SuspendLayout();
//            this.grpStep2.SuspendLayout();
//            this.grpStep3.SuspendLayout();
//            this.grpTracing.SuspendLayout();
//            this.ProfilerConfigurationTabs.SuspendLayout();
//            this.tabSetup.SuspendLayout();
//            this.tabUnsecureConfiguration.SuspendLayout();
//            this.tabSecureConfiguration.SuspendLayout();
//            this.tabSettings.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // grpStep1
//            // 
//            this.grpStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.grpStep1.Controls.Add(this.LogPathControl);
//            this.grpStep1.Controls.Add(this.LogPathLabel);
//            this.grpStep1.Controls.Add(this.LogCollectionLabel);
//            this.grpStep1.Location = new System.Drawing.Point(6, 6);
//            this.grpStep1.Name = "grpStep1";
//            this.grpStep1.Size = new System.Drawing.Size(534, 81);
//            this.grpStep1.TabIndex = 0;
//            this.grpStep1.TabStop = false;
//            this.grpStep1.Text = "Step #1: Retrieve Log";
//            // 
//            // LogPathControl
//            // 
//            this.LogPathControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.LogPathControl.BackColor = System.Drawing.Color.Transparent;
//            this.LogPathControl.DefaultExtension = "";
//            this.LogPathControl.DialogTitle = "";
//            this.LogPathControl.FileName = "";
//            this.LogPathControl.Filter = "All Profile Types (*.log, *.txt, *.xml)|*.log;*.txt;*.xml|All files|*.*";
//            this.LogPathControl.InitialDirectory = "";
//            this.LogPathControl.Location = new System.Drawing.Point(113, 52);
//            this.LogPathControl.Name = "LogPathControl";
//            this.LogPathControl.Size = new System.Drawing.Size(415, 20);
//            this.LogPathControl.TabIndex = 4;
//            this.LogPathControl.PathChanged += new System.EventHandler<System.EventArgs>(this.LogPathControl_PathChanged);
//            // 
//            // LogPathLabel
//            // 
//            this.LogPathLabel.AutoSize = true;
//            this.LogPathLabel.Location = new System.Drawing.Point(6, 55);
//            this.LogPathLabel.Name = "LogPathLabel";
//            this.LogPathLabel.Size = new System.Drawing.Size(83, 13);
//            this.LogPathLabel.TabIndex = 1;
//            this.LogPathLabel.Text = "Profile Location:";
//            // 
//            // LogCollectionLabel
//            // 
//            this.LogCollectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.LogCollectionLabel.Location = new System.Drawing.Point(6, 16);
//            this.LogCollectionLabel.Name = "LogCollectionLabel";
//            this.LogCollectionLabel.Size = new System.Drawing.Size(522, 30);
//            this.LogCollectionLabel.TabIndex = 0;
//            this.LogCollectionLabel.Text = "To collect the log, do the action that triggers the plug-in. When the exception o" +
//                "ccurs, download the error log and specify the path below.";
//            // 
//            // grpStep2
//            // 
//            this.grpStep2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.grpStep2.Controls.Add(this.RefreshPluginsButton);
//            this.grpStep2.Controls.Add(this.PluginComboBox);
//            this.grpStep2.Controls.Add(this.PluginLabel);
//            this.grpStep2.Controls.Add(this.AssemblyPathControl);
//            this.grpStep2.Controls.Add(this.AssemblyPathLabel);
//            this.grpStep2.Location = new System.Drawing.Point(6, 93);
//            this.grpStep2.Name = "grpStep2";
//            this.grpStep2.Size = new System.Drawing.Size(534, 76);
//            this.grpStep2.TabIndex = 1;
//            this.grpStep2.TabStop = false;
//            this.grpStep2.Text = "Step #2: Specify Assembly";
//            // 
//            // RefreshPluginsButton
//            // 
//            this.RefreshPluginsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
//            this.RefreshPluginsButton.Enabled = false;
//            this.RefreshPluginsButton.Location = new System.Drawing.Point(498, 46);
//            this.RefreshPluginsButton.Name = "RefreshPluginsButton";
//            this.RefreshPluginsButton.Size = new System.Drawing.Size(29, 21);
//            this.RefreshPluginsButton.TabIndex = 7;
//            this.RefreshPluginsButton.UseVisualStyleBackColor = true;
//            this.RefreshPluginsButton.Click += new System.EventHandler(this.RefreshPluginsButton_Click);
//            // 
//            // PluginComboBox
//            // 
//            this.PluginComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.PluginComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.PluginComboBox.Enabled = false;
//            this.PluginComboBox.FormattingEnabled = true;
//            this.PluginComboBox.Location = new System.Drawing.Point(113, 45);
//            this.PluginComboBox.Name = "PluginComboBox";
//            this.PluginComboBox.Size = new System.Drawing.Size(378, 21);
//            this.PluginComboBox.Sorted = true;
//            this.PluginComboBox.TabIndex = 6;
//            this.PluginComboBox.SelectedIndexChanged += new System.EventHandler(this.PluginComboBox_SelectedIndexChanged);
//            // 
//            // PluginLabel
//            // 
//            this.PluginLabel.AutoSize = true;
//            this.PluginLabel.Enabled = false;
//            this.PluginLabel.Location = new System.Drawing.Point(9, 48);
//            this.PluginLabel.Name = "PluginLabel";
//            this.PluginLabel.Size = new System.Drawing.Size(42, 13);
//            this.PluginLabel.TabIndex = 5;
//            this.PluginLabel.Text = "Plug-in:";
//            // 
//            // AssemblyPathControl
//            // 
//            this.AssemblyPathControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.AssemblyPathControl.BackColor = System.Drawing.Color.Transparent;
//            this.AssemblyPathControl.DefaultExtension = "";
//            this.AssemblyPathControl.DialogTitle = "";
//            this.AssemblyPathControl.FileName = "";
//            this.AssemblyPathControl.Filter = "Assemblies (*.dll)|*.dll|All files|*.*";
//            this.AssemblyPathControl.InitialDirectory = "";
//            this.AssemblyPathControl.Location = new System.Drawing.Point(113, 19);
//            this.AssemblyPathControl.Name = "AssemblyPathControl";
//            this.AssemblyPathControl.Size = new System.Drawing.Size(415, 20);
//            this.AssemblyPathControl.TabIndex = 4;
//            this.AssemblyPathControl.PathChanged += new System.EventHandler<System.EventArgs>(this.AssemblyPathControl_PathChanged);
//            // 
//            // AssemblyPathLabel
//            // 
//            this.AssemblyPathLabel.AutoSize = true;
//            this.AssemblyPathLabel.Location = new System.Drawing.Point(9, 22);
//            this.AssemblyPathLabel.Name = "AssemblyPathLabel";
//            this.AssemblyPathLabel.Size = new System.Drawing.Size(98, 13);
//            this.AssemblyPathLabel.TabIndex = 3;
//            this.AssemblyPathLabel.Text = "Assembly Location:";
//            // 
//            // grpStep3
//            // 
//            this.grpStep3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.grpStep3.Controls.Add(this.ExecutePluginButton);
//            this.grpStep3.Controls.Add(this.ExecutePluginDescriptionLabel);
//            this.grpStep3.Location = new System.Drawing.Point(6, 211);
//            this.grpStep3.Name = "grpStep3";
//            this.grpStep3.Size = new System.Drawing.Size(555, 68);
//            this.grpStep3.TabIndex = 2;
//            this.grpStep3.TabStop = false;
//            this.grpStep3.Text = "Step #3: Execute Plug-in";
//            // 
//            // ExecutePluginButton
//            // 
//            this.ExecutePluginButton.Enabled = false;
//            this.ExecutePluginButton.Location = new System.Drawing.Point(9, 39);
//            this.ExecutePluginButton.Name = "ExecutePluginButton";
//            this.ExecutePluginButton.Size = new System.Drawing.Size(136, 23);
//            this.ExecutePluginButton.TabIndex = 2;
//            this.ExecutePluginButton.Text = "Start Plug-in Execution";
//            this.ExecutePluginButton.UseVisualStyleBackColor = true;
//            this.ExecutePluginButton.Click += new System.EventHandler(this.ExecutePluginButton_Click);
//            // 
//            // ExecutePluginDescriptionLabel
//            // 
//            this.ExecutePluginDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.ExecutePluginDescriptionLabel.Location = new System.Drawing.Point(6, 19);
//            this.ExecutePluginDescriptionLabel.Name = "ExecutePluginDescriptionLabel";
//            this.ExecutePluginDescriptionLabel.Size = new System.Drawing.Size(543, 17);
//            this.ExecutePluginDescriptionLabel.TabIndex = 3;
//            this.ExecutePluginDescriptionLabel.Text = "Attach Visual Studio to the {0} process (PID: {1}) and click the Execute plug-in." +
//                "";
//            // 
//            // PluginTracesBox
//            // 
//            this.PluginTracesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//                        | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.PluginTracesBox.Location = new System.Drawing.Point(9, 19);
//            this.PluginTracesBox.Multiline = true;
//            this.PluginTracesBox.Name = "PluginTracesBox";
//            this.PluginTracesBox.ReadOnly = true;
//            this.PluginTracesBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.PluginTracesBox.Size = new System.Drawing.Size(537, 236);
//            this.PluginTracesBox.TabIndex = 0;
//            this.PluginTracesBox.WordWrap = false;
//            // 
//            // grpTracing
//            // 
//            this.grpTracing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//                        | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.grpTracing.Controls.Add(this.PluginTracesBox);
//            this.grpTracing.Location = new System.Drawing.Point(6, 285);
//            this.grpTracing.Name = "grpTracing";
//            this.grpTracing.Size = new System.Drawing.Size(555, 261);
//            this.grpTracing.TabIndex = 3;
//            this.grpTracing.TabStop = false;
//            this.grpTracing.Text = "Plug-in Traces";
//            // 
//            // CloseButton
//            // 
//            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.CloseButton.Location = new System.Drawing.Point(504, 552);
//            this.CloseButton.Name = "CloseButton";
//            this.CloseButton.Size = new System.Drawing.Size(57, 23);
//            this.CloseButton.TabIndex = 4;
//            this.CloseButton.Text = "Close";
//            this.CloseButton.UseVisualStyleBackColor = true;
//            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
//            // 
//            // ProfilerConfigurationTabs
//            // 
//            this.ProfilerConfigurationTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.ProfilerConfigurationTabs.Controls.Add(this.tabSetup);
//            this.ProfilerConfigurationTabs.Controls.Add(this.tabUnsecureConfiguration);
//            this.ProfilerConfigurationTabs.Controls.Add(this.tabSecureConfiguration);
//            this.ProfilerConfigurationTabs.Controls.Add(this.tabSettings);
//            this.ProfilerConfigurationTabs.Location = new System.Drawing.Point(6, 6);
//            this.ProfilerConfigurationTabs.Name = "ProfilerConfigurationTabs";
//            this.ProfilerConfigurationTabs.SelectedIndex = 0;
//            this.ProfilerConfigurationTabs.Size = new System.Drawing.Size(555, 199);
//            this.ProfilerConfigurationTabs.TabIndex = 5;
//            // 
//            // tabSetup
//            // 
//            this.tabSetup.BackColor = System.Drawing.SystemColors.Control;
//            this.tabSetup.Controls.Add(this.grpStep1);
//            this.tabSetup.Controls.Add(this.grpStep2);
//            this.tabSetup.Location = new System.Drawing.Point(4, 22);
//            this.tabSetup.Name = "tabSetup";
//            this.tabSetup.Padding = new System.Windows.Forms.Padding(3);
//            this.tabSetup.Size = new System.Drawing.Size(547, 173);
//            this.tabSetup.TabIndex = 0;
//            this.tabSetup.Text = "Setup";
//            // 
//            // tabUnsecureConfiguration
//            // 
//            this.tabUnsecureConfiguration.BackColor = System.Drawing.SystemColors.Control;
//            this.tabUnsecureConfiguration.Controls.Add(this.UseCustomUnsecureConfigurationBox);
//            this.tabUnsecureConfiguration.Controls.Add(this.txtUnsecureConfiguration);
//            this.tabUnsecureConfiguration.Location = new System.Drawing.Point(4, 22);
//            this.tabUnsecureConfiguration.Name = "tabUnsecureConfiguration";
//            this.tabUnsecureConfiguration.Padding = new System.Windows.Forms.Padding(3);
//            this.tabUnsecureConfiguration.Size = new System.Drawing.Size(547, 173);
//            this.tabUnsecureConfiguration.TabIndex = 1;
//            this.tabUnsecureConfiguration.Text = "Unsecure Configuration";
//            // 
//            // UseCustomUnsecureConfigurationBox
//            // 
//            this.UseCustomUnsecureConfigurationBox.AutoSize = true;
//            this.UseCustomUnsecureConfigurationBox.Location = new System.Drawing.Point(6, 6);
//            this.UseCustomUnsecureConfigurationBox.Name = "UseCustomUnsecureConfigurationBox";
//            this.UseCustomUnsecureConfigurationBox.Size = new System.Drawing.Size(113, 17);
//            this.UseCustomUnsecureConfigurationBox.TabIndex = 3;
//            this.UseCustomUnsecureConfigurationBox.Text = "Use Custom Value";
//            this.UseCustomUnsecureConfigurationBox.UseVisualStyleBackColor = true;
//            this.UseCustomUnsecureConfigurationBox.CheckedChanged += new System.EventHandler(this.UseSpecifiedUnsecureConfigurationBox_CheckedChanged);
//            // 
//            // txtUnsecureConfiguration
//            // 
//            this.txtUnsecureConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//                        | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.txtUnsecureConfiguration.Location = new System.Drawing.Point(6, 29);
//            this.txtUnsecureConfiguration.Multiline = true;
//            this.txtUnsecureConfiguration.Name = "txtUnsecureConfiguration";
//            this.txtUnsecureConfiguration.ReadOnly = true;
//            this.txtUnsecureConfiguration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.txtUnsecureConfiguration.Size = new System.Drawing.Size(536, 138);
//            this.txtUnsecureConfiguration.TabIndex = 2;
//            // 
//            // tabSecureConfiguration
//            // 
//            this.tabSecureConfiguration.BackColor = System.Drawing.SystemColors.Control;
//            this.tabSecureConfiguration.Controls.Add(this.UseCustomSecureConfigurationBox);
//            this.tabSecureConfiguration.Controls.Add(this.txtSecureConfiguration);
//            this.tabSecureConfiguration.Location = new System.Drawing.Point(4, 22);
//            this.tabSecureConfiguration.Name = "tabSecureConfiguration";
//            this.tabSecureConfiguration.Size = new System.Drawing.Size(547, 173);
//            this.tabSecureConfiguration.TabIndex = 2;
//            this.tabSecureConfiguration.Text = "Secure Configuration";
//            // 
//            // UseCustomSecureConfigurationBox
//            // 
//            this.UseCustomSecureConfigurationBox.AutoSize = true;
//            this.UseCustomSecureConfigurationBox.Location = new System.Drawing.Point(6, 6);
//            this.UseCustomSecureConfigurationBox.Name = "UseCustomSecureConfigurationBox";
//            this.UseCustomSecureConfigurationBox.Size = new System.Drawing.Size(113, 17);
//            this.UseCustomSecureConfigurationBox.TabIndex = 4;
//            this.UseCustomSecureConfigurationBox.Text = "Use Custom Value";
//            this.UseCustomSecureConfigurationBox.UseVisualStyleBackColor = true;
//            this.UseCustomSecureConfigurationBox.CheckedChanged += new System.EventHandler(this.UseSpecifiedSecureConfigurationBox_CheckedChanged);
//            // 
//            // txtSecureConfiguration
//            // 
//            this.txtSecureConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
//                        | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.txtSecureConfiguration.Location = new System.Drawing.Point(6, 29);
//            this.txtSecureConfiguration.Multiline = true;
//            this.txtSecureConfiguration.Name = "txtSecureConfiguration";
//            this.txtSecureConfiguration.ReadOnly = true;
//            this.txtSecureConfiguration.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
//            this.txtSecureConfiguration.Size = new System.Drawing.Size(536, 138);
//            this.txtSecureConfiguration.TabIndex = 2;
//            // 
//            // tabSettings
//            // 
//            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
//            this.tabSettings.Controls.Add(this.IsolationModeComboBox);
//            this.tabSettings.Controls.Add(this.IsolationModeLabel);
//            this.tabSettings.Location = new System.Drawing.Point(4, 22);
//            this.tabSettings.Name = "tabSettings";
//            this.tabSettings.Size = new System.Drawing.Size(547, 173);
//            this.tabSettings.TabIndex = 3;
//            this.tabSettings.Text = "Settings";
//            // 
//            // IsolationModeLabel
//            // 
//            this.IsolationModeLabel.AutoSize = true;
//            this.IsolationModeLabel.Location = new System.Drawing.Point(3, 9);
//            this.IsolationModeLabel.Name = "IsolationModeLabel";
//            this.IsolationModeLabel.Size = new System.Drawing.Size(79, 13);
//            this.IsolationModeLabel.TabIndex = 0;
//            this.IsolationModeLabel.Text = "&Isolation Mode:";
//            // 
//            // IsolationModeComboBox
//            // 
//            this.IsolationModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
//            this.IsolationModeComboBox.FormattingEnabled = true;
//            this.IsolationModeComboBox.Location = new System.Drawing.Point(88, 6);
//            this.IsolationModeComboBox.Name = "IsolationModeComboBox";
//            this.IsolationModeComboBox.Size = new System.Drawing.Size(125, 21);
//            this.IsolationModeComboBox.TabIndex = 1;
//            // 
//            // DebugPluginForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.CancelButton = this.CloseButton;
//            this.ClientSize = new System.Drawing.Size(568, 579);
//            this.Controls.Add(this.ProfilerConfigurationTabs);
//            this.Controls.Add(this.CloseButton);
//            this.Controls.Add(this.grpTracing);
//            this.Controls.Add(this.grpStep3);
//            this.Name = "DebugPluginForm";
//            this.ShowIcon = false;
//            this.ShowInTaskbar = false;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//            this.Text = "Debug an Existing Plug-in";
//            this.grpStep1.ResumeLayout(false);
//            this.grpStep1.PerformLayout();
//            this.grpStep2.ResumeLayout(false);
//            this.grpStep2.PerformLayout();
//            this.grpStep3.ResumeLayout(false);
//            this.grpTracing.ResumeLayout(false);
//            this.grpTracing.PerformLayout();
//            this.ProfilerConfigurationTabs.ResumeLayout(false);
//            this.tabSetup.ResumeLayout(false);
//            this.tabUnsecureConfiguration.ResumeLayout(false);
//            this.tabUnsecureConfiguration.PerformLayout();
//            this.tabSecureConfiguration.ResumeLayout(false);
//            this.tabSecureConfiguration.PerformLayout();
//            this.tabSettings.ResumeLayout(false);
//            this.tabSettings.PerformLayout();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox grpStep1;
//        private System.Windows.Forms.Label LogPathLabel;
//        private System.Windows.Forms.Label LogCollectionLabel;
//        private System.Windows.Forms.GroupBox grpStep2;
//        private FileBrowserControl LogPathControl;
//        private FileBrowserControl AssemblyPathControl;
//        private System.Windows.Forms.Label AssemblyPathLabel;
//        private System.Windows.Forms.GroupBox grpStep3;
//        private System.Windows.Forms.Label ExecutePluginDescriptionLabel;
//        private System.Windows.Forms.Button ExecutePluginButton;
//        private System.Windows.Forms.TextBox PluginTracesBox;
//        private System.Windows.Forms.GroupBox grpTracing;
//        private System.Windows.Forms.Button CloseButton;
//        private System.Windows.Forms.ComboBox PluginComboBox;
//        private System.Windows.Forms.Label PluginLabel;
//        private System.Windows.Forms.Button RefreshPluginsButton;
//        private System.Windows.Forms.TabControl ProfilerConfigurationTabs;
//        private System.Windows.Forms.TabPage tabSetup;
//        private System.Windows.Forms.TabPage tabUnsecureConfiguration;
//        private System.Windows.Forms.TabPage tabSecureConfiguration;
//        private System.Windows.Forms.TextBox txtUnsecureConfiguration;
//        private System.Windows.Forms.TextBox txtSecureConfiguration;
//        private System.Windows.Forms.CheckBox UseCustomUnsecureConfigurationBox;
//        private System.Windows.Forms.CheckBox UseCustomSecureConfigurationBox;
//        private System.Windows.Forms.TabPage tabSettings;
//        private System.Windows.Forms.ComboBox IsolationModeComboBox;
//        private System.Windows.Forms.Label IsolationModeLabel;

//    }
//}