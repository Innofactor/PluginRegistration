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
using System.IO;
using System.ServiceModel.Security;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PluginRegistrationTool
{
	public partial class ConnectionsForm : Form
	{
		private const string DiscoveryService2011Path = "/XRMServices/2011/Discovery.svc";
		private Dictionary<Guid, CrmConnection> m_connections;
		private OrganizationsForm m_orgsForm;
		private string m_connectionFile;
		private MainForm m_mainForm;

		public ConnectionsForm(string connectionsFile, MainForm mainForm)
		{
			if (string.IsNullOrEmpty(connectionsFile))
			{
				throw new ArgumentNullException("connectionsFile");
			}
			else if (mainForm == null)
			{
				throw new ArgumentNullException("mainForm");
			}

			InitializeComponent();

			this.m_connections = new Dictionary<Guid, CrmConnection>();
			this.m_connectionFile = connectionsFile;
			this.m_orgsForm = null;
			this.m_mainForm = mainForm;

			//Load the connections file
			LoadConnectionsFile();

			//Convert the connection dictionary to an array of nodes
			CrmConnection[] connections = new CrmConnection[this.m_connections.Count];
			this.m_connections.Values.CopyTo(connections, 0);

			//Load the nodes in the tree
			trvConnections.LoadNodes(connections);
		}

		#region Events
		private void ConnectionsForm_Load(object sender, EventArgs e)
		{
			this.ResizeConnectionTree();
		}

		private void ConnectionsForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm parentForm = this.MdiParent as MainForm;

			if (parentForm != null && e.CloseReason == CloseReason.UserClosing)
			{
				parentForm.ConnectionsFormVisible = false;
				e.Cancel = true;
			}
		}

		private void trvConnections_DoubleClick(object sender, CrmTreeNodeEventArgs e)
		{
			if (e.Node != null && trvConnections.SelectedNode == e.Node)
			{
				btnConnect_Click(sender, e);
			}
		}

		private ICrmTreeNode m_editingItem = null;
		private void trvConnections_SelectionChanged(object sender, CrmTreeNodeTreeEventArgs e)
		{
			//Check if the currently selected item has been re-selected
			if (e.Node == this.m_editingItem)
			{
				return;
			}

			//Save the changes
			if (this.m_editingItem != null && this.SaveChanges(false, true, false) == null)
			{
				return;
			}

			//Populate using the currently selected node
			switch (e.Node.NodeType)
			{
				case CrmTreeNodeType.Connection:
					this.PopulateConnectionInformation((CrmConnection)e.Node);
					break;
				case CrmTreeNodeType.Organization:
					this.PopulateOrganizationInformation((CrmOrganization)e.Node);
					break;
				default:
					throw new NotImplementedException("NodeType = " + e.Node.NodeType.ToString());
			}
		}

		private void btnSaveConnection_Click(object sender, EventArgs e)
		{
			if (CompareConnectionInformation())
			{
				if (!SaveConnectionInformation())
				{
					return;
				}
			}

			ClearConnectionInformation();
			trvConnections.SelectedNode = null;
		}

		private void btnCancelConnection_Click(object sender, EventArgs e)
		{
			if (!CompareConnectionInformation() ||
				MessageBox.Show("Are you sure you want to cancel your changes?",
					"Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ClearConnectionInformation();
				trvConnections.SelectedNode = null;
			}
		}

		private void btnSaveOrganization_Click(object sender, EventArgs e)
		{
			if (CompareOrganizationInformation())
			{
				if (!SaveOrganizationInformation())
				{
					return;
				}
			}

			ClearOrganizationInformation();
			trvConnections.SelectedNode = null;
		}

		private void btnCancelOrganization_Click(object sender, EventArgs e)
		{
			if (!CompareOrganizationInformation() ||
				MessageBox.Show("Are you sure you want to cancel your changes?",
					"Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				ClearOrganizationInformation();
				trvConnections.SelectedNode = null;
			}
		}

		private void OrganizationText_TextChanged(object sender, EventArgs e)
		{
			btnSaveOrganization.Enabled = (!string.IsNullOrEmpty(txtCrmServiceUrl.Text) &&
				txtCrmServiceUrl.Text.Trim().Length != 0);
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			Guid? nodeId = this.SaveChanges(true, true, true);
			if (nodeId == null || nodeId == Guid.Empty)
			{
				return;
			}
			else
			{
				this.OpenConnection(trvConnections[(Guid)nodeId]);
			}
		}

		private void trvConnections_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete && null != trvConnections.SelectedNode)
			{
				this.RemoveConnection();
			}
		}

		private void chkUseSavedCredentials_CheckedChanged(object sender, EventArgs e)
		{
			bool enableControls = !chkUseSavedCredentials.Checked;

			lblUserName.Enabled = enableControls;
			txtUserName.Enabled = enableControls;
		}
		#endregion

		#region Properties
		private MainForm MainForm
		{
			get
			{
				return this.m_mainForm;
			}
		}

		public OrganizationsForm OrganizationsForm
		{
			get
			{
				return this.m_orgsForm;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}

				this.m_orgsForm = value;
			}
		}

		public CrmConnection[] Connections
		{
			get
			{
				CrmConnection[] list = new CrmConnection[this.m_connections.Count];
				this.m_connections.Values.CopyTo(list, 0);

				return list;
			}
		}

		public CrmConnection this[Guid key]
		{
			get
			{
				return this.m_connections[key];
			}
		}
		#endregion

		#region Helper Methods
		private bool RetrievePassword(CrmConnection con)
		{
			using (UserCredentialsDialog dialog = new UserCredentialsDialog(con.ConnectionId))
			{
				dialog.Caption = "Connect to CRM Web Service";
				dialog.Message = "Enter your credentials:";
				dialog.Domain = con.UserDomain;
				dialog.User = con.UserName;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					con.UserDomain = dialog.Domain;
					con.UserName = dialog.User;
					con.UserPassword = dialog.Password;
					con.UseSavedCredentials = false;
					if (dialog.IsSaveChecked)
					{
						dialog.ConfirmCredentials(true);
					}

					//Update the user name text box
					if (null != this.m_editingItem && con.NodeId == this.m_editingItem.NodeId)
					{
						txtUserName.Text = this.FormatUserName(con);
						chkUseSavedCredentials.Checked = con.UseSavedCredentials;
					}

					//Save the connections file
					this.SaveConnectionsFile();

					return true;
				}
				else
				{
					return false;
				}
			}
		}

		private string FormatUserName(CrmConnection con)
		{
			//Determine the format of the string
			string format;
			if (string.IsNullOrEmpty(con.UserDomain))
			{
				format = "{1}";
			}
			else
			{
				format = "{0}\\{1}";
			}

			return string.Format(System.Globalization.CultureInfo.InvariantCulture, format, con.UserDomain, con.UserName);
		}

		/// <summary>
		/// Checks if there are changes. If there are, the users is asked if they want to save them.
		/// </summary>
		/// <param name="saveIfNewItem">Save the changes automatically if it is a new item</param>
		/// <param name="queryUser">Ask the user whether they want to save changes</param>
		/// <param name="deselectNode">Deselects the currently selected node</param>
		/// <returns>Guid of Item if execution can continue because the item was saved or no changes occurred</returns>
		private Guid? SaveChanges(bool saveIfNewItem, bool queryUser, bool deselectNode)
		{
			bool newItem, itemChanged, saveChanges;

			//Check if the node has been set
			if (this.m_editingItem == null)
			{
				return null;
			}
			else
			{
				switch (this.m_editingItem.NodeType)
				{
					case CrmTreeNodeType.Connection:
						itemChanged = this.CompareConnectionInformation();
						newItem = (((CrmConnection)this.m_editingItem).ConnectionId == Guid.Empty);
						break;
					case CrmTreeNodeType.Organization:
						itemChanged = this.CompareOrganizationInformation();
						newItem = false; //Cannot create new organizations from this tool
						break;
					default:
						throw new NotImplementedException("NodeType = " + this.m_editingItem.NodeType.ToString());
				}
			}

			if (itemChanged)
			{
				if (newItem && saveIfNewItem)
				{
					saveChanges = true;
				}
				else if (queryUser)
				{
					switch (MessageBox.Show("Would you like to save your changes?", "Save Changes",
						MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
					{
						case DialogResult.Yes:
							saveChanges = true;
							break;
						case DialogResult.No:
							saveChanges = false;
							break;
						case DialogResult.Cancel:
							if (this.m_editingItem == null || this.m_editingItem.NodeId == Guid.Empty)
							{
								trvConnections.SelectedNode = null;
							}
							else
							{
								trvConnections.SelectedNode = this.m_editingItem;
							}
							return null;
						default:
							throw new NotSupportedException();
					}
				}
				else
				{
					saveChanges = true;
				}
			}
			else
			{
				saveChanges = false;
			}

			//Save and clear changes
			Guid editingNodeId;
			switch (this.m_editingItem.NodeType)
			{
				case CrmTreeNodeType.Connection:
					if (saveChanges && !this.SaveConnectionInformation())
					{
						return null;
					}
					editingNodeId = this.m_editingItem.NodeId;

					this.ClearConnectionInformation();
					break;
				case CrmTreeNodeType.Organization:
					if (saveChanges && !this.SaveOrganizationInformation())
					{
						return null;
					}
					editingNodeId = this.m_editingItem.NodeId;

					this.ClearOrganizationInformation();
					break;
				default:
					throw new NotImplementedException("NodeType = " + this.m_editingItem.NodeType.ToString());
			}

			//Check if the currently selected item should be deselected
			if (deselectNode)
			{
				trvConnections.SelectedNode = null;
			}

			return editingNodeId;
		}

		#region Methods for Connection
		private void PopulateConnectionInformation(CrmConnection con)
		{
			grpConnectionInformation.Visible = true;
			this.ResizeConnectionTree();

			//Check if this is a new connection
			if (null == con)
			{
				txtLabel.Text = "New Connection";
				txtDiscoveryUrl.Text = "http://";
				txtUserName.Text = string.Empty;

				con = new CrmConnection();
			}
			else
			{
				//Check if the discovery service URL has the XRM Services path
				string rootPath;
				if (string.IsNullOrEmpty(con.DiscoveryServiceUrl) ||
					!con.DiscoveryServiceUrl.EndsWith(DiscoveryService2011Path, StringComparison.OrdinalIgnoreCase))
				{
					rootPath = con.DiscoveryServiceUrl;
				}
				else
				{
					rootPath = con.DiscoveryServiceUrl.Substring(0, con.DiscoveryServiceUrl.Length - DiscoveryService2011Path.Length);
				}

				txtLabel.Text = con.Label;
				txtDiscoveryUrl.Text = rootPath;
				chkUseSavedCredentials.Checked = con.UseSavedCredentials;
				txtUserName.Text = this.FormatUserName(con);
			}

			this.m_editingItem = con;
			this.AcceptButton = btnConnectConnection;
			this.CancelButton = btnCancelConnection;
		}

		private bool CompareConnectionInformation()
		{
			if (this.m_editingItem == null)
			{
				return false;
			}
			else if (typeof(CrmConnection) != this.m_editingItem.GetType())
			{
				if (typeof(CrmOrganization) == this.m_editingItem.GetType())
				{
					return this.CompareOrganizationInformation();
				}
			}

			CrmConnection editingCon = (CrmConnection)this.m_editingItem;
			if (editingCon.ConnectionId == Guid.Empty)
			{
				return true;
			}

			CrmConnection changedCon = new CrmConnection();
			this.RetrieveConnectionFormValues(changedCon);

			if (editingCon.Label != changedCon.Label ||
				editingCon.DiscoveryServiceUrl != changedCon.DiscoveryServiceUrl ||
				editingCon.UserDomain != changedCon.UserDomain ||
				editingCon.UserName != changedCon.UserName ||
				editingCon.UseSavedCredentials != changedCon.UseSavedCredentials)
			{
				return true;
			}

			return false;
		}

		private bool SaveConnectionInformation()
		{
			if (this.m_editingItem == null)
			{
				return false;
			}

			//Validate the input values
			if (string.IsNullOrWhiteSpace(txtLabel.Text))
			{
				MessageBox.Show(this, "You must specify a label for this connection", "Connection",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			else if (string.IsNullOrWhiteSpace(txtDiscoveryUrl.Text) ||
				string.Equals("http://", txtDiscoveryUrl.Text, StringComparison.OrdinalIgnoreCase) ||
				string.Equals("https://", txtDiscoveryUrl.Text, StringComparison.OrdinalIgnoreCase))
			{
				MessageBox.Show(this, "The discovery service URL has not been specified", "Connection",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			//Attempt to create a URI from the URL
			try
			{
				new Uri(txtDiscoveryUrl.Text);
			}
			catch (UriFormatException)
			{
				MessageBox.Show(this, "The discovery service URL is not valid", "Connection",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			CrmConnection con = (CrmConnection)this.m_editingItem;

			List<Guid> organizationsWithTabs = new List<Guid>();
			foreach (CrmOrganization org in con.Organizations)
			{
				if (this.OrganizationsForm.OrganizationHasTab(con.ConnectionId, org.OrganizationId))
				{
					organizationsWithTabs.Add(org.OrganizationId);
				}
			}

			if (organizationsWithTabs.Count == 0 ||
				MessageBox.Show("This will close any open organization windows. Continue?",
					"Close Windows", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				if (organizationsWithTabs.Count != 0)
				{
					foreach (Guid orgId in organizationsWithTabs)
					{
						this.OrganizationsForm.CloseOrganizationTab(con.ConnectionId, orgId);
					}
				}
			}
			else
			{
				return false;
			}

			if (con.ConnectionId == Guid.Empty) //Adding New Connection
			{
				con.ConnectionId = Guid.NewGuid();
				this.m_connections.Add(con.ConnectionId, con);
				trvConnections.AddNode(Guid.Empty, con);
			}
			else
			{
				con.ClearOrganizations();
			}

			//Populate the connection object
			this.RetrieveConnectionFormValues(con);

			//Refresh the node
			trvConnections.RefreshNode(con.ConnectionId, true);

			//Save the connections
			SaveConnectionsFile();

			return true;
		}

		private void ClearConnectionInformation()
		{
			this.m_editingItem = null;

			txtLabel.Clear();
			txtDiscoveryUrl.Clear();
			txtUserName.Clear();
			chkUseSavedCredentials.Checked = false;

			this.AcceptButton = null;
			this.CancelButton = null;
			grpConnectionInformation.Visible = false;
			this.ResizeConnectionTree();
		}

		private void RetrieveConnectionFormValues(CrmConnection connection)
		{
			if (null == connection)
			{
				throw new ArgumentNullException("connection");
			}

			//Check if the discovery service URL has the XRM Services path
			string discoveryUrl;
			if (string.IsNullOrEmpty(txtDiscoveryUrl.Text) ||
				txtDiscoveryUrl.Text.EndsWith(DiscoveryService2011Path, StringComparison.OrdinalIgnoreCase))
			{
				discoveryUrl = txtDiscoveryUrl.Text;
			}
			else
			{
				discoveryUrl = txtDiscoveryUrl.Text + DiscoveryService2011Path;
			}

			//Set the values
			connection.Label = txtLabel.Text;
			connection.DiscoveryServiceUrl = discoveryUrl;

			//Retrieve the user information
			string userDomain = connection.UserDomain;
			string userName = connection.UserName;

			//Check if the user name has been specified
			if (chkUseSavedCredentials.Checked)
			{
				connection.UserDomain = null;
				connection.UserName = null;
				connection.UseSavedCredentials = true;
			}
			else
			{
				if (!string.IsNullOrEmpty(txtUserName.Text))
				{
					//Split the user name
					string[] userNameParts = (txtUserName.Text ?? string.Empty).Split(new char[] { '\\' }, 2);
					if (1 == userNameParts.Length)
					{
						connection.UserDomain = null;
						connection.UserName = userNameParts[0];
					}
					else
					{
						connection.UserDomain = userNameParts[0];
						connection.UserName = userNameParts[1];
					}
				}

				//Since the user name is specified, the saved credentials should not be used
				connection.UseSavedCredentials = false;
			}

			//Check whether the user information has changed
			if (!string.Equals(userDomain, connection.UserDomain, StringComparison.Ordinal) ||
				!string.Equals(userName, connection.UserName, StringComparison.Ordinal))
			{
				connection.UserPassword = null;
			}
		}
		#endregion

		#region Methods for Organization
		private void PopulateOrganizationInformation(CrmOrganization org)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			grpOrganizationInformation.Visible = true;
			btnSaveOrganization.Enabled = false;
			this.ResizeConnectionTree();

			txtCrmServiceUrl.Text = org.OrganizationServiceUrl;

			this.m_editingItem = org;
			this.AcceptButton = btnConnectOrganization;
			this.CancelButton = btnCancelOrganization;
		}

		private bool CompareOrganizationInformation()
		{
			if (this.m_editingItem == null)
			{
				return true;
			}

			CrmOrganization editingOrg = (CrmOrganization)this.m_editingItem;

			CrmOrganization changedOrg = new CrmOrganization();
			changedOrg.OrganizationServiceUrl = txtCrmServiceUrl.Text;

			if (editingOrg.OrganizationServiceUrl != changedOrg.OrganizationServiceUrl)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private bool SaveOrganizationInformation()
		{
			if (this.m_editingItem == null)
			{
				return false;
			}

			CrmOrganization org = (CrmOrganization)this.m_editingItem;

			if (!this.OrganizationsForm.OrganizationHasTab(org.ConnectionDetail.ConnectionId, org.OrganizationId) ||
				MessageBox.Show("This will close the organization window. Continue?",
					"Close Windows", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
                if (this.OrganizationsForm.OrganizationHasTab(org.ConnectionDetail.ConnectionId, org.OrganizationId))
				{
                    this.OrganizationsForm.CloseOrganizationTab(org.ConnectionDetail.ConnectionId, org.OrganizationId);
				}
			}
			else
			{
				return false;
			}

			org.OrganizationServiceUrl = txtCrmServiceUrl.Text;

			return true;
		}

		private void ClearOrganizationInformation()
		{
			this.m_editingItem = null;

			txtCrmServiceUrl.Clear();

			this.AcceptButton = null;
			this.CancelButton = null;
			btnSaveOrganization.Enabled = false;
			grpOrganizationInformation.Visible = false;
			this.ResizeConnectionTree();
		}
		#endregion

		private void LoadConnectionsFile()
		{
			if (File.Exists(this.m_connectionFile))
			{
				bool readError = true;

				try
				{
					using (FileStream inputStream = new FileStream(this.m_connectionFile, FileMode.Open, FileAccess.Read))
					{
						using (XmlReader reader = new XmlTextReader(inputStream))
						{
							XmlSerializer serializer = new XmlSerializer(typeof(CrmConnection[]));
							if (serializer.CanDeserialize(reader))
							{
								CrmConnection[] conList = (CrmConnection[])serializer.Deserialize(reader);

								if (conList != null)
								{
									List<CrmConnection> newConList = new List<CrmConnection>(conList);
									newConList.Sort(new CrmConnectionLabelComparer());

									foreach (CrmConnection con in newConList)
									{
										con.ConnectionId = Guid.NewGuid();
										this.m_connections.Add(con.ConnectionId, con);
									}
								}

								readError = false;
							}
						}

						inputStream.Close();
					}
				}
				catch (IOException)
				{
					//Do nothing. The error will be caught
				}
				catch (InvalidOperationException)
				{
					//Do nothing. The error will be caught
				}
				catch (XmlException)
				{
					//Do nothing
				}

				if (readError)
				{
					MessageBox.Show(string.Format("Unable to read saved Connections file {0}.\nPlease ensure that it exists, you have permissions to the file, and it is valid XML.", this.m_connectionFile),
						"Connections Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void SaveConnectionsFile()
		{
			bool writeError = true;

			try
			{
				FileStream outputStream;
				if (File.Exists(this.m_connectionFile))
				{
					outputStream = new FileStream(this.m_connectionFile, FileMode.Truncate, FileAccess.Write);
				}
				else
				{
					outputStream = new FileStream(this.m_connectionFile, FileMode.Create, FileAccess.Write);
				}

				using (outputStream)
				{
					XmlSerializer serializer = new XmlSerializer(typeof(CrmConnection[]));
					serializer.Serialize(outputStream, this.Connections);

					writeError = false;

					outputStream.Close();
				}
			}
			catch (IOException)
			{
				//Do nothing
			}
			catch (InvalidOperationException)
			{
				//Do nothing. The error will be caught
			}

			if (writeError)
			{
				MessageBox.Show(string.Format("Unable to save Connections file {0}.\nPlease ensure that you have permissions to the file and that it is not in use.", this.m_connectionFile),
					"Connections Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private class CrmConnectionLabelComparer : IComparer<CrmConnection>
		{
			public int Compare(CrmConnection item1, CrmConnection item2)
			{
				if (item1 == null || item2 == null)
				{
					throw new ArgumentNullException();
				}
				else
				{
					return string.Compare(item1.Label, item2.Label, true);
				}
			}
		}

		private int groupBoxDiff = 0;
		private void ResizeConnectionTree()
		{
			if (this.groupBoxDiff == 0)
			{
				this.groupBoxDiff = grpConnectionInformation.Top - trvConnections.Bottom;
			}

			int newBottom;
			if (grpConnectionInformation.Visible)
			{
				newBottom = grpConnectionInformation.Top - groupBoxDiff;
			}
			else if (grpOrganizationInformation.Visible)
			{
				newBottom = grpOrganizationInformation.Top - groupBoxDiff;
			}
			else
			{
				newBottom = this.ClientSize.Height - trvConnections.Top;
			}

			if (newBottom - trvConnections.Top > 0)
			{
				trvConnections.Height = newBottom - trvConnections.Top;
			}
		}

		private void OpenConnection(ICrmTreeNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}

			switch (node.NodeType)
			{
				case CrmTreeNodeType.Connection:
					this.OpenConnection((CrmConnection)node);
					break;
				case CrmTreeNodeType.Organization:
					this.OpenConnection((CrmOrganization)node);
					break;
				default:
					throw new NotImplementedException("Unknown Node Type = " + node.NodeType.ToString());
			}
		}

		private void OpenConnection(CrmConnection con)
		{
			if (con == null)
			{
				throw new ArgumentNullException("con");
			}

			if (!con.OrganizationsLoaded)
			{
				ProgressIndicator prog = this.MainForm.ProgressIndicator;
				prog.Initialize(2, "Discovering");

				bool passwordRetrieved = false;

				//Check to see if the password needs to be retrieved
				if (!con.UseSavedCredentials && null == con.UserPassword)
				{
					if (!this.RetrievePassword(con))
					{
						trvConnections.SelectedNode = con;
						prog.Complete();
						return;
					}

					//Mark the password as retrieved
					passwordRetrieved = true;
				}

				string errorMessage = null;
				Exception error = null;

				this.MainForm.EnableToolBar(false);
				trvConnections.Enabled = false;
				grpConnectionInformation.Enabled = false;
				Application.DoEvents();

				try
				{
					try
					{
						con.RetrieveOrganizations();
					}
					catch (NotSupportedException)
					{
						if (con.UseSavedCredentials)
						{
							//Attempt to retrieve the password
							if (!this.RetrievePassword(con))
							{
								trvConnections.SelectedNode = con;
								prog.Complete();
								return;
							}
						}
					}

					prog.Increment("Not loading Messages from CRM");
				}
				catch (System.Net.WebException ex)
				{
					errorMessage = "Unable to connect to the Discovery Service.";
					error = ex;
				}
				catch (Exception ex)
				{
					errorMessage = "Unable to retrieve the organizations from the Discovery Service.";
					error = ex;
				}
				finally
				{
					trvConnections.Enabled = true;
					grpConnectionInformation.Enabled = true;
					this.MainForm.EnableToolBar(true);
				}
				prog.Complete();

				if (!string.IsNullOrEmpty(errorMessage))
				{
					if (passwordRetrieved)
					{
						con.UserPassword = null;
					}
					trvConnections.SelectedNode = con;

					ErrorMessage.ShowErrorMessageBox(this, errorMessage, "Discovery Service", error);
					return;
				}
				else
				{
					foreach (CrmOrganization org in con.Organizations)
					{
						if (trvConnections.HasNode(org.OrganizationId))
						{
							CrmOrganization compareOrg = (CrmOrganization)trvConnections[org.OrganizationId];
                            if (compareOrg.ConnectionDetail.ConnectionId != con.ConnectionId)
							{
								MessageBox.Show(string.Format("Unable to load Organizations for \"{0}\", because the same Organization Id is being used by \"{1}\".\nPlease close \"{1}\" connection and try again.",
                                    con.Label, compareOrg.ConnectionDetail.ConnectionName), "Error",
									MessageBoxButtons.OK, MessageBoxIcon.Warning);
								con.ClearOrganizations();
								return;
							}
						}
					}

					trvConnections.RefreshNode(con.ConnectionId, true);
					if (con.Organizations.Length != 0)
					{
						trvConnections.SelectedNode = con.Organizations[0];
						trvConnections.Focus();
					}
					else
					{
						trvConnections.SelectedNode = con;
					}
				}
			}

			if (con.Organizations.Length == 0)
			{
				MessageBox.Show("No Organizations were retrieved.\nYou may not have permissions to any Organizations on this Deployment.",
					"No Organizations", MessageBoxButtons.OK, MessageBoxIcon.Information);

				con.ClearOrganizations();
				trvConnections.RefreshNode(con.NodeId, true);
			}
		}

		private void OpenConnection(CrmOrganization org)
		{
			if (org == null)
			{
				throw new ArgumentNullException("org");
			}

			if (org.Connected && this.m_orgsForm.OrganizationHasTab(org.ConnectionDetail.ConnectionId, org.OrganizationId))
			{
                this.m_orgsForm.SelectOrganizationTab(org.ConnectionDetail.ConnectionId, org.OrganizationId);
			}
			else
			{
				trvConnections.Enabled = false;
				this.MainForm.EnableToolBar(false);
				grpOrganizationInformation.Enabled = false;
				Application.DoEvents();

				try
				{
					OrganizationHelper.OpenConnection(org,
						this.MainForm.LoadMessages(org), this.MainForm.ProgressIndicator);
				}
				catch (Exception ex)
				{
					ErrorMessage.ShowErrorMessageBox(this, "Unable to the connect to the organization", "Connection Error", ex);

					this.MainForm.ProgressIndicator.Complete();
					return;
				}
				finally
				{
					trvConnections.Enabled = true;
					this.MainForm.EnableToolBar(true);
					grpOrganizationInformation.Enabled = true;
				}

				this.m_orgsForm.CreateOrganizationTab(org);
			}

			trvConnections.SelectedNode = null;
		}
		#endregion

		#region Public Methods
		public void NewConnection()
		{
			if (!this.Visible)
			{
				MessageBox.Show("The Connections Window is not currently visible. Use the View menu to make it visible",
					"Connections", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (this.m_editingItem != null && this.CompareConnectionInformation() && this.SaveChanges(false, true, true) == null)
			{
				return;
			}

			ClearConnectionInformation();
			ClearOrganizationInformation();
			PopulateConnectionInformation(null);
		}

		public void ReloadConnection()
		{
			if (trvConnections.SelectedNode == null ||
				(trvConnections.SelectedNode.NodeType != CrmTreeNodeType.Connection &&
				 trvConnections.SelectedNode.NodeType != CrmTreeNodeType.Organization))
			{
				MessageBox.Show("Please select a connection to Reload.", "Select a connection",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			CrmTreeNodeType selectedNode = trvConnections.SelectedNode.NodeType;
			Guid? nodeId = this.SaveChanges(true, true, true);
			if (nodeId == null || nodeId == Guid.Empty)
			{
				return;
			}
			else
			{
				CrmConnection con;
				switch (selectedNode)
				{
					case CrmTreeNodeType.Connection:
						con = (CrmConnection)trvConnections[(Guid)nodeId];
						break;
					case CrmTreeNodeType.Organization:
						con = ((CrmConnection)trvConnections[(Guid)nodeId]);//.Connection;
						break;
					default:
						throw new NotImplementedException("NodeType = " + selectedNode.ToString());
				}
				trvConnections.SelectedNode = con;

				if (con.OrganizationsLoaded)
				{
					bool userQueried = false;
					foreach (CrmOrganization org in con.Organizations)
					{
						if (this.OrganizationsForm.OrganizationHasTab(con.ConnectionId, org.OrganizationId))
						{
							if (!userQueried)
							{
								switch (MessageBox.Show("This will close any open organization windows. Continue?",
									"Close Windows", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
								{
									case DialogResult.Yes:
										userQueried = true;
										break;
									case DialogResult.No:
										return;
									default:
										throw new NotImplementedException();
								}
							}

							org.Connected = false;
							this.OrganizationsForm.CloseOrganizationTab(con.ConnectionId, org.OrganizationId);
						}
					}
				}

				con.ClearOrganizations();
				trvConnections.RefreshNode(con.ConnectionId, true);
				Application.DoEvents();

				this.OpenConnection(trvConnections[con.NodeId]);
			}
		}

		public void RemoveConnection()
		{
			if (!this.Visible)
			{
				MessageBox.Show("The Connections Window is not currently visible. Use the View menu to make it visible",
					"Connections", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (this.m_editingItem == null)
			{
				MessageBox.Show("A Connection has not been selected.",
					"Remove Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			else if (MessageBox.Show("Are you sure you want to remove your saved connection?", "Connections",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
			{
				ICrmTreeNode node;
				if (trvConnections.SelectedNode.NodeType == CrmTreeNodeType.Organization)
				{
					node = trvConnections[((CrmOrganization)trvConnections.SelectedNode).ConnectionDetail.ConnectionId];
				}
				else
				{
					node = trvConnections.SelectedNode;
				}

				if (node.NodeType != CrmTreeNodeType.Connection)
				{
					MessageBox.Show("A Connection has not been selected.",
						"Remove Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				else
				{
					CrmConnection con = (CrmConnection)node;
					if (con != null)
					{
						foreach (CrmOrganization org in con.Organizations)
						{
							if (org.Connected && this.OrganizationsForm.OrganizationHasTab(con.ConnectionId, org.OrganizationId))
							{
								org.Connected = false;
								this.OrganizationsForm.CloseOrganizationTab(con.ConnectionId, org.OrganizationId);
							}
						}
					}

					this.m_connections.Remove(con.ConnectionId);
				}

				this.ClearConnectionInformation();
				trvConnections.RemoveNode(node.NodeId);
				this.SaveConnectionsFile();
			}
		}

		public void UpdateAutoExpand(bool newValue)
		{
			trvConnections.AutoExpand = newValue;
		}
		#endregion
	}
}