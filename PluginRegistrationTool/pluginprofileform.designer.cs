//namespace PluginRegistrationTool
//{
//    partial class PluginProfileForm
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
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginProfileForm));
//            this.grpStep1 = new System.Windows.Forms.GroupBox();
//            this.WarningTextLabel = new System.Windows.Forms.Label();
//            this.WarningLabel = new System.Windows.Forms.Label();
//            this.LogPathControl = new PluginRegistrationTool.FileBrowserControl();
//            this.LogPathLabel = new System.Windows.Forms.Label();
//            this.LogCollectionLabel = new System.Windows.Forms.Label();
//            this.CloseButton = new System.Windows.Forms.Button();
//            this.SaveButton = new System.Windows.Forms.Button();
//            this.ExportFileDialog = new System.Windows.Forms.SaveFileDialog();
//            this.ViewButton = new System.Windows.Forms.Button();
//            this.grpStep1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // grpStep1
//            // 
//            this.grpStep1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.grpStep1.Controls.Add(this.WarningTextLabel);
//            this.grpStep1.Controls.Add(this.WarningLabel);
//            this.grpStep1.Controls.Add(this.LogPathControl);
//            this.grpStep1.Controls.Add(this.LogPathLabel);
//            this.grpStep1.Controls.Add(this.LogCollectionLabel);
//            this.grpStep1.Location = new System.Drawing.Point(6, 6);
//            this.grpStep1.Name = "grpStep1";
//            this.grpStep1.Size = new System.Drawing.Size(577, 120);
//            this.grpStep1.TabIndex = 0;
//            this.grpStep1.TabStop = false;
//            this.grpStep1.Text = "Step #1: Specify Log Location";
//            // 
//            // WarningTextLabel
//            // 
//            this.WarningTextLabel.Location = new System.Drawing.Point(81, 75);
//            this.WarningTextLabel.Name = "WarningTextLabel";
//            this.WarningTextLabel.Size = new System.Drawing.Size(489, 43);
//            this.WarningTextLabel.TabIndex = 8;
//            this.WarningTextLabel.Text = resources.GetString("WarningTextLabel.Text");
//            // 
//            // WarningLabel
//            // 
//            this.WarningLabel.AutoSize = true;
//            this.WarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.WarningLabel.Location = new System.Drawing.Point(6, 75);
//            this.WarningLabel.Name = "WarningLabel";
//            this.WarningLabel.Size = new System.Drawing.Size(71, 13);
//            this.WarningLabel.TabIndex = 7;
//            this.WarningLabel.Text = "WARNING:";
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
//            this.LogPathControl.Location = new System.Drawing.Point(84, 52);
//            this.LogPathControl.Name = "LogPathControl";
//            this.LogPathControl.Size = new System.Drawing.Size(487, 20);
//            this.LogPathControl.TabIndex = 4;
//            this.LogPathControl.PathChanged += new System.EventHandler<System.EventArgs>(this.LogPathControl_PathChanged);
//            // 
//            // LogPathLabel
//            // 
//            this.LogPathLabel.AutoSize = true;
//            this.LogPathLabel.Location = new System.Drawing.Point(6, 55);
//            this.LogPathLabel.Name = "LogPathLabel";
//            this.LogPathLabel.Size = new System.Drawing.Size(72, 13);
//            this.LogPathLabel.TabIndex = 1;
//            this.LogPathLabel.Text = "Log Location:";
//            // 
//            // LogCollectionLabel
//            // 
//            this.LogCollectionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
//                        | System.Windows.Forms.AnchorStyles.Right)));
//            this.LogCollectionLabel.Location = new System.Drawing.Point(6, 16);
//            this.LogCollectionLabel.Name = "LogCollectionLabel";
//            this.LogCollectionLabel.Size = new System.Drawing.Size(565, 30);
//            this.LogCollectionLabel.TabIndex = 0;
//            this.LogCollectionLabel.Text = "To collect the log, do the action that triggers the plug-in. When the exception o" +
//                "ccurs, download the error log and specify the path below.";
//            // 
//            // CloseButton
//            // 
//            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.CloseButton.Location = new System.Drawing.Point(526, 135);
//            this.CloseButton.Name = "CloseButton";
//            this.CloseButton.Size = new System.Drawing.Size(57, 23);
//            this.CloseButton.TabIndex = 4;
//            this.CloseButton.Text = "Close";
//            this.CloseButton.UseVisualStyleBackColor = true;
//            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
//            // 
//            // SaveButton
//            // 
//            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.SaveButton.Enabled = false;
//            this.SaveButton.Location = new System.Drawing.Point(472, 135);
//            this.SaveButton.Name = "SaveButton";
//            this.SaveButton.Size = new System.Drawing.Size(48, 23);
//            this.SaveButton.TabIndex = 3;
//            this.SaveButton.Text = "&Save";
//            this.SaveButton.UseVisualStyleBackColor = true;
//            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
//            // 
//            // ExportFileDialog
//            // 
//            this.ExportFileDialog.Filter = "XML Files (*.xml)|*.xml|All files|*.*";
//            this.ExportFileDialog.Title = "Save Plug-in Profile";
//            // 
//            // ViewButton
//            // 
//            this.ViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
//            this.ViewButton.Enabled = false;
//            this.ViewButton.Location = new System.Drawing.Point(420, 135);
//            this.ViewButton.Name = "ViewButton";
//            this.ViewButton.Size = new System.Drawing.Size(46, 23);
//            this.ViewButton.TabIndex = 2;
//            this.ViewButton.Text = "&View";
//            this.ViewButton.UseVisualStyleBackColor = true;
//            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
//            // 
//            // PluginProfileForm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.CancelButton = this.CloseButton;
//            this.ClientSize = new System.Drawing.Size(588, 164);
//            this.Controls.Add(this.ViewButton);
//            this.Controls.Add(this.SaveButton);
//            this.Controls.Add(this.CloseButton);
//            this.Controls.Add(this.grpStep1);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.Name = "PluginProfileForm";
//            this.ShowIcon = false;
//            this.ShowInTaskbar = false;
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
//            this.Text = "View Plug-in Profile";
//            this.grpStep1.ResumeLayout(false);
//            this.grpStep1.PerformLayout();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox grpStep1;
//        private System.Windows.Forms.Label LogPathLabel;
//        private System.Windows.Forms.Label LogCollectionLabel;
//        private FileBrowserControl LogPathControl;
//        private System.Windows.Forms.Button CloseButton;
//        private System.Windows.Forms.Button SaveButton;
//        private System.Windows.Forms.SaveFileDialog ExportFileDialog;
//        private System.Windows.Forms.Button ViewButton;
//        private System.Windows.Forms.Label WarningTextLabel;
//        private System.Windows.Forms.Label WarningLabel;

//    }
//}