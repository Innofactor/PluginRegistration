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

namespace Microsoft.AccessControl.Samples.AcmTool.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using AcmTool.Resources;

    internal class UpdateCommand : Command
    {
        private Resource resource;

        internal UpdateCommand()
        {
            this.Method = RESTMethod.PUT;
        }

        internal override void Validate()
        {
            if (CommandLineArguments.Resource == ResourceType.Rule)
            {
                Resource.ValidateOptionValueExists(Constants.OptionRuleScopeId, this.CommandLineArguments.Options);
            }

            if (!CommandLineArguments.Options.ContainsKey(Constants.OptionGeneralId))
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption1, Constants.OptionGeneralId));
            }
        }

        internal override ResponseMessage Execute()
        {
            ResponseMessage response = base.Execute();
            if (response.Status != OperationStatus.Failure)
            {
                if (this.HttpResponse.StatusCode == System.Net.HttpStatusCode.OK) 
                {
                    response.Status = OperationStatus.Success;
                    response.Message = Constants.MessageUpdateSuccess0;
                }
                else
                {
                    response.Status = OperationStatus.Failure;
                    response.Message = Constants.MessageUpdateFailed0;
                }
            }

            return response;
        }

        internal override void Parse()
        {
            this.resource = this.CommandLineArguments.CreateResource();
            this.resource.ParseAndValidate(this.CommandLineArguments.Options);
            string payload = Resource.SerializeToXmlString(this.resource);
            this.PayloadBytes = Encoding.UTF8.GetBytes(payload);
        }
    }
}
