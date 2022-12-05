namespace Xrm.Sdk.PluginRegistration.Entities
{
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
    [EntityLogicalName("pluginpackage")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginPackage : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region Public Fields

        public const string EntityLogicalName = "pluginpackage";

        public const int EntityTypeCode = 10090;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PluginPackage() :
            base(EntityLogicalName)
        {
        }

        #endregion Public Constructors

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        #endregion Public Events

        #region Public Properties

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

        [AttributeLogicalName("pluginpackageid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                PluginPackageId = value;
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
        /// 1:N pluginpackage_pluginassembly
        /// </summary>
        [RelationshipSchemaName("pluginpackage_pluginassembly")]
        public IEnumerable<PluginType> pluginpackage_pluginassembly
        {
            get
            {
                return GetRelatedEntities<PluginType>("pluginpackage_pluginassembly", null);
            }
            set
            {
                OnPropertyChanging("pluginpackage_pluginassembly");
                SetRelatedEntities("pluginpackage_pluginassembly", null, value);
                OnPropertyChanged("pluginpackage_pluginassembly");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in assembly.
        /// </summary>
        [AttributeLogicalName("pluginpackageid")]
        public Guid? PluginPackageId
        {
            get
            {
                return GetAttributeValue<Guid?>("pluginpackageid");
            }
            set
            {
                OnPropertyChanging("PluginPackageId");
                SetAttributeValue("pluginpackageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("PluginPackageId");
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
            set
            {
                OnPropertyChanging("SolutionId");
                SetAttributeValue("solutionid", value);
                OnPropertyChanged("SolutionId");
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

        #endregion Public Properties

        #region Private Methods

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

        #endregion Private Methods
    }
}