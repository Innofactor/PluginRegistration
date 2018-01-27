﻿namespace Xrm.Sdk.PluginRegistration.Models
{
    using CsvHelper.Configuration.Attributes;

    public class ExportModel
    {
        [Name("Plugin Type")]
        public string PluginType { get; set; }

        [Name("Assembly")]
        public string AssemblyName { get; set; }

        [Name("Plugin/Workflow Name")]
        public string TypeName { get; set; }

        [Name("Description")]
        public string Description { get; set; }

        [Name("Primary Entity")]
        public string PrimaryEntity { get; set; }

        [Name("Secondary Entity")]
        public string SecondaryEntity { get; set; }

        [Name("Message")]
        public string Message { get; set; }

        [Name("Execution Mode")]
        public string ExecutionMode { get; set; }

        [Name("Stage")]
        public string Stage { get; set; }

        [Name("Execution Order")]
        public string ExecutionOrder { get; set; }

        [Name("Deployment")]
        /// <summary>
        /// ServerOnly, Offline, Both
        /// </summary>
        public string Deployment { get; set; }

        [Name("Filtering Attributes")]
        public string FilteringAttributes { get; set; }

        [Name("Is Enabled")]
        public string IsEnabled { get; set; }

        /// <summary>
        /// None, Sandbox
        /// </summary>
        [Name("Isolation Mode")]
        public string IsolationMode { get; set; }
        /// <summary>
        /// Database, Disk, GAC
        /// </summary>
        [Name("Source Type")]
        public string SourceType{ get; set; }


    }
}