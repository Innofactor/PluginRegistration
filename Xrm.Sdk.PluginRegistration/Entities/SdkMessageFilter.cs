namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Filter that defines which SDK messages are valid for each type of entity.
    /// </summary>
    [System.Runtime.Serialization.DataContract()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessagefilter")]
    [System.CodeDom.Compiler.GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageFilter : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageFilter() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessagefilter";

        public const int EntityTypeCode = 4607;

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
        /// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("availability")]
        public int? Availability
        {
            get
            {
                return GetAttributeValue<int?>("availability");
            }
            set
            {
                OnPropertyChanging("Availability");
                SetAttributeValue("availability", value);
                OnPropertyChanged("Availability");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message filter.
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
        /// Date and time when the SDK message filter was created.
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
        /// Unique identifier of the delegate user who created the sdkmessagefilter.
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
        /// Customization level of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get
            {
                return GetAttributeValue<int?>("customizationlevel");
            }
        }

        /// <summary>
        /// Indicates whether a custom SDK message processing step is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("iscustomprocessingstepallowed")]
        public bool? IsCustomProcessingStepAllowed
        {
            get
            {
                return GetAttributeValue<bool?>("iscustomprocessingstepallowed");
            }
            set
            {
                OnPropertyChanging("IsCustomProcessingStepAllowed");
                SetAttributeValue("iscustomprocessingstepallowed", value);
                OnPropertyChanged("IsCustomProcessingStepAllowed");
            }
        }

        /// <summary>
        /// Indicates whether the filter should be visible.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("isvisible")]
        public bool? IsVisible
        {
            get
            {
                return GetAttributeValue<bool?>("isvisible");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message filter.
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
        /// Date and time when the SDK message filter was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessagefilter.
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
        /// Unique identifier of the organization with which the SDK message filter is associated.
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
        /// Type of entity with which the SDK message filter is primarily associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get
            {
                return GetAttributeValue<string>("primaryobjecttypecode");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessagefilterid")]
        public System.Guid? SdkMessageFilterId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessagefilterid");
            }
            set
            {
                OnPropertyChanging("SdkMessageFilterId");
                SetAttributeValue("sdkmessagefilterid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("SdkMessageFilterId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessagefilterid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SdkMessageFilterId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessagefilteridunique")]
        public System.Guid? SdkMessageFilterIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessagefilteridunique");
            }
        }

        /// <summary>
        /// Unique identifier of the related SDK message.
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
        /// Type of entity with which the SDK message filter is secondarily associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("secondaryobjecttypecode")]
        public string SecondaryObjectTypeCode
        {
            get
            {
                return GetAttributeValue<string>("secondaryobjecttypecode");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }
    }
}
