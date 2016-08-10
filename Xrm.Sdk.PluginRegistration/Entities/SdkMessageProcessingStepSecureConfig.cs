namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Magic;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Non-public custom configuration that is passed to a plug-in's constructor.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("sdkmessageprocessingstepsecureconfig")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageProcessingStepSecureConfig : Transformer, INotifyPropertyChanging, INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageProcessingStepSecureConfig() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessageprocessingstepsecureconfig";

        public const int EntityTypeCode = 4616;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

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
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.
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
        /// Customization level of the SDK message processing step secure configuration.
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
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.
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
        /// Unique identifier of the SDK message processing step secure configuration.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public Guid? SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
            }
        }

        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SdkMessageProcessingStepSecureConfigId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [AttributeLogicalName("sdkmessageprocessingstepsecureconfigidunique")]
        public Guid? SdkMessageProcessingStepSecureConfigIdUnique
        {
            get
            {
                return GetAttributeValue<Guid?>("sdkmessageprocessingstepsecureconfigidunique");
            }
        }

        /// <summary>
        /// Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.
        /// </summary>
        [AttributeLogicalName("secureconfig")]
        public string SecureConfig
        {
            get
            {
                return GetAttributeValue<string>("secureconfig");
            }
            set
            {
                OnPropertyChanging("SecureConfig");
                SetAttributeValue("secureconfig", value);
                OnPropertyChanged("SecureConfig");
            }
        }
    }
}
