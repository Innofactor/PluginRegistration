using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACS.Management;
using System.Security.Cryptography.X509Certificates;
using Common.ACS.Management;

namespace PluginRegistrationTool
{
	internal sealed class ACSConfigurationWithManagementService
	{
		private const string ACSManagementServiceIdentityName = "ManagementClient";
		private const string SBManagementServiceIdentityName = "SBManagementClient";
		private ManagementService _svc;
			
		public ACSConfigurationWithManagementService(CrmServiceEndpoint serviceEndpoint, bool isServiceBusScope)
		{
			if (null == serviceEndpoint)
			{
				throw new ArgumentNullException("serviceEndpoint");
			}

			if (isServiceBusScope)
			{				
				SamplesConfiguration.ServiceNamespace = serviceEndpoint.SolutionNamespace + "-sb";
				SamplesConfiguration.ManagementServiceIdentityName = SBManagementServiceIdentityName;								
			}
			else
			{
				SamplesConfiguration.ServiceNamespace = serviceEndpoint.SolutionNamespace;
				SamplesConfiguration.ManagementServiceIdentityName = ACSManagementServiceIdentityName;				
			}

			SamplesConfiguration.ManagementServiceIdentityKey = serviceEndpoint.AcsManagementKey;
			ManagementServiceHelper.ClearCachedSwtToken();
			_svc = ManagementServiceHelper.CreateManagementServiceClient();
		}		

		public void AssignRuleGroupToRelyingParty(RelyingParty relyingParty, RuleGroup ruleGroup)
		{
			if (null == relyingParty)
			{
				throw new ArgumentNullException("relyingParty");
			}

			if (null == ruleGroup)
			{
				throw new ArgumentNullException("ruleGroup");
			}

			_svc.AssignRuleGroupToRelyingParty(ruleGroup, relyingParty);
			_svc.SaveChangesBatch();
		}

		/// <summary>
		/// Retrieves the ServiceIdentity which matches the given name		
		/// <param name="name">name</param>
		/// <returns>ServiceIdentity</returns>
		/// </summary>
		public ServiceIdentity RetrieveServiceIdentityIfExists(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			return _svc.GetServiceIdentityByName(name);			
		}

		/// <summary>
		/// Retrieves the Issuer which matches the given name		
		/// <param name="name">name</param>
		/// <returns>Issuer</returns>
		/// </summary>
		public Issuer RetrieveIssuerIfExists(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			return _svc.GetIssuerByName(name);
		}

		/// <summary>
		/// Retrieves the RelyingParty which matches the given name		
		/// <param name="name">name</param>
		/// <returns>RelyingParty</returns>
		/// </summary>
		public RelyingParty RetrieveRelyingPartyIfExists(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			return _svc.GetRelyingPartyByName(name);
		}

		/// <summary>
		/// Creates a RuleGroup with the given name		
		/// <param name="name">name</param>
		/// <returns>RuleGroup</returns>
		/// </summary>
		public RuleGroup ConfigureRuleGroup(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			RuleGroup ruleGroup = _svc.CreateRuleGroup(name);
			_svc.SaveChangesBatch();
			return ruleGroup;
		}

		/// <summary>
		/// Retrieves the Issuer with name "LOCAL AUTHORITY"		
		/// <returns>Issuer</returns>
		/// </summary>
		public Issuer RetrieveLocalAuthority()
		{
			Issuer localAuthority = _svc.GetIssuerByName("LOCAL AUTHORITY");
			_svc.SaveChangesBatch();
			return localAuthority;
		}

		/// <summary>
		/// Creates a RelyingParty with the given name and realm	
		/// <param name="name">name</param>
		/// <param name="realm">realm</param>
		/// <returns>RuleGroup</returns>
		/// </summary>
		public RelyingParty ConfigureRelyingParty(string realm, string name)
		{
			if (String.IsNullOrEmpty(realm))
			{
				throw new ArgumentNullException("realm");
			}

			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			RelyingParty relyingParty = _svc.CreateRelyingParty(name, realm, null, RelyingPartyTokenType.SWT, false);
			_svc.SaveChangesBatch();
			return relyingParty;
		}

		/// <summary>
		/// Creates a ServiceIdentity with the specified name and certificate
		/// <param name="name">acsPublicCertificate</param>
		/// <param name="name">name</param>
		/// <returns>ServiceIdentity</returns>
		/// </summary>
		public ServiceIdentity ConfigureServiceIdentity(string acsPublicCertificate, string name)
		{
			if (String.IsNullOrEmpty(acsPublicCertificate))
			{
				throw new ArgumentNullException("acsPublicCertificate");
			}

			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			X509Certificate2 clientCertificate = new X509Certificate2(acsPublicCertificate);
			ServiceIdentity serviceIdentityCRM = _svc.CreateServiceIdentity(name, clientCertificate.RawData, ServiceIdentityKeyType.X509Certificate, ServiceIdentityKeyUsage.Signing);
			_svc.SaveChangesBatch();
			return serviceIdentityCRM;	
		}

		/// <summary>
		/// Creates an issuer with the specified name
		/// <param name="ClientName">name</param>
		/// <returns>Issuer</returns>
		/// </summary>
		public Issuer ConfigureIssuer(string name)
		{
			if (String.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException("name");
			}

			Issuer issuerCRM = new Issuer() { Name = name };
			_svc.AddToIssuers(issuerCRM);
			_svc.SaveChangesBatch();
			return issuerCRM;					
		}
		
		/// <summary>
		/// Creates a rule within the specified rulegroup using given values
		/// <param name="issuer">issuer</param>
		/// <param name="ruleGroup">ruleGroup</param>
		/// <param name="argsCollection">values required for the rule like name, inputclaimtype, inputclaimvalue, outputclaimtype, outputclaimvalue</param>
		/// <returns>Rule</returns>
		/// </summary>
		public Rule CreateRule(Issuer issuer, RuleGroup ruleGroup, Dictionary<string, string> argsCollection)
		{
			if (null == issuer)
			{
				throw new ArgumentNullException("issuer");
			}

			if (null == ruleGroup)
			{
				throw new ArgumentNullException("ruleGroup");
			}

			if (null == argsCollection)
			{
				throw new ArgumentNullException("argsCollection");
			}

			Rule rule = _svc.CreateRule(issuer, argsCollection[Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimType], argsCollection[Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleInputClaimValue], argsCollection[Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimType], argsCollection[Microsoft.AccessControl.Samples.AcmTool.Constants.OptionRuleOutputClaimValue], ruleGroup, argsCollection[Microsoft.AccessControl.Samples.AcmTool.Constants.OptionGeneralName]);
			_svc.SaveChangesBatch();
			return rule;
		}

		/// <summary>
		/// Deletes the rulegroup if matches the given name name
		/// <param name="RuleGroupName">name of the rulegroup to be matched against</param>
		/// </summary>
		public void DeleteRuleGroupByNameIfExists(string RuleGroupName)
		{
			if (String.IsNullOrEmpty(RuleGroupName))
			{
				throw new ArgumentNullException("RuleGroupName");
			}
			_svc.DeleteRuleGroupByNameIfExists(RuleGroupName);
			_svc.SaveChangesBatch();
		}		
	}
}
