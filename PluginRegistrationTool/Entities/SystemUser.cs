namespace PluginRegistrationTool.Entities
{
    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "5.0.9689.1985")]
    public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
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
        /// Type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode");
            }
            set
            {
                this.OnPropertyChanging("AccessMode");
                this.SetAttributeValue("accessmode", value);
                this.OnPropertyChanged("AccessMode");
            }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
            }
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
            }
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            get
            {
                return this.GetAttributeValue<string>("address1_city");
            }
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Country/region name in address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address1_country");
            }
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// County name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            get
            {
                return this.GetAttributeValue<string>("address1_county");
            }
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Fax number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address1_fax");
            }
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
            }
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line1");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line2");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line3");
            }
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
            }
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address1_name");
            }
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postalcode");
            }
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
            }
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address1_stateorprovince");
            }
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone1");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone2");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone3");
            }
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address1_upszone");
            }
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
            }
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
            }
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 2, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
            }
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            get
            {
                return this.GetAttributeValue<string>("address2_city");
            }
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Country/region name in address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address2_country");
            }
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// County name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            get
            {
                return this.GetAttributeValue<string>("address2_county");
            }
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Fax number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address2_fax");
            }
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
            }
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line1");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line2");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line3");
            }
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
            }
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address2_name");
            }
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postalcode");
            }
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
            }
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address2_stateorprovince");
            }
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone1");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone2");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone3");
            }
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address2_upszone");
            }
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
            }
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid");
            }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Fiscal calendar associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Sdk.EntityReference CalendarId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid");
            }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// License type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
        public Microsoft.Xrm.Sdk.OptionSetValue CALType
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype");
            }
            set
            {
                this.OnPropertyChanging("CALType");
                this.SetAttributeValue("caltype", value);
                this.OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the user.
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
        /// Date and time when the user was created.
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
        /// Unique identifier of the delegate user who created the systemuser.
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
        /// Indicates if default outlook filters have been populated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
        public System.Nullable<bool> DefaultFiltersPopulated
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated");
            }
        }

        /// <summary>
        /// Reason for disabling the user.
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
        /// Whether to display the user in service views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews");
            }
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            get
            {
                return this.GetAttributeValue<string>("domainname");
            }
            set
            {
                this.OnPropertyChanging("DomainName");
                this.SetAttributeValue("domainname", value);
                this.OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        /// Shows the status of the primary e-mail address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval");
            }
            set
            {
                this.OnPropertyChanging("EmailRouterAccessApproval");
                this.SetAttributeValue("emailrouteraccessapproval", value);
                this.OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// Employee identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            get
            {
                return this.GetAttributeValue<string>("employeeid");
            }
            set
            {
                this.OnPropertyChanging("EmployeeId");
                this.SetAttributeValue("employeeid", value);
                this.OnPropertyChanged("EmployeeId");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the systemuser with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            get
            {
                return this.GetAttributeValue<string>("firstname");
            }
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            get
            {
                return this.GetAttributeValue<string>("fullname");
            }
        }

        /// <summary>
        /// Government identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            get
            {
                return this.GetAttributeValue<string>("governmentid");
            }
            set
            {
                this.OnPropertyChanging("GovernmentId");
                this.SetAttributeValue("governmentid", value);
                this.OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        /// Home phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
        public string HomePhone
        {
            get
            {
                return this.GetAttributeValue<string>("homephone");
            }
            set
            {
                this.OnPropertyChanging("HomePhone");
                this.SetAttributeValue("homephone", value);
                this.OnPropertyChanged("HomePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Incoming e-mail delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod");
            }
            set
            {
                this.OnPropertyChanging("IncomingEmailDeliveryMethod");
                this.SetAttributeValue("incomingemaildeliverymethod", value);
                this.OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Internal e-mail address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
        public string InternalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("internalemailaddress");
            }
            set
            {
                this.OnPropertyChanging("InternalEMailAddress");
                this.SetAttributeValue("internalemailaddress", value);
                this.OnPropertyChanged("InternalEMailAddress");
            }
        }

        /// <summary>
        /// User invitation status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InviteStatusCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode");
            }
            set
            {
                this.OnPropertyChanging("InviteStatusCode");
                this.SetAttributeValue("invitestatuscode", value);
                this.OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        /// Information about whether the user is enabled.
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
        /// Check if user is an integration user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
        public System.Nullable<bool> IsIntegrationUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser");
            }
            set
            {
                this.OnPropertyChanging("IsIntegrationUser");
                this.SetAttributeValue("isintegrationuser", value);
                this.OnPropertyChanged("IsIntegrationUser");
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("islicensed");
            }
            set
            {
                this.OnPropertyChanging("IsLicensed");
                this.SetAttributeValue("islicensed", value);
                this.OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        /// Information about whether the user is synced with the directory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
        public System.Nullable<bool> IsSyncWithDirectory
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory");
            }
            set
            {
                this.OnPropertyChanging("IsSyncWithDirectory");
                this.SetAttributeValue("issyncwithdirectory", value);
                this.OnPropertyChanged("IsSyncWithDirectory");
            }
        }

        /// <summary>
        /// Job title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            get
            {
                return this.GetAttributeValue<string>("jobtitle");
            }
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            get
            {
                return this.GetAttributeValue<string>("lastname");
            }
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Middle name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("middlename");
            }
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Mobile alert e-mail address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
        public string MobileAlertEMail
        {
            get
            {
                return this.GetAttributeValue<string>("mobilealertemail");
            }
            set
            {
                this.OnPropertyChanging("MobileAlertEMail");
                this.SetAttributeValue("mobilealertemail", value);
                this.OnPropertyChanged("MobileAlertEMail");
            }
        }

        /// <summary>
        /// Mobile phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            get
            {
                return this.GetAttributeValue<string>("mobilephone");
            }
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the user.
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
        /// Date and time when the user was last modified.
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
        /// Unique identifier of the delegate user who last modified the systemuser.
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
        /// Nickname of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            get
            {
                return this.GetAttributeValue<string>("nickname");
            }
            set
            {
                this.OnPropertyChanging("NickName");
                this.SetAttributeValue("nickname", value);
                this.OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
            }
        }

        /// <summary>
        /// Outgoing e-mail delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod");
            }
            set
            {
                this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
                this.SetAttributeValue("outgoingemaildeliverymethod", value);
                this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the manager of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid");
            }
            set
            {
                this.OnPropertyChanging("ParentSystemUserId");
                this.SetAttributeValue("parentsystemuserid", value);
                this.OnPropertyChanged("ParentSystemUserId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
        public System.Nullable<int> PassportHi
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passporthi");
            }
            set
            {
                this.OnPropertyChanging("PassportHi");
                this.SetAttributeValue("passporthi", value);
                this.OnPropertyChanged("PassportHi");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
        public System.Nullable<int> PassportLo
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("passportlo");
            }
            set
            {
                this.OnPropertyChanging("PassportLo");
                this.SetAttributeValue("passportlo", value);
                this.OnPropertyChanged("PassportLo");
            }
        }

        /// <summary>
        /// Personal e-mail address of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get
            {
                return this.GetAttributeValue<string>("personalemailaddress");
            }
            set
            {
                this.OnPropertyChanging("PersonalEMailAddress");
                this.SetAttributeValue("personalemailaddress", value);
                this.OnPropertyChanged("PersonalEMailAddress");
            }
        }

        /// <summary>
        /// URL for the Web site on which a photo of the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
        public string PhotoUrl
        {
            get
            {
                return this.GetAttributeValue<string>("photourl");
            }
            set
            {
                this.OnPropertyChanging("PhotoUrl");
                this.SetAttributeValue("photourl", value);
                this.OnPropertyChanged("PhotoUrl");
            }
        }

        /// <summary>
        /// Preferred address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAddressCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode");
            }
            set
            {
                this.OnPropertyChanging("PreferredAddressCode");
                this.SetAttributeValue("preferredaddresscode", value);
                this.OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        /// Preferred e-mail address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredEmailCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode");
            }
            set
            {
                this.OnPropertyChanging("PreferredEmailCode");
                this.SetAttributeValue("preferredemailcode", value);
                this.OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        /// Preferred phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredPhoneCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode");
            }
            set
            {
                this.OnPropertyChanging("PreferredPhoneCode");
                this.SetAttributeValue("preferredphonecode", value);
                this.OnPropertyChanged("PreferredPhoneCode");
            }
        }

        /// <summary>
        /// Unique identifier of the default queue for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
            }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// Salutation for correspondence with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            get
            {
                return this.GetAttributeValue<string>("salutation");
            }
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Check if user is a setup user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
        public System.Nullable<bool> SetupUser
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("setupuser");
            }
            set
            {
                this.OnPropertyChanging("SetupUser");
                this.SetAttributeValue("setupuser", value);
                this.OnPropertyChanged("SetupUser");
            }
        }

        /// <summary>
        /// Site at which the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid");
            }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Skill set of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            get
            {
                return this.GetAttributeValue<string>("skills");
            }
            set
            {
                this.OnPropertyChanging("Skills");
                this.SetAttributeValue("skills", value);
                this.OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        /// Unique identifier for the user.
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
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.SystemUserId = value;
            }
        }

        /// <summary>
        /// Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public Microsoft.Xrm.Sdk.EntityReference TerritoryId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
            }
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                this.OnPropertyChanged("TerritoryId");
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
        /// Title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get
            {
                return this.GetAttributeValue<string>("title");
            }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
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
        /// Version number of the user.
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
        /// Windows Live ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
        public string WindowsLiveID
        {
            get
            {
                return this.GetAttributeValue<string>("windowsliveid");
            }
            set
            {
                this.OnPropertyChanging("WindowsLiveID");
                this.SetAttributeValue("windowsliveid", value);
                this.OnPropertyChanged("WindowsLiveID");
            }
        }

        /// <summary>
        /// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifirstname");
            }
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            get
            {
                return this.GetAttributeValue<string>("yomifullname");
            }
        }

        /// <summary>
        /// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            get
            {
                return this.GetAttributeValue<string>("yomilastname");
            }
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            get
            {
                return this.GetAttributeValue<string>("yomimiddlename");
            }
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
            }
        }

        /// <summary>
        /// 1:N annotation_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Annotation> annotation_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Annotation>("annotation_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("annotation_owning_user");
                this.SetRelatedEntities<CrmSdk.Annotation>("annotation_owning_user", null, value);
                this.OnPropertyChanged("annotation_owning_user");
            }
        }

        /// <summary>
        /// 1:N constraintbasedgroup_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_systemuser")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> constraintbasedgroup_systemuser
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("constraintbasedgroup_systemuser", null);
            }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_systemuser");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("constraintbasedgroup_systemuser", null, value);
                this.OnPropertyChanged("constraintbasedgroup_systemuser");
            }
        }

        /// <summary>
        /// 1:N contact_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> contact_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("contact_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("contact_owning_user");
                this.SetRelatedEntities<CrmSdk.Contact>("contact_owning_user", null, value);
                this.OnPropertyChanged("contact_owning_user");
            }
        }

        /// <summary>
        /// 1:N createdby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_attributemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AttributeMap> createdby_attributemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AttributeMap>("createdby_attributemap", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_attributemap");
                this.SetRelatedEntities<CrmSdk.AttributeMap>("createdby_attributemap", null, value);
                this.OnPropertyChanged("createdby_attributemap");
            }
        }

        /// <summary>
        /// 1:N createdby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> createdby_connection
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("createdby_connection", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_connection");
                this.SetRelatedEntities<CrmSdk.Connection>("createdby_connection", null, value);
                this.OnPropertyChanged("createdby_connection");
            }
        }

        /// <summary>
        /// 1:N createdby_connection_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection_role")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConnectionRole> createdby_connection_role
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConnectionRole>("createdby_connection_role", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_connection_role");
                this.SetRelatedEntities<CrmSdk.ConnectionRole>("createdby_connection_role", null, value);
                this.OnPropertyChanged("createdby_connection_role");
            }
        }

        /// <summary>
        /// 1:N createdby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerRelationship> createdby_customer_relationship
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerRelationship>("createdby_customer_relationship", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_customer_relationship");
                this.SetRelatedEntities<CrmSdk.CustomerRelationship>("createdby_customer_relationship", null, value);
                this.OnPropertyChanged("createdby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N createdby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_entitymap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.EntityMap> createdby_entitymap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.EntityMap>("createdby_entitymap", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_entitymap");
                this.SetRelatedEntities<CrmSdk.EntityMap>("createdby_entitymap", null, value);
                this.OnPropertyChanged("createdby_entitymap");
            }
        }

        /// <summary>
        /// 1:N createdby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_pluginassembly")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginAssembly> createdby_pluginassembly
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginAssembly>("createdby_pluginassembly", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_pluginassembly");
                this.SetRelatedEntities<CrmSdk.PluginAssembly>("createdby_pluginassembly", null, value);
                this.OnPropertyChanged("createdby_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N createdby_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintype")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> createdby_plugintype
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("createdby_plugintype", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_plugintype");
                this.SetRelatedEntities<CrmSdk.PluginType>("createdby_plugintype", null, value);
                this.OnPropertyChanged("createdby_plugintype");
            }
        }

        /// <summary>
        /// 1:N createdby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginTypeStatistic> createdby_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginTypeStatistic>("createdby_plugintypestatistic", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_plugintypestatistic");
                this.SetRelatedEntities<CrmSdk.PluginTypeStatistic>("createdby_plugintypestatistic", null, value);
                this.OnPropertyChanged("createdby_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N createdby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRole> createdby_relationship_role
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRole>("createdby_relationship_role", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_relationship_role");
                this.SetRelatedEntities<CrmSdk.RelationshipRole>("createdby_relationship_role", null, value);
                this.OnPropertyChanged("createdby_relationship_role");
            }
        }

        /// <summary>
        /// 1:N createdby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role_map")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRoleMap> createdby_relationship_role_map
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRoleMap>("createdby_relationship_role_map", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_relationship_role_map");
                this.SetRelatedEntities<CrmSdk.RelationshipRoleMap>("createdby_relationship_role_map", null, value);
                this.OnPropertyChanged("createdby_relationship_role_map");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessage> createdby_sdkmessage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessage>("createdby_sdkmessage", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessage");
                this.SetRelatedEntities<CrmSdk.SdkMessage>("createdby_sdkmessage", null, value);
                this.OnPropertyChanged("createdby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageFilter> createdby_sdkmessagefilter
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageFilter>("createdby_sdkmessagefilter", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagefilter");
                this.SetRelatedEntities<CrmSdk.SdkMessageFilter>("createdby_sdkmessagefilter", null, value);
                this.OnPropertyChanged("createdby_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessagePair> createdby_sdkmessagepair
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessagePair>("createdby_sdkmessagepair", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagepair");
                this.SetRelatedEntities<CrmSdk.SdkMessagePair>("createdby_sdkmessagepair", null, value);
                this.OnPropertyChanged("createdby_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> createdby_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> createdby_sdkmessageprocessingstepimage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepSecureConfig> createdby_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequest> createdby_sdkmessagerequest
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequest>("createdby_sdkmessagerequest", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagerequest");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequest>("createdby_sdkmessagerequest", null, value);
                this.OnPropertyChanged("createdby_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequestField> createdby_sdkmessagerequestfield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequestField>("createdby_sdkmessagerequestfield", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagerequestfield");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequestField>("createdby_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("createdby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponse> createdby_sdkmessageresponse
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponse>("createdby_sdkmessageresponse", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageresponse");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponse>("createdby_sdkmessageresponse", null, value);
                this.OnPropertyChanged("createdby_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponseField> createdby_sdkmessageresponsefield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponseField>("createdby_sdkmessageresponsefield", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageresponsefield");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponseField>("createdby_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("createdby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N createdby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceEndpoint> createdby_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceEndpoint>("createdby_serviceendpoint", null);
            }
            set
            {
                this.OnPropertyChanging("createdby_serviceendpoint");
                this.SetRelatedEntities<CrmSdk.ServiceEndpoint>("createdby_serviceendpoint", null, value);
                this.OnPropertyChanged("createdby_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N createdonbehalfby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_attributemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AttributeMap> createdonbehalfby_attributemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AttributeMap>("createdonbehalfby_attributemap", null);
            }
            set
            {
                this.OnPropertyChanging("createdonbehalfby_attributemap");
                this.SetRelatedEntities<CrmSdk.AttributeMap>("createdonbehalfby_attributemap", null, value);
                this.OnPropertyChanged("createdonbehalfby_attributemap");
            }
        }

        /// <summary>
        /// 1:N createdonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerRelationship> createdonbehalfby_customer_relationship
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerRelationship>("createdonbehalfby_customer_relationship", null);
            }
            set
            {
                this.OnPropertyChanging("createdonbehalfby_customer_relationship");
                this.SetRelatedEntities<CrmSdk.CustomerRelationship>("createdonbehalfby_customer_relationship", null, value);
                this.OnPropertyChanged("createdonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N equipment_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_systemuser")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> equipment_systemuser
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("equipment_systemuser", null);
            }
            set
            {
                this.OnPropertyChanging("equipment_systemuser");
                this.SetRelatedEntities<CrmSdk.Equipment>("equipment_systemuser", null, value);
                this.OnPropertyChanged("equipment_systemuser");
            }
        }

        /// <summary>
        /// 1:N impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("impersonatinguserid_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> impersonatinguserid_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N ImportFile_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_SystemUser")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> ImportFile_SystemUser
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("ImportFile_SystemUser", null);
            }
            set
            {
                this.OnPropertyChanging("ImportFile_SystemUser");
                this.SetRelatedEntities<CrmSdk.ImportFile>("ImportFile_SystemUser", null, value);
                this.OnPropertyChanged("ImportFile_SystemUser");
            }
        }

        /// <summary>
        /// 1:N lead_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Lead> lead_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Lead>("lead_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("lead_owning_user");
                this.SetRelatedEntities<CrmSdk.Lead>("lead_owning_user", null, value);
                this.OnPropertyChanged("lead_owning_user");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> lk_accountbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("lk_accountbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdby");
                this.SetRelatedEntities<CrmSdk.Account>("lk_accountbase_createdby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> lk_accountbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("lk_accountbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Account>("lk_accountbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> lk_accountbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("lk_accountbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Account>("lk_accountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> lk_accountbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("lk_accountbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Account>("lk_accountbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityPointer> lk_activitypointer_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_createdby");
                this.SetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_createdby", null, value);
                this.OnPropertyChanged("lk_activitypointer_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityPointer> lk_activitypointer_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_activitypointer_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityPointer> lk_activitypointer_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_modifiedby");
                this.SetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_modifiedby", null, value);
                this.OnPropertyChanged("lk_activitypointer_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityPointer> lk_activitypointer_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_activitypointer_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Annotation> lk_annotationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_createdby");
                this.SetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_createdby", null, value);
                this.OnPropertyChanged("lk_annotationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Annotation> lk_annotationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_annotationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Annotation> lk_annotationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_annotationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Annotation> lk_annotationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Annotation>("lk_annotationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_annotationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AnnualFiscalCalendar> lk_annualfiscalcalendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_createdby");
                this.SetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AnnualFiscalCalendar> lk_annualfiscalcalendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AnnualFiscalCalendar> lk_annualfiscalcalendar_salespersonid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_salespersonid");
                this.SetRelatedEntities<CrmSdk.AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Appointment> lk_appointment_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Appointment>("lk_appointment_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_appointment_createdby");
                this.SetRelatedEntities<CrmSdk.Appointment>("lk_appointment_createdby", null, value);
                this.OnPropertyChanged("lk_appointment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Appointment> lk_appointment_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Appointment>("lk_appointment_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_appointment_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Appointment>("lk_appointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Appointment> lk_appointment_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Appointment>("lk_appointment_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedby");
                this.SetRelatedEntities<CrmSdk.Appointment>("lk_appointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Appointment> lk_appointment_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Appointment>("lk_appointment_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Appointment>("lk_appointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> lk_asyncoperation_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_createdby");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_createdby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> lk_asyncoperation_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> lk_asyncoperation_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_modifiedby");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_modifiedby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> lk_asyncoperation_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_audit_callinguserid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_callinguserid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Audit> lk_audit_callinguserid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Audit>("lk_audit_callinguserid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_audit_callinguserid");
                this.SetRelatedEntities<CrmSdk.Audit>("lk_audit_callinguserid", null, value);
                this.OnPropertyChanged("lk_audit_callinguserid");
            }
        }

        /// <summary>
        /// 1:N lk_audit_userid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_userid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Audit> lk_audit_userid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Audit>("lk_audit_userid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_audit_userid");
                this.SetRelatedEntities<CrmSdk.Audit>("lk_audit_userid", null, value);
                this.OnPropertyChanged("lk_audit_userid");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteOperation> lk_bulkdeleteoperation_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperation_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteOperation> lk_bulkdeleteoperation_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperation_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteOperation> lk_bulkdeleteoperationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperationbase_createdby");
                this.SetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteOperation> lk_bulkdeleteoperationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperationbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkOperation> lk_BulkOperation_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_createdby");
                this.SetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_createdby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkOperation> lk_BulkOperation_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkOperation> lk_BulkOperation_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_modifiedby");
                this.SetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_modifiedby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkOperation> lk_BulkOperation_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.BulkOperation>("lk_BulkOperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunit_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnit> lk_businessunit_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunit_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunit_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunit_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunit_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunit_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnit> lk_businessunit_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunit_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunit_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnit> lk_businessunitbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunitbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitbase_createdby");
                this.SetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunitbase_createdby", null, value);
                this.OnPropertyChanged("lk_businessunitbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnit> lk_businessunitbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunitbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.BusinessUnit>("lk_businessunitbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_businessunitbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnitNewsArticle> lk_businessunitnewsarticle_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticle_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticle_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnitNewsArticle> lk_businessunitnewsarticle_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticle_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticlebase_createdby");
                this.SetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticlebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticlebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticlebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Calendar> lk_calendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Calendar>("lk_calendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_calendar_createdby");
                this.SetRelatedEntities<CrmSdk.Calendar>("lk_calendar_createdby", null, value);
                this.OnPropertyChanged("lk_calendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Calendar> lk_calendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Calendar>("lk_calendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_calendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Calendar>("lk_calendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_calendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Calendar> lk_calendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Calendar>("lk_calendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_calendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.Calendar>("lk_calendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_calendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Calendar> lk_calendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Calendar>("lk_calendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_calendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Calendar>("lk_calendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_calendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Campaign> lk_campaign_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Campaign>("lk_campaign_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaign_createdby");
                this.SetRelatedEntities<CrmSdk.Campaign>("lk_campaign_createdby", null, value);
                this.OnPropertyChanged("lk_campaign_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Campaign> lk_campaign_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Campaign>("lk_campaign_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaign_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Campaign>("lk_campaign_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaign_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Campaign> lk_campaign_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Campaign>("lk_campaign_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaign_modifiedby");
                this.SetRelatedEntities<CrmSdk.Campaign>("lk_campaign_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaign_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Campaign> lk_campaign_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Campaign>("lk_campaign_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaign_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Campaign>("lk_campaign_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaign_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignActivity> lk_campaignactivity_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_createdby");
                this.SetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_createdby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignActivity> lk_campaignactivity_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignActivity> lk_campaignactivity_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_modifiedby");
                this.SetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignActivity> lk_campaignactivity_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignResponse> lk_campaignresponse_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_createdby");
                this.SetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_createdby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignResponse> lk_campaignresponse_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignResponse> lk_campaignresponse_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_modifiedby");
                this.SetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignResponse> lk_campaignresponse_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ColumnMapping> lk_columnmapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_createdby");
                this.SetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_createdby", null, value);
                this.OnPropertyChanged("lk_columnmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ColumnMapping> lk_columnmapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_columnmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ColumnMapping> lk_columnmapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_columnmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ColumnMapping> lk_columnmapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_columnmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitor_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Competitor> lk_competitor_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Competitor>("lk_competitor_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_competitor_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Competitor>("lk_competitor_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_competitor_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitor_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Competitor> lk_competitor_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Competitor>("lk_competitor_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_competitor_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Competitor>("lk_competitor_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_competitor_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitorbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Competitor> lk_competitorbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Competitor>("lk_competitorbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_competitorbase_createdby");
                this.SetRelatedEntities<CrmSdk.Competitor>("lk_competitorbase_createdby", null, value);
                this.OnPropertyChanged("lk_competitorbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_competitorbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Competitor> lk_competitorbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Competitor>("lk_competitorbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_competitorbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Competitor>("lk_competitorbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_competitorbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> lk_connectionbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("lk_connectionbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_connectionbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Connection>("lk_connectionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> lk_connectionbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("lk_connectionbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_connectionbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Connection>("lk_connectionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionrolebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConnectionRole> lk_connectionrolebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_connectionrolebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionrolebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionrolebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConnectionRole> lk_connectionrolebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_connectionrolebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionrolebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> lk_constraintbasedgroup_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_createdby");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_createdby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> lk_constraintbasedgroup_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> lk_constraintbasedgroup_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_modifiedby");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConstraintBasedGroup> lk_constraintbasedgroup_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> lk_contact_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("lk_contact_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contact_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Contact>("lk_contact_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> lk_contact_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("lk_contact_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Contact>("lk_contact_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> lk_contactbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("lk_contactbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contactbase_createdby");
                this.SetRelatedEntities<CrmSdk.Contact>("lk_contactbase_createdby", null, value);
                this.OnPropertyChanged("lk_contactbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> lk_contactbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("lk_contactbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contactbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Contact>("lk_contactbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contactbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contract_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contract> lk_contract_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contract>("lk_contract_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contract_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Contract>("lk_contract_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contract_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contract_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contract> lk_contract_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contract>("lk_contract_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contract_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Contract>("lk_contract_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contract_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contract> lk_contractbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contract>("lk_contractbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractbase_createdby");
                this.SetRelatedEntities<CrmSdk.Contract>("lk_contractbase_createdby", null, value);
                this.OnPropertyChanged("lk_contractbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contractbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contract> lk_contractbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contract>("lk_contractbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Contract>("lk_contractbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contractbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractDetail> lk_contractdetail_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetail_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractdetail_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contractdetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractDetail> lk_contractdetail_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetail_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractdetail_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contractdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractDetail> lk_contractdetailbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetailbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractdetailbase_createdby");
                this.SetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_contractdetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractDetail> lk_contractdetailbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetailbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contractdetailbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ContractDetail>("lk_contractdetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contractdetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractTemplate> lk_contracttemplate_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplate_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contracttemplate_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contracttemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractTemplate> lk_contracttemplate_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contracttemplate_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contracttemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractTemplate> lk_contracttemplatebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplatebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contracttemplatebase_createdby");
                this.SetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_contracttemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ContractTemplate> lk_contracttemplatebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplatebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_contracttemplatebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ContractTemplate>("lk_contracttemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contracttemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddress_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerAddress> lk_customeraddress_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddress_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeraddress_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddress_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeraddress_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddress_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerAddress> lk_customeraddress_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeraddress_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeraddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerAddress> lk_customeraddressbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddressbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeraddressbase_createdby");
                this.SetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_customeraddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerAddress> lk_customeraddressbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddressbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeraddressbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.CustomerAddress>("lk_customeraddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_customeraddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerOpportunityRole> lk_customeropportunityrole_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_createdby");
                this.SetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_createdby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerOpportunityRole> lk_customeropportunityrole_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerOpportunityRole> lk_customeropportunityrole_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_modifiedby");
                this.SetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerOpportunityRole> lk_customeropportunityrole_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discount_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Discount> lk_discount_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Discount>("lk_discount_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discount_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Discount>("lk_discount_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_discount_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discount_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Discount> lk_discount_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Discount>("lk_discount_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discount_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Discount>("lk_discount_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_discount_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Discount> lk_discountbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Discount>("lk_discountbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discountbase_createdby");
                this.SetRelatedEntities<CrmSdk.Discount>("lk_discountbase_createdby", null, value);
                this.OnPropertyChanged("lk_discountbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_discountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Discount> lk_discountbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Discount>("lk_discountbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discountbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Discount>("lk_discountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_discountbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttype_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DiscountType> lk_discounttype_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DiscountType>("lk_discounttype_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discounttype_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.DiscountType>("lk_discounttype_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_discounttype_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttype_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DiscountType> lk_discounttype_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DiscountType>("lk_discounttype_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discounttype_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.DiscountType>("lk_discounttype_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_discounttype_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttypebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DiscountType> lk_discounttypebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DiscountType>("lk_discounttypebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discounttypebase_createdby");
                this.SetRelatedEntities<CrmSdk.DiscountType>("lk_discounttypebase_createdby", null, value);
                this.OnPropertyChanged("lk_discounttypebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttypebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DiscountType> lk_discounttypebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DiscountType>("lk_discounttypebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_discounttypebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.DiscountType>("lk_discounttypebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_discounttypebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DisplayString> lk_DisplayStringbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_createdby");
                this.SetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_createdby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DisplayString> lk_DisplayStringbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DisplayString> lk_DisplayStringbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DisplayString> lk_DisplayStringbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRule> lk_duplicaterule_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterule_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterule_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRule> lk_duplicaterule_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterule_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterule_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRule> lk_duplicaterulebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterulebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulebase_createdby");
                this.SetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterulebase_createdby", null, value);
                this.OnPropertyChanged("lk_duplicaterulebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRule> lk_duplicaterulebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterulebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.DuplicateRule>("lk_duplicaterulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_duplicaterulebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulecondition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRuleCondition> lk_duplicaterulecondition_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulecondition_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterulecondition_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulecondition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRuleCondition> lk_duplicaterulecondition_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulecondition_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterulecondition_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicateruleconditionbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRuleCondition> lk_duplicateruleconditionbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicateruleconditionbase_createdby");
                this.SetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null, value);
                this.OnPropertyChanged("lk_duplicateruleconditionbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicateruleconditionbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRuleCondition> lk_duplicateruleconditionbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_duplicateruleconditionbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_duplicateruleconditionbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Email> lk_email_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Email>("lk_email_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_email_createdby");
                this.SetRelatedEntities<CrmSdk.Email>("lk_email_createdby", null, value);
                this.OnPropertyChanged("lk_email_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Email> lk_email_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Email>("lk_email_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_email_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Email>("lk_email_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Email> lk_email_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Email>("lk_email_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_email_modifiedby");
                this.SetRelatedEntities<CrmSdk.Email>("lk_email_modifiedby", null, value);
                this.OnPropertyChanged("lk_email_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Email> lk_email_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Email>("lk_email_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_email_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Email>("lk_email_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitymap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.EntityMap> lk_entitymap_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.EntityMap>("lk_entitymap_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_entitymap_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.EntityMap>("lk_entitymap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitymap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitymap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.EntityMap> lk_entitymap_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.EntityMap>("lk_entitymap_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_entitymap_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.EntityMap>("lk_entitymap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitymap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> lk_equipment_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("lk_equipment_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_equipment_createdby");
                this.SetRelatedEntities<CrmSdk.Equipment>("lk_equipment_createdby", null, value);
                this.OnPropertyChanged("lk_equipment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> lk_equipment_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("lk_equipment_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_equipment_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Equipment>("lk_equipment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_equipment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> lk_equipment_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("lk_equipment_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_equipment_modifiedby");
                this.SetRelatedEntities<CrmSdk.Equipment>("lk_equipment_modifiedby", null, value);
                this.OnPropertyChanged("lk_equipment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Equipment> lk_equipment_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Equipment>("lk_equipment_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_equipment_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Equipment>("lk_equipment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_equipment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Fax> lk_fax_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Fax>("lk_fax_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fax_createdby");
                this.SetRelatedEntities<CrmSdk.Fax>("lk_fax_createdby", null, value);
                this.OnPropertyChanged("lk_fax_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Fax> lk_fax_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Fax>("lk_fax_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fax_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Fax>("lk_fax_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fax_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Fax> lk_fax_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Fax>("lk_fax_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fax_modifiedby");
                this.SetRelatedEntities<CrmSdk.Fax>("lk_fax_modifiedby", null, value);
                this.OnPropertyChanged("lk_fax_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Fax> lk_fax_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Fax>("lk_fax_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fax_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Fax>("lk_fax_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fax_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> lk_fieldsecurityprofile_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_createdby");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> lk_fieldsecurityprofile_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> lk_fieldsecurityprofile_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedby");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> lk_fieldsecurityprofile_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdby");
                this.SetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_salespersonid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<CrmSdk.FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_goal_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> lk_goal_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("lk_goal_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goal_createdby");
                this.SetRelatedEntities<CrmSdk.Goal>("lk_goal_createdby", null, value);
                this.OnPropertyChanged("lk_goal_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> lk_goal_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("lk_goal_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goal_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Goal>("lk_goal_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_goal_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> lk_goal_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("lk_goal_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goal_modifiedby");
                this.SetRelatedEntities<CrmSdk.Goal>("lk_goal_modifiedby", null, value);
                this.OnPropertyChanged("lk_goal_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> lk_goal_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("lk_goal_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goal_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Goal>("lk_goal_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_goal_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.GoalRollupQuery> lk_goalrollupquery_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_createdby");
                this.SetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_createdby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.GoalRollupQuery> lk_goalrollupquery_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.GoalRollupQuery> lk_goalrollupquery_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_modifiedby");
                this.SetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_modifiedby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.GoalRollupQuery> lk_goalrollupquery_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.GoalRollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_import_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Import> lk_import_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Import>("lk_import_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_import_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Import>("lk_import_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_import_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_import_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Import> lk_import_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Import>("lk_import_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_import_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Import>("lk_import_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_import_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Import> lk_importbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Import>("lk_importbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importbase_createdby");
                this.SetRelatedEntities<CrmSdk.Import>("lk_importbase_createdby", null, value);
                this.OnPropertyChanged("lk_importbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Import> lk_importbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Import>("lk_importbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Import>("lk_importbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportEntityMapping> lk_importentitymapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_createdby");
                this.SetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_createdby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportEntityMapping> lk_importentitymapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportEntityMapping> lk_importentitymapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportEntityMapping> lk_importentitymapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> lk_importfilebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_createdby");
                this.SetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_createdby", null, value);
                this.OnPropertyChanged("lk_importfilebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> lk_importfilebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importfilebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> lk_importfilebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importfilebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> lk_importfilebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportFile>("lk_importfilebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importfilebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportJob> lk_importjobbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_createdby");
                this.SetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_createdby", null, value);
                this.OnPropertyChanged("lk_importjobbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportJob> lk_importjobbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importjobbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportJob> lk_importjobbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importjobbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportJob> lk_importjobbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportJob>("lk_importjobbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importjobbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportLog> lk_importlog_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportLog>("lk_importlog_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importlog_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportLog>("lk_importlog_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importlog_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportLog> lk_importlog_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportLog>("lk_importlog_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importlog_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportLog>("lk_importlog_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlogbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportLog> lk_importlogbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportLog>("lk_importlogbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importlogbase_createdby");
                this.SetRelatedEntities<CrmSdk.ImportLog>("lk_importlogbase_createdby", null, value);
                this.OnPropertyChanged("lk_importlogbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importlogbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportLog> lk_importlogbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportLog>("lk_importlogbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importlogbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ImportLog>("lk_importlogbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importlogbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importmap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportMap> lk_importmap_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportMap>("lk_importmap_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importmap_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportMap>("lk_importmap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importmap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importmap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportMap> lk_importmap_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportMap>("lk_importmap_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importmap_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ImportMap>("lk_importmap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importmap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importmapbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportMap> lk_importmapbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportMap>("lk_importmapbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importmapbase_createdby");
                this.SetRelatedEntities<CrmSdk.ImportMap>("lk_importmapbase_createdby", null, value);
                this.OnPropertyChanged("lk_importmapbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importmapbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportMap> lk_importmapbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportMap>("lk_importmapbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_importmapbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ImportMap>("lk_importmapbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importmapbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Incident> lk_incidentbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_createdby");
                this.SetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_createdby", null, value);
                this.OnPropertyChanged("lk_incidentbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Incident> lk_incidentbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Incident> lk_incidentbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_incidentbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Incident> lk_incidentbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Incident>("lk_incidentbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IncidentResolution> lk_incidentresolution_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_createdby");
                this.SetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_createdby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IncidentResolution> lk_incidentresolution_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IncidentResolution> lk_incidentresolution_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_modifiedby");
                this.SetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_modifiedby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IncidentResolution> lk_incidentresolution_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoice_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Invoice> lk_invoice_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Invoice>("lk_invoice_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoice_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Invoice>("lk_invoice_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoice_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoice_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Invoice> lk_invoice_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Invoice>("lk_invoice_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoice_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Invoice>("lk_invoice_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoice_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Invoice> lk_invoicebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Invoice>("lk_invoicebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicebase_createdby");
                this.SetRelatedEntities<CrmSdk.Invoice>("lk_invoicebase_createdby", null, value);
                this.OnPropertyChanged("lk_invoicebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Invoice> lk_invoicebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Invoice>("lk_invoicebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Invoice>("lk_invoicebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_invoicebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.InvoiceDetail> lk_invoicedetail_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetail_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicedetail_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoicedetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.InvoiceDetail> lk_invoicedetail_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetail_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicedetail_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoicedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.InvoiceDetail> lk_invoicedetailbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetailbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicedetailbase_createdby");
                this.SetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_invoicedetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.InvoiceDetail> lk_invoicedetailbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetailbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_invoicedetailbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.InvoiceDetail>("lk_invoicedetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_invoicedetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IsvConfig> lk_isvconfig_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfig_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_isvconfig_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_isvconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IsvConfig> lk_isvconfig_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfig_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_isvconfig_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_isvconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfigbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IsvConfig> lk_isvconfigbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfigbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_isvconfigbase_createdby");
                this.SetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfigbase_createdby", null, value);
                this.OnPropertyChanged("lk_isvconfigbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfigbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IsvConfig> lk_isvconfigbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfigbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_isvconfigbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.IsvConfig>("lk_isvconfigbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_isvconfigbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticle> lk_kbarticle_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticle_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticle_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticle_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticle_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticle> lk_kbarticle_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticle_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticle_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticle_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticle> lk_kbarticlebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticlebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlebase_createdby");
                this.SetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticlebase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticlebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticle> lk_kbarticlebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticlebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.KbArticle>("lk_kbarticlebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticlebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleComment> lk_kbarticlecomment_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecomment_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecomment_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecomment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticlecomment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecomment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleComment> lk_kbarticlecomment_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecomment_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticlecomment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecommentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleComment> lk_kbarticlecommentbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecommentbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecommentbase_createdby");
                this.SetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecommentbase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticlecommentbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecommentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleComment> lk_kbarticlecommentbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecommentbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecommentbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.KbArticleComment>("lk_kbarticlecommentbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticlecommentbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleTemplate> lk_kbarticletemplate_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplate_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleTemplate> lk_kbarticletemplate_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplate_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleTemplate> lk_kbarticletemplatebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplatebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplatebase_createdby");
                this.SetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.KbArticleTemplate> lk_kbarticletemplatebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplatebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.KbArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_lead_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Lead> lk_lead_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Lead>("lk_lead_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lead_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Lead>("lk_lead_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_lead_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lead_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Lead> lk_lead_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Lead>("lk_lead_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lead_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Lead>("lk_lead_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_lead_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddress_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LeadAddress> lk_leadaddress_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddress_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadaddress_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddress_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_leadaddress_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddress_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LeadAddress> lk_leadaddress_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddress_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadaddress_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddress_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_leadaddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LeadAddress> lk_leadaddressbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddressbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadaddressbase_createdby");
                this.SetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_leadaddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LeadAddress> lk_leadaddressbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddressbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadaddressbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.LeadAddress>("lk_leadaddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_leadaddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_leadbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Lead> lk_leadbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Lead>("lk_leadbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadbase_createdby");
                this.SetRelatedEntities<CrmSdk.Lead>("lk_leadbase_createdby", null, value);
                this.OnPropertyChanged("lk_leadbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_leadbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Lead> lk_leadbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Lead>("lk_leadbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_leadbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Lead>("lk_leadbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_leadbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Letter> lk_letter_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Letter>("lk_letter_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_letter_createdby");
                this.SetRelatedEntities<CrmSdk.Letter>("lk_letter_createdby", null, value);
                this.OnPropertyChanged("lk_letter_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Letter> lk_letter_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Letter>("lk_letter_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_letter_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Letter>("lk_letter_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_letter_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Letter> lk_letter_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Letter>("lk_letter_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_letter_modifiedby");
                this.SetRelatedEntities<CrmSdk.Letter>("lk_letter_modifiedby", null, value);
                this.OnPropertyChanged("lk_letter_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Letter> lk_letter_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Letter>("lk_letter_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_letter_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Letter>("lk_letter_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_letter_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_list_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.List> lk_list_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.List>("lk_list_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_list_createdby");
                this.SetRelatedEntities<CrmSdk.List>("lk_list_createdby", null, value);
                this.OnPropertyChanged("lk_list_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_list_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.List> lk_list_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.List>("lk_list_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_list_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.List>("lk_list_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_list_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_list_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.List> lk_list_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.List>("lk_list_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_list_modifiedby");
                this.SetRelatedEntities<CrmSdk.List>("lk_list_modifiedby", null, value);
                this.OnPropertyChanged("lk_list_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_list_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.List> lk_list_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.List>("lk_list_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_list_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.List>("lk_list_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_list_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ListMember> lk_listmember_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ListMember>("lk_listmember_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_listmember_createdby");
                this.SetRelatedEntities<CrmSdk.ListMember>("lk_listmember_createdby", null, value);
                this.OnPropertyChanged("lk_listmember_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ListMember> lk_listmember_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ListMember>("lk_listmember_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_listmember_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ListMember>("lk_listmember_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_listmember_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ListMember> lk_listmember_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ListMember>("lk_listmember_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_listmember_modifiedby");
                this.SetRelatedEntities<CrmSdk.ListMember>("lk_listmember_modifiedby", null, value);
                this.OnPropertyChanged("lk_listmember_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ListMember> lk_listmember_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ListMember>("lk_listmember_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_listmember_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ListMember>("lk_listmember_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_listmember_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LookUpMapping> lk_lookupmapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_createdby");
                this.SetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_createdby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LookUpMapping> lk_lookupmapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LookUpMapping> lk_lookupmapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.LookUpMapping> lk_lookupmapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.LookUpMapping>("lk_lookupmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MailMergeTemplate> lk_mailmergetemplate_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplate_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MailMergeTemplate> lk_mailmergetemplate_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplate_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MailMergeTemplate> lk_mailmergetemplatebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplatebase_createdby");
                this.SetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MailMergeTemplate> lk_mailmergetemplatebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplatebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Metric> lk_metric_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Metric>("lk_metric_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_metric_createdby");
                this.SetRelatedEntities<CrmSdk.Metric>("lk_metric_createdby", null, value);
                this.OnPropertyChanged("lk_metric_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Metric> lk_metric_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Metric>("lk_metric_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_metric_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Metric>("lk_metric_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_metric_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Metric> lk_metric_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Metric>("lk_metric_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_metric_modifiedby");
                this.SetRelatedEntities<CrmSdk.Metric>("lk_metric_modifiedby", null, value);
                this.OnPropertyChanged("lk_metric_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Metric> lk_metric_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Metric>("lk_metric_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_metric_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Metric>("lk_metric_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_metric_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_createdby");
                this.SetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_salespersonid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<CrmSdk.MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Opportunity> lk_opportunity_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Opportunity>("lk_opportunity_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunity_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Opportunity>("lk_opportunity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Opportunity> lk_opportunity_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Opportunity>("lk_opportunity_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Opportunity>("lk_opportunity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Opportunity> lk_opportunitybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Opportunity>("lk_opportunitybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_createdby");
                this.SetRelatedEntities<CrmSdk.Opportunity>("lk_opportunitybase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Opportunity> lk_opportunitybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Opportunity>("lk_opportunitybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Opportunity>("lk_opportunitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityClose> lk_opportunityclose_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_createdby");
                this.SetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_createdby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityClose> lk_opportunityclose_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityClose> lk_opportunityclose_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_modifiedby");
                this.SetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityClose> lk_opportunityclose_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproduct_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityProduct> lk_opportunityproduct_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityproduct_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityproduct_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproduct_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityProduct> lk_opportunityproduct_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityproduct_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityproduct_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproductbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityProduct> lk_opportunityproductbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproductbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityproductbase_createdby");
                this.SetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproductbase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunityproductbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproductbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityProduct> lk_opportunityproductbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproductbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_opportunityproductbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.OpportunityProduct>("lk_opportunityproductbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunityproductbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OrderClose> lk_orderclose_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_orderclose_createdby");
                this.SetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_createdby", null, value);
                this.OnPropertyChanged("lk_orderclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OrderClose> lk_orderclose_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_orderclose_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orderclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OrderClose> lk_orderclose_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_orderclose_modifiedby");
                this.SetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_orderclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OrderClose> lk_orderclose_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_orderclose_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.OrderClose>("lk_orderclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orderclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organization_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Organization> lk_organization_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Organization>("lk_organization_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_organization_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Organization>("lk_organization_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_organization_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organization_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Organization> lk_organization_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Organization>("lk_organization_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_organization_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Organization>("lk_organization_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_organization_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Organization> lk_organizationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Organization>("lk_organizationbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_organizationbase_createdby");
                this.SetRelatedEntities<CrmSdk.Organization>("lk_organizationbase_createdby", null, value);
                this.OnPropertyChanged("lk_organizationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_organizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Organization> lk_organizationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Organization>("lk_organizationbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_organizationbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Organization>("lk_organizationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_organizationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OwnerMapping> lk_ownermapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_createdby");
                this.SetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_createdby", null, value);
                this.OnPropertyChanged("lk_ownermapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OwnerMapping> lk_ownermapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_ownermapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OwnerMapping> lk_ownermapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_ownermapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OwnerMapping> lk_ownermapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_ownermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PhoneCall> lk_phonecall_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_phonecall_createdby");
                this.SetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_createdby", null, value);
                this.OnPropertyChanged("lk_phonecall_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PhoneCall> lk_phonecall_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_phonecall_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_phonecall_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PhoneCall> lk_phonecall_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_phonecall_modifiedby");
                this.SetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_modifiedby", null, value);
                this.OnPropertyChanged("lk_phonecall_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PhoneCall> lk_phonecall_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_phonecall_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PhoneCall>("lk_phonecall_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_phonecall_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PickListMapping> lk_picklistmapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_createdby");
                this.SetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_createdby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PickListMapping> lk_picklistmapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PickListMapping> lk_picklistmapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PickListMapping> lk_picklistmapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PickListMapping>("lk_picklistmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pluginassembly_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginAssembly> lk_pluginassembly_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginAssembly>("lk_pluginassembly_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pluginassembly_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginAssembly>("lk_pluginassembly_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_pluginassembly_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pluginassembly_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginAssembly> lk_pluginassembly_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pluginassembly_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_pluginassembly_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintype_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintype_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> lk_plugintype_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("lk_plugintype_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_plugintype_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginType>("lk_plugintype_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintype_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintype_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintype_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> lk_plugintype_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("lk_plugintype_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_plugintype_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginType>("lk_plugintype_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintype_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintypestatisticbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginTypeStatistic> lk_plugintypestatisticbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_plugintypestatisticbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintypestatisticbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintypestatisticbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginTypeStatistic> lk_plugintypestatisticbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_plugintypestatisticbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintypestatisticbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_post_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Post> lk_post_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Post>("lk_post_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_post_createdby");
                this.SetRelatedEntities<CrmSdk.Post>("lk_post_createdby", null, value);
                this.OnPropertyChanged("lk_post_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_post_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Post> lk_post_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Post>("lk_post_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_post_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Post>("lk_post_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_post_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_post_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Post> lk_post_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Post>("lk_post_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_post_modifiedby");
                this.SetRelatedEntities<CrmSdk.Post>("lk_post_modifiedby", null, value);
                this.OnPropertyChanged("lk_post_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_post_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Post> lk_post_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Post>("lk_post_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_post_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Post>("lk_post_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_post_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_postcomment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostComment> lk_postcomment_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostComment>("lk_postcomment_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_postcomment_createdby");
                this.SetRelatedEntities<CrmSdk.PostComment>("lk_postcomment_createdby", null, value);
                this.OnPropertyChanged("lk_postcomment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postcomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostComment> lk_postcomment_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostComment>("lk_postcomment_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_postcomment_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PostComment>("lk_postcomment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postcomment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_PostFollow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_PostFollow_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostFollow> lk_PostFollow_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostFollow>("lk_PostFollow_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_PostFollow_createdby");
                this.SetRelatedEntities<CrmSdk.PostFollow>("lk_PostFollow_createdby", null, value);
                this.OnPropertyChanged("lk_PostFollow_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postfollow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postfollow_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostFollow> lk_postfollow_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostFollow>("lk_postfollow_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_postfollow_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PostFollow>("lk_postfollow_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postfollow_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_postlike_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostLike> lk_postlike_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostLike>("lk_postlike_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_postlike_createdby");
                this.SetRelatedEntities<CrmSdk.PostLike>("lk_postlike_createdby", null, value);
                this.OnPropertyChanged("lk_postlike_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postlike_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostLike> lk_postlike_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostLike>("lk_postlike_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_postlike_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PostLike>("lk_postlike_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postlike_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PriceLevel> lk_pricelevel_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevel_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pricelevel_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_pricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PriceLevel> lk_pricelevel_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevel_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pricelevel_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_pricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevelbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PriceLevel> lk_pricelevelbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevelbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pricelevelbase_createdby");
                this.SetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevelbase_createdby", null, value);
                this.OnPropertyChanged("lk_pricelevelbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevelbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PriceLevel> lk_pricelevelbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevelbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_pricelevelbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.PriceLevel>("lk_pricelevelbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_pricelevelbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_canceledby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_canceledby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_canceledby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_canceledby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_canceledby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_canceledby", null, value);
                this.OnPropertyChanged("lk_processsession_canceledby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_completedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_completedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_completedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_completedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_completedby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_completedby", null, value);
                this.OnPropertyChanged("lk_processsession_completedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_createdby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_createdby", null, value);
                this.OnPropertyChanged("lk_processsession_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_executedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_executedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_executedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_executedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_executedby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_executedby", null, value);
                this.OnPropertyChanged("lk_processsession_executedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_modifiedby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_modifiedby", null, value);
                this.OnPropertyChanged("lk_processsession_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_startedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_startedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsession_startedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_startedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsession_startedby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsession_startedby", null, value);
                this.OnPropertyChanged("lk_processsession_startedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsessionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsessionbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsessionbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsessionbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsessionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_processsessionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_processsessionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> lk_processsessionbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_processsessionbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_processsessionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Product> lk_product_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Product>("lk_product_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_product_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Product>("lk_product_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Product> lk_product_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Product>("lk_product_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_product_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Product>("lk_product_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Product> lk_productbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Product>("lk_productbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productbase_createdby");
                this.SetRelatedEntities<CrmSdk.Product>("lk_productbase_createdby", null, value);
                this.OnPropertyChanged("lk_productbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Product> lk_productbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Product>("lk_productbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Product>("lk_productbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProductPriceLevel> lk_productpricelevel_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevel_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productpricelevel_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_productpricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProductPriceLevel> lk_productpricelevel_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevel_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productpricelevel_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_productpricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevelbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProductPriceLevel> lk_productpricelevelbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevelbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productpricelevelbase_createdby");
                this.SetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevelbase_createdby", null, value);
                this.OnPropertyChanged("lk_productpricelevelbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevelbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProductPriceLevel> lk_productpricelevelbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevelbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_productpricelevelbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ProductPriceLevel>("lk_productpricelevelbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productpricelevelbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_publisher_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Publisher> lk_publisher_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Publisher>("lk_publisher_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisher_createdby");
                this.SetRelatedEntities<CrmSdk.Publisher>("lk_publisher_createdby", null, value);
                this.OnPropertyChanged("lk_publisher_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_publisher_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Publisher> lk_publisher_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Publisher>("lk_publisher_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisher_modifiedby");
                this.SetRelatedEntities<CrmSdk.Publisher>("lk_publisher_modifiedby", null, value);
                this.OnPropertyChanged("lk_publisher_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PublisherAddress> lk_publisheraddressbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_createdby");
                this.SetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PublisherAddress> lk_publisheraddressbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PublisherAddress> lk_publisheraddressbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PublisherAddress> lk_publisheraddressbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisherbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Publisher> lk_publisherbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Publisher>("lk_publisherbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisherbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Publisher>("lk_publisherbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisherbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisherbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Publisher> lk_publisherbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Publisher>("lk_publisherbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_publisherbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Publisher>("lk_publisherbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisherbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_createdby");
                this.SetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_salespersonid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<CrmSdk.QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_queue_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> lk_queue_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("lk_queue_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queue_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Queue>("lk_queue_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_queue_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queue_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> lk_queue_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("lk_queue_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queue_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Queue>("lk_queue_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_queue_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queuebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> lk_queuebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("lk_queuebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queuebase_createdby");
                this.SetRelatedEntities<CrmSdk.Queue>("lk_queuebase_createdby", null, value);
                this.OnPropertyChanged("lk_queuebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_queuebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> lk_queuebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("lk_queuebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queuebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Queue>("lk_queuebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_queuebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> lk_queueitem_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("lk_queueitem_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queueitem_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.QueueItem>("lk_queueitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_queueitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> lk_queueitem_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("lk_queueitem_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queueitem_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.QueueItem>("lk_queueitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_queueitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> lk_queueitembase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_createdby");
                this.SetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_createdby", null, value);
                this.OnPropertyChanged("lk_queueitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> lk_queueitembase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_modifiedby");
                this.SetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_queueitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_workerid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_workerid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QueueItem> lk_queueitembase_workerid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_workerid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_workerid");
                this.SetRelatedEntities<CrmSdk.QueueItem>("lk_queueitembase_workerid", null, value);
                this.OnPropertyChanged("lk_queueitembase_workerid");
            }
        }

        /// <summary>
        /// 1:N lk_quote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Quote> lk_quote_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Quote>("lk_quote_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quote_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Quote>("lk_quote_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Quote> lk_quote_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Quote>("lk_quote_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quote_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Quote>("lk_quote_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Quote> lk_quotebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Quote>("lk_quotebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotebase_createdby");
                this.SetRelatedEntities<CrmSdk.Quote>("lk_quotebase_createdby", null, value);
                this.OnPropertyChanged("lk_quotebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Quote> lk_quotebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Quote>("lk_quotebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Quote>("lk_quotebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteClose> lk_quoteclose_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_createdby");
                this.SetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_createdby", null, value);
                this.OnPropertyChanged("lk_quoteclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteClose> lk_quoteclose_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quoteclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteClose> lk_quoteclose_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_modifiedby");
                this.SetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_quoteclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteClose> lk_quoteclose_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuoteClose>("lk_quoteclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quoteclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteDetail> lk_quotedetail_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetail_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotedetail_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quotedetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteDetail> lk_quotedetail_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetail_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotedetail_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quotedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteDetail> lk_quotedetailbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetailbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotedetailbase_createdby");
                this.SetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_quotedetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteDetail> lk_quotedetailbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetailbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_quotedetailbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.QuoteDetail>("lk_quotedetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotedetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurrenceRule> lk_recurrencerule_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerule_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurrencerule_createdby");
                this.SetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerule_createdby", null, value);
                this.OnPropertyChanged("lk_recurrencerule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurrenceRule> lk_recurrencerule_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerule_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurrencerule_modifiedby");
                this.SetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerule_modifiedby", null, value);
                this.OnPropertyChanged("lk_recurrencerule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerulebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurrenceRule> lk_recurrencerulebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurrencerulebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurrencerulebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerulebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurrenceRule> lk_recurrencerulebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurrencerulebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurrencerulebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurringAppointmentMaster> lk_recurringappointmentmaster_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_createdby");
                this.SetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurringAppointmentMaster> lk_recurringappointmentmaster_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_modifiedby");
                this.SetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRole> lk_relationshiprole_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRole>("lk_relationshiprole_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_relationshiprole_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.RelationshipRole>("lk_relationshiprole_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprole_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRole> lk_relationshiprole_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_relationshiprole_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprole_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprolemap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRoleMap> lk_relationshiprolemap_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_relationshiprolemap_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprolemap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprolemap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRoleMap> lk_relationshiprolemap_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_relationshiprolemap_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprolemap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_report_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Report> lk_report_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Report>("lk_report_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_report_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Report>("lk_report_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_report_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_report_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Report> lk_report_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Report>("lk_report_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_report_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Report>("lk_report_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_report_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Report> lk_reportbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Report>("lk_reportbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportbase_createdby");
                this.SetRelatedEntities<CrmSdk.Report>("lk_reportbase_createdby", null, value);
                this.OnPropertyChanged("lk_reportbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Report> lk_reportbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Report>("lk_reportbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Report>("lk_reportbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportCategory> lk_reportcategory_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategory_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportcategory_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategory_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportcategory_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportCategory> lk_reportcategory_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategory_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportcategory_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategory_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportcategory_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportCategory> lk_reportcategorybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategorybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportcategorybase_createdby");
                this.SetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategorybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportcategorybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportCategory> lk_reportcategorybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategorybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportcategorybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ReportCategory>("lk_reportcategorybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportcategorybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportEntity> lk_reportentity_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentity_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportentity_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportentity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportEntity> lk_reportentity_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentity_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportentity_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportentity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentitybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportEntity> lk_reportentitybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentitybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportentitybase_createdby");
                this.SetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentitybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportentitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportEntity> lk_reportentitybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentitybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportentitybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ReportEntity>("lk_reportentitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportentitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlink_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportLink> lk_reportlink_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportLink>("lk_reportlink_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportlink_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportLink>("lk_reportlink_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportlink_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlink_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportLink> lk_reportlink_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportLink>("lk_reportlink_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportlink_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportLink>("lk_reportlink_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportlink_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlinkbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportLink> lk_reportlinkbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportLink>("lk_reportlinkbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportlinkbase_createdby");
                this.SetRelatedEntities<CrmSdk.ReportLink>("lk_reportlinkbase_createdby", null, value);
                this.OnPropertyChanged("lk_reportlinkbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlinkbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportLink> lk_reportlinkbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportLink>("lk_reportlinkbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportlinkbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ReportLink>("lk_reportlinkbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportlinkbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibility_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportVisibility> lk_reportvisibility_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibility_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportvisibility_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibility_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportvisibility_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibility_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportVisibility> lk_reportvisibility_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibility_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportvisibility_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibility_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportvisibility_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibilitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportVisibility> lk_reportvisibilitybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibilitybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportvisibilitybase_createdby");
                this.SetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibilitybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportvisibilitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibilitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ReportVisibility> lk_reportvisibilitybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibilitybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_reportvisibilitybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.ReportVisibility>("lk_reportvisibilitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportvisibilitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceSpec> lk_resourcespec_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_createdby");
                this.SetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_createdby", null, value);
                this.OnPropertyChanged("lk_resourcespec_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceSpec> lk_resourcespec_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_resourcespec_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceSpec> lk_resourcespec_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_modifiedby");
                this.SetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_modifiedby", null, value);
                this.OnPropertyChanged("lk_resourcespec_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ResourceSpec> lk_resourcespec_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ResourceSpec>("lk_resourcespec_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_resourcespec_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_role_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> lk_role_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("lk_role_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_role_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Role>("lk_role_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_role_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_role_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> lk_role_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("lk_role_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_role_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Role>("lk_role_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_role_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rolebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> lk_rolebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("lk_rolebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rolebase_createdby");
                this.SetRelatedEntities<CrmSdk.Role>("lk_rolebase_createdby", null, value);
                this.OnPropertyChanged("lk_rolebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rolebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> lk_rolebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("lk_rolebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rolebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Role>("lk_rolebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_rolebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RollupField> lk_rollupfield_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_createdby");
                this.SetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_createdby", null, value);
                this.OnPropertyChanged("lk_rollupfield_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RollupField> lk_rollupfield_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rollupfield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RollupField> lk_rollupfield_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_modifiedby");
                this.SetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_modifiedby", null, value);
                this.OnPropertyChanged("lk_rollupfield_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RollupField> lk_rollupfield_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.RollupField>("lk_rollupfield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rollupfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliterature_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> lk_salesliterature_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliterature_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliterature_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliterature_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliterature_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliterature_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> lk_salesliterature_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliterature_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliterature_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteraturebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> lk_salesliteraturebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliteraturebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteraturebase_createdby");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliteraturebase_createdby", null, value);
                this.OnPropertyChanged("lk_salesliteraturebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteraturebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> lk_salesliteraturebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliteraturebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteraturebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("lk_salesliteraturebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesliteraturebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiteratureItem> lk_salesliteratureitem_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitem_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitem_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiteratureItem> lk_salesliteratureitem_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitem_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitem_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiteratureItem> lk_salesliteratureitembase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitembase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitembase_createdby");
                this.SetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitembase_createdby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiteratureItem> lk_salesliteratureitembase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitembase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitembase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SalesLiteratureItem>("lk_salesliteratureitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorder_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrder> lk_salesorder_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorder_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorder_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorder_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorder_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorder_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrder> lk_salesorder_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorder_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorder_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorder_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorder_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrder> lk_salesorderbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorderbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderbase_createdby");
                this.SetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorderbase_createdby", null, value);
                this.OnPropertyChanged("lk_salesorderbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrder> lk_salesorderbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorderbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SalesOrder>("lk_salesorderbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesorderbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrderDetail> lk_salesorderdetail_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetail_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetail_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorderdetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrderDetail> lk_salesorderdetail_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetail_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetail_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorderdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrderDetail> lk_salesorderdetailbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetailbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetailbase_createdby");
                this.SetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_salesorderdetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrderDetail> lk_salesorderdetailbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetailbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetailbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SalesOrderDetail>("lk_salesorderdetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesorderdetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQuery> lk_savedquery_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquery_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedquery_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQuery> lk_savedquery_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquery_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedquery_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquerybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQuery> lk_savedquerybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquerybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedquerybase_createdby");
                this.SetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquerybase_createdby", null, value);
                this.OnPropertyChanged("lk_savedquerybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquerybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQuery> lk_savedquerybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquerybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedquerybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SavedQuery>("lk_savedquerybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_savedquerybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQueryVisualization> lk_savedqueryvisualizationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_createdby");
                this.SetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQueryVisualization> lk_savedqueryvisualizationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessage> lk_sdkmessage_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessage>("lk_sdkmessage_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessage>("lk_sdkmessage_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessage> lk_sdkmessage_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagefilter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageFilter> lk_sdkmessagefilter_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagefilter_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagefilter_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagefilter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageFilter> lk_sdkmessagefilter_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagefilter_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagefilter_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagepair_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessagePair> lk_sdkmessagepair_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagepair_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagepair_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagepair_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessagePair> lk_sdkmessagepair_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagepair_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagepair_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> lk_sdkmessageprocessingstep_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepimage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequest_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequest> lk_sdkmessagerequest_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequest_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequest_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequest_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequest> lk_sdkmessagerequest_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequest_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequest_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequestfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequestField> lk_sdkmessagerequestfield_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequestfield_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequestfield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequestfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequestField> lk_sdkmessagerequestfield_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequestfield_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequestfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponse> lk_sdkmessageresponse_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponse_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponse_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponse> lk_sdkmessageresponse_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponse_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponsefield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponseField> lk_sdkmessageresponsefield_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponsefield_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponsefield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponsefield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponseField> lk_sdkmessageresponsefield_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponsefield_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponsefield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdby");
                this.SetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedby");
                this.SetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_salespersonid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
                this.SetRelatedEntities<CrmSdk.SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_service_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Service> lk_service_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Service>("lk_service_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_service_createdby");
                this.SetRelatedEntities<CrmSdk.Service>("lk_service_createdby", null, value);
                this.OnPropertyChanged("lk_service_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_service_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Service> lk_service_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Service>("lk_service_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_service_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Service>("lk_service_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_service_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_service_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Service> lk_service_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Service>("lk_service_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_service_modifiedby");
                this.SetRelatedEntities<CrmSdk.Service>("lk_service_modifiedby", null, value);
                this.OnPropertyChanged("lk_service_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_service_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Service> lk_service_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Service>("lk_service_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_service_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Service>("lk_service_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_service_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceAppointment> lk_serviceappointment_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_createdby");
                this.SetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_createdby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceAppointment> lk_serviceappointment_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceAppointment> lk_serviceappointment_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_modifiedby");
                this.SetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceAppointment> lk_serviceappointment_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ServiceAppointment>("lk_serviceappointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceendpointbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceEndpoint> lk_serviceendpointbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceendpointbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceendpointbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceendpointbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceEndpoint> lk_serviceendpointbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_serviceendpointbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceendpointbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_createdby");
                this.SetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointSite> lk_sharepointsitebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_createdby");
                this.SetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_createdby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointSite> lk_sharepointsitebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointSite> lk_sharepointsitebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointSite> lk_sharepointsitebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_site_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Site> lk_site_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Site>("lk_site_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_site_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Site>("lk_site_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_site_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_site_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Site> lk_site_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Site>("lk_site_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_site_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Site>("lk_site_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_site_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Site> lk_sitebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Site>("lk_sitebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sitebase_createdby");
                this.SetRelatedEntities<CrmSdk.Site>("lk_sitebase_createdby", null, value);
                this.OnPropertyChanged("lk_sitebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Site> lk_sitebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Site>("lk_sitebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_sitebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Site>("lk_sitebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sitebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_solution_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Solution> lk_solution_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Solution>("lk_solution_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solution_createdby");
                this.SetRelatedEntities<CrmSdk.Solution>("lk_solution_createdby", null, value);
                this.OnPropertyChanged("lk_solution_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_solution_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Solution> lk_solution_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Solution>("lk_solution_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solution_modifiedby");
                this.SetRelatedEntities<CrmSdk.Solution>("lk_solution_modifiedby", null, value);
                this.OnPropertyChanged("lk_solution_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_solutionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Solution> lk_solutionbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Solution>("lk_solutionbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solutionbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Solution>("lk_solutionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Solution> lk_solutionbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Solution>("lk_solutionbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Solution>("lk_solutionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutioncomponentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SolutionComponent> lk_solutioncomponentbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solutioncomponentbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutioncomponentbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutioncomponentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SolutionComponent> lk_solutioncomponentbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_solutioncomponentbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutioncomponentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subject_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Subject> lk_subject_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Subject>("lk_subject_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_subject_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Subject>("lk_subject_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_subject_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subject_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Subject> lk_subject_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Subject>("lk_subject_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_subject_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Subject>("lk_subject_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_subject_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subjectbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Subject> lk_subjectbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Subject>("lk_subjectbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_subjectbase_createdby");
                this.SetRelatedEntities<CrmSdk.Subject>("lk_subjectbase_createdby", null, value);
                this.OnPropertyChanged("lk_subjectbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_subjectbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Subject> lk_subjectbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Subject>("lk_subjectbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_subjectbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Subject>("lk_subjectbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_subjectbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> Referencedlk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
                this.SetRelatedEntities<CrmSdk.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Task> lk_task_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Task>("lk_task_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_task_createdby");
                this.SetRelatedEntities<CrmSdk.Task>("lk_task_createdby", null, value);
                this.OnPropertyChanged("lk_task_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Task> lk_task_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Task>("lk_task_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_task_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Task>("lk_task_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Task> lk_task_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Task>("lk_task_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_task_modifiedby");
                this.SetRelatedEntities<CrmSdk.Task>("lk_task_modifiedby", null, value);
                this.OnPropertyChanged("lk_task_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Task> lk_task_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Task>("lk_task_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_task_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Task>("lk_task_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_team_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> lk_team_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("lk_team_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_team_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Team>("lk_team_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_team_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_team_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> lk_team_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("lk_team_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_team_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Team>("lk_team_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_team_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_administratorid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> lk_teambase_administratorid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("lk_teambase_administratorid", null);
            }
            set
            {
                this.OnPropertyChanging("lk_teambase_administratorid");
                this.SetRelatedEntities<CrmSdk.Team>("lk_teambase_administratorid", null, value);
                this.OnPropertyChanged("lk_teambase_administratorid");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> lk_teambase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("lk_teambase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_teambase_createdby");
                this.SetRelatedEntities<CrmSdk.Team>("lk_teambase_createdby", null, value);
                this.OnPropertyChanged("lk_teambase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> lk_teambase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("lk_teambase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_teambase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Team>("lk_teambase_modifiedby", null, value);
                this.OnPropertyChanged("lk_teambase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Template> lk_templatebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Template>("lk_templatebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_templatebase_createdby");
                this.SetRelatedEntities<CrmSdk.Template>("lk_templatebase_createdby", null, value);
                this.OnPropertyChanged("lk_templatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Template> lk_templatebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Template>("lk_templatebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_templatebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Template>("lk_templatebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_templatebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Template> lk_templatebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Template>("lk_templatebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_templatebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Template>("lk_templatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_templatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Template> lk_templatebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Template>("lk_templatebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_templatebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Template>("lk_templatebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_templatebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> lk_territory_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("lk_territory_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_territory_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Territory>("lk_territory_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_territory_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> lk_territory_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("lk_territory_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_territory_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Territory>("lk_territory_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_territory_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> lk_territorybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("lk_territorybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_territorybase_createdby");
                this.SetRelatedEntities<CrmSdk.Territory>("lk_territorybase_createdby", null, value);
                this.OnPropertyChanged("lk_territorybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_territorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> lk_territorybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("lk_territorybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_territorybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.Territory>("lk_territorybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_territorybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneDefinition> lk_timezonedefinition_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_createdby");
                this.SetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_createdby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneDefinition> lk_timezonedefinition_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneDefinition> lk_timezonedefinition_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_modifiedby");
                this.SetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneDefinition> lk_timezonedefinition_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneLocalizedName> lk_timezonelocalizedname_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_createdby");
                this.SetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneLocalizedName> lk_timezonelocalizedname_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_modifiedby");
                this.SetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneRule> lk_timezonerule_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_createdby");
                this.SetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_createdby", null, value);
                this.OnPropertyChanged("lk_timezonerule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneRule> lk_timezonerule_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonerule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneRule> lk_timezonerule_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_modifiedby");
                this.SetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonerule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TimeZoneRule> lk_timezonerule_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonerule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransactionCurrency> lk_transactioncurrency_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrency_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transactioncurrency_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransactionCurrency> lk_transactioncurrency_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrency_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transactioncurrency_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrencybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransactionCurrency> lk_transactioncurrencybase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrencybase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrencybase_createdby");
                this.SetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrencybase_createdby", null, value);
                this.OnPropertyChanged("lk_transactioncurrencybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrencybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransactionCurrency> lk_transactioncurrencybase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrencybase_modifiedby");
                this.SetRelatedEntities<CrmSdk.TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_transactioncurrencybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationMapping> lk_transformationmapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_createdby");
                this.SetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_createdby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationMapping> lk_transformationmapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationMapping> lk_transformationmapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationMapping> lk_transformationmapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationParameterMapping> lk_transformationparametermapping_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_createdby");
                this.SetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_createdby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationParameterMapping> lk_transformationparametermapping_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationParameterMapping> lk_transformationparametermapping_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_modifiedby");
                this.SetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.TransformationParameterMapping> lk_transformationparametermapping_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.TransformationParameterMapping>("lk_transformationparametermapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoM> lk_uom_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoM>("lk_uom_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uom_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UoM>("lk_uom_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoM> lk_uom_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoM>("lk_uom_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uom_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UoM>("lk_uom_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoM> lk_uombase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoM>("lk_uombase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uombase_createdby");
                this.SetRelatedEntities<CrmSdk.UoM>("lk_uombase_createdby", null, value);
                this.OnPropertyChanged("lk_uombase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoM> lk_uombase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoM>("lk_uombase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uombase_modifiedby");
                this.SetRelatedEntities<CrmSdk.UoM>("lk_uombase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uombase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoMSchedule> lk_uomschedule_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedule_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uomschedule_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoMSchedule> lk_uomschedule_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoMSchedule> lk_uomschedulebase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedulebase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_createdby");
                this.SetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedulebase_createdby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UoMSchedule> lk_uomschedulebase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedulebase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_modifiedby");
                this.SetRelatedEntities<CrmSdk.UoMSchedule>("lk_uomschedulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userform_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserForm> lk_userform_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserForm>("lk_userform_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userform_createdby");
                this.SetRelatedEntities<CrmSdk.UserForm>("lk_userform_createdby", null, value);
                this.OnPropertyChanged("lk_userform_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userform_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserForm> lk_userform_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserForm>("lk_userform_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userform_modifiedby");
                this.SetRelatedEntities<CrmSdk.UserForm>("lk_userform_modifiedby", null, value);
                this.OnPropertyChanged("lk_userform_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userformbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserForm> lk_userformbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserForm>("lk_userformbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userformbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserForm>("lk_userformbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userformbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userformbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserForm> lk_userformbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserForm>("lk_userformbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userformbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserForm>("lk_userformbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userformbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQuery> lk_userquery_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userquery_createdby");
                this.SetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_createdby", null, value);
                this.OnPropertyChanged("lk_userquery_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQuery> lk_userquery_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userquery_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQuery> lk_userquery_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userquery_modifiedby");
                this.SetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_modifiedby", null, value);
                this.OnPropertyChanged("lk_userquery_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQuery> lk_userquery_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userquery_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserQuery>("lk_userquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualization_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQueryVisualization> lk_userqueryvisualization_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualization_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualization_createdby");
                this.SetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualization_createdby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualization_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualization_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQueryVisualization> lk_userqueryvisualization_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualization_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualization_modifiedby");
                this.SetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualization_modifiedby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualization_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQueryVisualization> lk_userqueryvisualizationbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualizationbase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualizationbase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualizationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQueryVisualization> lk_userqueryvisualizationbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualizationbase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualizationbase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserQueryVisualization>("lk_userqueryvisualizationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettings_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserSettings> lk_usersettings_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserSettings>("lk_usersettings_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_usersettings_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserSettings>("lk_usersettings_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_usersettings_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettings_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserSettings> lk_usersettings_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserSettings>("lk_usersettings_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_usersettings_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.UserSettings>("lk_usersettings_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_usersettings_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettingsbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserSettings> lk_usersettingsbase_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserSettings>("lk_usersettingsbase_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_usersettingsbase_createdby");
                this.SetRelatedEntities<CrmSdk.UserSettings>("lk_usersettingsbase_createdby", null, value);
                this.OnPropertyChanged("lk_usersettingsbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettingsbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserSettings> lk_usersettingsbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserSettings>("lk_usersettingsbase_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_usersettingsbase_modifiedby");
                this.SetRelatedEntities<CrmSdk.UserSettings>("lk_usersettingsbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_usersettingsbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_webresourcebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WebResource> lk_webresourcebase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WebResource>("lk_webresourcebase_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_webresourcebase_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.WebResource>("lk_webresourcebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_webresourcebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_webresourcebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WebResource> lk_webresourcebase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WebResource>("lk_webresourcebase_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_webresourcebase_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.WebResource>("lk_webresourcebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_webresourcebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowLog> lk_workflowlog_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_createdby");
                this.SetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_createdby", null, value);
                this.OnPropertyChanged("lk_workflowlog_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowLog> lk_workflowlog_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_workflowlog_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowLog> lk_workflowlog_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_modifiedby");
                this.SetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_modifiedby", null, value);
                this.OnPropertyChanged("lk_workflowlog_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowLog> lk_workflowlog_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.WorkflowLog>("lk_workflowlog_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_workflowlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N modifiedby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_attributemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AttributeMap> modifiedby_attributemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AttributeMap>("modifiedby_attributemap", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_attributemap");
                this.SetRelatedEntities<CrmSdk.AttributeMap>("modifiedby_attributemap", null, value);
                this.OnPropertyChanged("modifiedby_attributemap");
            }
        }

        /// <summary>
        /// 1:N modifiedby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> modifiedby_connection
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("modifiedby_connection", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_connection");
                this.SetRelatedEntities<CrmSdk.Connection>("modifiedby_connection", null, value);
                this.OnPropertyChanged("modifiedby_connection");
            }
        }

        /// <summary>
        /// 1:N modifiedby_connection_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection_role")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ConnectionRole> modifiedby_connection_role
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ConnectionRole>("modifiedby_connection_role", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_connection_role");
                this.SetRelatedEntities<CrmSdk.ConnectionRole>("modifiedby_connection_role", null, value);
                this.OnPropertyChanged("modifiedby_connection_role");
            }
        }

        /// <summary>
        /// 1:N modifiedby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerRelationship> modifiedby_customer_relationship
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerRelationship>("modifiedby_customer_relationship", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_customer_relationship");
                this.SetRelatedEntities<CrmSdk.CustomerRelationship>("modifiedby_customer_relationship", null, value);
                this.OnPropertyChanged("modifiedby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N modifiedby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_entitymap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.EntityMap> modifiedby_entitymap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.EntityMap>("modifiedby_entitymap", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_entitymap");
                this.SetRelatedEntities<CrmSdk.EntityMap>("modifiedby_entitymap", null, value);
                this.OnPropertyChanged("modifiedby_entitymap");
            }
        }

        /// <summary>
        /// 1:N modifiedby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_pluginassembly")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginAssembly> modifiedby_pluginassembly
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginAssembly>("modifiedby_pluginassembly", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_pluginassembly");
                this.SetRelatedEntities<CrmSdk.PluginAssembly>("modifiedby_pluginassembly", null, value);
                this.OnPropertyChanged("modifiedby_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N modifiedby_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintype")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginType> modifiedby_plugintype
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginType>("modifiedby_plugintype", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_plugintype");
                this.SetRelatedEntities<CrmSdk.PluginType>("modifiedby_plugintype", null, value);
                this.OnPropertyChanged("modifiedby_plugintype");
            }
        }

        /// <summary>
        /// 1:N modifiedby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PluginTypeStatistic> modifiedby_plugintypestatistic
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PluginTypeStatistic>("modifiedby_plugintypestatistic", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_plugintypestatistic");
                this.SetRelatedEntities<CrmSdk.PluginTypeStatistic>("modifiedby_plugintypestatistic", null, value);
                this.OnPropertyChanged("modifiedby_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N modifiedby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRole> modifiedby_relationship_role
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRole>("modifiedby_relationship_role", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_relationship_role");
                this.SetRelatedEntities<CrmSdk.RelationshipRole>("modifiedby_relationship_role", null, value);
                this.OnPropertyChanged("modifiedby_relationship_role");
            }
        }

        /// <summary>
        /// 1:N modifiedby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role_map")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RelationshipRoleMap> modifiedby_relationship_role_map
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RelationshipRoleMap>("modifiedby_relationship_role_map", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_relationship_role_map");
                this.SetRelatedEntities<CrmSdk.RelationshipRoleMap>("modifiedby_relationship_role_map", null, value);
                this.OnPropertyChanged("modifiedby_relationship_role_map");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessage> modifiedby_sdkmessage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessage>("modifiedby_sdkmessage", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessage");
                this.SetRelatedEntities<CrmSdk.SdkMessage>("modifiedby_sdkmessage", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageFilter> modifiedby_sdkmessagefilter
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageFilter>("modifiedby_sdkmessagefilter", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagefilter");
                this.SetRelatedEntities<CrmSdk.SdkMessageFilter>("modifiedby_sdkmessagefilter", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessagePair> modifiedby_sdkmessagepair
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessagePair>("modifiedby_sdkmessagepair", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagepair");
                this.SetRelatedEntities<CrmSdk.SdkMessagePair>("modifiedby_sdkmessagepair", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStep> modifiedby_sdkmessageprocessingstep
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstep");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepImage> modifiedby_sdkmessageprocessingstepimage
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageProcessingStepSecureConfig> modifiedby_sdkmessageprocessingstepsecureconfig
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<CrmSdk.SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequest> modifiedby_sdkmessagerequest
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequest>("modifiedby_sdkmessagerequest", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagerequest");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequest>("modifiedby_sdkmessagerequest", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageRequestField> modifiedby_sdkmessagerequestfield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagerequestfield");
                this.SetRelatedEntities<CrmSdk.SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponse> modifiedby_sdkmessageresponse
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponse>("modifiedby_sdkmessageresponse", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageresponse");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponse>("modifiedby_sdkmessageresponse", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SdkMessageResponseField> modifiedby_sdkmessageresponsefield
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageresponsefield");
                this.SetRelatedEntities<CrmSdk.SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N modifiedby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceEndpoint> modifiedby_serviceendpoint
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceEndpoint>("modifiedby_serviceendpoint", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedby_serviceendpoint");
                this.SetRelatedEntities<CrmSdk.ServiceEndpoint>("modifiedby_serviceendpoint", null, value);
                this.OnPropertyChanged("modifiedby_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N modifiedonbehalfby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_attributemap")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AttributeMap> modifiedonbehalfby_attributemap
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AttributeMap>("modifiedonbehalfby_attributemap", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedonbehalfby_attributemap");
                this.SetRelatedEntities<CrmSdk.AttributeMap>("modifiedonbehalfby_attributemap", null, value);
                this.OnPropertyChanged("modifiedonbehalfby_attributemap");
            }
        }

        /// <summary>
        /// 1:N modifiedonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerRelationship> modifiedonbehalfby_customer_relationship
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerRelationship>("modifiedonbehalfby_customer_relationship", null);
            }
            set
            {
                this.OnPropertyChanging("modifiedonbehalfby_customer_relationship");
                this.SetRelatedEntities<CrmSdk.CustomerRelationship>("modifiedonbehalfby_customer_relationship", null, value);
                this.OnPropertyChanged("modifiedonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Opportunity> opportunity_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Opportunity>("opportunity_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("opportunity_owning_user");
                this.SetRelatedEntities<CrmSdk.Opportunity>("opportunity_owning_user", null, value);
                this.OnPropertyChanged("opportunity_owning_user");
            }
        }

        /// <summary>
        /// 1:N OwnerMapping_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwnerMapping_SystemUser")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OwnerMapping> OwnerMapping_SystemUser
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OwnerMapping>("OwnerMapping_SystemUser", null);
            }
            set
            {
                this.OnPropertyChanging("OwnerMapping_SystemUser");
                this.SetRelatedEntities<CrmSdk.OwnerMapping>("OwnerMapping_SystemUser", null, value);
                this.OnPropertyChanged("OwnerMapping_SystemUser");
            }
        }

        /// <summary>
        /// 1:N queue_primary_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_primary_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Queue> queue_primary_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Queue>("queue_primary_user", null);
            }
            set
            {
                this.OnPropertyChanging("queue_primary_user");
                this.SetRelatedEntities<CrmSdk.Queue>("queue_primary_user", null, value);
                this.OnPropertyChanged("queue_primary_user");
            }
        }

        /// <summary>
        /// 1:N system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> system_user_accounts
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("system_user_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_accounts");
                this.SetRelatedEntities<CrmSdk.Account>("system_user_accounts", null, value);
                this.OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        /// 1:N system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityParty> system_user_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityParty>("system_user_activity_parties", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_activity_parties");
                this.SetRelatedEntities<CrmSdk.ActivityParty>("system_user_activity_parties", null, value);
                this.OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        /// 1:N system_user_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_asyncoperation")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> system_user_asyncoperation
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("system_user_asyncoperation", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_asyncoperation");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("system_user_asyncoperation", null, value);
                this.OnPropertyChanged("system_user_asyncoperation");
            }
        }

        /// <summary>
        /// 1:N system_user_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contact> system_user_contacts
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contact>("system_user_contacts", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_contacts");
                this.SetRelatedEntities<CrmSdk.Contact>("system_user_contacts", null, value);
                this.OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        /// 1:N system_user_email_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_email_templates")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Template> system_user_email_templates
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Template>("system_user_email_templates", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_email_templates");
                this.SetRelatedEntities<CrmSdk.Template>("system_user_email_templates", null, value);
                this.OnPropertyChanged("system_user_email_templates");
            }
        }

        /// <summary>
        /// 1:N system_user_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_incidents")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Incident> system_user_incidents
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Incident>("system_user_incidents", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_incidents");
                this.SetRelatedEntities<CrmSdk.Incident>("system_user_incidents", null, value);
                this.OnPropertyChanged("system_user_incidents");
            }
        }

        /// <summary>
        /// 1:N system_user_invoicedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_invoicedetail")]
        public System.Collections.Generic.IEnumerable<CrmSdk.InvoiceDetail> system_user_invoicedetail
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.InvoiceDetail>("system_user_invoicedetail", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_invoicedetail");
                this.SetRelatedEntities<CrmSdk.InvoiceDetail>("system_user_invoicedetail", null, value);
                this.OnPropertyChanged("system_user_invoicedetail");
            }
        }

        /// <summary>
        /// 1:N system_user_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_invoices")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Invoice> system_user_invoices
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Invoice>("system_user_invoices", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_invoices");
                this.SetRelatedEntities<CrmSdk.Invoice>("system_user_invoices", null, value);
                this.OnPropertyChanged("system_user_invoices");
            }
        }

        /// <summary>
        /// 1:N system_user_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_orders")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrder> system_user_orders
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrder>("system_user_orders", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_orders");
                this.SetRelatedEntities<CrmSdk.SalesOrder>("system_user_orders", null, value);
                this.OnPropertyChanged("system_user_orders");
            }
        }

        /// <summary>
        /// 1:N system_user_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotedetail")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteDetail> system_user_quotedetail
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteDetail>("system_user_quotedetail", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_quotedetail");
                this.SetRelatedEntities<CrmSdk.QuoteDetail>("system_user_quotedetail", null, value);
                this.OnPropertyChanged("system_user_quotedetail");
            }
        }

        /// <summary>
        /// 1:N system_user_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotes")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Quote> system_user_quotes
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Quote>("system_user_quotes", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_quotes");
                this.SetRelatedEntities<CrmSdk.Quote>("system_user_quotes", null, value);
                this.OnPropertyChanged("system_user_quotes");
            }
        }

        /// <summary>
        /// 1:N system_user_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_sales_literature")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesLiterature> system_user_sales_literature
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesLiterature>("system_user_sales_literature", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_sales_literature");
                this.SetRelatedEntities<CrmSdk.SalesLiterature>("system_user_sales_literature", null, value);
                this.OnPropertyChanged("system_user_sales_literature");
            }
        }

        /// <summary>
        /// 1:N system_user_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_salesorderdetail")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SalesOrderDetail> system_user_salesorderdetail
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SalesOrderDetail>("system_user_salesorderdetail", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_salesorderdetail");
                this.SetRelatedEntities<CrmSdk.SalesOrderDetail>("system_user_salesorderdetail", null, value);
                this.OnPropertyChanged("system_user_salesorderdetail");
            }
        }

        /// <summary>
        /// 1:N system_user_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_appointments")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ServiceAppointment> system_user_service_appointments
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ServiceAppointment>("system_user_service_appointments", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_service_appointments");
                this.SetRelatedEntities<CrmSdk.ServiceAppointment>("system_user_service_appointments", null, value);
                this.OnPropertyChanged("system_user_service_appointments");
            }
        }

        /// <summary>
        /// 1:N system_user_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_contracts")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Contract> system_user_service_contracts
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Contract>("system_user_service_contracts", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_service_contracts");
                this.SetRelatedEntities<CrmSdk.Contract>("system_user_service_contracts", null, value);
                this.OnPropertyChanged("system_user_service_contracts");
            }
        }

        /// <summary>
        /// 1:N system_user_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_territories")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Territory> system_user_territories
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Territory>("system_user_territories", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_territories");
                this.SetRelatedEntities<CrmSdk.Territory>("system_user_territories", null, value);
                this.OnPropertyChanged("system_user_territories");
            }
        }

        /// <summary>
        /// 1:N system_user_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_workflow")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Workflow> system_user_workflow
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Workflow>("system_user_workflow", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_workflow");
                this.SetRelatedEntities<CrmSdk.Workflow>("system_user_workflow", null, value);
                this.OnPropertyChanged("system_user_workflow");
            }
        }

        /// <summary>
        /// 1:N SystemUser_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<CrmSdk.AsyncOperation> SystemUser_AsyncOperations
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.AsyncOperation>("SystemUser_AsyncOperations", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_AsyncOperations");
                this.SetRelatedEntities<CrmSdk.AsyncOperation>("SystemUser_AsyncOperations", null, value);
                this.OnPropertyChanged("SystemUser_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SystemUser_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkDeleteFailure> SystemUser_BulkDeleteFailures
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_BulkDeleteFailures");
                this.SetRelatedEntities<CrmSdk.BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SystemUser_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Campaigns")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Campaign> SystemUser_Campaigns
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Campaign>("SystemUser_Campaigns", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_Campaigns");
                this.SetRelatedEntities<CrmSdk.Campaign>("SystemUser_Campaigns", null, value);
                this.OnPropertyChanged("SystemUser_Campaigns");
            }
        }

        /// <summary>
        /// 1:N systemuser_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections1")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> systemuser_connections1
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("systemuser_connections1", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_connections1");
                this.SetRelatedEntities<CrmSdk.Connection>("systemuser_connections1", null, value);
                this.OnPropertyChanged("systemuser_connections1");
            }
        }

        /// <summary>
        /// 1:N systemuser_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections2")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Connection> systemuser_connections2
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Connection>("systemuser_connections2", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_connections2");
                this.SetRelatedEntities<CrmSdk.Connection>("systemuser_connections2", null, value);
                this.OnPropertyChanged("systemuser_connections2");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRecord> SystemUser_DuplicateBaseRecord
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRecord>("SystemUser_DuplicateBaseRecord", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateBaseRecord");
                this.SetRelatedEntities<CrmSdk.DuplicateRecord>("SystemUser_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRecord> SystemUser_DuplicateMatchingRecord
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateMatchingRecord");
                this.SetRelatedEntities<CrmSdk.DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateRules")]
        public System.Collections.Generic.IEnumerable<CrmSdk.DuplicateRule> SystemUser_DuplicateRules
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.DuplicateRule>("SystemUser_DuplicateRules", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateRules");
                this.SetRelatedEntities<CrmSdk.DuplicateRule>("SystemUser_DuplicateRules", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateRules");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportFiles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportFile> SystemUser_ImportFiles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportFile>("SystemUser_ImportFiles", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportFiles");
                this.SetRelatedEntities<CrmSdk.ImportFile>("SystemUser_ImportFiles", null, value);
                this.OnPropertyChanged("SystemUser_ImportFiles");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportLogs")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportLog> SystemUser_ImportLogs
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportLog>("SystemUser_ImportLogs", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportLogs");
                this.SetRelatedEntities<CrmSdk.ImportLog>("SystemUser_ImportLogs", null, value);
                this.OnPropertyChanged("SystemUser_ImportLogs");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportMaps")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ImportMap> SystemUser_ImportMaps
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ImportMap>("SystemUser_ImportMaps", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportMaps");
                this.SetRelatedEntities<CrmSdk.ImportMap>("SystemUser_ImportMaps", null, value);
                this.OnPropertyChanged("SystemUser_ImportMaps");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Imports")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Import> SystemUser_Imports
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Import>("SystemUser_Imports", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_Imports");
                this.SetRelatedEntities<CrmSdk.Import>("SystemUser_Imports", null, value);
                this.OnPropertyChanged("SystemUser_Imports");
            }
        }

        /// <summary>
        /// 1:N systemuser_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_PostFollows")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostFollow> systemuser_PostFollows
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostFollow>("systemuser_PostFollows", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_PostFollows");
                this.SetRelatedEntities<CrmSdk.PostFollow>("systemuser_PostFollows", null, value);
                this.OnPropertyChanged("systemuser_PostFollows");
            }
        }

        /// <summary>
        /// 1:N systemuser_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess");
                this.SetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N systemuser_principalobjectattributeaccess_principalid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess_principalid")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess_principalid
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess_principalid", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess_principalid");
                this.SetRelatedEntities<CrmSdk.PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess_principalid", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ProcessSession> SystemUser_ProcessSessions
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ProcessSession>("SystemUser_ProcessSessions", null);
            }
            set
            {
                this.OnPropertyChanging("SystemUser_ProcessSessions");
                this.SetRelatedEntities<CrmSdk.ProcessSession>("SystemUser_ProcessSessions", null, value);
                this.OnPropertyChanged("SystemUser_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N systemuser_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_resources")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Resource> systemuser_resources
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Resource>("systemuser_resources", null);
            }
            set
            {
                this.OnPropertyChanging("systemuser_resources");
                this.SetRelatedEntities<CrmSdk.Resource>("systemuser_resources", null, value);
                this.OnPropertyChanged("systemuser_resources");
            }
        }

        /// <summary>
        /// 1:N user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Account> user_accounts
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Account>("user_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("user_accounts");
                this.SetRelatedEntities<CrmSdk.Account>("user_accounts", null, value);
                this.OnPropertyChanged("user_accounts");
            }
        }

        /// <summary>
        /// 1:N user_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_activity")]
        public System.Collections.Generic.IEnumerable<CrmSdk.ActivityPointer> user_activity
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.ActivityPointer>("user_activity", null);
            }
            set
            {
                this.OnPropertyChanging("user_activity");
                this.SetRelatedEntities<CrmSdk.ActivityPointer>("user_activity", null, value);
                this.OnPropertyChanged("user_activity");
            }
        }

        /// <summary>
        /// 1:N user_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_appointment")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Appointment> user_appointment
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Appointment>("user_appointment", null);
            }
            set
            {
                this.OnPropertyChanging("user_appointment");
                this.SetRelatedEntities<CrmSdk.Appointment>("user_appointment", null, value);
                this.OnPropertyChanged("user_appointment");
            }
        }

        /// <summary>
        /// 1:N user_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_BulkOperation")]
        public System.Collections.Generic.IEnumerable<CrmSdk.BulkOperation> user_BulkOperation
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.BulkOperation>("user_BulkOperation", null);
            }
            set
            {
                this.OnPropertyChanging("user_BulkOperation");
                this.SetRelatedEntities<CrmSdk.BulkOperation>("user_BulkOperation", null, value);
                this.OnPropertyChanged("user_BulkOperation");
            }
        }

        /// <summary>
        /// 1:N user_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignactivity")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignActivity> user_campaignactivity
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignActivity>("user_campaignactivity", null);
            }
            set
            {
                this.OnPropertyChanging("user_campaignactivity");
                this.SetRelatedEntities<CrmSdk.CampaignActivity>("user_campaignactivity", null, value);
                this.OnPropertyChanged("user_campaignactivity");
            }
        }

        /// <summary>
        /// 1:N user_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CampaignResponse> user_campaignresponse
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CampaignResponse>("user_campaignresponse", null);
            }
            set
            {
                this.OnPropertyChanging("user_campaignresponse");
                this.SetRelatedEntities<CrmSdk.CampaignResponse>("user_campaignresponse", null, value);
                this.OnPropertyChanged("user_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N user_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerOpportunityRole> user_customer_opportunity_roles
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerOpportunityRole>("user_customer_opportunity_roles", null);
            }
            set
            {
                this.OnPropertyChanging("user_customer_opportunity_roles");
                this.SetRelatedEntities<CrmSdk.CustomerOpportunityRole>("user_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("user_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N user_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CrmSdk.CustomerRelationship> user_customer_relationship
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.CustomerRelationship>("user_customer_relationship", null);
            }
            set
            {
                this.OnPropertyChanging("user_customer_relationship");
                this.SetRelatedEntities<CrmSdk.CustomerRelationship>("user_customer_relationship", null, value);
                this.OnPropertyChanged("user_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Email> user_email
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Email>("user_email", null);
            }
            set
            {
                this.OnPropertyChanging("user_email");
                this.SetRelatedEntities<CrmSdk.Email>("user_email", null, value);
                this.OnPropertyChanged("user_email");
            }
        }

        /// <summary>
        /// 1:N user_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_fax")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Fax> user_fax
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Fax>("user_fax", null);
            }
            set
            {
                this.OnPropertyChanging("user_fax");
                this.SetRelatedEntities<CrmSdk.Fax>("user_fax", null, value);
                this.OnPropertyChanged("user_fax");
            }
        }

        /// <summary>
        /// 1:N user_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> user_goal
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("user_goal", null);
            }
            set
            {
                this.OnPropertyChanging("user_goal");
                this.SetRelatedEntities<CrmSdk.Goal>("user_goal", null, value);
                this.OnPropertyChanged("user_goal");
            }
        }

        /// <summary>
        /// 1:N user_goal_goalowner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal_goalowner")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Goal> user_goal_goalowner
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Goal>("user_goal_goalowner", null);
            }
            set
            {
                this.OnPropertyChanging("user_goal_goalowner");
                this.SetRelatedEntities<CrmSdk.Goal>("user_goal_goalowner", null, value);
                this.OnPropertyChanged("user_goal_goalowner");
            }
        }

        /// <summary>
        /// 1:N user_incidentresolution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_incidentresolution")]
        public System.Collections.Generic.IEnumerable<CrmSdk.IncidentResolution> user_incidentresolution
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.IncidentResolution>("user_incidentresolution", null);
            }
            set
            {
                this.OnPropertyChanging("user_incidentresolution");
                this.SetRelatedEntities<CrmSdk.IncidentResolution>("user_incidentresolution", null, value);
                this.OnPropertyChanged("user_incidentresolution");
            }
        }

        /// <summary>
        /// 1:N user_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_letter")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Letter> user_letter
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Letter>("user_letter", null);
            }
            set
            {
                this.OnPropertyChanging("user_letter");
                this.SetRelatedEntities<CrmSdk.Letter>("user_letter", null, value);
                this.OnPropertyChanged("user_letter");
            }
        }

        /// <summary>
        /// 1:N user_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_list")]
        public System.Collections.Generic.IEnumerable<CrmSdk.List> user_list
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.List>("user_list", null);
            }
            set
            {
                this.OnPropertyChanging("user_list");
                this.SetRelatedEntities<CrmSdk.List>("user_list", null, value);
                this.OnPropertyChanged("user_list");
            }
        }

        /// <summary>
        /// 1:N user_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_opportunityclose")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OpportunityClose> user_opportunityclose
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OpportunityClose>("user_opportunityclose", null);
            }
            set
            {
                this.OnPropertyChanging("user_opportunityclose");
                this.SetRelatedEntities<CrmSdk.OpportunityClose>("user_opportunityclose", null, value);
                this.OnPropertyChanged("user_opportunityclose");
            }
        }

        /// <summary>
        /// 1:N user_orderclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orderclose")]
        public System.Collections.Generic.IEnumerable<CrmSdk.OrderClose> user_orderclose
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.OrderClose>("user_orderclose", null);
            }
            set
            {
                this.OnPropertyChanging("user_orderclose");
                this.SetRelatedEntities<CrmSdk.OrderClose>("user_orderclose", null, value);
                this.OnPropertyChanged("user_orderclose");
            }
        }

        /// <summary>
        /// 1:N user_owner_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_owner_postfollows")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PostFollow> user_owner_postfollows
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PostFollow>("user_owner_postfollows", null);
            }
            set
            {
                this.OnPropertyChanging("user_owner_postfollows");
                this.SetRelatedEntities<CrmSdk.PostFollow>("user_owner_postfollows", null, value);
                this.OnPropertyChanged("user_owner_postfollows");
            }
        }

        /// <summary>
        /// 1:N user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CrmSdk.SystemUser> Referenceduser_parent_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referenceduser_parent_user");
                this.SetRelatedEntities<CrmSdk.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referenceduser_parent_user");
            }
        }

        /// <summary>
        /// 1:N user_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_phonecall")]
        public System.Collections.Generic.IEnumerable<CrmSdk.PhoneCall> user_phonecall
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.PhoneCall>("user_phonecall", null);
            }
            set
            {
                this.OnPropertyChanging("user_phonecall");
                this.SetRelatedEntities<CrmSdk.PhoneCall>("user_phonecall", null, value);
                this.OnPropertyChanged("user_phonecall");
            }
        }

        /// <summary>
        /// 1:N user_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_quoteclose")]
        public System.Collections.Generic.IEnumerable<CrmSdk.QuoteClose> user_quoteclose
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.QuoteClose>("user_quoteclose", null);
            }
            set
            {
                this.OnPropertyChanging("user_quoteclose");
                this.SetRelatedEntities<CrmSdk.QuoteClose>("user_quoteclose", null, value);
                this.OnPropertyChanged("user_quoteclose");
            }
        }

        /// <summary>
        /// 1:N user_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<CrmSdk.RecurringAppointmentMaster> user_recurringappointmentmaster
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("user_recurringappointmentmaster", null);
            }
            set
            {
                this.OnPropertyChanging("user_recurringappointmentmaster");
                this.SetRelatedEntities<CrmSdk.RecurringAppointmentMaster>("user_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("user_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// 1:N user_settings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_settings")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserSettings> user_settings
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserSettings>("user_settings", null);
            }
            set
            {
                this.OnPropertyChanging("user_settings");
                this.SetRelatedEntities<CrmSdk.UserSettings>("user_settings", null, value);
                this.OnPropertyChanged("user_settings");
            }
        }

        /// <summary>
        /// 1:N user_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointDocumentLocation> user_sharepointdocumentlocation
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointDocumentLocation>("user_sharepointdocumentlocation", null);
            }
            set
            {
                this.OnPropertyChanging("user_sharepointdocumentlocation");
                this.SetRelatedEntities<CrmSdk.SharePointDocumentLocation>("user_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("user_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N user_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointsite")]
        public System.Collections.Generic.IEnumerable<CrmSdk.SharePointSite> user_sharepointsite
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.SharePointSite>("user_sharepointsite", null);
            }
            set
            {
                this.OnPropertyChanging("user_sharepointsite");
                this.SetRelatedEntities<CrmSdk.SharePointSite>("user_sharepointsite", null, value);
                this.OnPropertyChanged("user_sharepointsite");
            }
        }

        /// <summary>
        /// 1:N user_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_task")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Task> user_task
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Task>("user_task", null);
            }
            set
            {
                this.OnPropertyChanging("user_task");
                this.SetRelatedEntities<CrmSdk.Task>("user_task", null, value);
                this.OnPropertyChanged("user_task");
            }
        }

        /// <summary>
        /// 1:N user_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userform")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserForm> user_userform
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserForm>("user_userform", null);
            }
            set
            {
                this.OnPropertyChanging("user_userform");
                this.SetRelatedEntities<CrmSdk.UserForm>("user_userform", null, value);
                this.OnPropertyChanged("user_userform");
            }
        }

        /// <summary>
        /// 1:N user_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userquery")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQuery> user_userquery
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQuery>("user_userquery", null);
            }
            set
            {
                this.OnPropertyChanging("user_userquery");
                this.SetRelatedEntities<CrmSdk.UserQuery>("user_userquery", null, value);
                this.OnPropertyChanged("user_userquery");
            }
        }

        /// <summary>
        /// 1:N user_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserQueryVisualization> user_userqueryvisualizations
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserQueryVisualization>("user_userqueryvisualizations", null);
            }
            set
            {
                this.OnPropertyChanging("user_userqueryvisualizations");
                this.SetRelatedEntities<CrmSdk.UserQueryVisualization>("user_userqueryvisualizations", null, value);
                this.OnPropertyChanged("user_userqueryvisualizations");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_owning_user");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_owning_user", null, value);
                this.OnPropertyChanged("userentityinstancedata_owning_user");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_systemuser")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityInstanceData> userentityinstancedata_systemuser
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_systemuser", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_systemuser");
                this.SetRelatedEntities<CrmSdk.UserEntityInstanceData>("userentityinstancedata_systemuser", null, value);
                this.OnPropertyChanged("userentityinstancedata_systemuser");
            }
        }

        /// <summary>
        /// 1:N userentityuisettings_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityuisettings_owning_user")]
        public System.Collections.Generic.IEnumerable<CrmSdk.UserEntityUISettings> userentityuisettings_owning_user
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.UserEntityUISettings>("userentityuisettings_owning_user", null);
            }
            set
            {
                this.OnPropertyChanging("userentityuisettings_owning_user");
                this.SetRelatedEntities<CrmSdk.UserEntityUISettings>("userentityuisettings_owning_user", null, value);
                this.OnPropertyChanged("userentityuisettings_owning_user");
            }
        }

        /// <summary>
        /// 1:N webresource_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WebResource> webresource_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WebResource>("webresource_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("webresource_createdby");
                this.SetRelatedEntities<CrmSdk.WebResource>("webresource_createdby", null, value);
                this.OnPropertyChanged("webresource_createdby");
            }
        }

        /// <summary>
        /// 1:N webresource_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WebResource> webresource_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WebResource>("webresource_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("webresource_modifiedby");
                this.SetRelatedEntities<CrmSdk.WebResource>("webresource_modifiedby", null, value);
                this.OnPropertyChanged("webresource_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Workflow> workflow_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Workflow>("workflow_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_createdby");
                this.SetRelatedEntities<CrmSdk.Workflow>("workflow_createdby", null, value);
                this.OnPropertyChanged("workflow_createdby");
            }
        }

        /// <summary>
        /// 1:N workflow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Workflow> workflow_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Workflow>("workflow_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.Workflow>("workflow_createdonbehalfby", null, value);
                this.OnPropertyChanged("workflow_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowDependency> workflow_dependency_createdby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_createdby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_dependency_createdby");
                this.SetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_createdby", null, value);
                this.OnPropertyChanged("workflow_dependency_createdby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowDependency> workflow_dependency_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_createdonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_dependency_createdonbehalfby");
                this.SetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_createdonbehalfby", null, value);
                this.OnPropertyChanged("workflow_dependency_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowDependency> workflow_dependency_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_dependency_modifiedby");
                this.SetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_modifiedby", null, value);
                this.OnPropertyChanged("workflow_dependency_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.WorkflowDependency> workflow_dependency_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_dependency_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.WorkflowDependency>("workflow_dependency_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("workflow_dependency_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Workflow> workflow_modifiedby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Workflow>("workflow_modifiedby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_modifiedby");
                this.SetRelatedEntities<CrmSdk.Workflow>("workflow_modifiedby", null, value);
                this.OnPropertyChanged("workflow_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Workflow> workflow_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Workflow>("workflow_modifiedonbehalfby", null);
            }
            set
            {
                this.OnPropertyChanging("workflow_modifiedonbehalfby");
                this.SetRelatedEntities<CrmSdk.Workflow>("workflow_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("workflow_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:N systemuserprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserprofiles_association")]
        public System.Collections.Generic.IEnumerable<CrmSdk.FieldSecurityProfile> systemuserprofiles_association
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.FieldSecurityProfile>("systemuserprofiles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserprofiles_association");
                this.SetRelatedEntities<CrmSdk.FieldSecurityProfile>("systemuserprofiles_association", null, value);
                this.OnPropertyChanged("systemuserprofiles_association");
            }
        }

        /// <summary>
        /// N:N systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Role> systemuserroles_association
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Role>("systemuserroles_association", null);
            }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<CrmSdk.Role>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }

        /// <summary>
        /// N:N teammembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
        public System.Collections.Generic.IEnumerable<CrmSdk.Team> teammembership_association
        {
            get
            {
                return this.GetRelatedEntities<CrmSdk.Team>("teammembership_association", null);
            }
            set
            {
                this.OnPropertyChanging("teammembership_association");
                this.SetRelatedEntities<CrmSdk.Team>("teammembership_association", null, value);
                this.OnPropertyChanged("teammembership_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
        public CrmSdk.BusinessUnit business_unit_system_users
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.BusinessUnit>("business_unit_system_users", null);
            }
            set
            {
                this.OnPropertyChanging("business_unit_system_users");
                this.SetRelatedEntity<CrmSdk.BusinessUnit>("business_unit_system_users", null, value);
                this.OnPropertyChanged("business_unit_system_users");
            }
        }

        /// <summary>
        /// N:1 calendar_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_system_users")]
        public CrmSdk.Calendar calendar_system_users
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Calendar>("calendar_system_users", null);
            }
            set
            {
                this.OnPropertyChanging("calendar_system_users");
                this.SetRelatedEntity<CrmSdk.Calendar>("calendar_system_users", null, value);
                this.OnPropertyChanged("calendar_system_users");
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CrmSdk.SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CrmSdk.SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CrmSdk.SystemUser Referencinglk_systemuserbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CrmSdk.SystemUser Referencinglk_systemuserbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 organization_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_system_users")]
        public CrmSdk.Organization organization_system_users
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Organization>("organization_system_users", null);
            }
        }

        /// <summary>
        /// N:1 queue_system_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_system_user")]
        public CrmSdk.Queue queue_system_user
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Queue>("queue_system_user", null);
            }
            set
            {
                this.OnPropertyChanging("queue_system_user");
                this.SetRelatedEntity<CrmSdk.Queue>("queue_system_user", null, value);
                this.OnPropertyChanged("queue_system_user");
            }
        }

        /// <summary>
        /// N:1 site_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_system_users")]
        public CrmSdk.Site site_system_users
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Site>("site_system_users", null);
            }
            set
            {
                this.OnPropertyChanging("site_system_users");
                this.SetRelatedEntity<CrmSdk.Site>("site_system_users", null, value);
                this.OnPropertyChanged("site_system_users");
            }
        }

        /// <summary>
        /// N:1 territory_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_system_users")]
        public CrmSdk.Territory territory_system_users
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.Territory>("territory_system_users", null);
            }
            set
            {
                this.OnPropertyChanging("territory_system_users");
                this.SetRelatedEntity<CrmSdk.Territory>("territory_system_users", null, value);
                this.OnPropertyChanged("territory_system_users");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
        public CrmSdk.TransactionCurrency TransactionCurrency_SystemUser
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.TransactionCurrency>("TransactionCurrency_SystemUser", null);
            }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SystemUser");
                this.SetRelatedEntity<CrmSdk.TransactionCurrency>("TransactionCurrency_SystemUser", null, value);
                this.OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        /// N:1 user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CrmSdk.SystemUser Referencinguser_parent_user
        {
            get
            {
                return this.GetRelatedEntity<CrmSdk.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.OnPropertyChanging("Referencinguser_parent_user");
                this.SetRelatedEntity<CrmSdk.SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinguser_parent_user");
            }
        }
    }
}
