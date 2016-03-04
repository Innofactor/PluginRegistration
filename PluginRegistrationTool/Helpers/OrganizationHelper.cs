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

namespace PluginRegistrationTool.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Reflection;
    using System.ServiceModel;
    using Microsoft.Crm.Sdk.Messages;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Client;
    using Microsoft.Xrm.Sdk.Messages;
    using Microsoft.Xrm.Sdk.Metadata;
    using Microsoft.Xrm.Sdk.Query;
    using PluginRegistrationTool.Entities;
    using PluginRegistrationTool.Wrappers;
    
    public static class OrganizationHelper
    {
        internal const string V3CalloutProxyTypeName = "Microsoft.Crm.Extensibility.V3CalloutProxyPlugin";

        private static Dictionary<string, ColumnSet> m_entityColumns = new Dictionary<string, ColumnSet>();
        private volatile static List<CrmMessage> m_messageList = new List<CrmMessage>();

        public static void RefreshConnection(CrmOrganization org, CrmEntityDictionary<CrmMessage> messages)
        {
            RefreshConnection(org, messages, null);
        }

        public static void RefreshConnection(CrmOrganization org,
            CrmEntityDictionary<CrmMessage> messages, ProgressIndicator prog)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            org.Connected = false;

            OpenConnection(org, messages, prog);
        }

        ///// <summary>
        ///// Retrieve the Message entities for the organization. This will be the same for each deployment and organization.
        ///// </summary>
        ///// <param name="org">Organization to be used</param>
        //public static List<CrmMessage> LoadMessages(CrmOrganization org)
        //{
        //    return LoadMessages(org, null);
        //}

        public static CrmEntityDictionary<CrmMessage> LoadMessages(CrmOrganization org)
        {
            lock (m_messageList)
            {
                if (m_messageList.Count == 0)
                {
                    m_messageList = OrganizationHelper.LoadMessages(org, null);
                }

                Dictionary<Guid, CrmMessage> messageList = new Dictionary<Guid, CrmMessage>();
                foreach (CrmMessage msg in m_messageList)
                {
                    CrmMessage newMessage = new CrmMessage(null, msg.MessageId, msg.Name,
                        msg.SupportsFilteredAttributes, msg.CustomizationLevel, msg.CreatedOn, msg.ModifiedOn,
                        msg.ImageMessagePropertyNames);

                    messageList.Add(newMessage.MessageId, newMessage);
                }

                return new CrmEntityDictionary<CrmMessage>(messageList);
            }
        }

        /// <summary>
        /// Retrieve the Message entities for the organization. This will be the same for each deployment and organization.
        /// </summary>
        /// <param name="org">Organization to be used</param>
        /// <param name="prog">ProgressIndicator that will show the progress as the object is loaded</param>
        public static List<CrmMessage> LoadMessages(CrmOrganization org, ProgressIndicator prog)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            //Setup the Progress Indicator
            if (null != prog)
            {
                prog.Initialize(2, "Loading Messages");
            }

            //Generate the query
            QueryExpression query = new QueryExpression();
            query.ColumnSet = GetColumnSet(Entities.SdkMessage.EntityLogicalName);
            query.Criteria.AddCondition("isprivate", ConditionOperator.Equal, false);
            query.AddOrder("name", OrderType.Ascending);
            query.EntityName = SdkMessage.EntityLogicalName;

            //Increment the Progress
            if (null != prog)
            {
                prog.Increment();
            }

            //Retrieve the message entities
            EntityCollection results = org.OrganizationService.RetrieveMultipleAllPages(query);

            //Update the progress indicator with a new maximum
            if (null != prog)
            {
                prog.Initialize(0, results.Entities.Count + 1, 1, "Loading Messages");
            }

            //Process each message entity
            List<CrmMessage> msgList = new List<CrmMessage>();
            for (int i = 0; i < results.Entities.Count; i++)
            {
                msgList.Add(UpdateMessageProperties(new CrmMessage(null, (SdkMessage)results[i])));

                //Increment the Progress Indicator
                if (null != prog)
                {
                    prog.Increment();
                }
            }

            if (null != prog)
            {
                prog.Complete();
            }

            return msgList;
        }

        /// <summary>
        /// Initializes any items that need to be initialized when the connection gets opened
        /// </summary>
        /// <param name="org">Organization that should be opened</param>
        /// <param name="messages">List of messages</param>
        public static void OpenConnection(CrmOrganization org, CrmEntityDictionary<CrmMessage> messages)
        {
            OpenConnection(org, messages, null);
        }

        /// <summary>
        /// Initializes any items that need to be initialized when the connection gets opened
        /// </summary>
        /// <param name="org">Organization that should be opened</param>
        /// <param name="messages">List of messages</param>
        /// <param name="prog">ProgressIndicator that will show the progress as the object is loaded</param>
        public static void OpenConnection(CrmOrganization org, CrmEntityDictionary<CrmMessage> messages, ProgressIndicator prog)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (org.Connected)
            {
                return;
            }

            bool loadedCompletely = false;
            try
            {
                //Initialize the progress bar
                if (prog != null)
                {
                    prog.Initialize(8, "Loading Services");
                }

                //Initialize the services
                org.Initialize();

                //Initialize list of users
                if (prog != null)
                {
                    prog.Increment("Loading Users");
                }
                LoadUsers(org);

                //Find the current user
                if (prog != null)
                {
                    prog.Increment("Get Logged In User");
                }
                org.LoggedOnUser = GetLoggedOnUser(org);

                //Initialize list of messages
                if (prog != null)
                {
                    prog.Increment("Loading Messages");
                }
                LoadMessageEntities(org, messages);

                //Initialize list of assemblies
                if (prog != null)
                {
                    prog.Increment("Loading Assemblies");
                }
                LoadAssemblies(org);

                //Initialize list of plugins
                if (prog != null)
                {
                    prog.Increment("Loading Plugins");
                }
                Dictionary<Guid, CrmPlugin> typeList;
                LoadPlugins(org, out typeList);

                //Initialize list of service end points
                if (prog != null)
                {
                    prog.Increment("Loading Service Endpoints");
                }
                LoadServiceEndpoints(org);

                //Initialize list of steps
                if (prog != null)
                {
                    prog.Increment("Loading Steps");
                }
                Dictionary<Guid, CrmPluginStep> stepList;
                LoadSteps(org, typeList, out stepList);

                //Initialize list of images
                if (prog != null)
                {
                    prog.Increment("Loading Images");
                }
                LoadImages(org, stepList);

                org.ClearAllEntityAttributes();

                loadedCompletely = true;
            }

            finally
            {
                org.Connected = loadedCompletely;

                //Mark the progress as complete
                if (prog != null)
                {
                    prog.Increment();
                    prog.Complete();
                }
            }
        }

        /// <summary>
        /// Loads/Reloads assemblies from CRM
        /// </summary>
        /// <param name="assemblyId">Assembly Ids to reload (does not reload plugins). If not specified, reloads all assemblies</param>
        public static void LoadAssemblies(CrmOrganization org)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            var query = new QueryExpression();
            query.ColumnSet = GetColumnSet(PluginAssembly.EntityLogicalName);
            query.Criteria = CreateAssemblyFilter();
            query.EntityName = PluginAssembly.EntityLogicalName;

            //Clear the assemblies list since we are reloading from scratch
            org.ClearAssemblies();

            foreach (PluginAssembly assembly in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
            {
                org.AddAssembly(new CrmPluginAssembly(org, assembly));
            }
        }

        /// <summary>
        /// Loads/Reloads Service Endpoitns from CRM
        /// </summary>
        public static void LoadServiceEndpoints(CrmOrganization org)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            QueryExpression query = new QueryExpression();
            query.ColumnSet = GetColumnSet(Entities.ServiceEndpoint.EntityLogicalName);
            query.Criteria = new FilterExpression();
            query.EntityName = Entities.ServiceEndpoint.EntityLogicalName;

            //Clear the Service Endpoints list since we are reloading from scratch
            org.ClearServiceEndpoints();

            foreach (ServiceEndpoint serviceEndPoint in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
            {
                org.AddServiceEndpoint(new CrmServiceEndpoint(org, serviceEndPoint));
            }
        }
        /// <summary>
        /// Retrieves a list of attributes for a specified attribute in a DataTable
        /// </summary>
        /// <param name="entityName">Name of the entity</param>
        /// <returns>DataTable containing the attributes</returns>
        public static void LoadAttributeList(CrmOrganization org, string entityName)
        {
            LoadAttributeList(org, entityName, null);
        }

        /// <summary>
        /// Retrieves a list of attributes for a specified attribute in a DataTable
        /// </summary>
        /// <param name="entityName">Name of the entity</param>
        /// <param name="prog">ProgressIndicator that will show the progress as the object is loaded</param>
        /// <returns>DataTable containing the attributes</returns>
        public static void LoadAttributeList(CrmOrganization org, string entityName, ProgressIndicator prog)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (entityName == null)
            {
                throw new ArgumentNullException("entityName");
            }

            RetrieveEntityRequest request = new RetrieveEntityRequest();
            request.EntityFilters = EntityFilters.Attributes;
            request.LogicalName = entityName;
            request.RetrieveAsIfPublished = false;

            //Execute the request
            RetrieveEntityResponse response = (RetrieveEntityResponse)org.OrganizationService.Execute(request);

            EntityMetadata entityMd = response.EntityMetadata;

            List<CrmAttribute> attList = new List<CrmAttribute>();

            foreach (AttributeMetadata att in entityMd.Attributes)
            {
                // Do not add the child attributes 
                // Do not add the attributes that are not valid for Read
                if (att.IsValidForRead.Value && null == att.AttributeOf)
                {
                    attList.Add(new CrmAttribute(att, att.LogicalName == entityMd.PrimaryIdAttribute));
                }
            }

            org.SaveEntityAttributes(entityName, attList.ToArray());
        }

        /// <summary>
        /// Creates a DataTable from the given Dictionary of CrmEntity objects
        /// </summary>
        public static DataTable CreateDataTable<Entity>(CrmEntityColumn[] columns, IEnumerable<Entity> enumerable)
            where Entity : ICrmEntity
        {
            if (columns == null)
            {
                throw new ArgumentNullException("columns");
            }
            else if (enumerable == null)
            {
                throw new ArgumentNullException("enumerable");
            }

            //Create the data table
            DataTable table = new DataTable(typeof(Entity).Name);

            //Create the list of columns
            foreach (CrmEntityColumn col in columns)
            {
                DataColumn tableCol = table.Columns.Add(col.Name, col.Type);
                if (col.Label != null)
                {
                    tableCol.Caption = col.Label;
                }
            }

            //Create the list of rows
            foreach (Entity entity in enumerable)
            {
                DataRow row = table.NewRow();

                foreach (KeyValuePair<string, object> value in entity.Values)
                {
                    row[value.Key] = value.Value;
                }

                table.Rows.Add(row);
            }

            return table;
        }

        /// <summary>
        /// Updates the dates of the entities
        /// </summary>
        /// <param name="org">Organization that contains the entities</param>
        /// <param name="entityList">List of entities to be updated</param>
        public static void UpdateDates(CrmOrganization org, List<ICrmEntity> entityList)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (entityList == null)
            {
                throw new ArgumentNullException("entityList");
            }

            Dictionary<Guid, ICrmEntity> updateList = new Dictionary<Guid, ICrmEntity>();
            Dictionary<string, List<Guid>> queryList = new Dictionary<string, List<Guid>>();
            foreach (ICrmEntity entity in entityList)
            {
                if (entity != null)
                {
                    if (queryList.ContainsKey(entity.EntityType))
                    {
                        queryList[entity.EntityType].Add(entity.EntityId);
                    }
                    else
                    {
                        List<Guid> idList = new List<Guid>();
                        idList.Add(entity.EntityId);

                        queryList.Add(entity.EntityType, idList);
                    }

                    updateList.Add(entity.EntityId, entity);
                }
            }

            if (queryList.Count == 0)
            {
                return;
            }

            //Create the base query that will be used       

            string[] colsArray = new string[] { "modifiedon", "createdon" };
            ConditionExpression idCon = new ConditionExpression();
            idCon.AttributeName = string.Empty;
            idCon.Operator = ConditionOperator.In;

            QueryExpression query = new QueryExpression();
            query.Criteria.Conditions.Add(idCon);

            foreach (KeyValuePair<string, List<Guid>> entityIdList in queryList)
            {
                query.EntityName = entityIdList.Key.ToString();

                idCon.AttributeName = query.EntityName + "id";
                idCon.Values.Clear();
                idCon.Values.AddRange(ConvertToObjectArray(entityIdList.Value));
                query.ColumnSet = new ColumnSet(colsArray);

                foreach (Entity entity in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
                {
                    DateTime? created = null;
                    DateTime? modified = null;
                    Guid id = Guid.Empty;

                    foreach (KeyValuePair<string, object> prop in entity.Attributes)
                    {
                        DateTime? dateValue = prop.Value as DateTime?;
                        if (null != dateValue)
                        {
                            switch (prop.Key)
                            {
                                case "createdon":
                                    created = dateValue.Value;
                                    break;
                                case "modifiedon":
                                    modified = dateValue.Value;
                                    break;
                            }
                        }
                        else
                        {
                            Guid? idValue = prop.Value as Guid?;
                            if (null != idValue)
                            {
                                id = (Guid)idValue;
                            }
                        }
                    }

                    if (id != Guid.Empty)
                    {
                        updateList[id].UpdateDates(created, modified);
                    }
                }
            }
        }

        public static void RefreshAssembly(CrmOrganization org, CrmPluginAssembly assembly)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            PluginAssembly assemblyRetrievedFromDatabase = (PluginAssembly)org.OrganizationService.Retrieve(Entities.PluginAssembly.EntityLogicalName, assembly.AssemblyId, GetColumnSet(Entities.PluginAssembly.EntityLogicalName));
            assembly.RefreshFromPluginAssembly(assemblyRetrievedFromDatabase);
        }

        public static void RefreshPlugin(CrmOrganization org, CrmPlugin plugin)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            PluginType pluginRetrievedFromDatabase = (PluginType)org.OrganizationService.Retrieve(Entities.PluginType.EntityLogicalName, plugin.PluginId, GetColumnSet(Entities.PluginType.EntityLogicalName));
            plugin.RefreshFromPluginType(pluginRetrievedFromDatabase);
        }

        public static void RefreshStep(CrmOrganization org, CrmPluginStep step)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            SdkMessageProcessingStep stepRetrievedFromDatabase = (SdkMessageProcessingStep)org.OrganizationService.Retrieve(Entities.SdkMessageProcessingStep.EntityLogicalName, step.StepId, GetColumnSet(Entities.SdkMessageProcessingStep.EntityLogicalName));
            step.RefreshFromSdkMessageProcessingStep(step.AssemblyId, stepRetrievedFromDatabase, step.SecureConfiguration);
        }

        public static void RefreshImage(CrmOrganization org, CrmPluginImage image, CrmPluginStep step)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (step == null)
            {
                throw new ArgumentNullException("step");
            }
            else if (image == null)
            {
                throw new ArgumentNullException("image");
            }

            SdkMessageProcessingStepImage imageRetrievedFromDatabase = (SdkMessageProcessingStepImage)org.OrganizationService.Retrieve(Entities.SdkMessageProcessingStepImage.EntityLogicalName, image.ImageId, GetColumnSet(Entities.SdkMessageProcessingStepImage.EntityLogicalName));
            if (step.IsProfiled && null != imageRetrievedFromDatabase.SdkMessageProcessingStepId)
            {
                imageRetrievedFromDatabase.SdkMessageProcessingStepId.Id = step.StepId;
            }

            image.RefreshFromSdkMessageProcessingStepImage(step.AssemblyId, step.PluginId, imageRetrievedFromDatabase);
        }

        public static void RefreshServiceEndpoint(CrmOrganization org, CrmServiceEndpoint sep)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            if (sep == null)
            {
                throw new ArgumentNullException("sep");
            }

            ServiceEndpoint sepRetrievedFromDatabase = (ServiceEndpoint)org.OrganizationService.Retrieve(Entities.ServiceEndpoint.EntityLogicalName, sep.ServiceEndpointId, GetColumnSet(Entities.ServiceEndpoint.EntityLogicalName));
            sep.RefreshFromServiceEndpoint(sepRetrievedFromDatabase);
        }

        public static string ExecutingDirectory
        {
            get
            {
                return new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).Directory.FullName;
            }
        }
        /// <summary>
        /// Indicates that the step can be exported
        /// </summary>
        /// <param name="step">Step to be checked</param>
        /// <returns>True if step can be exported</returns>
        public static bool AllowStepImportExport(CrmPluginStep step)
        {
            if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            if (step.CustomizationLevel == 0)
            {
                switch (step.Organization.Plugins[step.PluginId].TypeName)
                {
                    case "Microsoft.Crm.ServiceBus.ServiceBusPlugin":
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Indicates that the plugin allows registration of steps
        /// </summary>
        /// <param name="plugin">Plugin to be checked</param>
        /// <returns>True if steps can be registered on the plugin</returns>
        public static bool AllowStepRegistrationForPlugin(CrmPlugin plugin)
        {
            if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            if (plugin.CustomizationLevel == 0)
            {
                switch (plugin.TypeName)
                {
                    case "Microsoft.Crm.ServiceBus.ServiceBusPlugin":
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return true;
            }
        }

        #region Private Helper Methods
        private static CrmMessage UpdateMessageProperties(CrmMessage message)
        {
            switch (message.Name)
            {
                case "Assign":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target, "Assigned Entity"));
                    break;
                case "Create":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Id, "Created Entity"));
                    break;
                case "Delete":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target, "Deleted Entity"));
                    break;
                case "DeliverIncoming":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.EmailId, "Delivered E-mail Id"));
                    break;
                case "DeliverPromote":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.EmailId, "Delivered E-mail Id"));
                    break;
                case "ExecuteWorkflow":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target, "Workflow Entity", null));
                    break;
                case "Merge":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target,
                        "Parent Entity", "Entity into which the data from the Child Entity is being merged."));
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.SubordinateId,
                        "Child Entity", "Entity that is being merged into the Parent Entity."));
                    break;
                case "Route":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target, "Routed Entity", null));
                    break;
                case "Send":
                    //This is only applicable for Send message when the entity is e-mail. If the entity is template
                    //or fax, then the parameter should be ParameterName.FaxId or ParameterName.TemplateId
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.EmailId, "Sent Entity Id"));
                    break;
                case "SetState":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.EntityMoniker, "Entity"));
                    break;
                case "SetStateDynamicEntity":
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.EntityMoniker, "Entity"));
                    break;
                case "Update":
                    message.SupportsFilteredAttributes = true;
                    message.ImageMessagePropertyNames.Add(
                        new ImageMessagePropertyName(ParameterName.Target, "Updated Entity"));
                    break;
                default:
                    //There are no valid message property names for images for any other messages
                    break;
            }

            return message;
        }

        private static void LoadUsers(CrmOrganization org)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            //Retrieve all of the users
            OrganizationServiceContext context = new OrganizationServiceContext(org.OrganizationService);
            IQueryable<CrmUser> users = from u in context.CreateQuery<SystemUser>()
                                        orderby u.FullName ascending
                                        select new CrmUser(org)
                                        {
                                            UserId = u.SystemUserId.GetValueOrDefault(),
                                            Name = u.FullName,
                                            DomainName = u.DomainName,
                                            InternalEmailAddress = u.InternalEMailAddress,
                                            Enabled = !u.IsDisabled.GetValueOrDefault(),
                                        };

            //Loop through the users that were returned from the server
            org.Users.Clear();
            foreach (CrmUser user in users)
            {
                //Create the CrmUser object
                org.Users.Add(user.UserId, user);
            }
        }

        private static void LoadMessageEntities(CrmOrganization org, CrmEntityDictionary<CrmMessage> messages)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (messages == null)
            {
                throw new ArgumentNullException("messages");
            }
            else if (messages.Count == 0)
            {
                return;
            }

            org.ClearMessages();

            //Load the list of filters
            List<object> messageIdList = new List<object>();
            foreach (CrmMessage message in messages)
            {
                messageIdList.Add(message.MessageId);
            }

            var query = new QueryExpression();
            query.ColumnSet = GetColumnSet(Entities.SdkMessageFilter.EntityLogicalName);
            query.Criteria.AddCondition("sdkmessageid", ConditionOperator.In, messageIdList.ToArray());
            query.Criteria.AddCondition("iscustomprocessingstepallowed", ConditionOperator.Equal, true);
            query.Criteria.AddCondition("isvisible", ConditionOperator.Equal, true);
            query.Criteria.FilterOperator = LogicalOperator.And;
            query.EntityName = SdkMessageFilter.EntityLogicalName;

            foreach (SdkMessageFilter filter in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
            {
                CrmMessageEntity entity = new CrmMessageEntity(org, filter);
                CrmMessage message = messages[entity.MessageId];
                if (message.Organization == null)
                {
                    message.Organization = org;
                    org.AddMessage(message);
                }

                message.AddMessageEntity(entity);
            }
        }

        private static void LoadPlugins(CrmOrganization org, out Dictionary<Guid, CrmPlugin> typeList)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            //Create the query
            QueryExpression query = new QueryExpression(PluginType.EntityLogicalName);
            query.ColumnSet = GetColumnSet(Entities.PluginType.EntityLogicalName);
            query.Criteria = new FilterExpression();
            query.Criteria.AddCondition("typename", ConditionOperator.NotLike, "Compiled.Workflow%");

            //Add a filter to only include the desired system plugins
            FilterExpression systemAssemblyFilter = query.Criteria.AddFilter(LogicalOperator.Or);
            systemAssemblyFilter.AddCondition("customizationlevel", ConditionOperator.Null);
            systemAssemblyFilter.AddCondition("customizationlevel", ConditionOperator.NotEqual, 0);
            systemAssemblyFilter.AddCondition("typename", ConditionOperator.In,
                "Microsoft.Crm.Extensibility.InternalOperationPlugin",
                OrganizationHelper.V3CalloutProxyTypeName,
                "Microsoft.Crm.ServiceBus.ServiceBusPlugin");

            //Link to the assembly to ensure that only valid plug-ins are retrieved
            LinkEntity assemblyLink = query.AddLink(PluginAssembly.EntityLogicalName, "pluginassemblyid", "pluginassemblyid");
            assemblyLink.LinkCriteria = CreateAssemblyFilter();

            //Retrieve the results
            EntityCollection results = org.OrganizationService.RetrieveMultipleAllPages(query);

            //Initialize the map
            bool profilerPluginLocated = false;//!OrganizationHelper.IsProfilerSupported;
            typeList = new Dictionary<Guid, CrmPlugin>();
            
            foreach (PluginType plugin in results.Entities)
            {
                CrmPluginAssembly assembly = org.Assemblies[plugin.PluginAssemblyId.Id];
                if (assembly.Plugins.ContainsKey(plugin.PluginTypeId.Value))
                {
                    assembly[plugin.PluginTypeId.Value].RefreshFromPluginType(plugin);
                }
                else
                {
                    assembly.AddPlugin(new CrmPlugin(org, plugin));
                }

                CrmPlugin crmPlugin = assembly[plugin.PluginTypeId.Value];
                if (!profilerPluginLocated)
                {
                    bool isProfilerPlugin = false;// IsProfilerPlugin(crmPlugin);
                    crmPlugin.IsProfilerPlugin = isProfilerPlugin;
                    profilerPluginLocated = isProfilerPlugin;

                    if (isProfilerPlugin)
                    {
                        org.ProfilerPlugin = crmPlugin;
                        assembly.IsProfilerAssembly = true;
                    }
                }

                typeList.Add(plugin.PluginTypeId.Value, crmPlugin);
            }
        }

        private static void LoadSteps(CrmOrganization org, Dictionary<Guid, CrmPlugin> typeList, out Dictionary<Guid, CrmPluginStep> crmStepList)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            const string SecureConfigurationAttributeName = "config.secureconfig";

            List<SdkMessageProcessingStep> stepList = new List<SdkMessageProcessingStep>();
            List<object> secureConfigIdList = new List<object>();

            //Create the query for the step
            QueryExpression query = new QueryExpression(SdkMessageProcessingStep.EntityLogicalName);
            query.ColumnSet = GetColumnSet(SdkMessageProcessingStep.EntityLogicalName);
            query.Criteria = CreateStepFilter();

            //Only add this link if retrieval of the secure configuration has not failed previously
            LinkEntity secureConfigurationLink;
            if (org.SecureConfigurationPermissionDenied)
            {
                secureConfigurationLink = null;
            }
            else
            {
                //Create the link for the secure configuration
                secureConfigurationLink = query.AddLink(SdkMessageProcessingStepSecureConfig.EntityLogicalName,
                    "sdkmessageprocessingstepsecureconfigid", "sdkmessageprocessingstepsecureconfigid", JoinOperator.LeftOuter);
                secureConfigurationLink.EntityAlias = "config";
                secureConfigurationLink.Columns = GetColumnSet(SdkMessageProcessingStepSecureConfig.EntityLogicalName);
            }

            //Execute the query
            EntityCollection results;
            try
            {
                results = org.OrganizationService.RetrieveMultipleAllPages(query);
            }
            catch (FaultException<OrganizationServiceFault> ex)
            {
                //Privilege Denied Error Code
                if (null != secureConfigurationLink && 0x80040220 == (uint)ex.Detail.ErrorCode)
                {
                    //Set the flag
                    org.SecureConfigurationPermissionDenied = true;

                    //Remove the secure configuration link
                    query.LinkEntities.Remove(secureConfigurationLink);

                    //Execute the request without the link
                    results = org.OrganizationService.RetrieveMultipleAllPages(query);
                }
                else
                {
                    throw;
                }
            }

            //Loop through the results and process them
            Dictionary<Guid, CrmPluginStep> profiledStepList = new Dictionary<Guid, CrmPluginStep>();
            crmStepList = new Dictionary<Guid, CrmPluginStep>();
            foreach (SdkMessageProcessingStep step in results.Entities)
            {
                AliasedValue secureConfig = step.GetAttributeValue<AliasedValue>(SecureConfigurationAttributeName);

                //Check if the secure configuration was retrieved
                bool invalidSecureConfigurationId = false;
                if (null != step.SdkMessageProcessingStepSecureConfigId && null == secureConfig &&
                    !org.SecureConfigurationPermissionDenied)
                {
                    invalidSecureConfigurationId = true;
                }

                //Retrieve the secure configuration
                string secureConfiguration = (null == secureConfig ? null : (string)secureConfig.Value);

                //Retrieve the plug-in
#pragma warning disable 0612
                Guid pluginId = (step.PluginTypeId != null) ? step.PluginTypeId.Id : Guid.Empty;
#pragma warning restore 0612

                CrmPlugin plugin;
                if (null != typeList && typeList.TryGetValue(pluginId, out plugin))
                {
                    CrmPluginStep crmStep;
                    if (plugin.Steps.TryGetValue(step.SdkMessageProcessingStepId.GetValueOrDefault(), out crmStep))
                    {
                        crmStep.RefreshFromSdkMessageProcessingStep(plugin.AssemblyId, step, secureConfiguration);
                    }
                    else
                    {
                        crmStep = new CrmPluginStep(org, plugin.AssemblyId, step, secureConfiguration);
                        plugin.AddStep(crmStep);
                    }

                    if (plugin.IsProfilerPlugin)
                    {
                        // ProfilerConfiguration configuration = RetrieveProfilerConfiguration(crmStep);
                        //if (null != configuration)
                        //{
                        //    EntityReference profiledHandler = configuration.EventHandler;
                        //    if (configuration.IsContextReplay.GetValueOrDefault())
                        //    {
                        //        crmStep.ProfilerStepId = crmStep.StepId;
                        //    }
                        //    else if (null != profiledHandler && !profiledStepList.ContainsKey(profiledHandler.Id))
                        //    {
                        //        profiledStepList[profiledHandler.Id] = crmStep;
                        //        crmStep.ProfilerOriginalStepId = profiledHandler.Id;
                        //    }
                        //}
                    }

                    crmStep.SecureConfigurationRecordIdInvalid = invalidSecureConfigurationId;

                    crmStepList.Add(step.SdkMessageProcessingStepId.Value, plugin.Steps[step.SdkMessageProcessingStepId.Value]);
                }
            }

            //Looping through each step that is being profiled and mark it with the corresponding "Profiler Step" (plug-in instance of 
            //the Plug-in Profiler that takes the place of the original plug-in) so that it can be rendered correctly in the UI
            foreach (KeyValuePair<Guid, CrmPluginStep> pair in profiledStepList)
            {
                CrmPluginStep step;
                if (crmStepList.TryGetValue(pair.Key, out step))
                {
                    step.ProfilerStepId = pair.Value.StepId;

                    //If the step is profiled, the actual profiled step should not be listed in any of the trees, etc.
                    CrmPluginStep profiledStep = pair.Value;
                    profiledStep.Organization.Plugins[profiledStep.PluginId].RemoveStep(profiledStep.StepId);
                }
            }
        }

        /// <summary>
        /// Loads the images
        /// </summary>
        /// <param name="org"></param>
        /// <param name="imageId"></param>
        /// <param name="stepList">List of steps that were registered</param>
        /// <param name="stepIds"></param>
        private static void LoadImages(CrmOrganization org, Dictionary<Guid, CrmPluginStep> stepList)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            var query = new QueryExpression(SdkMessageProcessingStepImage.EntityLogicalName);
            query.ColumnSet = GetColumnSet(Entities.SdkMessageProcessingStepImage.EntityLogicalName);

            //Put this extra exclusion because any published Workflows will create
            //Images (linked to the Step for Workflow Expansion). Since we are using InnerJoin,
            //any images that reference invalid steps will be excluded. This is okay, because
            //images without steps will have no effect in the system.
            var parentLink = query.AddLink(SdkMessageProcessingStep.EntityLogicalName, "sdkmessageprocessingstepid", "sdkmessageprocessingstepid");
            parentLink.LinkCriteria = CreateStepFilter();

            //Execute the query
            foreach (SdkMessageProcessingStepImage image in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
            {
                CrmPluginStep step;
                if (null != stepList && stepList.TryGetValue(image.SdkMessageProcessingStepId.Id, out step))
                {
                    //If this is a profiled step, the image should be parented by the original step
                    if (null != step.ProfilerOriginalStepId)
                    {
                        if (!stepList.TryGetValue(step.ProfilerOriginalStepId.GetValueOrDefault(), out step))
                        {
                            continue;
                        }

                        image.SdkMessageProcessingStepId.Id = step.StepId;
                    }

                    CrmPluginImage existingImage;
                    if (step.Images.TryGetValue(image.Id, out existingImage))
                    {
                        existingImage.RefreshFromSdkMessageProcessingStepImage(step.AssemblyId, step.StepId, image);
                    }
                    else
                    {
                        step.AddImage(new CrmPluginImage(org, step.AssemblyId, step.PluginId, image));
                    }
                }
            }
        }

        private static FilterExpression CreateAssemblyFilter()
        {
            var criteria = new FilterExpression();

            //Exclude all compiled workflow assemblies that may remain after upgrade
            criteria.AddCondition("name", ConditionOperator.NotLike, "CompiledWorkflow%");

            //Exclude any system assemblies that shouldn't be included
            var systemAssemblyFilter = criteria.AddFilter(LogicalOperator.Or);
            systemAssemblyFilter.AddCondition("customizationlevel", ConditionOperator.Null);
            systemAssemblyFilter.AddCondition("customizationlevel", ConditionOperator.NotEqual, 0);
            systemAssemblyFilter.AddCondition("name", ConditionOperator.In, "Microsoft.Crm.ObjectModel", "Microsoft.Crm.ServiceBus");

            return criteria;
        }

        private static FilterExpression CreateStepFilter()
        {
            var criteria = new FilterExpression();

            //Exclude all steps that are not in the supported stages
            criteria.AddCondition("stage", ConditionOperator.In, "10", "20", "40", "50");

            return criteria;
        }

        /// <summary>
        /// Retrieves the needed columns for the specified entity
        /// </summary>
        /// <param name="entityName">Entity for which to generate the columns</param>
        private static ColumnSet GetColumnSet(string entityName)
        {
            if (!m_entityColumns.ContainsKey(entityName))
            {
                ColumnSet cols = new ColumnSet();
                switch (entityName)
                {
                    case ServiceEndpoint.EntityLogicalName:
                        cols.AddColumns(
                            "name", 
                            "createdon", 
                            "modifiedon", 
                            "serviceendpointid", 
                            "path", 
                            "contract", 
                            "userclaim", 
                            "solutionnamespace", 
                            "connectionmode", 
                            "description");
                        break;

                    case PluginAssembly.EntityLogicalName:
                        cols.AddColumns(
                            "name", 
                            "createdon", 
                            "modifiedon", 
                            "customizationlevel", 
                            "pluginassemblyid", 
                            "sourcetype", 
                            "path", 
                            "version", 
                            "publickeytoken", 
                            "culture", 
                            "isolationmode", 
                            "description");
                        break;

                    case PluginType.EntityLogicalName:
                        cols.AddColumns(
                            "plugintypeid", 
                            "friendlyname", 
                            "createdon", 
                            "modifiedon", 
                            "customizationlevel", 
                            "assemblyname", 
                            "typename", 
                            "pluginassemblyid", 
                            "isworkflowactivity", 
                            "name", 
                            "description", 
                            "workflowactivitygroupname");
                        break;

                    case SdkMessage.EntityLogicalName:
                        cols.AddColumns(
                            "sdkmessageid", 
                            "createdon", 
                            "modifiedon", 
                            "name", 
                            "customizationlevel");
                        break;

                    case SdkMessageFilter.EntityLogicalName:
                        cols.AddColumns(
                            "sdkmessagefilterid", 
                            "createdon", 
                            "modifiedon", 
                            "sdkmessageid", 
                            "primaryobjecttypecode", 
                            "secondaryobjecttypecode", 
                            "customizationlevel", 
                            "availability");
                        break;

                    case SdkMessageProcessingStep.EntityLogicalName:
                        cols.AddColumns(
                            "name", 
                            "mode", 
                            "customizationlevel", 
                            "stage", 
                            "rank", 
                            "sdkmessageid",
                            "sdkmessagefilterid", 
                            "plugintypeid", 
                            "supporteddeployment", 
                            "description", 
                            "asyncautodelete",
                            "impersonatinguserid", 
                            "configuration", 
                            "sdkmessageprocessingstepsecureconfigid",
                            "statecode", 
                            "invocationsource", 
                            "modifiedon", 
                            "createdon", 
                            "filteringattributes", 
                            "eventhandler");
                        break;

                    case SdkMessageProcessingStepImage.EntityLogicalName:
                        cols.AddColumns(
                            "name", 
                            "attributes", 
                            "customizationlevel", 
                            "entityalias", 
                            "createdon", 
                            "modifiedon", 
                            "imagetype", 
                            "sdkmessageprocessingstepid", 
                            "messagepropertyname", 
                            "relatedattributename");
                        break;

                    case SdkMessageProcessingStepSecureConfig.EntityLogicalName:
                        cols.AddColumns(
                            "sdkmessageprocessingstepsecureconfigid", 
                            "secureconfig");
                        break;

                    default:
                        throw new NotImplementedException(entityName.ToString());
                }

                m_entityColumns.Add(entityName, cols);
            }

            return m_entityColumns[entityName];
        }

        /// <summary>
        /// Returns the Id field for the entity using Reflection
        /// </summary>
        /// <param name="entityType">Type of the entity</param>
        /// <returns>Name of the attribute</returns>
        public static string GetPrimaryKeyField(Type entityType)
        {
            if (entityType == null)
            {
                throw new ArgumentNullException("entityType");
            }

            foreach (PropertyInfo prop in entityType.GetProperties())
            {
                if (prop.PropertyType == typeof(Guid?))
                {
                    return prop.Name;
                }
            }

            throw new ArgumentException("Does not contain property of type Key", "entityType");
        }

        private static object[] ConvertToObjectArray<T>(IList<T> list)
        {
            if (null == list || 0 == list.Count)
            {
                return new object[0];
            }

            //Create the array
            object[] newArray = new object[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                newArray[i] = list[i];
            }

            return newArray;
        }

        /// <summary>
        /// Given the current organization, determine who the current user is
        /// </summary>
        /// <param name="org">Organization to connect to</param>
        /// <returns>Returns the object from the organization that is the current logged in user</returns>
        public static CrmUser GetLoggedOnUser(CrmOrganization org)
        {
            WhoAmIResponse resp = (WhoAmIResponse)org.OrganizationService.Execute(new WhoAmIRequest());
            return org.Users[resp.UserId];
        }
        #endregion

        #region Private Classes
        private static class ParameterName
        {
            public const string EmailId = "EmailId";
            public const string EntityMoniker = "EntityMoniker";
            public const string Id = "Id";
            public const string SubordinateId = "SubordinateId";
            public const string Target = "Target";
        }
        #endregion
    }
}
