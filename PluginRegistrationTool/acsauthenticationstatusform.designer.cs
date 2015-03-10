namespace PluginRegistrationTool
{
	partial class ACSAuthenticationStatusForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSystemJobMessage = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblVerificationStatus = new System.Windows.Forms.Label();
			this.progressBarAuthentication = new System.Windows.Forms.ProgressBar();
			this.timerSystemJobCheck = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtSystemJobMessage);
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.lblVerificationStatus);
			this.panel1.Controls.Add(this.progressBarAuthentication);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(561, 536);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 107);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "System Job Message:";
			// 
			// txtSystemJobMessage
			// 
			this.txtSystemJobMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtSystemJobMessage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.txtSystemJobMessage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.txtSystemJobMessage.Location = new System.Drawing.Point(3, 128);
			this.txtSystemJobMessage.Multiline = true;
			this.txtSystemJobMessage.Name = "txtSystemJobMessage";
			this.txtSystemJobMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSystemJobMessage.Size = new System.Drawing.Size(555, 271);
			this.txtSystemJobMessage.TabIndex = 2;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(477, 79);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lblVerificationStatus
			// 
			this.lblVerificationStatus.AutoSize = true;
			this.lblVerificationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVerificationStatus.Location = new System.Drawing.Point(11, 16);
			this.lblVerificationStatus.Name = "lblVerificationStatus";
			this.lblVerificationStatus.Size = new System.Drawing.Size(169, 15);
			this.lblVerificationStatus.TabIndex = 3;
			this.lblVerificationStatus.Text = "Verifying authentication...";
			this.lblVerificationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressBarAuthentication
			// 
			this.progressBarAuthentication.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBarAuthentication.BackColor = System.Drawing.SystemColors.Control;
			this.progressBarAuthentication.ForeColor = System.Drawing.Color.PaleGreen;
			this.progressBarAuthentication.Location = new System.Drawing.Point(7, 49);
			this.progressBarAuthentication.Name = "progressBarAuthentication";
			this.progressBarAuthentication.Size = new System.Drawing.Size(545, 23);
			this.progressBarAuthentication.TabIndex = 2;
			// 
			// timerSystemJobCheck
			// 
			this.timerSystemJobCheck.Enabled = true;
			this.timerSystemJobCheck.Interval = 1000;
			this.timerSystemJobCheck.Tick += new System.EventHandler(this.timerSystemJobCheck_Tick);
			// 
			// ACSAuthenticationStatusForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 423);
			this.Controls.Add(this.panel1);
			this.Name = "ACSAuthenticationStatusForm";
			this.Text = "Verify Authentication";
			this.Load += new System.EventHandler(this.AuthenticationStatus_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblVerificationStatus;
		private System.Windows.Forms.ProgressBar progressBarAuthentication;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSystemJobMessage;
		private System.Windows.Forms.Timer timerSystemJobCheck;

	}
}