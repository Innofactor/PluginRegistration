namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Filter that defines which SDK messages are valid for each type of entity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagefilter")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
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
        /// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
        public System.Nullable<int> Availability
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("availability");
            }
            set
            {
                this.OnPropertyChanging("Availability");
                this.SetAttributeValue("availability", value);
                this.OnPropertyChanged("Availability");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message filter.
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
        /// Date and time when the SDK message filter was created.
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
        /// Unique identifier of the delegate user who created the sdkmessagefilter.
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
        /// Customization level of the SDK message filter.
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
        /// Indicates whether a custom SDK message processing step is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomprocessingstepallowed")]
        public System.Nullable<bool> IsCustomProcessingStepAllowed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("iscustomprocessingstepallowed");
            }
            set
            {
                this.OnPropertyChanging("IsCustomProcessingStepAllowed");
                this.SetAttributeValue("iscustomprocessingstepallowed", value);
                this.OnPropertyChanged("IsCustomProcessingStepAllowed");
            }
        }

        /// <summary>
        /// Indicates whether the filter should be visible.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
        public System.Nullable<bool> IsVisible
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isvisible");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message filter.
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
        /// Date and time when the SDK message filter was last modified.
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
        /// Unique identifier of the delegate user who last modified the sdkmessagefilter.
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
        /// Unique identifier of the organization with which the SDK message filter is associated.
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
        /// Type of entity with which the SDK message filter is primarily associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("primaryobjecttypecode");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
        public System.Nullable<System.Guid> SdkMessageFilterId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilterid");
            }
            set
            {
                this.OnPropertyChanging("SdkMessageFilterId");
                this.SetAttributeValue("sdkmessagefilterid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageFilterId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilterid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SdkMessageFilterId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagefilteridunique")]
        public System.Nullable<System.Guid> SdkMessageFilterIdUnique
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagefilteridunique");
            }
        }

        /// <summary>
        /// Unique identifier of the related SDK message.
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
        /// Type of entity with which the SDK message filter is secondarily associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondaryobjecttypecode")]
        public string SecondaryObjectTypeCode
        {
            get
            {
                return this.GetAttributeValue<string>("secondaryobjecttypecode");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        ///// <summary>
        ///// 1:N sdkmessagefilterid_sdkmessageprocessingstep
        ///// </summary>
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessagefilterid_sdkmessageprocessingstep")]
        //public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> sdkmessagefilterid_sdkmessageprocessingstep
        //{
        //    get
        //    {
        //        return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null);
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("sdkmessagefilterid_sdkmessageprocessingstep");
        //        this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("sdkmessagefilterid_sdkmessageprocessingstep", null, value);
        //        this.OnPropertyChanged("sdkmessagefilterid_sdkmessageprocessingstep");
        //    }
        //}

        ///// <summary>
        ///// 1:N userentityinstancedata_sdkmessagefilter
        ///// </summary>
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagefilter")]
        //public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_sdkmessagefilter
        //{
        //    get
        //    {
        //        return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessagefilter", null);
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("userentityinstancedata_sdkmessagefilter");
        //        this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_sdkmessagefilter", null, value);
        //        this.OnPropertyChanged("userentityinstancedata_sdkmessagefilter");
        //    }
        //}

        ///// <summary>
        ///// N:1 createdby_sdkmessagefilter
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagefilter")]
        //public CrmSdk.SystemUser createdby_sdkmessagefilter
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_sdkmessagefilter", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 lk_sdkmessagefilter_createdonbehalfby
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_createdonbehalfby")]
        //public CrmSdk.SystemUser lk_sdkmessagefilter_createdonbehalfby
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessagefilter_createdonbehalfby", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 lk_sdkmessagefilter_modifiedonbehalfby
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_modifiedonbehalfby")]
        //public CrmSdk.SystemUser lk_sdkmessagefilter_modifiedonbehalfby
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_sdkmessagefilter_modifiedonbehalfby", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 modifiedby_sdkmessagefilter
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagefilter")]
        //public CrmSdk.SystemUser modifiedby_sdkmessagefilter
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_sdkmessagefilter", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 organization_sdkmessagefilter
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagefilter")]
        //public CrmSdk.Organization organization_sdkmessagefilter
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.Organization>("organization_sdkmessagefilter", null);
        //    }
        //}

        ///// <summary>
        ///// N:1 sdkmessageid_sdkmessagefilter
        ///// </summary>
        //[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        //[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
        //public CrmSdk.SdkMessage sdkmessageid_sdkmessagefilter
        //{
        //    get
        //    {
        //        return this.GetRelatedEntity<CrmSdk.SdkMessage>("sdkmessageid_sdkmessagefilter", null);
        //    }
        //    set
        //    {
        //        this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
        //        this.SetRelatedEntity<CrmSdk.SdkMessage>("sdkmessageid_sdkmessagefilter", null, value);
        //        this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
        //    }
        //}
    }
}
