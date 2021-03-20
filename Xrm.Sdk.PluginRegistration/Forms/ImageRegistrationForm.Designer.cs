namespace Xrm.Sdk.PluginRegistration.Forms
{
    partial class ImageRegistrationForm
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
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.trvPlugins = new Xrm.Sdk.PluginRegistration.Controls.CrmTreeControl();
            this.grpImageType = new System.Windows.Forms.GroupBox();
            this.chkImageTypePost = new System.Windows.Forms.CheckBox();
            this.chkImageTypePre = new System.Windows.Forms.CheckBox();
            this.grpEntityAlias = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.crmParameters = new Xrm.Sdk.PluginRegistration.Controls.CrmAttributeSelectionControl();
            this.lblImageParameters = new System.Windows.Forms.Label();
            this.txtEntityAlias = new System.Windows.Forms.TextBox();
            this.lblEntityAlias = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpSteps.SuspendLayout();
            this.grpImageType.SuspendLayout();
            this.grpEntityAlias.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSteps
            // 
            this.grpSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSteps.Controls.Add(this.trvPlugins);
            this.grpSteps.Location = new System.Drawing.Point(4, 4);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Size = new System.Drawing.Size(550, 374);
            this.grpSteps.TabIndex = 0;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Step #1: Select a Step";
            // 
            // trvPlugins
            // 
            this.trvPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trvPlugins.AutoExpand = false;
            this.trvPlugins.CrmTreeNodeSorter = null;
            this.trvPlugins.ExcludeTypes = Xrm.Sdk.PluginRegistration.Controls.CrmTreeNodeType.Image;
            this.trvPlugins.LabelEdit = false;
            this.trvPlugins.Location = new System.Drawing.Point(9, 19);
            this.trvPlugins.Name = "trvPlugins";
            this.trvPlugins.SelectedNode = null;
            this.trvPlugins.ShowNodeToolTips = false;
            this.trvPlugins.Size = new System.Drawing.Size(535, 347);
            this.trvPlugins.TabIndex = 0;
            this.trvPlugins.SelectionChanged += new System.EventHandler<Xrm.Sdk.PluginRegistration.Controls.CrmTreeNodeTreeEventArgs>(this.trvPlugins_SelectionChanged);
            // 
            // grpImageType
            // 
            this.grpImageType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpImageType.Controls.Add(this.chkImageTypePost);
            this.grpImageType.Controls.Add(this.chkImageTypePre);
            this.grpImageType.Location = new System.Drawing.Point(3, 384);
            this.grpImageType.Name = "grpImageType";
            this.grpImageType.Size = new System.Drawing.Size(100, 92);
            this.grpImageType.TabIndex = 1;
            this.grpImageType.TabStop = false;
            this.grpImageType.Text = "Image Type";
            // 
            // chkImageTypePost
            // 
            this.chkImageTypePost.AutoSize = true;
            this.chkImageTypePost.Location = new System.Drawing.Point(9, 42);
            this.chkImageTypePost.Name = "chkImageTypePost";
            this.chkImageTypePost.Size = new System.Drawing.Size(79, 17);
            this.chkImageTypePost.TabIndex = 1;
            this.chkImageTypePost.Text = "Post Image";
            this.chkImageTypePost.UseVisualStyleBackColor = true;
            // 
            // chkImageTypePre
            // 
            this.chkImageTypePre.AutoSize = true;
            this.chkImageTypePre.Checked = true;
            this.chkImageTypePre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImageTypePre.Location = new System.Drawing.Point(9, 19);
            this.chkImageTypePre.Name = "chkImageTypePre";
            this.chkImageTypePre.Size = new System.Drawing.Size(74, 17);
            this.chkImageTypePre.TabIndex = 0;
            this.chkImageTypePre.Text = "Pre Image";
            this.chkImageTypePre.UseVisualStyleBackColor = true;
            // 
            // grpEntityAlias
            // 
            this.grpEntityAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpEntityAlias.Controls.Add(this.txtName);
            this.grpEntityAlias.Controls.Add(this.lblName);
            this.grpEntityAlias.Controls.Add(this.crmParameters);
            this.grpEntityAlias.Controls.Add(this.lblImageParameters);
            this.grpEntityAlias.Controls.Add(this.txtEntityAlias);
            this.grpEntityAlias.Controls.Add(this.lblEntityAlias);
            this.grpEntityAlias.Location = new System.Drawing.Point(109, 384);
            this.grpEntityAlias.Name = "grpEntityAlias";
            this.grpEntityAlias.Size = new System.Drawing.Size(444, 92);
            this.grpEntityAlias.TabIndex = 2;
            this.grpEntityAlias.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Location = new System.Drawing.Point(75, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // crmParameters
            // 
            this.crmParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crmParameters.Attributes = null;
            this.crmParameters.DisabledMessage = "";
            this.crmParameters.EntityName = null;
            this.crmParameters.Location = new System.Drawing.Point(75, 64);
            this.crmParameters.Name = "crmParameters";
            this.crmParameters.Organization = null;
            this.crmParameters.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.crmParameters.Size = new System.Drawing.Size(362, 20);
            this.crmParameters.TabIndex = 6;
            this.crmParameters.WordWrap = false;
            // 
            // lblImageParameters
            // 
            this.lblImageParameters.AutoSize = true;
            this.lblImageParameters.Location = new System.Drawing.Point(8, 67);
            this.lblImageParameters.Name = "lblImageParameters";
            this.lblImageParameters.Size = new System.Drawing.Size(63, 13);
            this.lblImageParameters.TabIndex = 5;
            this.lblImageParameters.Text = "Parameters:";
            // 
            // txtEntityAlias
            // 
            this.txtEntityAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEntityAlias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEntityAlias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEntityAlias.Location = new System.Drawing.Point(75, 38);
            this.txtEntityAlias.Name = "txtEntityAlias";
            this.txtEntityAlias.Size = new System.Drawing.Size(362, 20);
            this.txtEntityAlias.TabIndex = 3;
            // 
            // lblEntityAlias
            // 
            this.lblEntityAlias.AutoSize = true;
            this.lblEntityAlias.Location = new System.Drawing.Point(8, 41);
            this.lblEntityAlias.Name = "lblEntityAlias";
            this.lblEntityAlias.Size = new System.Drawing.Size(61, 13);
            this.lblEntityAlias.TabIndex = 2;
            this.lblEntityAlias.Text = "Entity Alias:";
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegister.Location = new System.Drawing.Point(345, 482);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "&Register Image";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(478, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ImageRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 511);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpEntityAlias);
            this.Controls.Add(this.grpImageType);
            this.Controls.Add(this.grpSteps);
            this.Name = "ImageRegistrationForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register New Image";
            this.grpSteps.ResumeLayout(false);
            this.grpImageType.ResumeLayout(false);
            this.grpImageType.PerformLayout();
            this.grpEntityAlias.ResumeLayout(false);
            this.grpEntityAlias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSteps;
        private Xrm.Sdk.PluginRegistration.Controls.CrmTreeControl trvPlugins;
        private System.Windows.Forms.GroupBox grpImageType;
        private System.Windows.Forms.CheckBox chkImageTypePost;
        private System.Windows.Forms.CheckBox chkImageTypePre;
        private System.Windows.Forms.GroupBox grpEntityAlias;
        private System.Windows.Forms.TextBox txtEntityAlias;
        private System.Windows.Forms.Label lblEntityAlias;
        private System.Windows.Forms.Label lblImageParameters;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private Xrm.Sdk.PluginRegistration.Controls.CrmAttributeSelectionControl crmParameters;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}