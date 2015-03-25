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
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.AccessControl.Samples.AcmTool;
using Microsoft.AccessControl.Samples.AcmTool.Resources;
using System.Web;
using System.Net;
using System.IO;
using AuthProviderType = Microsoft.Xrm.Sdk.Client.AuthenticationProviderType;

namespace PluginRegistrationTool
{
	public partial class ACSConfigurationForm : Form
	{				
		private CrmOrganization m_org;
		private CrmServiceEndpoint m_serviceEndpoint;
		private const string m_orgClaimType = "http://schemas.microsoft.com/xrm/2011/Claims/Organization";
		private const string m_userClaimType = "http://schemas.microsoft.com/xrm/2011/Claims/User";
		private const string m_initiatingUserClaimType = "http://schemas.microsoft.com/xrm/2011/Claims/InitiatingUser";
		
		private const string m_host = "accesscontrol.windows.net";

		public ACSConfigurationForm(CrmOrganization org, CrmServiceEndpoint serviceEndpoint)
		{	
			if (serviceEndpoint == null)
			{
				throw new ArgumentNullException("serviceEndpoint");
			}

			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			InitializeComponent();
			this.m_org = org;
			this.m_serviceEndpoint = serviceEndpoint;

			this.Text = "ACS Configuration - " + m_serviceEndpoint.SolutionNamespace;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{

			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
		private void btnConfigureACS_Click(object sender, EventArgs e)
		{
			DialogResult response = MessageBox.Show("This action will configure Windows Azure AppFabric ACS to allow Microsoft Dynamics CRM to post to the solution and path specified by the service endpoint configuration. This action will delete any matching component that may already exist and then create the service identity, issuer, token policy, scope, relying party, rule groups and rules." + Environment.NewLine + Environment.NewLine + "Do you want to continue?", "Action cannot be undone", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
			if (response != DialogResult.Yes)
			{
				return;
			}

			txtConfigureACSStatus.Text = String.Empty;

			if (String.IsNullOrEmpty(txtManagementKey.Text))
			{
				txtConfigureACSStatus.Text += "Management key cannot be empty" + Environment.NewLine;
			}

			if (String.IsNullOrEmpty(txtPublicCertificate.Text))
			{
				txtConfigureACSStatus.Text += "Public certificate cannot be empty" + Environment.NewLine;
			}

			if (String.IsNullOrEmpty(txtIssuerName.Text))
			{
				txtConfigureACSStatus.Text += "Issuer name cannot be empty";
			}

			if (!String.IsNullOrEmpty(txtConfigureACSStatus.Text))
			{
				return;
			}

			m_serviceEndpoint.AcsManagementKey = txtManagementKey.Text;
			m_serviceEndpoint.AcsPublicCertificate = txtPublicCertificate.Text;
			m_serviceEndpoint.AcsIssuerName = txtIssuerName.Text;

			txtConfigureACSStatus.Text = String.Empty;
			RefreshConfigureACSStatus();

			ConfigureACS();
		}

		private string populateArg(string name, string value)
		{
			return ("-" + name + ":" + value);
		}

		private string GetOrCreateResource(bool isServiceBusScope, string resourceType, Dictionary<string, string> argsCollection)
		{
			List<string> lstAcmArgs = new List<string>();
			lstAcmArgs.Add("getall ");
			lstAcmArgs.Add(resourceType + " ");
			lstAcmArgs.Add(populateArg(Constants.OptionHost, m_host));
			if (isServiceBusScope)
			{
				lstAcmArgs.Add(populateArg(Constants.OptionServiceName, m_serviceEndpoint.SolutionNamespace + "-sb"));
			}
			else
			{
				lstAcmArgs.Add(populateArg(Constants.OptionServiceName, m_serviceEndpoint.SolutionNamespace));
			}
			lstAcmArgs.Add(populateArg(Constants.OptionManagementKey, m_serviceEndpoint.AcsManagementKey));

			Acm acm = new Acm();
			if (resourceType.Equals("rule"))
			{
				lstAcmArgs.Add(populateArg(Constants.OptionRuleScopeId, argsCollection[Constants.OptionRuleScopeId]));
			}
			List<Microsoft.AccessControl.Samples.AcmTool.Resources.Resource> resources = acm.ConfigureACSGetResources(lstAcmArgs.ToArray());
			if (resourceType.Equals("rule"))
			{
				lstAcmArgs.Remove("-" + Constants.OptionRuleScopeId + ":" + argsCollection[Constants.OptionRuleScopeId]);
			}

			string resourceId = String.Empty;
			Issuer newIssuer = null;
			TokenPolicy newTokenPolicy = null;
			Scope newScope = null;
			Rule newRule = null;
			switch (resourceType)
			{
				case "issuer":
					newIssuer = new Issuer();
					if ((argsCollection.Keys.Contains(Constants.OptionIssuerName)) && (argsCollection[Constants.OptionIssuerName] == "owner") && (argsCollection.Keys.Contains(Constants.OptionIssuerPreviousKey)) && (argsCollection[Constants.OptionIssuerPreviousKey] == m_serviceEndpoint.AcsManagementKey))
					{
						//This is a special case for owner issuer.
						newIssuer = null;
					}
					else
					{
						newIssuer.ParseAndValidate(argsCollection);
					}
					if (resources != null)
					{
						foreach (Microsoft.AccessControl.Samples.AcmTool.Resources.Resource resource in resources)
						{
							if (CompareIssuer((Issuer)resource, newIssuer))
							{
								resourceId = resource.Id;
								break;
							}
						}
					}
					break;
				case "tokenpolicy":
					if (isServiceBusScope && resources.Count > 0)
					{
						resourceId = resources[0].Id;
						return resourceId;
					}
					else
					{
						newTokenPolicy = new TokenPolicy();
						argsCollection.Add(Constants.OptionAutoGenerate, "");
						newTokenPolicy.ParseAndValidate(argsCollection);
						if (resources != null)
						{
							foreach (Microsoft.AccessControl.Samples.AcmTool.Resources.Resource resource in resources)
							{
								if (CompareTokenPolicy((TokenPolicy)resource, newTokenPolicy))
								{
									resourceId = resource.Id;
									break;
								}
							}
						}
					}
					break;
				case "scope":
					newScope = new Scope();
					newScope.ParseAndValidate(argsCollection);
					if (resources != null)
					{
						foreach (Microsoft.AccessControl.Samples.AcmTool.Resources.Resource resource in resources)
						{
							if (CompareScope((Scope)resource, newScope))
							{
								resourceId = resource.Id;
								break;
							}
						}
					}
					break;
				case "rule":
					if (!isServiceBusScope && argsCollection[Constants.OptionRuleInputClaimType].Equals(argsCollection[Constants.OptionRuleOutputClaimType]))
					{
						argsCollection.Add(Constants.OptionRuleIsPassthrough, "");
					}
					newRule = new Rule();
					newRule.ParseAndValidate(argsCollection);

					if (resources != null)
					{
						foreach (Microsoft.AccessControl.Samples.AcmTool.Resources.Resource resource in resources)
						{
							if (CompareRule((Rule)resource, newRule))
							{
								resourceId = resource.Id;
								break;
							}
						}
					}
					break;
				default:
					throw new NotImplementedException(resourceType);					
			}

			if (String.IsNullOrEmpty(resourceId)) //Owner Issuer which is a special case. We don't want to create this, even if not present.
			{
				if (resourceType.Equals("issuer") && (newIssuer == null))
				{
					return resourceId;
				}

				lstAcmArgs[0] = "create ";
				foreach (string key in argsCollection.Keys)
				{
					if (String.IsNullOrEmpty(argsCollection[key]))
					{
						lstAcmArgs.Add("-" + key);
					}
					else
					{
						lstAcmArgs.Add("-" + key + ":" + argsCollection[key]);
					}
				}

				string acmResult = acm.ConfigureACS(lstAcmArgs.ToArray());
				string searchString = "ID:'";
				int matchIndex = acmResult.IndexOf(searchString, StringComparison.OrdinalIgnoreCase);
				if (matchIndex == -1)
				{
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Result when creating {0} is {1}. It does not contain the expected substring: {2}. Unable to proceed with the rest of the operation.", resourceType, acmResult, searchString);
					return resourceId;
				}
				acmResult = acmResult.Substring(matchIndex + searchString.Length);				
				acmResult = acmResult.Replace("')", "");
				resourceId = acmResult;

				txtConfigureACSStatus.Text += Environment.NewLine + "Creating " + resourceType;

				switch (resourceType)
				{
					case "issuer":
						newIssuer.Id = resourceId;
						IssuerDetails(newIssuer);
						break;
					case "tokenpolicy":
						newTokenPolicy.Id = resourceId;
						TokenPolicyDetails(newTokenPolicy);
						break;
					case "scope":
						newScope.Id = resourceId;
						ScopeDetails(newScope);
						break;
					case "rule":
						newRule.Id = resourceId;
						RuleDetails(newRule);
						break;
					default:
						throw new NotImplementedException(resourceType);		
				}
			}

			txtConfigureACSStatus.Text += Environment.NewLine;
			RefreshConfigureACSStatus();
			return resourceId;
		}

		public bool CompareIssuer(Issuer existingIssuer, Issuer newIssuer)
		{
			if (newIssuer != null)
			{
				if ((existingIssuer.IssuerName.Equals(newIssuer.IssuerName))
						&& (existingIssuer.Security.Algorithm.Equals(newIssuer.Security.Algorithm))
						&& (existingIssuer.Security.CurrentKey.Equals(newIssuer.Security.CurrentKey)))
				{
					txtConfigureACSStatus.Text += Environment.NewLine + "Found issuer";
					IssuerDetails(existingIssuer);
					return true;
				}
				else
				{
					return false;
				}
			}
			else //Owner Issuer which is not a special case
			{
				if ((existingIssuer.IssuerName.Equals("owner"))
						&& (existingIssuer.Security.Algorithm.Equals(Constants.AlgorithmSymmetric))
						&& (existingIssuer.Security.CurrentKey.Equals(m_serviceEndpoint.AcsManagementKey))
						&& (existingIssuer.Security.PreviousKey.Equals(m_serviceEndpoint.AcsManagementKey)))
				{
					txtConfigureACSStatus.Text += Environment.NewLine + "Found issuer";
					IssuerDetails(existingIssuer);
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public bool CompareRule(Rule existingRule, Rule newRule)
		{
			if ((existingRule.InputClaim.IssuerId.Equals(newRule.InputClaim.IssuerId))
					&& (existingRule.InputClaim.ClaimType.Equals(newRule.InputClaim.ClaimType))
					&& (existingRule.InputClaim.Value.Equals(newRule.InputClaim.Value))
					&& (existingRule.OutputClaim.ClaimType.Equals(newRule.OutputClaim.ClaimType))
					&& (existingRule.OutputClaim.Value.Equals(newRule.OutputClaim.Value))
					&& (existingRule.RuleType.Equals(newRule.RuleType, StringComparison.OrdinalIgnoreCase)))
			{
				txtConfigureACSStatus.Text += Environment.NewLine + "Found rule";
				RuleDetails(existingRule);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool CompareScope(Scope existingScope, Scope newScope)
		{
			if (existingScope.AppliesTo.Equals(newScope.AppliesTo))
			{
				txtConfigureACSStatus.Text += Environment.NewLine + "Found scope";
				ScopeDetails(existingScope);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool CompareTokenPolicy(TokenPolicy existingTokenPolicy, TokenPolicy newTokenPolicy)
		{
			if (existingTokenPolicy.DefaultTokenLifetimeInSeconds.Equals(newTokenPolicy.DefaultTokenLifetimeInSeconds))
			{
				txtConfigureACSStatus.Text += Environment.NewLine + "Found tokenpolicy";
				TokenPolicyDetails(existingTokenPolicy);
				return true;
			}
			else
			{
				return false;
			}
		}

		private void IssuerDetails(Issuer issuer)
		{
			txtConfigureACSStatus.Text += String.Format("{0}\t Id: {1}{0}\t Name: {2}{0}\t IssuerName: {3}", Environment.NewLine, issuer.Id, issuer.DisplayName, issuer.IssuerName);			
		}

		private void RuleDetails(Rule rule)
		{
			txtConfigureACSStatus.Text += String.Format("{0}\t Id: {1}{0}\t Name: {2}{0}\t InputClaimIssuerId: {3}{0}\t InputClaimType: {4}{0}\t InputClaimValue: {5}{0}\t OutputClaimType: {6}{0}\t OutputClaimValue: {7}{0}\t Type: {8}", Environment.NewLine, rule.Id, rule.DisplayName, rule.InputClaim.IssuerId, rule.InputClaim.ClaimType, rule.InputClaim.Value, rule.OutputClaim.ClaimType, rule.OutputClaim.Value, rule.RuleType);
		}

		private void ScopeDetails(Scope scope)
		{
			txtConfigureACSStatus.Text += String.Format("{0}\t Id: {1}{0}\t Name: {2}{0}\t AppliesTo: {3}{0}\t AppliesTo: {4}", Environment.NewLine, scope.Id, scope.DisplayName, scope.AppliesTo, scope.TokenPolicyId);			
		}

		private void TokenPolicyDetails(TokenPolicy tokenPolicy)
		{
			txtConfigureACSStatus.Text += String.Format("{0}\t Id: {1}{0}\t Name: {2}{0}\t Timeout in seconds: {3}{0}\t Key: {4}", Environment.NewLine, tokenPolicy.Id, tokenPolicy.DisplayName, tokenPolicy.DefaultTokenLifetimeInSeconds, tokenPolicy.SigningKey);						
		}

		public void ConfigureACS()
		{
			Uri uri = new Uri(String.Format("https://{0}.{1}/{2}", m_serviceEndpoint.SolutionNamespace + "-sb", ACS.Management.SamplesConfiguration.AcsHostUrl, ACS.Management.SamplesConfiguration.AcsManagementServicesRelativeUrl));
			
			HttpWebRequest getRequest = (HttpWebRequest)WebRequest.Create(uri);
			getRequest.Method = "GET";
			getRequest.KeepAlive = false;
			bool isACSv2 = false;
			bool isExpectedBehavior = false;
			try
			{
				txtConfigureACSStatus.Text += "Trying to find out the ACS Version. ";

				using (HttpWebResponse getResponse = (HttpWebResponse)getRequest.GetResponse())
				{
					if (getResponse.StatusCode == HttpStatusCode.OK)
					{
						isACSv2 = true;
						isExpectedBehavior = true;
					}
				}
			}
			catch (System.Net.WebException ex)
			{
				if (ex.Response != null)
				{
					System.Net.HttpWebResponse r = (System.Net.HttpWebResponse)ex.Response;
					if (r.StatusCode == HttpStatusCode.NotFound)
					{
						isACSv2 = false;
						isExpectedBehavior = true;
					}									
				}
				
				if (!isExpectedBehavior)
				{
					txtConfigureACSStatus.Text += Environment.NewLine + "WebException encountered while trying to find out ACS Version. ";
					txtConfigureACSStatus.Text += Environment.NewLine + ex.Message; 
					RefreshConfigureACSStatus();
					return;
				}
			}
			catch (Exception ex)
			{
				txtConfigureACSStatus.Text += Environment.NewLine + "Exception encountered while trying to find out ACS Version.";
				txtConfigureACSStatus.Text += Environment.NewLine + ex.Message;
				RefreshConfigureACSStatus();
				return;
			}
			txtConfigureACSStatus.Text += Environment.NewLine + "ACS Version is: " + (isACSv2? "V2": "V1") + Environment.NewLine;

			try
			{
				txtConfigureACSStatus.Text += Environment.NewLine + "Begin Configuring For Service Bus Scope" + Environment.NewLine;
				if (!isACSv2)
				{
					ConfigureResources(true);
				}
				else
				{
					ConfigureResourcesUsingManagementService(true);
				}
				txtConfigureACSStatus.Text += Environment.NewLine + "End Configuring For Service Bus Scope" + Environment.NewLine;
				if (m_serviceEndpoint.ConnectionMode == CrmServiceEndpointConnectionMode.Federated)
				{
					txtConfigureACSStatus.Text += Environment.NewLine + "Begin Configuring For Federated Mode Scope" + Environment.NewLine;
					if (!isACSv2)
					{
						ConfigureResources(false);
					}
					else
					{
						ConfigureResourcesUsingManagementService(false);
					}
					txtConfigureACSStatus.Text += Environment.NewLine + "End Configuring For Federated Mode Scope";
					RefreshConfigureACSStatus();
				}
				else
				{
					RefreshConfigureACSStatus();
				}
			}
			catch (ArgumentException ex)
			{
				txtConfigureACSStatus.Text += ex.Message;
			}
		}

		public void ConfigureResources(bool isServiceBusScope)
		{
			//NORMAL Mode
			//Create Issuer 
			//Create Scope
			//Create Send Rule for Org

			//FEDERATED Mode
			//Create Issuer
			//Create TokenPolicy
			//Create Scope
			//Create Passthrough rule for Org
			//Create OrgUrl rule for Org

			Dictionary<string, string> argsCollection = new Dictionary<string, string>();
			argsCollection.Add(Constants.OptionGeneralName, "sampleissuer");
			argsCollection.Add(Constants.OptionIssuerName, m_serviceEndpoint.AcsIssuerName);
			argsCollection.Add(Constants.OptionIssuerCert, m_serviceEndpoint.AcsPublicCertificate);
			argsCollection.Add(Constants.OptionIssuerAlgorithm, Constants.AlgorithmX509);
			string issuerId = GetOrCreateResource(isServiceBusScope, "issuer", argsCollection).Trim();
			string issuerOwnerId = String.Empty;
			if (isServiceBusScope)
			{
				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionIssuerName, "owner");
				argsCollection.Add(Constants.OptionIssuerPreviousKey, m_serviceEndpoint.AcsManagementKey);
				issuerOwnerId = GetOrCreateResource(isServiceBusScope, "issuer", argsCollection).Trim();

				if (String.IsNullOrEmpty(issuerOwnerId))
				{
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Unable to find the issuer with issuername: owner; key: {0}; previouskey:{0}; algorithm: Symmetric256BitKey. Unable to proceed with the rest of the operation.", m_serviceEndpoint.AcsManagementKey);
					return;
				}
			}

			argsCollection = new Dictionary<string, string>();

			argsCollection.Add(Constants.OptionGeneralName, "sampletokenpolicy");
			string tokenPolicyId = GetOrCreateResource(isServiceBusScope, "tokenpolicy", argsCollection).Trim();

			argsCollection = new Dictionary<string, string>();
			argsCollection.Add(Constants.OptionGeneralName, "samplescope");
			argsCollection.Add(Constants.OptionScopeTokenPolicyId, tokenPolicyId);
			argsCollection.Add(Constants.OptionScopeAppliesTo, String.Format("http://{0}.servicebus.windows.net/{1}", m_serviceEndpoint.SolutionNamespace, m_serviceEndpoint.Path));
			string scopeId = GetOrCreateResource(isServiceBusScope, "scope", argsCollection).Trim();

			if (isServiceBusScope)
			{
				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "sampleorgsendrule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, m_orgClaimType);
				argsCollection.Add(Constants.OptionRuleInputClaimValue, GetOrgClaimValue());
				argsCollection.Add(Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
				argsCollection.Add(Constants.OptionRuleOutputClaimValue, "Send");

				string ruleId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();

				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "sampleownersendrule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerOwnerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, "Issuer");
				argsCollection.Add(Constants.OptionRuleInputClaimValue, "owner");
				argsCollection.Add(Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
				argsCollection.Add(Constants.OptionRuleOutputClaimValue, "Send");

				string ruleOwnerSendId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();

				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "sampleownerlistenrule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerOwnerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, "Issuer");
				argsCollection.Add(Constants.OptionRuleInputClaimValue, "owner");
				argsCollection.Add(Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
				argsCollection.Add(Constants.OptionRuleOutputClaimValue, "Listen");

				string ruleOwnerListenId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();
				
				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "sampleownermanagerule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerOwnerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, "Issuer");
				argsCollection.Add(Constants.OptionRuleInputClaimValue, "owner");
				argsCollection.Add(Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
				argsCollection.Add(Constants.OptionRuleOutputClaimValue, "Manage");

				string ruleOwnerManageId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();
			}
			else
			{
				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "samplepassthroughrule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, m_orgClaimType);
				argsCollection.Add(Constants.OptionRuleOutputClaimType, m_orgClaimType);
				string rulePassThroughId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();
								
				argsCollection = new Dictionary<string, string>();
				argsCollection.Add(Constants.OptionGeneralName, "sampleorgurlrule");
				argsCollection.Add(Constants.OptionRuleScopeId, scopeId);
				argsCollection.Add(Constants.OptionRuleInputClaimIssuerId, issuerId);
				argsCollection.Add(Constants.OptionRuleInputClaimType, m_orgClaimType);
				argsCollection.Add(Constants.OptionRuleInputClaimValue, GetOrgClaimValue());
				argsCollection.Add(Constants.OptionRuleOutputClaimType, "http://schemas.microsoft.com/xrm/2011/Claims/OrganizationUrl");
				argsCollection.Add(Constants.OptionRuleOutputClaimValue, m_org.OrganizationServiceUrl);
				string ruleOrgUrlId = GetOrCreateResource(isServiceBusScope, "rule", argsCollection).Trim();
			}
		}

		public void ConfigureResourcesUsingManagementService(bool isServiceBusScope)
		{
			//NORMAL Mode
			//Create Service Identity
			//Create Issuer
			//Create Relying Party 
			//Create RuleGroup
			//Assign RuleGroup To RelyingParty
			//Create Send Rule for Org

			//FEDERATED Mode
			//Create Service Identity
			//Create Issuer
			//Create Relying Party 
			//Create RuleGroup
			//Assign RuleGroup To RelyingParty
			//Create Passthrough rule for Org
			//Create OrgUrl rule for Org

			txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Creating ManagementService for {0}", m_serviceEndpoint.SolutionNamespace + (isServiceBusScope? "-sb" : ""));
			RefreshConfigureACSStatus();
			ACSConfigurationWithManagementService acsMgmtService = new ACSConfigurationWithManagementService(m_serviceEndpoint, isServiceBusScope);			
			txtConfigureACSStatus.Text += Environment.NewLine + "Created ManagementService and cleared the cached token";
			RefreshConfigureACSStatus();

			try
			{				
				string ClientName = m_serviceEndpoint.AcsIssuerName;
				string RPRealm = String.Format("http://{0}.{1}/{2}", m_serviceEndpoint.SolutionNamespace, ACS.Management.SamplesConfiguration.ServiceBusHostUrl, m_serviceEndpoint.Path);
				string RPName = m_serviceEndpoint.Path;
				string RuleGroupName = String.Format("Rule group for {0}", m_serviceEndpoint.Path);

				Common.ACS.Management.ServiceIdentity serviceIdentityCRM = acsMgmtService.RetrieveServiceIdentityIfExists(ClientName);
				if (serviceIdentityCRM == null)
				{
					serviceIdentityCRM = acsMgmtService.ConfigureServiceIdentity(m_serviceEndpoint.AcsPublicCertificate, ClientName);
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Created ServiceIdentity with Name: {0}, ID: {1}", ClientName, serviceIdentityCRM.Id);
				}
				else
				{
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Found ServiceIdentity with Name: {0}, ID: {1}", ClientName, serviceIdentityCRM.Id);
				}
				RefreshConfigureACSStatus();

				Common.ACS.Management.Issuer issuerCRM = acsMgmtService.RetrieveIssuerIfExists(ClientName);
				if (issuerCRM == null)
				{
					issuerCRM = acsMgmtService.ConfigureIssuer(ClientName);
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Created Issuer with Name: {0}, ID: {1}", ClientName, issuerCRM.Id);
				}
				else
				{
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Found Issuer with Name: {0}, ID: {1}", ClientName, issuerCRM.Id);
				}
				RefreshConfigureACSStatus();

				Common.ACS.Management.RelyingParty relyingParty = acsMgmtService.RetrieveRelyingPartyIfExists(RPName);
				if (relyingParty == null)
				{
					relyingParty = acsMgmtService.ConfigureRelyingParty(RPRealm, RPName);
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Created RelyingParty with Name: {0}, RealmName: {1}, ID: {2}", RPName, RPRealm, relyingParty.Id);
				}
				else
				{
					txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Found RelyingParty with Name: {0}, ID: {1}", RPName, relyingParty.Id);
				}				
				RefreshConfigureACSStatus();


				acsMgmtService.DeleteRuleGroupByNameIfExists(RuleGroupName);
				txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Deleted RuleGroup with Name: {0} (Only if existed)", RuleGroupName);
				RefreshConfigureACSStatus();
				Common.ACS.Management.RuleGroup ruleGroup = acsMgmtService.ConfigureRuleGroup(RuleGroupName);
				txtConfigureACSStatus.Text += Environment.NewLine + String.Format("Created RuleGroup with Name: {0}", RuleGroupName);
				RefreshConfigureACSStatus();
				
				acsMgmtService.AssignRuleGroupToRelyingParty(relyingParty, ruleGroup);
				txtConfigureACSStatus.Text += Environment.NewLine + "Assigned RuleGroup to RelyingParty";
				RefreshConfigureACSStatus();

				if (isServiceBusScope)
				{
					Common.ACS.Management.Issuer localAuthority = acsMgmtService.RetrieveLocalAuthority();

					Dictionary<string, string> argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "sampleorgsendrule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, m_orgClaimType);
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, GetOrgClaimValue());
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, "Send");
					acsMgmtService.CreateRule(issuerCRM, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: sampleorgsendrule";
					RefreshConfigureACSStatus();

					argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "sampleownersendrule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, "owner");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, "Send");
					acsMgmtService.CreateRule(localAuthority, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: sampleownersendrule";
					RefreshConfigureACSStatus();

					argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "sampleownerlistenrule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, "owner");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, "Listen");
					acsMgmtService.CreateRule(localAuthority, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: sampleownerlistenrule";
					RefreshConfigureACSStatus();

					argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "sampleownermanagerule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, "owner");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, "net.windows.servicebus.action");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, "Manage");
					acsMgmtService.CreateRule(localAuthority, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: sampleownermanagerule" + Environment.NewLine;
					RefreshConfigureACSStatus();
				}
				else
				{
					Dictionary<string, string> argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "samplepassthroughrule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, m_orgClaimType);
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, null);
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, null);
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, null);
					acsMgmtService.CreateRule(issuerCRM, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: samplepassthroughrule";
					RefreshConfigureACSStatus();

					argsCollection = new Dictionary<string, string>();
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName, "sampleorgurlrule");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType, m_orgClaimType);
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue, GetOrgClaimValue());
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType, "http://schemas.microsoft.com/xrm/2011/Claims/OrganizationUrl");
					argsCollection.Add(Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue, m_org.OrganizationServiceUrl);
					acsMgmtService.CreateRule(issuerCRM, ruleGroup, argsCollection);
					txtConfigureACSStatus.Text += Environment.NewLine + "Created Rule: sampleorgurlrule" + Environment.NewLine;
					RefreshConfigureACSStatus();
				}
			}
			catch (Exception ex)
			{
				txtConfigureACSStatus.Text += Environment.NewLine + ex.ToString();				
			}			
		}

		private string GetOrgClaimValue()
		{
            //switch (m_org.OrganizationService.ServiceConfiguration.AuthenticationType)
            //{
            //    case AuthProviderType.LiveId:
            //    case AuthProviderType.OnlineFederation:
            //        string s = m_org.WebApplicationUrl;
            //        Uri uri = new Uri(s);
            //        string host = uri.Host;				
            //        return host.ToLower();					
            //    default:
            //        return m_org.OrganizationUniqueName.ToLower();				
            //}		
            throw new NotImplementedException();
		}

		private string SelectCertificateFile(string initialDirectory)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "cer files (*.cer)|*.cer";
			dialog.InitialDirectory = initialDirectory;
			dialog.Title = "Select a public certificate file";
			return (dialog.ShowDialog() == DialogResult.OK)
			   ? dialog.FileName : null;
		}

		private void btnBrowseCertificate_Click(object sender, EventArgs e)
		{
			txtPublicCertificate.Text = SelectCertificateFile(Directory.GetCurrentDirectory());
		}

		private void ACSConfigurationForm_Load(object sender, EventArgs e)
		{
			txtManagementKey.Text = m_serviceEndpoint.AcsManagementKey;
			txtPublicCertificate.Text = m_serviceEndpoint.AcsPublicCertificate;
			txtIssuerName.Text = m_serviceEndpoint.AcsIssuerName;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}		

		private void lnkDevResources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{			
			string targetUrl = String.Format("{0}/tools/systemcustomization/WsdlProgramming/wsdlProgramming.aspx", m_org.WebApplicationUrl);
			System.Diagnostics.Process.Start("IExplore", targetUrl);
			lnkDevResources.LinkColor = Color.Black;
			lnkDevResources.LinkVisited = true;
		}

		private void RefreshConfigureACSStatus()
		{			
			this.txtConfigureACSStatus.SelectionStart = txtConfigureACSStatus.Text.Length;
			this.txtConfigureACSStatus.ScrollToCaret();
			this.txtConfigureACSStatus.Refresh();
		}
		
	}
}
