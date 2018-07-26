namespace Xrm.Sdk.PluginRegistration.Entities
{
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [DataContract()]
    [EntityLogicalName("systemuser")]
    [GeneratedCode("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SystemUser : Entity, INotifyPropertyChanging, INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUser() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuser";

        public const int EntityTypeCode = 8;

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

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

        /// <summary>
        /// Type of user.
        /// </summary>
        [AttributeLogicalName("accessmode")]
        public OptionSetValue AccessMode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("accessmode");
            }
            set
            {
                OnPropertyChanging("AccessMode");
                SetAttributeValue("accessmode", value);
                OnPropertyChanged("AccessMode");
            }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [AttributeLogicalName("address1_addressid")]
        public Guid? Address1_AddressId
        {
            get
            {
                return GetAttributeValue<Guid?>("address1_addressid");
            }
            set
            {
                OnPropertyChanging("Address1_AddressId");
                SetAttributeValue("address1_addressid", value);
                OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [AttributeLogicalName("address1_addresstypecode")]
        public OptionSetValue Address1_AddressTypeCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("address1_addresstypecode");
            }
            set
            {
                OnPropertyChanging("Address1_AddressTypeCode");
                SetAttributeValue("address1_addresstypecode", value);
                OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 1.
        /// </summary>
        [AttributeLogicalName("address1_city")]
        public string Address1_City
        {
            get
            {
                return GetAttributeValue<string>("address1_city");
            }
            set
            {
                OnPropertyChanging("Address1_City");
                SetAttributeValue("address1_city", value);
                OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Country/region name in address 1.
        /// </summary>
        [AttributeLogicalName("address1_country")]
        public string Address1_Country
        {
            get
            {
                return GetAttributeValue<string>("address1_country");
            }
            set
            {
                OnPropertyChanging("Address1_Country");
                SetAttributeValue("address1_country", value);
                OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// County name for address 1.
        /// </summary>
        [AttributeLogicalName("address1_county")]
        public string Address1_County
        {
            get
            {
                return GetAttributeValue<string>("address1_county");
            }
            set
            {
                OnPropertyChanging("Address1_County");
                SetAttributeValue("address1_county", value);
                OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Fax number for address 1.
        /// </summary>
        [AttributeLogicalName("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return GetAttributeValue<string>("address1_fax");
            }
            set
            {
                OnPropertyChanging("Address1_Fax");
                SetAttributeValue("address1_fax", value);
                OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 1.
        /// </summary>
        [AttributeLogicalName("address1_latitude")]
        public double? Address1_Latitude
        {
            get
            {
                return GetAttributeValue<double?>("address1_latitude");
            }
            set
            {
                OnPropertyChanging("Address1_Latitude");
                SetAttributeValue("address1_latitude", value);
                OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return GetAttributeValue<string>("address1_line1");
            }
            set
            {
                OnPropertyChanging("Address1_Line1");
                SetAttributeValue("address1_line1", value);
                OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return GetAttributeValue<string>("address1_line2");
            }
            set
            {
                OnPropertyChanging("Address1_Line2");
                SetAttributeValue("address1_line2", value);
                OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [AttributeLogicalName("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return GetAttributeValue<string>("address1_line3");
            }
            set
            {
                OnPropertyChanging("Address1_Line3");
                SetAttributeValue("address1_line3", value);
                OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 1.
        /// </summary>
        [AttributeLogicalName("address1_longitude")]
        public double? Address1_Longitude
        {
            get
            {
                return GetAttributeValue<double?>("address1_longitude");
            }
            set
            {
                OnPropertyChanging("Address1_Longitude");
                SetAttributeValue("address1_longitude", value);
                OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 1.
        /// </summary>
        [AttributeLogicalName("address1_name")]
        public string Address1_Name
        {
            get
            {
                return GetAttributeValue<string>("address1_name");
            }
            set
            {
                OnPropertyChanging("Address1_Name");
                SetAttributeValue("address1_name", value);
                OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 1.
        /// </summary>
        [AttributeLogicalName("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return GetAttributeValue<string>("address1_postalcode");
            }
            set
            {
                OnPropertyChanging("Address1_PostalCode");
                SetAttributeValue("address1_postalcode", value);
                OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 1.
        /// </summary>
        [AttributeLogicalName("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                OnPropertyChanging("Address1_PostOfficeBox");
                SetAttributeValue("address1_postofficebox", value);
                OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 1.
        /// </summary>
        [AttributeLogicalName("address1_shippingmethodcode")]
        public OptionSetValue Address1_ShippingMethodCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("address1_shippingmethodcode");
            }
            set
            {
                OnPropertyChanging("Address1_ShippingMethodCode");
                SetAttributeValue("address1_shippingmethodcode", value);
                OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 1.
        /// </summary>
        [AttributeLogicalName("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return GetAttributeValue<string>("address1_stateorprovince");
            }
            set
            {
                OnPropertyChanging("Address1_StateOrProvince");
                SetAttributeValue("address1_stateorprovince", value);
                OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone1");
            }
            set
            {
                OnPropertyChanging("Address1_Telephone1");
                SetAttributeValue("address1_telephone1", value);
                OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone2");
            }
            set
            {
                OnPropertyChanging("Address1_Telephone2");
                SetAttributeValue("address1_telephone2", value);
                OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 1.
        /// </summary>
        [AttributeLogicalName("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return GetAttributeValue<string>("address1_telephone3");
            }
            set
            {
                OnPropertyChanging("Address1_Telephone3");
                SetAttributeValue("address1_telephone3", value);
                OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [AttributeLogicalName("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return GetAttributeValue<string>("address1_upszone");
            }
            set
            {
                OnPropertyChanging("Address1_UPSZone");
                SetAttributeValue("address1_upszone", value);
                OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [AttributeLogicalName("address1_utcoffset")]
        public int? Address1_UTCOffset
        {
            get
            {
                return GetAttributeValue<int?>("address1_utcoffset");
            }
            set
            {
                OnPropertyChanging("Address1_UTCOffset");
                SetAttributeValue("address1_utcoffset", value);
                OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [AttributeLogicalName("address2_addressid")]
        public Guid? Address2_AddressId
        {
            get
            {
                return GetAttributeValue<Guid?>("address2_addressid");
            }
            set
            {
                OnPropertyChanging("Address2_AddressId");
                SetAttributeValue("address2_addressid", value);
                OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address.
        /// </summary>
        [AttributeLogicalName("address2_addresstypecode")]
        public OptionSetValue Address2_AddressTypeCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("address2_addresstypecode");
            }
            set
            {
                OnPropertyChanging("Address2_AddressTypeCode");
                SetAttributeValue("address2_addresstypecode", value);
                OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 2.
        /// </summary>
        [AttributeLogicalName("address2_city")]
        public string Address2_City
        {
            get
            {
                return GetAttributeValue<string>("address2_city");
            }
            set
            {
                OnPropertyChanging("Address2_City");
                SetAttributeValue("address2_city", value);
                OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Country/region name in address 2.
        /// </summary>
        [AttributeLogicalName("address2_country")]
        public string Address2_Country
        {
            get
            {
                return GetAttributeValue<string>("address2_country");
            }
            set
            {
                OnPropertyChanging("Address2_Country");
                SetAttributeValue("address2_country", value);
                OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// County name for address 2.
        /// </summary>
        [AttributeLogicalName("address2_county")]
        public string Address2_County
        {
            get
            {
                return GetAttributeValue<string>("address2_county");
            }
            set
            {
                OnPropertyChanging("Address2_County");
                SetAttributeValue("address2_county", value);
                OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Fax number for address 2.
        /// </summary>
        [AttributeLogicalName("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return GetAttributeValue<string>("address2_fax");
            }
            set
            {
                OnPropertyChanging("Address2_Fax");
                SetAttributeValue("address2_fax", value);
                OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 2.
        /// </summary>
        [AttributeLogicalName("address2_latitude")]
        public double? Address2_Latitude
        {
            get
            {
                return GetAttributeValue<double?>("address2_latitude");
            }
            set
            {
                OnPropertyChanging("Address2_Latitude");
                SetAttributeValue("address2_latitude", value);
                OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return GetAttributeValue<string>("address2_line1");
            }
            set
            {
                OnPropertyChanging("Address2_Line1");
                SetAttributeValue("address2_line1", value);
                OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return GetAttributeValue<string>("address2_line2");
            }
            set
            {
                OnPropertyChanging("Address2_Line2");
                SetAttributeValue("address2_line2", value);
                OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 2 information.
        /// </summary>
        [AttributeLogicalName("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return GetAttributeValue<string>("address2_line3");
            }
            set
            {
                OnPropertyChanging("Address2_Line3");
                SetAttributeValue("address2_line3", value);
                OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 2.
        /// </summary>
        [AttributeLogicalName("address2_longitude")]
        public double? Address2_Longitude
        {
            get
            {
                return GetAttributeValue<double?>("address2_longitude");
            }
            set
            {
                OnPropertyChanging("Address2_Longitude");
                SetAttributeValue("address2_longitude", value);
                OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 2.
        /// </summary>
        [AttributeLogicalName("address2_name")]
        public string Address2_Name
        {
            get
            {
                return GetAttributeValue<string>("address2_name");
            }
            set
            {
                OnPropertyChanging("Address2_Name");
                SetAttributeValue("address2_name", value);
                OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 2.
        /// </summary>
        [AttributeLogicalName("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return GetAttributeValue<string>("address2_postalcode");
            }
            set
            {
                OnPropertyChanging("Address2_PostalCode");
                SetAttributeValue("address2_postalcode", value);
                OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 2.
        /// </summary>
        [AttributeLogicalName("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                OnPropertyChanging("Address2_PostOfficeBox");
                SetAttributeValue("address2_postofficebox", value);
                OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 2.
        /// </summary>
        [AttributeLogicalName("address2_shippingmethodcode")]
        public OptionSetValue Address2_ShippingMethodCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("address2_shippingmethodcode");
            }
            set
            {
                OnPropertyChanging("Address2_ShippingMethodCode");
                SetAttributeValue("address2_shippingmethodcode", value);
                OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 2.
        /// </summary>
        [AttributeLogicalName("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return GetAttributeValue<string>("address2_stateorprovince");
            }
            set
            {
                OnPropertyChanging("Address2_StateOrProvince");
                SetAttributeValue("address2_stateorprovince", value);
                OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone1");
            }
            set
            {
                OnPropertyChanging("Address2_Telephone1");
                SetAttributeValue("address2_telephone1", value);
                OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone2");
            }
            set
            {
                OnPropertyChanging("Address2_Telephone2");
                SetAttributeValue("address2_telephone2", value);
                OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 2.
        /// </summary>
        [AttributeLogicalName("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return GetAttributeValue<string>("address2_telephone3");
            }
            set
            {
                OnPropertyChanging("Address2_Telephone3");
                SetAttributeValue("address2_telephone3", value);
                OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [AttributeLogicalName("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return GetAttributeValue<string>("address2_upszone");
            }
            set
            {
                OnPropertyChanging("Address2_UPSZone");
                SetAttributeValue("address2_upszone", value);
                OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [AttributeLogicalName("address2_utcoffset")]
        public int? Address2_UTCOffset
        {
            get
            {
                return GetAttributeValue<int?>("address2_utcoffset");
            }
            set
            {
                OnPropertyChanging("Address2_UTCOffset");
                SetAttributeValue("address2_utcoffset", value);
                OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [AttributeLogicalName("businessunitid")]
        public EntityReference BusinessUnitId
        {
            get
            {
                return GetAttributeValue<EntityReference>("businessunitid");
            }
            set
            {
                OnPropertyChanging("BusinessUnitId");
                SetAttributeValue("businessunitid", value);
                OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Fiscal calendar associated with the user.
        /// </summary>
        [AttributeLogicalName("calendarid")]
        public EntityReference CalendarId
        {
            get
            {
                return GetAttributeValue<EntityReference>("calendarid");
            }
            set
            {
                OnPropertyChanging("CalendarId");
                SetAttributeValue("calendarid", value);
                OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// License type of user.
        /// </summary>
        [AttributeLogicalName("caltype")]
        public OptionSetValue CALType
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("caltype");
            }
            set
            {
                OnPropertyChanging("CALType");
                SetAttributeValue("caltype", value);
                OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the user.
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
        /// Date and time when the user was created.
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
        /// Unique identifier of the delegate user who created the systemuser.
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
        /// Indicates if default outlook filters have been populated.
        /// </summary>
        [AttributeLogicalName("defaultfilterspopulated")]
        public bool? DefaultFiltersPopulated
        {
            get
            {
                return GetAttributeValue<bool?>("defaultfilterspopulated");
            }
        }

        /// <summary>
        /// Reason for disabling the user.
        /// </summary>
        [AttributeLogicalName("disabledreason")]
        public string DisabledReason
        {
            get
            {
                return GetAttributeValue<string>("disabledreason");
            }
        }

        /// <summary>
        /// Whether to display the user in service views.
        /// </summary>
        [AttributeLogicalName("displayinserviceviews")]
        public bool? DisplayInServiceViews
        {
            get
            {
                return GetAttributeValue<bool?>("displayinserviceviews");
            }
            set
            {
                OnPropertyChanging("DisplayInServiceViews");
                SetAttributeValue("displayinserviceviews", value);
                OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [AttributeLogicalName("domainname")]
        public string DomainName
        {
            get
            {
                return GetAttributeValue<string>("domainname");
            }
            set
            {
                OnPropertyChanging("DomainName");
                SetAttributeValue("domainname", value);
                OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        /// Shows the status of the primary e-mail address.
        /// </summary>
        [AttributeLogicalName("emailrouteraccessapproval")]
        public OptionSetValue EmailRouterAccessApproval
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("emailrouteraccessapproval");
            }
            set
            {
                OnPropertyChanging("EmailRouterAccessApproval");
                SetAttributeValue("emailrouteraccessapproval", value);
                OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// Employee identifier for the user.
        /// </summary>
        [AttributeLogicalName("employeeid")]
        public string EmployeeId
        {
            get
            {
                return GetAttributeValue<string>("employeeid");
            }
            set
            {
                OnPropertyChanging("EmployeeId");
                SetAttributeValue("employeeid", value);
                OnPropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the systemuser with respect to the base currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public decimal? ExchangeRate
        {
            get
            {
                return GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [AttributeLogicalName("firstname")]
        public string FirstName
        {
            get
            {
                return GetAttributeValue<string>("firstname");
            }
            set
            {
                OnPropertyChanging("FirstName");
                SetAttributeValue("firstname", value);
                OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [AttributeLogicalName("fullname")]
        public string FullName
        {
            get
            {
                return GetAttributeValue<string>("fullname");
            }
        }

        /// <summary>
        /// Government identifier for the user.
        /// </summary>
        [AttributeLogicalName("governmentid")]
        public string GovernmentId
        {
            get
            {
                return GetAttributeValue<string>("governmentid");
            }
            set
            {
                OnPropertyChanging("GovernmentId");
                SetAttributeValue("governmentid", value);
                OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        /// Home phone number for the user.
        /// </summary>
        [AttributeLogicalName("homephone")]
        public string HomePhone
        {
            get
            {
                return GetAttributeValue<string>("homephone");
            }
            set
            {
                OnPropertyChanging("HomePhone");
                SetAttributeValue("homephone", value);
                OnPropertyChanged("HomePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public int? ImportSequenceNumber
        {
            get
            {
                return GetAttributeValue<int?>("importsequencenumber");
            }
            set
            {
                OnPropertyChanging("ImportSequenceNumber");
                SetAttributeValue("importsequencenumber", value);
                OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Incoming e-mail delivery method for the user.
        /// </summary>
        [AttributeLogicalName("incomingemaildeliverymethod")]
        public OptionSetValue IncomingEmailDeliveryMethod
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("incomingemaildeliverymethod");
            }
            set
            {
                OnPropertyChanging("IncomingEmailDeliveryMethod");
                SetAttributeValue("incomingemaildeliverymethod", value);
                OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Internal e-mail address for the user.
        /// </summary>
        [AttributeLogicalName("internalemailaddress")]
        public string InternalEMailAddress
        {
            get
            {
                return GetAttributeValue<string>("internalemailaddress");
            }
            set
            {
                OnPropertyChanging("InternalEMailAddress");
                SetAttributeValue("internalemailaddress", value);
                OnPropertyChanged("InternalEMailAddress");
            }
        }

        /// <summary>
        /// User invitation status.
        /// </summary>
        [AttributeLogicalName("invitestatuscode")]
        public OptionSetValue InviteStatusCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("invitestatuscode");
            }
            set
            {
                OnPropertyChanging("InviteStatusCode");
                SetAttributeValue("invitestatuscode", value);
                OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        /// Information about whether the user is enabled.
        /// </summary>
        [AttributeLogicalName("isdisabled")]
        public bool? IsDisabled
        {
            get
            {
                return GetAttributeValue<bool?>("isdisabled");
            }
        }

        /// <summary>
        /// Check if user is an integration user.
        /// </summary>
        [AttributeLogicalName("isintegrationuser")]
        public bool? IsIntegrationUser
        {
            get
            {
                return GetAttributeValue<bool?>("isintegrationuser");
            }
            set
            {
                OnPropertyChanging("IsIntegrationUser");
                SetAttributeValue("isintegrationuser", value);
                OnPropertyChanged("IsIntegrationUser");
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [AttributeLogicalName("islicensed")]
        public bool? IsLicensed
        {
            get
            {
                return GetAttributeValue<bool?>("islicensed");
            }
            set
            {
                OnPropertyChanging("IsLicensed");
                SetAttributeValue("islicensed", value);
                OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        /// Information about whether the user is synced with the directory.
        /// </summary>
        [AttributeLogicalName("issyncwithdirectory")]
        public bool? IsSyncWithDirectory
        {
            get
            {
                return GetAttributeValue<bool?>("issyncwithdirectory");
            }
            set
            {
                OnPropertyChanging("IsSyncWithDirectory");
                SetAttributeValue("issyncwithdirectory", value);
                OnPropertyChanged("IsSyncWithDirectory");
            }
        }

        /// <summary>
        /// Job title of the user.
        /// </summary>
        [AttributeLogicalName("jobtitle")]
        public string JobTitle
        {
            get
            {
                return GetAttributeValue<string>("jobtitle");
            }
            set
            {
                OnPropertyChanging("JobTitle");
                SetAttributeValue("jobtitle", value);
                OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [AttributeLogicalName("lastname")]
        public string LastName
        {
            get
            {
                return GetAttributeValue<string>("lastname");
            }
            set
            {
                OnPropertyChanging("LastName");
                SetAttributeValue("lastname", value);
                OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Middle name of the user.
        /// </summary>
        [AttributeLogicalName("middlename")]
        public string MiddleName
        {
            get
            {
                return GetAttributeValue<string>("middlename");
            }
            set
            {
                OnPropertyChanging("MiddleName");
                SetAttributeValue("middlename", value);
                OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Mobile alert e-mail address for the user.
        /// </summary>
        [AttributeLogicalName("mobilealertemail")]
        public string MobileAlertEMail
        {
            get
            {
                return GetAttributeValue<string>("mobilealertemail");
            }
            set
            {
                OnPropertyChanging("MobileAlertEMail");
                SetAttributeValue("mobilealertemail", value);
                OnPropertyChanged("MobileAlertEMail");
            }
        }

        /// <summary>
        /// Mobile phone number for the user.
        /// </summary>
        [AttributeLogicalName("mobilephone")]
        public string MobilePhone
        {
            get
            {
                return GetAttributeValue<string>("mobilephone");
            }
            set
            {
                OnPropertyChanging("MobilePhone");
                SetAttributeValue("mobilephone", value);
                OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the user.
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
        /// Date and time when the user was last modified.
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
        /// Unique identifier of the delegate user who last modified the systemuser.
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
        /// Nickname of the user.
        /// </summary>
        [AttributeLogicalName("nickname")]
        public string NickName
        {
            get
            {
                return GetAttributeValue<string>("nickname");
            }
            set
            {
                OnPropertyChanging("NickName");
                SetAttributeValue("nickname", value);
                OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the user.
        /// </summary>
        [AttributeLogicalName("organizationid")]
        public Guid? OrganizationId
        {
            get
            {
                return GetAttributeValue<Guid?>("organizationid");
            }
        }

        /// <summary>
        /// Outgoing e-mail delivery method for the user.
        /// </summary>
        [AttributeLogicalName("outgoingemaildeliverymethod")]
        public OptionSetValue OutgoingEmailDeliveryMethod
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("outgoingemaildeliverymethod");
            }
            set
            {
                OnPropertyChanging("OutgoingEmailDeliveryMethod");
                SetAttributeValue("outgoingemaildeliverymethod", value);
                OnPropertyChanged("OutgoingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public DateTime? OverriddenCreatedOn
        {
            get
            {
                return GetAttributeValue<DateTime?>("overriddencreatedon");
            }
            set
            {
                OnPropertyChanging("OverriddenCreatedOn");
                SetAttributeValue("overriddencreatedon", value);
                OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the manager of the user.
        /// </summary>
        [AttributeLogicalName("parentsystemuserid")]
        public EntityReference ParentSystemUserId
        {
            get
            {
                return GetAttributeValue<EntityReference>("parentsystemuserid");
            }
            set
            {
                OnPropertyChanging("ParentSystemUserId");
                SetAttributeValue("parentsystemuserid", value);
                OnPropertyChanged("ParentSystemUserId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("passporthi")]
        public int? PassportHi
        {
            get
            {
                return GetAttributeValue<int?>("passporthi");
            }
            set
            {
                OnPropertyChanging("PassportHi");
                SetAttributeValue("passporthi", value);
                OnPropertyChanged("PassportHi");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("passportlo")]
        public int? PassportLo
        {
            get
            {
                return GetAttributeValue<int?>("passportlo");
            }
            set
            {
                OnPropertyChanging("PassportLo");
                SetAttributeValue("passportlo", value);
                OnPropertyChanged("PassportLo");
            }
        }

        /// <summary>
        /// Personal e-mail address of the user.
        /// </summary>
        [AttributeLogicalName("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get
            {
                return GetAttributeValue<string>("personalemailaddress");
            }
            set
            {
                OnPropertyChanging("PersonalEMailAddress");
                SetAttributeValue("personalemailaddress", value);
                OnPropertyChanged("PersonalEMailAddress");
            }
        }

        /// <summary>
        /// URL for the Web site on which a photo of the user is located.
        /// </summary>
        [AttributeLogicalName("photourl")]
        public string PhotoUrl
        {
            get
            {
                return GetAttributeValue<string>("photourl");
            }
            set
            {
                OnPropertyChanging("PhotoUrl");
                SetAttributeValue("photourl", value);
                OnPropertyChanged("PhotoUrl");
            }
        }

        /// <summary>
        /// Preferred address for the user.
        /// </summary>
        [AttributeLogicalName("preferredaddresscode")]
        public OptionSetValue PreferredAddressCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("preferredaddresscode");
            }
            set
            {
                OnPropertyChanging("PreferredAddressCode");
                SetAttributeValue("preferredaddresscode", value);
                OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        /// Preferred e-mail address for the user.
        /// </summary>
        [AttributeLogicalName("preferredemailcode")]
        public OptionSetValue PreferredEmailCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("preferredemailcode");
            }
            set
            {
                OnPropertyChanging("PreferredEmailCode");
                SetAttributeValue("preferredemailcode", value);
                OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        /// Preferred phone number for the user.
        /// </summary>
        [AttributeLogicalName("preferredphonecode")]
        public OptionSetValue PreferredPhoneCode
        {
            get
            {
                return GetAttributeValue<OptionSetValue>("preferredphonecode");
            }
            set
            {
                OnPropertyChanging("PreferredPhoneCode");
                SetAttributeValue("preferredphonecode", value);
                OnPropertyChanged("PreferredPhoneCode");
            }
        }

        /// <summary>
        /// Unique identifier of the default queue for the user.
        /// </summary>
        [AttributeLogicalName("queueid")]
        public EntityReference QueueId
        {
            get
            {
                return GetAttributeValue<EntityReference>("queueid");
            }
            set
            {
                OnPropertyChanging("QueueId");
                SetAttributeValue("queueid", value);
                OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// Salutation for correspondence with the user.
        /// </summary>
        [AttributeLogicalName("salutation")]
        public string Salutation
        {
            get
            {
                return GetAttributeValue<string>("salutation");
            }
            set
            {
                OnPropertyChanging("Salutation");
                SetAttributeValue("salutation", value);
                OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Check if user is a setup user.
        /// </summary>
        [AttributeLogicalName("setupuser")]
        public bool? SetupUser
        {
            get
            {
                return GetAttributeValue<bool?>("setupuser");
            }
            set
            {
                OnPropertyChanging("SetupUser");
                SetAttributeValue("setupuser", value);
                OnPropertyChanged("SetupUser");
            }
        }

        /// <summary>
        /// Site at which the user is located.
        /// </summary>
        [AttributeLogicalName("siteid")]
        public EntityReference SiteId
        {
            get
            {
                return GetAttributeValue<EntityReference>("siteid");
            }
            set
            {
                OnPropertyChanging("SiteId");
                SetAttributeValue("siteid", value);
                OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Skill set of the user.
        /// </summary>
        [AttributeLogicalName("skills")]
        public string Skills
        {
            get
            {
                return GetAttributeValue<string>("skills");
            }
            set
            {
                OnPropertyChanging("Skills");
                SetAttributeValue("skills", value);
                OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [AttributeLogicalName("systemuserid")]
        public Guid? SystemUserId
        {
            get
            {
                return GetAttributeValue<Guid?>("systemuserid");
            }
            set
            {
                OnPropertyChanging("SystemUserId");
                SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = Guid.Empty;
                }
                OnPropertyChanged("SystemUserId");
            }
        }

        [AttributeLogicalName("systemuserid")]
        public override Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                SystemUserId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [AttributeLogicalName("territoryid")]
        public EntityReference TerritoryId
        {
            get
            {
                return GetAttributeValue<EntityReference>("territoryid");
            }
            set
            {
                OnPropertyChanging("TerritoryId");
                SetAttributeValue("territoryid", value);
                OnPropertyChanged("TerritoryId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("timezoneruleversionnumber")]
        public int? TimeZoneRuleVersionNumber
        {
            get
            {
                return GetAttributeValue<int?>("timezoneruleversionnumber");
            }
            set
            {
                OnPropertyChanging("TimeZoneRuleVersionNumber");
                SetAttributeValue("timezoneruleversionnumber", value);
                OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Title of the user.
        /// </summary>
        [AttributeLogicalName("title")]
        public string Title
        {
            get
            {
                return GetAttributeValue<string>("title");
            }
            set
            {
                OnPropertyChanging("Title");
                SetAttributeValue("title", value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the systemuser.
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        public EntityReference TransactionCurrencyId
        {
            get
            {
                return GetAttributeValue<EntityReference>("transactioncurrencyid");
            }
            set
            {
                OnPropertyChanging("TransactionCurrencyId");
                SetAttributeValue("transactioncurrencyid", value);
                OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [AttributeLogicalName("utcconversiontimezonecode")]
        public int? UTCConversionTimeZoneCode
        {
            get
            {
                return GetAttributeValue<int?>("utcconversiontimezonecode");
            }
            set
            {
                OnPropertyChanging("UTCConversionTimeZoneCode");
                SetAttributeValue("utcconversiontimezonecode", value);
                OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the user.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public long? VersionNumber
        {
            get
            {
                return GetAttributeValue<long?>("versionnumber");
            }
        }

        /// <summary>
        /// Windows Live ID
        /// </summary>
        [AttributeLogicalName("windowsliveid")]
        public string WindowsLiveID
        {
            get
            {
                return GetAttributeValue<string>("windowsliveid");
            }
            set
            {
                OnPropertyChanging("WindowsLiveID");
                SetAttributeValue("windowsliveid", value);
                OnPropertyChanged("WindowsLiveID");
            }
        }

        /// <summary>
        /// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomifirstname")]
        public string YomiFirstName
        {
            get
            {
                return GetAttributeValue<string>("yomifirstname");
            }
            set
            {
                OnPropertyChanging("YomiFirstName");
                SetAttributeValue("yomifirstname", value);
                OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomifullname")]
        public string YomiFullName
        {
            get
            {
                return GetAttributeValue<string>("yomifullname");
            }
        }

        /// <summary>
        /// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomilastname")]
        public string YomiLastName
        {
            get
            {
                return GetAttributeValue<string>("yomilastname");
            }
            set
            {
                OnPropertyChanging("YomiLastName");
                SetAttributeValue("yomilastname", value);
                OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [AttributeLogicalName("yomimiddlename")]
        public string YomiMiddleName
        {
            get
            {
                return GetAttributeValue<string>("yomimiddlename");
            }
            set
            {
                OnPropertyChanging("YomiMiddleName");
                SetAttributeValue("yomimiddlename", value);
                OnPropertyChanged("YomiMiddleName");
            }
        }
    }
}