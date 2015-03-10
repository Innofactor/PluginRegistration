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

    [XmlRootAttribute("Rule", Namespace = Constants.ResourceNameSpace)]
    public class Rule : Resource
    {
        public Rule()
        {
            this.InputClaim = new InputClaim();
            this.OutputClaim = new OutputClaim();
        }

        public InputClaim InputClaim { get; set; }

        public OutputClaim OutputClaim { get; set; }

        [XmlElement(ElementName = "Type")]
        public string RuleType { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","id", this.Id));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","name", this.DisplayName));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","inputclaimissuerid", this.InputClaim.IssuerId));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","inputclaimtype", this.InputClaim.ClaimType));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","inputclaimvalue", this.InputClaim.Value));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","outputclaimtype", this.OutputClaim.ClaimType));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","outputclaimvalue", this.OutputClaim.Value));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","type", this.RuleType));

            return stringBuilder.ToString();
        }

        internal override void ParseAndValidate(Dictionary<string, string> options)
        {
            ValidateOptionExists(Constants.OptionGeneralName, options);
            ValidateOptionExists(Constants.OptionRuleInputClaimIssuerId, options);
            ValidateOptionExists(Constants.OptionRuleInputClaimType, options);
            
            ValidateOptionExists(Constants.OptionRuleOutputClaimType, options);
            
            ValidateOptionValueExists(Constants.OptionRuleScopeId, options);

            if (options.ContainsKey(Constants.OptionRuleIsPassthrough))
            {
                this.InputClaim.Value = string.Empty;
                this.OutputClaim.Value = string.Empty;
                this.RuleType = "Passthrough";
            }
            else
            {
                ValidateOptionExists(Constants.OptionRuleInputClaimValue, options);
                ValidateOptionExists(Constants.OptionRuleOutputClaimValue, options);
                this.InputClaim.Value = options[Constants.OptionRuleInputClaimValue];
                this.OutputClaim.Value = options[Constants.OptionRuleOutputClaimValue];
                this.RuleType = "Simple";
            }

            this.DisplayName = options[Constants.OptionGeneralName];
            this.InputClaim.IssuerId = options[Constants.OptionRuleInputClaimIssuerId];
            this.InputClaim.ClaimType = options[Constants.OptionRuleInputClaimType];
            this.OutputClaim.ClaimType = options[Constants.OptionRuleOutputClaimType];       
        }
    }
}
