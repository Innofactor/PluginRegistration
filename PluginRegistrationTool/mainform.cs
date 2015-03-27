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
using System.Configuration;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using PluginRegistrationTool.Helpers;

namespace PluginRegistrationTool
{
	public partial class MainForm : Form
	{
		// private ConnectionsForm m_connectionsForm;
		private OrganizationsForm m_organizationsForm;
		private ProgressIndicator m_progIndicator;
		private volatile static List<CrmMessage> m_messageList = new List<CrmMessage>();

		public MainForm(string connectionsFile)
		{
			InitializeComponent();

			#region Load the Images & Icons from the Resource File
			Image connectionImage = null;
			try
			{
				connectionImage = CrmResources.LoadImage(CrmTreeNodeImageType.Connection);

				toolConnectionNew.Image = connectionImage;
			}
			catch (ArgumentException) //Thrown if the image is not in the list
			{
				if (connectionImage != null)
				{
					connectionImage.Dispose();
					connectionImage = null;
				}
			}

			Dictionary<string, Image> imageList = null;
			try
			{
				imageList = CrmResources.LoadImage("Refresh", "Delete", "Debug", "PluginProfile");

				toolConnectionRefresh.Image = imageList["Refresh"];
				toolConnectionRemove.Image = imageList["Delete"];
				toolProfilerReplay.Image = imageList["Debug"];
				toolPluginProfile.Image = imageList["PluginProfile"];
			}
			catch (ArgumentException) //Thrown if the image is not in the list
			{
				foreach (Image img in imageList.Values)
				{
					img.Dispose();
				}

				imageList.Clear();
			}
			#endregion

			//Add the Connections form to the Main Window
            //this.m_connectionsForm = new ConnectionsForm(connectionsFile, this);
            //this.m_connectionsForm.MdiParent = this;
            //this.m_connectionsForm.Dock = DockStyle.Left;
            //this.m_connectionsForm.Show();

			//Create the Organizations container
			this.m_organizationsForm = new OrganizationsForm(this);
			this.m_organizationsForm.MdiParent = this;

			//this.m_connectionsForm.OrganizationsForm = this.m_organizationsForm;

			//Register Resize Event Handlers
			//this.m_connectionsForm.Resize += MainForm_Resize;

			//Initialize the progress bar
			this.m_progIndicator = new ProgressIndicator(this.ProgressIndicatorInit, this.ProgressIndicatorComplete,
				null, this.ProgressIndicatorSetText, this.ProgressIndicatorIncrement, null);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.ResizeOrganizationForm();

			// Add online help.
			string chmFile = string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}\\{1}",
				OrganizationHelper.ExecutingDirectory, "PluginRegistration.chm");

			HelpProvider helpProvider = new HelpProvider();

			if (System.IO.File.Exists(chmFile))
			{
				helpProvider.HelpNamespace = chmFile;
			}
			else
			{
				helpProvider.HelpNamespace = "http://msdn2.microsoft.com/en-us/library/bb955365.aspx";
			}

			helpProvider.SetHelpNavigator(this, HelpNavigator.TableOfContents);
			helpProvider.SetHelpKeyword(this, "Creating a Simple Plug-in");
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			this.ResizeOrganizationForm();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		#region Properties
        //public ConnectionsForm ConnectionsForm
        //{
        //    get
        //    {
        //        return this.m_connectionsForm;
        //    }
        //}

		public OrganizationsForm OrganizationsForm
		{
			get
			{
				return this.m_organizationsForm;
			}
		}

		public ProgressIndicator ProgressIndicator
		{
			get
			{
				return this.m_progIndicator;
			}
		}
		#endregion

		#region Menu Event Handlers
		private void mnuViewConnections_Click(object sender, EventArgs e)
		{
			this.ConnectionsFormVisible = !this.ConnectionsFormVisible;
		}

