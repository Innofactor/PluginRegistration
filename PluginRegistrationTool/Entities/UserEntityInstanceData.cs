//namespace PluginRegistrationTool.Entities
//{
//    /// <summary>
//    /// Per User item instance data
//    /// </summary>
//    [System.Runtime.Serialization.DataContractAttribute()]
//    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userentityinstancedata")]
//    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
//    public partial class UserEntityInstanceData : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
//    {

//        /// <summary>
//        /// Default Constructor.
//        /// </summary>
//        public UserEntityInstanceData() :
//            base(EntityLogicalName)
//        {
//        }

//        public const string EntityLogicalName = "userentityinstancedata";

//        public const int EntityTypeCode = 2501;

//        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

//        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

//        private void OnPropertyChanged(string propertyName)
//        {
//            if ((this.PropertyChanged != null))
//            {
//                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
//            }
//        }

//        private void OnPropertyChanging(string propertyName)
//        {
//            if ((this.PropertyChanging != null))
//            {
//                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
//            }
//        }

//        /// <summary>
//        /// Common end date
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("commonend")]
//        public System.Nullable<System.DateTime> CommonEnd
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("commonend");
//            }
//            set
//            {
//                this.OnPropertyChanging("CommonEnd");
//                this.SetAttributeValue("commonend", value);
//                this.OnPropertyChanged("CommonEnd");
//            }
//        }

//        /// <summary>
//        /// Common start date
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("commonstart")]
//        public System.Nullable<System.DateTime> CommonStart
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("commonstart");
//            }
//            set
//            {
//                this.OnPropertyChanging("CommonStart");
//                this.SetAttributeValue("commonstart", value);
//                this.OnPropertyChanged("CommonStart");
//            }
//        }

//        /// <summary>
//        /// Due Date
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duedate")]
//        public System.Nullable<System.DateTime> DueDate
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("duedate");
//            }
//            set
//            {
//                this.OnPropertyChanging("DueDate");
//                this.SetAttributeValue("duedate", value);
//                this.OnPropertyChanged("DueDate");
//            }
//        }

//        /// <summary>
//        /// Flag due by
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("flagdueby")]
//        public System.Nullable<System.DateTime> FlagDueBy
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("flagdueby");
//            }
//            set
//            {
//                this.OnPropertyChanging("FlagDueBy");
//                this.SetAttributeValue("flagdueby", value);
//                this.OnPropertyChanged("FlagDueBy");
//            }
//        }

//        /// <summary>
//        /// Flag request
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("flagrequest")]
//        public string FlagRequest
//        {
//            get
//            {
//                return this.GetAttributeValue<string>("flagrequest");
//            }
//            set
//            {
//                this.OnPropertyChanging("FlagRequest");
//                this.SetAttributeValue("flagrequest", value);
//                this.OnPropertyChanged("FlagRequest");
//            }
//        }

//        /// <summary>
//        /// Flag status.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("flagstatus")]
//        public System.Nullable<int> FlagStatus
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<int>>("flagstatus");
//            }
//            set
//            {
//                this.OnPropertyChanging("FlagStatus");
//                this.SetAttributeValue("flagstatus", value);
//                this.OnPropertyChanged("FlagStatus");
//            }
//        }

//        /// <summary>
//        /// Unique identifier of the source record.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        public Microsoft.Xrm.Sdk.EntityReference ObjectId
//        {
//            get
//            {
//                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
//            }
//            set
//            {
//                this.OnPropertyChanging("ObjectId");
//                this.SetAttributeValue("objectid", value);
//                this.OnPropertyChanged("ObjectId");
//            }
//        }

//        /// <summary>
//        /// Object Type Code
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
//        public System.Nullable<int> ObjectTypeCode
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<int>>("objecttypecode");
//            }
//            set
//            {
//                this.OnPropertyChanging("ObjectTypeCode");
//                this.SetAttributeValue("objecttypecode", value);
//                this.OnPropertyChanged("ObjectTypeCode");
//            }
//        }

//        /// <summary>
//        /// Unique identifier of the user or team who owns the user entity instance data.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
//        public Microsoft.Xrm.Sdk.EntityReference OwnerId
//        {
//            get
//            {
//                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
//            }
//            set
//            {
//                this.OnPropertyChanging("OwnerId");
//                this.SetAttributeValue("ownerid", value);
//                this.OnPropertyChanged("OwnerId");
//            }
//        }

//        /// <summary>
//        /// Unique identifier of the business unit that owns this.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
//        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
//        {
//            get
//            {
//                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
//            }
//        }

//        /// <summary>
//        /// Unique identifier of the team who owns this object.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
//        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
//        {
//            get
//            {
//                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
//            }
//        }

//        /// <summary>
//        /// Unique identifier of the user who owns this object.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
//        public Microsoft.Xrm.Sdk.EntityReference OwningUser
//        {
//            get
//            {
//                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
//            }
//        }

//        /// <summary>
//        /// Personal categories
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalcategories")]
//        public string PersonalCategories
//        {
//            get
//            {
//                return this.GetAttributeValue<string>("personalcategories");
//            }
//            set
//            {
//                this.OnPropertyChanging("PersonalCategories");
//                this.SetAttributeValue("personalcategories", value);
//                this.OnPropertyChanged("PersonalCategories");
//            }
//        }

//        /// <summary>
//        /// Indicates whether a reminder is set on this object.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reminderset")]
//        public System.Nullable<bool> ReminderSet
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<bool>>("reminderset");
//            }
//            set
//            {
//                this.OnPropertyChanging("ReminderSet");
//                this.SetAttributeValue("reminderset", value);
//                this.OnPropertyChanged("ReminderSet");
//            }
//        }

//        /// <summary>
//        /// Reminder time
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("remindertime")]
//        public System.Nullable<System.DateTime> ReminderTime
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("remindertime");
//            }
//            set
//            {
//                this.OnPropertyChanging("ReminderTime");
//                this.SetAttributeValue("remindertime", value);
//                this.OnPropertyChanged("ReminderTime");
//            }
//        }

//        /// <summary>
//        /// Start Time
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
//        public System.Nullable<System.DateTime> StartTime
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime");
//            }
//            set
//            {
//                this.OnPropertyChanging("StartTime");
//                this.SetAttributeValue("starttime", value);
//                this.OnPropertyChanged("StartTime");
//            }
//        }

//        /// <summary>
//        /// To Do item flags.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("todoitemflags")]
//        public System.Nullable<int> ToDoItemFlags
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<int>>("todoitemflags");
//            }
//            set
//            {
//                this.OnPropertyChanging("ToDoItemFlags");
//                this.SetAttributeValue("todoitemflags", value);
//                this.OnPropertyChanged("ToDoItemFlags");
//            }
//        }

//        /// <summary>
//        /// For internal use only.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("todoordinaldate")]
//        public System.Nullable<System.DateTime> ToDoOrdinalDate
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.DateTime>>("todoordinaldate");
//            }
//            set
//            {
//                this.OnPropertyChanging("ToDoOrdinalDate");
//                this.SetAttributeValue("todoordinaldate", value);
//                this.OnPropertyChanged("ToDoOrdinalDate");
//            }
//        }

//        /// <summary>
//        /// For internal use only.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("todosubordinal")]
//        public string ToDoSubOrdinal
//        {
//            get
//            {
//                return this.GetAttributeValue<string>("todosubordinal");
//            }
//            set
//            {
//                this.OnPropertyChanging("ToDoSubOrdinal");
//                this.SetAttributeValue("todosubordinal", value);
//                this.OnPropertyChanged("ToDoSubOrdinal");
//            }
//        }

//        /// <summary>
//        /// For internal use only.
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("todotitle")]
//        public string ToDoTitle
//        {
//            get
//            {
//                return this.GetAttributeValue<string>("todotitle");
//            }
//            set
//            {
//                this.OnPropertyChanging("ToDoTitle");
//                this.SetAttributeValue("todotitle", value);
//                this.OnPropertyChanged("ToDoTitle");
//            }
//        }

//        /// <summary>
//        /// Unique identifier user entity
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userentityinstancedataid")]
//        public System.Nullable<System.Guid> UserEntityInstanceDataId
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<System.Guid>>("userentityinstancedataid");
//            }
//            set
//            {
//                this.OnPropertyChanging("UserEntityInstanceDataId");
//                this.SetAttributeValue("userentityinstancedataid", value);
//                if (value.HasValue)
//                {
//                    base.Id = value.Value;
//                }
//                else
//                {
//                    base.Id = System.Guid.Empty;
//                }
//                this.OnPropertyChanged("UserEntityInstanceDataId");
//            }
//        }

//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userentityinstancedataid")]
//        public override System.Guid Id
//        {
//            get
//            {
//                return base.Id;
//            }
//            set
//            {
//                this.UserEntityInstanceDataId = value;
//            }
//        }

//        /// <summary>
//        /// 
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
//        public System.Nullable<long> VersionNumber
//        {
//            get
//            {
//                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
//            }
//        }

