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

using Microsoft.Xrm.Sdk.Client;

namespace PluginRegistrationTool
{
	/// <summary>
	/// Class that wraps acquiring the security token for a service
	/// </summary>
	public sealed class AutoRefreshSecurityToken<TProxy, TService>
		where TProxy : ServiceProxy<TService>
		where TService : class
	{
		private ClientCredentials _deviceCredentials;
		private TProxy _proxy;

		/// <summary>
		/// Instantiates an instance of the proxy class
		/// </summary>
		/// <param name="proxy">Proxy that will be used to authenticate the user</param>
		public AutoRefreshSecurityToken(TProxy proxy)
		{
			if (null == proxy)
			{
				throw new ArgumentNullException("proxy");
			}

			this._proxy = proxy;
		}

		/// <summary>
		/// Prepares authentication before authen6ticated
		/// </summary>
		public void PrepareCredentials()
		{
			if (null == this._proxy.ClientCredentials)
			{
				return;
			}

			switch (this._proxy.ServiceConfiguration.AuthenticationType)
			{
				case AuthenticationProviderType.ActiveDirectory:
					this._proxy.ClientCredentials.UserName.UserName = null;
					this._proxy.ClientCredentials.UserName.Password = null;
					break;
				case AuthenticationProviderType.Federation:
				case AuthenticationProviderType.LiveId:
					this._proxy.ClientCredentials.Windows.ClientCredential = null;
					break;
				default:
					return;
			}
		}

		/// <summary>
		/// Authenticates the device token
		/// </summary>
		/// <returns>Generated SecurityTokenResponse for the device</returns>
		public SecurityTokenResponse AuthenticateDevice()
		{
			if (null == this._deviceCredentials)
			{
				this._deviceCredentials = DeviceIdManager.LoadOrRegisterDevice(
					this._proxy.ServiceConfiguration.CurrentIssuer.IssuerAddress.Uri);
			}

			return this._proxy.ServiceConfiguration.AuthenticateDevice(this._deviceCredentials);
		}

		/// <summary>
		/// Renews the token (if it is near expiration or has expired)
		/// </summary>
		public void RenewTokenIfRequired()
		{
			if (null != this._proxy.SecurityTokenResponse &&
				DateTime.UtcNow.AddMinutes(15) >= this._proxy.SecurityTokenResponse.Response.Lifetime.Expires)
			{
				try
				{
					this._proxy.Authenticate();
				}
				catch (CommunicationException)
				{
					if (null == this._proxy.SecurityTokenResponse ||
						DateTime.UtcNow >= this._proxy.SecurityTokenResponse.Response.Lifetime.Expires)
					{
						throw;
					}

					//Ignore the exception, since this 
				}
			}
		}
	}
}
