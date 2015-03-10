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
    using System.Collections.Specialized;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Xml;

    internal abstract class Command
    {
        internal Command()
        {
        }

        internal CommandLineArguments CommandLineArguments { get; set; }

        protected RESTMethod Method { get; set; }

        protected HttpWebRequest HttpRequest { get; set; }

        protected HttpWebResponse HttpResponse { get; set; }

        protected byte[] PayloadBytes { get; set; }

        internal virtual ResponseMessage Execute()
        {
            ResponseMessage response = new ResponseMessage();
            Uri resourceUri = ResourceUri.GetUriForCommandLineArgument(this.CommandLineArguments);
            this.HttpRequest = (HttpWebRequest)WebRequest.Create(resourceUri);
            this.HttpRequest.Method = this.Method.ToString();

            string authorizationHeader = TokenRequestor.GetTokenHeader(this.CommandLineArguments);
            this.HttpRequest.Headers.Add(HttpRequestHeader.Authorization, authorizationHeader);

            this.HttpRequest.ContentLength = 0;
            if (this.PayloadBytes != null)
            {
                this.HttpRequest.ContentLength = this.PayloadBytes.Length;
                this.HttpRequest.ContentType = Constants.ContentType;

                try
                {
                    using (Stream reqStm = this.HttpRequest.GetRequestStream())
                    {
                        reqStm.Write(this.PayloadBytes, 0, (int)this.HttpRequest.ContentLength);
                    }
                }
                catch (WebException)
                {
                    throw new ArgumentException(Constants.ErrorConnection0);
                }
            }

            try
            {
                this.HttpResponse = (HttpWebResponse)this.HttpRequest.GetResponse();
            }
            catch (WebException exception)
            {
                response.Status = OperationStatus.Failure;

                if (exception.Response != null)
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    using (Stream exceptionStream = exception.Response.GetResponseStream())
                    {
                        xmlDoc.Load(exceptionStream);
                    }

                    string subcode = xmlDoc.GetElementsByTagName("SubCode")[0].InnerText;
                    string details = xmlDoc.GetElementsByTagName("Detail")[0].InnerText;
                    response.Message = String.Format(CultureInfo.InvariantCulture, "{0} : {1}", subcode, details);
                }
                else
                {
                    response.Message = Constants.ErrorConnection0;
                }
            }

            return response;
        }

        internal virtual void Validate()
        {
        }

        internal virtual void Parse()
        {
        }
    }
}
