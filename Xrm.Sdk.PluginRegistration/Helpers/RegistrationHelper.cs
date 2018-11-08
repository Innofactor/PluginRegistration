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

namespace Xrm.Sdk.PluginRegistration.Helpers
{
    using Entities;
    using Forms;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using Wrappers;

    public static class RegistrationHelper
    {
        #region Public Methods

        /// <summary>
        /// Generate the default group name for an activity
        /// </summary>
        public static string GenerateDefaultGroupName(string assemblyName, Version version)
        {
            if (string.IsNullOrWhiteSpace(assemblyName))
            {
                throw new ArgumentNullException("assemblyName");
            }
            else if (null == version)
            {
                throw new ArgumentNullException("version");
            }

            return string.Format(CultureInfo.InvariantCulture, "{0} ({1})", assemblyName, version);
        }

        /// <summary>
        /// Generates a step description for the given message, primary and secondary entities, for a Step
        /// </summary>
        /// <param name="typeName">Name of the plug-in type</param>
        /// <param name="messageName">Message Name</param>
        /// <param name="primaryEntity">Primary Entity</param>
        /// <param name="secondaryEntity">Secondary Entity</param>
        /// <returns>Description that the Step should use</returns>
        public static string GenerateStepDescription(string typeName, string messageName, string primaryEntity, string secondaryEntity)
        {
            var descriptionBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(typeName))
            {
                descriptionBuilder.AppendFormat("{0}: ", typeName);
            }

            if (string.IsNullOrEmpty(messageName))
            {
                descriptionBuilder.Append("Not Specified of ");
            }
            else
            {
                descriptionBuilder.AppendFormat("{0} of ", messageName);
            }

            bool hasPrimaryEntity = false;
            if (!string.IsNullOrEmpty(primaryEntity) &&
                !string.Equals(primaryEntity, "none", StringComparison.InvariantCultureIgnoreCase))
            {
                hasPrimaryEntity = true;
                descriptionBuilder.Append(primaryEntity);
            }

            if (!string.IsNullOrEmpty(secondaryEntity) &&
                !string.Equals(secondaryEntity, "none", StringComparison.InvariantCultureIgnoreCase))
            {
                string format;
                if (hasPrimaryEntity)
                {
                    format = "and {0}";
                }
                else
                {
                    format = "{0}";
                }

                descriptionBuilder.AppendFormat(format, secondaryEntity);
            }
            else if (!hasPrimaryEntity)
            {
                descriptionBuilder.Append(" any Entity");
            }

            return descriptionBuilder.ToString();
        }

        /// <summary>
        /// Determines if the given TypeName is in use for the given assembly id
        /// </summary>
        /// <param name="org">Organization to check</param>
        /// <param name="typeName">Type Name to check</param>
        /// <param name="pluginAssemblyId">Assembly that should contain the Type</param>
        /// <param name="pluginTypeId">pluginTypeId that is using the type name</param>
        /// <returns>True if the type name is found</returns>
        public static bool PluginExists(CrmOrganization org, string typeName, Guid pluginAssemblyId,
            out Guid pluginTypeId)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (typeName == null)
            {
                throw new ArgumentNullException("typeName");
            }

            QueryByAttribute query = new QueryByAttribute(PluginType.EntityLogicalName)
            {
                ColumnSet = new ColumnSet()
            };
            query.AddAttributeValue("typename", typeName);
            if (pluginAssemblyId != Guid.Empty)
            {
                query.AddAttributeValue("pluginassemblyid", pluginAssemblyId);
            }

