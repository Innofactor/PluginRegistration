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

namespace PluginRegistrationTool.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using PluginRegistrationTool.SDK;

	public partial class OrganizationsForm : Form
	{
		private Dictionary<Guid?, Dictionary<Guid, OrganizationControl>> m_orgList;
        //private MainForm m_mainForm;

        //public OrganizationsForm(MainForm mainForm)
        //{
        //    InitializeComponent();

        //    this.m_orgList = new Dictionary<Guid?, Dictionary<Guid, OrganizationControl>>();
        //    this.m_mainForm = mainForm;
        //}

		private void lblClose_Click(object sender, EventArgs e)
		{
			if (tabOrganizations.SelectedTab != null)
			{
				CrmOrganization org = ((CrmOrganization)tabOrganizations.SelectedTab.Tag);
				CloseOrganizationTab(org.ConnectionDetail.ConnectionId, org.OrganizationId);
			}
		}

		private void tabOrganizations_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabOrganizations.SelectedTab != null)
			{
				// this.m_mainForm.UpdateCurrentOrganization((CrmOrganization)tabOrganizations.SelectedTab.Tag);
			}
		}

		#region Public Methods
        //public void CreateOrganizationTab(CrmOrganization org)
        //{
        //    if (org == null)
        //    {
        //        throw new ArgumentNullException("org");
        //    }
        //    else if (org.ConnectionDetail == null)
        //    {
        //        throw new ArgumentNullException("org.ConnectionDetail");
        //    }

        //    TabPage page;
        //    if (this.m_orgList.ContainsKey(org.ConnectionDetail.ConnectionId) &&
        //        this.m_orgList[org.ConnectionDetail.ConnectionId].ContainsKey(org.OrganizationId))
        //    {
        //        page = this.GetTab(org.ConnectionDetail.ConnectionId, org.OrganizationId);
        //    }
        //    else
        //    {
        //        page = new TabPage(string.Format("{0}: {1}", org.ConnectionDetail.ConnectionName, org.OrganizationFriendlyName));
        //        page.Tag = org;
        //        tabOrganizations.TabPages.Add(page);

        //        OrganizationControl orgControl = new OrganizationControl(org, this.m_mainForm);
        //        orgControl.Dock = DockStyle.Fill;
        //        orgControl.Location = new Point(0, 0);

        //        page.Controls.Add(orgControl);

        //        if (this.m_orgList.ContainsKey(org.ConnectionDetail.ConnectionId))
        //        {
        //            this.m_orgList[org.ConnectionDetail.ConnectionId].Add(org.OrganizationId, orgControl);
        //        }
        //        else
        //        {
        //            Dictionary<Guid, OrganizationControl> orgList = new Dictionary<Guid, OrganizationControl>();
        //            orgList.Add(org.OrganizationId, orgControl);

        //            this.m_orgList.Add(org.ConnectionDetail.ConnectionId, orgList);
        //        }
        //    }

        //    tabOrganizations.SelectedTab = page;

        //    if (!this.Visible)
        //    {
        //        this.Show();
        //    }

        //    this.m_mainForm.UpdateCurrentOrganization(org);
        //}

		public bool OrganizationHasTab(Guid? connectionId, Guid organizationId)
		{
			Dictionary<Guid, OrganizationControl> organizationControlMap;
			if (this.m_orgList.TryGetValue(connectionId, out organizationControlMap))
			{
				OrganizationControl control;
				if (organizationControlMap.TryGetValue(organizationId, out control))
				{
					//This will happen if the form was closed
					if (null == control.Parent)
					{
						organizationControlMap.Remove(organizationId);
						return false;
					}

					return true;
				}
			}

			return false;
		}

		public void SelectOrganizationTab(Guid? connectionId, Guid organizationId)
		{
			tabOrganizations.SelectedTab = GetTab(connectionId, organizationId);
		}

		public void CloseOrganizationTab(Guid? connectionId, Guid organizationId)
		{
			TabPage page = this.GetTab(connectionId, organizationId);

			{
				tabOrganizations.TabPages.Remove(page);
				this.m_orgList[connectionId][organizationId].Organization.Connected = false;
				this.m_orgList[connectionId].Remove(organizationId);

				if (this.m_orgList[connectionId].Count == 0)
				{
					this.m_orgList.Remove(connectionId);
				}

				if (this.m_orgList.Count == 0)
				{
					this.Hide();
					// this.m_mainForm.UpdateCurrentOrganization(null);
				}
				else if (tabOrganizations.SelectedTab == null)
				{
					tabOrganizations.SelectedTab = tabOrganizations.TabPages[0];
				}
				else
				{
					// this.m_mainForm.UpdateCurrentOrganization((CrmOrganization)tabOrganizations.SelectedTab.Tag);
				}
			}
		}

		public void UpdateAutoExpand(bool newValue)
		{
			foreach (Dictionary<Guid, OrganizationControl> connectionList in this.m_orgList.Values)
			{
				foreach (OrganizationControl control in connectionList.Values)
				{
					control.UpdateAutoExpand(newValue);
				}
			}
		}
		#endregion

		#region Private Helper Methods
		private TabPage GetTab(Guid? connectionId, Guid organizationId)
		{
			if (!this.OrganizationHasTab(connectionId, organizationId))
			{
				throw new ArgumentException("Invalid organization id");
			}

			return (TabPage)this.m_orgList[connectionId][organizationId].Parent;
		}
		#endregion
	}
}
