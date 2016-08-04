namespace PluginRegistrationTool.Forms
{
    partial class AttributeSelectionForm
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
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lsvAttributes = new System.Windows.Forms.ListView();
            this.hdrName = new System.Windows.Forms.ColumnHeader();
            this.hdrLogicalName = new System.Windows.Forms.ColumnHeader();
            this.hdrType = new System.Windows.Forms.ColumnHeader();
            this.grpSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelect.Controls.Add(this.btnCancel);
            this.grpSelect.Controls.Add(this.btnOK);
            this.grpSelect.Controls.Add(this.chkSelectAll);
            this.grpSelect.Controls.Add(this.lsvAttributes);
            this.grpSelect.Location = new System.Drawing.Point(7, 4);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(482, 432);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(425, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(380, 398);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(39, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(339, 14);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(137, 17);
            this.chkSelectAll.TabIndex = 1;
            this.chkSelectAll.Text = "Select &All / Deselect All";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.Click += new System.EventHandler(this.chkSelectAll_Click);
            // 
            // lsvAttributes
            // 
            this.lsvAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvAttributes.CheckBoxes = true;
            this.lsvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrName,
            this.hdrLogicalName,
            this.hdrType});
            this.lsvAttributes.FullRowSelect = true;
            this.lsvAttributes.Location = new System.Drawing.Point(5, 37);
            this.lsvAttributes.Name = "lsvAttributes";
            this.lsvAttributes.Size = new System.Drawing.Size(471, 355);
            this.lsvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvAttributes.TabIndex = 2;
            this.lsvAttributes.UseCompatibleStateImageBehavior = false;
            this.lsvAttributes.View = System.Windows.Forms.View.Details;
            this.lsvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvAttributes_ColumnClick);
            // 
            // hdrName
            // 
            this.hdrName.Text = "Name";
            this.hdrName.Width = 237;
            // 
            // hdrLogicalName
            // 
            this.hdrLogicalName.Text = "Type";
            this.hdrLogicalName.Width = 143;
            // 
            // hdrType
            // 
            this.hdrType.Text = "Type";
            this.hdrType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AttributeSelectionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 443);
            this.Controls.Add(this.grpSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 310);
            this.Name = "AttributeSelectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Select Attributes";
            this.Load += new System.EventHandler(this.AttributeSelectionForm_Load);
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.ListView lsvAttributes;
        private System.Windows.Forms.ColumnHeader hdrName;
        private System.Windows.Forms.ColumnHeader hdrLogicalName;
        private System.Windows.Forms.ColumnHeader hdrType;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}