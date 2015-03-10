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

    [XmlRootAttribute("Security", Namespace = Constants.ResourceNameSpace)]
    public class SecuritySetting
    {
        public SecuritySetting()
        {
        }

        public string Algorithm { get; set; }

        public string CurrentKey { get; set; }

        public string PreviousKey { get; set; }
    }
}
