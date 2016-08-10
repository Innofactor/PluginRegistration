namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Message that is supported by the SDK.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("sdkmessage")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, INotifyPropertyChanging, INotifyPropertyChanged
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
        [AttributeLogicalName("autotransact")]
        public bool? AutoTransact
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
        [AttributeLogicalName("availability")]
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
        /// If this is a categorized method, this is the name, otherwise None.
        /// </summary>
        [AttributeLogicalName("categoryname")]
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
        [AttributeLogicalName("createdby")]
        public EntityReference CreatedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message was created.
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
        /// Unique identifier of the delegate user who created the sdkmessage.
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
        /// Customization level of the SDK message.
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
        /// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
        /// </summary>
        [AttributeLogicalName("expand")]
        public bool? Expand
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
        [AttributeLogicalName("isprivate")]
        public bool? IsPrivate
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
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessage.
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
        /// Name of the SDK message.
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
        /// Unique identifier of the organization with which the SDK message is associated.
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
        /// Unique identifier of the SDK message entity.
        /// </summary>
        [AttributeLogicalName("sdkmessageid")]
        public System.Guid? SdkMessageId
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

        [AttributeLogicalName("sdkmessageid")]
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
        [AttributeLogicalName("sdkmessageidunique")]
        public System.Guid? SdkMessageIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageidunique");
            }
        }

        /// <summary>
        /// Indicates whether the SDK message is a template.
        /// </summary>
        [AttributeLogicalName("template")]
        public bool? Template
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
        [AttributeLogicalName("throttlesettings")]
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
        [AttributeLogicalName("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }
    }
}
