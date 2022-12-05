using System;
using System.Windows.Forms;

namespace Xrm.Sdk.PluginRegistration.Forms
{
    public partial class AssembliesFilterForm : Form
    {
        #region Private Fields

        private readonly bool m_initialExcludeManagedAssemblies;
        private readonly string m_initialFilterValue;

        private readonly Settings settings;

        #endregion Private Fields

        #region Public Constructors

        public AssembliesFilterForm(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;

            txtAssemblies.Text = settings.ExcludedAssemblies;
            m_initialFilterValue = settings.ExcludedAssemblies;
            chkHideManagedAssemblies.Checked = settings.ExcludeManagedAssemblies;
            m_initialExcludeManagedAssemblies = settings.ExcludeManagedAssemblies;
        }

        #endregion Public Constructors

        #region Public Properties

        public bool ExcludeManagedAssemblies { get; private set; }
        public string Filter { get; private set; }
        public bool HasChanged { get; private set; }

        #endregion Public Properties

        #region Private Methods

        private void btnOk_Click(object sender, EventArgs e)
        {
            Filter = txtAssemblies.Text.Trim();
            ExcludeManagedAssemblies = chkHideManagedAssemblies.Checked;
            settings.ExcludedAssemblies = txtAssemblies.Text.Trim();
            settings.ExcludeManagedAssemblies = chkHideManagedAssemblies.Checked;

            HasChanged = settings.ExcludedAssemblies != m_initialFilterValue || settings.ExcludeManagedAssemblies != m_initialExcludeManagedAssemblies;
        }

        #endregion Private Methods
    }
}