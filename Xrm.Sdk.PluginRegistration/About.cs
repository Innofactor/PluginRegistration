namespace Xrm.Sdk.PluginRegistration
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Windows.Forms;

    public partial class About : Form
    {
        #region Public Constructors

        public About()
        {
            InitializeComponent();

            PopulateAssemblies();
            lblVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #endregion Public Constructors

        #region Private Methods

        private static string AssemblyPrioritizer(string assemblyName)
        {
            return
                assemblyName.Equals("XrmToolBox") ? "AAAAAAAAAAAA" :
                assemblyName.Contains("XrmToolBox") ? "AAAAAAAAAAAB" :
                assemblyName.Equals(Assembly.GetExecutingAssembly().GetName().Name) ? "AAAAAAAAAAAC" :
                assemblyName.Contains("Innofactor") ? "AAAAAAAAAAAF" :
                assemblyName.Contains("Cinteros") ? "AAAAAAAAAAAG" :
                assemblyName;
        }

        private ListViewItem GetListItem(AssemblyName a)
        {
            var item = new ListViewItem(a.Name);
            item.SubItems.Add(a.Version.ToString());
            return item;
        }

        private List<AssemblyName> GetReferencedAssemblies()
        {
            var names = Assembly.GetExecutingAssembly().GetReferencedAssemblies()
                    .Where(a => !a.Name.Equals("mscorlib") && !a.Name.StartsWith("System") && !a.Name.Contains("CSharp")).ToList();
            names.Add(Assembly.GetEntryAssembly().GetName());
            names.Add(Assembly.GetExecutingAssembly().GetName());
            names.Add(Assembly.LoadFrom("CsvHelper.dll")?.GetName());
            names.Add(Assembly.LoadFrom("EPPlus.dll")?.GetName());
            names = names.OrderBy(a => AssemblyPrioritizer(a.Name)).ToList();
            return names;
        }

        private void PopulateAssemblies()
        {
            try
            {
                var assemblies = GetReferencedAssemblies();
                var items = assemblies.Select(a => GetListItem(a)).ToArray();
                listAssemblies.Items.Clear();
                listAssemblies.Items.AddRange(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion Private Methods
    }
}