		private void mnuViewConnections_CheckedChanged(object sender, EventArgs e)
		{
			this.ResizeOrganizationForm();
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void mnuFileConnectionNew_Click(object sender, EventArgs e)
		{
			// this.ConnectionsForm.NewConnection();
		}

		private void mnuHelpAbout_Click(object sender, EventArgs e)
		{
            //AboutForm aboutForm = new AboutForm();
            //aboutForm.ShowDialog();
		}

		private void mnuViewAutoExpand_CheckedChanged(object sender, EventArgs e)
		{
            //if (this.ConnectionsForm != null)
            //{
            //    this.ConnectionsForm.UpdateAutoExpand(mnuViewAutoExpand.Checked);
            //}

			if (this.OrganizationsForm != null)
			{
				this.OrganizationsForm.UpdateAutoExpand(mnuViewAutoExpand.Checked);
			}
		}
		#endregion

		#region Public Methods
		#region ProgressIndicator Implementation
		public bool ConnectionsFormVisible
		{
			get
			{
                return true; // this.ConnectionsForm.Visible;
			}

			set
			{
				// this.ConnectionsForm.Visible = value;
				mnuViewConnections.Checked = value;
				toolConnectionNew.Enabled = value;
				toolConnectionRemove.Enabled = value;
			}
		}

		public void UpdateStatusLabel(string label)
		{
			if (string.IsNullOrEmpty(label))
			{
				statusLabel.Text = "Done";
			}
			else
			{
				statusLabel.Text = label;
			}
		}

		public void InitializeStatusProgress(int max)
		{
			if (max <= 0)
			{
				statusProgress.Visible = false;
			}
			else
			{
				statusProgress.Value = 0;
				statusProgress.Maximum = max;
				statusProgress.Visible = true;
			}
		}

		public void UpdateStatusProgress(int value)
		{
			if (statusProgress.Visible)
			{
				statusProgress.Value = value;
			}
		}

		public void IncrementStatusProgress(int value)
		{
			if (statusProgress.Visible)
			{
				statusProgress.Value += value;
			}
		}

		public void CompleteStatus()
		{
			statusLabel.Text = "Done";
			statusProgress.Visible = false;
		}
		#endregion

		public static CrmEntityDictionary<CrmMessage> LoadMessages(CrmOrganization org)
		{
			lock (m_messageList)
			{
				if (m_messageList.Count == 0)
				{
					m_messageList = OrganizationHelper.LoadMessages(org, null);
				}

				Dictionary<Guid, CrmMessage> messageList = new Dictionary<Guid, CrmMessage>();
				foreach (CrmMessage msg in m_messageList)
				{
					CrmMessage newMessage = new CrmMessage(null, msg.MessageId, msg.Name,
						msg.SupportsFilteredAttributes, msg.CustomizationLevel, msg.CreatedOn, msg.ModifiedOn,
						msg.ImageMessagePropertyNames);

					messageList.Add(newMessage.MessageId, newMessage);
				}

				return new CrmEntityDictionary<CrmMessage>(messageList);
			}
		}

		public void EnableToolBar(bool enabled)
		{
			menuMain.Enabled = enabled;
			toolMain.Enabled = enabled;
		}

		public void UpdateCurrentOrganization(CrmOrganization org)
		{
			if (org == null)
			{
				statusOrganizationInformation.Visible = false;
			}
			else
			{
				statusOrganizationInformation.Visible = true;

				//Generate the text to display in the status bar
				StringBuilder sb = new StringBuilder();
				sb.AppendFormat(CultureInfo.InvariantCulture, "Organization: {0}", org.OrganizationFriendlyName);

				//Add the current user
				if (null != org.LoggedOnUser)
				{
					sb.AppendFormat(CultureInfo.InvariantCulture, " / User: {0} ({1})", org.LoggedOnUser.Name, org.LoggedOnUser.DomainName);
				}

				//Add the build number for the server
				if (null != org.ServerBuild)
				{
					sb.AppendFormat(CultureInfo.InvariantCulture, " / Build: {0}", org.ServerBuild);
				}

				statusOrganizationInformation.Text = sb.ToString().Replace("&", "&&");
			}
		}
		#endregion

		#region Toolbar Event Handlers
		private void toolConnectionNew_Click(object sender, EventArgs e)
		{
			// this.ConnectionsForm.NewConnection();
		}

		private void toolConnectionRefresh_Click(object sender, EventArgs e)
		{
			// this.ConnectionsForm.ReloadConnection();
		}

		private void toolConnectionRemove_Click(object sender, EventArgs e)
		{
			// this.ConnectionsForm.RemoveConnection();
		}

		private void toolProfilerReplay_Click(object sender, EventArgs e)
		{
            //using (DebugPluginForm form = new DebugPluginForm(null))
            //{
            //    form.Text = "Replay Plug-in Execution";
            //    form.ShowDialog();
            //}
		}

		private void toolPluginProfile_Click(object sender, EventArgs e)
		{
            //using (PluginProfileForm form = new PluginProfileForm())
            //{
            //    form.ShowDialog();
            //}
		}
		#endregion

		#region ProgressIndicator Implementation
		private void ProgressIndicatorInit(int min, int max, int initialValue)
		{
			statusProgress.Minimum = min;
			statusProgress.Maximum = max;
			statusProgress.Value = initialValue;
			statusProgress.Visible = true;
		}

		private void ProgressIndicatorIncrement(int value)
		{
			statusProgress.Increment(value);
		}

		private void ProgressIndicatorSetText(string message)
		{
			if (string.IsNullOrEmpty(message))
			{
				statusLabel.Text = "Done";
			}
			else
			{
				statusLabel.Text = message;
			}
		}

		private void ProgressIndicatorComplete()
		{
			statusLabel.Text = "Done";
			statusProgress.Visible = false;
		}
		#endregion

		#region Private Helper Methods
		private void ResizeOrganizationForm()
		{
			if (null != this.OrganizationsForm && null != this.OrganizationsForm.Parent)
			{
				//Retrieve the MDI client
				MdiClient client = (MdiClient)this.OrganizationsForm.Parent;

				//Resize the organization form
				this.OrganizationsForm.Top = 0;

				if (client.Height > 4)
				{
					this.OrganizationsForm.Height = client.Height - 4;
				}

				if (this.ConnectionsFormVisible)
				{
					// this.OrganizationsForm.Left = this.ConnectionsForm.Right + 1;
				}
				else
				{
					this.OrganizationsForm.Left = 0;
				}

				if (client.Width > 4 + this.OrganizationsForm.Left)
				{
					this.OrganizationsForm.Width = client.Width - this.OrganizationsForm.Left - 4;
				}
			}
		}
		#endregion
	}
}
