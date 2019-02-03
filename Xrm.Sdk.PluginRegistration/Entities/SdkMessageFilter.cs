namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Filter that defines which SDK messages are valid for each type of entity.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("sdkmessagefilter")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageFilter : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        #region Public Fields

        public const string EntityLogicalName = "sdkmessagefilter";

        public const int EntityTypeCode = 4607;

        #endregion Public Fields

        #region Public Constructors

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageFilter() :
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
        /// Unique identifier of the user who created the SDK message filter.
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
        /// Date and time when the SDK message filter was created.
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
        /// Unique identifier of the delegate user who created the sdkmessagefilter.
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
        /// Customization level of the SDK message filter.
        /// </summary>
        [AttributeLogicalName("customizationlevel")]
        public int? CustomizationLevel
        {
            get
            {
                return GetAttributeValue<int?>("customizationlevel");
            }
        }

        [AttributeLogicalName("sdkmessagefilterid")]
        public override Guid Id
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
        /// Indicates whether a custom SDK message processing step is allowed.
        /// </summary>
        [AttributeLogicalName("iscustomprocessingstepallowed")]
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
        [AttributeLogicalName("isvisible")]
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
        [AttributeLogicalName("modifiedby")]
        public EntityReference ModifiedBy
        {
            get
            {
                return GetAttributeValue<EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Date and time when the SDK message filter was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessagefilter.
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
        /// Unique identifier of the organization with which the SDK message filter is associated.
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
        /// Type of entity with which the SDK message filter is primarily associated.
        /// </summary>
        [AttributeLogicalName("primaryobjecttypecode")]
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
        [AttributeLogicalName("sdkmessagefilterid")]
        public Guid? SdkMessageFilterId
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessagefilterid");
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
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageFilterId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter.
        /// </summary>
        [AttributeLogicalName("sdkmessagefilteridunique")]
        public Guid? SdkMessageFilterIdUnique
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessagefilteridunique");
            }
        }

        /// <summary>
        /// Unique identifier of the related SDK message.
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
        /// Type of entity with which the SDK message filter is secondarily associated.
        /// </summary>
        [AttributeLogicalName("secondaryobjecttypecode")]
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