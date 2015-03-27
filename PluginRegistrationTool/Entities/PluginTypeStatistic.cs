namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Plug-in type statistic.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("plugintypestatistic")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class PluginTypeStatistic : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PluginTypeStatistic() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "plugintypestatistic";

        public const int EntityTypeCode = 4603;

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
        /// The average execution time (in milliseconds) for the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("averageexecutetimeinmilliseconds")]
        public System.Nullable<int> AverageExecuteTimeInMilliseconds
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("averageexecutetimeinmilliseconds");
            }
        }

        /// <summary>
        /// The plug-in type percentage contribution to crashes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcontributionpercent")]
        public System.Nullable<int> CrashContributionPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("crashcontributionpercent");
            }
        }

        /// <summary>
        /// Number of times the plug-in type has crashed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashcount")]
        public System.Nullable<int> CrashCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("crashcount");
            }
        }

        /// <summary>
        /// Percentage of crashes for the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crashpercent")]
        public System.Nullable<int> CrashPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("crashpercent");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the plug-in type statistic.
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
        /// Date and time when the plug-in type statistic was created.
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
        /// Unique identifier of the delegate user who created the plug-in type statistic.
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
        /// Number of times the plug-in type has been executed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executecount")]
        public System.Nullable<int> ExecuteCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("executecount");
            }
        }

        /// <summary>
        /// Number of times the plug-in type has failed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
        public System.Nullable<int> FailureCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("failurecount");
            }
        }

        /// <summary>
        /// Percentage of failures for the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurepercent")]
        public System.Nullable<int> FailurePercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("failurepercent");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the plug-in type statistic.
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
        /// Date and time when the plug-in type statistic was last modified.
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
        /// Unique identifier of the delegate user who modified the plug-in type statistic.
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
        /// Unique identifier of the organization with which the plug-in type statistic is associated.
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
        /// Unique identifier of the plug-in type associated with this plug-in type statistic.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid");
            }
        }

        /// <summary>
        /// Unique identifier of the plug-in type statistic.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
        public System.Nullable<System.Guid> PluginTypeStatisticId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("plugintypestatisticid");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypestatisticid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                base.Id = value;
            }
        }

        /// <summary>
        /// The plug-in type percentage contribution to Worker process termination due to excessive CPU usage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatecpucontributionpercent")]
        public System.Nullable<int> TerminateCpuContributionPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("terminatecpucontributionpercent");
            }
        }

        /// <summary>
        /// The plug-in type percentage contribution to Worker process termination due to excessive handle usage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatehandlescontributionpercent")]
        public System.Nullable<int> TerminateHandlesContributionPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("terminatehandlescontributionpercent");
            }
        }

        /// <summary>
        /// The plug-in type percentage contribution to Worker process termination due to excessive memory usage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminatememorycontributionpercent")]
        public System.Nullable<int> TerminateMemoryContributionPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("terminatememorycontributionpercent");
            }
        }

        /// <summary>
        /// The plug-in type percentage contribution to Worker process termination due to unknown reasons.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("terminateothercontributionpercent")]
        public System.Nullable<int> TerminateOtherContributionPercent
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("terminateothercontributionpercent");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_plugintypestatistic", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_plugintypestatistic");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_plugintypestatistic", null, value);
                this.OnPropertyChanged("userentityinstancedata_plugintypestatistic");
            }
        }

        /// <summary>
        /// N:1 createdby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintypestatistic")]
        public CrmSdk.SystemUser createdby_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("createdby_plugintypestatistic", null);
            }
        }

        /// <summary>
        /// N:1 lk_plugintypestatisticbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_createdonbehalfby")]
        public CrmSdk.SystemUser lk_plugintypestatisticbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_plugintypestatisticbase_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_plugintypestatisticbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_modifiedonbehalfby")]
        public CrmSdk.SystemUser lk_plugintypestatisticbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_plugintypestatisticbase_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 modifiedby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintypestatistic")]
        public CrmSdk.SystemUser modifiedby_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("modifiedby_plugintypestatistic", null);
            }
        }

        /// <summary>
        /// N:1 organization_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintypestatistic")]
        public CrmSdk.Organization organization_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Organization>("organization_plugintypestatistic", null);
            }
        }

        /// <summary>
        /// N:1 plugintype_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugintype_plugintypestatistic")]
        public CrmSdk.PluginType plugintype_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.PluginType>("plugintype_plugintypestatistic", null);
            }
        }
    }
}
