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
    using Microsoft.Xrm.Sdk;
    using PluginRegistrationTool.Controls;

	public sealed class CrmPluginStep : ICrmEntity, ICrmTreeNode, ICloneable
	{
		public const string RelationshipStepToSecureConfig = "sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep";
		public const string RelationshipStepToImage = "sdkmessageprocessingstepid_sdkmessageprocessingstepimage";

		private CrmOrganization m_org;
		private Guid m_assemblyId = Guid.Empty;
		private Guid m_pluginId = Guid.Empty;
		private int m_customizationLevel = 1;
		private string m_filteringAttributes = null;
		private DateTime? m_createdOn = null;
		private DateTime? m_modifiedOn = null;
		private Guid m_serviceBusConfigurationId = Guid.Empty;

		private CrmEntityDictionary<CrmPluginImage> m_imageReadOnlyList = null;
		private Dictionary<Guid, CrmPluginImage> m_imageList = new Dictionary<Guid, CrmPluginImage>();

		public CrmPluginStep(CrmOrganization org)
		{
			this.m_org = org;
			this.Enabled = true;
			this.Mode = CrmPluginStepMode.Synchronous;
			this.Stage = CrmPluginStepStage.PostOperationDeprecated;
			this.Rank = 1;
			this.Deployment = CrmPluginStepDeployment.ServerOnly;
		}

		public CrmPluginStep(CrmOrganization org, Guid assemblyId, Guid pluginId, Guid stepId, Guid messageId, Guid messageEntityId,
			string name, string unsecureConfiguration, Guid secureConfigurationId, string secureConfiguration,
			Guid impersonatingUserId, CrmPluginStepMode mode, CrmPluginStepStage stage,
			CrmPluginStepDeployment deployment, CrmPluginStepInvocationSource? invocationSource, int rank, bool enabled,
			int customizationLevel, DateTime? createdOn, DateTime? modifiedOn, string filteringAttributes, Guid serviceBusConfigurationId)
			: this(org)
		{
			this.AssemblyId = assemblyId;
			this.Deployment = deployment;
			this.Name = name;
			this.Enabled = enabled;
			this.ImpersonatingUserId = impersonatingUserId;
			this.InvocationSource = invocationSource;
			this.MessageEntityId = messageEntityId;
			this.MessageId = messageId;
			this.Mode = mode;
			this.PluginId = pluginId;
			this.Rank = rank;
			this.SecureConfigurationId = secureConfigurationId;
			this.SecureConfiguration = secureConfiguration;
			this.Stage = stage;
			this.StepId = stepId;
			this.CustomizationLevel = customizationLevel;
			this.UnsecureConfiguration = unsecureConfiguration;
			this.FilteringAttributes = filteringAttributes;
			this.m_createdOn = createdOn;
			this.m_modifiedOn = modifiedOn;
			this.m_serviceBusConfigurationId = serviceBusConfigurationId;
		}

		public CrmPluginStep(CrmOrganization org, Guid assemblyId, SdkMessageProcessingStep step, string secureConfig)
			: this(org)
		{
			if (step == null)
			{
				throw new ArgumentNullException("step");
			}

			this.RefreshFromSdkMessageProcessingStep(assemblyId, step, secureConfig);
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
					m_org = value;
					foreach (CrmPluginImage image in this.m_imageList.Values)
					{
						if (image.Organization == null)
						{
							image.Organization = m_org;
						}
						m_org.AddImage(this, image);
					}
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
				if (value == this.m_assemblyId)
				{
					return;
				}

				this.m_assemblyId = value;

				if (this.m_imageList != null)
				{
					foreach (CrmPluginImage image in this.m_imageList.Values)
					{
						image.AssemblyId = value;
					}
				}
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
				if (value == this.m_pluginId)
				{
					return;
				}

				this.m_pluginId = value;

				if (this.m_imageList != null)
				{
					foreach (CrmPluginImage image in this.m_imageList.Values)
					{
						image.PluginId = value;
					}
				}
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public EntityReference EventHandler { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid ServiceBusConfigurationId
		{
			get
			{
				return this.m_serviceBusConfigurationId;
			}

			set
			{
				this.m_serviceBusConfigurationId = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid StepId { get; set; }

		[Browsable(false)]
		public bool Enabled { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginStepMode Mode { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginStepStage Stage { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid MessageId { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public int Rank { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string FilteringAttributes { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginStepDeployment Deployment { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginStepInvocationSource? InvocationSource { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Name { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Description { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string UnsecureConfiguration { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid SecureConfigurationId { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string SecureConfiguration { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid ImpersonatingUserId { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid MessageEntityId { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public bool DeleteAsyncOperationIfSuccessful { get; set; }

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

		[Browsable(false)]
		public CrmPluginImage this[Guid imageId]
		{
			get
			{
				return this.m_imageList[imageId];
			}
		}

		[Browsable(false)]
		public CrmEntityDictionary<CrmPluginImage> Images
		{
			get
			{
				if (this.m_imageReadOnlyList == null)
				{
					this.m_imageReadOnlyList = new CrmEntityDictionary<CrmPluginImage>(this.m_imageList);
				}

				return this.m_imageReadOnlyList;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public bool SecureConfigurationRecordIdInvalid { get; set; }

		[Browsable(false)]
		public bool IsProfiled
		{
			get
			{
				return (null != this.ProfilerStepId);
			}
		}

		[Browsable(false)]
		public Guid? ProfilerStepId { get; set; }

		/// <summary>
		/// ID for the Step that is being profiled
		/// </summary>
		[Browsable(false)]
		public Guid? ProfilerOriginalStepId { get; set; }
		#endregion

		#region Public Helper Methods
		public void RefreshFromSdkMessageProcessingStep(Guid assemblyId, SdkMessageProcessingStep step, string secureConfig)
		{
			if (step == null)
			{
				throw new ArgumentNullException("step");
			}

			if (step.SupportedDeployment != null)
			{
				this.Deployment = (CrmPluginStepDeployment)Enum.ToObject(typeof(CrmPluginStepDeployment), step.SupportedDeployment.Value);
			}

			if (step.StateCode != null)
			{
				this.Enabled = (step.StateCode.Value == SdkMessageProcessingStepState.Enabled);
			}

			if (step.ImpersonatingUserId != null)
			{
				this.ImpersonatingUserId = step.ImpersonatingUserId.Id;
			}

#pragma warning disable 0612
			if (step.InvocationSource != null)
			{
				this.InvocationSource = (CrmPluginStepInvocationSource)Enum.ToObject(typeof(CrmPluginStepInvocationSource), step.InvocationSource.Value);
			}
#pragma warning restore 0612

			if (step.SdkMessageFilterId != null)
			{
				this.MessageEntityId = step.SdkMessageFilterId.Id;
			}

			if (step.SdkMessageId != null)
			{
				this.MessageId = step.SdkMessageId.Id;
			}

			if (step.Mode != null)
			{
				this.Mode = (CrmPluginStepMode)Enum.ToObject(typeof(CrmPluginStepMode), step.Mode.Value);
			}

			if (step.CreatedOn != null && (step.CreatedOn.HasValue))
			{
				this.m_createdOn = step.CreatedOn.Value;
			}

			if (step.ModifiedOn != null && (step.ModifiedOn.HasValue))
			{
				this.m_modifiedOn = step.ModifiedOn.Value;
			}

#pragma warning disable 0612
			if (step.PluginTypeId != null)
			{
				this.PluginId = step.PluginTypeId.Id;
			}
#pragma warning restore 0612

			if (step.Rank != null && (step.Rank.HasValue))
			{
				this.Rank = step.Rank.Value;
			}

			if (step.SdkMessageProcessingStepSecureConfigId != null)
			{
				this.SecureConfigurationId = step.SdkMessageProcessingStepSecureConfigId.Id;
				this.SecureConfiguration = secureConfig;
			}
			else
			{
				this.SecureConfiguration = null;
				this.SecureConfigurationId = Guid.Empty;
			}

			// Step can be unregistered as ExchangeRate plugin Can be replaced to ISV Plugin. So 'customizationlevel' logic is no longer valid here.
			this.CustomizationLevel = 1;

			if (step.Stage != null)
			{
				this.Stage = (CrmPluginStepStage)Enum.ToObject(typeof(CrmPluginStepStage), step.Stage.Value);
			}

			this.AssemblyId = assemblyId;

			if (step.SdkMessageProcessingStepId != null)
			{
				this.StepId = step.SdkMessageProcessingStepId.Value;
			}

			if (step.Configuration != null)
			{
				this.UnsecureConfiguration = step.Configuration;
			}
			else
			{
				this.UnsecureConfiguration = null;
			}

			if (step.EventHandler != null)
			{
				this.EventHandler = step.EventHandler;
				if (EventHandler.LogicalName == ServiceEndpoint.EntityLogicalName)
				{
					this.ServiceBusConfigurationId = step.EventHandler.Id;
				}
			}

			this.Name = step.Name;

			this.Description = step.Description;

			this.FilteringAttributes = step.FilteringAttributes;

			if (step.AsyncAutoDelete != null)
			{
				this.DeleteAsyncOperationIfSuccessful = (bool)step.AsyncAutoDelete;
			}
		}

		public override string ToString()
		{
			return this.NodeText;
		}

		#region Management Methods
		public void AddImage(CrmPluginImage image)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}

			this.m_imageList.Add(image.ImageId, image);

			if (this.Organization != null)
			{
				this.Organization.AddImage(this, image);
			}
		}

		public void ClearImages()
		{
			this.m_imageList.Clear();

			if (this.Organization != null)
			{
				this.Organization.ClearImages(this.StepId);
			}
		}

		public void RemoveImage(Guid imageId)
		{
			if (this.m_imageList.ContainsKey(imageId))
			{
				this.m_imageList.Remove(imageId);

				if (this.Organization != null)
				{
					this.Organization.RemoveImage(this, imageId);
				}
			}
			else
			{
				throw new ArgumentException("Invalid Image Id", "imageId");
			}
		}
		#endregion
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

		#region ICrmTreeItem Members
		[XmlIgnore]
		[Browsable(false)]
		public string NodeText
		{
			get
			{
				return string.Format("({0}) {1}", this.NodeTypeLabel, string.IsNullOrWhiteSpace(this.Name) ? this.Description : this.Name);
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid NodeId
		{
			get
			{
				return this.StepId;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				if (this.m_imageList == null || this.m_imageList.Count == 0)
				{
					return new CrmPluginImage[0];
				}
				else
				{
					CrmPluginImage[] children = new CrmPluginImage[this.m_imageList.Count];
					this.m_imageList.Values.CopyTo(children, 0);

					return children;
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeImageType
		{
			get
			{
				if (this.IsProfiled)
				{
					return CrmTreeNodeImageType.StepProfiled;
				}
				else if (this.Enabled)
				{
					return CrmTreeNodeImageType.StepEnabled;
				}
				else
				{
					return CrmTreeNodeImageType.StepDisabled;
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				if (this.IsProfiled)
				{
					return CrmTreeNodeImageType.StepProfiledSelected;
				}
				else if (this.Enabled)
				{
					return CrmTreeNodeImageType.StepEnabledSelected;
				}
				else
				{
					return CrmTreeNodeImageType.StepDisabledSelected;
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeType NodeType
		{
			get
			{
				return CrmTreeNodeType.Step;
			}
		}


		[XmlIgnore]
		[Browsable(false)]
		public string NodeTypeLabel
		{
			get
			{
				return "Step";
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
				return CrmSdk.SdkMessageProcessingStep.EntityLogicalName;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid EntityId
		{
			get
			{
				return this.StepId;
			}
		}

		public Dictionary<string, object> GenerateCrmEntities()
		{
			Dictionary<string, object> entityList = new Dictionary<string, object>();
			//Check for Permissions denied
			bool saveSecureConfiguration = true;
			if (this.Organization != null)
			{
				saveSecureConfiguration = !this.Organization.SecureConfigurationPermissionDenied;
			}

			//Create the secure configuration entity
			SdkMessageProcessingStep sdkStep = new SdkMessageProcessingStep();
			// For Create cases, SecureConfig != null , SecureConfigurationId = null

			//For Update cases SecureConfigurationId != null , SecureConfig=null
			if (!string.IsNullOrEmpty(this.SecureConfiguration))
			{
				SdkMessageProcessingStepSecureConfig sdkSecureConfig = new SdkMessageProcessingStepSecureConfig();
				if (this.SecureConfigurationId != Guid.Empty)
				{
					sdkSecureConfig.SdkMessageProcessingStepSecureConfigId = new Guid?();
					sdkSecureConfig["sdkmessageprocessingstepsecureconfigid"] = this.SecureConfigurationId;

					sdkStep.SdkMessageProcessingStepSecureConfigId = new EntityReference();
					sdkStep.SdkMessageProcessingStepSecureConfigId.LogicalName = SdkMessageProcessingStepSecureConfig.EntityLogicalName;
					sdkStep.SdkMessageProcessingStepSecureConfigId.Id = this.SecureConfigurationId;
				}

				sdkSecureConfig.SecureConfig = this.SecureConfiguration;

				entityList.Add(SdkMessageProcessingStepSecureConfig.EntityLogicalName, sdkSecureConfig);
			}

			//Create the main entity
			if (this.StepId != Guid.Empty)
			{
				sdkStep.SdkMessageProcessingStepId = new Guid?();
				sdkStep["sdkmessageprocessingstepid"] = this.StepId;
			}

			sdkStep.Configuration = this.UnsecureConfiguration;


			if (this.ServiceBusConfigurationId == Guid.Empty)
			{
				sdkStep.EventHandler = new EntityReference(PluginType.EntityLogicalName, this.PluginId);
			}
			else
			{
				sdkStep.EventHandler = new EntityReference(ServiceEndpoint.EntityLogicalName, this.ServiceBusConfigurationId);
			}

			sdkStep.Name = this.Name;


			sdkStep.Mode = new OptionSetValue();
			sdkStep.Mode.Value = (int)this.Mode;

			sdkStep.Rank = new int?();
			sdkStep["rank"] = this.Rank;

			if (null != this.InvocationSource)
			{
#pragma warning disable 0612
				sdkStep.InvocationSource = new OptionSetValue((int)this.InvocationSource);
#pragma warning restore 0612
			}

			sdkStep.SdkMessageId = new EntityReference();
			sdkStep.SdkMessageId.LogicalName = SdkMessage.EntityLogicalName;

			sdkStep.SdkMessageFilterId = new EntityReference();
			sdkStep.SdkMessageFilterId.LogicalName = SdkMessageFilter.EntityLogicalName;

			if (this.MessageId == Guid.Empty)
			{
				sdkStep.SdkMessageId = null;
			}
			else
			{
				sdkStep.SdkMessageId.Id = this.MessageId;
			}
			if (this.MessageEntityId == Guid.Empty)
			{
				sdkStep.SdkMessageFilterId = null;
			}
			else
			{
				sdkStep.SdkMessageFilterId.Id = this.MessageEntityId;
			}
			sdkStep.ImpersonatingUserId = new EntityReference();
			sdkStep.ImpersonatingUserId.LogicalName = SystemUser.EntityLogicalName;

			if (this.ImpersonatingUserId != Guid.Empty)
			{
				sdkStep.ImpersonatingUserId.Id = this.ImpersonatingUserId;
			}
			else
			{
				sdkStep.ImpersonatingUserId = null;
			}

			sdkStep.Stage = new OptionSetValue();
			sdkStep.Stage.Value = (int)this.Stage;

			sdkStep.SupportedDeployment = new OptionSetValue();
			sdkStep.SupportedDeployment.Value = (int)this.Deployment;

			if (string.IsNullOrEmpty(this.FilteringAttributes))
			{
				sdkStep.FilteringAttributes = string.Empty;
			}
			else
			{
				sdkStep.FilteringAttributes = this.FilteringAttributes;
			}

			sdkStep.AsyncAutoDelete = this.DeleteAsyncOperationIfSuccessful;

			sdkStep.Description = this.Description;

			entityList.Add(SdkMessageProcessingStep.EntityLogicalName, sdkStep);

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
						new CrmEntityColumn("CreatedOn", "Created On", typeof(string)),
						new CrmEntityColumn("ModifiedOn", "Modified On", typeof(string)),
						new CrmEntityColumn("Message", "Message", typeof(string)),
						new CrmEntityColumn("PrimaryEntity", "PrimaryEntity", typeof(string)),
						new CrmEntityColumn("SecondaryEntity", "SecondaryEntity", typeof(string)),
						new CrmEntityColumn("TypeName", "TypeName", typeof(string)),
						new CrmEntityColumn("FilteringAttributes", "Filtering Attributes", typeof(string)),
						new CrmEntityColumn("Impersonate", "Impersonate", typeof(string)),
						new CrmEntityColumn("Mode", "Mode", typeof(string)),
						new CrmEntityColumn("Deployment", "Deployment", typeof(string)),
						new CrmEntityColumn("Invocation", "Invocation", typeof(string)),
						new CrmEntityColumn("Stage", "Stage", typeof(string)),
						new CrmEntityColumn("Enabled", "Enabled", typeof(bool)),
						new CrmEntityColumn("Rank", "Rank", typeof(int)),
						new CrmEntityColumn("Description", "Description", typeof(string)),
						new CrmEntityColumn("UnsecureConfiguration", "Unsecure Configuration", typeof(string)),
						new CrmEntityColumn("SecureConfiguration", "Secure Configuration", typeof(string)),
						new CrmEntityColumn("MessageId", "MessageId", typeof(string)),
						new CrmEntityColumn("MessageEntityId", "MessageEntityId", typeof(string)),
						new CrmEntityColumn("Id", "StepId", typeof(Guid)),
						new CrmEntityColumn("ServiceBusConfigurationId", "ServiceBus Config", typeof(Guid)),
						new CrmEntityColumn("DeleteAsyncOperationIfSuccessful", "Delete Async.", typeof(string))
						};
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
				valueList.Add("Id", this.StepId);
				valueList.Add("Name", ConvertNullStringToEmpty(this.Name));
				valueList.Add("CreatedOn", this.CreatedOn.HasValue ? this.CreatedOn.ToString() : "");
				valueList.Add("ModifiedOn", this.ModifiedOn.HasValue ? this.ModifiedOn.ToString() : "");

				if (this.MessageId == Guid.Empty)
				{
					valueList.Add("Message", string.Empty);
					valueList.Add("MessageId", Guid.Empty.ToString());
					valueList.Add("MessageEntityId", this.MessageEntityId.ToString());
					valueList.Add("PrimaryEntity", string.Empty);
					valueList.Add("SecondaryEntity", string.Empty);
				}
				else if (this.Organization == null)
				{
					valueList.Add("Message", this.MessageId.ToString());
					valueList.Add("MessageId", MessageId.ToString());
					valueList.Add("MessageEntityId", this.MessageEntityId.ToString());
					valueList.Add("PrimaryEntity", this.MessageEntityId.ToString());
					valueList.Add("SecondaryEntity", this.MessageEntityId.ToString());
				}
				else
				{
					valueList.Add("MessageId", MessageId.ToString());
					valueList.Add("MessageEntityId", this.MessageEntityId.ToString());

					if (this.Organization.Messages.ContainsKey(this.MessageId))
					{
						valueList.Add("Message", this.Organization.Messages[this.MessageId].Name);

						if (this.Organization.Messages[this.MessageId].MessageEntities.ContainsKey(this.MessageEntityId))
						{
							valueList.Add("PrimaryEntity", this.Organization.Messages[this.MessageId][MessageEntityId].PrimaryEntity);
							valueList.Add("SecondaryEntity", this.Organization.Messages[this.MessageId][MessageEntityId].SecondaryEntity);
						}
						else if (MessageEntityId == Guid.Empty)
						{
							valueList.Add("PrimaryEntity", "none");
							valueList.Add("SecondaryEntity", "none");
						}
						else
						{
							valueList.Add("PrimaryEntity", "Invalid MessageFilterId");
							valueList.Add("SecondaryEntity", "Invalid MessageFilterId");
						}
					}
					else
					{
						valueList.Add("Message", "Invalid Message");
						valueList.Add("PrimaryEntity", string.Empty);
						valueList.Add("SecondaryEntity", string.Empty);
					}
				}
				if (this.Organization != null && this.Organization.Plugins != null && this.Organization.Plugins.ContainsKey(this.PluginId))
				{
					valueList.Add("TypeName", this.Organization.Plugins[this.PluginId].TypeName);
				}
				else
				{
					valueList.Add("TypeName", "Error - Unable to retrieve the TypeName");
				}

				if (this.ImpersonatingUserId == Guid.Empty)
				{
					valueList.Add("Impersonate", "Calling User");
				}
				else if (this.Organization == null)
				{
					valueList.Add("Impersonate", this.ImpersonatingUserId.ToString());
				}
				else if (this.Organization.Users.ContainsKey(this.ImpersonatingUserId))
				{
					valueList.Add("Impersonate", this.Organization.Users[this.ImpersonatingUserId].Name);
				}
				else
				{
					valueList.Add("Impersonate", "Invalid User");
				}
				valueList.Add("Mode", this.Mode.ToString());

				switch (this.Stage)
				{
					case CrmPluginStepStage.PreValidation:

						valueList.Add("Stage", "Pre Stage - Outside Transaction");
						break;
					case CrmPluginStepStage.PreOperation:

						valueList.Add("Stage", "Pre Stage - Inside Transaction");
						break;
					case CrmPluginStepStage.PostOperation:

						valueList.Add("Stage", "Post Stage - Inside Transaction");
						break;
					case CrmPluginStepStage.PostOperationDeprecated:

						valueList.Add("Stage", "Post Stage - Outside Transaction");
						break;
					default:
						throw new NotImplementedException("Stage = " + this.Stage.ToString());
				}

				switch (this.Deployment)
				{
					case CrmPluginStepDeployment.ServerOnly:

						valueList.Add("Deployment", "Server Only");
						break;

					case CrmPluginStepDeployment.OfflineOnly:

						valueList.Add("Deployment", "Offline Only");
						break;

					case CrmPluginStepDeployment.Both:

						valueList.Add("Deployment", "Server & Offline");
						break;

					default:
						throw new NotImplementedException("Deployment = " + this.Deployment.ToString());
				}

				switch (this.InvocationSource)
				{
					case CrmPluginStepInvocationSource.Parent:

						valueList.Add("Invocation", "Parent Pipeline");
						break;

					case CrmPluginStepInvocationSource.Child:

						valueList.Add("Invocation", "Child Pipeline");
						break;
				}

				valueList.Add("Enabled", this.Enabled);
				valueList.Add("Rank", this.Rank);

				if (string.IsNullOrEmpty(this.FilteringAttributes))
				{
					valueList.Add("FilteringAttributes", "All Attributes");
				}
				else
				{
					valueList.Add("FilteringAttributes", this.FilteringAttributes);
				}

				valueList.Add("Description", ConvertNullStringToEmpty(this.Description));
				valueList.Add("UnsecureConfiguration", ConvertNullStringToEmpty(this.UnsecureConfiguration));
				valueList.Add("ServiceBusConfigurationId", this.ServiceBusConfigurationId);

				if (this.Organization != null && this.Organization.SecureConfigurationPermissionDenied)
				{
					valueList.Add("SecureConfiguration", "Unable to Retrieve Value");
				}
				else
				{
					valueList.Add("SecureConfiguration", ConvertNullStringToEmpty(this.SecureConfiguration));
				}

				if (this.DeleteAsyncOperationIfSuccessful)
				{
					valueList.Add("DeleteAsyncOperationIfSuccessful", "If StatusCode = Successful");
				}
				else
				{
					valueList.Add("DeleteAsyncOperationIfSuccessful", "Manually");
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

		public CrmPluginStep Clone(bool includeOrganization)
		{
			CrmPluginStep newStep;
			if (includeOrganization)
			{
				newStep = new CrmPluginStep(this.m_org);
			}
			else
			{
				newStep = new CrmPluginStep(null);
			}

			newStep.m_assemblyId = this.m_assemblyId;
			newStep.UnsecureConfiguration = this.UnsecureConfiguration;
			newStep.m_createdOn = this.m_createdOn;
			newStep.m_customizationLevel = this.m_customizationLevel;
			newStep.Deployment = this.Deployment;
			newStep.Name = this.Name;
			newStep.Enabled = this.Enabled;
			newStep.MessageEntityId = this.MessageEntityId;
			newStep.m_filteringAttributes = this.m_filteringAttributes;
			newStep.ImpersonatingUserId = this.ImpersonatingUserId;
			newStep.InvocationSource = this.InvocationSource;
			newStep.MessageId = this.MessageId;
			newStep.Mode = this.Mode;
			newStep.m_modifiedOn = this.m_modifiedOn;
			newStep.m_pluginId = this.m_pluginId;
			newStep.Rank = this.Rank;
			newStep.SecureConfiguration = this.SecureConfiguration;
			newStep.SecureConfigurationId = this.SecureConfigurationId;
			newStep.Stage = this.Stage;
			newStep.StepId = this.StepId;
			newStep.m_serviceBusConfigurationId = this.m_serviceBusConfigurationId;
			//Create a new image list
			Dictionary<Guid, CrmPluginImage> newImageList = new Dictionary<Guid, CrmPluginImage>();
			foreach (CrmPluginImage image in this.m_imageList.Values)
			{
				//Clone the image
				CrmPluginImage clonedImage = (CrmPluginImage)image.Clone(includeOrganization);

				//Add the image to the new list
				newImageList.Add(clonedImage.ImageId, clonedImage);
			}

			//Assign the list to the new object
			newStep.m_imageList = newImageList;

			return newStep;
		}
		#endregion
	}

	public enum CrmPluginStepMode
	{
		Asynchronous = 1,
		Synchronous = 0
	}

	public enum CrmPluginStepStage
	{
		PreValidation = 10,
		PreOperation = 20,
		PostOperation = 40,
		PostOperationDeprecated = 50
	}

	public enum CrmPluginStepDeployment
	{
		ServerOnly = 0,
		OfflineOnly = 1,
		Both = 2
	}

	public enum CrmPluginStepInvocationSource
	{
		Parent = 0,
		Child = 1
	}
}