//---------------------------------------------------------------------------------
// Microsoft (R)  Windows Azure Platform AppFabric SDK
// Software Development Kit
// 
// Copyright (c) Microsoft Corporation. All rights reserved.  
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//---------------------------------------------------------------------------------

namespace Microsoft.AccessControl.Samples.AcmTool.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    [XmlRoot(Namespace = Constants.ResourceNameSpace)]
    public abstract class Resource
    {
        protected Resource()
        {
        }

        [XmlElement(IsNullable = true)]
        public string DisplayName { get; set; }

        public string Id { get; set; }

        [XmlIgnore]
        public string Version { get; set; }

        internal static Resource DeserializeFromXml(XmlReader reader)
        {
            Resource resource;
            reader.Read();
            string typeName = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", typeof(Resource).Namespace, reader.Name);
            XmlSerializer xs = new XmlSerializer(Assembly.GetExecutingAssembly().GetType(typeName));
            resource = (Resource)xs.Deserialize(reader);

            return resource;
        }

        internal static string SerializeToXmlString(Resource resource)
        {
            XmlSerializer xs = new XmlSerializer(resource.GetType());
            StringBuilder sb = new StringBuilder(256);

            XmlWriterSettings writerSettings = new XmlWriterSettings();
            writerSettings.Indent = true;
            writerSettings.IndentChars = "    ";
            writerSettings.OmitXmlDeclaration = true;

            using (XmlWriter writer = XmlTextWriter.Create(sb, writerSettings))
            {
                xs.Serialize(writer, resource);
            }

            return sb.ToString();
        }

        internal abstract void ParseAndValidate(Dictionary<string, string> options);

        protected static void ValidateOptionExists(string option, Dictionary<string, string> options)
        {
            if (!options.ContainsKey(option))
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption1, option));
            }
        }

        internal static void ValidateOptionValueExists(string optionName, Dictionary<string, string> options)
        {
            String optionValue;
            if (!options.TryGetValue(optionName, out optionValue) || String.IsNullOrEmpty(optionValue))
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption1, optionName));
            }
        }

        protected static string GenerateKey()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] key = new byte[32];
            rng.GetBytes(key);
            return Convert.ToBase64String(key);
        }
    }
}
