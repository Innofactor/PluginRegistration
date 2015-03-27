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

namespace PluginRegistrationTool.SDK
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using CrmSdk;

	public sealed class CrmMessage : ICrmEntity
	{
		private CrmOrganization m_org;
		private Guid m_messageId = Guid.Empty;
		private string m_messageName = null;
		private int m_customizationLevel = 0;
		private DateTime? m_createdOn = null;
		private DateTime? m_modifiedOn = null;
		private bool m_supportsFilteredAttributes = false;
		private List<ImageMessagePropertyName> m_messagePropertyNames;

		private CrmEntityDictionary<CrmMessageEntity> m_filterReadOnlyList = null;
		private Dictionary<Guid, CrmMessageEntity> m_filterList = new Dictionary<Guid, CrmMessageEntity>();

		public CrmMessage(CrmOrganization org)
		{
			this.m_org = org;
		}

		public CrmMessage(CrmOrganization org, Guid messageId, string messageName, bool supportsFilteredAttributes,
			int customizationLevel, DateTime? createdOn, DateTime? modifiedOn,
			List<ImageMessagePropertyName> imageMessagePropertyNames)
			: this(org)
		{
			this.MessageId = messageId;
			this.Name = messageName;
			this.CustomizationLevel = customizationLevel;
			this.SupportsFilteredAttributes = supportsFilteredAttributes;
			this.UpdateDates(createdOn, modifiedOn);

			this.m_messagePropertyNames = imageMessagePropertyNames;
		}

		public CrmMessage(CrmOrganization org, SdkMessage msg)
			: this(org)
		{
			this.RefreshFromSdkMessage(msg);
		}

		#region Properties
		/// <summary>
		/// Retrieves the Created On date of the entity. To update, see UpdateDates.
		/// </summary>
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public DateTime? CreatedOn
		{
			get
			{
				return this.m_createdOn;
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
				return this.m_modifiedOn;
			}
		}

		[Browsable(false)]
		public CrmOrganization Organization
		{
			get
			{
				return this.m_org;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				else if (this.m_org == null)
				{
					this.m_org = value;

					foreach (CrmMessageEntity entity in this.m_filterList.Values)
					{
						this.Organization.AddMessageEntity(this, entity);
					}
				}
				else
				{
					throw new NotSupportedException("Cannot change the Organization once it has been set");
				}
			}
		}

		[Category("Information"), Browsable(true), Description("Unique identifier of Message"), ReadOnly(true)]
		public Guid MessageId
		{
			get
			{
				return this.m_messageId;
			}

			set
			{
				this.m_messageId = value;
			}
		}

		[Category("Information"), Browsable(true), Description("Name of the Message"), ReadOnly(true)]
		public string Name
		{
			get
			{
				return this.m_messageName;
			}

			set
			{
				this.m_messageName = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public int CustomizationLevel
		{
			get
			{
				return this.m_customizationLevel;
			}
			set
			{
				this.m_customizationLevel = value;
			}
		}

		[Browsable(false)]
		public bool SupportsFilteredAttributes
		{
			get
			{
				return this.m_supportsFilteredAttributes;
			}

			set
			{
				this.m_supportsFilteredAttributes = value;
			}
		}

		[Browsable(false)]
		public List<ImageMessagePropertyName> ImageMessagePropertyNames
		{
			get
			{
				if (null == this.m_messagePropertyNames)
				{
					this.m_messagePropertyNames = new List<ImageMessagePropertyName>();
				}

				return this.m_messagePropertyNames;
			}
		}

		[Browsable(false)]
		public CrmMessageEntity this[Guid filterId]
		{
			get
			{
				return this.m_filterList[filterId];
			}
		}

		[Browsable(false)]
		public CrmEntityDictionary<CrmMessageEntity> MessageEntities
		{
			get
			{
				if (this.m_filterReadOnlyList == null)
				{
					this.m_filterReadOnlyList = new CrmEntityDictionary<CrmMessageEntity>(this.m_filterList);
				}

				return this.m_filterReadOnlyList;
			}
		}

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
						new CrmEntityColumn("Name", "Name", typeof(string)) };
				}

				return m_entityColumns;
			}
		}
		#endregion

		#region Public Helper Methods
		public void RefreshFromSdkMessage(SdkMessage msg)
		{
			if (msg == null)
			{
				throw new ArgumentNullException("msg");
			}

			if (msg.SdkMessageId != null)
			{
				this.MessageId = msg.SdkMessageId.Value;
			}

			if (msg.Name != null)
			{
				this.Name = msg.Name;
			}

			if (msg.CustomizationLevel != null)
			{
				this.CustomizationLevel = msg.CustomizationLevel.Value;
			}

			if (msg.CreatedOn != null && (msg.CreatedOn.HasValue))
			{
				this.m_createdOn = msg.CreatedOn.Value;
			}

			if (msg.ModifiedOn != null && (msg.ModifiedOn.HasValue))
			{
				this.m_modifiedOn = msg.ModifiedOn.Value;
			}
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
			List<CrmMessageEntity> matchList = this.FindMessageEntities(primaryEntity, secondaryEntity, true);
			if (matchList == null || matchList.Count == 0)
			{
				return null;
			}
			else
			{
				return matchList[0];
			}
		}

		/// <summary>
		/// Locate the message entities based on the primary or secondary entity (or both)
		/// </summary>
		/// <returns>Returns all CrmMessageEntity that match the criteria</returns>
		public CrmMessageEntity[] FindMessageEntities(string primaryEntity, string secondaryEntity)
		{
			return this.FindMessageEntities(primaryEntity, secondaryEntity, true).ToArray();
		}

		public override string ToString()
		{
			return string.Format(System.Globalization.CultureInfo.InvariantCulture, "(Message) {0}", this.Name);
		}

		#region Management Methods
		public void AddMessageEntity(CrmMessageEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}

			this.m_filterList.Add(entity.MessageEntityId, entity);

			if (this.Organization != null)
			{
				this.Organization.AddMessageEntity(this, entity);
			}
		}

		public void ClearMessageEntities()
		{
			this.m_filterList.Clear();

			if (this.Organization != null)
			{
				this.Organization.ClearMessageEntities(this.MessageId);
			}
		}

		public void RemoveMessageEntity(Guid messageEntityId)
		{
			if (this.m_filterList.ContainsKey(messageEntityId))
			{
				this.m_filterList.Remove(messageEntityId);

				if (this.Organization != null)
				{
					this.Organization.RemoveMessageEntity(this, messageEntityId);
				}
			}
			else
			{
				throw new ArgumentException("Invalid Message Entity Id", "messageEntityId");
			}
		}
		#endregion
		#endregion

		#region Private Helper Method
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
			List<CrmMessageEntity> msgList = new List<CrmMessageEntity>();

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

				foreach (CrmMessageEntity msg in this.m_filterList.Values)
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

				foreach (CrmMessageEntity msg in this.m_filterList.Values)
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
				msgList.Add(new CrmMessageEntity(this.Organization, this.MessageId, Guid.Empty, "none", "none",
					CrmPluginStepDeployment.Both, null, null));
			}

			return msgList;

		}
		#endregion

		#region ICrmEntity Members
		[XmlIgnore, Browsable(false)]
		public bool IsSystemCrmEntity
		{
			get
			{
				return (this.m_customizationLevel == 0);
			}
		}

		[XmlIgnore, Browsable(false)]
		public string EntityType
		{
			get
			{
				return CrmSdk.SdkMessageFilter.EntityLogicalName;
			}
		}

		[XmlIgnore, Browsable(false)]
		public Guid EntityId
		{
			get
			{
				return this.MessageId;
			}
		}

		public Dictionary<string, object> GenerateCrmEntities()
		{
			Dictionary<string, object> entityList = new Dictionary<string, object>();

			SdkMessage entity = new SdkMessage();

			entity.SdkMessageId = new Guid?();
			entity["sdkmessageid"] = this.MessageId;

			if (!string.IsNullOrEmpty(this.Name))
			{
				entity.Name = this.Name;
			}

			entityList.Add(SdkMessage.EntityLogicalName, entity);

			return entityList;
		}

		[XmlIgnore, Browsable(false)]
		public Dictionary<string, object> Values
		{
			get
			{
				Dictionary<string, object> valueList = new Dictionary<string, object>();
				valueList.Add("Id", this.MessageId);
				valueList.Add("Name", this.Name);

				return valueList;
			}
		}

		public void UpdateDates(DateTime? createdOn, DateTime? modifiedOn)
		{
			if (createdOn != null)
			{
				this.m_createdOn = createdOn;
			}

			if (modifiedOn != null)
			{
				this.m_modifiedOn = modifiedOn;
			}
		}
		#endregion
	}

	#region Private Class
	public sealed class ImageMessagePropertyName
	{
		private string _name;
		private string _label;
		private string _description;

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

			this._name = name;
			this._label = label;
			this._description = description;
		}

		public string Name
		{
			get
			{
				return this._name;
			}
		}

		public string Label
		{
			get
			{
				return this._label;
			}
		}

		public string Description
		{
			get
			{
				return this._description;
			}
		}
	}
	#endregion
}
