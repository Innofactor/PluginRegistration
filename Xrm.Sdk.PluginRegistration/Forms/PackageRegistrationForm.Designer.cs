
namespace Xrm.Sdk.PluginRegistration.Forms
{
    partial class PackageRegistrationForm
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
            this.pnlFilePath = new System.Windows.Forms.Panel();
            this.txtPluginPackageFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblPluginPackageFile = new System.Windows.Forms.Label();
            this.pnlSolution = new System.Windows.Forms.Panel();
            this.cbbSolution = new System.Windows.Forms.ComboBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAddToSolution = new System.Windows.Forms.CheckBox();
            this.lblAddToSolution = new System.Windows.Forms.Label();
            this.pnlFilePath.SuspendLayout();
            this.pnlSolution.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilePath
            // 
            this.pnlFilePath.Controls.Add(this.txtPluginPackageFile);
            this.pnlFilePath.Controls.Add(this.btnBrowse);
            this.pnlFilePath.Controls.Add(this.lblPluginPackageFile);
            this.pnlFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilePath.Location = new System.Drawing.Point(0, 0);
            this.pnlFilePath.Name = "pnlFilePath";
            this.pnlFilePath.Size = new System.Drawing.Size(811, 44);
            this.pnlFilePath.TabIndex = 0;
            // 
            // txtPluginPackageFile
            // 
            this.txtPluginPackageFile.Location = new System.Drawing.Point(166, 6);
            this.txtPluginPackageFile.Name = "txtPluginPackageFile";
            this.txtPluginPackageFile.Size = new System.Drawing.Size(561, 26);
            this.txtPluginPackageFile.TabIndex = 2;
            this.txtPluginPackageFile.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(733, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(55, 32);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblPluginPackageFile
            // 
            this.lblPluginPackageFile.AutoSize = true;
            this.lblPluginPackageFile.Location = new System.Drawing.Point(12, 9);
            this.lblPluginPackageFile.Name = "lblPluginPackageFile";
            this.lblPluginPackageFile.Size = new System.Drawing.Size(141, 20);
            this.lblPluginPackageFile.TabIndex = 0;
            this.lblPluginPackageFile.Text = "Plugin package file";
            // 
            // pnlSolution
            // 
            this.pnlSolution.Controls.Add(this.cbbSolution);
            this.pnlSolution.Controls.Add(this.lblSolution);
            this.pnlSolution.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolution.Location = new System.Drawing.Point(0, 44);
            this.pnlSolution.Name = "pnlSolution";
            this.pnlSolution.Size = new System.Drawing.Size(811, 44);
            this.pnlSolution.TabIndex = 1;
            // 
            // cbbSolution
            // 
            this.cbbSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSolution.FormattingEnabled = true;
            this.cbbSolution.Location = new System.Drawing.Point(166, 6);
            this.cbbSolution.Name = "cbbSolution";
            this.cbbSolution.Size = new System.Drawing.Size(622, 28);
            this.cbbSolution.TabIndex = 2;
            this.cbbSolution.SelectedIndexChanged += new System.EventHandler(this.cbbSolution_SelectedIndexChanged);
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(12, 3);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(67, 20);
            this.lblSolution.TabIndex = 1;
            this.lblSolution.Text = "Solution";
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Controls.Add(this.txtPrefix);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 88);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(811, 44);
            this.pnlName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(272, 6);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(516, 26);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(166, 6);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(100, 26);
            this.txtPrefix.TabIndex = 2;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(664, 239);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(523, 239);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(135, 36);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // pnlVersion
            // 
            this.pnlVersion.Controls.Add(this.txtVersion);
            this.pnlVersion.Controls.Add(this.lblVersion);
            this.pnlVersion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVersion.Location = new System.Drawing.Point(0, 132);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Size = new System.Drawing.Size(811, 44);
            this.pnlVersion.TabIndex = 5;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(166, 6);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(622, 26);
            this.txtVersion.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 3);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(63, 20);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(12, 248);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(0, 20);
            this.lblProgress.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAddToSolution);
            this.panel1.Controls.Add(this.lblAddToSolution);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 44);
            this.panel1.TabIndex = 7;
            // 
            // chkAddToSolution
            // 
            this.chkAddToSolution.AutoSize = true;
            this.chkAddToSolution.Location = new System.Drawing.Point(166, 2);
            this.chkAddToSolution.Name = "chkAddToSolution";
            this.chkAddToSolution.Size = new System.Drawing.Size(22, 21);
            this.chkAddToSolution.TabIndex = 2;
            this.chkAddToSolution.UseVisualStyleBackColor = true;
            // 
            // lblAddToSolution
            // 
            this.lblAddToSolution.AutoSize = true;
            this.lblAddToSolution.Location = new System.Drawing.Point(12, 3);
            this.lblAddToSolution.Name = "lblAddToSolution";
            this.lblAddToSolution.Size = new System.Drawing.Size(115, 20);
            this.lblAddToSolution.TabIndex = 1;
            this.lblAddToSolution.Text = "Add to solution";
            // 
            // PackageRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 287);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pnlVersion);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.pnlSolution);
            this.Controls.Add(this.pnlFilePath);
            this.Name = "PackageRegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import New Plugin package";
            this.pnlFilePath.ResumeLayout(false);
            this.pnlFilePath.PerformLayout();
            this.pnlSolution.ResumeLayout(false);
            this.pnlSolution.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlVersion.ResumeLayout(false);
            this.pnlVersion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFilePath;
        private System.Windows.Forms.TextBox txtPluginPackageFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblPluginPackageFile;
        private System.Windows.Forms.Panel pnlSolution;
        private System.Windows.Forms.ComboBox cbbSolution;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAddToSolution;
        private System.Windows.Forms.Label lblAddToSolution;
    }
}