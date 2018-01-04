namespace Xrm.Sdk.PluginRegistration.Forms
{
    partial class ExportTypeSelectionForm
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
            this.btnExportAll = new System.Windows.Forms.Button();
            this.btnExportSelected = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExportAll
            // 
            this.btnExportAll.Location = new System.Drawing.Point(15, 57);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(75, 23);
            this.btnExportAll.TabIndex = 0;
            this.btnExportAll.Text = "All";
            this.btnExportAll.UseVisualStyleBackColor = true;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // btnExportSelected
            // 
            this.btnExportSelected.Location = new System.Drawing.Point(96, 57);
            this.btnExportSelected.Name = "btnExportSelected";
            this.btnExportSelected.Size = new System.Drawing.Size(70, 23);
            this.btnExportSelected.TabIndex = 1;
            this.btnExportSelected.Text = "Selected";
            this.btnExportSelected.UseVisualStyleBackColor = true;
            this.btnExportSelected.Click += new System.EventHandler(this.btnExportSelected_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 26);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(192, 26);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Export all or selected item?\r\n(assembly, plugin and workflow activity)\r\n";
            // 
            // ExportTypeSelectionForm
            // 
            this.AccessibleName = "Export all or selected";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 99);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnExportSelected);
            this.Controls.Add(this.btnExportAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportTypeSelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export all or selected";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Button btnExportSelected;
        private System.Windows.Forms.Label lblText;
    }
}