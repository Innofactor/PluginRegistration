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
namespace Microsoft.AccessControl.Samples.AcmTool.Resources
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Xml.Serialization;

    [XmlRootAttribute("Issuer", Namespace = Constants.ResourceNameSpace)]
    public class Issuer : Resource
    {
        public Issuer()
        {
            this.Security = new SecuritySetting();
        }

        public string IssuerName { get; set; }

        public SecuritySetting Security { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","id", this.Id));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","name", this.DisplayName));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","issuername", this.IssuerName));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","key", this.Security.CurrentKey));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","previouskey", this.Security.PreviousKey));
            stringBuilder.AppendLine(String.Format(CultureInfo.InvariantCulture, "{0,18}: {1}","algorithm", this.Security.Algorithm));

            return stringBuilder.ToString();
        }

        internal override void ParseAndValidate(Dictionary<string, string> options)
        {
            bool algorithmSymmetric = true;
            string signingKey = string.Empty;

            if (options.ContainsKey(Constants.OptionIssuerAlgorithm))
            {
                if (options[Constants.OptionIssuerAlgorithm] != Constants.AlgorithmSymmetric &&
                    options[Constants.OptionIssuerAlgorithm] != Constants.AlgorithmX509)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, Constants.OptionIssuerAlgorithm));
                }
                else
                {
                    algorithmSymmetric = options[Constants.OptionIssuerAlgorithm] == Constants.AlgorithmSymmetric;
                }
            }

            if (algorithmSymmetric)
            {
                // can't define both a -key:<key> and -autogenerate
                if (options.ContainsKey(Constants.OptionAutoGenerate) && options.ContainsKey(Constants.OptionGeneralKey))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorDuplicateKeys0));
                }

                // need to specify at least -key:<key> or -autogenerate
                if (!options.ContainsKey(Constants.OptionAutoGenerate) && !options.ContainsKey(Constants.OptionGeneralKey))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption0));
                }

                // -certfile is invalid for symmetric keys
                if (options.ContainsKey(Constants.OptionIssuerCert))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, Constants.OptionIssuerCert));
                }

                signingKey = options.ContainsKey(Constants.OptionGeneralKey) ? options[Constants.OptionGeneralKey] : GenerateKey();
            }
            else
            {
                // must not define both -key and -certfile
                if (options.ContainsKey(Constants.OptionGeneralKey) && options.ContainsKey(Constants.OptionIssuerCert))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorDuplicateKeys0));
                }

                // must define at least one -key or -certfile
                if (!options.ContainsKey(Constants.OptionGeneralKey) && !options.ContainsKey(Constants.OptionIssuerCert))
                {
                    throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, Constants.ErrorMissingOption0));
                }

                // autogeneratekey isn't valid option for X509 Certs
                if (options.ContainsKey(Constants.OptionAutoGenerate))
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorInvalidOption1, Constants.OptionAutoGenerate));
                }
                
                X509Certificate2 cert = new X509Certificate2();

                // Loads the certificate into a cert object
                // Cert object throws CryptographicException if loading fails
                // Sets signingKey to value of the certificate
                try
                {
                    if (options.ContainsKey(Constants.OptionIssuerCert))
                    {
                        cert.Import(options[Constants.OptionIssuerCert]);
                        signingKey = Convert.ToBase64String(cert.GetRawCertData());
                    }
                    else
                    {
                        signingKey = options[Constants.OptionGeneralKey];
                        Encoding encoder = new UTF8Encoding();
                        cert.Import(encoder.GetBytes(signingKey));
                    }
                }
                catch (CryptographicException exception)
                {
                    throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, Constants.ErrorCertKey1, exception.Message.Trim()));
                }

                // ensure that the private key is not sent to the management service
                if (cert.HasPrivateKey)
                {
                    throw new ArgumentException(Constants.ErrorCertPrivateKey0);
                }
            }

            ValidateOptionExists(Constants.OptionGeneralName, options);
            ValidateOptionExists(Constants.OptionIssuerName, options);

            this.DisplayName = options[Constants.OptionGeneralName];
            this.IssuerName = options[Constants.OptionIssuerName];
            this.Security.CurrentKey = signingKey;
            this.Security.PreviousKey = (options.ContainsKey(Constants.OptionIssuerPreviousKey) && !String.IsNullOrEmpty(options[Constants.OptionIssuerPreviousKey])) ? options[Constants.OptionIssuerPreviousKey] : signingKey;
            this.Security.Algorithm = algorithmSymmetric ? Constants.AlgorithmSymmetric : Constants.AlgorithmX509;
        }
    }
}
