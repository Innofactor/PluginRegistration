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

namespace Xrm.Sdk.PluginRegistration
{
    using Controls;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;
    using System.Resources;

    public static class CrmResources
    {
        private const string TREE_RESOURCE_NAME = "CrmTreeControlDefaults";
        private const string COMMON_RESOURCE_NAME = "Resources";

        private static Dictionary<string, ResourceManager> _resourceList = null;

        #region String Resources

        /// <summary>
        /// Retrieves a string from the resource files
        /// </summary>
        /// <param name="name">Name to retrieve</param>
        /// <returns>String that is found. Null if not found.</returns>
        public static string GetString(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            else if (null == _resourceList)
            {
                LoadResourceManagers();
            }

            //Check the common resource file first
            string resourceString = _resourceList[COMMON_RESOURCE_NAME].GetString(name);
            if (string.IsNullOrEmpty(resourceString))
            {
                return _resourceList[TREE_RESOURCE_NAME].GetString(name);
            }
            else
            {
                return resourceString;
            }
        }

        /// <summary>
        /// Formats the string based on a string from the resource file
        /// </summary>
        /// <param name="provider">An System.IFormatProvider that supplies culture-specific information.</param>
        /// <param name="resourceName">Resource name that should be retrieved.</param>
        /// <param name="args">Format parameters</param>
        /// <returns>Formatted string. If resource is not found (or string is null), then string returned is null</returns>
        public static string FormatString(IFormatProvider provider, string resourceName, params object[] args)
        {
            if (null == provider)
            {
                throw new ArgumentNullException("provider");
            }
            else if (string.IsNullOrEmpty(resourceName))
            {
                throw new ArgumentNullException("resourceName");
            }

            //Retrieve the resource string
            string resourceString = GetString(resourceName);

            //If it is null, then no formatting will be done
            if (string.IsNullOrEmpty(resourceString))
            {
                return null;
            }
            else
            {
                return string.Format(provider, resourceString, args);
            }
        }

        #endregion String Resources

        #region Image Resources

        public static Image LoadImage(CrmTreeNodeImageType imageType)
        {
            return LoadImage(new CrmTreeNodeImageType[] { imageType })[imageType];
        }

        public static Dictionary<CrmTreeNodeImageType, Image> LoadImage(params CrmTreeNodeImageType[] imageType)
        {
            if (imageType == null || imageType.Length == 0)
            {
                return new Dictionary<CrmTreeNodeImageType, Image>(0);
            }

            Dictionary<CrmTreeNodeImageType, Image> imageList = new Dictionary<CrmTreeNodeImageType, Image>(imageType.Length);
            try
            {
                ResourceManager resMan = GetResourceManager(TREE_RESOURCE_NAME);
                if (null != resMan)
                {
                    foreach (CrmTreeNodeImageType type in imageType)
                    {
                        if (!imageList.ContainsKey(type))
                        {
                            imageList.Add(type, (Image)resMan.GetObject(type.ToString()));
                        }
                    }
                }
            }
            catch (Exception)
            {
                foreach (Image img in imageList.Values)
                {
                    if (img != null)
                    {
                        img.Dispose();
                    }
                }

                throw;
            }

            return imageList;
        }

        public static Image LoadImage(string key)
        {
            return LoadImage(new string[] { key })[key];
        }

        public static Dictionary<string, Image> LoadImage(params string[] key)
        {
            if (key == null || key.Length == 0)
            {
                return new Dictionary<string, Image>(0);
            }

            Dictionary<string, Image> imageList = new Dictionary<string, Image>(key.Length);
            try
            {
                ResourceManager resMan = GetResourceManager(COMMON_RESOURCE_NAME);
                if (null != resMan)
                {
                    foreach (string id in key)
                    {
                        if (!string.IsNullOrEmpty(id) && !imageList.ContainsKey(id))
                        {
                            imageList.Add(id, (Image)resMan.GetObject(id));
                        }
                    }
                }
            }
            catch (Exception)
            {
                foreach (Image img in imageList.Values)
                {
                    if (img != null)
                    {
                        img.Dispose();
                    }
                }

                throw;
            }

            return imageList;
        }

        #endregion Image Resources

        #region Private Helper Methods

        private static ResourceManager GetResourceManager(string resourceName)
        {
            if (null == _resourceList)
            {
                LoadResourceManagers();
            }

            //Attempt to retrieve the object
            ResourceManager manager;
            if (!_resourceList.TryGetValue(resourceName, out manager))
            {
                return null;
            }

            return manager;
        }

        private static void LoadResourceManagers()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            _resourceList = new Dictionary<string, ResourceManager>();

            foreach (string name in assembly.GetManifestResourceNames())
            {
                string manifestName = name;
                if (manifestName.EndsWith(".resources"))
                {
                    manifestName = manifestName.Substring(0, manifestName.Length - ".resources".Length);
                }

                if (ValidateResourceName(TREE_RESOURCE_NAME, manifestName))
                {
                    _resourceList.Add(TREE_RESOURCE_NAME, new ResourceManager(manifestName, assembly));
                }
                else if (ValidateResourceName(COMMON_RESOURCE_NAME, manifestName))
                {
                    _resourceList.Add(COMMON_RESOURCE_NAME, new ResourceManager(manifestName, assembly));
                }
            }
        }

        private static bool ValidateResourceName(string resourceName, string manifestResourceName)
        {
            if (manifestResourceName.EndsWith(resourceName))
            {
                int charIndex = manifestResourceName.Length - resourceName.Length - 1;
                if (charIndex < 0 || manifestResourceName[charIndex] == '.')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion Private Helper Methods
    }

    public static class CrmResourceStringNames
    {
        public const string ImportExportValidation_StepFriendlyNameDuplicate_Label = "ImportExportValidation_StepFriendlyNameDuplicate_Label";
        public const string ImportExportValidation_StepFriendlyNameDuplicate_Description = "ImportExportValidation_StepFriendlyNameDuplicate_Description";
        public const string ImportExportValidation_StepFriendlyNameDuplicate_Resolution = "ImportExportValidation_StepFriendlyNameDuplicate_Resolution";
        public const string ImportExportValidation_StepFriendlyNameDuplicate_PluginLabel_InMemory = "ImportExportValidation_StepFriendlyNameDuplicate_PluginLabel_InMemory";
        public const string ImportExportValidation_StepFriendlyNameDuplicate_PluginLabel_NotInMemory = "ImportExportValidation_StepFriendlyNameDuplicate_PluginLabel_NotInMemory";

        /// <summary>
        /// Retrieves the value of the constant for the given name
        /// </summary>
        /// <param name="name">Resource String Name to retrieve</param>
        /// <returns>Resource String Name</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static string GetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }

            FieldInfo field = typeof(CrmResourceStringNames).GetField(name,
                BindingFlags.IgnoreCase | BindingFlags.Static | BindingFlags.Public);
            if (null == field)
            {
                return null;
            }
            else
            {
                return (string)field.GetValue(null);
            }
        }

        /// <summary>
        /// Retrieves the name by using the given format and format arguments
        /// </summary>
        /// <param name="format">Specifies how to format the arguments</param>
        /// <param name="args">Arguments to format</param>
        /// <returns>Name if found</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static string GetNameByFormat(string format, params object[] args)
        {
            if (string.IsNullOrEmpty(format))
            {
                throw new ArgumentNullException("format");
            }

            return GetName(string.Format(System.Globalization.CultureInfo.InvariantCulture, format, args));
        }
    }
}