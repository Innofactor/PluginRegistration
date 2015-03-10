namespace PluginRegistrationTool
{
	partial class ConnectionsForm
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
			this.grpConnectionInformation = new System.Windows.Forms.GroupBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserName = new System.Windows.Forms.Label();
			this.chkUseSavedCredentials = new System.Windows.Forms.CheckBox();
			this.txtDiscoveryUrl = new System.Windows.Forms.TextBox();
			this.lblDiscoveryURL = new System.Windows.Forms.Label();
			this.btnConnectConnection = new System.Windows.Forms.Button();
			this.txtLabel = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.btnCancelConnection = new System.Windows.Forms.Button();
			this.btnSaveConnection = new System.Windows.Forms.Button();
			this.toolTips = new System.Windows.Forms.ToolTip(this.components);
			this.txtCrmServiceUrl = new System.Windows.Forms.TextBox();
			this.lblCrmServiceUrl = new System.Windows.Forms.Label();
			this.grpOrganizationInformation = new System.Windows.Forms.GroupBox();
			this.btnConnectOrganization = new System.Windows.Forms.Button();
			this.btnCancelOrganization = new System.Windows.Forms.Button();
			this.btnSaveOrganization = new System.Windows.Forms.Button();
			this.lblOrganizationNote = new System.Windows.Forms.Label();
			this.trvConnections = new PluginRegistrationTool.CrmTreeControl();
			this.grpConnectionInformation.SuspendLayout();
			this.grpOrganizationInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpConnectionInformation
			// 
			this.grpConnectionInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpConnectionInformation.Controls.Add(this.txtUserName);
			this.grpConnectionInformation.Controls.Add(this.lblUserName);
			this.grpConnectionInformation.Controls.Add(this.chkUseSavedCredentials);
			this.grpConnectionInformation.Controls.Add(this.txtDiscoveryUrl);
			this.grpConnectionInformation.Controls.Add(this.lblDiscoveryURL);
			this.grpConnectionInformation.Controls.Add(this.btnConnectConnection);
			this.grpConnectionInformation.Controls.Add(this.txtLabel);
			this.grpConnectionInformation.Controls.Add(this.lblName);
			this.grpConnectionInformation.Controls.Add(this.btnCancelConnection);
			this.grpConnectionInformation.Controls.Add(this.btnSaveConnection);
			this.grpConnectionInformation.Location = new System.Drawing.Point(3, 392);
			this.grpConnectionInformation.Name = "grpConnectionInformation";
			this.grpConnectionInformation.Size = new System.Drawing.Size(310, 153);
			this.grpConnectionInformation.TabIndex = 1;
			this.grpConnectionInformation.TabStop = false;
			this.grpConnectionInformation.Text = "Connection Information";
			this.grpConnectionInformation.Visible = false;
			// 
			// txtUserName
			// 
			this.txtUserName.AcceptsReturn = true;
			this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserName.Location = new System.Drawing.Point(104, 71);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(196, 20);
			this.txtUserName.TabIndex = 5;
			this.toolTips.SetToolTip(this.txtUserName, "Server Name of the Discovery or Sdk Service. eg: localhost etc.");
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(10, 74);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(63, 13);
			this.lblUserName.TabIndex = 4;
			this.lblUserName.Text = "User Name:";
			this.toolTips.SetToolTip(this.lblUserName, "Server Name of the Discovery or Sdk Service. eg: localhost etc.");
			// 
			// chkUseSavedCredentials
			// 
			this.chkUseSavedCredentials.AutoSize = true;
			this.chkUseSavedCredentials.Location = new System.Drawing.Point(104, 99);
			this.chkUseSavedCredentials.Name = "chkUseSavedCredentials";
			this.chkUseSavedCredentials.Size = new System.Drawing.Size(134, 17);
			this.chkUseSavedCredentials.TabIndex = 6;
			this.chkUseSavedCredentials.Text = "Use Saved Credentials";
			this.chkUseSavedCredentials.UseVisualStyleBackColor = true;
			this.chkUseSavedCredentials.CheckedChanged += new System.EventHandler(this.chkUseSavedCredentials_CheckedChanged);
			// 
			// txtDiscoveryUrl
			// 
			this.txtDiscoveryUrl.AcceptsReturn = true;
			this.txtDiscoveryUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDiscoveryUrl.Location = new System.Drawing.Point(104, 45);
			this.txtDiscoveryUrl.Name = "txtDiscoveryUrl";
			this.txtDiscoveryUrl.Size = new System.Drawing.Size(196, 20);
			this.txtDiscoveryUrl.TabIndex = 3;
			this.toolTips.SetToolTip(this.txtDiscoveryUrl, "Server Name of the Discovery or Sdk Service. eg: localhost etc.");
			// 
			// lblDiscoveryURL
			// 
			this.lblDiscoveryURL.AutoSize = true;
			this.lblDiscoveryURL.Location = new System.Drawing.Point(10, 48);
			this.lblDiscoveryURL.Name = "lblDiscoveryURL";
			this.lblDiscoveryURL.Size = new System.Drawing.Size(82, 13);
			this.lblDiscoveryURL.TabIndex = 2;
			this.lblDiscoveryURL.Text = "Discovery URL:";
			this.toolTips.SetToolTip(this.lblDiscoveryURL, "Server Name of the Discovery or Sdk Service. eg: localhost etc.");
			// 
			// btnConnectConnection
			// 
			this.btnConnectConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnectConnection.Location = new System.Drawing.Point(122, 122);
			this.btnConnectConnection.Name = "btnConnectConnection";
			this.btnConnectConnection.Size = new System.Drawing.Size(59, 23);
			this.btnConnectConnection.TabIndex = 7;
			this.btnConnectConnection.Text = "Connect";
			this.btnConnectConnection.UseVisualStyleBackColor = true;
			this.btnConnectConnection.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtLabel
			// 
			this.txtLabel.AcceptsReturn = true;
			this.txtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtLabel.Location = new System.Drawing.Point(104, 19);
			this.txtLabel.Name = "txtLabel";
			this.txtLabel.Size = new System.Drawing.Size(196, 20);
			this.txtLabel.TabIndex = 1;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(10, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(36, 13);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Label:";
			// 
			// btnCancelConnection
			// 
			this.btnCancelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelConnection.Location = new System.Drawing.Point(244, 122);
			this.btnCancelConnection.Name = "btnCancelConnection";
			this.btnCancelConnection.Size = new System.Drawing.Size(55, 23);
			this.btnCancelConnection.TabIndex = 9;
			this.btnCancelConnection.Text = "Cancel";
			this.btnCancelConnection.UseVisualStyleBackColor = true;
			this.btnCancelConnection.Click += new System.EventHandler(this.btnCancelConnection_Click);
			// 
			// btnSaveConnection
			// 
			this.btnSaveConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveConnection.Location = new System.Drawing.Point(187, 122);
			this.btnSaveConnection.Name = "btnSaveConnection";
			this.btnSaveConnection.Size = new System.Drawing.Size(51, 23);
			this.btnSaveConnection.TabIndex = 8;
			this.btnSaveConnection.Text = "Save";
			this.btnSaveConnection.UseVisualStyleBackColor = true;
			this.btnSaveConnection.Click += new System.EventHandler(this.btnSaveConnection_Click);
			// 
			// txtCrmServiceUrl
			// 
			this.txtCrmServiceUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCrmServiceUrl.Location = new System.Drawing.Point(134, 19);
			this.txtCrmServiceUrl.Name = "txtCrmServiceUrl";
			this.txtCrmServiceUrl.Size = new System.Drawing.Size(165, 20);
			this.txtCrmServiceUrl.TabIndex = 2;
			this.toolTips.SetToolTip(this.txtCrmServiceUrl, "CrmService Endpoint retrieved from Discovery service");
			this.txtCrmServiceUrl.TextChanged += new System.EventHandler(this.OrganizationText_TextChanged);
			// 
			// lblCrmServiceUrl
			// 
			this.lblCrmServiceUrl.AutoSize = true;
			this.lblCrmServiceUrl.Location = new System.Drawing.Point(9, 22);
			this.lblCrmServiceUrl.Name = "lblCrmServiceUrl";
			this.lblCrmServiceUrl.Size = new System.Drawing.Size(89, 13);
			this.lblCrmServiceUrl.TabIndex = 1;
			this.lblCrmServiceUrl.Text = "CrmService URL:";
			this.toolTips.SetToolTip(this.lblCrmServiceUrl, "CrmServiceUrl");
			// 
			// grpOrganizationInformation
			// 
			this.grpOrganizationInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpOrganizationInformation.Controls.Add(this.btnConnectOrganization);
			this.grpOrganizationInformation.Controls.Add(this.btnCancelOrganization);
			this.grpOrganizationInformation.Controls.Add(this.btnSaveOrganization);
			this.grpOrganizationInformation.Controls.Add(this.txtCrmServiceUrl);
			this.grpOrganizationInformation.Controls.Add(this.lblCrmServiceUrl);
			this.grpOrganizationInformation.Controls.Add(this.lblOrganizationNote);
			this.grpOrganizationInformation.Location = new System.Drawing.Point(3, 435);
			this.grpOrganizationInformation.Name = "grpOrganizationInformation";
			this.grpOrganizationInformation.Size = new System.Drawing.Size(310, 110);
			this.grpOrganizationInformation.TabIndex = 2;
			this.grpOrganizationInformation.TabStop = false;
			this.grpOrganizationInformation.Text = "Organization URLs";
			this.grpOrganizationInformation.Visible = false;
			// 
			// btnConnectOrganization
			// 
			this.btnConnectOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConnectOrganization.Location = new System.Drawing.Point(122, 79);
			this.btnConnectOrganization.Name = "btnConnectOrganization";
			this.btnConnectOrganization.Size = new System.Drawing.Size(59, 23);
			this.btnConnectOrganization.TabIndex = 6;
			this.btnConnectOrganization.Text = "Connect";
			this.btnConnectOrganization.UseVisualStyleBackColor = true;
			this.btnConnectOrganization.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnCancelOrganization
			// 
			this.btnCancelOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancelOrganization.Location = new System.Drawing.Point(244, 79);
			this.btnCancelOrganization.Name = "btnCancelOrganization";
			this.btnCancelOrganization.Size = new System.Drawing.Size(55, 23);
			this.btnCancelOrganization.TabIndex = 8;
			this.btnCancelOrganization.Text = "Cancel";
			this.btnCancelOrganization.UseVisualStyleBackColor = true;
			this.btnCancelOrganization.Click += new System.EventHandler(this.btnCancelOrganization_Click);
			// 
			// btnSaveOrganization
			// 
			this.btnSaveOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveOrganization.Enabled = false;
			this.btnSaveOrganization.Location = new System.Drawing.Point(187, 79);
			this.btnSaveOrganization.Name = "btnSaveOrganization";
			this.btnSaveOrganization.Size = new System.Drawing.Size(51, 23);
			this.btnSaveOrganization.TabIndex = 7;
			this.btnSaveOrganization.Text = "Save";
			this.btnSaveOrganization.UseVisualStyleBackColor = true;
			this.btnSaveOrganization.Click += new System.EventHandler(this.btnSaveOrganization_Click);
			// 
			// lblOrganizationNote
			// 
			this.lblOrganizationNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblOrganizationNote.Location = new System.Drawing.Point(9, 48);
			this.lblOrganizationNote.Name = "lblOrganizationNote";
			this.lblOrganizationNote.Size = new System.Drawing.Size(290, 30);
			this.lblOrganizationNote.TabIndex = 5;
			this.lblOrganizationNote.Text = "You only need to change these if the incorrect value is being displayed.";
			// 
			// trvConnections
			// 
			this.trvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.trvConnections.AutoExpand = false;
			this.trvConnections.CrmTreeNodeSorter = null;
			this.trvConnections.LabelEdit = false;
			this.trvConnections.Location = new System.Drawing.Point(3, 3);
			this.trvConnections.Name = "trvConnections";
			this.trvConnections.SelectedNode = null;
			this.trvConnections.ShowNodeToolTips = false;
			this.trvConnections.Size = new System.Drawing.Size(310, 383);
			this.trvConnections.TabIndex = 3;
			this.trvConnections.SelectionChanged += new System.EventHandler<PluginRegistrationTool.CrmTreeNodeTreeEventArgs>(this.trvConnections_SelectionChanged);
			this.trvConnections.DoubleClick += new System.EventHandler<PluginRegistrationTool.CrmTreeNodeEventArgs>(this.trvConnections_DoubleClick);
			this.trvConnections.KeyUp += new System.Windows.Forms.KeyEventHandler(this.trvConnections_KeyUp);
			// 
			// ConnectionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 549);
			this.Controls.Add(this.grpConnectionInformation);
			this.Controls.Add(this.trvConnections);
			this.Controls.Add(this.grpOrganizationInformation);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ConnectionsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Connections";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionsForm_FormClosing);
			this.Load += new System.EventHandler(this.ConnectionsForm_Load);
			this.grpConnectionInformation.ResumeLayout(false);
			this.grpConnectionInformation.PerformLayout();
			this.grpOrganizationInformation.ResumeLayout(false);
			this.grpOrganizationInformation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpConnectionInformation;
		private System.Windows.Forms.ToolTip toolTips;
		private System.Windows.Forms.Button btnCancelConnection;
		private System.Windows.Forms.Button btnSaveConnection;
		private System.Windows.Forms.TextBox txtLabel;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.GroupBox grpOrganizationInformation;
		private System.Windows.Forms.Label lblCrmServiceUrl;
		private System.Windows.Forms.TextBox txtCrmServiceUrl;
		private System.Windows.Forms.Button btnCancelOrganization;
		private System.Windows.Forms.Button btnSaveOrganization;
		private System.Windows.Forms.Label lblOrganizationNote;
		private System.Windows.Forms.Button btnConnectConnection;
		private System.Windows.Forms.Button btnConnectOrganization;
		private CrmTreeControl trvConnections;
		private System.Windows.Forms.TextBox txtDiscoveryUrl;
		private System.Windows.Forms.Label lblDiscoveryURL;
		private System.Windows.Forms.CheckBox chkUseSavedCredentials;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblUserName;
	}
}