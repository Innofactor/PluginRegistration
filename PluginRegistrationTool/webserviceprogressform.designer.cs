namespace PluginRegistrationTool
{
	partial class WebServiceProgressForm
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
			this.barRegistration = new System.Windows.Forms.ProgressBar();
			this.lblStatus = new System.Windows.Forms.Label();
			this.tmrWait = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// barRegistration
			// 
			this.barRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.barRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.barRegistration.Location = new System.Drawing.Point(5, 35);
			this.barRegistration.Name = "barRegistration";
			this.barRegistration.Size = new System.Drawing.Size(488, 19);
			this.barRegistration.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.barRegistration.TabIndex = 7;
			// 
			// lblStatus
			// 
			this.lblStatus.Location = new System.Drawing.Point(6, 9);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(487, 16);
			this.lblStatus.TabIndex = 8;
			// 
			// tmrWait
			// 
			this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
			// 
			// WebServiceProgressForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 60);
			this.ControlBox = false;
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.barRegistration);
			this.Name = "WebServiceProgressForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Microsoft Dynamics CRM";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ProgressBar barRegistration;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Timer tmrWait;
	}
}