namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Service endpoint that can be contacted.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("serviceendpoint")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class ServiceEndpoint : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ServiceEndpoint() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "serviceendpoint";

        public const int EntityTypeCode = 4618;

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
        /// Connection mode to contact the service endpoint.
        /// </summary>
        [AttributeLogicalName("connectionmode")]
        public OptionSetValue ConnectionMode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("connectionmode");
            }
            set
            {
                OnPropertyChanging("ConnectionMode");
                SetAttributeValue("connectionmode", value);
                OnPropertyChanged("ConnectionMode");
            }
        }

        /// <summary>
        /// Type of the endpoint contract.
        /// </summary>
        [AttributeLogicalName("contract")]
        public OptionSetValue Contract
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("contract");
            }
            set
            {
                OnPropertyChanging("Contract");
                SetAttributeValue("contract", value);
                OnPropertyChanged("Contract");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the service endpoint.
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
        /// Date and time when the service endpoint was created.
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
        /// Unique identifier of the delegate user who created the service endpoint.
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
        /// Description of the service endpoint.
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
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [AttributeLogicalName("iscustomizable")]
        public BooleanManagedProperty IsCustomizable
        {
            get
            {
                return GetAttributeValue<BooleanManagedProperty>("iscustomizable");
            }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
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
        /// Unique identifier of the user who last modified the service endpoint.
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
        /// Date and time when the service endpoint was last modified.
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
        /// Unique identifier of the delegate user who modified the service endpoint.
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
        /// Name of Service end point.
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
        /// Unique identifier of the organization with which the service endpoint is associated.
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
        /// Path to the service endpoint.
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
        /// Unique identifier of the service endpoint.
        /// </summary>
        [AttributeLogicalName("serviceendpointid")]
        public System.Guid? ServiceEndpointId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("serviceendpointid");
            }
            set
            {
                OnPropertyChanging("ServiceEndpointId");
                SetAttributeValue("serviceendpointid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("ServiceEndpointId");
            }
        }

        [AttributeLogicalName("serviceendpointid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                ServiceEndpointId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the service endpoint.
        /// </summary>
        [AttributeLogicalName("serviceendpointidunique")]
        public System.Guid? ServiceEndpointIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("serviceendpointidunique");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [AttributeLogicalName("solutionid")]
        public System.Guid? SolutionId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("solutionid");
            }
        }

        /// <summary>
        /// Namespace of the App Fabric solution.
        /// </summary>
        [AttributeLogicalName("solutionnamespace")]
        public string SolutionNamespace
        {
            get
            {
                return GetAttributeValue<string>("solutionnamespace");
            }
            set
            {
                OnPropertyChanging("SolutionNamespace");
                SetAttributeValue("solutionnamespace", value);
                OnPropertyChanged("SolutionNamespace");
            }
        }

        /// <summary>
        /// Additional user claim value type.
        /// </summary>
        [AttributeLogicalName("userclaim")]
        public OptionSetValue UserClaim
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("userclaim");
            }
            set
            {
                OnPropertyChanging("UserClaim");
                SetAttributeValue("userclaim", value);
                OnPropertyChanged("UserClaim");
            }
        }
    }
}