            var results = org.OrganizationService.RetrieveMultipleAllPages(query);
            if (results.Entities != null && results.Entities.Count > 0)
            {
                pluginTypeId = results.Entities[0].Id;
                return true;
            }
            else
            {
                pluginTypeId = Guid.Empty;
                return false;
            }
        }

        public static Guid RegisterAssembly(CrmOrganization org, string pathToAssembly, CrmPluginAssembly assembly)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }
            else if (assembly.SourceType == CrmAssemblySourceType.Database && pathToAssembly == null)
            {
                throw new ArgumentNullException("pathToAssembly", "Cannot be null when SourceType is Database");
            }

            PluginAssembly ptl = (PluginAssembly)assembly.GenerateCrmEntities()[PluginAssembly.EntityLogicalName];
            if (assembly.SourceType == CrmAssemblySourceType.Database)
            {
                ptl.Content = Convert.ToBase64String(File.ReadAllBytes(pathToAssembly));
            }

            return org.OrganizationService.Create(ptl);
        }

        public static Guid RegisterImage(CrmOrganization org, CrmPluginImage image)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (image == null)
            {
                throw new ArgumentNullException("image");
            }
            return RegisterImage(org, image, org[image.AssemblyId][image.PluginId][image.StepId]);
        }

        public static Guid RegisterImage(CrmOrganization org, CrmPluginImage image, CrmPluginStep step)
        {
            if (null == org)
            {
                throw new ArgumentNullException("org");
            }
            else if (null == image)
            {
                throw new ArgumentNullException("image");
            }
            else if (null == step)
            {
                throw new ArgumentNullException("step");
            }

            //Retrieve the SDK entity equivalent of the given image
            Dictionary<string, object> entityList = image.GenerateCrmEntities(step.MessageId, step.MessageEntityId);
            SdkMessageProcessingStepImage sdkImage = (SdkMessageProcessingStepImage)entityList[SdkMessageProcessingStepImage.EntityLogicalName];

            //If the step that owns this image is a profiled step, the step will be the original step (the step that is being profiled),
            //not the profiler step. The Profiler step is what should be set on the server, since that is the step that is actually enabled.
            if (step.IsProfiled && null != sdkImage.SdkMessageProcessingStepId)
            {
                sdkImage.SdkMessageProcessingStepId.Id = step.ProfilerStepId.GetValueOrDefault();
            }

            return org.OrganizationService.Create(sdkImage);
        }

        public static Guid RegisterPlugin(CrmOrganization org, CrmPlugin plugin)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            PluginType pt = (PluginType)plugin.GenerateCrmEntities()[PluginType.EntityLogicalName];

            return org.OrganizationService.Create(pt);
        }

        public static Guid RegisterServiceEndpoint(CrmOrganization org, CrmServiceEndpoint serviceEndpoint)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (serviceEndpoint == null)
            {
                throw new ArgumentNullException("serviceEndpoint");
            }
            ServiceEndpoint sep = serviceEndpoint.GenerateCrmEntities()[ServiceEndpoint.EntityLogicalName] as ServiceEndpoint;

            return org.OrganizationService.Create(sep);
        }

        public static Guid RegisterStep(CrmOrganization org, CrmPluginStep step)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            Dictionary<string, object> entityList = step.GenerateCrmEntities();
            SdkMessageProcessingStep sdkStep = (SdkMessageProcessingStep)entityList[SdkMessageProcessingStep.EntityLogicalName];

            //This is a sanity check. The UI won't allow a user to set the secure configuration.
            if (org.SecureConfigurationPermissionDenied)
            {
                sdkStep.Attributes.Remove("sdkmessageprocessingstepsecureconfigid");
                sdkStep.RelatedEntities.Clear();
            }
            else if (entityList.ContainsKey(Entities.SdkMessageProcessingStepSecureConfig.EntityLogicalName))
            {
                Guid secureConfigId = Guid.NewGuid();

                //Create the related secure config in the related entities
                SdkMessageProcessingStepSecureConfig sdkSecureConfig =
                    (SdkMessageProcessingStepSecureConfig)entityList[SdkMessageProcessingStepSecureConfig.EntityLogicalName];
                sdkSecureConfig.Id = secureConfigId;
                sdkStep.RelatedEntities[new Relationship(CrmPluginStep.RelationshipStepToSecureConfig)] =
                    new EntityCollection(new Entity[] { sdkSecureConfig }) { EntityName = sdkSecureConfig.LogicalName };
                step.SecureConfigurationId = secureConfigId;
            }

            return org.OrganizationService.Create(sdkStep);
        }

        /// <summary>
        /// Extracts the properties for the plugin assembly
        /// </summary>
        /// <param name="pathToAssembly">Path to the DLL file that is needed to gather information</param>
        /// <returns>Properties Assembly</returns>
        public static CrmPluginAssembly RetrieveAssemblyProperties(string pathToAssembly)
        {
            using (var context = new AppDomainContext<AssemblyReader>())
            {
                return context.Proxy.RetrieveAssemblyProperties(pathToAssembly);
            }
        }

        /// <summary>
        /// Extracts all Workflow Activities and Plugins from the Assembly
        /// </summary>
        /// <param name="pathToAssembly">Path to the DLL file that is needed to gather information</param>
        /// <returns>List of Plugins in the Assembly</returns>
        public static CrmPluginAssembly RetrievePluginsFromAssembly(string pathToAssembly)
        {
            using (var context = new AppDomainContext<AssemblyReader>())
            {
                return context.Proxy.RetrievePluginsFromAssembly(pathToAssembly);
            }
        }

        public static List<Guid> RetrieveSecureConfigIdsForStepId(CrmOrganization org, IList<Guid> stepIds)
        {
            return RetrieveReferenceAttributeIds(org, SdkMessageProcessingStep.EntityLogicalName,
                "sdkmessageprocessingstepsecureconfigid", "sdkmessageprocessingstepid", stepIds);
        }

        /// <summary>
        /// Unregister entities
        /// </summary>
        /// <param name="org">Organization to be used</param>
        /// <param name="cascadeOperation">Cascade the operation</param>
        /// <param name="crmEntity">Entities to be unregistered. If these are not invalid entities, only one can be specified</param>
        /// <returns>Statistics of what was unregistered</returns>
        public static Dictionary<string, int> Unregister(CrmOrganization org, params ICrmEntity[] crmEntity)
        {
            return Unregister(org, null, crmEntity);
        }

        /// <summary>
        /// Unregister entities and cascade the operation
        /// </summary>
        /// <param name="org">Organization to be used</param>
        /// <param name="crmEntity">Entities to be unregistered. If these are not invalid entities, only one can be specified</param>
        /// <param name="cascadeOperation">Cascade the operation</param>
        /// <param name="prog">ProgressIndicator to indicate success</param>
        /// <returns>Statistics of what was unregistered</returns>
        public static Dictionary<string, int> Unregister(CrmOrganization org, ProgressIndicator prog, params ICrmEntity[] crmEntity)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (crmEntity == null || crmEntity.Length == 0)
            {
                throw new ArgumentNullException("crmEntity");
            }

            var serviceEndpointList = new Collection<Guid>();
            var assemblyList = new Collection<Guid>();
            var pluginList = new Collection<Guid>();
            var stepList = new Collection<Guid>();
            var secureConfigList = new Collection<Guid>();
            var imageList = new Collection<Guid>();

            //Create the list of various objects that need to be unregistered
            foreach (var entity in crmEntity)
            {
                switch (entity.EntityType)
                {
                    case ServiceEndpoint.EntityLogicalName:
                        serviceEndpointList.Add(entity.EntityId);
                        break;

                    case PluginAssembly.EntityLogicalName:
                        assemblyList.Add(entity.EntityId);
                        break;

                    case PluginType.EntityLogicalName:
                        pluginList.Add(entity.EntityId);
                        break;

                    case SdkMessageProcessingStep.EntityLogicalName:
                        stepList.Add(entity.EntityId);
                        break;

                    case SdkMessageProcessingStepImage.EntityLogicalName:
                        imageList.Add(entity.EntityId);
                        break;

                    default:
                        throw new NotImplementedException($"Type = {entity.EntityType.ToString()}");
                }
            }

            //Retrieve the up-to-date list of steps for the service endpoints and add them to the unregister list
            foreach (var stepId in RetrieveStepIdsForServiceEndpoint(org, serviceEndpointList))
            {
                if (!stepList.Contains(stepId))
                {
                    stepList.Add(stepId);
                }
            }
            //Retrieve the up-to-date list of plugins for the assemblies and add them to the unregister list
            foreach (var pluginId in RetrievePluginIdsForAssembly(org, assemblyList))
            {
                if (!pluginList.Contains(pluginId))
                {
                    pluginList.Add(pluginId);
                }
            }

            //Retrieve the up-to-date list of steps for the plugins and add them to the unregister list
            foreach (var stepId in RetrieveStepIdsForPlugins(org, pluginList))
            {
                if (!stepList.Contains(stepId))
                {
                    stepList.Add(stepId);
                }
            }

            //Retrieve all of the profiler steps that need to be deleted
            for (int i = stepList.Count - 1; i >= 0; i--)
            {
                CrmPluginStep step;
                if (org.Steps.TryGetValue(stepList[i], out step))
                {
                    var profilerStepId = step.ProfilerStepId.GetValueOrDefault();
                    if (Guid.Empty != profilerStepId && profilerStepId != step.StepId)
                    {
                        stepList.Add(profilerStepId);
                    }
                }
            }

            //Retrieve the up-to-date list of secure configs for the steps and add them to the unregister list
            foreach (var secureConfigId in RetrieveSecureConfigIdsForStepId(org, stepList))
            {
                if (!secureConfigList.Contains(secureConfigId))
                {
                    secureConfigList.Add(secureConfigId);
                }
            }

            //Retrieve the up-to-date list of images for the steps and add them to the unregister list
            foreach (var imageId in RetrieveImageIdsForStepId(org, stepList))
            {
                if (!imageList.Contains(imageId))
                {
                    imageList.Add(imageId);
                }
            }

            //Loop through each object and delete them
            var deleteStats = new Dictionary<string, int>();
            int totalSteps = secureConfigList.Count + 1;
            if (serviceEndpointList.Count != 0)
            {
                deleteStats.Add(serviceEndpointList.Count == 1 ? "ServiceEndpoint" : "ServiceEndpoints", serviceEndpointList.Count);
                totalSteps += serviceEndpointList.Count;
            }
            if (assemblyList.Count != 0)
            {
                deleteStats.Add(assemblyList.Count == 1 ? "Assembly" : "Assemblies", assemblyList.Count);
                totalSteps += assemblyList.Count;
            }
            if (pluginList.Count != 0)
            {
                deleteStats.Add(pluginList.Count == 1 ? "Plugin" : "Plugins", pluginList.Count);
                totalSteps += pluginList.Count;
            }
            if (stepList.Count != 0)
            {
                deleteStats.Add(stepList.Count == 1 ? "Step" : "Steps", stepList.Count);
                totalSteps += stepList.Count;
            }
            if (imageList.Count != 0)
            {
                deleteStats.Add(imageList.Count == 1 ? "Image" : "Images", imageList.Count);
                totalSteps += imageList.Count;
            }

            try
            {
                if (prog != null)
                {
                    prog.Initialize(totalSteps, "Unregistering Images");
                }
                foreach (var imageId in imageList)
                {
                    org.OrganizationService.Delete(SdkMessageProcessingStepImage.EntityLogicalName, imageId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }

                if (prog != null)
                {
                    prog.SetText("Unregistering Steps");
                }
                foreach (var stepId in stepList)
                {
                    org.OrganizationService.Delete(SdkMessageProcessingStep.EntityLogicalName, stepId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }

                if (prog != null)
                {
                    prog.SetText("Unregistering Secure Configuration");
                }
                foreach (Guid secureConfigId in secureConfigList)
                {
                    org.OrganizationService.Delete(SdkMessageProcessingStepSecureConfig.EntityLogicalName, secureConfigId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }

                if (prog != null)
                {
                    prog.SetText("Unregistering Plugins");
                }
                foreach (var pluginId in pluginList)
                {
                    org.OrganizationService.Delete(PluginType.EntityLogicalName, pluginId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }

                if (prog != null)
                {
                    prog.SetText("Unregistering Assemblies");
                }
                foreach (var assemblyId in assemblyList)
                {
                    org.OrganizationService.Delete(PluginAssembly.EntityLogicalName, assemblyId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }

                if (prog != null)
                {
                    prog.SetText("Unregistering ServiceEndpoints");
                }
                foreach (var serviceEndpointId in serviceEndpointList)
                {
                    org.OrganizationService.Delete(ServiceEndpoint.EntityLogicalName, serviceEndpointId);
                    if (prog != null)
                    {
                        prog.Increment();
                    }
                }
            }
            finally
            {
                if (prog != null)
                {
                    prog.Complete(true);
                }
            }

            return deleteStats;
        }

        /// <summary>
        /// Assembly is Uploaded if it is database.
        /// We dont do Smart updates
        /// </summary>
        /// <param name="org"></param>
        /// <param name="pathToAssembly"></param>
        /// <param name="assembly"></param>
        public static void UpdateAssembly(CrmOrganization org, string pathToAssembly, CrmPluginAssembly assembly, params PluginType[] type)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (assembly == null)
            {
                throw new ArgumentNullException("assembly");
            }

            var ptl = (PluginAssembly)assembly.GenerateCrmEntities()[PluginAssembly.EntityLogicalName];

            //If the assembly path is not set, then the content does not need to be updated
            if (!string.IsNullOrEmpty(pathToAssembly) &&
                assembly.SourceType == CrmAssemblySourceType.Database)
            {
                ptl.Content = Convert.ToBase64String(File.ReadAllBytes(pathToAssembly));
            }

            if (null != type && 0 != type.Length)
            {
                ptl.pluginassembly_plugintype = type;
            }

            org.OrganizationService.Update(ptl);
            OrganizationHelper.RefreshAssembly(org, assembly);
        }

        public static void UpdateAssembly(CrmOrganization org, string description, Guid assemblyId)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (assemblyId == Guid.Empty)
            {
                throw new ArgumentNullException("assemblyId");
            }

            // Work around as updating only description is failing with publickeytoken not null
            var pt1 = org.OrganizationService.Retrieve(PluginAssembly.EntityLogicalName, assemblyId, new ColumnSet(true)) as PluginAssembly;
            //PluginAssembly pt1 = new PluginAssembly();
            pt1.Description = description;
            org.OrganizationService.Update(pt1);
        }

        public static void UpdateImage(CrmOrganization org, CrmPluginImage image)
        {
            if (null == org)
            {
                throw new ArgumentNullException("org");
            }
            else if (null == image)
            {
                throw new ArgumentNullException("image");
            }

            UpdateImage(org, image, org[image.AssemblyId][image.PluginId][image.StepId]);
        }

        public static void UpdateImage(CrmOrganization org, CrmPluginImage image, CrmPluginStep step)
        {
            if (null == org)
            {
                throw new ArgumentNullException("org");
            }
            else if (null == image)
            {
                throw new ArgumentNullException("image");
            }
            else if (null == step)
            {
                throw new ArgumentNullException("step");
            }

            //Retrieve the SDK entity equivalent of the given image
            var entityList = image.GenerateCrmEntities(step.MessageId, step.MessageEntityId);
            var sdkImage = (SdkMessageProcessingStepImage)entityList[SdkMessageProcessingStepImage.EntityLogicalName];

            //If the step that owns this image is a profiled step, the step will be the original step (the step that is being profiled),
            //not the profiler step. The Profiler step is what should be set on the server, since that is the step that is actually enabled.
            if (step.IsProfiled && null != sdkImage.SdkMessageProcessingStepId)
            {
                sdkImage.SdkMessageProcessingStepId.Id = step.ProfilerStepId.GetValueOrDefault();
            }

            org.OrganizationService.Update(sdkImage);
            OrganizationHelper.RefreshImage(org, image, step);
        }

        public static void UpdatePlugin(CrmOrganization org, CrmPlugin plugin)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (plugin == null)
            {
                throw new ArgumentNullException("plugin");
            }

            var ptl = (PluginType)plugin.GenerateCrmEntities()[PluginType.EntityLogicalName];

            org.OrganizationService.Update(ptl);
            OrganizationHelper.RefreshPlugin(org, plugin);
        }

        public static void UpdatePlugin(CrmOrganization org, Guid pluginId, string typeName, string friendlyName)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            if (pluginId == Guid.Empty)
            {
                throw new ArgumentException("Invalid Guid", "pluginId");
            }
            if (string.IsNullOrEmpty(typeName))
            {
                throw new ArgumentException("Invalid typeName", "typeName");
            }

            if (friendlyName == null)
            {
                //No updates will occur if friendly name is null. Don't need to do anything
                return;
            }

            PluginType updatePlugin = new PluginType
            {
                PluginTypeId = new Guid?()
            };
            updatePlugin["plugintypeid"] = pluginId;

            updatePlugin.FriendlyName = friendlyName;
            updatePlugin.TypeName = typeName;
            org.OrganizationService.Update(updatePlugin);
            return;
        }

        public static void UpdatePluginFriendlyName(CrmOrganization org, Guid pluginId, string friendlyName)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (pluginId == Guid.Empty)
            {
                throw new ArgumentException("Invalid Guid", "pluginId");
            }
            else if (friendlyName == null)
            {
                //No updates will occur if friendly name is null. Don't need to do anything
                return;
            }

            PluginType updatePlugin = new PluginType
            {
                PluginTypeId = new Guid?()
            };
            updatePlugin["plugintypeid"] = pluginId;

            updatePlugin.FriendlyName = friendlyName;

            org.OrganizationService.Update(updatePlugin);
            return;
        }

        public static void UpdateServiceEndpoint(CrmOrganization org, CrmServiceEndpoint serviceEndpoint)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (serviceEndpoint == null)
            {
                throw new ArgumentNullException("serviceEndpoint");
            }
            var sep = serviceEndpoint.GenerateCrmEntities()[ServiceEndpoint.EntityLogicalName] as ServiceEndpoint;

            org.OrganizationService.Update(sep);
            OrganizationHelper.RefreshServiceEndpoint(org, serviceEndpoint);
        }

        public static bool UpdateStep(CrmOrganization org, CrmPluginStep step, Guid? origSecureConfigId, IList<CrmPluginImage> updateImages)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (step == null)
            {
                throw new ArgumentNullException("step");
            }

            var entityList = step.GenerateCrmEntities();
            var sdkStep = (SdkMessageProcessingStep)entityList[SdkMessageProcessingStep.EntityLogicalName];

            // Loop through each image and set the new message property
            List<SdkMessageProcessingStepImage> sdkImages = null;
            if (null != updateImages)
            {
                // Ensure that the given message supports images
                var message = org.Messages[step.MessageId];
                if (0 == message.ImageMessagePropertyNames.Count && step.Images.Count > 0)
                {
                    throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture,
                        "The step has images registered, but the \"{0}\" message doesn't support images.{1}In order to change the message to \"{0}\", delete the existing images.",
                        message.Name, Environment.NewLine));
                }

                // Loop through the existing images and update their message property name values
                sdkImages = new List<SdkMessageProcessingStepImage>(updateImages.Count);
                foreach (CrmPluginImage image in updateImages)
                {
                    // Set the message property name for each of the images
                    string propertyName = MessagePropertyNameForm.SelectMessagePropertyName(message);
                    if (string.IsNullOrWhiteSpace(propertyName))
                    {
                        return false;
                    }
                    else if (string.Equals(image.MessagePropertyName, propertyName, StringComparison.Ordinal))
                    {
                        continue;
                    }

                    // Create the entity to update the value
                    var sdkImage = new SdkMessageProcessingStepImage
                    {
                        Id = image.ImageId,
                        MessagePropertyName = propertyName,
                        EntityState = EntityState.Changed
                    };

                    sdkImages.Add(sdkImage);
                }
            }

            //This is a sanity check. The UI won't allow a user to set the secure configuration.
            if (org.SecureConfigurationPermissionDenied)
            {
                sdkStep.Attributes.Remove("sdkmessageprocessingstepsecureconfigid");
                sdkStep.RelatedEntities.Clear();
                origSecureConfigId = null;
            }
            else if (entityList.ContainsKey(Entities.SdkMessageProcessingStepSecureConfig.EntityLogicalName))
            {
                if (null == origSecureConfigId)
                {
                    entityList.Remove(Entities.SdkMessageProcessingStepSecureConfig.EntityLogicalName);
                }
                else
                {
                    SdkMessageProcessingStepSecureConfig sdkSecureConfig =
                        (SdkMessageProcessingStepSecureConfig)entityList[SdkMessageProcessingStepSecureConfig.EntityLogicalName];

                    Guid secureConfigId;
                    EntityState secureConfigState;
                    if (step.SecureConfigurationId == origSecureConfigId && origSecureConfigId.GetValueOrDefault() != Guid.Empty)
                    {
                        //Set the ID of the secure configuration to be the
                        secureConfigId = origSecureConfigId.GetValueOrDefault();
                        secureConfigState = EntityState.Changed;

                        //Set the original secure config id so that the current id is not deleted
                        sdkStep.SdkMessageProcessingStepSecureConfigId =
                            new EntityReference(SdkMessageProcessingStepSecureConfig.EntityLogicalName, secureConfigId);
                    }
                    else
                    {
                        secureConfigId = Guid.NewGuid();
                        secureConfigState = EntityState.Created;
                    }

                    //Set the configuration id for the step
                    step.SecureConfigurationId = secureConfigId;

                    //Populate the secure configuration object and add it to the related entities
                    sdkSecureConfig.SdkMessageProcessingStepSecureConfigId = secureConfigId;
                    sdkSecureConfig.EntityState = secureConfigState;

                    //Update the related entities
                    sdkStep.sdkmessageprocessingstepsecureconfigid_sdkmessageprocessingstep = sdkSecureConfig;

                    //Reset the original secure configuration
                    origSecureConfigId = null;
                }
            }
            else if (null != origSecureConfigId)
            {
                // To null out if it was set before
                sdkStep.SdkMessageProcessingStepSecureConfigId = null;
                step.SecureConfigurationId = Guid.Empty;

                if (Guid.Empty == origSecureConfigId)
                {
                    origSecureConfigId = null;
                }
            }

            // If the images need to be updated, there are two possible scenarios:
            // 1) The step is profiled -- The parent of the image is not the step that is currently being updated
            //    but rather the profiler step itself. In order to avoid changing this, there will have to be two SDK
            //    operations (update the step and update the images). Otherwise, the next time the profiled step executes,
            //    the images won't be present.
            // 2) The step is not profiled -- The image can be added to the related entities because the parent step is the
            //    current step being updated.
            if (null != sdkImages && sdkImages.Count > 0)
            {
                if (!step.IsProfiled || step.ProfilerStepId == step.StepId)
                {
                    sdkStep.sdkmessageprocessingstepid_sdkmessageprocessingstepimage = sdkImages;
                }
            }

            //Update the step
            org.OrganizationService.Update(sdkStep);

            if (step.IsProfiled && null != sdkImages && sdkImages.Count > 0)
            {
                // Update the Profiler step with the new property values as a single transaction to minimize the
                // possibility of data corruption.
                SdkMessageProcessingStep profilerStep = new SdkMessageProcessingStep
                {
                    Id = step.ProfilerStepId.GetValueOrDefault(),
                    sdkmessageprocessingstepid_sdkmessageprocessingstepimage = sdkImages
                };
                org.OrganizationService.Update(profilerStep);
            }

            // Refresh the objects so that the caller has up-to-date data
            OrganizationHelper.RefreshStep(org, step);
            if (null != updateImages)
            {
                foreach (CrmPluginImage image in updateImages)
                {
                    OrganizationHelper.RefreshImage(org, image, step);
                }
            }

            // Delete the orphaned Secure config when nulling out the value on the step
            if (null != origSecureConfigId)
            {
                org.OrganizationService.Delete(SdkMessageProcessingStepSecureConfig.EntityLogicalName, origSecureConfigId.GetValueOrDefault());
            }

            return true;
        }

        public static void UpdateStepDescription(CrmOrganization org, Guid stepId, string description)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (stepId == Guid.Empty)
            {
                throw new ArgumentException("Invalid Guid", "stepId");
            }
            else if (description == null)
            {
                //No updates will occur if description is null. Don't need to do anything
                return;
            }

            SdkMessageProcessingStep updateStep = new SdkMessageProcessingStep
            {
                SdkMessageProcessingStepId = new Guid?()
            };
            updateStep["sdkmessageprocessingstepid"] = stepId;

            updateStep.Description = description;

            org.OrganizationService.Update(updateStep);
            return;
        }

        public static void UpdateStepStatus(CrmOrganization org, Guid stepId, bool isEnable)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (stepId == Guid.Empty)
            {
                throw new ArgumentException("Invalid Guid", "stepId");
            }

            Microsoft.Crm.Sdk.Messages.SetStateRequest request = new Microsoft.Crm.Sdk.Messages.SetStateRequest
            {
                EntityMoniker = new EntityReference(SdkMessageProcessingStep.EntityLogicalName, stepId)
            };
            if (isEnable)
            {
                request.State = new OptionSetValue((int)SdkMessageProcessingStepState.Enabled);
            }
            else
            {
                request.State = new OptionSetValue((int)SdkMessageProcessingStepState.Disabled);
            }
            request.Status = new OptionSetValue(-1);
            org.OrganizationService.Execute(request);

            return;
        }

        #endregion Public Methods

        #region Private Methods

        private static object[] ConvertIdArrayToObjectArray(IList<Guid> idList)
        {
            if (idList == null)
            {
                return null;
            }

            List<object> newIdList = new List<object>();
            if (idList != null && idList.Count != 0)
            {
                foreach (Guid id in idList)
                {
                    if (id != Guid.Empty)
                    {
                        newIdList.Add(id);
                    }
                }
            }

            return newIdList.ToArray();
        }

        private static List<Guid> RetrieveImageIdsForStepId(CrmOrganization org, IList<Guid> stepIds)
        {
            return RetrieveReferenceAttributeIds(org, SdkMessageProcessingStepImage.EntityLogicalName, "sdkmessageprocessingstepimageid", "sdkmessageprocessingstepid", stepIds);
        }

        private static List<Guid> RetrievePluginIdsForAssembly(CrmOrganization org, IList<Guid> assemblyIds)
        {
            return RetrieveReferenceAttributeIds(org, PluginType.EntityLogicalName, "plugintypeid", "pluginassemblyid", assemblyIds);
        }

        /// <summary>
        /// Retrieve the Id for each entityName that has a filterAttribute value in the filterIdList.
        /// </summary>
        private static List<Guid> RetrieveReferenceAttributeIds(CrmOrganization org, string entityName, string retrieveAttribute, string filterAttribute, IList<Guid> filterIdList)
        {
            #region Argument Validation

            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (entityName == null)
            {
                throw new ArgumentNullException("entityName");
            }
            else if (retrieveAttribute == null)
            {
                throw new ArgumentNullException("retrieveAttribute");
            }
            else if (filterAttribute == null)
            {
                throw new ArgumentNullException("filterAttribute");
            }
            else if (retrieveAttribute == filterAttribute)
            {
                throw new ArgumentException("Attributes must be different");
            }

            #endregion Argument Validation

            if (filterIdList.Count == 0)
            {
                return new List<Guid>();
            }

            //Generate the query
            var cols = new ColumnSet();
            cols.AddColumns(retrieveAttribute);

            var idCondition = new ConditionExpression();
            idCondition.AttributeName = filterAttribute;
            idCondition.Operator = ConditionOperator.In;
            idCondition.Values.Clear();
            idCondition.Values.AddRange(ConvertIdArrayToObjectArray(filterIdList));

            var query = new QueryExpression();
            query.ColumnSet = cols;
            query.Criteria.AddCondition(idCondition);
            query.EntityName = entityName;

            //Loop through the results
            var resultList = new List<Guid>();
            foreach (var entity in org.OrganizationService.RetrieveMultipleAllPages(query).Entities)
            {
                foreach (KeyValuePair<string, object> prop in entity.Attributes)
                {
                    if (prop.Key == retrieveAttribute)
                    {
                        var propType = prop.Value.GetType();
                        if (propType == typeof(Guid))
                        {
                            resultList.Add((Guid)prop.Value);
                        }
                        else if (propType == typeof(EntityReference))
                        {
                            resultList.Add(((EntityReference)prop.Value).Id);
                        }
                        else
                        {
                            throw new ArgumentException("Unknown property returned " + prop.GetType().FullName);
                        }
                    }
                }
            }

            return resultList;
        }

        private static List<Guid> RetrieveStepIdsForPlugins(CrmOrganization org, IList<Guid> pluginIds)
        {
            return RetrieveReferenceAttributeIds(org, SdkMessageProcessingStep.EntityLogicalName, "sdkmessageprocessingstepid", "plugintypeid", pluginIds);
        }

        private static List<Guid> RetrieveStepIdsForServiceEndpoint(CrmOrganization org, IList<Guid> serviceEndpointIds)
        {
            return RetrieveReferenceAttributeIds(org, SdkMessageProcessingStep.EntityLogicalName, "sdkmessageprocessingstepid", "eventhandler", serviceEndpointIds);
        }

        #endregion Private Methods
    }
}