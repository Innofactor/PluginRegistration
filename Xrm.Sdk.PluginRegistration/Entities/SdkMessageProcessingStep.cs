namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Stage in the execution pipeline that a plug-in is to execute.
    /// </summary>
    [System.Runtime.Serialization.DataContract()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstep")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageProcessingStep : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageProcessingStep() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessageprocessingstep";

        public const int EntityTypeCode = 4608;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((PropertyChanging != null))
            {
                PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Indicates whether the asynchronous system job is automatically deleted on completion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("asyncautodelete")]
        public System.Nullable<bool> AsyncAutoDelete
        {
            get
            {
                return GetAttributeValue<bool?>("asyncautodelete");
            }
            set
            {
                OnPropertyChanging("AsyncAutoDelete");
                SetAttributeValue("asyncautodelete", value);
                OnPropertyChanged("AsyncAutoDelete");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("configuration")]
        public string Configuration
        {
            get
            {
                return GetAttributeValue<string>("configuration");
            }
            set
            {
                OnPropertyChanging("Configuration");
                SetAttributeValue("configuration", value);
                OnPropertyChanged("Configuration");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message processing step was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("createdon")]
        public System.DateTime? CreatedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Customization level of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get
            {
                return GetAttributeValue<int?>("customizationlevel");
            }
        }

        /// <summary>
        /// Description of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("description")]
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
        /// Unique identifier of the associated event handler.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("eventhandler")]
        public Microsoft.Xrm.Sdk.EntityReference EventHandler
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("eventhandler");
            }
            set
            {
                OnPropertyChanging("EventHandler");
                SetAttributeValue("eventhandler", value);
                OnPropertyChanged("EventHandler");
            }
        }

        /// <summary>
        /// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("filteringattributes")]
        public string FilteringAttributes
        {
            get
            {
                return GetAttributeValue<string>("filteringattributes");
            }
            set
            {
                OnPropertyChanging("FilteringAttributes");
                SetAttributeValue("filteringattributes", value);
                OnPropertyChanged("FilteringAttributes");
            }
        }

        /// <summary>
        /// Unique identifier of the user to impersonate context when step is executed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("impersonatinguserid")]
        public Microsoft.Xrm.Sdk.EntityReference ImpersonatingUserId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("impersonatinguserid");
            }
            set
            {
                OnPropertyChanging("ImpersonatingUserId");
                SetAttributeValue("impersonatinguserid", value);
                OnPropertyChanged("ImpersonatingUserId");
            }
        }

        /// <summary>
        /// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("invocationsource")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.OptionSetValue InvocationSource
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invocationsource");
            }
            set
            {
                OnPropertyChanging("InvocationSource");
                SetAttributeValue("invocationsource", value);
                OnPropertyChanged("InvocationSource");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
            }
            set
            {
                OnPropertyChanging("IsCustomizable");
                SetAttributeValue("iscustomizable", value);
                OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Information that specifies whether this component should be hidden.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("ishidden")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden");
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
        [Microsoft.Xrm.Sdk.AttributeLogicalName("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get
            {
                return GetAttributeValue<bool?>("ismanaged");
            }
        }

        /// <summary>
        /// Run-time mode of execution, for example, synchronous or asynchronous.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("mode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Mode
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
            }
            set
            {
                OnPropertyChanging("Mode");
                SetAttributeValue("mode", value);
                OnPropertyChanged("Mode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message processing step was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("modifiedon")]
        public System.DateTime? ModifiedOn
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Name of SdkMessage processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("name")]
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
        /// Unique identifier of the organization with which the SDK message processing step is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("overwritetime")]
        public System.DateTime? OverwriteTime
        {
            get
            {
                return GetAttributeValue<System.DateTime?>("overwritetime");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in type associated with the step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("plugintypeid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
            }
            set
            {
                OnPropertyChanging("PluginTypeId");
                SetAttributeValue("plugintypeid", value);
                OnPropertyChanged("PluginTypeId");
            }
        }

        /// <summary>
        /// Processing order within the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("rank")]
        public System.Nullable<int> Rank
        {
            get
            {
                return GetAttributeValue<int?>("rank");
            }
            set
            {
                OnPropertyChanging("Rank");
                SetAttributeValue("rank", value);
                OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessagefilterid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageFilterId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagefilterid");
            }
            set
            {
                OnPropertyChanging("SdkMessageFilterId");
                SetAttributeValue("sdkmessagefilterid", value);
                OnPropertyChanged("SdkMessageFilterId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
            }
            set
            {
                OnPropertyChanging("SdkMessageId");
                SetAttributeValue("sdkmessageid", value);
                OnPropertyChanged("SdkMessageId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepid")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepId");
                SetAttributeValue("sdkmessageprocessingstepid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SdkMessageProcessingStepId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepidunique")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepidunique");
            }
        }

        /// <summary>
        /// Unique identifier of the Sdk message processing step secure configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepsecureconfigid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("solutionid");
            }
        }

        /// <summary>
        /// Stage in the execution pipeline that the SDK message processing step is in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("stage")]
        public Microsoft.Xrm.Sdk.OptionSetValue Stage
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stage");
            }
            set
            {
                OnPropertyChanging("Stage");
                SetAttributeValue("stage", value);
                OnPropertyChanged("Stage");
            }
        }

        /// <summary>
        /// Status of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("statecode")]
        public System.Nullable<SdkMessageProcessingStepState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SdkMessageProcessingStepState)(System.Enum.ToObject(typeof(SdkMessageProcessingStepState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
            }
            set
            {
                OnPropertyChanging("StatusCode");
                SetAttributeValue("statuscode", value);
                OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Deployment that the SDK message processing step should be executed on; server, client, or both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("supporteddeployment")]
        public Microsoft.Xrm.Sdk.OptionSetValue SupportedDeployment
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("supporteddeployment");
            }
            set
            {
                OnPropertyChanging("SupportedDeployment");
                SetAttributeValue("supporteddeployment", value);
                OnPropertyChanged("SupportedDeployment");
            }
        }

        /// <summary>
        /// Number that identifies a specific revision of the SDK message processing step. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }

        /// <summary>
        /// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        {
            get
            {
                return GetRelatedEntities<SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
            }
            set
            {
                OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
                SetRelatedEntities("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
                OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        public SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        {
            get
            {
                return GetRelatedEntity<SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
            }
            set
            {
                OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
                SetRelatedEntity("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
                OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
            }
        }
    }
}
