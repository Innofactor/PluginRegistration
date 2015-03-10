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
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using AcmTool.Resources;

    internal class GetAllCommand : Command
    {
        private List<Resource> result;

        internal GetAllCommand()
        {
            this.Method = RESTMethod.GET;
            this.result = new List<Resource>();
        }

        internal List<Resource> Resources
        {
            get
            {
                return this.result;
            }
        }

        internal override void Validate()
        {
            if (CommandLineArguments.Resource == ResourceType.Rule)
            {
                Resource.ValidateOptionValueExists(Constants.OptionRuleScopeId, this.CommandLineArguments.Options);
            }
        }

        internal override ResponseMessage Execute()
        {
            ResponseMessage response = base.Execute();

            if (response.Status != OperationStatus.Failure)
            {
                Stream stream = this.HttpResponse.GetResponseStream();
                this.result = new List<Resource>();

                XmlReader reader = XmlTextReader.Create(stream);
                XDocument doc = XDocument.Load(reader);
                foreach (XElement element in doc.Root.Elements())
                {
                    this.result.Add(Resource.DeserializeFromXml(element.CreateReader()));
                }

                stream.Close();

                StringBuilder message = new StringBuilder();

                message.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}",Constants.MessageGetallAllCount1, this.result.Count.ToString(CultureInfo.InvariantCulture)));
                message.AppendLine();
                
                foreach (Resource entity in this.result)
                {
                    message.AppendLine(entity.ToString());
                }

                response.Status = OperationStatus.Information;
                response.Message = message.ToString();
            }

            return response;
        }

		public List<Resource> ExecuteReturnResourceList()
		{
			ResponseMessage response = base.Execute();

			if (response.Status != OperationStatus.Failure)
			{
				Stream stream = this.HttpResponse.GetResponseStream();
				this.result = new List<Resource>();

				XmlReader reader = XmlTextReader.Create(stream);
				XDocument doc = XDocument.Load(reader);
				foreach (XElement element in doc.Root.Elements())
				{
					this.result.Add(Resource.DeserializeFromXml(element.CreateReader()));
				}

				stream.Close();

				StringBuilder message = new StringBuilder();

				message.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}",Constants.MessageGetallAllCount1, this.result.Count.ToString(CultureInfo.InvariantCulture)));
				message.AppendLine();

				return this.result;
			}

			return null;
		}
    }
}
