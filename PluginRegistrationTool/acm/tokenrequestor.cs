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
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web;
    using AcmTool.Commands;

    internal static class TokenRequestor
    {
        internal static string GetTokenHeader(CommandLineArguments commandLineArguments)
        {
            Uri mgmtUri = ResourceUri.GetUriForCommandLineArgument(commandLineArguments, true);
            Uri mgmtStsUri = ResourceUri.GetStsUriForCommandLineArgument(commandLineArguments);

            WebRequest tokenWebRequest = WebRequest.Create(mgmtStsUri);
            tokenWebRequest.ContentType = "application/x-www-form-urlencoded";
            tokenWebRequest.Method = "POST";

            byte[] body = CreateTokenRequestBodyInBytes(
                Constants.DefaultIssuerName,
                commandLineArguments.ManagementKey,
                SetToDefaultPort(mgmtUri).AbsoluteUri);

            try
            {
                using (Stream requestStream = tokenWebRequest.GetRequestStream())
                {
                    requestStream.Write(body, 0, body.Length);
                }
            }
            catch (WebException)
            {
                throw new ArgumentException(Constants.ErrorConnection0);
            }

            string wrapToken = null;

            try
            {
                WebResponse tokenResponse = tokenWebRequest.GetResponse();

                using (Stream responseStream = tokenResponse.GetResponseStream())
                {
                    using (StreamReader streamReader = new StreamReader(responseStream))
                    {
                        wrapToken = streamReader.ReadToEnd();
                    }
                }
            }
            catch (WebException)
            {
                throw new ArgumentException(Constants.ErrorConnection0);
            }

            string[] wrapParams = wrapToken.Split('&');
            string swtToken = null;

            // iterates through simple simpleAuthParams to find the wrap_token key/value pair
            // once found sets swtToken and breaks
            foreach (string nameValue in wrapParams)
            {
                string[] keyValueArray = nameValue.Split('=');

                if (keyValueArray.Length == 2)
                {
                    string name = keyValueArray[0];

                    if (name == "wrap_access_token")
                    {
                        swtToken = HttpUtility.UrlDecode(keyValueArray[1]);
                        break;
                    }
                }
                else
                {
                    throw new ArgumentException(Constants.ErrorConnection0);
                }
            }

            return String.Format(CultureInfo.InvariantCulture, "{0} access_token=\"{1}\"", Constants.TokenHeader, swtToken);
        }

        private static byte[] CreateTokenRequestBodyInBytes(string issuerName, string sharedSecret, string appliesTo)
        {
            Dictionary<string, string> claims = new Dictionary<string, string>();

            claims.Add("Issuer", issuerName);
            claims.Add("ExpiresOn", GetExpiresOn(3).ToString(CultureInfo.InvariantCulture));

            string signature = GenerateSignature(EncodeRequest(claims), sharedSecret);
            claims.Add("HMACSHA256", signature);

            string swt = EncodeRequest(claims);

            Dictionary<string, string> requestClaimSet = new Dictionary<string, string>();
            requestClaimSet.Add("wrap_assertion_format", "SWT");
            requestClaimSet.Add("wrap_assertion", HttpUtility.UrlEncode(swt));
            requestClaimSet.Add("wrap_scope", HttpUtility.UrlEncode(appliesTo));

            return Encoding.UTF8.GetBytes(EncodeRequest(requestClaimSet));
        }

        private static Uri SetToDefaultPort(Uri uri)
        {
            UriBuilder builder = new UriBuilder(uri);
            builder.Port = -1;
            return builder.Uri;
        }

        private static string GenerateSignature(string unsignedToken, string signingKey)
        {
            try
            {
                HMACSHA256 hmac = new HMACSHA256(Convert.FromBase64String(signingKey));
                byte[] locallyGeneratedSignatureInBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(unsignedToken));
                string locallyGeneratedSignature = HttpUtility.UrlEncode(Convert.ToBase64String(locallyGeneratedSignatureInBytes));
                return locallyGeneratedSignature;
            }
            catch (FormatException)
            {
                throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, Constants.OptionManagementKey));
            }
        }

        private static string EncodeRequest(Dictionary<string, string> claimSet)
        {
            List<string> claims = new List<string>();
            foreach (KeyValuePair<string, string> claim in claimSet)
            {
                claims.Add(String.Format(CultureInfo.InvariantCulture, "{0}={1}", claim.Key, claim.Value));
            }

            return string.Join("&", claims.ToArray());
        }

        private static ulong GetExpiresOn(double minutesFromNow)
        {
            TimeSpan expiresOnTimeSpan = TimeSpan.FromMinutes(minutesFromNow);
            DateTime expiresDate = DateTime.UtcNow + expiresOnTimeSpan;
            TimeSpan ts = expiresDate - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToUInt64(ts.TotalSeconds);
        }
    }
}
