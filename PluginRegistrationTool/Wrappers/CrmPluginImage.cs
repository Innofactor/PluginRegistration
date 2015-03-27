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

namespace PluginRegistrationTool.Wrappers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Text;
    using System.Xml.Serialization;
    using Microsoft.Xrm.Sdk;
    using PluginRegistrationTool.Controls;
    using PluginRegistrationTool.Entities;

	public sealed class CrmPluginImage : ICrmEntity, ICrmTreeNode, ICloneable
	{
		private CrmOrganization m_org;
		private Guid m_assemblyId = Guid.Empty;
		private Guid m_pluginId = Guid.Empty;
		private Guid m_stepId = Guid.Empty;
		private Guid m_imageId = Guid.Empty;
		private string m_attributes = null;
		private string m_entityAlias = null;
		private string m_relatedAttribute = null;
		private CrmPluginImageType m_type = CrmPluginImageType.PostImage;
		private string m_propertyName;
		private string m_propertyTitle = null;
		private DateTime? m_createdOn = null;
		private DateTime? m_modifiedOn = null;
		private int m_customizationLevel = 1;

		public CrmPluginImage(CrmOrganization org)
		{
			this.m_org = org;
		}

		public CrmPluginImage(CrmOrganization org, Guid assemblyId, Guid pluginId, Guid stepId, Guid imageId, string attributes,
			string relatedAttribute, string entityAlias, CrmPluginImageType imageType, string messagePropertyName, int customizationLevel,
			DateTime? createdOn, DateTime? modifiedOn)
			: this(org)
		{
			this.AssemblyId = assemblyId;
			this.PluginId = pluginId;
			this.StepId = stepId;
			this.ImageId = imageId;
			this.Attributes = attributes;
			this.RelatedAttribute = relatedAttribute;
			this.EntityAlias = entityAlias;
			this.ImageType = imageType;
			this.MessagePropertyName = messagePropertyName;
			this.CustomizationLevel = customizationLevel;
			this.UpdateDates(createdOn, modifiedOn);
		}

		public CrmPluginImage(CrmOrganization org, Guid assemblyId, Guid pluginId, SdkMessageProcessingStepImage image)
			: this(org)
		{
			this.RefreshFromSdkMessageProcessingStepImage(assemblyId, pluginId, image);
		}

		#region Properties
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
					m_org = value;
				}
				else
				{
					throw new NotSupportedException("Cannot change the Organization once it has been set");
				}
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid AssemblyId
		{
			get
			{
				return this.m_assemblyId;
			}

			set
			{
				this.m_assemblyId = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid PluginId
		{
			get
			{
				return this.m_pluginId;
			}

			set
			{
				this.m_pluginId = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid StepId
		{
			get
			{
				return this.m_stepId;
			}

			set
			{
				this.m_stepId = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid ImageId
		{
			get
			{
				return this.m_imageId;
			}

			set
			{
				this.m_imageId = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Attributes
		{
			get
			{
				return this.m_attributes;
			}

			set
			{
				this.m_attributes = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Name
		{
			get;
			set;
		}
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

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string RelatedAttribute
		{
			get
			{
				return this.m_relatedAttribute;
			}

			set
			{
				this.m_relatedAttribute = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string EntityAlias
		{
			get
			{
				return this.m_entityAlias;
			}

			set
			{
				this.m_entityAlias = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginImageType ImageType
		{
			get
			{
				return this.m_type;
			}

			set
			{
				this.m_type = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string MessagePropertyName
		{
			get
			{
				return this.m_propertyName;
			}

			set
			{
				if (!string.Equals(this.m_propertyName, value))
				{
					this.m_propertyName = value;
					this.m_propertyTitle = null;
				}
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
				if (value < 0)
				{
					throw new ArgumentException("Invalid CustomizationLevel specified");
				}

				this.m_customizationLevel = value;
			}
		}
		#endregion

		#region Public Helper Methods
		public void RefreshFromSdkMessageProcessingStepImage(Guid assemblyId, Guid pluginId, SdkMessageProcessingStepImage image)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}

			this.AssemblyId = assemblyId;
			this.PluginId = pluginId;

			if (image.SdkMessageProcessingStepImageId != null)
			{
				this.ImageId = image.SdkMessageProcessingStepImageId.Value;
			}

			if (image.Attributes != null)
			{
				this.Attributes = image.Attributes1;
			}

			if (image.EntityAlias != null)
			{
				this.EntityAlias = image.EntityAlias;
			}

			if (image.MessagePropertyName != null)
			{
				this.MessagePropertyName = image.MessagePropertyName;
			}

			if (image.RelatedAttributeName != null)
			{
				this.RelatedAttribute = image.RelatedAttributeName;
			}

			if (image.SdkMessageProcessingStepId != null)
			{
				this.StepId = image.SdkMessageProcessingStepId.Id;
			}

			if (image.ImageType != null)
			{
				this.ImageType = (CrmPluginImageType)Enum.ToObject(typeof(CrmPluginImageType), image.ImageType.Value);
			}

			if (image.CustomizationLevel != null)
			{
				this.m_customizationLevel = image.CustomizationLevel.Value;
			}

			if (image.CreatedOn != null && (image.CreatedOn.HasValue))
			{
				this.m_createdOn = image.CreatedOn.Value;
			}

			if (image.ModifiedOn != null && (image.ModifiedOn.HasValue))
			{
				this.m_modifiedOn = image.ModifiedOn.Value;
			}

			this.Name = image.Name;
		}

		public override string ToString()
		{
			return this.NodeText;
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

		#region ICrmTreeNode Members
		[XmlIgnore]
		[Browsable(false)]
		public string NodeText
		{
			get
			{
				string attributeList = this.m_attributes;
				if (string.IsNullOrEmpty(attributeList))
				{
					attributeList = null;
				}
				else if (attributeList.Length > 100)
				{
					attributeList = string.Format("{0}...", attributeList.Substring(0, 97));
				}

				string imageLabel;
				switch (this.ImageType)
				{
					case CrmPluginImageType.PreImage:
						imageLabel = "Pre Image";
						break;
					case CrmPluginImageType.PostImage:
						imageLabel = "Post Image";
						break;
					case CrmPluginImageType.Both:
						imageLabel = "Pre & Post Image";
						break;
					default:
						throw new NotImplementedException("ImageType = " + this.ImageType.ToString());
				}

				//Retrieve the MessagePropertyName object
				if (this.m_propertyTitle == null)
				{
					if (string.IsNullOrEmpty(this.MessagePropertyName))
					{
						this.m_propertyTitle = string.Empty;
					}
					else if (this.Organization != null && this.Organization.Steps.ContainsKey(this.StepId))
					{
						CrmPluginStep step = this.Organization.Steps[this.StepId];

						Guid messageId;
						string primaryEntity;
						if (Guid.Empty == step.MessageEntityId)
						{
							messageId = step.MessageId;
							primaryEntity = null;
						}
						else
						{
							CrmMessageEntity messageEntity = this.Organization.MessageEntities[step.MessageEntityId];
							messageId = messageEntity.MessageId;
							primaryEntity = messageEntity.PrimaryEntity;
						}


						this.m_propertyTitle = string.Empty;

						//Determine the title of the property
						List<ImageMessagePropertyName> validProperties = this.m_org.Messages[messageId].ImageMessagePropertyNames;
						if (0 != validProperties.Count && !string.IsNullOrEmpty(this.m_propertyName))
						{
							foreach (ImageMessagePropertyName property in validProperties)
							{
								if (string.Equals(property.Name, this.m_propertyName, StringComparison.OrdinalIgnoreCase))
								{
									this.m_propertyTitle = property.Label;
									break;
								}
							}
						}
					}
					else
					{
						this.m_propertyTitle = null;
					}
				}

				StringBuilder sb = new StringBuilder();
				sb.AppendFormat("({0}) ", this.NodeTypeLabel);
				if (!string.IsNullOrEmpty(this.m_entityAlias))
				{
					sb.Append(this.EntityAlias);
				}
				else
				{
					sb.Append(imageLabel);
				}

				if (!string.IsNullOrEmpty(attributeList))
				{
					sb.AppendFormat(" ({0})", attributeList);
				}

				if (!string.IsNullOrEmpty(this.m_propertyTitle))
				{
					sb.AppendFormat(" - {0}", this.m_propertyTitle);
				}

				return sb.ToString();
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid NodeId
		{
			get
			{
				return this.m_imageId;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				return null;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeImageType
		{
			get
			{
				return CrmTreeNodeImageType.Image;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				return CrmTreeNodeImageType.ImageSelected;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeType NodeType
		{
			get
			{
				return CrmTreeNodeType.Image;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public string NodeTypeLabel
		{
			get
			{
				return "Image";
			}
		}
		#endregion

		#region ICrmEntity Members
		[XmlIgnore]
		[Browsable(false)]
		public string EntityType
		{
			get
			{
				return CrmSdk.SdkMessageProcessingStepImage.EntityLogicalName;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid EntityId
		{
			get
			{
				return this.m_imageId;
			}
		}

		public Dictionary<string, object> GenerateCrmEntities()
		{
			if (this.Organization != null)
			{
				CrmPluginStep step = this.Organization[this.AssemblyId][this.PluginId][this.StepId];
				return GenerateCrmEntities(step.MessageId, step.MessageEntityId);
			}
			return GenerateCrmEntities(Guid.Empty, Guid.Empty);
		}

		public Dictionary<string, object> GenerateCrmEntities(Guid sdkMessageId, Guid sdkMessageFilterId)
		{
			if (this.Organization != null)
			{
				if (string.IsNullOrEmpty(this.MessagePropertyName))
				{
					List<ImageMessagePropertyName> validImages = this.Organization.Messages[sdkMessageId].ImageMessagePropertyNames;
					if (0 != validImages.Count)
					{
						//Select the first one from the list
						this.MessagePropertyName = validImages[0].Name;
					}
				}
			}

			Dictionary<string, object> entityList = new Dictionary<string, object>();
			SdkMessageProcessingStepImage image = new SdkMessageProcessingStepImage();
			if (this.ImageId != Guid.Empty)
			{
				image.SdkMessageProcessingStepImageId = new Guid?();
				image["sdkmessageprocessingstepimageid"] = this.ImageId;
			}

			if (this.StepId != Guid.Empty)
			{
				image.SdkMessageProcessingStepId = new EntityReference();
				image.SdkMessageProcessingStepId.LogicalName = SdkMessageProcessingStep.EntityLogicalName;
				image.SdkMessageProcessingStepId.Id = this.StepId;
			}

			image.ImageType = new OptionSetValue();
			image.ImageType.Value = (int)this.ImageType;

			image.MessagePropertyName = this.MessagePropertyName;

			image.Name = this.Name;

			image.EntityAlias = this.EntityAlias;

			if (!string.IsNullOrEmpty(this.Attributes)) // null is all attributes
			{
				image.Attributes1 = this.Attributes;
			}
			else
			{
				image.Attributes1 = string.Empty;
			}
			if (!string.IsNullOrEmpty(this.RelatedAttribute))
			{
				image.RelatedAttributeName = this.RelatedAttribute; //For Related Entity Information
			}

			entityList.Add(SdkMessageProcessingStepImage.EntityLogicalName, image);

			return entityList;
		}
		private static CrmEntityColumn[] m_entityColumns = null;
		[XmlIgnore]
		public static CrmEntityColumn[] Columns
		{
			get
			{
				if (m_entityColumns == null)
				{
					m_entityColumns = new CrmEntityColumn[] { 
						new CrmEntityColumn("Name", "Name", typeof(string)),
						new CrmEntityColumn("EntityAlias", "Entity Alias", typeof(string)),
						new CrmEntityColumn("Type", "Image Type", typeof(string)),
						new CrmEntityColumn("Attributes", "Attributes", typeof(string)),
						new CrmEntityColumn("PropertyName", "Property Name", typeof(string)) ,
						new CrmEntityColumn("Id", "ImageId", typeof(Guid))};
				}

				return m_entityColumns;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Dictionary<string, object> Values
		{
			get
			{
				Dictionary<string, object> valueList = new Dictionary<string, object>();
				valueList.Add("Id", this.ImageId);
				valueList.Add("Name", String.IsNullOrEmpty(this.Name) ? string.Empty : this.Name);
				valueList.Add("EntityAlias", this.EntityAlias);
				valueList.Add("PropertyName", this.MessagePropertyName);

				if (string.IsNullOrEmpty(this.Attributes))
				{
					valueList.Add("Attributes", "All Attributes");
				}
				else
				{
					valueList.Add("Attributes", this.Attributes);
				}

				switch (this.ImageType)
				{
					case CrmPluginImageType.PreImage:

						valueList.Add("Type", "Pre Image");
						break;
					case CrmPluginImageType.PostImage:

						valueList.Add("Type", "Post Image");
						break;

					case CrmPluginImageType.Both:

						valueList.Add("Type", "Pre & Post Image");
						break;
					default:
						throw new NotImplementedException("ImageType = " + this.ImageType.ToString());
				}

				return valueList;
			}
		}

		[XmlIgnore]
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public bool IsSystemCrmEntity
		{
			get
			{
				return this.CustomizationLevel == 0;
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

		#region ICloneable Members
		public object Clone()
		{
			return this.Clone(true);
		}

		public CrmPluginImage Clone(bool includeOrganization)
		{
			CrmPluginImage newImage;
			if (includeOrganization)
			{
				newImage = new CrmPluginImage(this.m_org);
			}
			else
			{
				newImage = new CrmPluginImage(null);
			}

			newImage.m_assemblyId = this.m_assemblyId;
			newImage.m_attributes = this.m_attributes;
			newImage.m_createdOn = this.m_createdOn;
			newImage.m_customizationLevel = this.m_customizationLevel;
			newImage.m_entityAlias = this.m_entityAlias;
			newImage.m_imageId = this.m_imageId;
			newImage.m_modifiedOn = this.m_modifiedOn;
			newImage.m_pluginId = this.m_pluginId;
			newImage.m_propertyName = this.m_propertyName;
			newImage.m_propertyTitle = this.m_propertyTitle;
			newImage.m_relatedAttribute = this.m_relatedAttribute;
			newImage.m_stepId = this.m_stepId;
			newImage.m_type = this.m_type;

			return newImage;
		}
		#endregion
	}

	public enum CrmPluginImageType
	{
		PreImage = 0,
		PostImage = 1,
		Both = 2
	}
}
