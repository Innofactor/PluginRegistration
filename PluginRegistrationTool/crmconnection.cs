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
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Net.Security;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;

namespace PluginRegistrationTool
{
	[Serializable]
	public sealed class CrmConnection : ICrmTreeNode
	{
		private volatile Dictionary<Guid, CrmOrganization> m_organizations;
		private Guid m_connectionId = Guid.Empty;
		private string m_label;
		private string m_url = null;
		private string m_domain;
		private string m_userName;
		private SecureString m_password;
		private volatile ClientCredentials m_credentials;
		private bool m_useSavedCredentials;
		private DiscoveryServiceProxy m_discoveryService = null;
		private volatile bool m_orgsLoaded = false;

		public CrmConnection()
			: this("Unknown", "http://localhost", null, null, null)
		{
		}

		public CrmConnection(string label, string discoveryServiceUrl, string userDomain, string userName, SecureString userPassword,
			params CrmOrganization[] organization)
		{
			this.Label = label;
			this.DiscoveryServiceUrl = discoveryServiceUrl;
			this.UserDomain = userDomain;
			this.UserName = userName;
			this.UserPassword = userPassword;

			this.m_organizations = new Dictionary<Guid, CrmOrganization>();
			this.Organizations = organization;
		}

		#region Properties
		[XmlElement(ElementName = "Id", Type = typeof(Guid), IsNullable = false)]
		public Guid ConnectionId
		{
			get
			{
				return this.m_connectionId;
			}

			set
			{
				this.m_connectionId = value;
			}
		}

		[XmlElement(ElementName = "UseSavedCredentials", Type = typeof(bool), IsNullable = false)]
		public bool UseSavedCredentials
		{
			get
			{
				return this.m_useSavedCredentials;
			}

			set
			{
				this.m_useSavedCredentials = value;
				this.m_credentials = null;
				this.m_discoveryService = null;
			}
		}

		[XmlElement(ElementName = "Label", Type = typeof(string), IsNullable = false)]
		public string Label
		{
			get
			{
				return this.m_label;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException();
				}
				else
				{
					this.m_label = value;
				}
			}
		}

