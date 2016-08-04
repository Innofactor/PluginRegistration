namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Message that is supported by the SDK.
    /// </summary>
    [System.Runtime.Serialization.DataContract()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessage")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessage() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessage";

        public const int EntityTypeCode = 4606;

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
        /// Information about whether the SDK message is automatically transacted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("autotransact")]
        public System.Nullable<bool> AutoTransact
        {
            get
            {
                return GetAttributeValue<bool?>("autotransact");
            }
            set
            {
                OnPropertyChanging("AutoTransact");
                SetAttributeValue("autotransact", value);
                OnPropertyChanged("AutoTransact");
            }
        }

        /// <summary>
        /// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("availability")]
        public System.Nullable<int> Availability
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
        /// If this is a categorized method, this is the name, otherwise None.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("categoryname")]
        public string CategoryName
        {
            get
            {
                return GetAttributeValue<string>("categoryname");
            }
            set
            {
                OnPropertyChanging("CategoryName");
                SetAttributeValue("categoryname", value);
                OnPropertyChanged("CategoryName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message.
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
        /// Date and time when the SDK message was created.
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
        /// Unique identifier of the delegate user who created the sdkmessage.
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
        /// Customization level of the SDK message.
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
        /// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("expand")]
        public System.Nullable<bool> Expand
        {
            get
            {
                return GetAttributeValue<bool?>("expand");
            }
            set
            {
                OnPropertyChanging("Expand");
                SetAttributeValue("expand", value);
                OnPropertyChanged("Expand");
            }
        }

        /// <summary>
        /// Indicates whether the SDK message is private.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("isprivate")]
        public System.Nullable<bool> IsPrivate
        {
            get
            {
                return GetAttributeValue<bool?>("isprivate");
            }
            set
            {
                OnPropertyChanging("IsPrivate");
                SetAttributeValue("isprivate", value);
                OnPropertyChanged("IsPrivate");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message.
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
        /// Date and time when the SDK message was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessage.
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
        /// Name of the SDK message.
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
        /// Unique identifier of the organization with which the SDK message is associated.
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
        /// Unique identifier of the SDK message entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageid")]
        public System.Nullable<System.Guid> SdkMessageId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageid");
            }
            set
            {
                OnPropertyChanging("SdkMessageId");
                SetAttributeValue("sdkmessageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("SdkMessageId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SdkMessageId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageidunique")]
        public System.Nullable<System.Guid> SdkMessageIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageidunique");
            }
        }

        /// <summary>
        /// Indicates whether the SDK message is a template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("template")]
        public System.Nullable<bool> Template
        {
            get
            {
                return GetAttributeValue<bool?>("template");
            }
            set
            {
                OnPropertyChanging("Template");
                SetAttributeValue("template", value);
                OnPropertyChanged("Template");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("throttlesettings")]
        public string ThrottleSettings
        {
            get
            {
                return GetAttributeValue<string>("throttlesettings");
            }
        }

        /// <summary>
        /// Number that identifies a specific revision of the SDK message. 
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
