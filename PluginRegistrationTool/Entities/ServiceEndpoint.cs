namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Service endpoint that can be contacted.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("serviceendpoint")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class ServiceEndpoint : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
        /// Connection mode to contact the service endpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ConnectionMode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("connectionmode");
            }
            set
            {
                this.OnPropertyChanging("ConnectionMode");
                this.SetAttributeValue("connectionmode", value);
                this.OnPropertyChanged("ConnectionMode");
            }
        }

        /// <summary>
        /// Type of the endpoint contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contract")]
        public Microsoft.Xrm.Sdk.OptionSetValue Contract
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("contract");
            }
            set
            {
                this.OnPropertyChanging("Contract");
                this.SetAttributeValue("contract", value);
                this.OnPropertyChanged("Contract");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the service endpoint.
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
        /// Date and time when the service endpoint was created.
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
        /// Unique identifier of the delegate user who created the service endpoint.
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
        /// Description of the service endpoint.
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
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
            }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
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
        /// Unique identifier of the user who last modified the service endpoint.
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
        /// Date and time when the service endpoint was last modified.
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
        /// Unique identifier of the delegate user who modified the service endpoint.
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
        /// Name of Service end point.
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
        /// Unique identifier of the organization with which the service endpoint is associated.
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
        /// Path to the service endpoint.
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
        /// Unique identifier of the service endpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceendpointid")]
        public System.Nullable<System.Guid> ServiceEndpointId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("serviceendpointid");
            }
            set
            {
                this.OnPropertyChanging("ServiceEndpointId");
                this.SetAttributeValue("serviceendpointid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ServiceEndpointId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceendpointid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.ServiceEndpointId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the service endpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceendpointidunique")]
        public System.Nullable<System.Guid> ServiceEndpointIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("serviceendpointidunique");
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
        /// Namespace of the App Fabric solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionnamespace")]
        public string SolutionNamespace
        {
            get
            {
                return this.GetAttributeValue<string>("solutionnamespace");
            }
            set
            {
                this.OnPropertyChanging("SolutionNamespace");
                this.SetAttributeValue("solutionnamespace", value);
                this.OnPropertyChanged("SolutionNamespace");
            }
        }

        /// <summary>
        /// Additional user claim value type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userclaim")]
        public Microsoft.Xrm.Sdk.OptionSetValue UserClaim
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("userclaim");
            }
            set
            {
                this.OnPropertyChanging("UserClaim");
                this.SetAttributeValue("userclaim", value);
                this.OnPropertyChanged("UserClaim");
            }
        }

        /// <summary>
        /// 1:N serviceendpoint_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceendpoint_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> serviceendpoint_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_serviceendpoint", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_serviceendpoint");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_serviceendpoint", null, value);
                this.OnPropertyChanged("userentityinstancedata_serviceendpoint");
            }
        }

        /// <summary>
        /// N:1 createdby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_serviceendpoint")]
        public CrmSdk.SystemUser createdby_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_serviceendpoint", null);
            }
        }

        /// <summary>
        /// N:1 lk_serviceendpointbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_createdonbehalfby")]
        public CrmSdk.SystemUser lk_serviceendpointbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_serviceendpointbase_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_serviceendpointbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_modifiedonbehalfby")]
        public CrmSdk.SystemUser lk_serviceendpointbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_serviceendpointbase_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 modifiedby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_serviceendpoint")]
        public CrmSdk.SystemUser modifiedby_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_serviceendpoint", null);
            }
        }

        /// <summary>
        /// N:1 organization_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_serviceendpoint")]
        public CrmSdk.Organization organization_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Organization>("organization_serviceendpoint", null);
            }
        }
    }
}
