// =====================================================================
//
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// =====================================================================

namespace Xrm.Sdk.PluginRegistration.Wrappers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using Microsoft.Xrm.Sdk;
    using Entities;

    public sealed class CrmMessageEntity : ICrmEntity
    {
        private CrmOrganization m_org;

        private CrmMessageEntity(CrmOrganization org)
        {
            m_org = org;
        }

        public CrmMessageEntity(CrmOrganization org, Guid messageId, Guid messageEntityId,
            string primaryEntity, string secondaryEntity, CrmPluginStepDeployment availability, DateTime? createdOn, DateTime? modifiedOn)
            : this(org)
        {
            MessageEntityId = messageEntityId;
            MessageId = messageId;
            PrimaryEntity = primaryEntity;
            SecondaryEntity = secondaryEntity;
            CreatedOn = createdOn;
            ModifiedOn = modifiedOn;
            Availability = availability;
        }

        public CrmMessageEntity(CrmOrganization org, SdkMessageFilter filter)
            : this(org)
        {
            RefreshFromSdkMessageFilter(filter);
        }

        #region Properties
        /// <summary>
        /// Retrieves the Created On date of the entity. To update, see UpdateDates.
        /// </summary>
        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? CreatedOn { get; private set; }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? ModifiedOn { get; private set; }

        [Browsable(false)]
        public CrmOrganization Organization
        {
            get
            {
                return m_org;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else if (m_org == null)
                {
                    m_org = value;
                }
                else
                {
                    throw new NotSupportedException("Cannot change the Organization once it has been set");
                }
            }
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public int CustomizationLevel { get; set; }

        [Category("Information"), Browsable(true), Description("Unique identifier of Message Filter"), ReadOnly(true)]
        public Guid MessageEntityId { get; set; }

        [Category("Information"), Browsable(true), Description("Unique identifier of the Message"), ReadOnly(true)]
        public Guid MessageId { get; set; }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string PrimaryEntity { get; set; }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string SecondaryEntity { get; set; }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public CrmPluginStepDeployment Availability { get; set; }

        private static CrmEntityColumn[] m_entityColumns = null;

        [XmlIgnore, Browsable(false)]
        public static CrmEntityColumn[] Columns
        {
            get
            {
                if (m_entityColumns == null)
                {
                    m_entityColumns = new CrmEntityColumn[] {
                        new CrmEntityColumn("Id", null, typeof(Guid)),
                        new CrmEntityColumn("PrimaryEntity", "Primary Entity", typeof(string)),
                        new CrmEntityColumn("SecondaryEntity", "Secondary Entity", typeof(string)) };
                }

                return m_entityColumns;
            }
        }
        #endregion

        #region Public Helper Methodsd
        public void RefreshFromSdkMessageFilter(SdkMessageFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException("filter");
            }

            if (filter.SdkMessageFilterId != null)
            {
                MessageEntityId = filter.SdkMessageFilterId.Value;
            }

            if (filter.SdkMessageId != null)
            {
                MessageId = filter.SdkMessageId.Id;
            }

            if (!string.IsNullOrEmpty(filter.PrimaryObjectTypeCode))
            {
                PrimaryEntity = filter.PrimaryObjectTypeCode;
            }

            if (!string.IsNullOrEmpty(filter.SecondaryObjectTypeCode))
            {
                SecondaryEntity = filter.SecondaryObjectTypeCode;
            }

            if (filter.CustomizationLevel != null)
            {
                CustomizationLevel = filter.CustomizationLevel.Value;
            }

            if ((string.IsNullOrWhiteSpace(PrimaryEntity) || PrimaryEntity.Equals("none")) &&
                (string.IsNullOrWhiteSpace(SecondaryEntity) || SecondaryEntity.Equals("none")))
            {
                Availability = CrmPluginStepDeployment.Both;
            }
            else
            {
                Availability = (CrmPluginStepDeployment)Enum.ToObject(typeof(CrmPluginStepDeployment),
                    filter.Availability.GetValueOrDefault());
            }

            CreatedOn = filter.CreatedOn;
            ModifiedOn = filter.ModifiedOn;
        }

        public override string ToString()
        {
            return string.Format(System.Globalization.CultureInfo.InvariantCulture, "(Entity) {0}", PrimaryEntity);
        }
        #endregion

        #region Private Helper Methods
        private string ConvertNullStringToEmpty(string val)
        {
            if (string.IsNullOrEmpty(val))
            {
                return string.Empty;
            }
            else
            {
                return val;
            }
        }
        #endregion

        #region ICrmEntity Members
        [XmlIgnore, Browsable(false)]
        public bool IsSystemCrmEntity
        {
            get
            {
                return (CustomizationLevel == 0);
            }
        }

        [XmlIgnore, Browsable(false)]
        public string EntityType
        {
            get
            {
                return SdkMessageFilter.EntityLogicalName;
            }
        }

        [XmlIgnore, Browsable(false)]
        public Guid EntityId
        {
            get
            {
                return MessageEntityId;
            }
        }

        public Dictionary<string, object> GenerateCrmEntities()
        {
            Dictionary<string, object> entityList = new Dictionary<string, object>();

            SdkMessageFilter entity = new SdkMessageFilter();
            entity["sdkmessagefilterid"] = MessageEntityId;
            entity.SdkMessageId = new EntityReference(SdkMessage.EntityLogicalName, MessageId);
            entity["primaryobjecttypecode"] = PrimaryEntity;
            entity["secondaryobjecttypecode"] = SecondaryEntity;

            entityList.Add(SdkMessageFilter.EntityLogicalName, entity);

            return entityList;
        }

        [XmlIgnore, Browsable(false)]
        public Dictionary<string, object> Values
        {
            get
            {
                Dictionary<string, object> valueList = new Dictionary<string, object>();
                valueList.Add("Id", MessageEntityId);
                valueList.Add("PrimaryEntity", ConvertNullStringToEmpty(PrimaryEntity));
                valueList.Add("SecondaryEntity", ConvertNullStringToEmpty(SecondaryEntity));

                return valueList;
            }
        }

        public void UpdateDates(DateTime? createdOn, DateTime? modifiedOn)
        {
            if (createdOn != null)
            {
                CreatedOn = createdOn;
            }

            if (modifiedOn != null)
            {
                ModifiedOn = modifiedOn;
            }
        }
        #endregion
    }
}
