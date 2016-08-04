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
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using Xrm.Sdk.PluginRegistration.Controls;
    using Xrm.Sdk.PluginRegistration.Wrappers;

    public partial class SearchForm : Form
    {
        private CrmOrganization m_org;
        private MainControl m_orgControl;
        private ICrmTreeNode[] m_rootNodes;
        private bool m_needReload = false;

        public SearchForm(CrmOrganization org, MainControl orgControl,
            ICrmTreeNode[] rootNodes, ICrmTreeNode selectedNode)
        {
            if (rootNodes == null)
            {
                throw new ArgumentNullException("rootNodes");
            }
            else if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (orgControl == null)
            {
                throw new ArgumentNullException("orgControl");
            }

            InitializeComponent();

            m_org = org;
            m_orgControl = orgControl;
            m_rootNodes = rootNodes;

            trvPlugins.AutoExpand = m_orgControl.IsAutoExpanded;
            trvPlugins.LoadNodes(rootNodes);
            trvPlugins.SelectedNode = selectedNode;
            btnSelect.Enabled = (trvPlugins.SelectedNode != null);

            txtSearch.AutoCompleteCustomSource = trvPlugins.NodeAutoCompleteCollection;
        }

        private void trvPlugins_SelectionChanged(object sender, CrmTreeNodeTreeEventArgs e)
        {
            btnSelect.Enabled = (e.Node != null);
        }

        private void trvPlugins_Leave(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }

        private void trvPlugins_Enter(object sender, EventArgs e)
        {
            AcceptButton = btnSelect;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (m_needReload)
            {
                trvPlugins.LoadNodes(m_rootNodes);
            }

            trvPlugins.SearchAndRemove(txtSearch.Text);
            trvPlugins.Expand();
            trvPlugins.Focus();

            m_needReload = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            m_orgControl.SelectNode(trvPlugins.SelectedNode.NodeId);
            Close();
        }
    }
}