		[XmlElement(ElementName = "Url", Type = typeof(string), IsNullable = false)]
		public string DiscoveryServiceUrl
		{
			get
			{
				return this.m_url;
			}

			set
			{

				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentNullException("value");
				}

				this.m_url = value;
			}
		}

		[XmlElement(ElementName = "UserDomain", Type = typeof(string), IsNullable = true)]
		public string UserDomain
		{
			get
			{
				return this.m_domain;
			}

			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					value = null;
				}

				this.m_domain = value;
				this.m_credentials = null;
				this.m_discoveryService = null;
			}
		}

		[XmlElement(ElementName = "UserName", Type = typeof(string), IsNullable = true)]
		public string UserName
		{
			get
			{
				return this.m_userName;
			}

			set
			{
				if (string.IsNullOrWhiteSpace(value))
				{
					value = null;
				}

				this.m_userName = value;
				this.m_credentials = null;
				this.m_discoveryService = null;
			}
		}

		[XmlIgnore]
		public SecureString UserPassword
		{
			get
			{
				return this.m_password;
			}

			set
			{
				this.m_password = value;
				this.m_credentials = null;
				this.m_discoveryService = null;
			}
		}

		[XmlIgnore]
		public CrmOrganization[] Organizations
		{
			get
			{
				CrmOrganization[] list = new CrmOrganization[this.m_organizations.Count];
				this.m_organizations.Values.CopyTo(list, 0);

				return list;
			}

			set
			{
				lock (this.m_organizations)
				{
					this.m_orgsLoaded = false;
					this.m_organizations.Clear();

					if (value != null)
					{
						List<CrmOrganization> orgList = new List<CrmOrganization>(value);
						orgList.Sort(new CrmOrganizationLabelComparer());

						foreach (CrmOrganization org in orgList)
						{
							if (org != null)
							{
								org.Connection = this;
								this.m_organizations.Add(org.OrganizationId, org);
							}
						}
					}
				}
			}
		}

		[XmlIgnore]
		public CrmOrganization this[Guid id]
		{
			get
			{
				return this.m_organizations[id];
			}
		}

		[XmlIgnore]
		internal DiscoveryServiceProxy DiscoveryService
		{
			get
			{
				if (null == this.m_discoveryService)
				{
					lock (this)
					{
						if (this.m_discoveryService == null)
						{
							ServicePointManager.ServerCertificateValidationCallback += MyCertificateValidation;

							this.m_discoveryService = new ManagedTokenDiscoveryServiceProxy(new Uri(this.DiscoveryServiceUrl),
								this.Credentials);
						}
					}
				}

				return this.m_discoveryService;
			}
		}

		[XmlIgnore]
		public bool OrganizationsLoaded
		{
			get
			{
				return this.m_orgsLoaded;
			}
		}

		[XmlIgnore]
		public bool OrganizationsLoading
		{
			get
			{
				return this.m_orgsLoaded;
			}
		}
		#endregion

		#region Public Methods
		public void ClearOrganizations()
		{
			lock (this.m_organizations)
			{
				foreach (CrmOrganization org in this.m_organizations.Values)
				{
					if (org.Connected)
					{
						org.Connected = false;
					}
				}

				this.m_organizations.Clear();
				this.m_orgsLoaded = false;
			}
		}

		public void RetrieveOrganizations()
		{
			lock (this.m_organizations)
			{
				this.m_orgsLoaded = false;
				this.m_organizations.Clear();

				RetrieveOrganizationsRequest request = new RetrieveOrganizationsRequest();

				//Execute the request
				RetrieveOrganizationsResponse response = (RetrieveOrganizationsResponse)this.DiscoveryService.Execute(request);
				OrganizationDetailCollection orgs = response.Details;

				CrmOrganization[] orgList = new CrmOrganization[orgs.Count];
				for (int i = 0; i < orgs.Count; i++)
				{
					orgList[i] = new CrmOrganization(orgs[i]);
				}

				this.Organizations = orgList;
				this.m_orgsLoaded = true;
			}
		}

		public void AddOrganization(CrmOrganization org)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			lock (this.m_organizations)
			{
				org.Connection = this;
				this.m_organizations.Add(org.OrganizationId, org);
			}
		}

		public override string ToString()
		{
			return this.NodeText;
		}
		#endregion

		#region Internal Properties
		internal SecurityTokenResponse UserToken
		{
			get
			{
				return this.DiscoveryService.SecurityTokenResponse;
			}
		}
		#endregion

		#region Private Properties
		internal ClientCredentials Credentials
		{
			get
			{
				if (null == this.m_credentials)
				{
					lock (this)
					{
						if (null == this.m_credentials)
						{
							//Check whether the credentials are saved
							if (this.UseSavedCredentials || string.IsNullOrEmpty(this.m_userName) || null == this.m_password)
							{
								this.m_credentials = null;
							}
							else
							{
								this.m_credentials = new ClientCredentials();
								if (string.IsNullOrWhiteSpace(this.UserDomain))
								{
									this.m_credentials.UserName.UserName = this.UserName;
								}
								else
								{
									this.m_credentials.UserName.UserName = this.UserName + "@" + this.UserDomain;
								}
								this.m_credentials.UserName.Password = this.m_password.ToUnsecureString();

								this.m_credentials.Windows.ClientCredential = new NetworkCredential(this.UserName,
									this.UserPassword.ToUnsecureString(), this.UserDomain);

								// Disable interactive as this will display a pop-up window.
								this.m_credentials.SupportInteractive = false;
							}
						}
					}
				}

				return this.m_credentials;
			}
		}
		#endregion

		#region Private Helper Methods
		/// <summary>
		/// Always Accept. It doesn't validate the server certificate but simply accepts
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="cert"></param>
		/// <param name="chain"></param>
		/// <param name="Errors"></param>
		/// <returns></returns>
		private static bool MyCertificateValidation(Object sender,
			X509Certificate cert,
			X509Chain chain,
			SslPolicyErrors Errors)
		{
			return true;
		}
		#endregion

		#region Private Helper Classes
		private sealed class CrmOrganizationLabelComparer : IComparer<CrmOrganization>
		{
			public int Compare(CrmOrganization item1, CrmOrganization item2)
			{
				if (item1 == null || item2 == null)
				{
					throw new ArgumentNullException();
				}
				else
				{
					return string.Compare(item1.OrganizationFriendlyName, item2.OrganizationFriendlyName, true);
				}
			}
		}
		#endregion

		#region ICrmTreeNode Members
		[XmlIgnore]
		public string NodeText
		{
			get
			{
				return this.m_label;
			}
		}

		[XmlIgnore]
		public Guid NodeId
		{
			get
			{
				return this.m_connectionId;
			}
		}

		[XmlIgnore]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				if (!this.m_orgsLoaded || this.m_organizations == null || this.m_organizations.Count == 0)
				{
					return new CrmOrganization[0];
				}
				else
				{
					CrmOrganization[] children = new CrmOrganization[this.m_organizations.Count];
					this.m_organizations.Values.CopyTo(children, 0);

					return children;
				}
			}
		}

		[XmlIgnore]
		public CrmTreeNodeImageType NodeImageType
		{
			get
			{
				return CrmTreeNodeImageType.Connection;
			}
		}

		[XmlIgnore]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				return CrmTreeNodeImageType.ConnectionSelected;
			}
		}

		[XmlIgnore]
		public CrmTreeNodeType NodeType
		{
			get
			{
				return CrmTreeNodeType.Connection;
			}
		}

		[XmlIgnore]
		public string NodeTypeLabel
		{
			get
			{
				return "Connection";
			}
		}
		#endregion
	}
}
