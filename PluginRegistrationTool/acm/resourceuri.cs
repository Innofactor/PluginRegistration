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

namespace Microsoft.AccessControl.Samples.AcmTool
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Globalization;

    internal class ResourceUri
    {
        private const string MgmtUrl = "https://{0}.{1}/mgmt";
        private const string MgmtStsUrl = "https://{0}-mgmt.{1}/WRAPv0.9/";
        private const string AllIssuersUrl = "/issuers";
        private const string AllRulesUrl = "/rulesets/{0}/rules";
        private const string AllScopesUrl = "/scopes";
        private const string AllTokenPoliciesUrl = "/tokenpolicies";
        private const string ModeNameId = "?mode=NameIdOnly";

        private const string SingleId = "/{0}";
        private const string SingleRuleId = "/{1}";

        internal static Uri GetUriForCommandLineArgument(CommandLineArguments commandLineArguments)
        {
            return GetUriForCommandLineArgument(commandLineArguments, false);
        }

        internal static Uri GetUriForCommandLineArgument(CommandLineArguments commandLineArguments, bool skipMode)
        {
            List<string> ids = new List<string>();
            bool includeId = false;
            if (commandLineArguments.Command == CommandType.Delete ||
                commandLineArguments.Command == CommandType.Get ||
                commandLineArguments.Command == CommandType.Update)
            {
                includeId = true;
                ids.Add(commandLineArguments.Options[Constants.OptionGeneralId]);
            }

            string resourcePath = string.Empty;
            switch (commandLineArguments.Resource)
            {
                case ResourceType.Scope:
                    resourcePath = AllScopesUrl + (includeId ? SingleId : String.Empty);
                    break;
                case ResourceType.Issuer:
                    resourcePath = AllIssuersUrl + (includeId ? SingleId : String.Empty);
                    break;
                case ResourceType.Rule:
                    resourcePath = AllRulesUrl + (includeId ? SingleRuleId : String.Empty);
                    ids.Insert(0, commandLineArguments.Options[Constants.OptionRuleScopeId]);
                    break;
                case ResourceType.TokenPolicy:
                    resourcePath = AllTokenPoliciesUrl + (includeId ? SingleId : String.Empty);
                    break;
            }

            if (!skipMode)
            {
                // if talking to SB Managment Service, and getting (get/getAll) then append NameId Mode to query string
                if (commandLineArguments.ServiceName.EndsWith("-sb", StringComparison.OrdinalIgnoreCase) &&
                    (commandLineArguments.Command == CommandType.Get ||
                    commandLineArguments.Command == CommandType.GetAll) &&
                    commandLineArguments.Resource == ResourceType.TokenPolicy)
                {
                    resourcePath += ModeNameId;
                }
            }

            return new Uri(string.Format(CultureInfo.InvariantCulture, MgmtUrl, commandLineArguments.ServiceName, commandLineArguments.Host) + string.Format(CultureInfo.InvariantCulture, resourcePath, ids.ToArray()));
        }

        internal static Uri GetStsUriForCommandLineArgument(CommandLineArguments commandLineArguments)
        {
            return new Uri(string.Format(CultureInfo.InvariantCulture, MgmtStsUrl, commandLineArguments.ServiceName, commandLineArguments.Host));
        }
    }
}

