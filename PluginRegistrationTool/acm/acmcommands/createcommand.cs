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

    internal class CreateCommand : Command
    {
        private Resource resource;

        internal CreateCommand()
        {
            this.Method = RESTMethod.POST;
        }

        internal override ResponseMessage Execute()
        {
            ResponseMessage responseMessage = base.Execute();

            if (responseMessage.Status != OperationStatus.Failure)
            {
                if (this.HttpResponse.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    XmlReader xmlReader = XmlReader.Create(this.HttpResponse.GetResponseStream());
                    this.resource = Resource.DeserializeFromXml(xmlReader);
                    xmlReader.Close();
                    responseMessage.Status = OperationStatus.Success;
                    if (CommandLineArguments.IsSimpleOut)
                    {
                        responseMessage.Message = this.resource.Id;
                    }
                    else
                    {
                        responseMessage.Message = String.Format(CultureInfo.InvariantCulture, Constants.MessageCreateSuccess1, this.resource.Id);
                    }
                }
                else
                {
                    responseMessage.Status = OperationStatus.Failure;
                    responseMessage.Message = Constants.MessageCreateFailed0;
                }
            }

            return responseMessage;
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
