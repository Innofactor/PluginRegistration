namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Top level of the Microsoft Dynamics CRM business hierarchy. The organization can be a specific business, holding company, or corporation.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("organization")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class Organization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Organization() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "organization";

        public const int EntityTypeCode = 1019;

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
        /// Unique identifier of the template to be used for acknowledgement when a user unsubscribes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("acknowledgementtemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference AcknowledgementTemplateId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("acknowledgementtemplateid");
            }
            set
            {
                this.OnPropertyChanging("AcknowledgementTemplateId");
                this.SetAttributeValue("acknowledgementtemplateid", value);
                this.OnPropertyChanged("AcknowledgementTemplateId");
            }
        }

        /// <summary>
        /// Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowaddressbooksyncs")]
        public System.Nullable<bool> AllowAddressBookSyncs
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowaddressbooksyncs");
            }
            set
            {
                this.OnPropertyChanging("AllowAddressBookSyncs");
                this.SetAttributeValue("allowaddressbooksyncs", value);
                this.OnPropertyChanged("AllowAddressBookSyncs");
            }
        }

        /// <summary>
        /// Indicates whether automatic response creation is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautoresponsecreation")]
        public System.Nullable<bool> AllowAutoResponseCreation
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowautoresponsecreation");
            }
            set
            {
                this.OnPropertyChanging("AllowAutoResponseCreation");
                this.SetAttributeValue("allowautoresponsecreation", value);
                this.OnPropertyChanged("AllowAutoResponseCreation");
            }
        }

        /// <summary>
        /// Indicates whether automatic unsubscribe is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautounsubscribe")]
        public System.Nullable<bool> AllowAutoUnsubscribe
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowautounsubscribe");
            }
            set
            {
                this.OnPropertyChanging("AllowAutoUnsubscribe");
                this.SetAttributeValue("allowautounsubscribe", value);
                this.OnPropertyChanged("AllowAutoUnsubscribe");
            }
        }

        /// <summary>
        /// Indicates whether automatic unsubscribe acknowledgement e-mail is allowed to send.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautounsubscribeacknowledgement")]
        public System.Nullable<bool> AllowAutoUnsubscribeAcknowledgement
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowautounsubscribeacknowledgement");
            }
            set
            {
                this.OnPropertyChanging("AllowAutoUnsubscribeAcknowledgement");
                this.SetAttributeValue("allowautounsubscribeacknowledgement", value);
                this.OnPropertyChanged("AllowAutoUnsubscribeAcknowledgement");
            }
        }

        /// <summary>
        /// Indicates whether Outlook Client message bar advertisement is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowclientmessagebarad")]
        public System.Nullable<bool> AllowClientMessageBarAd
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowclientmessagebarad");
            }
            set
            {
                this.OnPropertyChanging("AllowClientMessageBarAd");
                this.SetAttributeValue("allowclientmessagebarad", value);
                this.OnPropertyChanged("AllowClientMessageBarAd");
            }
        }

        /// <summary>
        /// Indicates whether auditing of changes to entity is allowed when no attributes have changed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowentityonlyaudit")]
        public System.Nullable<bool> AllowEntityOnlyAudit
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowentityonlyaudit");
            }
            set
            {
                this.OnPropertyChanging("AllowEntityOnlyAudit");
                this.SetAttributeValue("allowentityonlyaudit", value);
                this.OnPropertyChanged("AllowEntityOnlyAudit");
            }
        }

        /// <summary>
        /// Indicates whether marketing e-mails execution is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowmarketingemailexecution")]
        public System.Nullable<bool> AllowMarketingEmailExecution
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowmarketingemailexecution");
            }
            set
            {
                this.OnPropertyChanging("AllowMarketingEmailExecution");
                this.SetAttributeValue("allowmarketingemailexecution", value);
                this.OnPropertyChanged("AllowMarketingEmailExecution");
            }
        }

        /// <summary>
        /// Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowofflinescheduledsyncs")]
        public System.Nullable<bool> AllowOfflineScheduledSyncs
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowofflinescheduledsyncs");
            }
            set
            {
                this.OnPropertyChanging("AllowOfflineScheduledSyncs");
                this.SetAttributeValue("allowofflinescheduledsyncs", value);
                this.OnPropertyChanged("AllowOfflineScheduledSyncs");
            }
        }

        /// <summary>
        /// Indicates whether scheduled synchronizations to Outlook are allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowoutlookscheduledsyncs")]
        public System.Nullable<bool> AllowOutlookScheduledSyncs
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowoutlookscheduledsyncs");
            }
            set
            {
                this.OnPropertyChanging("AllowOutlookScheduledSyncs");
                this.SetAttributeValue("allowoutlookscheduledsyncs", value);
                this.OnPropertyChanged("AllowOutlookScheduledSyncs");
            }
        }

        /// <summary>
        /// Indicates whether users are allowed to send e-mail to unresolved parties (parties must still have an e-mail address).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowunresolvedpartiesonemailsend")]
        public System.Nullable<bool> AllowUnresolvedPartiesOnEmailSend
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowunresolvedpartiesonemailsend");
            }
            set
            {
                this.OnPropertyChanging("AllowUnresolvedPartiesOnEmailSend");
                this.SetAttributeValue("allowunresolvedpartiesonemailsend", value);
                this.OnPropertyChanged("AllowUnresolvedPartiesOnEmailSend");
            }
        }

        /// <summary>
        /// Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowwebexcelexport")]
        public System.Nullable<bool> AllowWebExcelExport
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("allowwebexcelexport");
            }
            set
            {
                this.OnPropertyChanging("AllowWebExcelExport");
                this.SetAttributeValue("allowwebexcelexport", value);
                this.OnPropertyChanged("AllowWebExcelExport");
            }
        }

        /// <summary>
        /// AM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amdesignator")]
        public string AMDesignator
        {
            get
            {
                return this.GetAttributeValue<string>("amdesignator");
            }
            set
            {
                this.OnPropertyChanging("AMDesignator");
                this.SetAttributeValue("amdesignator", value);
                this.OnPropertyChanged("AMDesignator");
            }
        }

        /// <summary>
        /// Unique identifier of the base currency of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference BaseCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("basecurrencyid");
            }
            set
            {
                this.OnPropertyChanging("BaseCurrencyId");
                this.SetAttributeValue("basecurrencyid", value);
                this.OnPropertyChanged("BaseCurrencyId");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyprecision")]
        public System.Nullable<int> BaseCurrencyPrecision
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("basecurrencyprecision");
            }
        }

        /// <summary>
        /// Symbol used for the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencysymbol")]
        public string BaseCurrencySymbol
        {
            get
            {
                return this.GetAttributeValue<string>("basecurrencysymbol");
            }
        }

        /// <summary>
        /// Prevent upload or download of certain attachment types that are considered dangerous.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("blockedattachments")]
        public string BlockedAttachments
        {
            get
            {
                return this.GetAttributeValue<string>("blockedattachments");
            }
            set
            {
                this.OnPropertyChanging("BlockedAttachments");
                this.SetAttributeValue("blockedattachments", value);
                this.OnPropertyChanged("BlockedAttachments");
            }
        }

        /// <summary>
        /// Prefix used for bulk operation numbering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationprefix")]
        public string BulkOperationPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("bulkoperationprefix");
            }
            set
            {
                this.OnPropertyChanging("BulkOperationPrefix");
                this.SetAttributeValue("bulkoperationprefix", value);
                this.OnPropertyChanged("BulkOperationPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the business closure calendar of organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessclosurecalendarid")]
        public System.Nullable<System.Guid> BusinessClosureCalendarId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("businessclosurecalendarid");
            }
            set
            {
                this.OnPropertyChanging("BusinessClosureCalendarId");
                this.SetAttributeValue("businessclosurecalendarid", value);
                this.OnPropertyChanged("BusinessClosureCalendarId");
            }
        }

        /// <summary>
        /// Calendar type for the system. Set to Gregorian US by default.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendartype")]
        public System.Nullable<int> CalendarType
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("calendartype");
            }
            set
            {
                this.OnPropertyChanging("CalendarType");
                this.SetAttributeValue("calendartype", value);
                this.OnPropertyChanged("CalendarType");
            }
        }

        /// <summary>
        /// Prefix used for campaign numbering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignprefix")]
        public string CampaignPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("campaignprefix");
            }
            set
            {
                this.OnPropertyChanging("CampaignPrefix");
                this.SetAttributeValue("campaignprefix", value);
                this.OnPropertyChanged("CampaignPrefix");
            }
        }

        /// <summary>
        /// Prefix to use for all cases throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caseprefix")]
        public string CasePrefix
        {
            get
            {
                return this.GetAttributeValue<string>("caseprefix");
            }
            set
            {
                this.OnPropertyChanging("CasePrefix");
                this.SetAttributeValue("caseprefix", value);
                this.OnPropertyChanged("CasePrefix");
            }
        }

        /// <summary>
        /// Prefix to use for all contracts throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractprefix")]
        public string ContractPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("contractprefix");
            }
            set
            {
                this.OnPropertyChanging("ContractPrefix");
                this.SetAttributeValue("contractprefix", value);
                this.OnPropertyChanged("ContractPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the organization.
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
        /// Date and time when the organization was created.
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
        /// Unique identifier of the delegate user who created the organization.
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
        /// Number of decimal places that can be used for currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencydecimalprecision")]
        public System.Nullable<int> CurrencyDecimalPrecision
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currencydecimalprecision");
            }
            set
            {
                this.OnPropertyChanging("CurrencyDecimalPrecision");
                this.SetAttributeValue("currencydecimalprecision", value);
                this.OnPropertyChanged("CurrencyDecimalPrecision");
            }
        }

        /// <summary>
        /// Indicates whether to display money fields with currency code or currency symbol.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencydisplayoption")]
        public Microsoft.Xrm.Sdk.OptionSetValue CurrencyDisplayOption
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("currencydisplayoption");
            }
            set
            {
                this.OnPropertyChanging("CurrencyDisplayOption");
                this.SetAttributeValue("currencydisplayoption", value);
                this.OnPropertyChanged("CurrencyDisplayOption");
            }
        }

        /// <summary>
        /// Information about how currency symbols are placed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CurrencyFormatCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("currencyformatcode");
            }
            set
            {
                this.OnPropertyChanging("CurrencyFormatCode");
                this.SetAttributeValue("currencyformatcode", value);
                this.OnPropertyChanged("CurrencyFormatCode");
            }
        }

        /// <summary>
        /// Symbol used for currency throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencysymbol")]
        public string CurrencySymbol
        {
            get
            {
                return this.GetAttributeValue<string>("currencysymbol");
            }
            set
            {
                this.OnPropertyChanging("CurrencySymbol");
                this.SetAttributeValue("currencysymbol", value);
                this.OnPropertyChanged("CurrencySymbol");
            }
        }

        /// <summary>
        /// Current bulk operation number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentbulkoperationnumber")]
        public System.Nullable<int> CurrentBulkOperationNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentbulkoperationnumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentBulkOperationNumber");
                this.SetAttributeValue("currentbulkoperationnumber", value);
                this.OnPropertyChanged("CurrentBulkOperationNumber");
            }
        }

        /// <summary>
        /// Current campaign number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcampaignnumber")]
        public System.Nullable<int> CurrentCampaignNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentcampaignnumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentCampaignNumber");
                this.SetAttributeValue("currentcampaignnumber", value);
                this.OnPropertyChanged("CurrentCampaignNumber");
            }
        }

        /// <summary>
        /// First case number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcasenumber")]
        public System.Nullable<int> CurrentCaseNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentcasenumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentCaseNumber");
                this.SetAttributeValue("currentcasenumber", value);
                this.OnPropertyChanged("CurrentCaseNumber");
            }
        }

        /// <summary>
        /// First contract number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcontractnumber")]
        public System.Nullable<int> CurrentContractNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentcontractnumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentContractNumber");
                this.SetAttributeValue("currentcontractnumber", value);
                this.OnPropertyChanged("CurrentContractNumber");
            }
        }

        /// <summary>
        /// Import sequence to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentimportsequencenumber")]
        public System.Nullable<int> CurrentImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentimportsequencenumber");
            }
        }

        /// <summary>
        /// First invoice number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentinvoicenumber")]
        public System.Nullable<int> CurrentInvoiceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentinvoicenumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentInvoiceNumber");
                this.SetAttributeValue("currentinvoicenumber", value);
                this.OnPropertyChanged("CurrentInvoiceNumber");
            }
        }

        /// <summary>
        /// First article number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentkbnumber")]
        public System.Nullable<int> CurrentKbNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentkbnumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentKbNumber");
                this.SetAttributeValue("currentkbnumber", value);
                this.OnPropertyChanged("CurrentKbNumber");
            }
        }

        /// <summary>
        /// First order number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentordernumber")]
        public System.Nullable<int> CurrentOrderNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentordernumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentOrderNumber");
                this.SetAttributeValue("currentordernumber", value);
                this.OnPropertyChanged("CurrentOrderNumber");
            }
        }

        /// <summary>
        /// First parsed table number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentparsedtablenumber")]
        public System.Nullable<int> CurrentParsedTableNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentparsedtablenumber");
            }
        }

        /// <summary>
        /// First quote number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentquotenumber")]
        public System.Nullable<int> CurrentQuoteNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("currentquotenumber");
            }
            set
            {
                this.OnPropertyChanging("CurrentQuoteNumber");
                this.SetAttributeValue("currentquotenumber", value);
                this.OnPropertyChanged("CurrentQuoteNumber");
            }
        }

        /// <summary>
        /// Information about how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DateFormatCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("dateformatcode");
            }
            set
            {
                this.OnPropertyChanging("DateFormatCode");
                this.SetAttributeValue("dateformatcode", value);
                this.OnPropertyChanged("DateFormatCode");
            }
        }

        /// <summary>
        /// String showing how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateformatstring")]
        public string DateFormatString
        {
            get
            {
                return this.GetAttributeValue<string>("dateformatstring");
            }
            set
            {
                this.OnPropertyChanging("DateFormatString");
                this.SetAttributeValue("dateformatstring", value);
                this.OnPropertyChanged("DateFormatString");
            }
        }

        /// <summary>
        /// Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateseparator")]
        public string DateSeparator
        {
            get
            {
                return this.GetAttributeValue<string>("dateseparator");
            }
            set
            {
                this.OnPropertyChanging("DateSeparator");
                this.SetAttributeValue("dateseparator", value);
                this.OnPropertyChanged("DateSeparator");
            }
        }

        /// <summary>
        /// Symbol used for decimal in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decimalsymbol")]
        public string DecimalSymbol
        {
            get
            {
                return this.GetAttributeValue<string>("decimalsymbol");
            }
            set
            {
                this.OnPropertyChanging("DecimalSymbol");
                this.SetAttributeValue("decimalsymbol", value);
                this.OnPropertyChanged("DecimalSymbol");
            }
        }

        /// <summary>
        /// Type of default recurrence end range date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultrecurrenceendrangetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue DefaultRecurrenceEndRangeType
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("defaultrecurrenceendrangetype");
            }
            set
            {
                this.OnPropertyChanging("DefaultRecurrenceEndRangeType");
                this.SetAttributeValue("defaultrecurrenceendrangetype", value);
                this.OnPropertyChanged("DefaultRecurrenceEndRangeType");
            }
        }

        /// <summary>
        /// Reason for disabling the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get
            {
                return this.GetAttributeValue<string>("disabledreason");
            }
        }

        /// <summary>
        /// Normal polling frequency used for sending e-mail in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsendpollingperiod")]
        public System.Nullable<int> EmailSendPollingPeriod
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("emailsendpollingperiod");
            }
            set
            {
                this.OnPropertyChanging("EmailSendPollingPeriod");
                this.SetAttributeValue("emailsendpollingperiod", value);
                this.OnPropertyChanged("EmailSendPollingPeriod");
            }
        }

        /// <summary>
        /// Enable pricing calculations on a Create call.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablepricingoncreate")]
        public System.Nullable<bool> EnablePricingOnCreate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("enablepricingoncreate");
            }
            set
            {
                this.OnPropertyChanging("EnablePricingOnCreate");
                this.SetAttributeValue("enablepricingoncreate", value);
                this.OnPropertyChanged("EnablePricingOnCreate");
            }
        }

        /// <summary>
        /// Use Smart Matching.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablesmartmatching")]
        public System.Nullable<bool> EnableSmartMatching
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("enablesmartmatching");
            }
            set
            {
                this.OnPropertyChanging("EnableSmartMatching");
                this.SetAttributeValue("enablesmartmatching", value);
                this.OnPropertyChanged("EnableSmartMatching");
            }
        }

        /// <summary>
        /// Maximum number of days before deleting inactive subscriptions.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expiresubscriptionsindays")]
        public System.Nullable<int> ExpireSubscriptionsInDays
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("expiresubscriptionsindays");
            }
            set
            {
                this.OnPropertyChanging("ExpireSubscriptionsInDays");
                this.SetAttributeValue("expiresubscriptionsindays", value);
                this.OnPropertyChanged("ExpireSubscriptionsInDays");
            }
        }

        /// <summary>
        /// Features to be enabled as an XML BLOB.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("featureset")]
        public string FeatureSet
        {
            get
            {
                return this.GetAttributeValue<string>("featureset");
            }
            set
            {
                this.OnPropertyChanging("FeatureSet");
                this.SetAttributeValue("featureset", value);
                this.OnPropertyChanged("FeatureSet");
            }
        }

        /// <summary>
        /// Start date for the fiscal period that is to be used throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalcalendarstart")]
        public System.Nullable<System.DateTime> FiscalCalendarStart
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("fiscalcalendarstart");
            }
            set
            {
                this.OnPropertyChanging("FiscalCalendarStart");
                this.SetAttributeValue("fiscalcalendarstart", value);
                this.OnPropertyChanged("FiscalCalendarStart");
            }
        }

        /// <summary>
        /// Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodformat")]
        public string FiscalPeriodFormat
        {
            get
            {
                return this.GetAttributeValue<string>("fiscalperiodformat");
            }
            set
            {
                this.OnPropertyChanging("FiscalPeriodFormat");
                this.SetAttributeValue("fiscalperiodformat", value);
                this.OnPropertyChanged("FiscalPeriodFormat");
            }
        }

        /// <summary>
        /// Format in which the fiscal period will be displayed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodformatperiod")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalPeriodFormatPeriod
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalperiodformatperiod");
            }
            set
            {
                this.OnPropertyChanging("FiscalPeriodFormatPeriod");
                this.SetAttributeValue("fiscalperiodformatperiod", value);
                this.OnPropertyChanged("FiscalPeriodFormatPeriod");
            }
        }

        /// <summary>
        /// Type of fiscal period used throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
        public System.Nullable<int> FiscalPeriodType
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype");
            }
            set
            {
                this.OnPropertyChanging("FiscalPeriodType");
                this.SetAttributeValue("fiscalperiodtype", value);
                this.OnPropertyChanged("FiscalPeriodType");
            }
        }

        /// <summary>
        /// Information that specifies whether the fiscal settings have been updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalsettingsupdated")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> FiscalSettingsUpdated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("fiscalsettingsupdated");
            }
        }

        /// <summary>
        /// Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyeardisplaycode")]
        public System.Nullable<int> FiscalYearDisplayCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("fiscalyeardisplaycode");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearDisplayCode");
                this.SetAttributeValue("fiscalyeardisplaycode", value);
                this.OnPropertyChanged("FiscalYearDisplayCode");
            }
        }

        /// <summary>
        /// Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformat")]
        public string FiscalYearFormat
        {
            get
            {
                return this.GetAttributeValue<string>("fiscalyearformat");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearFormat");
                this.SetAttributeValue("fiscalyearformat", value);
                this.OnPropertyChanged("FiscalYearFormat");
            }
        }

        /// <summary>
        /// Prefix for the display of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatprefix")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatPrefix
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatprefix");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatPrefix");
                this.SetAttributeValue("fiscalyearformatprefix", value);
                this.OnPropertyChanged("FiscalYearFormatPrefix");
            }
        }

        /// <summary>
        /// Suffix for the display of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatsuffix")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatSuffix
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatsuffix");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatSuffix");
                this.SetAttributeValue("fiscalyearformatsuffix", value);
                this.OnPropertyChanged("FiscalYearFormatSuffix");
            }
        }

        /// <summary>
        /// Format for the year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatyear")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatYear
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatyear");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatYear");
                this.SetAttributeValue("fiscalyearformatyear", value);
                this.OnPropertyChanged("FiscalYearFormatYear");
            }
        }

        /// <summary>
        /// Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearperiodconnect")]
        public string FiscalYearPeriodConnect
        {
            get
            {
                return this.GetAttributeValue<string>("fiscalyearperiodconnect");
            }
            set
            {
                this.OnPropertyChanging("FiscalYearPeriodConnect");
                this.SetAttributeValue("fiscalyearperiodconnect", value);
                this.OnPropertyChanged("FiscalYearPeriodConnect");
            }
        }

        /// <summary>
        /// Order in which names are to be displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullnameconventioncode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FullNameConventionCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fullnameconventioncode");
            }
            set
            {
                this.OnPropertyChanging("FullNameConventionCode");
                this.SetAttributeValue("fullnameconventioncode", value);
                this.OnPropertyChanged("FullNameConventionCode");
            }
        }

        /// <summary>
        /// Specifies the maximum number of months in future for which the recurring activities can be created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("futureexpansionwindow")]
        public System.Nullable<int> FutureExpansionWindow
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("futureexpansionwindow");
            }
            set
            {
                this.OnPropertyChanging("FutureExpansionWindow");
                this.SetAttributeValue("futureexpansionwindow", value);
                this.OnPropertyChanged("FutureExpansionWindow");
            }
        }

        /// <summary>
        /// Indicates whether Get Started content is enabled for this organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("getstartedpanecontentenabled")]
        public System.Nullable<bool> GetStartedPaneContentEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("getstartedpanecontentenabled");
            }
            set
            {
                this.OnPropertyChanging("GetStartedPaneContentEnabled");
                this.SetAttributeValue("getstartedpanecontentenabled", value);
                this.OnPropertyChanged("GetStartedPaneContentEnabled");
            }
        }

        /// <summary>
        /// Number of days after the goal's end date after which the rollup of the goal stops automatically.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupexpirytime")]
        public System.Nullable<int> GoalRollupExpiryTime
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("goalrollupexpirytime");
            }
            set
            {
                this.OnPropertyChanging("GoalRollupExpiryTime");
                this.SetAttributeValue("goalrollupexpirytime", value);
                this.OnPropertyChanged("GoalRollupExpiryTime");
            }
        }

        /// <summary>
        /// Number of hours between automatic rollup jobs .
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupfrequency")]
        public System.Nullable<int> GoalRollupFrequency
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("goalrollupfrequency");
            }
            set
            {
                this.OnPropertyChanging("GoalRollupFrequency");
                this.SetAttributeValue("goalrollupfrequency", value);
                this.OnPropertyChanged("GoalRollupFrequency");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grantaccesstonetworkservice")]
        public System.Nullable<bool> GrantAccessToNetworkService
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("grantaccesstonetworkservice");
            }
            set
            {
                this.OnPropertyChanging("GrantAccessToNetworkService");
                this.SetAttributeValue("grantaccesstonetworkservice", value);
                this.OnPropertyChanged("GrantAccessToNetworkService");
            }
        }

        /// <summary>
        /// Maximum difference allowed between subject keywords count of the e-mail messaged to be correlated
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashdeltasubjectcount")]
        public System.Nullable<int> HashDeltaSubjectCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("hashdeltasubjectcount");
            }
            set
            {
                this.OnPropertyChanging("HashDeltaSubjectCount");
                this.SetAttributeValue("hashdeltasubjectcount", value);
                this.OnPropertyChanged("HashDeltaSubjectCount");
            }
        }

        /// <summary>
        /// Filter Subject Keywords
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashfilterkeywords")]
        public string HashFilterKeywords
        {
            get
            {
                return this.GetAttributeValue<string>("hashfilterkeywords");
            }
            set
            {
                this.OnPropertyChanging("HashFilterKeywords");
                this.SetAttributeValue("hashfilterkeywords", value);
                this.OnPropertyChanged("HashFilterKeywords");
            }
        }

        /// <summary>
        /// Maximum number of subject keywords or recipients used for correlation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashmaxcount")]
        public System.Nullable<int> HashMaxCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("hashmaxcount");
            }
            set
            {
                this.OnPropertyChanging("HashMaxCount");
                this.SetAttributeValue("hashmaxcount", value);
                this.OnPropertyChanged("HashMaxCount");
            }
        }

        /// <summary>
        /// Minimum number of recipients required to match for e-mail messaged to be correlated
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashminaddresscount")]
        public System.Nullable<int> HashMinAddressCount
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("hashminaddresscount");
            }
            set
            {
                this.OnPropertyChanging("HashMinAddressCount");
                this.SetAttributeValue("hashminaddresscount", value);
                this.OnPropertyChanged("HashMinAddressCount");
            }
        }

        /// <summary>
        /// Indicates whether incoming e-mail sent by internal Microsoft Dynamics CRM users or queues should be tracked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreinternalemail")]
        public System.Nullable<bool> IgnoreInternalEmail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ignoreinternalemail");
            }
            set
            {
                this.OnPropertyChanging("IgnoreInternalEmail");
                this.SetAttributeValue("ignoreinternalemail", value);
                this.OnPropertyChanged("IgnoreInternalEmail");
            }
        }

        /// <summary>
        /// Initial version of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialversion")]
        public string InitialVersion
        {
            get
            {
                return this.GetAttributeValue<string>("initialversion");
            }
            set
            {
                this.OnPropertyChanging("InitialVersion");
                this.SetAttributeValue("initialversion", value);
                this.OnPropertyChanged("InitialVersion");
            }
        }

        /// <summary>
        /// Unique identifier of the integration user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("integrationuserid")]
        public System.Nullable<System.Guid> IntegrationUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("integrationuserid");
            }
            set
            {
                this.OnPropertyChanging("IntegrationUserId");
                this.SetAttributeValue("integrationuserid", value);
                this.OnPropertyChanged("IntegrationUserId");
            }
        }

        /// <summary>
        /// Prefix to use for all invoice numbers throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoiceprefix")]
        public string InvoicePrefix
        {
            get
            {
                return this.GetAttributeValue<string>("invoiceprefix");
            }
            set
            {
                this.OnPropertyChanging("InvoicePrefix");
                this.SetAttributeValue("invoiceprefix", value);
                this.OnPropertyChanged("InvoicePrefix");
            }
        }

        /// <summary>
        /// Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu bars is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappmode")]
        public System.Nullable<bool> IsAppMode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isappmode");
            }
            set
            {
                this.OnPropertyChanging("IsAppMode");
                this.SetAttributeValue("isappmode", value);
                this.OnPropertyChanged("IsAppMode");
            }
        }

        /// <summary>
        /// Enable or disable auditing of changes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isauditenabled")]
        public System.Nullable<bool> IsAuditEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isauditenabled");
            }
            set
            {
                this.OnPropertyChanging("IsAuditEnabled");
                this.SetAttributeValue("isauditenabled", value);
                this.OnPropertyChanged("IsAuditEnabled");
            }
        }

        /// <summary>
        /// Information that specifies whether the organization is disabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isdisabled");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabled")]
        public System.Nullable<bool> IsDuplicateDetectionEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabled");
            }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabled");
                this.SetAttributeValue("isduplicatedetectionenabled", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabled");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records during import is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforimport")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForImport
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforimport");
            }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForImport");
                this.SetAttributeValue("isduplicatedetectionenabledforimport", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForImport");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records during offline synchronization is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforofflinesync")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForOfflineSync
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforofflinesync");
            }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForOfflineSync");
                this.SetAttributeValue("isduplicatedetectionenabledforofflinesync", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForOfflineSync");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection during online create or update is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforonlinecreateupdate")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForOnlineCreateUpdate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforonlinecreateupdate");
            }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
                this.SetAttributeValue("isduplicatedetectionenabledforonlinecreateupdate", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
            }
        }

        /// <summary>
        /// Indicates whether the fiscal period is displayed as the month number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfiscalperiodmonthbased")]
        public System.Nullable<bool> IsFiscalPeriodMonthBased
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isfiscalperiodmonthbased");
            }
            set
            {
                this.OnPropertyChanging("IsFiscalPeriodMonthBased");
                this.SetAttributeValue("isfiscalperiodmonthbased", value);
                this.OnPropertyChanged("IsFiscalPeriodMonthBased");
            }
        }

        /// <summary>
        /// Information on whether IM presence is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispresenceenabled")]
        public System.Nullable<bool> IsPresenceEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("ispresenceenabled");
            }
            set
            {
                this.OnPropertyChanging("IsPresenceEnabled");
                this.SetAttributeValue("ispresenceenabled", value);
                this.OnPropertyChanged("IsPresenceEnabled");
            }
        }

        /// <summary>
        /// Enable sales order processing integration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issopintegrationenabled")]
        public System.Nullable<bool> IsSOPIntegrationEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("issopintegrationenabled");
            }
            set
            {
                this.OnPropertyChanging("IsSOPIntegrationEnabled");
                this.SetAttributeValue("issopintegrationenabled", value);
                this.OnPropertyChanged("IsSOPIntegrationEnabled");
            }
        }

        /// <summary>
        /// Enable or disable auditing of user access.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isuseraccessauditenabled")]
        public System.Nullable<bool> IsUserAccessAuditEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isuseraccessauditenabled");
            }
            set
            {
                this.OnPropertyChanging("IsUserAccessAuditEnabled");
                this.SetAttributeValue("isuseraccessauditenabled", value);
                this.OnPropertyChanged("IsUserAccessAuditEnabled");
            }
        }

        /// <summary>
        /// Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu bars is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvintegrationcode")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.OptionSetValue ISVIntegrationCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("isvintegrationcode");
            }
            set
            {
                this.OnPropertyChanging("ISVIntegrationCode");
                this.SetAttributeValue("isvintegrationcode", value);
                this.OnPropertyChanged("ISVIntegrationCode");
            }
        }

        /// <summary>
        /// Prefix to use for all articles in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbprefix")]
        public string KbPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("kbprefix");
            }
            set
            {
                this.OnPropertyChanging("KbPrefix");
                this.SetAttributeValue("kbprefix", value);
                this.OnPropertyChanged("KbPrefix");
            }
        }

        /// <summary>
        /// Preferred language for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("languagecode");
            }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// Unique identifier of the locale of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("localeid")]
        public System.Nullable<int> LocaleId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("localeid");
            }
            set
            {
                this.OnPropertyChanging("LocaleId");
                this.SetAttributeValue("localeid", value);
                this.OnPropertyChanged("LocaleId");
            }
        }

        /// <summary>
        /// Information that specifies how the Long Date format is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longdateformatcode")]
        public System.Nullable<int> LongDateFormatCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("longdateformatcode");
            }
            set
            {
                this.OnPropertyChanging("LongDateFormatCode");
                this.SetAttributeValue("longdateformatcode", value);
                this.OnPropertyChanged("LongDateFormatCode");
            }
        }

        /// <summary>
        /// Maximum number of days an appointment can last.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxappointmentdurationdays")]
        public System.Nullable<int> MaxAppointmentDurationDays
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("maxappointmentdurationdays");
            }
            set
            {
                this.OnPropertyChanging("MaxAppointmentDurationDays");
                this.SetAttributeValue("maxappointmentdurationdays", value);
                this.OnPropertyChanged("MaxAppointmentDurationDays");
            }
        }

        /// <summary>
        /// Maximum tracking number before recycling takes place.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maximumtrackingnumber")]
        public System.Nullable<int> MaximumTrackingNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("maximumtrackingnumber");
            }
            set
            {
                this.OnPropertyChanging("MaximumTrackingNumber");
                this.SetAttributeValue("maximumtrackingnumber", value);
                this.OnPropertyChanged("MaximumTrackingNumber");
            }
        }

        /// <summary>
        /// Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxrecordsforexporttoexcel")]
        public System.Nullable<int> MaxRecordsForExportToExcel
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("maxrecordsforexporttoexcel");
            }
            set
            {
                this.OnPropertyChanging("MaxRecordsForExportToExcel");
                this.SetAttributeValue("maxrecordsforexporttoexcel", value);
                this.OnPropertyChanged("MaxRecordsForExportToExcel");
            }
        }

        /// <summary>
        /// Maximum number of lookup and picklist records that can be selected by user for filtering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxrecordsforlookupfilters")]
        public System.Nullable<int> MaxRecordsForLookupFilters
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("maxrecordsforlookupfilters");
            }
            set
            {
                this.OnPropertyChanging("MaxRecordsForLookupFilters");
                this.SetAttributeValue("maxrecordsforlookupfilters", value);
                this.OnPropertyChanged("MaxRecordsForLookupFilters");
            }
        }

        /// <summary>
        /// Maximum allowed size of an attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxuploadfilesize")]
        public System.Nullable<int> MaxUploadFileSize
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("maxuploadfilesize");
            }
            set
            {
                this.OnPropertyChanging("MaxUploadFileSize");
                this.SetAttributeValue("maxuploadfilesize", value);
                this.OnPropertyChanged("MaxUploadFileSize");
            }
        }

        /// <summary>
        /// Normal polling frequency used for address book synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minaddressbooksyncinterval")]
        public System.Nullable<int> MinAddressBookSyncInterval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("minaddressbooksyncinterval");
            }
            set
            {
                this.OnPropertyChanging("MinAddressBookSyncInterval");
                this.SetAttributeValue("minaddressbooksyncinterval", value);
                this.OnPropertyChanged("MinAddressBookSyncInterval");
            }
        }

        /// <summary>
        /// Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minofflinesyncinterval")]
        public System.Nullable<int> MinOfflineSyncInterval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("minofflinesyncinterval");
            }
            set
            {
                this.OnPropertyChanging("MinOfflineSyncInterval");
                this.SetAttributeValue("minofflinesyncinterval", value);
                this.OnPropertyChanged("MinOfflineSyncInterval");
            }
        }

        /// <summary>
        /// Minimum allowed time between scheduled Outlook synchronizations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minoutlooksyncinterval")]
        public System.Nullable<int> MinOutlookSyncInterval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("minoutlooksyncinterval");
            }
            set
            {
                this.OnPropertyChanging("MinOutlookSyncInterval");
                this.SetAttributeValue("minoutlooksyncinterval", value);
                this.OnPropertyChanged("MinOutlookSyncInterval");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the organization.
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
        /// Date and time when the organization was last modified.
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
        /// Unique identifier of the delegate user who last modified the organization.
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
        /// Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("negativecurrencyformatcode")]
        public System.Nullable<int> NegativeCurrencyFormatCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("negativecurrencyformatcode");
            }
            set
            {
                this.OnPropertyChanging("NegativeCurrencyFormatCode");
                this.SetAttributeValue("negativecurrencyformatcode", value);
                this.OnPropertyChanged("NegativeCurrencyFormatCode");
            }
        }

        /// <summary>
        /// Information that specifies how negative numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("negativeformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue NegativeFormatCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("negativeformatcode");
            }
            set
            {
                this.OnPropertyChanging("NegativeFormatCode");
                this.SetAttributeValue("negativeformatcode", value);
                this.OnPropertyChanged("NegativeFormatCode");
            }
        }

        /// <summary>
        /// Next token to be placed on the subject line of an e-mail message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nexttrackingnumber")]
        public System.Nullable<int> NextTrackingNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("nexttrackingnumber");
            }
            set
            {
                this.OnPropertyChanging("NextTrackingNumber");
                this.SetAttributeValue("nexttrackingnumber", value);
                this.OnPropertyChanged("NextTrackingNumber");
            }
        }

        /// <summary>
        /// Specification of how numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberformat")]
        public string NumberFormat
        {
            get
            {
                return this.GetAttributeValue<string>("numberformat");
            }
            set
            {
                this.OnPropertyChanging("NumberFormat");
                this.SetAttributeValue("numberformat", value);
                this.OnPropertyChanged("NumberFormat");
            }
        }

        /// <summary>
        /// Specifies how numbers are grouped in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numbergroupformat")]
        public string NumberGroupFormat
        {
            get
            {
                return this.GetAttributeValue<string>("numbergroupformat");
            }
            set
            {
                this.OnPropertyChanging("NumberGroupFormat");
                this.SetAttributeValue("numbergroupformat", value);
                this.OnPropertyChanged("NumberGroupFormat");
            }
        }

        /// <summary>
        /// Symbol used for number separation in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberseparator")]
        public string NumberSeparator
        {
            get
            {
                return this.GetAttributeValue<string>("numberseparator");
            }
            set
            {
                this.OnPropertyChanging("NumberSeparator");
                this.SetAttributeValue("numberseparator", value);
                this.OnPropertyChanged("NumberSeparator");
            }
        }

        /// <summary>
        /// Prefix to use for all orders throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orderprefix")]
        public string OrderPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("orderprefix");
            }
            set
            {
                this.OnPropertyChanging("OrderPrefix");
                this.SetAttributeValue("orderprefix", value);
                this.OnPropertyChanged("OrderPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
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
        /// Organization settings stored in Organization Database.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orgdborgsettings")]
        public string OrgDbOrgSettings
        {
            get
            {
                return this.GetAttributeValue<string>("orgdborgsettings");
            }
            set
            {
                this.OnPropertyChanging("OrgDbOrgSettings");
                this.SetAttributeValue("orgdborgsettings", value);
                this.OnPropertyChanged("OrgDbOrgSettings");
            }
        }

        /// <summary>
        /// Prefix used for parsed table columns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("parsedtablecolumnprefix");
            }
        }

        /// <summary>
        /// Prefix used for parsed tables.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtableprefix")]
        public string ParsedTablePrefix
        {
            get
            {
                return this.GetAttributeValue<string>("parsedtableprefix");
            }
        }

        /// <summary>
        /// Specifies the maximum number of months in past for which the recurring activities can be created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pastexpansionwindow")]
        public System.Nullable<int> PastExpansionWindow
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("pastexpansionwindow");
            }
            set
            {
                this.OnPropertyChanging("PastExpansionWindow");
                this.SetAttributeValue("pastexpansionwindow", value);
                this.OnPropertyChanged("PastExpansionWindow");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picture")]
        public string Picture
        {
            get
            {
                return this.GetAttributeValue<string>("picture");
            }
            set
            {
                this.OnPropertyChanging("Picture");
                this.SetAttributeValue("picture", value);
                this.OnPropertyChanged("Picture");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointlanguagecode")]
        public System.Nullable<int> PinpointLanguageCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("pinpointlanguagecode");
            }
            set
            {
                this.OnPropertyChanging("PinpointLanguageCode");
                this.SetAttributeValue("pinpointlanguagecode", value);
                this.OnPropertyChanged("PinpointLanguageCode");
            }
        }

        /// <summary>
        /// PM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pmdesignator")]
        public string PMDesignator
        {
            get
            {
                return this.GetAttributeValue<string>("pmdesignator");
            }
            set
            {
                this.OnPropertyChanging("PMDesignator");
                this.SetAttributeValue("pmdesignator", value);
                this.OnPropertyChanged("PMDesignator");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for prices.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingdecimalprecision")]
        public System.Nullable<int> PricingDecimalPrecision
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("pricingdecimalprecision");
            }
            set
            {
                this.OnPropertyChanging("PricingDecimalPrecision");
                this.SetAttributeValue("pricingdecimalprecision", value);
                this.OnPropertyChanged("PricingDecimalPrecision");
            }
        }

        /// <summary>
        /// Unique identifier of the default privilege for users in the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeusergroupid")]
        public System.Nullable<System.Guid> PrivilegeUserGroupId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegeusergroupid");
            }
            set
            {
                this.OnPropertyChanging("PrivilegeUserGroupId");
                this.SetAttributeValue("privilegeusergroupid", value);
                this.OnPropertyChanged("PrivilegeUserGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privreportinggroupid")]
        public System.Nullable<System.Guid> PrivReportingGroupId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("privreportinggroupid");
            }
            set
            {
                this.OnPropertyChanging("PrivReportingGroupId");
                this.SetAttributeValue("privreportinggroupid", value);
                this.OnPropertyChanged("PrivReportingGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privreportinggroupname")]
        public string PrivReportingGroupName
        {
            get
            {
                return this.GetAttributeValue<string>("privreportinggroupname");
            }
            set
            {
                this.OnPropertyChanging("PrivReportingGroupName");
                this.SetAttributeValue("privreportinggroupname", value);
                this.OnPropertyChanged("PrivReportingGroupName");
            }
        }

        /// <summary>
        /// Prefix to use for all quotes throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteprefix")]
        public string QuotePrefix
        {
            get
            {
                return this.GetAttributeValue<string>("quoteprefix");
            }
            set
            {
                this.OnPropertyChanging("QuotePrefix");
                this.SetAttributeValue("quoteprefix", value);
                this.OnPropertyChanged("QuotePrefix");
            }
        }

        /// <summary>
        /// Specifies the default value for number of occurrences field in the recurrence dialog.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencedefaultnumberofoccurrences")]
        public System.Nullable<int> RecurrenceDefaultNumberOfOccurrences
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("recurrencedefaultnumberofoccurrences");
            }
            set
            {
                this.OnPropertyChanging("RecurrenceDefaultNumberOfOccurrences");
                this.SetAttributeValue("recurrencedefaultnumberofoccurrences", value);
                this.OnPropertyChanged("RecurrenceDefaultNumberOfOccurrences");
            }
        }

        /// <summary>
        /// Specifies the interval (in seconds) for pausing expansion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionjobbatchinterval")]
        public System.Nullable<int> RecurrenceExpansionJobBatchInterval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionjobbatchinterval");
            }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionJobBatchInterval");
                this.SetAttributeValue("recurrenceexpansionjobbatchinterval", value);
                this.OnPropertyChanged("RecurrenceExpansionJobBatchInterval");
            }
        }

        /// <summary>
        /// Specifies the value for number of instances created in on demand job in one shot.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionjobbatchsize")]
        public System.Nullable<int> RecurrenceExpansionJobBatchSize
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionjobbatchsize");
            }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionJobBatchSize");
                this.SetAttributeValue("recurrenceexpansionjobbatchsize", value);
                this.OnPropertyChanged("RecurrenceExpansionJobBatchSize");
            }
        }

        /// <summary>
        /// Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionsynchcreatemax")]
        public System.Nullable<int> RecurrenceExpansionSynchCreateMax
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionsynchcreatemax");
            }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionSynchCreateMax");
                this.SetAttributeValue("recurrenceexpansionsynchcreatemax", value);
                this.OnPropertyChanged("RecurrenceExpansionSynchCreateMax");
            }
        }

        /// <summary>
        /// XML string that defines the navigation structure for the application. This is the site map from the previously upgraded build and is used in a 3-way merge during upgrade.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencesitemapxml")]
        [System.ObsoleteAttribute()]
        public string ReferenceSiteMapXml
        {
            get
            {
                return this.GetAttributeValue<string>("referencesitemapxml");
            }
            set
            {
                this.OnPropertyChanging("ReferenceSiteMapXml");
                this.SetAttributeValue("referencesitemapxml", value);
                this.OnPropertyChanged("ReferenceSiteMapXml");
            }
        }

        /// <summary>
        /// Flag to render the body of e-mail in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rendersecureiframeforemail")]
        public System.Nullable<bool> RenderSecureIFrameForEmail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("rendersecureiframeforemail");
            }
            set
            {
                this.OnPropertyChanging("RenderSecureIFrameForEmail");
                this.SetAttributeValue("rendersecureiframeforemail", value);
                this.OnPropertyChanged("RenderSecureIFrameForEmail");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportinggroupid")]
        public System.Nullable<System.Guid> ReportingGroupId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("reportinggroupid");
            }
            set
            {
                this.OnPropertyChanging("ReportingGroupId");
                this.SetAttributeValue("reportinggroupid", value);
                this.OnPropertyChanged("ReportingGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportinggroupname")]
        public string ReportingGroupName
        {
            get
            {
                return this.GetAttributeValue<string>("reportinggroupname");
            }
            set
            {
                this.OnPropertyChanging("ReportingGroupName");
                this.SetAttributeValue("reportinggroupname", value);
                this.OnPropertyChanged("ReportingGroupName");
            }
        }

        /// <summary>
        /// Picklist for selecting the organization preference for reporting scripting errors.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportscripterrors")]
        public Microsoft.Xrm.Sdk.OptionSetValue ReportScriptErrors
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("reportscripterrors");
            }
            set
            {
                this.OnPropertyChanging("ReportScriptErrors");
                this.SetAttributeValue("reportscripterrors", value);
                this.OnPropertyChanged("ReportScriptErrors");
            }
        }

        /// <summary>
        /// Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requireapprovalforqueueemail")]
        public System.Nullable<bool> RequireApprovalForQueueEmail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("requireapprovalforqueueemail");
            }
            set
            {
                this.OnPropertyChanging("RequireApprovalForQueueEmail");
                this.SetAttributeValue("requireapprovalforqueueemail", value);
                this.OnPropertyChanged("RequireApprovalForQueueEmail");
            }
        }

        /// <summary>
        /// Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requireapprovalforuseremail")]
        public System.Nullable<bool> RequireApprovalForUserEmail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("requireapprovalforuseremail");
            }
            set
            {
                this.OnPropertyChanging("RequireApprovalForUserEmail");
                this.SetAttributeValue("requireapprovalforuseremail", value);
                this.OnPropertyChanged("RequireApprovalForUserEmail");
            }
        }

        /// <summary>
        /// Unique identifier of the sample data import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sampledataimportid")]
        public System.Nullable<System.Guid> SampleDataImportId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sampledataimportid");
            }
            set
            {
                this.OnPropertyChanging("SampleDataImportId");
                this.SetAttributeValue("sampledataimportid", value);
                this.OnPropertyChanged("SampleDataImportId");
            }
        }

        /// <summary>
        /// Prefix used for custom entities and attributes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schemanameprefix")]
        public string SchemaNamePrefix
        {
            get
            {
                return this.GetAttributeValue<string>("schemanameprefix");
            }
            set
            {
                this.OnPropertyChanging("SchemaNamePrefix");
                this.SetAttributeValue("schemanameprefix", value);
                this.OnPropertyChanged("SchemaNamePrefix");
            }
        }

        /// <summary>
        /// Information that specifies whether to share to previous owner on assign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharetopreviousowneronassign")]
        public System.Nullable<bool> ShareToPreviousOwnerOnAssign
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("sharetopreviousowneronassign");
            }
            set
            {
                this.OnPropertyChanging("ShareToPreviousOwnerOnAssign");
                this.SetAttributeValue("sharetopreviousowneronassign", value);
                this.OnPropertyChanged("ShareToPreviousOwnerOnAssign");
            }
        }

        /// <summary>
        /// Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showweeknumber")]
        public System.Nullable<bool> ShowWeekNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("showweeknumber");
            }
            set
            {
                this.OnPropertyChanging("ShowWeekNumber");
                this.SetAttributeValue("showweeknumber", value);
                this.OnPropertyChanged("ShowWeekNumber");
            }
        }

        /// <summary>
        /// XML string that defines the navigation structure for the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapxml")]
        [System.ObsoleteAttribute()]
        public string SiteMapXml
        {
            get
            {
                return this.GetAttributeValue<string>("sitemapxml");
            }
            set
            {
                this.OnPropertyChanging("SiteMapXml");
                this.SetAttributeValue("sitemapxml", value);
                this.OnPropertyChanged("SiteMapXml");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortid")]
        public System.Nullable<int> SortId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("sortid");
            }
            set
            {
                this.OnPropertyChanging("SortId");
                this.SetAttributeValue("sortid", value);
                this.OnPropertyChanged("SortId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqlaccessgroupid")]
        public System.Nullable<System.Guid> SqlAccessGroupId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("sqlaccessgroupid");
            }
            set
            {
                this.OnPropertyChanging("SqlAccessGroupId");
                this.SetAttributeValue("sqlaccessgroupid", value);
                this.OnPropertyChanged("SqlAccessGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqlaccessgroupname")]
        public string SqlAccessGroupName
        {
            get
            {
                return this.GetAttributeValue<string>("sqlaccessgroupname");
            }
            set
            {
                this.OnPropertyChanging("SqlAccessGroupName");
                this.SetAttributeValue("sqlaccessgroupname", value);
                this.OnPropertyChanged("SqlAccessGroupName");
            }
        }

        /// <summary>
        /// Setting for SQM data collection, 0 no, 1 yes enabled
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqmenabled")]
        public System.Nullable<bool> SQMEnabled
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("sqmenabled");
            }
            set
            {
                this.OnPropertyChanging("SQMEnabled");
                this.SetAttributeValue("sqmenabled", value);
                this.OnPropertyChanged("SQMEnabled");
            }
        }

        /// <summary>
        /// Unique identifier of the support user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportuserid")]
        public System.Nullable<System.Guid> SupportUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("supportuserid");
            }
            set
            {
                this.OnPropertyChanging("SupportUserId");
                this.SetAttributeValue("supportuserid", value);
                this.OnPropertyChanged("SupportUserId");
            }
        }

        /// <summary>
        /// Unique identifier of the system user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
            }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                this.OnPropertyChanged("SystemUserId");
            }
        }

        /// <summary>
        /// Maximum number of aggressive polling cycles executed for e-mail auto-tagging when a new e-mail is received.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tagmaxaggressivecycles")]
        public System.Nullable<int> TagMaxAggressiveCycles
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("tagmaxaggressivecycles");
            }
            set
            {
                this.OnPropertyChanging("TagMaxAggressiveCycles");
                this.SetAttributeValue("tagmaxaggressivecycles", value);
                this.OnPropertyChanged("TagMaxAggressiveCycles");
            }
        }

        /// <summary>
        /// Normal polling frequency used for e-mail receive auto-tagging in outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tagpollingperiod")]
        public System.Nullable<int> TagPollingPeriod
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("tagpollingperiod");
            }
            set
            {
                this.OnPropertyChanging("TagPollingPeriod");
                this.SetAttributeValue("tagpollingperiod", value);
                this.OnPropertyChanged("TagPollingPeriod");
            }
        }

        /// <summary>
        /// Information that specifies how the time is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TimeFormatCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeformatcode");
            }
            set
            {
                this.OnPropertyChanging("TimeFormatCode");
                this.SetAttributeValue("timeformatcode", value);
                this.OnPropertyChanged("TimeFormatCode");
            }
        }

        /// <summary>
        /// Text for how time is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeformatstring")]
        public string TimeFormatString
        {
            get
            {
                return this.GetAttributeValue<string>("timeformatstring");
            }
            set
            {
                this.OnPropertyChanging("TimeFormatString");
                this.SetAttributeValue("timeformatstring", value);
                this.OnPropertyChanged("TimeFormatString");
            }
        }

        /// <summary>
        /// Text for how the time separator is displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeseparator")]
        public string TimeSeparator
        {
            get
            {
                return this.GetAttributeValue<string>("timeseparator");
            }
            set
            {
                this.OnPropertyChanging("TimeSeparator");
                this.SetAttributeValue("timeseparator", value);
                this.OnPropertyChanged("TimeSeparator");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Duration used for token expiration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tokenexpiry")]
        public System.Nullable<int> TokenExpiry
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("tokenexpiry");
            }
            set
            {
                this.OnPropertyChanging("TokenExpiry");
                this.SetAttributeValue("tokenexpiry", value);
                this.OnPropertyChanged("TokenExpiry");
            }
        }

        /// <summary>
        /// Token key.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tokenkey")]
        public string TokenKey
        {
            get
            {
                return this.GetAttributeValue<string>("tokenkey");
            }
            set
            {
                this.OnPropertyChanging("TokenKey");
                this.SetAttributeValue("tokenkey", value);
                this.OnPropertyChanged("TokenKey");
            }
        }

        /// <summary>
        /// History list of tracking token prefixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingprefix")]
        public string TrackingPrefix
        {
            get
            {
                return this.GetAttributeValue<string>("trackingprefix");
            }
            set
            {
                this.OnPropertyChanging("TrackingPrefix");
                this.SetAttributeValue("trackingprefix", value);
                this.OnPropertyChanged("TrackingPrefix");
            }
        }

        /// <summary>
        /// Base number used to provide separate tracking token identifiers to users belonging to different deployments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtokenidbase")]
        public System.Nullable<int> TrackingTokenIdBase
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("trackingtokenidbase");
            }
            set
            {
                this.OnPropertyChanging("TrackingTokenIdBase");
                this.SetAttributeValue("trackingtokenidbase", value);
                this.OnPropertyChanged("TrackingTokenIdBase");
            }
        }

        /// <summary>
        /// Number of digits used to represent a tracking token identifier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtokeniddigits")]
        public System.Nullable<int> TrackingTokenIdDigits
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("trackingtokeniddigits");
            }
            set
            {
                this.OnPropertyChanging("TrackingTokenIdDigits");
                this.SetAttributeValue("trackingtokeniddigits", value);
                this.OnPropertyChanged("TrackingTokenIdDigits");
            }
        }

        /// <summary>
        /// Number of characters appended to invoice, quote, and order numbers.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquespecifierlength")]
        public System.Nullable<int> UniqueSpecifierLength
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("uniquespecifierlength");
            }
            set
            {
                this.OnPropertyChanging("UniqueSpecifierLength");
                this.SetAttributeValue("uniquespecifierlength", value);
                this.OnPropertyChanged("UniqueSpecifierLength");
            }
        }

        /// <summary>
        /// The interval at which user access is checked for auditing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useraccessauditinginterval")]
        public System.Nullable<int> UserAccessAuditingInterval
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("useraccessauditinginterval");
            }
            set
            {
                this.OnPropertyChanging("UserAccessAuditingInterval");
                this.SetAttributeValue("useraccessauditinginterval", value);
                this.OnPropertyChanged("UserAccessAuditingInterval");
            }
        }

        /// <summary>
        /// Unique identifier of the default group of users in the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usergroupid")]
        public System.Nullable<System.Guid> UserGroupId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("usergroupid");
            }
            set
            {
                this.OnPropertyChanging("UserGroupId");
                this.SetAttributeValue("usergroupid", value);
                this.OnPropertyChanged("UserGroupId");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Hash of the V3 callout configuration file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("v3calloutconfighash")]
        public string V3CalloutConfigHash
        {
            get
            {
                return this.GetAttributeValue<string>("v3calloutconfighash");
            }
        }

        /// <summary>
        /// Version number of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// Designated first day of the week throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("weekstartdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue WeekStartDayCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("weekstartdaycode");
            }
            set
            {
                this.OnPropertyChanging("WeekStartDayCode");
                this.SetAttributeValue("weekstartdaycode", value);
                this.OnPropertyChanged("WeekStartDayCode");
            }
        }

        /// <summary>
        /// Information that specifies how the first week of the year is specified in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yearstartweekcode")]
        public System.Nullable<int> YearStartWeekCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("yearstartweekcode");
            }
            set
            {
                this.OnPropertyChanging("YearStartWeekCode");
                this.SetAttributeValue("yearstartweekcode", value);
                this.OnPropertyChanged("YearStartWeekCode");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_organizationid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> lk_fieldsecurityprofile_organizationid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_organizationid");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_organizationid");
            }
        }

        /// <summary>
        /// 1:N lk_principalobjectattributeaccess_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_principalobjectattributeaccess_organizationid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PrincipalObjectAttributeAccess> lk_principalobjectattributeaccess_organizationid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("lk_principalobjectattributeaccess_organizationid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_principalobjectattributeaccess_organizationid");
                this.SetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("lk_principalobjectattributeaccess_organizationid", null, value);
                this.OnPropertyChanged("lk_principalobjectattributeaccess_organizationid");
            }
        }

        /// <summary>
        /// 1:N Organization_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> Organization_AsyncOperations
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("Organization_AsyncOperations", null);
            }
            set
            {
                this.OnPropertyChanging("Organization_AsyncOperations");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("Organization_AsyncOperations", null, value);
                this.OnPropertyChanged("Organization_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N organization_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_attributemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AttributeMap> organization_attributemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AttributeMap>("organization_attributemap", null);
            }
            set
            {
                this.OnPropertyChanging("organization_attributemap");
                this.SetRelatedEntities<CrmSdk.AttributeMap>("organization_attributemap", null, value);
                this.OnPropertyChanged("organization_attributemap");
            }
        }

        /// <summary>
        /// 1:N Organization_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteFailure> Organization_BulkDeleteFailures
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteFailure>("Organization_BulkDeleteFailures", null);
            }
            set
            {
                this.OnPropertyChanging("Organization_BulkDeleteFailures");
                this.SetRelatedEntities<CrmSdk.BulkDeleteFailure>("Organization_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Organization_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N organization_business_unit_news_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_unit_news_articles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnitNewsArticle> organization_business_unit_news_articles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("organization_business_unit_news_articles", null);
            }
            set
            {
                this.OnPropertyChanging("organization_business_unit_news_articles");
                this.SetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("organization_business_unit_news_articles", null, value);
                this.OnPropertyChanged("organization_business_unit_news_articles");
            }
        }

        /// <summary>
        /// 1:N organization_business_units
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_units")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnit> organization_business_units
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnit>("organization_business_units", null);
            }
            set
            {
                this.OnPropertyChanging("organization_business_units");
                this.SetRelatedEntities<CrmSdk.BusinessUnit>("organization_business_units", null, value);
                this.OnPropertyChanged("organization_business_units");
            }
        }

        /// <summary>
        /// 1:N organization_calendars
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_calendars")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Calendar> organization_calendars
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Calendar>("organization_calendars", null);
            }
            set
            {
                this.OnPropertyChanging("organization_calendars");
                this.SetRelatedEntities<CrmSdk.Calendar>("organization_calendars", null, value);
                this.OnPropertyChanged("organization_calendars");
            }
        }

        /// <summary>
        /// 1:N organization_competitors
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_competitors")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Competitor> organization_competitors
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Competitor>("organization_competitors", null);
            }
            set
            {
                this.OnPropertyChanging("organization_competitors");
                this.SetRelatedEntities<CrmSdk.Competitor>("organization_competitors", null, value);
                this.OnPropertyChanged("organization_competitors");
            }
        }

        /// <summary>
        /// 1:N organization_connection_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_connection_roles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConnectionRole> organization_connection_roles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConnectionRole>("organization_connection_roles", null);
            }
            set
            {
                this.OnPropertyChanging("organization_connection_roles");
                this.SetRelatedEntities<CrmSdk.ConnectionRole>("organization_connection_roles", null, value);
                this.OnPropertyChanged("organization_connection_roles");
            }
        }

        /// <summary>
        /// 1:N organization_constraint_based_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_constraint_based_groups")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> organization_constraint_based_groups
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("organization_constraint_based_groups", null);
            }
            set
            {
                this.OnPropertyChanging("organization_constraint_based_groups");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("organization_constraint_based_groups", null, value);
                this.OnPropertyChanged("organization_constraint_based_groups");
            }
        }

        /// <summary>
        /// 1:N organization_contract_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_contract_templates")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractTemplate> organization_contract_templates
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractTemplate>("organization_contract_templates", null);
            }
            set
            {
                this.OnPropertyChanging("organization_contract_templates");
                this.SetRelatedEntities<CrmSdk.ContractTemplate>("organization_contract_templates", null, value);
                this.OnPropertyChanged("organization_contract_templates");
            }
        }

        /// <summary>
        /// 1:N organization_custom_displaystrings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_custom_displaystrings")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DisplayString> organization_custom_displaystrings
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DisplayString>("organization_custom_displaystrings", null);
            }
            set
            {
                this.OnPropertyChanging("organization_custom_displaystrings");
                this.SetRelatedEntities<CrmSdk.DisplayString>("organization_custom_displaystrings", null, value);
                this.OnPropertyChanged("organization_custom_displaystrings");
            }
        }

        /// <summary>
        /// 1:N organization_discount_types
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_discount_types")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DiscountType> organization_discount_types
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DiscountType>("organization_discount_types", null);
            }
            set
            {
                this.OnPropertyChanging("organization_discount_types");
                this.SetRelatedEntities<CrmSdk.DiscountType>("organization_discount_types", null, value);
                this.OnPropertyChanged("organization_discount_types");
            }
        }

        /// <summary>
        /// 1:N organization_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_entitymap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.EntityMap> organization_entitymap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.EntityMap>("organization_entitymap", null);
            }
            set
            {
                this.OnPropertyChanging("organization_entitymap");
                this.SetRelatedEntities<CrmSdk.EntityMap>("organization_entitymap", null, value);
                this.OnPropertyChanged("organization_entitymap");
            }
        }

        /// <summary>
        /// 1:N organization_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_equipment")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> organization_equipment
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("organization_equipment", null);
            }
            set
            {
                this.OnPropertyChanging("organization_equipment");
                this.SetRelatedEntities<CrmSdk.Equipment>("organization_equipment", null, value);
                this.OnPropertyChanged("organization_equipment");
            }
        }

        /// <summary>
        /// 1:N organization_importjob
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_importjob")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportJob> organization_importjob
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportJob>("organization_importjob", null);
            }
            set
            {
                this.OnPropertyChanging("organization_importjob");
                this.SetRelatedEntities<CrmSdk.ImportJob>("organization_importjob", null, value);
                this.OnPropertyChanged("organization_importjob");
            }
        }

        /// <summary>
        /// 1:N organization_isvconfigs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_isvconfigs")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IsvConfig> organization_isvconfigs
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IsvConfig>("organization_isvconfigs", null);
            }
            set
            {
                this.OnPropertyChanging("organization_isvconfigs");
                this.SetRelatedEntities<CrmSdk.IsvConfig>("organization_isvconfigs", null, value);
                this.OnPropertyChanged("organization_isvconfigs");
            }
        }

        /// <summary>
        /// 1:N organization_kb_article_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_article_templates")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleTemplate> organization_kb_article_templates
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleTemplate>("organization_kb_article_templates", null);
            }
            set
            {
                this.OnPropertyChanging("organization_kb_article_templates");
                this.SetRelatedEntities<CrmSdk.KbArticleTemplate>("organization_kb_article_templates", null, value);
                this.OnPropertyChanged("organization_kb_article_templates");
            }
        }

        /// <summary>
        /// 1:N organization_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_articles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticle> organization_kb_articles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticle>("organization_kb_articles", null);
            }
            set
            {
                this.OnPropertyChanging("organization_kb_articles");
                this.SetRelatedEntities<CrmSdk.KbArticle>("organization_kb_articles", null, value);
                this.OnPropertyChanged("organization_kb_articles");
            }
        }

        /// <summary>
        /// 1:N organization_licenses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_licenses")]
        public System.Collections.Generic.IEnumerable<CrmSdk.License> organization_licenses
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.License>("organization_licenses", null);
            }
            set
            {
                this.OnPropertyChanging("organization_licenses");
                this.SetRelatedEntities<CrmSdk.License>("organization_licenses", null, value);
                this.OnPropertyChanged("organization_licenses");
            }
        }

        /// <summary>
        /// 1:N organization_metric
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_metric")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Metric> organization_metric
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Metric>("organization_metric", null);
            }
            set
            {
                this.OnPropertyChanging("organization_metric");
                this.SetRelatedEntities<CrmSdk.Metric>("organization_metric", null, value);
                this.OnPropertyChanged("organization_metric");
            }
        }

        /// <summary>
        /// 1:N organization_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_pluginassembly")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginAssembly> organization_pluginassembly
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginAssembly>("organization_pluginassembly", null);
            }
            set
            {
                this.OnPropertyChanging("organization_pluginassembly");
                this.SetRelatedEntities<CrmSdk.PluginAssembly>("organization_pluginassembly", null, value);
                this.OnPropertyChanged("organization_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N organization_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintype")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> organization_plugintype
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("organization_plugintype", null);
            }
            set
            {
                this.OnPropertyChanging("organization_plugintype");
                this.SetRelatedEntities<CrmSdk.PluginType>("organization_plugintype", null, value);
                this.OnPropertyChanged("organization_plugintype");
            }
        }

        /// <summary>
        /// 1:N organization_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginTypeStatistic> organization_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginTypeStatistic>("organization_plugintypestatistic", null);
            }
            set
            {
                this.OnPropertyChanging("organization_plugintypestatistic");
                this.SetRelatedEntities<CrmSdk.PluginTypeStatistic>("organization_plugintypestatistic", null, value);
                this.OnPropertyChanged("organization_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N organization_post
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_post")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Post> organization_post
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Post>("organization_post", null);
            }
            set
            {
                this.OnPropertyChanging("organization_post");
                this.SetRelatedEntities<CrmSdk.Post>("organization_post", null, value);
                this.OnPropertyChanged("organization_post");
            }
        }

        /// <summary>
        /// 1:N organization_PostComment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_PostComment")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostComment> organization_PostComment
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostComment>("organization_PostComment", null);
            }
            set
            {
                this.OnPropertyChanging("organization_PostComment");
                this.SetRelatedEntities<CrmSdk.PostComment>("organization_PostComment", null, value);
                this.OnPropertyChanged("organization_PostComment");
            }
        }

        /// <summary>
        /// 1:N organization_postlike
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_postlike")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostLike> organization_postlike
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostLike>("organization_postlike", null);
            }
            set
            {
                this.OnPropertyChanging("organization_postlike");
                this.SetRelatedEntities<CrmSdk.PostLike>("organization_postlike", null, value);
                this.OnPropertyChanged("organization_postlike");
            }
        }

        /// <summary>
        /// 1:N organization_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_price_levels")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PriceLevel> organization_price_levels
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PriceLevel>("organization_price_levels", null);
            }
            set
            {
                this.OnPropertyChanging("organization_price_levels");
                this.SetRelatedEntities<CrmSdk.PriceLevel>("organization_price_levels", null, value);
                this.OnPropertyChanged("organization_price_levels");
            }
        }

        /// <summary>
        /// 1:N organization_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_products")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Product> organization_products
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Product>("organization_products", null);
            }
            set
            {
                this.OnPropertyChanging("organization_products");
                this.SetRelatedEntities<CrmSdk.Product>("organization_products", null, value);
                this.OnPropertyChanged("organization_products");
            }
        }

        /// <summary>
        /// 1:N organization_publisher
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_publisher")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Publisher> organization_publisher
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Publisher>("organization_publisher", null);
            }
            set
            {
                this.OnPropertyChanging("organization_publisher");
                this.SetRelatedEntities<CrmSdk.Publisher>("organization_publisher", null, value);
                this.OnPropertyChanged("organization_publisher");
            }
        }

        /// <summary>
        /// 1:N organization_queueitems
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queueitems")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> organization_queueitems
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("organization_queueitems", null);
            }
            set
            {
                this.OnPropertyChanging("organization_queueitems");
                this.SetRelatedEntities<CrmSdk.QueueItem>("organization_queueitems", null, value);
                this.OnPropertyChanged("organization_queueitems");
            }
        }

        /// <summary>
        /// 1:N organization_queues
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queues")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> organization_queues
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("organization_queues", null);
            }
            set
            {
                this.OnPropertyChanging("organization_queues");
                this.SetRelatedEntities<CrmSdk.Queue>("organization_queues", null, value);
                this.OnPropertyChanged("organization_queues");
            }
        }

        /// <summary>
        /// 1:N organization_relationship_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_relationship_roles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRole> organization_relationship_roles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRole>("organization_relationship_roles", null);
            }
            set
            {
                this.OnPropertyChanging("organization_relationship_roles");
                this.SetRelatedEntities<CrmSdk.RelationshipRole>("organization_relationship_roles", null, value);
                this.OnPropertyChanged("organization_relationship_roles");
            }
        }

        /// <summary>
        /// 1:N organization_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_groups")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceGroup> organization_resource_groups
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceGroup>("organization_resource_groups", null);
            }
            set
            {
                this.OnPropertyChanging("organization_resource_groups");
                this.SetRelatedEntities<CrmSdk.ResourceGroup>("organization_resource_groups", null, value);
                this.OnPropertyChanged("organization_resource_groups");
            }
        }

        /// <summary>
        /// 1:N organization_resource_specs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_specs")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceSpec> organization_resource_specs
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceSpec>("organization_resource_specs", null);
            }
            set
            {
                this.OnPropertyChanging("organization_resource_specs");
                this.SetRelatedEntities<CrmSdk.ResourceSpec>("organization_resource_specs", null, value);
                this.OnPropertyChanged("organization_resource_specs");
            }
        }

        /// <summary>
        /// 1:N organization_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resources")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Resource> organization_resources
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Resource>("organization_resources", null);
            }
            set
            {
                this.OnPropertyChanging("organization_resources");
                this.SetRelatedEntities<CrmSdk.Resource>("organization_resources", null, value);
                this.OnPropertyChanged("organization_resources");
            }
        }

        /// <summary>
        /// 1:N organization_ribbon_customization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ribbon_customization")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RibbonCustomization> organization_ribbon_customization
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RibbonCustomization>("organization_ribbon_customization", null);
            }
            set
            {
                this.OnPropertyChanging("organization_ribbon_customization");
                this.SetRelatedEntities<CrmSdk.RibbonCustomization>("organization_ribbon_customization", null, value);
                this.OnPropertyChanged("organization_ribbon_customization");
            }
        }

        /// <summary>
        /// 1:N organization_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_roles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> organization_roles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("organization_roles", null);
            }
            set
            {
                this.OnPropertyChanging("organization_roles");
                this.SetRelatedEntities<CrmSdk.Role>("organization_roles", null, value);
                this.OnPropertyChanged("organization_roles");
            }
        }

        /// <summary>
        /// 1:N organization_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sales_literature")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> organization_sales_literature
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("organization_sales_literature", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sales_literature");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("organization_sales_literature", null, value);
                this.OnPropertyChanged("organization_sales_literature");
            }
        }

        /// <summary>
        /// 1:N organization_saved_queries
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_queries")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQuery> organization_saved_queries
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQuery>("organization_saved_queries", null);
            }
            set
            {
                this.OnPropertyChanging("organization_saved_queries");
                this.SetRelatedEntities<CrmSdk.SavedQuery>("organization_saved_queries", null, value);
                this.OnPropertyChanged("organization_saved_queries");
            }
        }

        /// <summary>
        /// 1:N organization_saved_query_visualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_query_visualizations")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQueryVisualization> organization_saved_query_visualizations
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQueryVisualization>("organization_saved_query_visualizations", null);
            }
            set
            {
                this.OnPropertyChanging("organization_saved_query_visualizations");
                this.SetRelatedEntities<CrmSdk.SavedQueryVisualization>("organization_saved_query_visualizations", null, value);
                this.OnPropertyChanged("organization_saved_query_visualizations");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessage> organization_sdkmessage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessage>("organization_sdkmessage", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessage");
                this.SetRelatedEntities<CrmSdk.SdkMessage>("organization_sdkmessage", null, value);
                this.OnPropertyChanged("organization_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageFilter> organization_sdkmessagefilter
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageFilter>("organization_sdkmessagefilter", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagefilter");
                this.SetRelatedEntities<CrmSdk.SdkMessageFilter>("organization_sdkmessagefilter", null, value);
                this.OnPropertyChanged("organization_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessagePair> organization_sdkmessagepair
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessagePair>("organization_sdkmessagepair", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagepair");
                this.SetRelatedEntities<CrmSdk.SdkMessagePair>("organization_sdkmessagepair", null, value);
                this.OnPropertyChanged("organization_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> organization_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> organization_sdkmessageprocessingstepimage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepSecureConfig> organization_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("organization_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("organization_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequest> organization_sdkmessagerequest
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequest>("organization_sdkmessagerequest", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagerequest");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequest>("organization_sdkmessagerequest", null, value);
                this.OnPropertyChanged("organization_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequestField> organization_sdkmessagerequestfield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequestField>("organization_sdkmessagerequestfield", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagerequestfield");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequestField>("organization_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("organization_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponse> organization_sdkmessageresponse
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponse>("organization_sdkmessageresponse", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageresponse");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponse>("organization_sdkmessageresponse", null, value);
                this.OnPropertyChanged("organization_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponseField> organization_sdkmessageresponsefield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponseField>("organization_sdkmessageresponsefield", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageresponsefield");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponseField>("organization_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("organization_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N organization_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceEndpoint> organization_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceEndpoint>("organization_serviceendpoint", null);
            }
            set
            {
                this.OnPropertyChanging("organization_serviceendpoint");
                this.SetRelatedEntities<CrmSdk.ServiceEndpoint>("organization_serviceendpoint", null, value);
                this.OnPropertyChanged("organization_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N organization_services
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_services")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Service> organization_services
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Service>("organization_services", null);
            }
            set
            {
                this.OnPropertyChanging("organization_services");
                this.SetRelatedEntities<CrmSdk.Service>("organization_services", null, value);
                this.OnPropertyChanged("organization_services");
            }
        }

        /// <summary>
        /// 1:N organization_sitemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sitemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SiteMap> organization_sitemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SiteMap>("organization_sitemap", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sitemap");
                this.SetRelatedEntities<CrmSdk.SiteMap>("organization_sitemap", null, value);
                this.OnPropertyChanged("organization_sitemap");
            }
        }

        /// <summary>
        /// 1:N organization_sites
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sites")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Site> organization_sites
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Site>("organization_sites", null);
            }
            set
            {
                this.OnPropertyChanging("organization_sites");
                this.SetRelatedEntities<CrmSdk.Site>("organization_sites", null, value);
                this.OnPropertyChanged("organization_sites");
            }
        }

        /// <summary>
        /// 1:N organization_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solution")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Solution> organization_solution
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Solution>("organization_solution", null);
            }
            set
            {
                this.OnPropertyChanging("organization_solution");
                this.SetRelatedEntities<CrmSdk.Solution>("organization_solution", null, value);
                this.OnPropertyChanged("organization_solution");
            }
        }

        /// <summary>
        /// 1:N organization_subjects
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_subjects")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Subject> organization_subjects
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Subject>("organization_subjects", null);
            }
            set
            {
                this.OnPropertyChanging("organization_subjects");
                this.SetRelatedEntities<CrmSdk.Subject>("organization_subjects", null, value);
                this.OnPropertyChanged("organization_subjects");
            }
        }

        /// <summary>
        /// 1:N organization_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_system_users")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> organization_system_users
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("organization_system_users", null);
            }
            set
            {
                this.OnPropertyChanging("organization_system_users");
                this.SetRelatedEntities<CrmSdk.SystemUser>("organization_system_users", null, value);
                this.OnPropertyChanged("organization_system_users");
            }
        }

        /// <summary>
        /// 1:N organization_systemforms
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_systemforms")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemForm> organization_systemforms
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemForm>("organization_systemforms", null);
            }
            set
            {
                this.OnPropertyChanging("organization_systemforms");
                this.SetRelatedEntities<CrmSdk.SystemForm>("organization_systemforms", null, value);
                this.OnPropertyChanged("organization_systemforms");
            }
        }

        /// <summary>
        /// 1:N organization_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_teams")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> organization_teams
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("organization_teams", null);
            }
            set
            {
                this.OnPropertyChanging("organization_teams");
                this.SetRelatedEntities<CrmSdk.Team>("organization_teams", null, value);
                this.OnPropertyChanged("organization_teams");
            }
        }

        /// <summary>
        /// 1:N organization_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_territories")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> organization_territories
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("organization_territories", null);
            }
            set
            {
                this.OnPropertyChanging("organization_territories");
                this.SetRelatedEntities<CrmSdk.Territory>("organization_territories", null, value);
                this.OnPropertyChanged("organization_territories");
            }
        }

        /// <summary>
        /// 1:N organization_transactioncurrencies
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_transactioncurrencies")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransactionCurrency> organization_transactioncurrencies
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransactionCurrency>("organization_transactioncurrencies", null);
            }
            set
            {
                this.OnPropertyChanging("organization_transactioncurrencies");
                this.SetRelatedEntities<CrmSdk.TransactionCurrency>("organization_transactioncurrencies", null, value);
                this.OnPropertyChanged("organization_transactioncurrencies");
            }
        }

        /// <summary>
        /// 1:N organization_uof_schedules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_uof_schedules")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoMSchedule> organization_uof_schedules
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoMSchedule>("organization_uof_schedules", null);
            }
            set
            {
                this.OnPropertyChanging("organization_uof_schedules");
                this.SetRelatedEntities<CrmSdk.UoMSchedule>("organization_uof_schedules", null, value);
                this.OnPropertyChanged("organization_uof_schedules");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_organization")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_organization
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_organization", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_organization");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_organization", null, value);
                this.OnPropertyChanged("userentityinstancedata_organization");
            }
        }

        /// <summary>
        /// 1:N webresource_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_organization")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WebResource> webresource_organization
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WebResource>("webresource_organization", null);
            }
            set
            {
                this.OnPropertyChanging("webresource_organization");
                this.SetRelatedEntities<CrmSdk.WebResource>("webresource_organization", null, value);
                this.OnPropertyChanged("webresource_organization");
            }
        }

        /// <summary>
        /// N:1 basecurrency_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("basecurrency_organization")]
        public CrmSdk.TransactionCurrency basecurrency_organization
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.TransactionCurrency>("basecurrency_organization", null);
            }
            set
            {
                this.OnPropertyChanging("basecurrency_organization");
                this.SetRelatedEntity<CrmSdk.TransactionCurrency>("basecurrency_organization", null, value);
                this.OnPropertyChanged("basecurrency_organization");
            }
        }

        /// <summary>
        /// N:1 calendar_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessclosurecalendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_organization")]
        public CrmSdk.Calendar calendar_organization
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Calendar>("calendar_organization", null);
            }
            set
            {
                this.OnPropertyChanging("calendar_organization");
                this.SetRelatedEntity<CrmSdk.Calendar>("calendar_organization", null, value);
                this.OnPropertyChanged("calendar_organization");
            }
        }

        /// <summary>
        /// N:1 lk_organization_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_createdonbehalfby")]
        public CrmSdk.SystemUser lk_organization_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_organization_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_organization_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_modifiedonbehalfby")]
        public CrmSdk.SystemUser lk_organization_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_organization_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_organizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_createdby")]
        public CrmSdk.SystemUser lk_organizationbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_organizationbase_createdby", null);
            }
        }

        /// <summary>
        /// N:1 lk_organizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_modifiedby")]
        public CrmSdk.SystemUser lk_organizationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_organizationbase_modifiedby", null);
            }
        }

        /// <summary>
        /// N:1 Template_Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("acknowledgementtemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Template_Organization")]
        public CrmSdk.Template Template_Organization
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Template>("Template_Organization", null);
            }
            set
            {
                this.OnPropertyChanging("Template_Organization");
                this.SetRelatedEntity<CrmSdk.Template>("Template_Organization", null, value);
                this.OnPropertyChanged("Template_Organization");
            }
        }
    }
	
}
