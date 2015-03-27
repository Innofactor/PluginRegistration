namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Assembly that contains one or more plug-in types.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("pluginassembly")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginAssembly : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Bytes of the assembly, in Base64 format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
        public string Content
        {
            get
            {
                return this.GetAttributeValue<string>("content");
            }
            set
            {
                this.OnPropertyChanging("Content");
                this.SetAttributeValue("content", value);
                this.OnPropertyChanged("Content");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the pluginassembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Culture code for the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("culture")]
        public string Culture
        {
            get
            {
                return this.GetAttributeValue<string>("culture");
            }
            set
            {
                this.OnPropertyChanging("Culture");
                this.SetAttributeValue("culture", value);
                this.OnPropertyChanged("Culture");
            }
        }

        /// <summary>
        /// Customization Level.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("customizationlevel");
            }
        }

        /// <summary>
        /// Description of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Information that specifies whether this component should be hidden.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
            }
            set
            {
                this.OnPropertyChanging("IsHidden");
                this.SetAttributeValue("ishidden", value);
                this.OnPropertyChanged("IsHidden");
            }
        }

        /// <summary>
        /// Information that specifies whether this component is managed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
            }
        }

        /// <summary>
        /// Information about how the plugin assembly is to be isolated at execution time; None / Sandboxed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isolationmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IsolationMode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("isolationmode");
            }
            set
            {
                this.OnPropertyChanging("IsolationMode");
                this.SetAttributeValue("isolationmode", value);
                this.OnPropertyChanged("IsolationMode");
            }
        }

        /// <summary>
        /// Major of the assembly version.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("major")]
        public System.Nullable<int> Major
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("major");
            }
        }

        /// <summary>
        /// Minor of the assembly version.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minor")]
        public System.Nullable<int> Minor
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("minor");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the plug-in assembly was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the pluginassembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Name of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the organization with which the plug-in assembly is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
            }
        }

        /// <summary>
        /// File name of the plug-in assembly. Used when the source type is set to 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("path")]
        public string Path
        {
            get
            {
                return this.GetAttributeValue<string>("path");
            }
            set
            {
                this.OnPropertyChanging("Path");
                this.SetAttributeValue("path", value);
                this.OnPropertyChanged("Path");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
        public System.Nullable<System.Guid> PluginAssemblyId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyid");
            }
            set
            {
                this.OnPropertyChanging("PluginAssemblyId");
                this.SetAttributeValue("pluginassemblyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PluginAssemblyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.PluginAssemblyId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyidunique")]
        public System.Nullable<System.Guid> PluginAssemblyIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("pluginassemblyidunique");
            }
        }

        /// <summary>
        /// Public key token of the assembly. This value can be obtained from the assembly by using reflection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
        public string PublicKeyToken
        {
            get
            {
                return this.GetAttributeValue<string>("publickeytoken");
            }
            set
            {
                this.OnPropertyChanging("PublicKeyToken");
                this.SetAttributeValue("publickeytoken", value);
                this.OnPropertyChanged("PublicKeyToken");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
            }
        }

        /// <summary>
        /// Hash of the source of the assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcehash")]
        public string SourceHash
        {
            get
            {
                return this.GetAttributeValue<string>("sourcehash");
            }
            set
            {
                this.OnPropertyChanging("SourceHash");
                this.SetAttributeValue("sourcehash", value);
                this.OnPropertyChanged("SourceHash");
            }
        }

        /// <summary>
        /// Location of the assembly, for example 0=database, 1=on-disk.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue SourceType
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("sourcetype");
            }
            set
            {
                this.OnPropertyChanging("SourceType");
                this.SetAttributeValue("sourcetype", value);
                this.OnPropertyChanged("SourceType");
            }
        }

        /// <summary>
        /// Version number of the assembly. The value can be obtained from the assembly through reflection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public string Version
        {
            get
            {
                return this.GetAttributeValue<string>("version");
            }
            set
            {
                this.OnPropertyChanging("Version");
                this.SetAttributeValue("version", value);
                this.OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N pluginassembly_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pluginassembly_plugintype")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> pluginassembly_plugintype
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("pluginassembly_plugintype", null);
            }
            set
            {
                this.OnPropertyChanging("pluginassembly_plugintype");
                this.SetRelatedEntities<CrmSdk.PluginType>("pluginassembly_plugintype", null, value);
                this.OnPropertyChanged("pluginassembly_plugintype");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_pluginassembly")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_pluginassembly
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_pluginassembly", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_pluginassembly");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_pluginassembly", null, value);
                this.OnPropertyChanged("userentityinstancedata_pluginassembly");
            }
        }

        /// <summary>
        /// N:1 createdby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_pluginassembly")]
        public CrmSdk.SystemUser createdby_pluginassembly
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_pluginassembly", null);
            }
        }

        /// <summary>
        /// N:1 lk_pluginassembly_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_createdonbehalfby")]
        public CrmSdk.SystemUser lk_pluginassembly_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_pluginassembly_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_pluginassembly_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_modifiedonbehalfby")]
        public CrmSdk.SystemUser lk_pluginassembly_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_pluginassembly_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 modifiedby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_pluginassembly")]
        public CrmSdk.SystemUser modifiedby_pluginassembly
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_pluginassembly", null);
            }
        }

        /// <summary>
        /// N:1 organization_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_pluginassembly")]
        public CrmSdk.Organization organization_pluginassembly
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Organization>("organization_pluginassembly", null);
            }
        }
    }
}
