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
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using AcmTool.Resources;

    internal class GetCommand : Command
    {
        private Resource entity;

        internal GetCommand()
        {
            this.Method = RESTMethod.GET;
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
                Stream stream = this.HttpResponse.GetResponseStream();
                
                XmlReader reader = XmlTextReader.Create(stream);

                this.entity = Resource.DeserializeFromXml(reader);

                stream.Close();

                response.Status = OperationStatus.Information;
                response.Message = this.entity.ToString();
            }

            return response;
        }
    }
}
