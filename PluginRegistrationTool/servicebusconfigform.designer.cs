namespace PluginRegistrationTool
{
    partial class ServiceBusConfigForm
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
			this.chkFederatedMode = new System.Windows.Forms.CheckBox();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.lblContract = new System.Windows.Forms.Label();
			this.lblClaim = new System.Windows.Forms.Label();
			this.cmbUserClaim = new System.Windows.Forms.ComboBox();
			this.cmbContract = new System.Windows.Forms.ComboBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.lblDescription = new System.Windows.Forms.Label();
			this.txtConfigId = new System.Windows.Forms.TextBox();
			this.lblSolution = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSolution = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblDesc = new System.Windows.Forms.Label();
			this.btnConfigureACS = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.toolTips = new System.Windows.Forms.ToolTip(this.components);
			this.btnVerifyAuthentication = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.grpGeneral.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkFederatedMode
			// 
			this.chkFederatedMode.AutoSize = true;
			this.chkFederatedMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkFederatedMode.Location = new System.Drawing.Point(120, 203);
			this.chkFederatedMode.Name = "chkFederatedMode";
			this.chkFederatedMode.Size = new System.Drawing.Size(104, 17);
			this.chkFederatedMode.TabIndex = 7;
			this.chkFederatedMode.Text = "Federated Mode";
			this.toolTips.SetToolTip(this.chkFederatedMode, "Pass token to listener");
			this.chkFederatedMode.UseVisualStyleBackColor = true;
			// 
			// grpGeneral
			// 
			this.grpGeneral.Controls.Add(this.lblContract);
			this.grpGeneral.Controls.Add(this.lblClaim);
			this.grpGeneral.Controls.Add(this.cmbUserClaim);
			this.grpGeneral.Controls.Add(this.chkFederatedMode);
			this.grpGeneral.Controls.Add(this.cmbContract);
			this.grpGeneral.Controls.Add(this.txtDescription);
			this.grpGeneral.Controls.Add(this.lblDescription);
			this.grpGeneral.Controls.Add(this.txtConfigId);
			this.grpGeneral.Controls.Add(this.lblSolution);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Controls.Add(this.txtSolution);
			this.grpGeneral.Controls.Add(this.lblPath);
			this.grpGeneral.Controls.Add(this.txtName);
			this.grpGeneral.Controls.Add(this.txtPath);
			this.grpGeneral.Controls.Add(this.lblDesc);
			this.grpGeneral.Location = new System.Drawing.Point(6, 12);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(517, 261);
			this.grpGeneral.TabIndex = 2;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "Service Endpoint";
			// 
			// lblContract
			// 
			this.lblContract.AutoSize = true;
			this.lblContract.Location = new System.Drawing.Point(6, 152);
			this.lblContract.Name = "lblContract";
			this.lblContract.Size = new System.Drawing.Size(50, 13);
			this.lblContract.TabIndex = 17;
			this.lblContract.Text = "Contract:";
			// 
			// lblClaim
			// 
			this.lblClaim.AutoSize = true;
			this.lblClaim.Location = new System.Drawing.Point(6, 179);
			this.lblClaim.Name = "lblClaim";
			this.lblClaim.Size = new System.Drawing.Size(35, 13);
			this.lblClaim.TabIndex = 16;
			this.lblClaim.Text = "Claim:";
			// 
			// cmbUserClaim
			// 
			this.cmbUserClaim.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbUserClaim.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbUserClaim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbUserClaim.FormattingEnabled = true;
			this.cmbUserClaim.Location = new System.Drawing.Point(120, 176);
			this.cmbUserClaim.Name = "cmbUserClaim";
			this.cmbUserClaim.Size = new System.Drawing.Size(388, 21);
			this.cmbUserClaim.TabIndex = 6;
			// 
			// cmbContract
			// 
			this.cmbContract.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbContract.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbContract.FormattingEnabled = true;
			this.cmbContract.Location = new System.Drawing.Point(120, 149);
			this.cmbContract.Name = "cmbContract";
			this.cmbContract.Size = new System.Drawing.Size(388, 21);
			this.cmbContract.TabIndex = 5;
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtDescription.Location = new System.Drawing.Point(120, 45);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescription.Size = new System.Drawing.Size(388, 46);
			this.txtDescription.TabIndex = 2;
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Location = new System.Drawing.Point(6, 48);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(63, 13);
			this.lblDescription.TabIndex = 9;
			this.lblDescription.Text = "Description:";
			// 
			// txtConfigId
			// 
			this.txtConfigId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConfigId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtConfigId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtConfigId.Enabled = false;
			this.txtConfigId.Location = new System.Drawing.Point(120, 226);
			this.txtConfigId.Name = "txtConfigId";
			this.txtConfigId.ReadOnly = true;
			this.txtConfigId.Size = new System.Drawing.Size(388, 20);
			this.txtConfigId.TabIndex = 8;
			// 
			// lblSolution
			// 
			this.lblSolution.AutoSize = true;
			this.lblSolution.Location = new System.Drawing.Point(6, 100);
			this.lblSolution.Name = "lblSolution";
			this.lblSolution.Size = new System.Drawing.Size(108, 13);
			this.lblSolution.TabIndex = 7;
			this.lblSolution.Text = "Solution Namespace:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 229);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "ID:";
			// 
			// txtSolution
			// 
			this.txtSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSolution.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtSolution.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSolution.Location = new System.Drawing.Point(120, 97);
			this.txtSolution.Name = "txtSolution";
			this.txtSolution.Size = new System.Drawing.Size(388, 20);
			this.txtSolution.TabIndex = 3;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(6, 126);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(32, 13);
			this.lblPath.TabIndex = 11;
			this.lblPath.Text = "Path:";
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtName.Location = new System.Drawing.Point(120, 19);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(388, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtPath.Location = new System.Drawing.Point(120, 123);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(388, 20);
			this.txtPath.TabIndex = 4;
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Location = new System.Drawing.Point(6, 22);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new System.Drawing.Size(38, 13);
			this.lblDesc.TabIndex = 5;
			this.lblDesc.Text = "Name:";
			// 
			// btnConfigureACS
			// 
			this.btnConfigureACS.Location = new System.Drawing.Point(6, 279);
			this.btnConfigureACS.Name = "btnConfigureACS";
			this.btnConfigureACS.Size = new System.Drawing.Size(146, 23);
			this.btnConfigureACS.TabIndex = 9;
			this.btnConfigureACS.Text = "Save && Configure ACS";
			this.btnConfigureACS.UseVisualStyleBackColor = true;
			this.btnConfigureACS.Click += new System.EventHandler(this.btnConfigureACS_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(473, 279);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(50, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnVerifyAuthentication
			// 
			this.btnVerifyAuthentication.Location = new System.Drawing.Point(269, 280);
			this.btnVerifyAuthentication.Name = "btnVerifyAuthentication";
			this.btnVerifyAuthentication.Size = new System.Drawing.Size(151, 23);
			this.btnVerifyAuthentication.TabIndex = 10;
			this.btnVerifyAuthentication.Text = "Save && Verify Authentication";
			this.btnVerifyAuthentication.UseVisualStyleBackColor = true;
			this.btnVerifyAuthentication.Click += new System.EventHandler(this.btnVerifyAuthentication_Click);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnOK.Location = new System.Drawing.Point(426, 280);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(41, 23);
			this.btnOK.TabIndex = 11;
			this.btnOK.Text = "Save";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// ServiceBusConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(530, 311);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnVerifyAuthentication);
			this.Controls.Add(this.btnConfigureACS);
			this.Controls.Add(this.grpGeneral);
			this.Controls.Add(this.btnCancel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(538, 270);
			this.Name = "ServiceBusConfigForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Service Endpoint Details";
			this.Load += new System.EventHandler(this.ServiceBusConfigForm_Load);
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblDesc;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TextBox txtSolution;
		private System.Windows.Forms.Label lblSolution;
		private System.Windows.Forms.CheckBox chkFederatedMode;
		private System.Windows.Forms.TextBox txtConfigId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTips;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label lblDescription;
		private System.Windows.Forms.Button btnConfigureACS;
		private System.Windows.Forms.Button btnVerifyAuthentication;
		private System.Windows.Forms.Label lblContract;
		private System.Windows.Forms.Label lblClaim;
		private System.Windows.Forms.ComboBox cmbUserClaim;
		private System.Windows.Forms.ComboBox cmbContract;
		private System.Windows.Forms.Button btnOK;
    }
}