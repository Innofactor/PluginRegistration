using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Xrm.Sdk.PluginRegistration.Forms
{
    public partial class AssembliesFilterForm : Form
    {
        #region Private Fields

        private string initialValue;

        #endregion Private Fields

        #region Public Constructors

        public AssembliesFilterForm()
        {
            InitializeComponent();

            if (SettingsManager.Instance.TryLoad(GetType(), out Settings settings))
            {
                txtAssemblies.Text = settings.ExcludedAssemblies;
                initialValue = settings.ExcludedAssemblies;
            }
        }

        #endregion Public Constructors

        #region Public Properties

        public bool HasChanged { get; private set; }

        #endregion Public Properties

        #region Private Methods

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (SettingsManager.Instance.TryLoad(GetType(), out Settings settings))
            {
                settings.ExcludedAssemblies = txtAssemblies.Text.Trim();
                SettingsManager.Instance.Save(GetType(), settings);

                HasChanged = settings.ExcludedAssemblies != initialValue;
            }
        }

        #endregion Private Methods
    }
}