//---------------------------------------------------------------------------------
// Copyright 2010 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License"); 
// You may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, 
// INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR 
// CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, 
// MERCHANTABLITY OR NON-INFRINGEMENT. 

// See the Apache 2 License for the specific language governing 
// permissions and limitations under the License.
//---------------------------------------------------------------------------------

using System;
namespace ACS.Management
{
	/// <summary>
	/// Defines the configuration that the sample needs. Refer to Readme for how to updated the various parameters
	/// in this file once registration with ACS is done.
	/// </summary>
	public static class SamplesConfiguration
	{
		//
		// ACS service Namespace
		//
		public static string ServiceNamespace = String.Empty;

		//
		// Management Service Configuration information.
		//
		public static string ManagementServiceIdentityName = String.Empty;
		public static string ManagementServiceIdentityKey = String.Empty;

		//
		// ACS endpoint information.
		//        
		public const string AcsManagementServicesRelativeUrl = "v2/mgmt/service/";
		public const string AcsHostUrl = "accesscontrol.windows.net";
		public const string ServiceBusHostUrl = "servicebus.windows.net";		
	}
}
