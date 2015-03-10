// =====================================================================
//
//  This file is part of the Microsoft Dynamics CRM SDK code samples.
//
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//
//  This source code is intended only as a supplement to Microsoft
//  Development Tools and/or on-line documentation.  See these other
//  materials for detailed information regarding Microsoft code samples.
//
//  THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
//  KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//  IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//  PARTICULAR PURPOSE.
//
// =====================================================================
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

using Microsoft.Crm.Services.Utility;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;

namespace PluginRegistrationTool
{
	internal sealed class ManagedTokenDiscoveryServiceProxy : DiscoveryServiceProxy
	{
		private AutoRefreshSecurityToken<DiscoveryServiceProxy, IDiscoveryService> _proxyManager;

		public ManagedTokenDiscoveryServiceProxy(Uri serviceUri, ClientCredentials userCredentials)
			: base(serviceUri, null, userCredentials, null)
		{
			this._proxyManager = new AutoRefreshSecurityToken<DiscoveryServiceProxy, IDiscoveryService>(this);
		}

		protected override SecurityTokenResponse AuthenticateDeviceCore()
		{
			return this._proxyManager.AuthenticateDevice();
		}

		protected override void AuthenticateCore()
		{
			this._proxyManager.PrepareCredentials();
			base.AuthenticateCore();
		}

		protected override void ValidateAuthentication()
		{
			this._proxyManager.RenewTokenIfRequired();
			base.ValidateAuthentication();
		}
	}

	internal sealed class ManagedTokenOrganizationServiceProxy : OrganizationServiceProxy
	{
		private AutoRefreshSecurityToken<OrganizationServiceProxy, IOrganizationService> _proxyManager;

		public ManagedTokenOrganizationServiceProxy(Uri serviceUri, ClientCredentials userCredentials)
			: base(serviceUri, null, userCredentials, null)
		{
			this._proxyManager = new AutoRefreshSecurityToken<OrganizationServiceProxy, IOrganizationService>(this);
		}

		protected override SecurityTokenResponse AuthenticateDeviceCore()
		{
			return this._proxyManager.AuthenticateDevice();
		}

		protected override void AuthenticateCore()
		{
			this._proxyManager.PrepareCredentials();
			base.AuthenticateCore();
		}

		protected override void ValidateAuthentication()
		{
			this._proxyManager.RenewTokenIfRequired();
			base.ValidateAuthentication();
		}
	}
}
