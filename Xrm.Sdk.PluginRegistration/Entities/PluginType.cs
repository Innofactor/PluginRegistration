namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Type that inherits from the IPlugin interface and is contained within a plug-in assembly.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintype")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginType : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PluginType() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "plugintype";

        public const int EntityTypeCode = 4602;

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
        /// Full path name of the plug-in assembly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assemblyname")]
        public string AssemblyName
        {
            get
            {
                return this.GetAttributeValue<string>("assemblyname");
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
        /// Unique identifier of the user who created the plug-in type.
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
        /// Date and time when the plug-in type was created.
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
        /// Unique identifier of the delegate user who created the plugintype.
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
        }

        /// <summary>
        /// Customization level of the plug-in type.
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
        /// Description of the plug-in type.
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
        /// User friendly name for the plug-in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
        public string FriendlyName
        {
            get
            {
                return this.GetAttributeValue<string>("friendlyname");
            }
            set
            {
                this.OnPropertyChanging("FriendlyName");
                this.SetAttributeValue("friendlyname", value);
                this.OnPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// 
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
        /// Indicates if the plug-in is a custom activity for workflows.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowactivity")]
        public System.Nullable<bool> IsWorkflowActivity
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isworkflowactivity");
            }
        }

        /// <summary>
        /// Major of the version number of the assembly for the plug-in type.
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
        /// Minor of the version number of the assembly for the plug-in type.
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
        /// Unique identifier of the user who last modified the plug-in type.
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
        /// Date and time when the plug-in type was last modified.
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
        /// Unique identifier of the delegate user who last modified the plugintype.
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
        /// Name of the plug-in type.
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
        /// Unique identifier of the organization with which the plug-in type is associated.
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
        /// Unique identifier of the plug-in assembly that contains this plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pluginassemblyid")]
        public Microsoft.Xrm.Sdk.EntityReference PluginAssemblyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pluginassemblyid");
            }
            set
            {
                this.OnPropertyChanging("PluginAssemblyId");
                this.SetAttributeValue("pluginassemblyid", value);
                this.OnPropertyChanged("PluginAssemblyId");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        public System.Nullable<System.Guid> PluginTypeId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypeid");
            }
            set
            {
                this.OnPropertyChanging("PluginTypeId");
                this.SetAttributeValue("plugintypeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PluginTypeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.PluginTypeId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeidunique")]
        public System.Nullable<System.Guid> PluginTypeIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypeidunique");
            }
        }

        /// <summary>
        /// Public key token of the assembly for the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publickeytoken")]
        public string PublicKeyToken
        {
            get
            {
                return this.GetAttributeValue<string>("publickeytoken");
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
        /// Fully qualified type name of the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("typename")]
        public string TypeName
        {
            get
            {
                return this.GetAttributeValue<string>("typename");
            }
            set
            {
                this.OnPropertyChanging("TypeName");
                this.SetAttributeValue("typename", value);
                this.OnPropertyChanged("TypeName");
            }
        }

        /// <summary>
        /// Version number of the assembly for the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public string Version
        {
            get
            {
                return this.GetAttributeValue<string>("version");
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
        /// Group name of workflow custom activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowactivitygroupname")]
        public string WorkflowActivityGroupName
        {
            get
            {
                return this.GetAttributeValue<string>("workflowactivitygroupname");
            }
            set
            {
                this.OnPropertyChanging("WorkflowActivityGroupName");
                this.SetAttributeValue("workflowactivitygroupname", value);
                this.OnPropertyChanged("WorkflowActivityGroupName");
            }
        }
    }
}
