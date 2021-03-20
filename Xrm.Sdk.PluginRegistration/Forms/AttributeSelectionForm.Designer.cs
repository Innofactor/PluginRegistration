namespace Xrm.Sdk.PluginRegistration.Forms
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
            this.lsvAttributes = new System.Windows.Forms.ListView();
            this.hdrName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkSelectNone = new System.Windows.Forms.LinkLabel();
            this.lblSelect = new System.Windows.Forms.Label();
            this.linkSelectAll = new System.Windows.Forms.LinkLabel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblCheckCount = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelect
            // 
            this.grpSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSelect.Location = new System.Drawing.Point(12, 182);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(483, 190);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(437, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOK.Location = new System.Drawing.Point(377, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(60, 31);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lsvAttributes
            // 
            this.lsvAttributes.CheckBoxes = true;
            this.lsvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrName,
            this.hdrLogicalName,
            this.hdrType});
            this.lsvAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvAttributes.FullRowSelect = true;
            this.lsvAttributes.HideSelection = false;
            this.lsvAttributes.Location = new System.Drawing.Point(5, 5);
            this.lsvAttributes.Name = "lsvAttributes";
            this.lsvAttributes.Size = new System.Drawing.Size(487, 409);
            this.lsvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvAttributes.TabIndex = 2;
            this.lsvAttributes.UseCompatibleStateImageBehavior = false;
            this.lsvAttributes.View = System.Windows.Forms.View.Details;
            this.lsvAttributes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvAttributes_ColumnClick);
            this.lsvAttributes.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvAttributes_ItemChecked);
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
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFilter.Location = new System.Drawing.Point(5, 3);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(355, 20);
            this.txtFilter.TabIndex = 5;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.txtFilter);
            this.pnlSearch.Controls.Add(this.panel1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(5, 5);
            this.pnlSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
            this.pnlSearch.Size = new System.Drawing.Size(497, 26);
            this.pnlSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkSelectNone);
            this.panel1.Controls.Add(this.lblSelect);
            this.panel1.Controls.Add(this.linkSelectAll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(360, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 23);
            this.panel1.TabIndex = 6;
            // 
            // linkSelectNone
            // 
            this.linkSelectNone.AutoSize = true;
            this.linkSelectNone.Location = new System.Drawing.Point(78, 3);
            this.linkSelectNone.Name = "linkSelectNone";
            this.linkSelectNone.Size = new System.Drawing.Size(38, 13);
            this.linkSelectNone.TabIndex = 2;
            this.linkSelectNone.TabStop = true;
            this.linkSelectNone.Text = "NONE";
            this.linkSelectNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectAllOrNone_LinkClicked);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(7, 3);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(37, 13);
            this.lblSelect.TabIndex = 1;
            this.lblSelect.Text = "Select";
            // 
            // linkSelectAll
            // 
            this.linkSelectAll.AutoSize = true;
            this.linkSelectAll.Location = new System.Drawing.Point(50, 3);
            this.linkSelectAll.Name = "linkSelectAll";
            this.linkSelectAll.Size = new System.Drawing.Size(26, 13);
            this.linkSelectAll.TabIndex = 0;
            this.linkSelectAll.TabStop = true;
            this.linkSelectAll.Text = "ALL";
            this.linkSelectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSelectAllOrNone_LinkClicked);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblCheckCount);
            this.pnlFooter.Controls.Add(this.btnOK);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(5, 450);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(497, 31);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblCheckCount
            // 
            this.lblCheckCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCheckCount.Location = new System.Drawing.Point(0, 0);
            this.lblCheckCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCheckCount.Name = "lblCheckCount";
            this.lblCheckCount.Size = new System.Drawing.Size(372, 31);
            this.lblCheckCount.TabIndex = 5;
            this.lblCheckCount.Tag = "Attributes selected: {0}";
            this.lblCheckCount.Text = "Attributes selected:";
            this.lblCheckCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lsvAttributes);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 31);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(5);
            this.pnlMain.Size = new System.Drawing.Size(497, 419);
            this.pnlMain.TabIndex = 3;
            // 
            // AttributeSelectionForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(507, 486);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.grpSelect);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(523, 525);
            this.Name = "AttributeSelectionForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Attributes";
            this.Load += new System.EventHandler(this.AttributeSelectionForm_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.ListView lsvAttributes;
        private System.Windows.Forms.ColumnHeader hdrName;
        private System.Windows.Forms.ColumnHeader hdrLogicalName;
        private System.Windows.Forms.ColumnHeader hdrType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblCheckCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkSelectNone;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.LinkLabel linkSelectAll;
    }
}