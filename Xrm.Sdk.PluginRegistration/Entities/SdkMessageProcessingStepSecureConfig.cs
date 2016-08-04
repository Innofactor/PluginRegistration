namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Non-public custom configuration that is passed to a plug-in's constructor.
    /// </summary>
    [System.Runtime.Serialization.DataContract()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageprocessingstepsecureconfig")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageProcessingStepSecureConfig : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.
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
        /// Customization level of the SDK message processing step secure configuration.
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
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.
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
        /// Unique identifier of the SDK message processing step secure configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepsecureconfigid");
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
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepsecureconfigid")]
        public override System.Guid Id
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
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepsecureconfigidunique")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepsecureconfigidunique");
            }
        }

        /// <summary>
        /// Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("secureconfig")]
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
