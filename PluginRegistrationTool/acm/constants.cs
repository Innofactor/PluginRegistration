//------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <owner current="true" primary="true">sskier</owner>
//------------------------------------------------------------------------------

namespace Microsoft.AccessControl.Samples.AcmTool
{
    using System;

    internal enum RESTMethod
    {
        Unknown = 0,
        POST,   // Typically used to Create a resource
        GET,    // Retrieve a resource
        PUT,    // Update a resource
        DELETE, // Delete a resource
    }

    internal enum CommandType
    {
        Create,
        GetAll,
        Get,
        Update,
        Delete
    }

    internal enum ResourceType
    {
        Scope,
        Issuer,
        Rule,
        TokenPolicy
    }

    internal static class Constants
    {
        internal const string ResourceNameSpace = "http://schemas.microsoft.com/ws/2009/06/acs/rest/resources";
        internal const string ContentType = "application/xml";
        internal const string AlgorithmSymmetric = "Symmetric256BitKey";
        internal const string AlgorithmX509 = "X509";
        internal const string TokenHeader = "WRAP";
        internal const string DefaultIssuerName = "owner";

        internal const string OptionServiceName = "service";
        internal const string OptionManagementKey = "mgmtkey";
        internal const string OptionAutoGenerate = "autogeneratekey";
        internal const string OptionSimpleOut = "simpleout";
        internal const string OptionHost = "host";
        internal const string OptionHelp1 = "help";
        internal const string OptionHelp2 = "?";
        internal const string OptionGeneralKey = "key";

        internal const string ErrorSyntax0 = "Syntax error in argument(s)";
        internal const string ErrorSyntax1 = "Syntax error in argument '{0}'";

        internal const string ErrorInvalidCommand1 = "Invalid Command '{0}'";
        internal const string ErrorMissingCommand0 = "Missing Command";
        internal const string ErrorInvalidResource2 = "Invalid Resource '{0}' for Command '{1}'";
        internal const string ErrorInvalidResource1 = "Invalid Resource '{0}'";
        internal const string ErrorMissingResource1 = "Missing Resource for Command '{0}'";
        internal const string ErrorInvalidOption1 = "Invalid Option '{0}'";
        internal const string ErrorMissingOption0 = "Missing one or more required options. Use 'acm.exe <command> <resource> /?' for more help";
        internal const string ErrorMissingOption1 = "Missing option '{0}' or its value is empty. Use 'acm.exe <command> <resource> /?' for more help";
        internal const string ErrorDuplicateOption1 = "Duplicate options '{0}'";
        internal const string ErrorDuplicateKeys0 = "Can not define both 'key' and 'autogeneratekey' options";
        internal const string ErrorMissingMgmtKey0 = "Either '-mgmtkey:<mgmtkey>' must be defined or 'mgmtkey' in the configuration file must be defined";
        internal const string ErrorMissingServiceName0 = "Either '-service:<service>' must be defined or 'service' in the configuration file must be defined";
        internal const string ErrorMissingHost0 = "Either -host:<host> must be defined or 'host' in the configuration file must be defined";
        internal const string ErrorCertKey1 = "Certificate retrieval error - {0}";
        internal const string ErrorConnection0 = "Failed to connect or to authenticate, check host, service, and mgmtkey";
        internal const string ErrorCertPrivateKey0 = "Certificate must not contain private key";
        internal const string ErrorDeleteByNameFailed = "Delete by name failed - {0}";

        internal const string OptionGeneralName = "name";
        internal const string OptionGeneralId = "id";
        internal const string OptionGeneralNameOrId = "id | name";

        internal const string OptionScopeAppliesTo = "appliesto";
        internal const string OptionScopeTokenPolicyId = "tokenpolicyid";

        internal const string OptionIssuerName = "issuername";
        internal const string OptionIssuerAlgorithm = "algorithm";
        internal const string OptionIssuerPreviousKey = "previouskey";
        internal const string OptionIssuerCert = "certfile";

        internal const string OptionRuleScopeId = "scopeid";
        internal const string OptionRuleInputClaimIssuerId = "inclaimissuerid";
        internal const string OptionRuleInputClaimType = "inclaimtype";
        internal const string OptionRuleInputClaimValue = "inclaimvalue";
        internal const string OptionRuleOutputClaimType = "outclaimtype";
        internal const string OptionRuleOutputClaimValue = "outclaimvalue";
        internal const string OptionRuleIsPassthrough = "passthrough";

        internal const string OptionTokenPolicyDefaultTimeOut = "timeout";

        internal const string MessageCreateSuccess1 = "Object created successfully (ID:'{0}')";
        internal const string MessageCreateFailed0 = "Object creation failed for unknown reason";
        internal const string MessageUpdateSuccess0 = "Object updated successfully";
        internal const string MessageUpdateFailed0 = "Object update failed for unknown reason";
        internal const string MessageDeleteSuccess0 = "Object deleted successfully";
        internal const string MessageDeleteFailed0 = "Object deletion failed for unknown reason";
        internal const string MessageGetallAllCount1 = "Count";
    }
}

