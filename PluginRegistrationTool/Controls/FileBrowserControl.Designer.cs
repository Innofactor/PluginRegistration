namespace PluginRegistrationTool.Controls
{
	partial class FileBrowserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BrowseButton = new System.Windows.Forms.Button();
			this.PathBox = new System.Windows.Forms.TextBox();
			this.Dialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// BrowseButton
			// 
			this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseButton.Location = new System.Drawing.Point(272, -1);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(30, 20);
			this.BrowseButton.TabIndex = 3;
			this.BrowseButton.Text = "&...";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// PathBox
			// 
			this.PathBox.AcceptsReturn = true;
			this.PathBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.PathBox.Location = new System.Drawing.Point(0, 0);
			this.PathBox.Name = "PathBox";
			this.PathBox.Size = new System.Drawing.Size(266, 20);
			this.PathBox.TabIndex = 2;
			this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
			this.PathBox.Leave += new System.EventHandler(this.PathBox_Leave);
			// 
			// FileBrowserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.PathBox);
			this.Name = "FileBrowserControl";
			this.Size = new System.Drawing.Size(302, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.TextBox PathBox;
		private System.Windows.Forms.OpenFileDialog Dialog;
	}
}
