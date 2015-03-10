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
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using AcmTool.Commands;
    using AcmTool.Resources;

    // carries the state from the command line to the tool
    // it does simple syntax validation
    // CommandLineArgumentParser does business validation on this type
    internal class CommandLineArguments
    {
        private static Regex matchExpression = new Regex(@"([\/\-](?<name>[^:]+)(:(?<value>.+))?)|(?<arg>[^\/\-].*)", RegexOptions.Compiled);

        private static HashSet<string> validOptions = new HashSet<string>
        {
            Constants.OptionHelp1,
            Constants.OptionHelp2,
            Constants.OptionHost,
            Constants.OptionManagementKey,
            Constants.OptionIssuerCert,
            Constants.OptionIssuerAlgorithm,
            Constants.OptionSimpleOut,
            Constants.OptionGeneralId,
            Constants.OptionGeneralName,
            Constants.OptionAutoGenerate,
            Constants.OptionScopeAppliesTo,
            Constants.OptionScopeTokenPolicyId,
            Constants.OptionServiceName,
            Constants.OptionTokenPolicyDefaultTimeOut,
            Constants.OptionIssuerName,
            Constants.OptionGeneralKey,
            Constants.OptionIssuerPreviousKey,
            Constants.OptionRuleInputClaimIssuerId,
            Constants.OptionRuleInputClaimType,
            Constants.OptionRuleInputClaimValue,
            Constants.OptionRuleIsPassthrough,
            Constants.OptionRuleOutputClaimType,
            Constants.OptionRuleOutputClaimValue,
            Constants.OptionRuleScopeId,
        };

        private IList<string> commandLineArgs = new List<string>();
        private bool helpRequest;
        private bool simpleOut;
        private Dictionary<string, string> options = new Dictionary<string, string>();
        private CommandType commandType;
        private ResourceType resourceType;
        private string host;
        private string serviceName;
        private string mgmtKey;

        internal CommandLineArguments()
        {
        }

        internal Dictionary<string, string> Options
        {
            get
            {
                return this.options;
            }

            set
            {
                this.options = value;
            }
        }

        internal CommandType Command
        {
            get
            {
                return this.commandType;
            }

            set
            {
                this.commandType = value;
            }
        }

        internal ResourceType Resource
        {
            get
            {
                return this.resourceType;
            }

            set
            {
                this.resourceType = value;
            }
        }

        internal string ServiceName
        {
            get
            {
                return this.serviceName;
            }

            set
            {
                this.serviceName = value;
            }
        }

        internal string Host
        {
            get
            {
                return this.host;
            }

            set
            {
                this.host = value;
            }
        }

        internal string ManagementKey
        {
            get
            {
                return this.mgmtKey;
            }

            set
            {
                this.mgmtKey = value;
            }
        }

        internal bool IsHelpRequest
        {
            get
            {
                return this.helpRequest;
            }

            set
            {
                this.helpRequest = value;
            }
        }

        internal bool IsSimpleOut
        {
            get
            {
                return this.simpleOut;
            }

            set
            {
                this.simpleOut = value;
            }
        }

        internal bool HasCommand()
        {
            return this.commandLineArgs.Count >= 1;
        }

        internal bool HasResource()
        {
            return this.commandLineArgs.Count >= 2;
        }

        internal void Validate()
        {
            // validates command is defined
            if (!this.HasCommand())
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingCommand0));
            }

            // validates command target is defined
            if (!this.HasResource())
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingResource1, this.Command));
            }

            // validates that user isn't trying to perfom update on rule (operation isn't allowed)
            if (this.Command == CommandType.Update && this.Resource == ResourceType.Rule)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidResource2, this.Resource, this.Command));
            }

            // if greater than 2, the user specified additional arguments that are not understood
            if (this.commandLineArgs.Count > 2)
            {
                throw new ArgumentException(Constants.ErrorSyntax0);
            }

            // IsSimpleOut only makes sense for Create
            if (this.commandType != CommandType.Create && this.IsSimpleOut)
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, Constants.OptionSimpleOut));
            }

            // validates all option keys are valid
            foreach (string optionKey in this.Options.Keys)
            {
                if (!validOptions.Contains(optionKey))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, optionKey));
                }
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
        internal void Parse(string[] args)
        {
            string matchName = "name";
            string matchValue = "value";
            string matchArg = "arg";

            foreach (string argument in args)
            {
                Match match = matchExpression.Match(argument);
                if (!match.Success)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorSyntax1, argument));
                }

                // this matched the "-name:value" or "/name:value" or "-name" or "/name" pattern, therefore it is an Option
                if (match.Groups[matchName].Success)
                {
                    UTF8Encoding utf8Enc = new UTF8Encoding(false, true);

                    // name is required, so matches the name first
                    string argumentName = match.Groups[matchName].Value.ToLowerInvariant();

                    // value is optional therefore on failure the argument value is null
                    string argumentValue = match.Groups[matchValue].Success ? match.Groups[matchValue].Value : null;

                    if (String.IsNullOrEmpty(argumentName))
                    {
                        throw new ArgumentException(Constants.ErrorSyntax0);
                    }

                    // checks for duplicate options
                    if (this.options.ContainsKey(argumentName))
                    {
                        throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorDuplicateOption1, argumentName));
                    }


                    if (!string.IsNullOrEmpty(argumentValue))
                    {
                        try
                        {
                            utf8Enc.GetBytes(argumentValue);
                        }
                        catch (ArgumentException)
                        {
                            throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorSyntax1, argumentValue));
                        }
                    }
                    this.options[argumentName] = argumentValue;
                }
                else
                {
                    // this is an argument (not option) since it doesn't match "-X:Y" pattern
                    this.commandLineArgs.Add(match.Groups[matchArg].Value.ToLowerInvariant());
                }
            }

            if (this.HasCommand())
            {
                try
                {
                    this.commandType = (CommandType)Enum.Parse(typeof(CommandType), this.commandLineArgs[0], true);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidCommand1, this.commandLineArgs[0]));
                }
            }

            if (this.HasResource())
            {
                try
                {
                    this.resourceType = (ResourceType)Enum.Parse(typeof(ResourceType), this.commandLineArgs[1], true);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidResource1, this.commandLineArgs[1]));
                }
            }

            if (this.Options.ContainsKey(Constants.OptionSimpleOut))
            {
                this.simpleOut = true;
            }

            // if /? or /help is specified, or if command or resourece are missing this is a help request
            if (this.Options.ContainsKey(Constants.OptionHelp1) ||
                    this.Options.ContainsKey(Constants.OptionHelp2) ||
                    (!this.HasCommand() || !this.HasResource()))
            {
                this.helpRequest = true;
            }
            else
            {
                // sets this.host from user input or from config
                this.host = this.GetConfig(Constants.OptionHost, Constants.ErrorMissingHost0);

                // sets this.serviceName from user input or config
                this.serviceName = this.GetConfig(Constants.OptionServiceName, Constants.ErrorMissingServiceName0);

                // sets this.mgmtKey from user input or config
                this.mgmtKey = this.GetConfig(Constants.OptionManagementKey, Constants.ErrorMissingMgmtKey0);
            }
        }

        internal Command CreateCommand()
        {
            Command returnCommand;
            switch (this.Command)
            {
                case CommandType.Create:
                    returnCommand = new CreateCommand();
                    break;
                case CommandType.Delete:
                    returnCommand = new DeleteCommand();
                    break;
                case CommandType.GetAll:
                    returnCommand = new GetAllCommand();
                    break;
                case CommandType.Get:
                    returnCommand = new GetCommand();
                    break;
                case CommandType.Update:
                    returnCommand = new UpdateCommand();
                    break;
                default:
                    returnCommand = null;
                    break;
            }

            returnCommand.CommandLineArguments = this;
            return returnCommand;
        }

        internal Resource CreateResource()
        {
            Resource returnResource;
            switch (this.Resource)
            {
                case ResourceType.Scope:
                    returnResource = new Scope();
                    break;
                case ResourceType.TokenPolicy:
                    returnResource = new TokenPolicy();
                    break;
                case ResourceType.Issuer:
                    returnResource = new Issuer();
                    break;
                case ResourceType.Rule:
                    returnResource = new Rule();
                    break;
                default:
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidResource2, this.Command, this.Resource));
            }

            return returnResource;
        }

        internal CommandLineArguments Clone()
        {
            CommandLineArguments args = new CommandLineArguments();
            args.Options = this.Options;
            args.Command = this.Command;
            args.Host = this.Host;
            args.IsHelpRequest = this.IsHelpRequest;
            args.IsSimpleOut = this.IsSimpleOut;
            args.ManagementKey = this.ManagementKey;
            args.Resource = this.Resource;
            args.ServiceName = this.ServiceName;

            return args;
        }

        private string GetConfig(string optionKey, string errorString)
        {
            string optionValue = String.Empty;
            if (this.Options.ContainsKey(optionKey))
            {
                if (String.IsNullOrEmpty(this.Options[optionKey]))
                {
                    throw new ArgumentException(errorString);
                }
                else
                {
                    optionValue = this.options[optionKey];
                }
            }
           /* else
            {
                if (String.IsNullOrEmpty(ConfigurationManager.AppSettings.Get(optionKey)))
                {
                    throw new ArgumentException(errorString);
                }
                else
                {
                    optionValue = ConfigurationManager.AppSettings.Get(optionKey);
                }
            } */

            return optionValue;
        }
    }
}
