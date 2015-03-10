namespace PluginRegistrationTool
{
	partial class ACSConfigurationForm
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
			this.btnConfigureACS = new System.Windows.Forms.Button();
			this.txtPublicCertificate = new System.Windows.Forms.TextBox();
			this.lblPublicCertificate = new System.Windows.Forms.Label();
			this.txtConfigureACSStatus = new System.Windows.Forms.TextBox();
			this.txtManagementKey = new System.Windows.Forms.TextBox();
			this.lblManagementKey = new System.Windows.Forms.Label();
			this.txtIssuerName = new System.Windows.Forms.TextBox();
			this.lblIssuerName = new System.Windows.Forms.Label();
			this.btnBrowseCertificate = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.lnkDevResources = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// btnConfigureACS
			// 
			this.btnConfigureACS.Location = new System.Drawing.Point(24, 128);
			this.btnConfigureACS.Name = "btnConfigureACS";
			this.btnConfigureACS.Size = new System.Drawing.Size(106, 23);
			this.btnConfigureACS.TabIndex = 5;
			this.btnConfigureACS.Text = "Configure ACS";
			this.btnConfigureACS.UseVisualStyleBackColor = true;
			this.btnConfigureACS.Click += new System.EventHandler(this.btnConfigureACS_Click);
			// 
			// txtPublicCertificate
			// 
			this.txtPublicCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPublicCertificate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtPublicCertificate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtPublicCertificate.BackColor = System.Drawing.SystemColors.Window;
			this.txtPublicCertificate.Location = new System.Drawing.Point(110, 55);
			this.txtPublicCertificate.Name = "txtPublicCertificate";
			this.txtPublicCertificate.Size = new System.Drawing.Size(439, 20);
			this.txtPublicCertificate.TabIndex = 2;
			// 
			// lblPublicCertificate
			// 
			this.lblPublicCertificate.AutoSize = true;
			this.lblPublicCertificate.Location = new System.Drawing.Point(16, 58);
			this.lblPublicCertificate.Name = "lblPublicCertificate";
			this.lblPublicCertificate.Size = new System.Drawing.Size(73, 13);
			this.lblPublicCertificate.TabIndex = 15;
			this.lblPublicCertificate.Text = "Certificate File";
			// 
			// txtConfigureACSStatus
			// 
			this.txtConfigureACSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtConfigureACSStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtConfigureACSStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtConfigureACSStatus.Location = new System.Drawing.Point(24, 174);
			this.txtConfigureACSStatus.Multiline = true;
			this.txtConfigureACSStatus.Name = "txtConfigureACSStatus";
			this.txtConfigureACSStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtConfigureACSStatus.Size = new System.Drawing.Size(599, 271);
			this.txtConfigureACSStatus.TabIndex = 6;
			// 
			// txtManagementKey
			// 
			this.txtManagementKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtManagementKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtManagementKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtManagementKey.Location = new System.Drawing.Point(109, 28);
			this.txtManagementKey.Name = "txtManagementKey";
			this.txtManagementKey.Size = new System.Drawing.Size(513, 20);
			this.txtManagementKey.TabIndex = 1;
			// 
			// lblManagementKey
			// 
			this.lblManagementKey.AutoSize = true;
			this.lblManagementKey.Location = new System.Drawing.Point(15, 31);
			this.lblManagementKey.Name = "lblManagementKey";
			this.lblManagementKey.Size = new System.Drawing.Size(90, 13);
			this.lblManagementKey.TabIndex = 17;
			this.lblManagementKey.Text = "Management Key";
			// 
			// txtIssuerName
			// 
			this.txtIssuerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtIssuerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtIssuerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtIssuerName.BackColor = System.Drawing.SystemColors.Window;
			this.txtIssuerName.Location = new System.Drawing.Point(110, 82);
			this.txtIssuerName.Name = "txtIssuerName";
			this.txtIssuerName.Size = new System.Drawing.Size(513, 20);
			this.txtIssuerName.TabIndex = 4;
			// 
			// lblIssuerName
			// 
			this.lblIssuerName.AutoSize = true;
			this.lblIssuerName.Location = new System.Drawing.Point(17, 85);
			this.lblIssuerName.Name = "lblIssuerName";
			this.lblIssuerName.Size = new System.Drawing.Size(66, 13);
			this.lblIssuerName.TabIndex = 23;
			this.lblIssuerName.Text = "Issuer Name";
			// 
			// btnBrowseCertificate
			// 
			this.btnBrowseCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseCertificate.Location = new System.Drawing.Point(555, 54);
			this.btnBrowseCertificate.Name = "btnBrowseCertificate";
			this.btnBrowseCertificate.Size = new System.Drawing.Size(67, 23);
			this.btnBrowseCertificate.TabIndex = 3;
			this.btnBrowseCertificate.Text = "Browse ...";
			this.btnBrowseCertificate.UseVisualStyleBackColor = true;
			this.btnBrowseCertificate.Click += new System.EventHandler(this.btnBrowseCertificate_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(572, 452);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(50, 23);
			this.btnClose.TabIndex = 27;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// lnkDevResources
			// 
			this.lnkDevResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkDevResources.AutoSize = true;
			this.lnkDevResources.Location = new System.Drawing.Point(247, 105);
			this.lnkDevResources.Name = "lnkDevResources";
			this.lnkDevResources.Size = new System.Drawing.Size(378, 13);
			this.lnkDevResources.TabIndex = 28;
			this.lnkDevResources.TabStop = true;
			this.lnkDevResources.Text = "Go to the Developer Resources page to obtain the certificate and issuer name.";
			this.lnkDevResources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDevResources_LinkClicked);
			// 
			// ACSConfigurationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(635, 480);
			this.Controls.Add(this.lnkDevResources);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnBrowseCertificate);
			this.Controls.Add(this.txtIssuerName);
			this.Controls.Add(this.lblIssuerName);
			this.Controls.Add(this.btnConfigureACS);
			this.Controls.Add(this.txtPublicCertificate);
			this.Controls.Add(this.lblPublicCertificate);
			this.Controls.Add(this.txtConfigureACSStatus);
			this.Controls.Add(this.txtManagementKey);
			this.Controls.Add(this.lblManagementKey);
			this.Name = "ACSConfigurationForm";
			this.Text = "ACS Configuration";
			this.Load += new System.EventHandler(this.ACSConfigurationForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConfigureACS;
		private System.Windows.Forms.TextBox txtPublicCertificate;
		private System.Windows.Forms.Label lblPublicCertificate;
		private System.Windows.Forms.TextBox txtConfigureACSStatus;
		private System.Windows.Forms.TextBox txtManagementKey;
		private System.Windows.Forms.Label lblManagementKey;
		private System.Windows.Forms.TextBox txtIssuerName;
		private System.Windows.Forms.Label lblIssuerName;
		private System.Windows.Forms.Button btnBrowseCertificate;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.LinkLabel lnkDevResources;

	}
}