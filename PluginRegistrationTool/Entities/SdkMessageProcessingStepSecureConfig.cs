namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Non-public custom configuration that is passed to a plug-in's constructor.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
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
        /// Unique identifier of the delegate user who created the sdkmessageprocessingstepsecureconfig.
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
        /// Customization level of the SDK message processing step secure configuration.
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
        /// Unique identifier of the delegate user who last modified the sdkmessageprocessingstepsecureconfig.
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
        /// Unique identifier of the SDK message processing step secure configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageProcessingStepSecureConfigId");
                this.SetAttributeValue("sdkmessageprocessingstepsecureconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageProcessingStepSecureConfigId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SdkMessageProcessingStepSecureConfigId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageprocessingstepsecureconfigidunique")]
        public System.Nullable<System.Guid> SdkMessageProcessingStepSecureConfigIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageprocessingstepsecureconfigidunique");
            }
        }

        /// <summary>
        /// Secure step-specific configuration for the plug-in type that is passed to the plug-in's constructor at run time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secureconfig")]
        public string SecureConfig
        {
            get
            {
                return this.GetAttributeValue<string>("secureconfig");
            }
            set
            {
                this.OnPropertyChanging("SecureConfig");
                this.SetAttributeValue("secureconfig", value);
                this.OnPropertyChanged("SecureConfig");
            }
        }

        ///// <summary>
        ///// 1:N sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        ///// </summary>
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep")]
        //public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep
        //{
        //    get
        //    {
        //        return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null);
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
        //        this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep", null, value);
        //        this.OnPropertyChanged("sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep");
        //    }
        //}

        ///// <summary>
        ///// 1:N userentityinstancedata_sdkmessageprocessingstepsecureconfig
        ///// </summary>
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageprocessingstepsecureconfig")]
        //public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_sdkmessageprocessingstepsecureconfig
        //{
        //    get
        //    {
        //        return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessageprocessingstepsecureconfig", null);
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
        //        this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessageprocessingstepsecureconfig", null, value);
        //        this.OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
        //    }
        //}

        ///// <summary>
        ///// N:1 createdby_sdkmessageprocessingstepsecureconfig
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstepsecureconfig")]
        //public CrmSdk.SystemUser createdby_sdkmessageprocessingstepsecureconfig
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_sdkmessageprocessingstepsecureconfig", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
        //public CrmSdk.SystemUser lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
        //public CrmSdk.SystemUser lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 modifiedby_sdkmessageprocessingstepsecureconfig
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstepsecureconfig")]
        //public CrmSdk.SystemUser modifiedby_sdkmessageprocessingstepsecureconfig
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_sdkmessageprocessingstepsecureconfig", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 organization_sdkmessageprocessingstepsecureconfig
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstepsecureconfig")]
        //public CrmSdk.Organization organization_sdkmessageprocessingstepsecureconfig
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.Organization>("organization_sdkmessageprocessingstepsecureconfig", null);
        //    }
        //}
    }
}
