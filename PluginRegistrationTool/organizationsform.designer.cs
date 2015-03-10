namespace PluginRegistrationTool
{
	partial class OrganizationsForm
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
			this.tabOrganizations = new System.Windows.Forms.TabControl();
			this.lblClose = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tabOrganizations
			// 
			this.tabOrganizations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabOrganizations.Location = new System.Drawing.Point(0, 0);
			this.tabOrganizations.Name = "tabOrganizations";
			this.tabOrganizations.SelectedIndex = 0;
			this.tabOrganizations.Size = new System.Drawing.Size(736, 527);
			this.tabOrganizations.TabIndex = 0;
			this.tabOrganizations.SelectedIndexChanged += new System.EventHandler(this.tabOrganizations_SelectedIndexChanged);
			// 
			// lblClose
			// 
			this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblClose.Location = new System.Drawing.Point(713, 0);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(23, 20);
			this.lblClose.TabIndex = 2;
			this.lblClose.Text = "X";
			this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
			// 
			// OrganizationsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 527);
			this.Controls.Add(this.lblClose);
			this.Controls.Add(this.tabOrganizations);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OrganizationsForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Organizations Container";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabOrganizations;
		private System.Windows.Forms.Label lblClose;

	}
}