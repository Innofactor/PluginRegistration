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
    using System.Xml.Serialization;

    public class InputClaim
    {
        public InputClaim()
        {
        }

        public string IssuerId { get; set; }

        [XmlElement(ElementName = "Type")]
        public string ClaimType { get; set; }

        [XmlElement(IsNullable = true)]
        public string Value { get; set; }
    }
}
