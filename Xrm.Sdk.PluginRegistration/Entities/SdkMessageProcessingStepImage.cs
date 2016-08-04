namespace Xrm.Sdk.PluginRegistration.Entities
{
    /// <summary>
    /// Copy of an entity's attributes before or after the core system operation.
    /// </summary>
    [System.Runtime.Serialization.DataContract()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalName("sdkmessageprocessingstepimage")]
    [System.CodeDom.Compiler.GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SdkMessageProcessingStepImage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageProcessingStepImage() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessageprocessingstepimage";

        public const int EntityTypeCode = 4615;

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
        /// Comma-separated list of attributes that are to be passed into the SDK message processing step image.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("attributes")]
        public string Attributes1
        {
            get
            {
                return GetAttributeValue<string>("attributes");
            }
            set
            {
                OnPropertyChanging("Attributes1");
                SetAttributeValue("attributes", value);
                OnPropertyChanged("Attributes1");
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
        /// Unique identifier of the user who created the SDK message processing step image.
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
        /// Date and time when the SDK message processing step image was created.
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
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstepimage.
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
        /// Customization level of the SDK message processing step image.
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
        /// Description of the SDK message processing step image.
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
        /// Key name used to access the pre-image or post-image property bags in a step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("entityalias")]
        public string EntityAlias
        {
            get
            {
                return GetAttributeValue<string>("entityalias");
            }
            set
            {
                OnPropertyChanging("EntityAlias");
                SetAttributeValue("entityalias", value);
                OnPropertyChanged("EntityAlias");
            }
        }

        /// <summary>
        /// Type of image requested.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("imagetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ImageType
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("imagetype");
            }
            set
            {
                OnPropertyChanging("ImageType");
                SetAttributeValue("imagetype", value);
                OnPropertyChanged("ImageType");
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
        /// 
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
        /// Name of the property on the Request message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("messagepropertyname")]
        public string MessagePropertyName
        {
            get
            {
                return GetAttributeValue<string>("messagepropertyname");
            }
            set
            {
                OnPropertyChanging("MessagePropertyName");
                SetAttributeValue("messagepropertyname", value);
                OnPropertyChanged("MessagePropertyName");
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
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepimage.
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
        /// Name of SdkMessage processing step image.
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
        /// Name of the related entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("relatedattributename")]
        public string RelatedAttributeName
        {
            get
            {
                return GetAttributeValue<string>("relatedattributename");
            }
            set
            {
                OnPropertyChanging("RelatedAttributeName");
                SetAttributeValue("relatedattributename", value);
                OnPropertyChanged("RelatedAttributeName");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageProcessingStepId
        {
            get
            {
                return GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageprocessingstepid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepId");
                SetAttributeValue("sdkmessageprocessingstepid", value);
                OnPropertyChanged("SdkMessageProcessingStepId");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step image entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepimageid")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepImageId
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepimageid");
            }
            set
            {
                OnPropertyChanging("SdkMessageProcessingStepImageId");
                SetAttributeValue("sdkmessageprocessingstepimageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                OnPropertyChanged("SdkMessageProcessingStepImageId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepimageid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SdkMessageProcessingStepImageId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step image.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalName("sdkmessageprocessingstepimageidunique")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepImageIdUnique
        {
            get
            {
                return GetAttributeValue<System.Guid?>("sdkmessageprocessingstepimageidunique");
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
        /// Number that identifies a specific revision of the step image. 
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
