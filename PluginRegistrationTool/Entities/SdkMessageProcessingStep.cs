namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Stage in the execution pipeline that a plug-in is to execute.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
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
        /// Indicates whether the asynchronous system job is automatically deleted on completion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncautodelete")]
        public System.Nullable<bool> AsyncAutoDelete
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("asyncautodelete");
            }
            set
            {
                this.OnPropertyChanging("AsyncAutoDelete");
                this.SetAttributeValue("asyncautodelete", value);
                this.OnPropertyChanged("AsyncAutoDelete");
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
        /// Step-specific configuration for the plug-in type. Passed to the plug-in constructor at run time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configuration")]
        public string Configuration
        {
            get
            {
                return this.GetAttributeValue<string>("configuration");
            }
            set
            {
                this.OnPropertyChanging("Configuration");
                this.SetAttributeValue("configuration", value);
                this.OnPropertyChanged("Configuration");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message processing step.
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
        /// Date and time when the SDK message processing step was created.
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
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstep.
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
        /// Customization level of the SDK message processing step.
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
        /// Description of the SDK message processing step.
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
        /// Unique identifier of the associated event handler.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
        public Microsoft.Xrm.Sdk.EntityReference EventHandler
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("eventhandler");
            }
            set
            {
                this.OnPropertyChanging("EventHandler");
                this.SetAttributeValue("eventhandler", value);
                this.OnPropertyChanged("EventHandler");
            }
        }

        /// <summary>
        /// Comma-separated list of attributes. If at least one of these attributes is modified, the plug-in should execute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filteringattributes")]
        public string FilteringAttributes
        {
            get
            {
                return this.GetAttributeValue<string>("filteringattributes");
            }
            set
            {
                this.OnPropertyChanging("FilteringAttributes");
                this.SetAttributeValue("filteringattributes", value);
                this.OnPropertyChanged("FilteringAttributes");
            }
        }

        /// <summary>
        /// Unique identifier of the user to impersonate context when step is executed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("impersonatinguserid")]
        public Microsoft.Xrm.Sdk.EntityReference ImpersonatingUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("impersonatinguserid");
            }
            set
            {
                this.OnPropertyChanging("ImpersonatingUserId");
                this.SetAttributeValue("impersonatinguserid", value);
                this.OnPropertyChanged("ImpersonatingUserId");
            }
        }

        /// <summary>
        /// Identifies if a plug-in should be executed from a parent pipeline, a child pipeline, or both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invocationsource")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.OptionSetValue InvocationSource
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invocationsource");
            }
            set
            {
                this.OnPropertyChanging("InvocationSource");
                this.SetAttributeValue("invocationsource", value);
                this.OnPropertyChanged("InvocationSource");
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
        /// Run-time mode of execution, for example, synchronous or asynchronous.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Mode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode");
            }
            set
            {
                this.OnPropertyChanging("Mode");
                this.SetAttributeValue("mode", value);
                this.OnPropertyChanged("Mode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message processing step.
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
        /// Date and time when the SDK message processing step was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstep.
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
        /// Name of SdkMessage processing step.
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
        /// Unique identifier of the organization with which the SDK message processing step is associated.
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
        /// Unique identifier of the plug-in type associated with the step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
            }
            set
            {
                this.OnPropertyChanging("PluginTypeId");
                this.SetAttributeValue("plugintypeid", value);
                this.OnPropertyChanged("PluginTypeId");
            }
        }

        /// <summary>
        /// Processing order within the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
        public System.Nullable<int> Rank
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("rank");
            }
            set
            {
                this.OnPropertyChanging("Rank");
                this.SetAttributeValue("rank", value);
                this.OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageFilterId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagefilterid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageFilterId");
                this.SetAttributeValue("sdkmessagefilterid", value);
                this.OnPropertyChanged("SdkMessageFilterId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageId");
                this.SetAttributeValue("sdkmessageid", value);
                this.OnPropertyChanged("SdkMessageId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageProcessingStepId");
                this.SetAttributeValue("sdkmessageprocessingstepid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SdkMessageProcessingStepId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepidunique")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepidunique");
            }
        }

        /// <summary>
        /// Unique identifier of the Sdk message processing step secure configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepsecureconfigid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
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
        /// Stage in the execution pipeline that the SDK message processing step is in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stage")]
        public Microsoft.Xrm.Sdk.OptionSetValue Stage
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stage");
            }
            set
            {
                this.OnPropertyChanging("Stage");
                this.SetAttributeValue("stage", value);
                this.OnPropertyChanged("Stage");
            }
        }

        /// <summary>
        /// Status of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SdkMessageProcessingStepState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
            }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Deployment that the SDK message processing step should be executed on; server, client, or both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supporteddeployment")]
        public Microsoft.Xrm.Sdk.OptionSetValue SupportedDeployment
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("supporteddeployment");
            }
            set
            {
                this.OnPropertyChanging("SupportedDeployment");
                this.SetAttributeValue("supporteddeployment", value);
                this.OnPropertyChanged("SupportedDeployment");
            }
        }

        /// <summary>
        /// Number that identifies a specific revision of the SDK message processing step. 
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
        /// 1:N SdkMessageProcessingStep_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SdkMessageProcessingStep_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> SdkMessageProcessingStep_AsyncOperations
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("SdkMessageProcessingStep_AsyncOperations", null);
            }
            set
            {
                this.OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("SdkMessageProcessingStep_AsyncOperations", null, value);
                this.OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> sdkmessageprocessingstepid_sdkmessageprocessingstepimage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null);
            }
            set
            {
                this.OnPropertyChanging("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("sdkmessageprocessingstepid_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("sdkmessageprocessingstepid_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstep")]
        public CrmSdk.SystemUser createdby_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_sdkmessageprocessingstep", null);
            }
        }

        /// <summary>
        /// N:1 impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("impersonatinguserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("impersonatinguserid_sdkmessageprocessingstep")]
        public CrmSdk.SystemUser impersonatinguserid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("impersonatinguserid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.SystemUser>("impersonatinguserid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public CrmSdk.SystemUser lk_sdkmessageprocessingstep_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessageprocessingstep_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public CrmSdk.SystemUser lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstep")]
        public CrmSdk.SystemUser modifiedby_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_sdkmessageprocessingstep", null);
            }
        }

        /// <summary>
        /// N:1 organization_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstep")]
        public CrmSdk.Organization organization_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Organization>("organization_sdkmessageprocessingstep", null);
            }
        }

        /// <summary>
        /// N:1 plugintype_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_sdkmessageprocessingstep")]
        public CrmSdk.PluginType plugintype_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.PluginType>("plugintype_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("plugintype_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.PluginType>("plugintype_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("plugintype_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 plugintypeid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintypeid_sdkmessageprocessingstep")]
        public CrmSdk.PluginType plugintypeid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.PluginType>("plugintypeid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("plugintypeid_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.PluginType>("plugintypeid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("plugintypeid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 sdkmessagefilterid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
        public CrmSdk.SdkMessageFilter sdkmessagefilterid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.SdkMessageFilter>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 sdkmessageid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
        public CrmSdk.SdkMessage sdkmessageid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.SdkMessage>("sdkmessageid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        public CrmSdk.SdkMessageProcessingStepSecureConfig sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.SdkMessageProcessingStepSecureConfig>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// N:1 serviceendpoint_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("eventhandler")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceendpoint_sdkmessageprocessingstep")]
        public CrmSdk.ServiceEndpoint serviceendpoint_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.ServiceEndpoint>("serviceendpoint_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("serviceendpoint_sdkmessageprocessingstep");
                this.SetRelatedEntity<CrmSdk.ServiceEndpoint>("serviceendpoint_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("serviceendpoint_sdkmessageprocessingstep");
            }
        }
    }
}
