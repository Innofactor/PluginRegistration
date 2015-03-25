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
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

using Microsoft.Xrm.Sdk.Discovery;

using Microsoft.Xrm.Sdk.Client;
using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;

namespace PluginRegistrationTool
{
	public sealed class CrmOrganization : ICrmTreeNode
	{
		private CrmConnection m_connection = null;
		private string m_organizationServiceUrl = null;
		private string m_friendlyName = null;
		private Guid m_organizationId = Guid.Empty;
		private string m_uniqueName = null;
		private Version m_serverBuild = null;
		private CrmUser m_currentUser = null;
		private volatile IOrganizationService m_organizationService = null;

		private bool m_connected = false;
		private Dictionary<Guid, CrmUser> m_userList = new Dictionary<Guid, CrmUser>();

		private Exception m_attributeException = null;
		private Dictionary<string, CrmAttribute[]> m_attributeList = new Dictionary<string, CrmAttribute[]>();

		private CrmEntityDictionary<ICrmEntity> m_invalidEntityReadOnlyList = null;
		private Dictionary<Guid, ICrmEntity> m_invalidEntityList = new Dictionary<Guid, ICrmEntity>();

		#region Entity Lists
		private CrmEntityDictionary<CrmMessage> m_messageReadOnlyList = null;
		private Dictionary<Guid, CrmMessage> m_messageList = new Dictionary<Guid, CrmMessage>();

		private CrmEntityDictionary<CrmMessageEntity> m_messageEntityReadOnlyList = null;
		private Dictionary<Guid, CrmMessageEntity> m_messageEntityList = new Dictionary<Guid, CrmMessageEntity>();

		private CrmEntityDictionary<CrmPluginAssembly> m_assemblyReadOnlyList = null;
		private Dictionary<Guid, CrmPluginAssembly> m_assemblyList = new Dictionary<Guid, CrmPluginAssembly>();

		private CrmEntityDictionary<CrmPlugin> m_pluginReadOnlyList = null;
		private Dictionary<Guid, CrmPlugin> m_pluginList = new Dictionary<Guid, CrmPlugin>();

		private CrmEntityDictionary<CrmPluginStep> m_stepReadOnlyList = null;
		private Dictionary<Guid, CrmPluginStep> m_stepList = new Dictionary<Guid, CrmPluginStep>();

		private CrmEntityDictionary<CrmPluginImage> m_imageReadOnlyList = null;
		private Dictionary<Guid, CrmPluginImage> m_imageList = new Dictionary<Guid, CrmPluginImage>();

		private CrmEntityDictionary<CrmServiceEndpoint> m_serviceEndpointReadOnlyList = null;
		private Dictionary<Guid, CrmServiceEndpoint> m_serviceEndpointList = new Dictionary<Guid, CrmServiceEndpoint>();

		#endregion

		public CrmOrganization()
			: this(null, null, Guid.Empty, null, null, null)
		{
		}

		public CrmOrganization(CrmEntityDictionary<CrmMessage> messages, CrmEntityDictionary<CrmMessageEntity> messageEntity, Dictionary<Guid, CrmUser> users)
			: this(null, null, Guid.Empty, null, null, null)
		{
			m_messageReadOnlyList = messages;
			m_messageEntityReadOnlyList = messageEntity;
			m_userList = users;
		}

        public CrmOrganization(ConnectionDetail detail)
        {
            this.ConnectionDetail = detail;

            var service = detail.GetDiscoveryService();

            var request = new RetrieveOrganizationRequest
            {
                UniqueName = detail.Organization
            };

            var response = (RetrieveOrganizationResponse)service.Execute(request);

            this.Init(response.Detail);

            OrganizationHelper.OpenConnection(this, MainForm.LoadMessages(this), null);
        }

		public CrmOrganization(OrganizationDetail detail)
		{
            this.Init(detail);
		}

