namespace Xrm.Sdk.PluginRegistration.Forms
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Returns DialogResult.Yes for Export All and DialogResult.No for Selected
    /// </summary>
    public partial class ExportTypeSelectionForm : Form
    {
        public ExportTypeSelectionForm()
        {
            InitializeComponent();
        }

        public ExportTypeSelectionForm(string message, string header)
        {
            InitializeComponent();
            lblText.Text = message;
            this.Text = header;
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}