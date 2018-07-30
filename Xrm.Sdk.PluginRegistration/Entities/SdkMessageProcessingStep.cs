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
    /// Stage in the execution pipeline that a plug-in is to execute.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("sdkmessageprocessingstep")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageProcessingStep : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region Public Fields

        public const string EntityLogicalName = "sdkmessageprocessingstep";

        public const int EntityTypeCode = 4608;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageProcessingStep() :
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
        /// Indicates whether the asynchronous system job is automatically deleted on completion.
        /// </summary>
        [AttributeLogicalName("asyncautodelete")]
        public bool? AsyncAutoDelete
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
        [AttributeLogicalName("componentstate")]
        public OptionSetValue ComponentState
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("componentstate");
            }
        }

        /// <summary>
        /// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
        /// </summary>
        [AttributeLogicalName("configuration")]
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
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message processing step was created.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public DateTime? CreatedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("createdon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
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
        /// Customization level of the SDK message processing step.
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
        /// Description of the SDK message processing step.
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
        /// Unique identifier of the associated event handler.
        /// </summary>
        [AttributeLogicalName("eventhandler")]
        public EntityReference EventHandler
        {
            get
            {
                return GetAttributeValue<EntityReference>("eventhandler");
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
        [AttributeLogicalName("filteringattributes")]
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

        [AttributeLogicalName("sdkmessageprocessingstepid")]
        public override Guid Id
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
        /// Unique identifier of the user to impersonate context when step is executed.
        /// </summary>
        [AttributeLogicalName("impersonatinguserid")]
        public EntityReference ImpersonatingUserId
        {
            get
            {
                return GetAttributeValue<EntityReference>("impersonatinguserid");
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
        [AttributeLogicalName("invocationsource")]
        [Obsolete()]
        public OptionSetValue InvocationSource
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("invocationsource");
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
        /// Run-time mode of execution, for example, synchronous or asynchronous.
        /// </summary>
        [AttributeLogicalName("mode")]
        public OptionSetValue Mode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("mode");
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
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message processing step was last modified.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public DateTime? ModifiedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("modifiedon");
            }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
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
        /// Name of SdkMessage processing step.
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
        /// Unique identifier of the organization with which the SDK message processing step is associated.
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
        public DateTime? OverwriteTime
        {
            get
            {
                return GetAttributeValue<DateTime?>("overwritetime");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in type associated with the step.
        /// </summary>
        [AttributeLogicalName("plugintypeid")]
        [Obsolete()]
        public EntityReference PluginTypeId
        {
            get
            {
                return GetAttributeValue<EntityReference>("plugintypeid");
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
        [AttributeLogicalName("rank")]
        public int? Rank
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
        [AttributeLogicalName("sdkmessagefilterid")]
        public EntityReference SdkMessageFilterId
        {
            get
            {
                return GetAttributeValue<EntityReference>("sdkmessagefilterid");
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
        [AttributeLogicalName("sdkmessageid")]
        public EntityReference SdkMessageId
        {
            get
            {
                return GetAttributeValue<EntityReference>("sdkmessageid");
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
        [AttributeLogicalName("sdkmessageprocessingstepid")]
        public Guid? SdkMessageProcessingStepId
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessageprocessingstepid");
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
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        /// <summary>
        /// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        /// </summary>
        [RelationshipSchemaName("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public IEnumerable<SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
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
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepidunique")]
        public Guid? SdkMessageProcessingStepIdUnique
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessageprocessingstepidunique");
            }
        }

        /// <summary>
        /// Unique identifier of the Sdk message processing step secure configuration.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public EntityReference SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return GetAttributeValue<EntityReference>("sdkmessageprocessingstepsecureconfigid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
            }
        }

        /// <summary>
        /// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        [RelationshipSchemaName("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
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
        /// Stage in the execution pipeline that the SDK message processing step is in.
        /// </summary>
        [AttributeLogicalName("stage")]
        public OptionSetValue Stage
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("stage");
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
        [AttributeLogicalName("statecode")]
        public SdkMessageProcessingStepState? StateCode
        {
            get
            {
                OptionSetValue optionSet = GetAttributeValue<OptionSetValue>("statecode");
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
        [AttributeLogicalName("statuscode")]
        public OptionSetValue StatusCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("statuscode");
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
        [AttributeLogicalName("supporteddeployment")]
        public OptionSetValue SupportedDeployment
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("supporteddeployment");
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