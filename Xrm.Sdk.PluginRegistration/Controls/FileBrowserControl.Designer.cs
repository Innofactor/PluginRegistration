namespace Xrm.Sdk.PluginRegistration.Controls
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
            this.BrowseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BrowseButton.Location = new System.Drawing.Point(520, 4);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(6);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(80, 30);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "&...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // PathBox
            // 
            this.PathBox.AcceptsReturn = true;
            this.PathBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathBox.Location = new System.Drawing.Point(4, 4);
            this.PathBox.Margin = new System.Windows.Forms.Padding(6);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(516, 31);
            this.PathBox.TabIndex = 2;
            this.PathBox.TextChanged += new System.EventHandler(this.PathBox_TextChanged);
            this.PathBox.Leave += new System.EventHandler(this.PathBox_Leave);
            // 
            // FileBrowserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.BrowseButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FileBrowserControl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(604, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.OpenFileDialog Dialog;
    }
}
