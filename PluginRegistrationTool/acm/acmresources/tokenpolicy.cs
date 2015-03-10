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
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    [XmlRootAttribute("TokenPolicy", Namespace = Constants.ResourceNameSpace)]
    public class TokenPolicy : Resource
    {
        public TokenPolicy()
        {
        }

        public string DefaultTokenLifetimeInSeconds { get; set; }

        public string SigningKey { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","id", this.Id));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","name", this.DisplayName));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","timeout", this.DefaultTokenLifetimeInSeconds));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","key", this.SigningKey));

            return stringBuilder.ToString();
        }

        internal override void ParseAndValidate(Dictionary<string, string> options)
        {
            // can't define both a -key:<key> and -autogenerate
            if (options.ContainsKey(Constants.OptionAutoGenerate) && options.ContainsKey(Constants.OptionGeneralKey))
            {
                throw new ArgumentException(Constants.ErrorDuplicateKeys0);
            }

            // need to specify at least -key:<key> or -autogenerate
            if (!options.ContainsKey(Constants.OptionAutoGenerate) && !options.ContainsKey(Constants.OptionGeneralKey))
            {
                throw new ArgumentException(Constants.ErrorMissingOption0);
            }

            ValidateOptionExists(Constants.OptionGeneralName, options);
            
            this.DisplayName = options[Constants.OptionGeneralName];
            this.SigningKey = options.ContainsKey(Constants.OptionGeneralKey) ? options[Constants.OptionGeneralKey] : GenerateKey();

            this.DefaultTokenLifetimeInSeconds =
                options.ContainsKey(Constants.OptionTokenPolicyDefaultTimeOut) ?
                options[Constants.OptionTokenPolicyDefaultTimeOut] :
                (new TimeSpan(8, 0, 0)).TotalSeconds.ToString(CultureInfo.InvariantCulture);
        }
    }
}
