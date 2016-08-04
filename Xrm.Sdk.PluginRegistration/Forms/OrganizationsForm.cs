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

namespace Xrm.Sdk.PluginRegistration.Forms
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Xrm.Sdk.PluginRegistration.Wrappers;

    public partial class OrganizationsForm : Form
    {
        private Dictionary<Guid?, Dictionary<Guid, MainControl>> m_orgList;

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

        public bool OrganizationHasTab(Guid? connectionId, Guid organizationId)
        {
            Dictionary<Guid, MainControl> organizationControlMap;
            if (m_orgList.TryGetValue(connectionId, out organizationControlMap))
            {
                MainControl control;
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
            TabPage page = GetTab(connectionId, organizationId);

            {
                tabOrganizations.TabPages.Remove(page);
                m_orgList[connectionId][organizationId].Organization.Connected = false;
                m_orgList[connectionId].Remove(organizationId);

                if (m_orgList[connectionId].Count == 0)
                {
                    m_orgList.Remove(connectionId);
                }

                if (m_orgList.Count == 0)
                {
                    Hide();
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
            foreach (Dictionary<Guid, MainControl> connectionList in m_orgList.Values)
            {
                foreach (MainControl control in connectionList.Values)
                {
                    control.UpdateAutoExpand(newValue);
                }
            }
        }
        #endregion

        #region Private Helper Methods
        private TabPage GetTab(Guid? connectionId, Guid organizationId)
        {
            if (!OrganizationHasTab(connectionId, organizationId))
            {
                throw new ArgumentException("Invalid organization id");
            }

            return (TabPage)m_orgList[connectionId][organizationId].Parent;
        }
        #endregion
    }
}
