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

using System.Collections.Generic;
using System.Linq;
using System.Threading;

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

        private List<ListViewItem> m_attributesList;
        private CrmOrganization m_org;
        private UpdateImageAttributesDelegate m_updateAttributes;

        private Thread searchThread;

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

            m_attributesList = new List<ListViewItem>();

            foreach (var attribute in attributeList)
            {
                var item = new ListViewItem
                {
                    Name = attribute.LogicalName.Trim().ToLowerInvariant(),
                    Text = attribute.FriendlyName,
                    ImageIndex = 0
                };
                item.SubItems.Add(attribute.LogicalName);
                item.SubItems.Add(attribute.TypeName == "MultiSelectPicklistType" ? "MultiSelect Picklist" : attribute.Type.ToString());
                item.Tag = attribute;
                item.Checked = currentAllChecked || currentValue.Contains(item.Name);
                var addattribute = false;
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
                            addattribute = true;
                        }
                        break;

                    case AttributeTypeCode.CalendarRules:
                    case AttributeTypeCode.Uniqueidentifier:
                    case AttributeTypeCode.Virtual:
                        if (attribute.IsPrimaryId || attribute.TypeName == "MultiSelectPicklistType")
                        {
                            addattribute = true;
                        }
                        continue;
                }
                if (addattribute)
                {
                    m_attributesList.Add(item);
                }
            }
        }

        #endregion Public Constructors

        #region Private Methods

        private void AttributeSelectionForm_Load(object sender, EventArgs e)
        {
            DisplayAttributes();
            lsvAttributes.Sort();
            RefreshCurrentAndCounts();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var attributeList = new Collection<string>();

            if (lsvAttributes.CheckedIndices.Count == 0)
            {
                MessageBox.Show("You must specify at least one attribute. This is a required field", "Registration",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (lsvAttributes.CheckedIndices.Count == m_attributesList.Count)
            {
                m_updateAttributes(null, true);
            }
            else
            {
                var attributes = new Collection<string>(m_attributesList.Where(a => a.Checked).Select(a => a.Name).OrderBy(a => a).ToList());
                m_updateAttributes(attributes, false);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void linkSelectAllOrNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var checkVal = sender == linkSelectAll;
            lsvAttributes.ItemChecked -= lsvAttributes_ItemChecked;
            lsvAttributes.Items.Cast<ListViewItem>().ToList().ForEach(i => i.Checked = checkVal);
            lsvAttributes.ItemChecked += lsvAttributes_ItemChecked;
            RefreshCurrentAndCounts();
        }

        private void DisplayAttributes()
        {
            Invoke(new Action(() =>
            {
                lsvAttributes.Items.Clear();

                var items = m_attributesList.Where(i =>
                    txtFilter.Text.Length == 0
                    || i.Text.ToLower().IndexOf(txtFilter.Text.ToLower(), StringComparison.Ordinal) >= 0
                    || i.Name.ToLower().IndexOf(txtFilter.Text.ToLower(), StringComparison.Ordinal) >= 0);

                lsvAttributes.ItemChecked -= lsvAttributes_ItemChecked;
                lsvAttributes.Items.AddRange(items.ToArray());
                lsvAttributes.ItemChecked += lsvAttributes_ItemChecked;
            }));
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

        private void lsvAttributes_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            RefreshCurrentAndCounts();
        }

        private void RefreshCurrentAndCounts()
        {
            var checkCount = m_attributesList.Count(a => a.Checked);
            lblCheckCount.Text = string.Format(lblCheckCount.Tag.ToString(), checkCount == m_attributesList.Count ? "All" : checkCount.ToString());
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            searchThread?.Abort();
            searchThread = new Thread(DisplayAttributes);
            searchThread.Start();
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