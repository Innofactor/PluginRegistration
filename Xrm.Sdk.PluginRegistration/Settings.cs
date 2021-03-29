using System.Collections.Generic;

namespace Xrm.Sdk.PluginRegistration
{
    public class Settings
    {
        #region Public Properties

        public string ExcludedAssemblies { get; set; }
        public bool ExcludeManagedAssemblies { get; set; }

        public List<PluginAssemblyFileMapping> Mappings { get; set; } = new List<PluginAssemblyFileMapping>();

        #endregion Public Properties
    }
}