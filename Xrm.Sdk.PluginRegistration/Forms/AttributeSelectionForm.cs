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
    using Microsoft.Xrm.Sdk.Metadata;
    using System;
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.Windows.Forms;
    using Wrappers;

    public delegate void UpdateImageAttributesDelegate(Collection<string> attributes, bool allAttributes);

    public partial class AttributeSelectionForm : Form
    {
        #region Private Fields

        private CrmOrganization m_org;
        private UpdateImageAttributesDelegate m_updateAttributes;

        #endregion Private Fields

        #region Public Constructors

        public AttributeSelectionForm(UpdateImageAttributesDelegate updateAttributes, CrmOrganization org,
            CrmAttribute[] attributeList, Collection<string> currentValue, bool currentAllChecked)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }
            else if (attributeList == null)
            {
                throw new ArgumentNullException("attributeList");
            }
            else if (updateAttributes == null)
            {
                throw new ArgumentNullException("updateAttributes");
            }

            InitializeComponent();

            m_org = org;
            m_updateAttributes = updateAttributes;

            //Create a sorter for the listview. This will allow the list to be sorted by different columns
            lsvAttributes.ListViewItemSorter = new ListViewColumnSorter(0, lsvAttributes.Sorting);

            foreach (CrmAttribute attribute in attributeList)
            {
                switch (attribute.Type)
                {
                    case AttributeTypeCode.Boolean:
                    case AttributeTypeCode.Customer:
                    case AttributeTypeCode.DateTime:
                    case AttributeTypeCode.Decimal:
                    case AttributeTypeCode.Double:
                    case AttributeTypeCode.Integer:
                    case AttributeTypeCode.Lookup:
                    case AttributeTypeCode.Memo:
                    case AttributeTypeCode.Money:
                    case AttributeTypeCode.Owner:
                    case AttributeTypeCode.PartyList:
                    case AttributeTypeCode.Picklist:
                    case AttributeTypeCode.State:
                    case AttributeTypeCode.Status:
                    case AttributeTypeCode.String:
                        {
                            ListViewItem item = lsvAttributes.Items.Add(attribute.LogicalName.Trim().ToLowerInvariant(), attribute.FriendlyName, 0);
                            item.SubItems.Add(attribute.LogicalName);
                            item.SubItems.Add(attribute.Type.ToString());
                            item.Tag = attribute;
                        }
                        break;

                    case AttributeTypeCode.CalendarRules:
                    case AttributeTypeCode.Uniqueidentifier:
                    case AttributeTypeCode.Virtual:

                        if (attribute.IsPrimaryId)
                        {
                            ListViewItem item = lsvAttributes.Items.Add(attribute.LogicalName.Trim().ToLowerInvariant(), attribute.FriendlyName, 0);
                            item.SubItems.Add(attribute.LogicalName);
                            item.SubItems.Add(attribute.Type.ToString());
                            item.Tag = attribute;
                        }
                        continue;
                }
            }

            if (currentAllChecked)
            {
                chkSelectAll.Checked = true;
                foreach (ListViewItem item in lsvAttributes.Items)
                {
                    item.Checked = true;
                }
            }
            else if (currentValue != null && currentValue.Count != 0)
            {
                foreach (string value in currentValue)
                {
                    if (!string.IsNullOrEmpty(value) && lsvAttributes.Items.ContainsKey(value.Trim().ToLowerInvariant()))
                    {
                        lsvAttributes.Items[value.ToLowerInvariant()].Checked = true;
                    }
                }
            }
        }

        #endregion Public Constructors

        #region Private Methods

        private void AttributeSelectionForm_Load(object sender, EventArgs e)
        {
            lsvAttributes.Sort();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var attributeList = new Collection<string>();
            if (lsvAttributes.CheckedIndices.Count == lsvAttributes.Items.Count)
            {
                m_updateAttributes(null, true);
            }
            else
            {
                foreach (ListViewItem attribute in lsvAttributes.CheckedItems)
                {
                    attributeList.Add(((CrmAttribute)attribute.Tag).LogicalName);
                }

                m_updateAttributes(attributeList, false);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void chkSelectAll_Click(object sender, EventArgs e)
        {
            bool checkVal = chkSelectAll.Checked;

            foreach (ListViewItem item in lsvAttributes.Items)
            {
                item.Checked = checkVal;
            }
        }

        private void lsvAttributes_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var lsvSorter = (ListViewColumnSorter)lsvAttributes.ListViewItemSorter;

            if (e.Column == lsvSorter.SortColumn)
            {
                if (lsvSorter.Order == SortOrder.Ascending)
                {
                    lsvSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lsvSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lsvSorter.SortColumn = e.Column;
                lsvSorter.Order = SortOrder.Ascending;
            }

            lsvAttributes.Sort();
        }

        #endregion Private Methods

        #region Private Classes

        private class ListViewColumnSorter : IComparer
        {
            #region Private Fields

            private int m_col;
            private SortOrder m_order;

            #endregion Private Fields

            #region Public Constructors

            public ListViewColumnSorter(int sortCol, SortOrder order)
            {
                m_col = sortCol;
                m_order = order;
            }

            #endregion Public Constructors

            #region Public Properties

            public SortOrder Order
            {
                get
                {
                    return m_order;
                }
                set
                {
                    m_order = value;
                }
            }

            public int SortColumn
            {
                get
                {
                    return m_col;
                }

                set
                {
                    m_col = value;
                }
            }

            #endregion Public Properties

            #region Public Methods

            public int Compare(object item1, object item2)
            {
                if (item1 == null || item2 == null || item1.GetType() != typeof(ListViewItem) || item2.GetType() != typeof(ListViewItem))
                {
                    throw new ArgumentException();
                }

                ListViewItem x = (ListViewItem)item1;
                ListViewItem y = (ListViewItem)item2;

                int compareResult;
                if (SortColumn <= 0)
                {
                    compareResult = string.Compare(x.Text, y.Text, StringComparison.CurrentCultureIgnoreCase);
                }
                else
                {
                    compareResult = string.Compare(x.SubItems[SortColumn].Text, y.SubItems[SortColumn].Text, StringComparison.CurrentCultureIgnoreCase);
                }

                switch (Order)
                {
                    case SortOrder.None:
                        return -1; //x is always less than y
                    case SortOrder.Ascending:
                        return compareResult; //string comparison is correct
                    case SortOrder.Descending:
                        return -compareResult; //Reverse of the string comparison
                    default:
                        throw new NotImplementedException("Unknown SortOrder = " + Order.ToString());
                }
            }

            #endregion Public Methods
        }

        #endregion Private Classes
    }
}