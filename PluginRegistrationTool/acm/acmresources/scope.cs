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
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Text;
    using System.Xml.Serialization;

    [XmlRootAttribute("Scope", Namespace = Constants.ResourceNameSpace)]
    public class Scope : Resource
    {
        public Scope()
        {
        }
        
        public string AppliesTo { get; set; }

        public string TokenPolicyId { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","id", this.Id));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","name", this.DisplayName));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","appliesto", this.AppliesTo));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","tokenpolicyid", this.TokenPolicyId));
            return stringBuilder.ToString();
        }

        internal override void ParseAndValidate(Dictionary<string, string> options)
        {
            ValidateOptionExists(Constants.OptionScopeTokenPolicyId, options);
            ValidateOptionExists(Constants.OptionScopeAppliesTo, options);
            ValidateOptionExists(Constants.OptionGeneralName, options);

            this.DisplayName = options[Constants.OptionGeneralName];
            this.AppliesTo = options[Constants.OptionScopeAppliesTo];
            this.TokenPolicyId = options[Constants.OptionScopeTokenPolicyId];
        }
    }
}