        private void Init(OrganizationDetail detail)
        {
            if (detail == null)
            {
                throw new ArgumentNullException("detail");
            }

            this.OrganizationServiceUrl = detail.Endpoints[EndpointType.OrganizationService];
            this.WebApplicationUrl = detail.Endpoints[EndpointType.WebApplication];

            this.OrganizationId = detail.OrganizationId;
            this.OrganizationFriendlyName = detail.FriendlyName;
            this.OrganizationUniqueName = detail.UniqueName;
            this.ServerBuild = new Version(detail.OrganizationVersion);
        }

		public CrmOrganization(string metadataServiceUrl, string organizationServiceUrl,
			Guid organizationId, string organizationFriendlyName, string organizationUniqueName, string webApplicationUrl)
		{
			this.OrganizationServiceUrl = organizationServiceUrl;

			this.OrganizationId = organizationId;
			this.OrganizationFriendlyName = organizationFriendlyName;
			this.OrganizationUniqueName = organizationUniqueName;
			this.WebApplicationUrl = webApplicationUrl;
		}

		#region Properties
        //[XmlIgnore]
        //public CrmConnection Connection
        //{
        //    get
        //    {
        //        return this.m_connection;
        //    }
        //    set
        //    {
        //        this.m_connection = value;
        //    }
        //}

		[XmlElement(ElementName = "CrmServiceUrl", Type = typeof(string), IsNullable = false)]
		public string OrganizationServiceUrl
		{
			get
			{
				return this.m_organizationServiceUrl;
			}
			set
			{
				this.m_organizationServiceUrl = value;
				this.m_organizationService = null;
				this.m_connected = false;
			}
		}

		[XmlIgnore]
		public string WebApplicationUrl { get; set; }

		[XmlElement(ElementName = "OrganizationId", IsNullable = false)]
		public Guid OrganizationId
		{
			get
			{
				return this.m_organizationId;
			}
			set
			{
				this.m_organizationId = value;
			}
		}

		[XmlElement(ElementName = "OrganizationFriendlyName", Type = typeof(string), IsNullable = false)]
		public string OrganizationFriendlyName
		{
			get
			{
				return this.m_friendlyName;
			}
			set
			{
				this.m_friendlyName = value;
			}
		}

		[XmlElement(ElementName = "OrganizationUniqueName", Type = typeof(string), IsNullable = false)]
		public string OrganizationUniqueName
		{
			get
			{
				return this.m_uniqueName;
			}
			set
			{
				this.m_uniqueName = value;
			}
		}

		[XmlIgnore]
		internal IOrganizationService OrganizationService
		{
			get
			{
				lock (this)
				{
					if (null == this.m_organizationService)
					{
						this.InitializeOrganizationService();
					}

					return this.m_organizationService;
				}
			}
		}