//        /// <summary>
//        /// N:1 team_userentityinstancedata
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userentityinstancedata")]
//        public CrmSdk.Team team_userentityinstancedata
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Team>("team_userentityinstancedata", null);
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_account
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_account")]
//        public CrmSdk.Account userentityinstancedata_account
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Account>("userentityinstancedata_account", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_account");
//                this.SetRelatedEntity<CrmSdk.Account>("userentityinstancedata_account", null, value);
//                this.OnPropertyChanged("userentityinstancedata_account");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_activitymimeattachment
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activitymimeattachment")]
//        public CrmSdk.ActivityMimeAttachment userentityinstancedata_activitymimeattachment
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ActivityMimeAttachment>("userentityinstancedata_activitymimeattachment", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_activitymimeattachment");
//                this.SetRelatedEntity<CrmSdk.ActivityMimeAttachment>("userentityinstancedata_activitymimeattachment", null, value);
//                this.OnPropertyChanged("userentityinstancedata_activitymimeattachment");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_activityparty
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activityparty")]
//        public CrmSdk.ActivityParty userentityinstancedata_activityparty
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ActivityParty>("userentityinstancedata_activityparty", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_activityparty");
//                this.SetRelatedEntity<CrmSdk.ActivityParty>("userentityinstancedata_activityparty", null, value);
//                this.OnPropertyChanged("userentityinstancedata_activityparty");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_annotation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_annotation")]
//        public CrmSdk.Annotation userentityinstancedata_annotation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Annotation>("userentityinstancedata_annotation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_annotation");
//                this.SetRelatedEntity<CrmSdk.Annotation>("userentityinstancedata_annotation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_annotation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_appointment
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_appointment")]
//        public CrmSdk.Appointment userentityinstancedata_appointment
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Appointment>("userentityinstancedata_appointment", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_appointment");
//                this.SetRelatedEntity<CrmSdk.Appointment>("userentityinstancedata_appointment", null, value);
//                this.OnPropertyChanged("userentityinstancedata_appointment");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_asyncoperation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_asyncoperation")]
//        public CrmSdk.AsyncOperation userentityinstancedata_asyncoperation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.AsyncOperation>("userentityinstancedata_asyncoperation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_asyncoperation");
//                this.SetRelatedEntity<CrmSdk.AsyncOperation>("userentityinstancedata_asyncoperation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_asyncoperation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_attributemap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_attributemap")]
//        public CrmSdk.AttributeMap userentityinstancedata_attributemap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.AttributeMap>("userentityinstancedata_attributemap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_attributemap");
//                this.SetRelatedEntity<CrmSdk.AttributeMap>("userentityinstancedata_attributemap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_attributemap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_audit
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_audit")]
//        public CrmSdk.Audit userentityinstancedata_audit
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Audit>("userentityinstancedata_audit", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_audit");
//                this.SetRelatedEntity<CrmSdk.Audit>("userentityinstancedata_audit", null, value);
//                this.OnPropertyChanged("userentityinstancedata_audit");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_bulkdeletefailure
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkdeletefailure")]
//        public CrmSdk.BulkDeleteFailure userentityinstancedata_bulkdeletefailure
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BulkDeleteFailure>("userentityinstancedata_bulkdeletefailure", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_bulkdeletefailure");
//                this.SetRelatedEntity<CrmSdk.BulkDeleteFailure>("userentityinstancedata_bulkdeletefailure", null, value);
//                this.OnPropertyChanged("userentityinstancedata_bulkdeletefailure");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_bulkdeleteoperation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkdeleteoperation")]
//        public CrmSdk.BulkDeleteOperation userentityinstancedata_bulkdeleteoperation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BulkDeleteOperation>("userentityinstancedata_bulkdeleteoperation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_bulkdeleteoperation");
//                this.SetRelatedEntity<CrmSdk.BulkDeleteOperation>("userentityinstancedata_bulkdeleteoperation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_bulkdeleteoperation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_bulkoperation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkoperation")]
//        public CrmSdk.BulkOperation userentityinstancedata_bulkoperation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BulkOperation>("userentityinstancedata_bulkoperation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_bulkoperation");
//                this.SetRelatedEntity<CrmSdk.BulkOperation>("userentityinstancedata_bulkoperation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_bulkoperation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_bulkoperationlog
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkoperationlog")]
//        public CrmSdk.BulkOperationLog userentityinstancedata_bulkoperationlog
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BulkOperationLog>("userentityinstancedata_bulkoperationlog", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_bulkoperationlog");
//                this.SetRelatedEntity<CrmSdk.BulkOperationLog>("userentityinstancedata_bulkoperationlog", null, value);
//                this.OnPropertyChanged("userentityinstancedata_bulkoperationlog");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_businessunit
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_businessunit")]
//        public CrmSdk.BusinessUnit userentityinstancedata_businessunit
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BusinessUnit>("userentityinstancedata_businessunit", null);
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_businessunitnewsarticle
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_businessunitnewsarticle")]
//        public CrmSdk.BusinessUnitNewsArticle userentityinstancedata_businessunitnewsarticle
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.BusinessUnitNewsArticle>("userentityinstancedata_businessunitnewsarticle", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_businessunitnewsarticle");
//                this.SetRelatedEntity<CrmSdk.BusinessUnitNewsArticle>("userentityinstancedata_businessunitnewsarticle", null, value);
//                this.OnPropertyChanged("userentityinstancedata_businessunitnewsarticle");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_calendar
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_calendar")]
//        public CrmSdk.Calendar userentityinstancedata_calendar
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Calendar>("userentityinstancedata_calendar", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_calendar");
//                this.SetRelatedEntity<CrmSdk.Calendar>("userentityinstancedata_calendar", null, value);
//                this.OnPropertyChanged("userentityinstancedata_calendar");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_campaign
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaign")]
//        public CrmSdk.Campaign userentityinstancedata_campaign
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Campaign>("userentityinstancedata_campaign", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_campaign");
//                this.SetRelatedEntity<CrmSdk.Campaign>("userentityinstancedata_campaign", null, value);
//                this.OnPropertyChanged("userentityinstancedata_campaign");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_campaignactivity
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignactivity")]
//        public CrmSdk.CampaignActivity userentityinstancedata_campaignactivity
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CampaignActivity>("userentityinstancedata_campaignactivity", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_campaignactivity");
//                this.SetRelatedEntity<CrmSdk.CampaignActivity>("userentityinstancedata_campaignactivity", null, value);
//                this.OnPropertyChanged("userentityinstancedata_campaignactivity");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_campaignactivityitem
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignactivityitem")]
//        public CrmSdk.CampaignActivityItem userentityinstancedata_campaignactivityitem
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CampaignActivityItem>("userentityinstancedata_campaignactivityitem", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_campaignactivityitem");
//                this.SetRelatedEntity<CrmSdk.CampaignActivityItem>("userentityinstancedata_campaignactivityitem", null, value);
//                this.OnPropertyChanged("userentityinstancedata_campaignactivityitem");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_campaignitem
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignitem")]
//        public CrmSdk.CampaignItem userentityinstancedata_campaignitem
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CampaignItem>("userentityinstancedata_campaignitem", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_campaignitem");
//                this.SetRelatedEntity<CrmSdk.CampaignItem>("userentityinstancedata_campaignitem", null, value);
//                this.OnPropertyChanged("userentityinstancedata_campaignitem");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_campaignresponse
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignresponse")]
//        public CrmSdk.CampaignResponse userentityinstancedata_campaignresponse
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CampaignResponse>("userentityinstancedata_campaignresponse", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_campaignresponse");
//                this.SetRelatedEntity<CrmSdk.CampaignResponse>("userentityinstancedata_campaignresponse", null, value);
//                this.OnPropertyChanged("userentityinstancedata_campaignresponse");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_columnmapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_columnmapping")]
//        public CrmSdk.ColumnMapping userentityinstancedata_columnmapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ColumnMapping>("userentityinstancedata_columnmapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_columnmapping");
//                this.SetRelatedEntity<CrmSdk.ColumnMapping>("userentityinstancedata_columnmapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_columnmapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_competitor
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitor")]
//        public CrmSdk.Competitor userentityinstancedata_competitor
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Competitor>("userentityinstancedata_competitor", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_competitor");
//                this.SetRelatedEntity<CrmSdk.Competitor>("userentityinstancedata_competitor", null, value);
//                this.OnPropertyChanged("userentityinstancedata_competitor");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_competitorproduct
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitorproduct")]
//        public CrmSdk.CompetitorProduct userentityinstancedata_competitorproduct
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CompetitorProduct>("userentityinstancedata_competitorproduct", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_competitorproduct");
//                this.SetRelatedEntity<CrmSdk.CompetitorProduct>("userentityinstancedata_competitorproduct", null, value);
//                this.OnPropertyChanged("userentityinstancedata_competitorproduct");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_competitorsalesliterature
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitorsalesliterature")]
//        public CrmSdk.CompetitorSalesLiterature userentityinstancedata_competitorsalesliterature
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CompetitorSalesLiterature>("userentityinstancedata_competitorsalesliterature", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_competitorsalesliterature");
//                this.SetRelatedEntity<CrmSdk.CompetitorSalesLiterature>("userentityinstancedata_competitorsalesliterature", null, value);
//                this.OnPropertyChanged("userentityinstancedata_competitorsalesliterature");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_connection
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connection")]
//        public CrmSdk.Connection userentityinstancedata_connection
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Connection>("userentityinstancedata_connection", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_connection");
//                this.SetRelatedEntity<CrmSdk.Connection>("userentityinstancedata_connection", null, value);
//                this.OnPropertyChanged("userentityinstancedata_connection");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_connectionrole
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionrole")]
//        public CrmSdk.ConnectionRole userentityinstancedata_connectionrole
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ConnectionRole>("userentityinstancedata_connectionrole", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_connectionrole");
//                this.SetRelatedEntity<CrmSdk.ConnectionRole>("userentityinstancedata_connectionrole", null, value);
//                this.OnPropertyChanged("userentityinstancedata_connectionrole");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_connectionroleassociation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionroleassociation")]
//        public CrmSdk.ConnectionRoleAssociation userentityinstancedata_connectionroleassociation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ConnectionRoleAssociation>("userentityinstancedata_connectionroleassociation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_connectionroleassociation");
//                this.SetRelatedEntity<CrmSdk.ConnectionRoleAssociation>("userentityinstancedata_connectionroleassociation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_connectionroleassociation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_connectionroleobjecttypecode
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionroleobjecttypecode")]
//        public CrmSdk.ConnectionRoleObjectTypeCode userentityinstancedata_connectionroleobjecttypecode
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ConnectionRoleObjectTypeCode>("userentityinstancedata_connectionroleobjecttypecode", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_connectionroleobjecttypecode");
//                this.SetRelatedEntity<CrmSdk.ConnectionRoleObjectTypeCode>("userentityinstancedata_connectionroleobjecttypecode", null, value);
//                this.OnPropertyChanged("userentityinstancedata_connectionroleobjecttypecode");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_constraintbasedgroup
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_constraintbasedgroup")]
//        public CrmSdk.ConstraintBasedGroup userentityinstancedata_constraintbasedgroup
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ConstraintBasedGroup>("userentityinstancedata_constraintbasedgroup", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_constraintbasedgroup");
//                this.SetRelatedEntity<CrmSdk.ConstraintBasedGroup>("userentityinstancedata_constraintbasedgroup", null, value);
//                this.OnPropertyChanged("userentityinstancedata_constraintbasedgroup");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_contact
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contact")]
//        public CrmSdk.Contact userentityinstancedata_contact
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Contact>("userentityinstancedata_contact", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_contact");
//                this.SetRelatedEntity<CrmSdk.Contact>("userentityinstancedata_contact", null, value);
//                this.OnPropertyChanged("userentityinstancedata_contact");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_contract
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contract")]
//        public CrmSdk.Contract userentityinstancedata_contract
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Contract>("userentityinstancedata_contract", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_contract");
//                this.SetRelatedEntity<CrmSdk.Contract>("userentityinstancedata_contract", null, value);
//                this.OnPropertyChanged("userentityinstancedata_contract");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_contractdetail
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contractdetail")]
//        public CrmSdk.ContractDetail userentityinstancedata_contractdetail
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ContractDetail>("userentityinstancedata_contractdetail", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_contractdetail");
//                this.SetRelatedEntity<CrmSdk.ContractDetail>("userentityinstancedata_contractdetail", null, value);
//                this.OnPropertyChanged("userentityinstancedata_contractdetail");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_contracttemplate
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contracttemplate")]
//        public CrmSdk.ContractTemplate userentityinstancedata_contracttemplate
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ContractTemplate>("userentityinstancedata_contracttemplate", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_contracttemplate");
//                this.SetRelatedEntity<CrmSdk.ContractTemplate>("userentityinstancedata_contracttemplate", null, value);
//                this.OnPropertyChanged("userentityinstancedata_contracttemplate");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_customeraddress
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customeraddress")]
//        public CrmSdk.CustomerAddress userentityinstancedata_customeraddress
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CustomerAddress>("userentityinstancedata_customeraddress", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_customeraddress");
//                this.SetRelatedEntity<CrmSdk.CustomerAddress>("userentityinstancedata_customeraddress", null, value);
//                this.OnPropertyChanged("userentityinstancedata_customeraddress");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_customeropportunityrole
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customeropportunityrole")]
//        public CrmSdk.CustomerOpportunityRole userentityinstancedata_customeropportunityrole
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CustomerOpportunityRole>("userentityinstancedata_customeropportunityrole", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_customeropportunityrole");
//                this.SetRelatedEntity<CrmSdk.CustomerOpportunityRole>("userentityinstancedata_customeropportunityrole", null, value);
//                this.OnPropertyChanged("userentityinstancedata_customeropportunityrole");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_customerrelationship
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customerrelationship")]
//        public CrmSdk.CustomerRelationship userentityinstancedata_customerrelationship
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.CustomerRelationship>("userentityinstancedata_customerrelationship", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_customerrelationship");
//                this.SetRelatedEntity<CrmSdk.CustomerRelationship>("userentityinstancedata_customerrelationship", null, value);
//                this.OnPropertyChanged("userentityinstancedata_customerrelationship");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_dependency
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_dependency")]
//        public CrmSdk.Dependency userentityinstancedata_dependency
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Dependency>("userentityinstancedata_dependency", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_dependency");
//                this.SetRelatedEntity<CrmSdk.Dependency>("userentityinstancedata_dependency", null, value);
//                this.OnPropertyChanged("userentityinstancedata_dependency");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_discount
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_discount")]
//        public CrmSdk.Discount userentityinstancedata_discount
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Discount>("userentityinstancedata_discount", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_discount");
//                this.SetRelatedEntity<CrmSdk.Discount>("userentityinstancedata_discount", null, value);
//                this.OnPropertyChanged("userentityinstancedata_discount");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_discounttype
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_discounttype")]
//        public CrmSdk.DiscountType userentityinstancedata_discounttype
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.DiscountType>("userentityinstancedata_discounttype", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_discounttype");
//                this.SetRelatedEntity<CrmSdk.DiscountType>("userentityinstancedata_discounttype", null, value);
//                this.OnPropertyChanged("userentityinstancedata_discounttype");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_displaystring
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_displaystring")]
//        public CrmSdk.DisplayString userentityinstancedata_displaystring
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.DisplayString>("userentityinstancedata_displaystring", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_displaystring");
//                this.SetRelatedEntity<CrmSdk.DisplayString>("userentityinstancedata_displaystring", null, value);
//                this.OnPropertyChanged("userentityinstancedata_displaystring");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_duplicaterecord
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterecord")]
//        public CrmSdk.DuplicateRecord userentityinstancedata_duplicaterecord
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.DuplicateRecord>("userentityinstancedata_duplicaterecord", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_duplicaterecord");
//                this.SetRelatedEntity<CrmSdk.DuplicateRecord>("userentityinstancedata_duplicaterecord", null, value);
//                this.OnPropertyChanged("userentityinstancedata_duplicaterecord");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_duplicaterule
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterule")]
//        public CrmSdk.DuplicateRule userentityinstancedata_duplicaterule
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.DuplicateRule>("userentityinstancedata_duplicaterule", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_duplicaterule");
//                this.SetRelatedEntity<CrmSdk.DuplicateRule>("userentityinstancedata_duplicaterule", null, value);
//                this.OnPropertyChanged("userentityinstancedata_duplicaterule");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_duplicaterulecondition
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterulecondition")]
//        public CrmSdk.DuplicateRuleCondition userentityinstancedata_duplicaterulecondition
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.DuplicateRuleCondition>("userentityinstancedata_duplicaterulecondition", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_duplicaterulecondition");
//                this.SetRelatedEntity<CrmSdk.DuplicateRuleCondition>("userentityinstancedata_duplicaterulecondition", null, value);
//                this.OnPropertyChanged("userentityinstancedata_duplicaterulecondition");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_email
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_email")]
//        public CrmSdk.Email userentityinstancedata_email
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Email>("userentityinstancedata_email", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_email");
//                this.SetRelatedEntity<CrmSdk.Email>("userentityinstancedata_email", null, value);
//                this.OnPropertyChanged("userentityinstancedata_email");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_entitymap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_entitymap")]
//        public CrmSdk.EntityMap userentityinstancedata_entitymap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.EntityMap>("userentityinstancedata_entitymap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_entitymap");
//                this.SetRelatedEntity<CrmSdk.EntityMap>("userentityinstancedata_entitymap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_entitymap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_equipment
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_equipment")]
//        public CrmSdk.Equipment userentityinstancedata_equipment
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Equipment>("userentityinstancedata_equipment", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_equipment");
//                this.SetRelatedEntity<CrmSdk.Equipment>("userentityinstancedata_equipment", null, value);
//                this.OnPropertyChanged("userentityinstancedata_equipment");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_fax
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fax")]
//        public CrmSdk.Fax userentityinstancedata_fax
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Fax>("userentityinstancedata_fax", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_fax");
//                this.SetRelatedEntity<CrmSdk.Fax>("userentityinstancedata_fax", null, value);
//                this.OnPropertyChanged("userentityinstancedata_fax");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_fieldpermission
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fieldpermission")]
//        public CrmSdk.FieldPermission userentityinstancedata_fieldpermission
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.FieldPermission>("userentityinstancedata_fieldpermission", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_fieldpermission");
//                this.SetRelatedEntity<CrmSdk.FieldPermission>("userentityinstancedata_fieldpermission", null, value);
//                this.OnPropertyChanged("userentityinstancedata_fieldpermission");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_fieldsecurityprofile
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fieldsecurityprofile")]
//        public CrmSdk.FieldSecurityProfile userentityinstancedata_fieldsecurityprofile
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.FieldSecurityProfile>("userentityinstancedata_fieldsecurityprofile", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_fieldsecurityprofile");
//                this.SetRelatedEntity<CrmSdk.FieldSecurityProfile>("userentityinstancedata_fieldsecurityprofile", null, value);
//                this.OnPropertyChanged("userentityinstancedata_fieldsecurityprofile");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_goal
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_goal")]
//        public CrmSdk.Goal userentityinstancedata_goal
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Goal>("userentityinstancedata_goal", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_goal");
//                this.SetRelatedEntity<CrmSdk.Goal>("userentityinstancedata_goal", null, value);
//                this.OnPropertyChanged("userentityinstancedata_goal");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_goalrollupquery
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_goalrollupquery")]
//        public CrmSdk.GoalRollupQuery userentityinstancedata_goalrollupquery
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.GoalRollupQuery>("userentityinstancedata_goalrollupquery", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_goalrollupquery");
//                this.SetRelatedEntity<CrmSdk.GoalRollupQuery>("userentityinstancedata_goalrollupquery", null, value);
//                this.OnPropertyChanged("userentityinstancedata_goalrollupquery");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_import
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_import")]
//        public CrmSdk.Import userentityinstancedata_import
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Import>("userentityinstancedata_import", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_import");
//                this.SetRelatedEntity<CrmSdk.Import>("userentityinstancedata_import", null, value);
//                this.OnPropertyChanged("userentityinstancedata_import");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_importentitymapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importentitymapping")]
//        public CrmSdk.ImportEntityMapping userentityinstancedata_importentitymapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ImportEntityMapping>("userentityinstancedata_importentitymapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_importentitymapping");
//                this.SetRelatedEntity<CrmSdk.ImportEntityMapping>("userentityinstancedata_importentitymapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_importentitymapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_importfile
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importfile")]
//        public CrmSdk.ImportFile userentityinstancedata_importfile
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ImportFile>("userentityinstancedata_importfile", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_importfile");
//                this.SetRelatedEntity<CrmSdk.ImportFile>("userentityinstancedata_importfile", null, value);
//                this.OnPropertyChanged("userentityinstancedata_importfile");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_importjob
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importjob")]
//        public CrmSdk.ImportJob userentityinstancedata_importjob
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ImportJob>("userentityinstancedata_importjob", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_importjob");
//                this.SetRelatedEntity<CrmSdk.ImportJob>("userentityinstancedata_importjob", null, value);
//                this.OnPropertyChanged("userentityinstancedata_importjob");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_importlog
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importlog")]
//        public CrmSdk.ImportLog userentityinstancedata_importlog
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ImportLog>("userentityinstancedata_importlog", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_importlog");
//                this.SetRelatedEntity<CrmSdk.ImportLog>("userentityinstancedata_importlog", null, value);
//                this.OnPropertyChanged("userentityinstancedata_importlog");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_importmap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importmap")]
//        public CrmSdk.ImportMap userentityinstancedata_importmap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ImportMap>("userentityinstancedata_importmap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_importmap");
//                this.SetRelatedEntity<CrmSdk.ImportMap>("userentityinstancedata_importmap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_importmap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_incident
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_incident")]
//        public CrmSdk.Incident userentityinstancedata_incident
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Incident>("userentityinstancedata_incident", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_incident");
//                this.SetRelatedEntity<CrmSdk.Incident>("userentityinstancedata_incident", null, value);
//                this.OnPropertyChanged("userentityinstancedata_incident");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_incidentresolution
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_incidentresolution")]
//        public CrmSdk.IncidentResolution userentityinstancedata_incidentresolution
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.IncidentResolution>("userentityinstancedata_incidentresolution", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_incidentresolution");
//                this.SetRelatedEntity<CrmSdk.IncidentResolution>("userentityinstancedata_incidentresolution", null, value);
//                this.OnPropertyChanged("userentityinstancedata_incidentresolution");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_invaliddependency
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invaliddependency")]
//        public CrmSdk.InvalidDependency userentityinstancedata_invaliddependency
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.InvalidDependency>("userentityinstancedata_invaliddependency", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_invaliddependency");
//                this.SetRelatedEntity<CrmSdk.InvalidDependency>("userentityinstancedata_invaliddependency", null, value);
//                this.OnPropertyChanged("userentityinstancedata_invaliddependency");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_invoice
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invoice")]
//        public CrmSdk.Invoice userentityinstancedata_invoice
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Invoice>("userentityinstancedata_invoice", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_invoice");
//                this.SetRelatedEntity<CrmSdk.Invoice>("userentityinstancedata_invoice", null, value);
//                this.OnPropertyChanged("userentityinstancedata_invoice");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_invoicedetail
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invoicedetail")]
//        public CrmSdk.InvoiceDetail userentityinstancedata_invoicedetail
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.InvoiceDetail>("userentityinstancedata_invoicedetail", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_invoicedetail");
//                this.SetRelatedEntity<CrmSdk.InvoiceDetail>("userentityinstancedata_invoicedetail", null, value);
//                this.OnPropertyChanged("userentityinstancedata_invoicedetail");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_isvconfig
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_isvconfig")]
//        public CrmSdk.IsvConfig userentityinstancedata_isvconfig
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.IsvConfig>("userentityinstancedata_isvconfig", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_isvconfig");
//                this.SetRelatedEntity<CrmSdk.IsvConfig>("userentityinstancedata_isvconfig", null, value);
//                this.OnPropertyChanged("userentityinstancedata_isvconfig");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_kbarticle
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticle")]
//        public CrmSdk.KbArticle userentityinstancedata_kbarticle
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.KbArticle>("userentityinstancedata_kbarticle", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_kbarticle");
//                this.SetRelatedEntity<CrmSdk.KbArticle>("userentityinstancedata_kbarticle", null, value);
//                this.OnPropertyChanged("userentityinstancedata_kbarticle");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_kbarticlecomment
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticlecomment")]
//        public CrmSdk.KbArticleComment userentityinstancedata_kbarticlecomment
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.KbArticleComment>("userentityinstancedata_kbarticlecomment", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_kbarticlecomment");
//                this.SetRelatedEntity<CrmSdk.KbArticleComment>("userentityinstancedata_kbarticlecomment", null, value);
//                this.OnPropertyChanged("userentityinstancedata_kbarticlecomment");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_kbarticletemplate
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticletemplate")]
//        public CrmSdk.KbArticleTemplate userentityinstancedata_kbarticletemplate
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.KbArticleTemplate>("userentityinstancedata_kbarticletemplate", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_kbarticletemplate");
//                this.SetRelatedEntity<CrmSdk.KbArticleTemplate>("userentityinstancedata_kbarticletemplate", null, value);
//                this.OnPropertyChanged("userentityinstancedata_kbarticletemplate");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_lead
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_lead")]
//        public CrmSdk.Lead userentityinstancedata_lead
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Lead>("userentityinstancedata_lead", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_lead");
//                this.SetRelatedEntity<CrmSdk.Lead>("userentityinstancedata_lead", null, value);
//                this.OnPropertyChanged("userentityinstancedata_lead");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_leadaddress
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_leadaddress")]
//        public CrmSdk.LeadAddress userentityinstancedata_leadaddress
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.LeadAddress>("userentityinstancedata_leadaddress", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_leadaddress");
//                this.SetRelatedEntity<CrmSdk.LeadAddress>("userentityinstancedata_leadaddress", null, value);
//                this.OnPropertyChanged("userentityinstancedata_leadaddress");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_leadproduct
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_leadproduct")]
//        public CrmSdk.LeadProduct userentityinstancedata_leadproduct
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.LeadProduct>("userentityinstancedata_leadproduct", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_leadproduct");
//                this.SetRelatedEntity<CrmSdk.LeadProduct>("userentityinstancedata_leadproduct", null, value);
//                this.OnPropertyChanged("userentityinstancedata_leadproduct");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_letter
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_letter")]
//        public CrmSdk.Letter userentityinstancedata_letter
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Letter>("userentityinstancedata_letter", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_letter");
//                this.SetRelatedEntity<CrmSdk.Letter>("userentityinstancedata_letter", null, value);
//                this.OnPropertyChanged("userentityinstancedata_letter");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_license
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_license")]
//        public CrmSdk.License userentityinstancedata_license
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.License>("userentityinstancedata_license", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_license");
//                this.SetRelatedEntity<CrmSdk.License>("userentityinstancedata_license", null, value);
//                this.OnPropertyChanged("userentityinstancedata_license");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_list
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_list")]
//        public CrmSdk.List userentityinstancedata_list
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.List>("userentityinstancedata_list", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_list");
//                this.SetRelatedEntity<CrmSdk.List>("userentityinstancedata_list", null, value);
//                this.OnPropertyChanged("userentityinstancedata_list");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_listmember
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_listmember")]
//        public CrmSdk.ListMember userentityinstancedata_listmember
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ListMember>("userentityinstancedata_listmember", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_listmember");
//                this.SetRelatedEntity<CrmSdk.ListMember>("userentityinstancedata_listmember", null, value);
//                this.OnPropertyChanged("userentityinstancedata_listmember");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_lookupmapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_lookupmapping")]
//        public CrmSdk.LookUpMapping userentityinstancedata_lookupmapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.LookUpMapping>("userentityinstancedata_lookupmapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_lookupmapping");
//                this.SetRelatedEntity<CrmSdk.LookUpMapping>("userentityinstancedata_lookupmapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_lookupmapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_mailmergetemplate
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_mailmergetemplate")]
//        public CrmSdk.MailMergeTemplate userentityinstancedata_mailmergetemplate
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.MailMergeTemplate>("userentityinstancedata_mailmergetemplate", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_mailmergetemplate");
//                this.SetRelatedEntity<CrmSdk.MailMergeTemplate>("userentityinstancedata_mailmergetemplate", null, value);
//                this.OnPropertyChanged("userentityinstancedata_mailmergetemplate");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_metric
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_metric")]
//        public CrmSdk.Metric userentityinstancedata_metric
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Metric>("userentityinstancedata_metric", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_metric");
//                this.SetRelatedEntity<CrmSdk.Metric>("userentityinstancedata_metric", null, value);
//                this.OnPropertyChanged("userentityinstancedata_metric");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_opportunity
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunity")]
//        public CrmSdk.Opportunity userentityinstancedata_opportunity
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Opportunity>("userentityinstancedata_opportunity", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_opportunity");
//                this.SetRelatedEntity<CrmSdk.Opportunity>("userentityinstancedata_opportunity", null, value);
//                this.OnPropertyChanged("userentityinstancedata_opportunity");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_opportunityclose
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunityclose")]
//        public CrmSdk.OpportunityClose userentityinstancedata_opportunityclose
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.OpportunityClose>("userentityinstancedata_opportunityclose", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_opportunityclose");
//                this.SetRelatedEntity<CrmSdk.OpportunityClose>("userentityinstancedata_opportunityclose", null, value);
//                this.OnPropertyChanged("userentityinstancedata_opportunityclose");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_opportunityproduct
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunityproduct")]
//        public CrmSdk.OpportunityProduct userentityinstancedata_opportunityproduct
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.OpportunityProduct>("userentityinstancedata_opportunityproduct", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_opportunityproduct");
//                this.SetRelatedEntity<CrmSdk.OpportunityProduct>("userentityinstancedata_opportunityproduct", null, value);
//                this.OnPropertyChanged("userentityinstancedata_opportunityproduct");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_orderclose
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_orderclose")]
//        public CrmSdk.OrderClose userentityinstancedata_orderclose
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.OrderClose>("userentityinstancedata_orderclose", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_orderclose");
//                this.SetRelatedEntity<CrmSdk.OrderClose>("userentityinstancedata_orderclose", null, value);
//                this.OnPropertyChanged("userentityinstancedata_orderclose");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_organization
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_organization")]
//        public CrmSdk.Organization userentityinstancedata_organization
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Organization>("userentityinstancedata_organization", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_organization");
//                this.SetRelatedEntity<CrmSdk.Organization>("userentityinstancedata_organization", null, value);
//                this.OnPropertyChanged("userentityinstancedata_organization");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_ownermapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_ownermapping")]
//        public CrmSdk.OwnerMapping userentityinstancedata_ownermapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.OwnerMapping>("userentityinstancedata_ownermapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_ownermapping");
//                this.SetRelatedEntity<CrmSdk.OwnerMapping>("userentityinstancedata_ownermapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_ownermapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_owning_user
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_owning_user")]
//        public CrmSdk.SystemUser userentityinstancedata_owning_user
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SystemUser>("userentityinstancedata_owning_user", null);
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_phonecall
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_phonecall")]
//        public CrmSdk.PhoneCall userentityinstancedata_phonecall
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PhoneCall>("userentityinstancedata_phonecall", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_phonecall");
//                this.SetRelatedEntity<CrmSdk.PhoneCall>("userentityinstancedata_phonecall", null, value);
//                this.OnPropertyChanged("userentityinstancedata_phonecall");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_picklistmapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_picklistmapping")]
//        public CrmSdk.PickListMapping userentityinstancedata_picklistmapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PickListMapping>("userentityinstancedata_picklistmapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_picklistmapping");
//                this.SetRelatedEntity<CrmSdk.PickListMapping>("userentityinstancedata_picklistmapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_picklistmapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_pluginassembly
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_pluginassembly")]
//        public CrmSdk.PluginAssembly userentityinstancedata_pluginassembly
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PluginAssembly>("userentityinstancedata_pluginassembly", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_pluginassembly");
//                this.SetRelatedEntity<CrmSdk.PluginAssembly>("userentityinstancedata_pluginassembly", null, value);
//                this.OnPropertyChanged("userentityinstancedata_pluginassembly");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_plugintype
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_plugintype")]
//        public CrmSdk.PluginType userentityinstancedata_plugintype
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PluginType>("userentityinstancedata_plugintype", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_plugintype");
//                this.SetRelatedEntity<CrmSdk.PluginType>("userentityinstancedata_plugintype", null, value);
//                this.OnPropertyChanged("userentityinstancedata_plugintype");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_plugintypestatistic
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_plugintypestatistic")]
//        public CrmSdk.PluginTypeStatistic userentityinstancedata_plugintypestatistic
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PluginTypeStatistic>("userentityinstancedata_plugintypestatistic", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_plugintypestatistic");
//                this.SetRelatedEntity<CrmSdk.PluginTypeStatistic>("userentityinstancedata_plugintypestatistic", null, value);
//                this.OnPropertyChanged("userentityinstancedata_plugintypestatistic");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_pricelevel
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_pricelevel")]
//        public CrmSdk.PriceLevel userentityinstancedata_pricelevel
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PriceLevel>("userentityinstancedata_pricelevel", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_pricelevel");
//                this.SetRelatedEntity<CrmSdk.PriceLevel>("userentityinstancedata_pricelevel", null, value);
//                this.OnPropertyChanged("userentityinstancedata_pricelevel");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_principalentitymap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_principalentitymap")]
//        public CrmSdk.PrincipalEntityMap userentityinstancedata_principalentitymap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PrincipalEntityMap>("userentityinstancedata_principalentitymap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_principalentitymap");
//                this.SetRelatedEntity<CrmSdk.PrincipalEntityMap>("userentityinstancedata_principalentitymap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_principalentitymap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_principalobjectattributeaccess
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_principalobjectattributeaccess")]
//        public CrmSdk.PrincipalObjectAttributeAccess userentityinstancedata_principalobjectattributeaccess
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PrincipalObjectAttributeAccess>("userentityinstancedata_principalobjectattributeaccess", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_principalobjectattributeaccess");
//                this.SetRelatedEntity<CrmSdk.PrincipalObjectAttributeAccess>("userentityinstancedata_principalobjectattributeaccess", null, value);
//                this.OnPropertyChanged("userentityinstancedata_principalobjectattributeaccess");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_privilege
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_privilege")]
//        public CrmSdk.Privilege userentityinstancedata_privilege
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Privilege>("userentityinstancedata_privilege", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_privilege");
//                this.SetRelatedEntity<CrmSdk.Privilege>("userentityinstancedata_privilege", null, value);
//                this.OnPropertyChanged("userentityinstancedata_privilege");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_processsession
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_processsession")]
//        public CrmSdk.ProcessSession userentityinstancedata_processsession
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ProcessSession>("userentityinstancedata_processsession", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_processsession");
//                this.SetRelatedEntity<CrmSdk.ProcessSession>("userentityinstancedata_processsession", null, value);
//                this.OnPropertyChanged("userentityinstancedata_processsession");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_product
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_product")]
//        public CrmSdk.Product userentityinstancedata_product
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Product>("userentityinstancedata_product", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_product");
//                this.SetRelatedEntity<CrmSdk.Product>("userentityinstancedata_product", null, value);
//                this.OnPropertyChanged("userentityinstancedata_product");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_productassociation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productassociation")]
//        public CrmSdk.ProductAssociation userentityinstancedata_productassociation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ProductAssociation>("userentityinstancedata_productassociation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_productassociation");
//                this.SetRelatedEntity<CrmSdk.ProductAssociation>("userentityinstancedata_productassociation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_productassociation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_productpricelevel
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productpricelevel")]
//        public CrmSdk.ProductPriceLevel userentityinstancedata_productpricelevel
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ProductPriceLevel>("userentityinstancedata_productpricelevel", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_productpricelevel");
//                this.SetRelatedEntity<CrmSdk.ProductPriceLevel>("userentityinstancedata_productpricelevel", null, value);
//                this.OnPropertyChanged("userentityinstancedata_productpricelevel");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_productsalesliterature
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productsalesliterature")]
//        public CrmSdk.ProductSalesLiterature userentityinstancedata_productsalesliterature
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ProductSalesLiterature>("userentityinstancedata_productsalesliterature", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_productsalesliterature");
//                this.SetRelatedEntity<CrmSdk.ProductSalesLiterature>("userentityinstancedata_productsalesliterature", null, value);
//                this.OnPropertyChanged("userentityinstancedata_productsalesliterature");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_productsubstitute
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productsubstitute")]
//        public CrmSdk.ProductSubstitute userentityinstancedata_productsubstitute
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ProductSubstitute>("userentityinstancedata_productsubstitute", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_productsubstitute");
//                this.SetRelatedEntity<CrmSdk.ProductSubstitute>("userentityinstancedata_productsubstitute", null, value);
//                this.OnPropertyChanged("userentityinstancedata_productsubstitute");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_publisher
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_publisher")]
//        public CrmSdk.Publisher userentityinstancedata_publisher
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Publisher>("userentityinstancedata_publisher", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_publisher");
//                this.SetRelatedEntity<CrmSdk.Publisher>("userentityinstancedata_publisher", null, value);
//                this.OnPropertyChanged("userentityinstancedata_publisher");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_publisheraddress
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_publisheraddress")]
//        public CrmSdk.PublisherAddress userentityinstancedata_publisheraddress
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.PublisherAddress>("userentityinstancedata_publisheraddress", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_publisheraddress");
//                this.SetRelatedEntity<CrmSdk.PublisherAddress>("userentityinstancedata_publisheraddress", null, value);
//                this.OnPropertyChanged("userentityinstancedata_publisheraddress");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_queue
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_queue")]
//        public CrmSdk.Queue userentityinstancedata_queue
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Queue>("userentityinstancedata_queue", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_queue");
//                this.SetRelatedEntity<CrmSdk.Queue>("userentityinstancedata_queue", null, value);
//                this.OnPropertyChanged("userentityinstancedata_queue");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_queueitem
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_queueitem")]
//        public CrmSdk.QueueItem userentityinstancedata_queueitem
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.QueueItem>("userentityinstancedata_queueitem", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_queueitem");
//                this.SetRelatedEntity<CrmSdk.QueueItem>("userentityinstancedata_queueitem", null, value);
//                this.OnPropertyChanged("userentityinstancedata_queueitem");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_quote
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_quote")]
//        public CrmSdk.Quote userentityinstancedata_quote
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Quote>("userentityinstancedata_quote", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_quote");
//                this.SetRelatedEntity<CrmSdk.Quote>("userentityinstancedata_quote", null, value);
//                this.OnPropertyChanged("userentityinstancedata_quote");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_quoteclose
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_quoteclose")]
//        public CrmSdk.QuoteClose userentityinstancedata_quoteclose
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.QuoteClose>("userentityinstancedata_quoteclose", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_quoteclose");
//                this.SetRelatedEntity<CrmSdk.QuoteClose>("userentityinstancedata_quoteclose", null, value);
//                this.OnPropertyChanged("userentityinstancedata_quoteclose");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_quotedetail
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_quotedetail")]
//        public CrmSdk.QuoteDetail userentityinstancedata_quotedetail
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.QuoteDetail>("userentityinstancedata_quotedetail", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_quotedetail");
//                this.SetRelatedEntity<CrmSdk.QuoteDetail>("userentityinstancedata_quotedetail", null, value);
//                this.OnPropertyChanged("userentityinstancedata_quotedetail");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_recurringappointmentmaster
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_recurringappointmentmaster")]
//        public CrmSdk.RecurringAppointmentMaster userentityinstancedata_recurringappointmentmaster
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.RecurringAppointmentMaster>("userentityinstancedata_recurringappointmentmaster", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_recurringappointmentmaster");
//                this.SetRelatedEntity<CrmSdk.RecurringAppointmentMaster>("userentityinstancedata_recurringappointmentmaster", null, value);
//                this.OnPropertyChanged("userentityinstancedata_recurringappointmentmaster");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_relationshiprole
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_relationshiprole")]
//        public CrmSdk.RelationshipRole userentityinstancedata_relationshiprole
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.RelationshipRole>("userentityinstancedata_relationshiprole", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_relationshiprole");
//                this.SetRelatedEntity<CrmSdk.RelationshipRole>("userentityinstancedata_relationshiprole", null, value);
//                this.OnPropertyChanged("userentityinstancedata_relationshiprole");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_relationshiprolemap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_relationshiprolemap")]
//        public CrmSdk.RelationshipRoleMap userentityinstancedata_relationshiprolemap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.RelationshipRoleMap>("userentityinstancedata_relationshiprolemap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_relationshiprolemap");
//                this.SetRelatedEntity<CrmSdk.RelationshipRoleMap>("userentityinstancedata_relationshiprolemap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_relationshiprolemap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_report
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_report")]
//        public CrmSdk.Report userentityinstancedata_report
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Report>("userentityinstancedata_report", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_report");
//                this.SetRelatedEntity<CrmSdk.Report>("userentityinstancedata_report", null, value);
//                this.OnPropertyChanged("userentityinstancedata_report");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_reportcategory
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportcategory")]
//        public CrmSdk.ReportCategory userentityinstancedata_reportcategory
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ReportCategory>("userentityinstancedata_reportcategory", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_reportcategory");
//                this.SetRelatedEntity<CrmSdk.ReportCategory>("userentityinstancedata_reportcategory", null, value);
//                this.OnPropertyChanged("userentityinstancedata_reportcategory");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_reportentity
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportentity")]
//        public CrmSdk.ReportEntity userentityinstancedata_reportentity
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ReportEntity>("userentityinstancedata_reportentity", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_reportentity");
//                this.SetRelatedEntity<CrmSdk.ReportEntity>("userentityinstancedata_reportentity", null, value);
//                this.OnPropertyChanged("userentityinstancedata_reportentity");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_reportlink
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportlink")]
//        public CrmSdk.ReportLink userentityinstancedata_reportlink
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ReportLink>("userentityinstancedata_reportlink", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_reportlink");
//                this.SetRelatedEntity<CrmSdk.ReportLink>("userentityinstancedata_reportlink", null, value);
//                this.OnPropertyChanged("userentityinstancedata_reportlink");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_reportvisibility
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportvisibility")]
//        public CrmSdk.ReportVisibility userentityinstancedata_reportvisibility
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ReportVisibility>("userentityinstancedata_reportvisibility", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_reportvisibility");
//                this.SetRelatedEntity<CrmSdk.ReportVisibility>("userentityinstancedata_reportvisibility", null, value);
//                this.OnPropertyChanged("userentityinstancedata_reportvisibility");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_resource
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resource")]
//        public CrmSdk.Resource userentityinstancedata_resource
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Resource>("userentityinstancedata_resource", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_resource");
//                this.SetRelatedEntity<CrmSdk.Resource>("userentityinstancedata_resource", null, value);
//                this.OnPropertyChanged("userentityinstancedata_resource");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_resourcegroup
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resourcegroup")]
//        public CrmSdk.ResourceGroup userentityinstancedata_resourcegroup
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ResourceGroup>("userentityinstancedata_resourcegroup", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_resourcegroup");
//                this.SetRelatedEntity<CrmSdk.ResourceGroup>("userentityinstancedata_resourcegroup", null, value);
//                this.OnPropertyChanged("userentityinstancedata_resourcegroup");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_resourcespec
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resourcespec")]
//        public CrmSdk.ResourceSpec userentityinstancedata_resourcespec
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ResourceSpec>("userentityinstancedata_resourcespec", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_resourcespec");
//                this.SetRelatedEntity<CrmSdk.ResourceSpec>("userentityinstancedata_resourcespec", null, value);
//                this.OnPropertyChanged("userentityinstancedata_resourcespec");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_ribboncustomization
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_ribboncustomization")]
//        public CrmSdk.RibbonCustomization userentityinstancedata_ribboncustomization
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.RibbonCustomization>("userentityinstancedata_ribboncustomization", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_ribboncustomization");
//                this.SetRelatedEntity<CrmSdk.RibbonCustomization>("userentityinstancedata_ribboncustomization", null, value);
//                this.OnPropertyChanged("userentityinstancedata_ribboncustomization");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_role
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_role")]
//        public CrmSdk.Role userentityinstancedata_role
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Role>("userentityinstancedata_role", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_role");
//                this.SetRelatedEntity<CrmSdk.Role>("userentityinstancedata_role", null, value);
//                this.OnPropertyChanged("userentityinstancedata_role");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_rollupfield
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_rollupfield")]
//        public CrmSdk.RollupField userentityinstancedata_rollupfield
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.RollupField>("userentityinstancedata_rollupfield", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_rollupfield");
//                this.SetRelatedEntity<CrmSdk.RollupField>("userentityinstancedata_rollupfield", null, value);
//                this.OnPropertyChanged("userentityinstancedata_rollupfield");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_salesliterature
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesliterature")]
//        public CrmSdk.SalesLiterature userentityinstancedata_salesliterature
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SalesLiterature>("userentityinstancedata_salesliterature", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_salesliterature");
//                this.SetRelatedEntity<CrmSdk.SalesLiterature>("userentityinstancedata_salesliterature", null, value);
//                this.OnPropertyChanged("userentityinstancedata_salesliterature");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_salesliteratureitem
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesliteratureitem")]
//        public CrmSdk.SalesLiteratureItem userentityinstancedata_salesliteratureitem
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SalesLiteratureItem>("userentityinstancedata_salesliteratureitem", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_salesliteratureitem");
//                this.SetRelatedEntity<CrmSdk.SalesLiteratureItem>("userentityinstancedata_salesliteratureitem", null, value);
//                this.OnPropertyChanged("userentityinstancedata_salesliteratureitem");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_salesorder
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesorder")]
//        public CrmSdk.SalesOrder userentityinstancedata_salesorder
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SalesOrder>("userentityinstancedata_salesorder", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_salesorder");
//                this.SetRelatedEntity<CrmSdk.SalesOrder>("userentityinstancedata_salesorder", null, value);
//                this.OnPropertyChanged("userentityinstancedata_salesorder");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_salesorderdetail
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesorderdetail")]
//        public CrmSdk.SalesOrderDetail userentityinstancedata_salesorderdetail
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SalesOrderDetail>("userentityinstancedata_salesorderdetail", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_salesorderdetail");
//                this.SetRelatedEntity<CrmSdk.SalesOrderDetail>("userentityinstancedata_salesorderdetail", null, value);
//                this.OnPropertyChanged("userentityinstancedata_salesorderdetail");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_savedquery
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_savedquery")]
//        public CrmSdk.SavedQuery userentityinstancedata_savedquery
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SavedQuery>("userentityinstancedata_savedquery", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_savedquery");
//                this.SetRelatedEntity<CrmSdk.SavedQuery>("userentityinstancedata_savedquery", null, value);
//                this.OnPropertyChanged("userentityinstancedata_savedquery");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_savedqueryvisualization
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_savedqueryvisualization")]
//        public CrmSdk.SavedQueryVisualization userentityinstancedata_savedqueryvisualization
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SavedQueryVisualization>("userentityinstancedata_savedqueryvisualization", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_savedqueryvisualization");
//                this.SetRelatedEntity<CrmSdk.SavedQueryVisualization>("userentityinstancedata_savedqueryvisualization", null, value);
//                this.OnPropertyChanged("userentityinstancedata_savedqueryvisualization");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessage
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessage")]
//        public CrmSdk.SdkMessage userentityinstancedata_sdkmessage
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessage>("userentityinstancedata_sdkmessage", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessage");
//                this.SetRelatedEntity<CrmSdk.SdkMessage>("userentityinstancedata_sdkmessage", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessage");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessagefilter
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagefilter")]
//        public CrmSdk.SdkMessageFilter userentityinstancedata_sdkmessagefilter
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageFilter>("userentityinstancedata_sdkmessagefilter", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessagefilter");
//                this.SetRelatedEntity<CrmSdk.SdkMessageFilter>("userentityinstancedata_sdkmessagefilter", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessagefilter");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessagepair
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagepair")]
//        public CrmSdk.SdkMessagePair userentityinstancedata_sdkmessagepair
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessagePair>("userentityinstancedata_sdkmessagepair", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessagepair");
//                this.SetRelatedEntity<CrmSdk.SdkMessagePair>("userentityinstancedata_sdkmessagepair", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessagepair");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessageprocessingstep
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageprocessingstep")]
//        public CrmSdk.SdkMessageProcessingStep userentityinstancedata_sdkmessageprocessingstep
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageProcessingStep>("userentityinstancedata_sdkmessageprocessingstep", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstep");
//                this.SetRelatedEntity<CrmSdk.SdkMessageProcessingStep>("userentityinstancedata_sdkmessageprocessingstep", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstep");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessageprocessingstepimage
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageprocessingstepimage")]
//        public CrmSdk.SdkMessageProcessingStepImage userentityinstancedata_sdkmessageprocessingstepimage
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageProcessingStepImage>("userentityinstancedata_sdkmessageprocessingstepimage", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepimage");
//                this.SetRelatedEntity<CrmSdk.SdkMessageProcessingStepImage>("userentityinstancedata_sdkmessageprocessingstepimage", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepimage");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessageprocessingstepsecureconfig
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageprocessingstepsecureconfig")]
//        public CrmSdk.SdkMessageProcessingStepSecureConfig userentityinstancedata_sdkmessageprocessingstepsecureconfig
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageProcessingStepSecureConfig>("userentityinstancedata_sdkmessageprocessingstepsecureconfig", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
//                this.SetRelatedEntity<CrmSdk.SdkMessageProcessingStepSecureConfig>("userentityinstancedata_sdkmessageprocessingstepsecureconfig", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessageprocessingstepsecureconfig");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessagerequest
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagerequest")]
//        public CrmSdk.SdkMessageRequest userentityinstancedata_sdkmessagerequest
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageRequest>("userentityinstancedata_sdkmessagerequest", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessagerequest");
//                this.SetRelatedEntity<CrmSdk.SdkMessageRequest>("userentityinstancedata_sdkmessagerequest", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessagerequest");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessagerequestfield
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagerequestfield")]
//        public CrmSdk.SdkMessageRequestField userentityinstancedata_sdkmessagerequestfield
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageRequestField>("userentityinstancedata_sdkmessagerequestfield", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessagerequestfield");
//                this.SetRelatedEntity<CrmSdk.SdkMessageRequestField>("userentityinstancedata_sdkmessagerequestfield", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessagerequestfield");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessageresponse
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageresponse")]
//        public CrmSdk.SdkMessageResponse userentityinstancedata_sdkmessageresponse
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageResponse>("userentityinstancedata_sdkmessageresponse", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessageresponse");
//                this.SetRelatedEntity<CrmSdk.SdkMessageResponse>("userentityinstancedata_sdkmessageresponse", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessageresponse");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sdkmessageresponsefield
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageresponsefield")]
//        public CrmSdk.SdkMessageResponseField userentityinstancedata_sdkmessageresponsefield
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SdkMessageResponseField>("userentityinstancedata_sdkmessageresponsefield", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sdkmessageresponsefield");
//                this.SetRelatedEntity<CrmSdk.SdkMessageResponseField>("userentityinstancedata_sdkmessageresponsefield", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sdkmessageresponsefield");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_service
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_service")]
//        public CrmSdk.Service userentityinstancedata_service
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Service>("userentityinstancedata_service", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_service");
//                this.SetRelatedEntity<CrmSdk.Service>("userentityinstancedata_service", null, value);
//                this.OnPropertyChanged("userentityinstancedata_service");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_serviceappointment
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_serviceappointment")]
//        public CrmSdk.ServiceAppointment userentityinstancedata_serviceappointment
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ServiceAppointment>("userentityinstancedata_serviceappointment", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_serviceappointment");
//                this.SetRelatedEntity<CrmSdk.ServiceAppointment>("userentityinstancedata_serviceappointment", null, value);
//                this.OnPropertyChanged("userentityinstancedata_serviceappointment");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_serviceendpoint
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_serviceendpoint")]
//        public CrmSdk.ServiceEndpoint userentityinstancedata_serviceendpoint
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.ServiceEndpoint>("userentityinstancedata_serviceendpoint", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_serviceendpoint");
//                this.SetRelatedEntity<CrmSdk.ServiceEndpoint>("userentityinstancedata_serviceendpoint", null, value);
//                this.OnPropertyChanged("userentityinstancedata_serviceendpoint");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sharepointdocumentlocation
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sharepointdocumentlocation")]
//        public CrmSdk.SharePointDocumentLocation userentityinstancedata_sharepointdocumentlocation
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SharePointDocumentLocation>("userentityinstancedata_sharepointdocumentlocation", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sharepointdocumentlocation");
//                this.SetRelatedEntity<CrmSdk.SharePointDocumentLocation>("userentityinstancedata_sharepointdocumentlocation", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sharepointdocumentlocation");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sharepointsite
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sharepointsite")]
//        public CrmSdk.SharePointSite userentityinstancedata_sharepointsite
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SharePointSite>("userentityinstancedata_sharepointsite", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sharepointsite");
//                this.SetRelatedEntity<CrmSdk.SharePointSite>("userentityinstancedata_sharepointsite", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sharepointsite");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_site
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_site")]
//        public CrmSdk.Site userentityinstancedata_site
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Site>("userentityinstancedata_site", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_site");
//                this.SetRelatedEntity<CrmSdk.Site>("userentityinstancedata_site", null, value);
//                this.OnPropertyChanged("userentityinstancedata_site");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_sitemap
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sitemap")]
//        public CrmSdk.SiteMap userentityinstancedata_sitemap
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SiteMap>("userentityinstancedata_sitemap", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_sitemap");
//                this.SetRelatedEntity<CrmSdk.SiteMap>("userentityinstancedata_sitemap", null, value);
//                this.OnPropertyChanged("userentityinstancedata_sitemap");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_solution
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solution")]
//        public CrmSdk.Solution userentityinstancedata_solution
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Solution>("userentityinstancedata_solution", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_solution");
//                this.SetRelatedEntity<CrmSdk.Solution>("userentityinstancedata_solution", null, value);
//                this.OnPropertyChanged("userentityinstancedata_solution");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_solutioncomponent
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solutioncomponent")]
//        public CrmSdk.SolutionComponent userentityinstancedata_solutioncomponent
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SolutionComponent>("userentityinstancedata_solutioncomponent", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_solutioncomponent");
//                this.SetRelatedEntity<CrmSdk.SolutionComponent>("userentityinstancedata_solutioncomponent", null, value);
//                this.OnPropertyChanged("userentityinstancedata_solutioncomponent");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_subject
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subject")]
//        public CrmSdk.Subject userentityinstancedata_subject
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Subject>("userentityinstancedata_subject", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_subject");
//                this.SetRelatedEntity<CrmSdk.Subject>("userentityinstancedata_subject", null, value);
//                this.OnPropertyChanged("userentityinstancedata_subject");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_subscriptionmanuallytrackedobject
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subscriptionmanuallytrackedobject")]
//        public CrmSdk.SubscriptionManuallyTrackedObject userentityinstancedata_subscriptionmanuallytrackedobject
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SubscriptionManuallyTrackedObject>("userentityinstancedata_subscriptionmanuallytrackedobject", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_subscriptionmanuallytrackedobject");
//                this.SetRelatedEntity<CrmSdk.SubscriptionManuallyTrackedObject>("userentityinstancedata_subscriptionmanuallytrackedobject", null, value);
//                this.OnPropertyChanged("userentityinstancedata_subscriptionmanuallytrackedobject");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_systemuser
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_systemuser")]
//        public CrmSdk.SystemUser userentityinstancedata_systemuser
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.SystemUser>("userentityinstancedata_systemuser", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_systemuser");
//                this.SetRelatedEntity<CrmSdk.SystemUser>("userentityinstancedata_systemuser", null, value);
//                this.OnPropertyChanged("userentityinstancedata_systemuser");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_task
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_task")]
//        public CrmSdk.Task userentityinstancedata_task
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Task>("userentityinstancedata_task", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_task");
//                this.SetRelatedEntity<CrmSdk.Task>("userentityinstancedata_task", null, value);
//                this.OnPropertyChanged("userentityinstancedata_task");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_team
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_team")]
//        public CrmSdk.Team userentityinstancedata_team
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Team>("userentityinstancedata_team", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_team");
//                this.SetRelatedEntity<CrmSdk.Team>("userentityinstancedata_team", null, value);
//                this.OnPropertyChanged("userentityinstancedata_team");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_teammembership
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_teammembership")]
//        public CrmSdk.TeamMembership userentityinstancedata_teammembership
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TeamMembership>("userentityinstancedata_teammembership", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_teammembership");
//                this.SetRelatedEntity<CrmSdk.TeamMembership>("userentityinstancedata_teammembership", null, value);
//                this.OnPropertyChanged("userentityinstancedata_teammembership");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_template
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_template")]
//        public CrmSdk.Template userentityinstancedata_template
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Template>("userentityinstancedata_template", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_template");
//                this.SetRelatedEntity<CrmSdk.Template>("userentityinstancedata_template", null, value);
//                this.OnPropertyChanged("userentityinstancedata_template");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_territory
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_territory")]
//        public CrmSdk.Territory userentityinstancedata_territory
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Territory>("userentityinstancedata_territory", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_territory");
//                this.SetRelatedEntity<CrmSdk.Territory>("userentityinstancedata_territory", null, value);
//                this.OnPropertyChanged("userentityinstancedata_territory");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_timezonedefinition
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonedefinition")]
//        public CrmSdk.TimeZoneDefinition userentityinstancedata_timezonedefinition
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TimeZoneDefinition>("userentityinstancedata_timezonedefinition", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_timezonedefinition");
//                this.SetRelatedEntity<CrmSdk.TimeZoneDefinition>("userentityinstancedata_timezonedefinition", null, value);
//                this.OnPropertyChanged("userentityinstancedata_timezonedefinition");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_timezonelocalizedname
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonelocalizedname")]
//        public CrmSdk.TimeZoneLocalizedName userentityinstancedata_timezonelocalizedname
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TimeZoneLocalizedName>("userentityinstancedata_timezonelocalizedname", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_timezonelocalizedname");
//                this.SetRelatedEntity<CrmSdk.TimeZoneLocalizedName>("userentityinstancedata_timezonelocalizedname", null, value);
//                this.OnPropertyChanged("userentityinstancedata_timezonelocalizedname");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_timezonerule
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonerule")]
//        public CrmSdk.TimeZoneRule userentityinstancedata_timezonerule
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TimeZoneRule>("userentityinstancedata_timezonerule", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_timezonerule");
//                this.SetRelatedEntity<CrmSdk.TimeZoneRule>("userentityinstancedata_timezonerule", null, value);
//                this.OnPropertyChanged("userentityinstancedata_timezonerule");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_transactioncurrency
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transactioncurrency")]
//        public CrmSdk.TransactionCurrency userentityinstancedata_transactioncurrency
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TransactionCurrency>("userentityinstancedata_transactioncurrency", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_transactioncurrency");
//                this.SetRelatedEntity<CrmSdk.TransactionCurrency>("userentityinstancedata_transactioncurrency", null, value);
//                this.OnPropertyChanged("userentityinstancedata_transactioncurrency");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_transformationmapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transformationmapping")]
//        public CrmSdk.TransformationMapping userentityinstancedata_transformationmapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TransformationMapping>("userentityinstancedata_transformationmapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_transformationmapping");
//                this.SetRelatedEntity<CrmSdk.TransformationMapping>("userentityinstancedata_transformationmapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_transformationmapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_transformationparametermapping
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transformationparametermapping")]
//        public CrmSdk.TransformationParameterMapping userentityinstancedata_transformationparametermapping
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.TransformationParameterMapping>("userentityinstancedata_transformationparametermapping", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_transformationparametermapping");
//                this.SetRelatedEntity<CrmSdk.TransformationParameterMapping>("userentityinstancedata_transformationparametermapping", null, value);
//                this.OnPropertyChanged("userentityinstancedata_transformationparametermapping");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_uom
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_uom")]
//        public CrmSdk.UoM userentityinstancedata_uom
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UoM>("userentityinstancedata_uom", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_uom");
//                this.SetRelatedEntity<CrmSdk.UoM>("userentityinstancedata_uom", null, value);
//                this.OnPropertyChanged("userentityinstancedata_uom");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_uomschedule
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_uomschedule")]
//        public CrmSdk.UoMSchedule userentityinstancedata_uomschedule
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UoMSchedule>("userentityinstancedata_uomschedule", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_uomschedule");
//                this.SetRelatedEntity<CrmSdk.UoMSchedule>("userentityinstancedata_uomschedule", null, value);
//                this.OnPropertyChanged("userentityinstancedata_uomschedule");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_userentityuisettings
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userentityuisettings")]
//        public CrmSdk.UserEntityUISettings userentityinstancedata_userentityuisettings
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UserEntityUISettings>("userentityinstancedata_userentityuisettings", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_userentityuisettings");
//                this.SetRelatedEntity<CrmSdk.UserEntityUISettings>("userentityinstancedata_userentityuisettings", null, value);
//                this.OnPropertyChanged("userentityinstancedata_userentityuisettings");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_userform
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userform")]
//        public CrmSdk.UserForm userentityinstancedata_userform
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UserForm>("userentityinstancedata_userform", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_userform");
//                this.SetRelatedEntity<CrmSdk.UserForm>("userentityinstancedata_userform", null, value);
//                this.OnPropertyChanged("userentityinstancedata_userform");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_userquery
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userquery")]
//        public CrmSdk.UserQuery userentityinstancedata_userquery
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UserQuery>("userentityinstancedata_userquery", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_userquery");
//                this.SetRelatedEntity<CrmSdk.UserQuery>("userentityinstancedata_userquery", null, value);
//                this.OnPropertyChanged("userentityinstancedata_userquery");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_userqueryvisualization
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userqueryvisualization")]
//        public CrmSdk.UserQueryVisualization userentityinstancedata_userqueryvisualization
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.UserQueryVisualization>("userentityinstancedata_userqueryvisualization", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_userqueryvisualization");
//                this.SetRelatedEntity<CrmSdk.UserQueryVisualization>("userentityinstancedata_userqueryvisualization", null, value);
//                this.OnPropertyChanged("userentityinstancedata_userqueryvisualization");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_webresource
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_webresource")]
//        public CrmSdk.WebResource userentityinstancedata_webresource
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.WebResource>("userentityinstancedata_webresource", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_webresource");
//                this.SetRelatedEntity<CrmSdk.WebResource>("userentityinstancedata_webresource", null, value);
//                this.OnPropertyChanged("userentityinstancedata_webresource");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_workflow
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflow")]
//        public CrmSdk.Workflow userentityinstancedata_workflow
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.Workflow>("userentityinstancedata_workflow", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_workflow");
//                this.SetRelatedEntity<CrmSdk.Workflow>("userentityinstancedata_workflow", null, value);
//                this.OnPropertyChanged("userentityinstancedata_workflow");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_workflowdependency
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflowdependency")]
//        public CrmSdk.WorkflowDependency userentityinstancedata_workflowdependency
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.WorkflowDependency>("userentityinstancedata_workflowdependency", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_workflowdependency");
//                this.SetRelatedEntity<CrmSdk.WorkflowDependency>("userentityinstancedata_workflowdependency", null, value);
//                this.OnPropertyChanged("userentityinstancedata_workflowdependency");
//            }
//        }

//        /// <summary>
//        /// N:1 userentityinstancedata_workflowlog
//        /// </summary>
//        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
//        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflowlog")]
//        public CrmSdk.WorkflowLog userentityinstancedata_workflowlog
//        {
//            get
//            {
//                return this.GetRelatedEntity<CrmSdk.WorkflowLog>("userentityinstancedata_workflowlog", null);
//            }
//            set
//            {
//                this.OnPropertyChanging("userentityinstancedata_workflowlog");
//                this.SetRelatedEntity<CrmSdk.WorkflowLog>("userentityinstancedata_workflowlog", null, value);
//                this.OnPropertyChanged("userentityinstancedata_workflowlog");
//            }
//        }
//    }
//}
