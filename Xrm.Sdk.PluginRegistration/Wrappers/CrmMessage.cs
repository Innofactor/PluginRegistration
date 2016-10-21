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
    using Entities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;

    public sealed class CrmMessage : ICrmEntity
    {
        #region Private Fields

        private static CrmEntityColumn[] m_entityColumns = null;
        private DateTime? m_createdOn = null;
        private int m_customizationLevel = 0;
        private Dictionary<Guid, CrmMessageEntity> m_filterList = new Dictionary<Guid, CrmMessageEntity>();
        private CrmEntityDictionary<CrmMessageEntity> m_filterReadOnlyList = null;
        private Guid m_messageId = Guid.Empty;
        private string m_messageName = null;
        private List<ImageMessagePropertyName> m_messagePropertyNames;
        private DateTime? m_modifiedOn = null;
        private CrmOrganization m_org;
        private bool m_supportsFilteredAttributes = false;

        #endregion Private Fields

        #region Public Constructors

        public CrmMessage(CrmOrganization org)
        {
            m_org = org;
        }

        public CrmMessage(CrmOrganization org, Guid messageId, string messageName, bool supportsFilteredAttributes,
            int customizationLevel, DateTime? createdOn, DateTime? modifiedOn,
            List<ImageMessagePropertyName> imageMessagePropertyNames)
            : this(org)
        {
            MessageId = messageId;
            Name = messageName;
            CustomizationLevel = customizationLevel;
            SupportsFilteredAttributes = supportsFilteredAttributes;
            UpdateDates(createdOn, modifiedOn);

            m_messagePropertyNames = imageMessagePropertyNames;
        }

        public CrmMessage(CrmOrganization org, SdkMessage msg)
            : this(org)
        {
            RefreshFromSdkMessage(msg);
        }

        #endregion Public Constructors

        #region Public Properties

        [XmlIgnore, Browsable(false)]
        public static CrmEntityColumn[] Columns
        {
            get
            {
                if (m_entityColumns == null)
                {
                    m_entityColumns = new CrmEntityColumn[] {
                        new CrmEntityColumn("Id", null, typeof(Guid)),
                        new CrmEntityColumn("Name", "Name", typeof(string)) };
                }

                return m_entityColumns;
            }
        }

        /// <summary>
        /// Retrieves the Created On date of the entity. To update, see UpdateDates.
        /// </summary>
        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? CreatedOn
        {
            get
            {
                return m_createdOn;
            }
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public int CustomizationLevel
        {
            get
            {
                return m_customizationLevel;
            }
            set
            {
                m_customizationLevel = value;
            }
        }

        [XmlIgnore, Browsable(false)]
        public Guid EntityId
        {
            get
            {
                return MessageId;
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

        [Browsable(false)]
        public List<ImageMessagePropertyName> ImageMessagePropertyNames
        {
            get
            {
                if (null == m_messagePropertyNames)
                {
                    m_messagePropertyNames = new List<ImageMessagePropertyName>();
                }

                return m_messagePropertyNames;
            }
        }

        [XmlIgnore, Browsable(false)]
        public bool IsSystemCrmEntity
        {
            get
            {
                return (m_customizationLevel == 0);
            }
        }

        [Browsable(false)]
        public CrmEntityDictionary<CrmMessageEntity> MessageEntities
        {
            get
            {
                if (m_filterReadOnlyList == null)
                {
                    m_filterReadOnlyList = new CrmEntityDictionary<CrmMessageEntity>(m_filterList);
                }

                return m_filterReadOnlyList;
            }
        }

        [Category("Information"), Browsable(true), Description("Unique identifier of Message"), ReadOnly(true)]
        public Guid MessageId
        {
            get
            {
                return m_messageId;
            }

            set
            {
                m_messageId = value;
            }
        }

        /// <summary>
        /// Retrieves the Modified On date of the entity. To update, see UpdateDates.
        /// </summary>
        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? ModifiedOn
        {
            get
            {
                return m_modifiedOn;
            }
        }

        [Category("Information"), Browsable(true), Description("Name of the Message"), ReadOnly(true)]
        public string Name
        {
            get
            {
                return m_messageName;
            }

            set
            {
                m_messageName = value;
            }
        }

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

                    foreach (CrmMessageEntity entity in m_filterList.Values)
                    {
                        Organization.AddMessageEntity(this, entity);
                    }
                }
                else
                {
                    throw new NotSupportedException("Cannot change the Organization once it has been set");
                }
            }
        }

        [Browsable(false)]
        public bool SupportsFilteredAttributes
        {
            get
            {
                return m_supportsFilteredAttributes;
            }

            set
            {
                m_supportsFilteredAttributes = value;
            }
        }

        [XmlIgnore, Browsable(false)]
        public Dictionary<string, object> Values
        {
            get
            {
                var valueList = new Dictionary<string, object>();
                valueList.Add("Id", MessageId);
                valueList.Add("Name", Name);

                return valueList;
            }
        }

        #endregion Public Properties

        #region Public Indexers

        [Browsable(false)]
        public CrmMessageEntity this[Guid filterId]
        {
            get
            {
                return m_filterList[filterId];
            }
        }

        #endregion Public Indexers

        #region Public Methods

        public void AddMessageEntity(CrmMessageEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            m_filterList.Add(entity.MessageEntityId, entity);

            if (Organization != null)
            {
                Organization.AddMessageEntity(this, entity);
            }
        }

        public void ClearMessageEntities()
        {
            m_filterList.Clear();

            if (Organization != null)
            {
                Organization.ClearMessageEntities(MessageId);
            }
        }

        /// <summary>
        /// Locate the message entities based on the primary or secondary entity (or both)
        /// </summary>
        /// <returns>Returns all CrmMessageEntity that match the criteria</returns>
        public CrmMessageEntity[] FindMessageEntities(string primaryEntity, string secondaryEntity)
        {
            return FindMessageEntities(primaryEntity, secondaryEntity, true).ToArray();
        }

        /// <summary>
        /// Locate the message entity based on the primary or secondary entity (or both)
        /// </summary>
        /// <returns>First CrmMessageEntity that matches the criteria</returns>
        public CrmMessageEntity FindMessageEntity(string primaryEntity, string secondaryEntity)
        {
            if (string.IsNullOrEmpty(primaryEntity) && string.IsNullOrEmpty(secondaryEntity))
            {
                return null;
            }
            List<CrmMessageEntity> matchList = FindMessageEntities(primaryEntity, secondaryEntity, true);
            if (matchList == null || matchList.Count == 0)
            {
                return null;
            }
            else
            {
                return matchList[0];
            }
        }

        public Dictionary<string, object> GenerateCrmEntities()
        {
            var entityList = new Dictionary<string, object>();

            var entity = new SdkMessage();

            entity.SdkMessageId = new Guid?();
            entity["sdkmessageid"] = MessageId;

            if (!string.IsNullOrEmpty(Name))
            {
                entity.Name = Name;
            }

            entityList.Add(SdkMessage.EntityLogicalName, entity);

            return entityList;
        }

        public void RefreshFromSdkMessage(SdkMessage msg)
        {
            if (msg == null)
            {
                throw new ArgumentNullException("msg");
            }

            if (msg.SdkMessageId != null)
            {
                MessageId = msg.SdkMessageId.Value;
            }

            if (msg.Name != null)
            {
                Name = msg.Name;
            }

            if (msg.CustomizationLevel != null)
            {
                CustomizationLevel = msg.CustomizationLevel.Value;
            }

            if (msg.CreatedOn != null && (msg.CreatedOn.HasValue))
            {
                m_createdOn = msg.CreatedOn.Value;
            }

            if (msg.ModifiedOn != null && (msg.ModifiedOn.HasValue))
            {
                m_modifiedOn = msg.ModifiedOn.Value;
            }
        }

        public void RemoveMessageEntity(Guid messageEntityId)
        {
            if (m_filterList.ContainsKey(messageEntityId))
            {
                m_filterList.Remove(messageEntityId);

                if (Organization != null)
                {
                    Organization.RemoveMessageEntity(this, messageEntityId);
                }
            }
            else
            {
                throw new ArgumentException("Invalid Message Entity Id", "messageEntityId");
            }
        }

        public override string ToString()
        {
            return string.Format(System.Globalization.CultureInfo.InvariantCulture, "(Message) {0}", Name);
        }

        public void UpdateDates(DateTime? createdOn, DateTime? modifiedOn)
        {
            if (createdOn != null)
            {
                m_createdOn = createdOn;
            }

            if (modifiedOn != null)
            {
                m_modifiedOn = modifiedOn;
            }
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// primaryEntity = NULL and secondaryEntity = null shall return complete list of entities.
        /// </summary>
        /// <param name="primaryEntity"></param>
        /// <param name="secondaryEntity"></param>
        /// <param name="stopAtFirstMatch"></param>
        /// <returns></returns>
        private List<CrmMessageEntity> FindMessageEntities(string primaryEntity, string secondaryEntity,
            bool stopAtFirstMatch)
        {
            bool hasNoneNone = false;
            var msgList = new List<CrmMessageEntity>();

            bool findNoneNone;
            if ((string.IsNullOrEmpty(primaryEntity) || primaryEntity.Equals("none", StringComparison.InvariantCultureIgnoreCase)) &&
                (string.IsNullOrEmpty(secondaryEntity) || secondaryEntity.Equals("none", StringComparison.InvariantCultureIgnoreCase)))
            {
                findNoneNone = true;
            }
            else
            {
                findNoneNone = false;
            }

            if (string.IsNullOrEmpty(primaryEntity) && string.IsNullOrEmpty(secondaryEntity))
            {
                // Get all the MessageEntities and add 'none', 'none'

                foreach (CrmMessageEntity msg in m_filterList.Values)
                {
                    if (!hasNoneNone && msg.PrimaryEntity == "none" && msg.SecondaryEntity == "none")
                    {
                        hasNoneNone = true;
                    }

                    msgList.Add(msg);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(primaryEntity))
                {
                    primaryEntity = primaryEntity.Trim();
                }
                if (!string.IsNullOrEmpty(secondaryEntity))
                {
                    secondaryEntity = secondaryEntity.Trim();
                }

                foreach (CrmMessageEntity msg in m_filterList.Values)
                {
                    if (!string.IsNullOrEmpty(primaryEntity) && !primaryEntity.Equals(msg.PrimaryEntity, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    if (!string.IsNullOrEmpty(secondaryEntity) && !secondaryEntity.Equals(msg.SecondaryEntity, StringComparison.InvariantCultureIgnoreCase))
                    {
                        continue;
                    }

                    if (!hasNoneNone && msg.PrimaryEntity == "none" && msg.SecondaryEntity == "none")
                    {
                        hasNoneNone = true;
                    }

                    msgList.Add(msg);

                    if (stopAtFirstMatch)
                    {
                        break;
                    }
                }

                //If we are not looking specifically for none, we don't want to add it.
                if (!findNoneNone)
                {
                    hasNoneNone = true;
                }
            }

            if (!hasNoneNone)
            {
                msgList.Add(new CrmMessageEntity(Organization, MessageId, Guid.Empty, "none", "none",
                    CrmPluginStepDeployment.Both, null, null));
            }

            return msgList;
        }

        #endregion Private Methods
    }

    public sealed class ImageMessagePropertyName
    {
        #region Private Fields

        private string _description;
        private string _label;
        private string _name;

        #endregion Private Fields

        #region Public Constructors

        public ImageMessagePropertyName(string name, string label)
            : this(name, label, null)
        {
        }

        public ImageMessagePropertyName(string name, string label, string description)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            else if (string.IsNullOrEmpty(label))
            {
                throw new ArgumentNullException("label");
            }

            _name = name;
            _label = label;
            _description = description;
        }

        #endregion Public Constructors

        #region Public Properties

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        #endregion Public Properties
    }
}