		[XmlIgnore]
		public bool Connected
		{
			get
			{
				return this.m_connected;
			}
			set
			{
				if (!value)
				{
					//Reset when closing the connection
					this.SecureConfigurationPermissionDenied = false;
					this.m_currentUser = null;
					this.m_invalidEntityList.Clear();
					this.ProfilerPlugin = null;
				}

				this.m_connected = value;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<CrmServiceEndpoint> ServiceEndpoints
		{
			get
			{
				if (this.m_serviceEndpointReadOnlyList == null)
				{
					this.m_serviceEndpointReadOnlyList = new CrmEntityDictionary<CrmServiceEndpoint>(this.m_serviceEndpointList);
				}

				return this.m_serviceEndpointReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<CrmPluginAssembly> Assemblies
		{
			get
			{
				if (this.m_assemblyReadOnlyList == null)
				{
					this.m_assemblyReadOnlyList = new CrmEntityDictionary<CrmPluginAssembly>(this.m_assemblyList);
				}

				return this.m_assemblyReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<CrmPlugin> Plugins
		{
			get
			{
				if (this.m_pluginReadOnlyList == null)
				{
					this.m_pluginReadOnlyList = new CrmEntityDictionary<CrmPlugin>(this.m_pluginList);
				}

				return this.m_pluginReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<CrmPluginStep> Steps
		{
			get
			{
				if (this.m_stepReadOnlyList == null)
				{
					this.m_stepReadOnlyList = new CrmEntityDictionary<CrmPluginStep>(this.m_stepList);
				}

				return this.m_stepReadOnlyList;
			}
		}

		[XmlIgnore]
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
		public CrmEntityDictionary<CrmMessage> Messages
		{
			get
			{
				if (this.m_messageReadOnlyList == null)
				{
					this.m_messageReadOnlyList = new CrmEntityDictionary<CrmMessage>(this.m_messageList);
				}

				return this.m_messageReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<CrmMessageEntity> MessageEntities
		{
			get
			{
				if (this.m_messageEntityReadOnlyList == null)
				{
					this.m_messageEntityReadOnlyList = new CrmEntityDictionary<CrmMessageEntity>(this.m_messageEntityList);
				}

				return this.m_messageEntityReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmEntityDictionary<ICrmEntity> InvalidEntities
		{
			get
			{
				if (this.m_invalidEntityReadOnlyList == null)
				{
					this.m_invalidEntityReadOnlyList = new CrmEntityDictionary<ICrmEntity>(this.m_invalidEntityList);
				}

				return this.m_invalidEntityReadOnlyList;
			}
		}

		[XmlIgnore]
		public CrmPluginAssembly this[Guid assemblyId]
		{
			get
			{
				if (this.Assemblies != null)
				{
					return this.Assemblies[assemblyId];
				}
				else
				{
					return null;
				}
			}
		}

		[XmlIgnore]
		public bool SecureConfigurationPermissionDenied { get; set; }

		[XmlIgnore]
		public Dictionary<Guid, CrmUser> Users
		{
			get
			{
				return this.m_userList;
			}
		}

		[XmlIgnore]
		public Exception AttributeLoadException
		{
			get
			{
				return this.m_attributeException;
			}
		}

		[XmlIgnore]
		public CrmUser LoggedOnUser
		{
			get
			{
				return this.m_currentUser;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}
				else
				{
					this.m_currentUser = value;
				}
			}
		}

		[XmlIgnore]
		public Version ServerBuild
		{
			get
			{
				return this.m_serverBuild;
			}

			set
			{
				if (null == value)
				{
					throw new ArgumentNullException("value");
				}
				else
				{
					this.m_serverBuild = value;
				}
			}
		}

		[XmlIgnore]
		public CrmPlugin ProfilerPlugin { get; set; }
		#endregion

		#region Public Helper Methods
		/// <summary>
		/// Method that initializes needed variables. This can be done in a thread
		/// </summary>
		public void Initialize()
		{
			lock (this)
			{
				if (this.m_organizationService == null)
				{
					InitializeOrganizationService();
				}
			}
		}

		/// <summary>
		/// Determines if the attributes for a specific entity have been loaded
		/// </summary>
		public bool IsEntityAttributesLoaded(string entityName)
		{
			return this.m_attributeList.ContainsKey(entityName);
		}

		/// <summary>
		/// Retrieves the entity attributes for the specified entity
		/// </summary>
		public CrmAttribute[] RetrieveEntityAttributes(string entityName)
		{
			if (this.m_attributeList.ContainsKey(entityName))
			{
				return this.m_attributeList[entityName];
			}
			else
			{
				throw new ArgumentException("Entity is not loaded", "entityName");
			}
		}

		/// <summary>
		/// Clears all saved entity attributes
		/// </summary>
		public void ClearAllEntityAttributes()
		{
			this.m_attributeList.Clear();
			this.m_attributeException = null;
		}

		public void SaveEntityAttributes(string entityName, Exception loadException)
		{
			if (loadException == null)
			{
				throw new ArgumentNullException("loadException");
			}
			else if (entityName == null)
			{
				throw new ArgumentNullException("entityName");
			}
			else if (this.m_attributeList.ContainsKey(entityName))
			{
				this.m_attributeList.Remove(entityName);
			}

			this.m_attributeException = loadException;
		}

		/// <summary>
		/// Save a specific list of attributes for a specific entity
		/// </summary>
		public void SaveEntityAttributes(string entityName, CrmAttribute[] attributes)
		{
			if (entityName == null)
			{
				throw new ArgumentNullException("entityName");
			}
			else if (attributes == null)
			{
				throw new ArgumentNullException("attributes");
			}

			if (this.m_attributeList.ContainsKey(entityName))
			{
				this.m_attributeList[entityName] = attributes;
			}
			else
			{
				this.m_attributeList.Add(entityName, attributes);
			}

			this.m_attributeException = null;
		}

		/// <summary>
		/// Locate the message based on the name of the message
		/// </summary>
		/// <param name="messageName">Message to be found</param>
		/// <returns>CrmMessage if found, null if not</returns>
		public CrmMessage FindMessage(string messageName)
		{
			if (messageName == null)
			{
				throw new ArgumentNullException("message");
			}

			foreach (CrmMessage msg in m_messageList.Values)
			{
				if (messageName.Equals(msg.Name, StringComparison.InvariantCultureIgnoreCase))
				{
					return msg;
				}
			}

			return null;
		}

		public override string ToString()
		{
			return this.NodeText;
		}

		#region Management Methods
		#region Service End point
		public void AddServiceEndpoint(CrmServiceEndpoint serviceEndpoint)
		{
			if (serviceEndpoint == null)
			{
				throw new ArgumentNullException("serviceEndpoint");
			}
			if (m_serviceEndpointList.ContainsKey(serviceEndpoint.ServiceEndpointId))
			{
				throw new ArgumentException("ServiceEndpoint is already in the list");
			}

			this.m_serviceEndpointList.Add(serviceEndpoint.ServiceEndpointId, serviceEndpoint);
		}
		public void ClearServiceEndpoints()
		{
			this.m_serviceEndpointList.Clear();
		}
		public void RemoveServiceEndpoint(Guid serviceEndpointId)
		{
			if (this.m_serviceEndpointList.ContainsKey(serviceEndpointId))
			{
				this.m_serviceEndpointList.Remove(serviceEndpointId);
			}
			else
			{
				throw new ArgumentException("Invalid ServiceEndpoint Id", "serviceEndpointId");
			}
		}
		#endregion
		#region Assembly
		public void AddAssembly(CrmPluginAssembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			else if (this.m_assemblyList.ContainsKey(assembly.AssemblyId))
			{
				throw new ArgumentException("Assembly is already in the list");
			}
			else
			{
				this.ValidateEntity(assembly);
			}

			this.m_assemblyList.Add(assembly.AssemblyId, assembly);
		}

		public void ClearAssemblies()
		{
			this.m_imageList.Clear();
			this.m_stepList.Clear();
			this.m_pluginList.Clear();
			this.m_assemblyList.Clear();
		}

		public void RemoveAssembly(Guid assemblyId)
		{
			if (this.m_assemblyList.ContainsKey(assemblyId))
			{
				CrmPluginAssembly assembly = this.m_assemblyList[assemblyId];

				//Copy the list of plugins. Can't use the enumerator because we are changing the underlying data
				Guid[] pluginIdList = new Guid[assembly.Plugins.Count];
				assembly.Plugins.Keys.CopyTo(pluginIdList, 0);

				//Loop through the plugin id's
				foreach (Guid pluginId in pluginIdList)
				{
					this.RemovePlugin(assembly, pluginId);
				}

				this.m_assemblyList.Remove(assemblyId);
			}
			else
			{
				throw new ArgumentException("Invalid Assembly Id", "assemblyId");
			}
		}
		#endregion

		#region Plugin
		public void AddPlugin(CrmPluginAssembly assembly, CrmPlugin plugin)
		{
			if (plugin == null)
			{
				throw new ArgumentNullException("plugin");
			}
			else if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			else if (!assembly.Plugins.ContainsKey(plugin.PluginId))
			{
				assembly.AddPlugin(plugin);
				return;
			}
			else
			{
				this.ValidateEntity(plugin);
			}

			this.m_pluginList.Add(plugin.PluginId, plugin);
		}

		public void ClearPlugins()
		{
			this.ClearPlugins(Guid.Empty);
		}

		public void ClearPlugins(Guid assemblyId)
		{
			CrmPlugin[] pluginList;
			if (assemblyId == Guid.Empty)
			{
				this.m_imageList.Clear();
				this.m_stepList.Clear();

				//Copy the list of plugins. Can't use the enumerator because we are changing the underlying data
				pluginList = new CrmPlugin[this.m_pluginList.Count];
				this.m_pluginList.Values.CopyTo(pluginList, 0);
			}
			else if (this.m_assemblyList.ContainsKey(assemblyId))
			{
				//Copy the list of plugins. Can't use the enumerator because we are changing the underlying data
				pluginList = this.m_assemblyList[assemblyId].Plugins.ToArray();
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "assemblyId");
			}

			//Loop through the plugin id's
			foreach (CrmPlugin plugin in pluginList)
			{
				this.RemovePlugin(plugin.AssemblyId, plugin.PluginId);
			}
		}

		public void RemovePlugin(Guid assemblyId, Guid pluginId)
		{
			if (this.m_assemblyList.ContainsKey(assemblyId))
			{
				this.RemovePlugin(this.m_assemblyList[assemblyId], pluginId);
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "assemblyId");
			}
		}

		public void RemovePlugin(CrmPluginAssembly assembly, Guid pluginId)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			else if (assembly.Plugins.ContainsKey(pluginId))
			{
				assembly.RemovePlugin(pluginId);
			}
			else if (this.m_pluginList.ContainsKey(pluginId))
			{
				CrmPlugin plugin = this.m_pluginList[pluginId];

				//Copy the list of steps. Can't use the enumerator because we are changing the underlying data
				Guid[] stepIdList = new Guid[plugin.Steps.Count];
				plugin.Steps.Keys.CopyTo(stepIdList, 0);

				//Loop through the step id's
				foreach (Guid stepId in stepIdList)
				{
					this.RemoveStep(plugin, stepId);
				}

				this.m_pluginList.Remove(pluginId);
			}
			else
			{
				throw new ArgumentException("Plugin is not in list", "pluginId");
			}
		}
		#endregion

		#region Step
		public void AddStep(CrmPlugin plugin, CrmPluginStep step)
		{
			if (step == null)
			{
				throw new ArgumentNullException("step");
			}
			else if (plugin == null)
			{
				throw new ArgumentNullException("plugin");
			}
			else if (!plugin.Steps.ContainsKey(step.StepId))
			{
				plugin.AddStep(step);
				return;
			}
			else
			{
				this.ValidateEntity(step);
			}

			this.m_stepList.Add(step.StepId, step);
		}

		public void ClearSteps()
		{
			this.ClearSteps(Guid.Empty);
		}

		public void ClearSteps(Guid pluginId)
		{
			CrmPluginStep[] stepList;
			if (pluginId == Guid.Empty)
			{
				this.m_imageList.Clear();

				//Copy the list of steps. Can't use the enumerator because we are changing the underlying data
				stepList = new CrmPluginStep[this.m_stepList.Count];
				this.m_stepList.Values.CopyTo(stepList, 0);
			}
			else if (this.m_pluginList.ContainsKey(pluginId))
			{
				//Copy the list of steps. Can't use the enumerator because we are changing the underlying data
				stepList = this.m_pluginList[pluginId].Steps.ToArray();
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "pluginId");
			}

			//Loop through the step id's
			foreach (CrmPluginStep step in stepList)
			{
				this.RemoveStep(step.PluginId, step.StepId);
			}
		}

		public void RemoveStep(Guid pluginId, Guid stepId)
		{
			if (this.m_pluginList.ContainsKey(pluginId))
			{
				this.RemoveStep(this.m_pluginList[pluginId], stepId);
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "pluginId");
			}
		}

		public void RemoveStep(CrmPlugin plugin, Guid stepId)
		{
			if (plugin == null)
			{
				throw new ArgumentNullException("plugin");
			}
			else if (plugin.Steps.ContainsKey(stepId))
			{
				plugin.RemoveStep(stepId);
			}
			else if (this.m_stepList.ContainsKey(stepId))
			{
				CrmPluginStep step = this.m_stepList[stepId];

				//Copy the list of images. Can't use the enumerator because we are changing the underlying data
				Guid[] imageIdList = new Guid[step.Images.Count];
				step.Images.Keys.CopyTo(imageIdList, 0);

				//Loop through the image id's
				foreach (Guid imageId in imageIdList)
				{
					this.RemoveImage(step, imageId);
				}

				this.m_stepList.Remove(stepId);
			}
			else
			{
				throw new ArgumentException("Step is not in list", "stepId");
			}
		}
		#endregion

		#region Image
		public void AddImage(CrmPluginStep step, CrmPluginImage image)
		{
			if (image == null)
			{
				throw new ArgumentNullException("image");
			}
			else if (step == null)
			{
				throw new ArgumentNullException("step");
			}
			else if (!step.Images.ContainsKey(image.ImageId))
			{
				step.AddImage(image);
				return;
			}
			else
			{
				this.ValidateEntity(image);
			}

			this.m_imageList.Add(image.ImageId, image);
		}

		public void ClearImages()
		{
			this.ClearImages(Guid.Empty);
		}

		public void ClearImages(Guid stepId)
		{
			CrmPluginImage[] imageList;
			if (stepId == Guid.Empty)
			{
				//Copy the list of images. Can't use the enumerator because we are changing the underlying data
				imageList = new CrmPluginImage[this.m_imageList.Count];
				this.m_imageList.Values.CopyTo(imageList, 0);
			}
			else if (this.m_stepList.ContainsKey(stepId))
			{
				//Copy the list of images. Can't use the enumerator because we are changing the underlying data
				imageList = this.m_stepList[stepId].Images.ToArray();
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "stepId");
			}

			//Loop through the image id's
			foreach (CrmPluginImage image in imageList)
			{
				this.RemoveImage(image.StepId, image.ImageId);
			}
		}

		public void RemoveImage(Guid stepId, Guid imageId)
		{
			if (this.m_stepList.ContainsKey(stepId))
			{
				this.RemoveImage(this.m_stepList[stepId], imageId);
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "stepId");
			}
		}

		public void RemoveImage(CrmPluginStep step, Guid imageId)
		{
			if (step == null)
			{
				throw new ArgumentNullException("plugin");
			}
			else if (step.Images.ContainsKey(imageId))
			{
				step.RemoveImage(imageId);
			}
			else if (this.m_imageList.ContainsKey(imageId))
			{
				this.m_imageList.Remove(imageId);
			}
			else
			{
				throw new ArgumentException("Image is not in list", "step");
			}
		}
		#endregion

		#region Message
		public void AddMessage(CrmMessage message)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			else if (this.m_messageList.ContainsKey(message.MessageId))
			{
				throw new ArgumentException("Message is already in the list");
			}
			else
			{
				this.ValidateEntity(message);
			}

			this.m_messageList.Add(message.MessageId, message);
		}

		public void ClearMessages()
		{
			this.m_messageEntityList.Clear();
			this.m_messageList.Clear();
		}

		public void RemoveMessage(Guid messageId)
		{
			if (this.m_messageList.ContainsKey(messageId))
			{
				CrmMessage message = this.m_messageList[messageId];

				//Copy the list of MessageEntities. Can't use the enumerator because we are changing the underlying data
				Guid[] entityIdList = new Guid[message.MessageEntities.Count];
				message.MessageEntities.Keys.CopyTo(entityIdList, 0);

				//Loop through the MessageEntity id's
				foreach (Guid messageEntityId in entityIdList)
				{
					this.RemoveMessageEntity(message, messageEntityId);
				}

				this.m_messageList.Remove(messageId);
			}
			else
			{
				throw new ArgumentException("Invalid Message Id", "messageId");
			}
		}
		#endregion

		#region MessageEntity
		public void AddMessageEntity(CrmMessage message, CrmMessageEntity entity)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			else if (entity == null)
			{
				throw new ArgumentNullException("entity");
			}
			else if (!message.MessageEntities.ContainsKey(entity.MessageEntityId))
			{
				message.AddMessageEntity(entity);
				return;
			}
			else
			{
				this.ValidateEntity(entity);
			}

			this.m_messageEntityList.Add(entity.EntityId, entity);
		}

		public void ClearMessageEntities()
		{
			this.ClearMessageEntities(Guid.Empty);
		}

		public void ClearMessageEntities(Guid messageId)
		{
			CrmMessageEntity[] entityList;
			if (messageId == Guid.Empty)
			{
				//Copy the list of entities. Can't use the enumerator because we are changing the underlying data
				entityList = new CrmMessageEntity[this.m_messageEntityList.Count];
				this.m_messageEntityList.Values.CopyTo(entityList, 0);
			}
			else if (this.m_messageList.ContainsKey(messageId))
			{
				//Copy the list of entities. Can't use the enumerator because we are changing the underlying data
				entityList = this.m_messageList[messageId].MessageEntities.ToArray();
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "messageId");
			}

			//Loop through the entity id's
			foreach (CrmMessageEntity message in entityList)
			{
				this.RemoveMessageEntity(message.MessageId, message.MessageEntityId);
			}
		}

		public void RemoveMessageEntity(Guid messageId, Guid messageEntityId)
		{
			if (this.m_messageList.ContainsKey(messageId))
			{
				this.RemoveMessageEntity(this.m_messageList[messageId], messageEntityId);
			}
			else
			{
				throw new ArgumentException("Invalid Entity Id", "messageId");
			}
		}

		public void RemoveMessageEntity(CrmMessage message, Guid messageEntityId)
		{
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			else if (message.MessageEntities.ContainsKey(messageEntityId))
			{
				message.RemoveMessageEntity(messageEntityId);
			}
			else if (this.m_messageEntityList.ContainsKey(messageEntityId))
			{
				this.m_messageEntityList.Remove(messageEntityId);
			}
			else
			{
				throw new ArgumentException("MessageEntity is not in list", "messageEntityId");
			}
		}
		#endregion
		#endregion
		#endregion

		#region Private Helper Methods
		/// <summary>
		/// Initialize the CrmService
		/// </summary>
		private void InitializeOrganizationService()
		{
			lock (this)
			{
                this.m_organizationService = this.ConnectionDetail.GetOrganizationService();
                //this.m_organizationService = new ManagedTokenOrganizationServiceProxy(new Uri(this.OrganizationServiceUrl),
                //    this.Connection.Credentials);
                //this.m_organizationService.EnableProxyTypes();
			}
		}

		private void ValidateEntity(CrmPluginAssembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_assemblyList.ContainsKey(assembly.AssemblyId))
			{
				throw new ArgumentException("Assembly is already in the list");
			}
			else if (assembly.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (assembly.AssemblyId == Guid.Empty)
			{
				throw new ArgumentException("AssemblyId must be set to valid Guid");
			}
		}

		private void ValidateEntity(CrmPlugin plugin)
		{
			if (plugin == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_pluginList.ContainsKey(plugin.PluginId))
			{
				throw new ArgumentException("Plugin is already in the list");
			}
			else if (plugin.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (plugin.AssemblyId == Guid.Empty)
			{
				throw new ArgumentException("AssemblyId must be set to valid Guid");
			}
			else if (plugin.PluginId == Guid.Empty)
			{
				throw new ArgumentException("PluginId must be set to valid Guid");
			}
		}

		private void ValidateEntity(CrmPluginStep step)
		{
			if (step == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_stepList.ContainsKey(step.StepId))
			{
				throw new ArgumentException("Step is already in the list");
			}
			else if (step.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (step.AssemblyId == Guid.Empty)
			{
				throw new ArgumentException("AssemblyId must be set to valid Guid");
			}
			else if (step.PluginId == Guid.Empty)
			{
				throw new ArgumentException("PluginId must be set to valid Guid");
			}
			else if (step.StepId == Guid.Empty)
			{
				throw new ArgumentException("StepId must be set to valid Guid");
			}
		}

		private void ValidateEntity(CrmPluginImage image)
		{
			if (image == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_imageList.ContainsKey(image.ImageId))
			{
				throw new ArgumentException("Image is already in the list");
			}
			else if (image.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (image.AssemblyId == Guid.Empty)
			{
				throw new ArgumentException("AssemblyId must be set to valid Guid");
			}
			else if (image.PluginId == Guid.Empty)
			{
				throw new ArgumentException("PluginId must be set to valid Guid");
			}
			else if (image.StepId == Guid.Empty)
			{
				throw new ArgumentException("StepId must be set to valid Guid");
			}
			else if (image.ImageId == Guid.Empty)
			{
				throw new ArgumentException("ImageId must be set to valid Guid");
			}
		}

		private void ValidateEntity(CrmMessage message)
		{
			if (message == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_messageList.ContainsKey(message.MessageId))
			{
				throw new ArgumentException("Message is already in the list");
			}
			else if (message.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (message.MessageId == Guid.Empty)
			{
				throw new ArgumentException("MessageId must be set to valid Guid");
			}
		}

		private void ValidateEntity(CrmMessageEntity messageEntity)
		{
			if (messageEntity == null)
			{
				throw new ArgumentNullException();
			}
			else if (this.m_messageEntityList.ContainsKey(messageEntity.MessageEntityId))
			{
				throw new ArgumentException("MessageEntity is already in the list");
			}
			else if (messageEntity.Organization != this)
			{
				throw new ArgumentException("Organization must match");
			}
			else if (messageEntity.MessageId == Guid.Empty)
			{
				throw new ArgumentException("MessageId must be set to valid Guid");
			}
			else if (messageEntity.MessageEntityId == Guid.Empty)
			{
				throw new ArgumentException("MessageEntityId must be set to valid Guid");
			}
		}
		#endregion */

		#region ICrmTreeNode Members
		[XmlIgnore]
		public string NodeText
		{
			get
			{
				return this.m_friendlyName;
			}
		}

		[XmlIgnore]
		public Guid NodeId
		{
			get
			{
				return this.m_organizationId;
			}
		}

		[XmlIgnore]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				return new ICrmTreeNode[0];
			}
		}

		[XmlIgnore]
		public CrmTreeNodeImageType NodeImageType
		{
			get
			{
				return CrmTreeNodeImageType.Organization;
			}
		}

		[XmlIgnore]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				return CrmTreeNodeImageType.OrganizationSelected;
			}
		}

		[XmlIgnore]
		public CrmTreeNodeType NodeType
		{
			get
			{
				return CrmTreeNodeType.Organization;
			}
		}

		[XmlIgnore]
		public string NodeTypeLabel
		{
			get
			{
				return "Organization";
			}
		}
		#endregion

        public ConnectionDetail ConnectionDetail { get; set; }
    }

	#region Public Classes & Enums


	#region Public Interfaces
	public interface IWcfAuthenticationHeader
	{
		Guid CallerId { get; set; }
		string CrmTicket { get; set; }
		string OrganizationName { get; }
	}
	#endregion

	public interface ICrmEntity
	{
		bool IsSystemCrmEntity { get; }
		string EntityType { get; }
		Guid EntityId { get; }
		Dictionary<string, object> GenerateCrmEntities();
		Dictionary<string, object> Values { get; }

		void UpdateDates(DateTime? createdOn, DateTime? modifiedOn);
	}

	public class CrmEntityColumn
	{
		private string m_name;
		private string m_label;
		private Type m_type;

		public CrmEntityColumn(string name, string label, Type type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}

			this.m_name = name;
			this.m_label = label;
			this.m_type = type;
		}

		public string Name
		{
			get
			{
				return this.m_name;
			}
		}

		public string Label
		{
			get
			{
				return this.m_label;
			}
		}

		public Type Type
		{
			get
			{
				return this.m_type;
			}
		}

		public override string ToString()
		{
			return this.Name;
		}
	}
	#endregion
}