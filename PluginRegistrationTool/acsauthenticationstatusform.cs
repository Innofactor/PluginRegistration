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
using System.Windows.Forms;
using Microsoft.Xrm.Sdk;
using CrmSdk;
using Microsoft.Xrm.Sdk.Query;
using System.Threading;
using Microsoft.Crm.Sdk.Messages;

namespace PluginRegistrationTool
{
	public partial class ACSAuthenticationStatusForm : Form
	{
		private CrmOrganization m_org;
		private Guid m_serviceEndpointId;
		private Guid m_asyncOperationId = Guid.Empty;
		private QueryExpression m_asyncQuery;
		private int m_timerTickCount = 0;

		private void AuthenticationStatus_Load(object sender, EventArgs e)
		{
			VerifyAuthentication();
		}

		public ACSAuthenticationStatusForm(Guid serviceEndpointId, CrmOrganization org)
		{
			if (serviceEndpointId == Guid.Empty)
			{
				throw new ArgumentException("serviceEndpointId", "serviceEndpointId cannot be an empty Guid");
			}

			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			InitializeComponent();
			this.m_org = org;
			m_serviceEndpointId = serviceEndpointId;
		}

		private void VerifyAuthentication()
		{
			progressBarAuthentication.Minimum = 0;
			progressBarAuthentication.Maximum = 100;

			Guid asyncTrackingGuid = Guid.NewGuid();
			TriggerServiceEndpointCheckRequest request = new TriggerServiceEndpointCheckRequest();
			request.RequestId = asyncTrackingGuid;
			request.Entity = new EntityReference(ServiceEndpoint.EntityLogicalName, m_serviceEndpointId);		
			m_org.OrganizationService.Execute(request);

			progressBarAuthentication.Value = 10;

			ConditionExpression condition = new ConditionExpression("requestid", ConditionOperator.Equal, asyncTrackingGuid);				
					
			m_asyncQuery = new QueryExpression(AsyncOperation.EntityLogicalName);
			m_asyncQuery.ColumnSet = new ColumnSet("asyncoperationid", "statecode", "statuscode", "requestid", "message", "friendlymessage");
			m_asyncQuery.Criteria = new FilterExpression();
			m_asyncQuery.Criteria.AddCondition(condition);
		}		
				
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void timerSystemJobCheck_Tick(object sender, EventArgs e)
		{			
			m_timerTickCount++;
			timerSystemJobCheck.Stop();
			if (m_timerTickCount < 60)
			{
				bool startTimer = CheckSystemJobStatus(false);
				if (startTimer)
				{
					timerSystemJobCheck.Start();
				}
				else
				{
					progressBarAuthentication.Value = 100;	
				}
			}
			else
			{
				CheckSystemJobStatus(true);
				progressBarAuthentication.Value = 100;									
			}				
		}

		private bool CheckSystemJobStatus(bool isLastTry)
		{
			bool startTimer = true;
			bool success = false;
			AsyncOperation entity = null;
			AsyncOperationState finalState = AsyncOperationState.Ready;

			if (progressBarAuthentication.Value < 90)
			{
				progressBarAuthentication.Increment(3);
			}
			try
			{
				EntityCollection asyncOperation = m_org.OrganizationService.RetrieveMultiple(m_asyncQuery);

				if (asyncOperation.Entities.Count == 1)
				{
					entity = (AsyncOperation)asyncOperation.Entities[0];
					m_asyncOperationId = entity.AsyncOperationId.Value;
					finalState = entity.StateCode.Value;
					lblVerificationStatus.Text = "Verifying Authentication: " + entity.StateCode.Value.ToString();

					if (entity.StateCode.Value == AsyncOperationState.Completed)
					{
						if (entity.StatusCode.Value == (int)AsyncOperationStatusCode.Succeeded) 
						{
							success = true;
							lblVerificationStatus.Text = "Verifying Authentication: Success";
						}
						startTimer = false;						
					}					
					//These are final status codes where we want to exit 
					else if ((entity.StatusCode.Value == (int) AsyncOperationStatusCode.Succeeded)
						|| (entity.StatusCode.Value == (int) AsyncOperationStatusCode.Canceled)
						|| (entity.StatusCode.Value == (int) AsyncOperationStatusCode.Waiting)
						|| (entity.StatusCode.Value == (int) AsyncOperationStatusCode.Failed))					
					{
						startTimer = false;						
					}
				}				

				if (!success && (isLastTry || !startTimer))
				{
					lblVerificationStatus.Text = "Verifying Authentication: Failed";
					if (String.IsNullOrEmpty(entity.Message))
					{
						txtSystemJobMessage.Text = String.Format("The system job failed to complete in the allotted time. Current status is: {0}", ((AsyncOperationStatusCode) entity.StatusCode.Value).ToString());
					}
					else
					{
						txtSystemJobMessage.Text = entity.FriendlyMessage + Environment.NewLine + Environment.NewLine + "Details:" + Environment.NewLine + entity.Message;
					}

					// Clean up.
					if (m_asyncOperationId != Guid.Empty && finalState == AsyncOperationState.Ready)
					{
						if (((OptionSetValue)entity["statecode"]).Value != 3)
						{							
							// Cancel the transaction and exit.				
							AsyncOperation updateEntity = new AsyncOperation();
							updateEntity.AsyncOperationId = new Guid?(m_asyncOperationId);
							updateEntity["statecode"] = new OptionSetValue(3);							
							m_org.OrganizationService.Update(updateEntity);
						}
					}
				}				
			}

			catch (Exception ex)
			{				
				startTimer = false;
				ErrorMessage.ShowErrorMessageBox(this, "Error occurred while querying the system job", "Error", ex);
			}
			return startTimer;
		}

		internal enum AsyncOperationStatusCode : int
		{	
			Canceled = 32,
			Canceling = 22,
			Failed = 31,
			InProgress = 20,
			Pausing = 21,
			Succeeded = 30,
			Waiting = 10,
			WaitingForResources = 0
		}
	}	
}
