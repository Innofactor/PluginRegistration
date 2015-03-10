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
    using System.IO;
    using System.Linq;
    using System.Text;
    using Microsoft.AccessControl.Samples.AcmTool.Resources;

    internal class DeleteCommand : Command
    {
        private bool isNameDelete;

        internal DeleteCommand()
        {
            this.Method = RESTMethod.DELETE;
        }

        internal override void Validate()
        {
            if (!this.CommandLineArguments.Options.ContainsKey(Constants.OptionGeneralId) && !this.CommandLineArguments.Options.ContainsKey(Constants.OptionGeneralName))
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption1, Constants.OptionGeneralNameOrId));
            }

            if (this.CommandLineArguments.Resource == ResourceType.Rule)
            {
                Resource.ValidateOptionValueExists(Constants.OptionRuleScopeId, this.CommandLineArguments.Options);
            }
        }

        internal override ResponseMessage Execute()
        {
            this.isNameDelete = this.CommandLineArguments.Options.ContainsKey(Constants.OptionGeneralName);

            ResponseMessage response;

            if (this.isNameDelete)
            {
                response = this.DeleteByName();
            }
            else
            {
                response = this.DeleteById();
            }

            return response;
        }

        private ResponseMessage DeleteByName()
        {
            string requiredName;
            
            // get the name passed from the command line
            if (!this.CommandLineArguments.Options.TryGetValue(Constants.OptionGeneralName, out requiredName))
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption1, Constants.OptionGeneralNameOrId));
            }

            // create a new command line args object
            // required to create a new command object
            CommandLineArguments getallargs = this.CommandLineArguments.Clone();
            getallargs.Command = CommandType.GetAll;

            // create a getall all command & getall the matching resources
            GetAllCommand command = getallargs.CreateCommand() as GetAllCommand;
            ResponseMessage msg = command.Execute();

            // return if failed
            if (msg.Status == OperationStatus.Failure)
            {
                return msg;
            }

            ResponseMessage responseMessage;

            // find all of the resources with a matching name
            IEnumerable<Resource> resources = command.Resources.Where(resource => resource.DisplayName == requiredName);
            
            // if there isn't a match, return an error
            if (resources.Count() < 1)
            {
                responseMessage = new ResponseMessage();
                responseMessage.Status = OperationStatus.Failure;
                responseMessage.Message = string.Format(CultureInfo.InvariantCulture, Constants.ErrorDeleteByNameFailed, requiredName + " not found");
                return responseMessage;
            }

            // if more than one match exists, return an error
            if (resources.Count() > 1)
            {
                responseMessage = new ResponseMessage();
                responseMessage.Status = OperationStatus.Failure;
                    
                StringBuilder message = resources.Aggregate(
                    new StringBuilder(),
                    (builder, resource) =>
                    {
                        builder.AppendLine(resource.Id);
                        return builder;
                    });

                responseMessage.Message = string.Format(CultureInfo.InvariantCulture, Constants.ErrorDeleteByNameFailed, "more than one resource found with that name, Ids found:\n" + message.ToString());
                return responseMessage;
            }

            // set the current Id before calling DeleteById
            if (this.CommandLineArguments.Options.ContainsKey(Constants.OptionGeneralId))
            {
                this.CommandLineArguments.Options[Constants.OptionGeneralId] = resources.First().Id;
            }
            else
            {
                this.CommandLineArguments.Options.Add(Constants.OptionGeneralId, resources.First().Id);
            }

            return this.DeleteById();
        }

        private ResponseMessage DeleteById()
        {
            ResponseMessage response = base.Execute();

            if (response.Status != OperationStatus.Failure)
            {
                if (this.HttpResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    response.Status = OperationStatus.Success;
                    response.Message = Constants.MessageDeleteSuccess0;
                }
                else
                {
                    response.Status = OperationStatus.Failure;
                    response.Message = Constants.MessageDeleteFailed0;
                }
            }

            return response;
        }
    }
}
