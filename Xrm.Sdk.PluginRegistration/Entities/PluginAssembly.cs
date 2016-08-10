namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Magic;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Assembly that contains one or more plug-in types.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("pluginassembly")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginAssembly : Transformer, INotifyPropertyChanging, INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PluginAssembly() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "pluginassembly";

        public const int EntityTypeCode = 4605;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((PropertyChanging != null))
            {
                PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Bytes of the assembly, in Base64 format.
        /// </summary>
        [AttributeLogicalName("content")]
        public string Content
        {
            get
            {
                return GetAttributeValue<string>("content");
            }
            set
            {
                OnPropertyChanging("Content");
                SetAttributeValue("content", value);
                OnPropertyChanged("Content");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public System.DateTime? CreatedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the pluginassembly.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public EntityReference CreatedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Culture code for the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("culture")]
        public string Culture
        {
            get
            {
                return GetAttributeValue<string>("culture");
            }
            set
            {
                OnPropertyChanging("Culture");
                SetAttributeValue("culture", value);
                OnPropertyChanged("Culture");
            }
        }

        /// <summary>
        /// Customization Level.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get
            {
                return GetAttributeValue<int?>("customizationlevel");
            }
        }

        /// <summary>
        /// Description of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get
            {
                return GetAttributeValue<string>("description");
            }
            set
            {
                OnPropertyChanging("Description");
                SetAttributeValue("description", value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Information that specifies whether this component should be hidden.
        /// </summary>
        [AttributeLogicalName("ishidden")]
        public BooleanManagedProperty IsHidden
        {
            get
            {
                return GetAttributeValue<BooleanManagedProperty>("ishidden");
            }
            set
            {
                OnPropertyChanging("IsHidden");
                SetAttributeValue("ishidden", value);
                OnPropertyChanged("IsHidden");
            }
        }

        /// <summary>
        /// Information that specifies whether this component is managed.
        /// </summary>
        [AttributeLogicalName("ismanaged")]
        public bool? IsManaged
        {
            get
            {
                return GetAttributeValue<bool?>("ismanaged");
            }
        }

        /// <summary>
        /// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
        /// </summary>
        [AttributeLogicalName("isolationmode")]
        public OptionSetValue IsolationMode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("isolationmode");
            }
            set
            {
                OnPropertyChanging("IsolationMode");
                SetAttributeValue("isolationmode", value);
                OnPropertyChanged("IsolationMode");
            }
        }

        /// <summary>
        /// Major of the assembly version.
        /// </summary>
        [AttributeLogicalName("major")]
        public int? Major
        {
            get
            {
                return GetAttributeValue<int?>("major");
            }
        }

        /// <summary>
        /// Minor of the assembly version.
        /// </summary>
        [AttributeLogicalName("minor")]
        public int? Minor
        {
            get
            {
                return GetAttributeValue<int?>("minor");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public System.DateTime? ModifiedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the pluginassembly.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Name of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get
            {
                return GetAttributeValue<string>("name");
            }
            set
            {
                OnPropertyChanging("Name");
                SetAttributeValue("name", value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the organization with which the plug-in assembly is associated.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public EntityReference OrganizationId
        {
            get
            {
                return GetAttributeValue<EntityReference>("organizationid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("overwritetime")]
        public System.DateTime? OverwriteTime
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("overwritetime");
            }
        }

        /// <summary>
        /// File name of the plug-in assembly. Used when the source type is set to 1.
        /// </summary>
        [AttributeLogicalName("path")]
        public string Path
        {
            get
            {
                return GetAttributeValue<string>("path");
            }
            set
            {
                OnPropertyChanging("Path");
                SetAttributeValue("path", value);
                OnPropertyChanged("Path");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("pluginassemblyid")]
        public Guid? PluginAssemblyId
        {
            get
            {
                return GetAttributeValue<Guid?>("pluginassemblyid");
            }
            set
            {
                OnPropertyChanging("PluginAssemblyId");
                SetAttributeValue("pluginassemblyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("PluginAssemblyId");
            }
        }

        [AttributeLogicalName("pluginassemblyid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                PluginAssemblyId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("pluginassemblyidunique")]
        public Guid? PluginAssemblyIdUnique
        {
            get
            {
                return GetAttributeValue<Guid?>("pluginassemblyidunique");
            }
        }

        /// <summary>
        /// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
        /// </summary>
        [AttributeLogicalName("publickeytoken")]
        public string PublicKeyToken
        {
            get
            {
                return GetAttributeValue<string>("publickeytoken");
            }
            set
            {
                OnPropertyChanging("PublicKeyToken");
                SetAttributeValue("publickeytoken", value);
                OnPropertyChanged("PublicKeyToken");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public Guid? SolutionId
        {
            get
            {
                return GetAttributeValue<Guid?>("solutionid");
            }
        }

        /// <summary>
        /// Hash of the source of the assembly.
        /// </summary>
        [AttributeLogicalName("sourcehash")]
        public string SourceHash
        {
            get
            {
                return GetAttributeValue<string>("sourcehash");
            }
            set
            {
                OnPropertyChanging("SourceHash");
                SetAttributeValue("sourcehash", value);
                OnPropertyChanged("SourceHash");
            }
        }

        /// <summary>
        /// Location of the assembly, for example 0=database, 1=on-disk.
        /// </summary>
        [AttributeLogicalName("sourcetype")]
        public OptionSetValue SourceType
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("sourcetype");
            }
            set
            {
                OnPropertyChanging("SourceType");
                SetAttributeValue("sourcetype", value);
                OnPropertyChanged("SourceType");
            }
        }

        /// <summary>
        /// Version number of the assembly. The value can be obtained from the assembly through reflection.
        /// </summary>
        [AttributeLogicalName("version")]
        public string Version
        {
            get
            {
                return GetAttributeValue<string>("version");
            }
            set
            {
                OnPropertyChanging("Version");
                SetAttributeValue("version", value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        ///
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N pluginassembly_plugintype
        /// </summary>
        [RelationshipSchemaName("pluginassembly_plugintype")]
        public IEnumerable<PluginType> pluginassembly_plugintype
        {
            get
            {
                return GetRelatedEntities<PluginType>("pluginassembly_plugintype", null);
            }
            set
            {
                OnPropertyChanging("pluginassembly_plugintype");
                SetRelatedEntities("pluginassembly_plugintype", null, value);
                OnPropertyChanged("pluginassembly_plugintype");
            }
        }
    }
}