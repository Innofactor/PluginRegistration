using System;

namespace Xrm.Sdk.PluginRegistration
{
    public class PluginAssemblyFileMapping
    {
        #region Public Properties

        public Guid ConnectionId { get; set; }
        public string FilePath { get; set; }

        public string PluginAssemblyName { get; set; }

        #endregion Public Properties
    }
}