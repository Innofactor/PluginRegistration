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
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

using PluginProfiler.Library;
using PluginProfiler.Plugins;

namespace PluginRegistrationTool
{
	public sealed partial class PluginProfileForm : Form
	{
		private ProfilerPluginReport m_report;

		public PluginProfileForm()
		{
			InitializeComponent();
		}

		#region Control Events
		private void ViewButton_Click(object sender, EventArgs e)
		{
			const string ProfileExtension = ".xml";

			if (!this.ParseReport(false))
			{
				this.EnableDisableButtons();
				return;
			}

			string fileName = null;
			try
			{
				//Generate a temporary file name with the correct extension. Path.GetTempFileName() cannot be used because it actually creates
				//the file, which won't have the correct extension.
				fileName = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ProfileExtension;

				//Write the report
				this.SaveFormattedReport(fileName);

				//Load the file
				using (Process process = new Process())
				{
					//Setup the process
					process.StartInfo = new ProcessStartInfo();
					process.StartInfo.FileName = fileName;
					process.StartInfo.UseShellExecute = true;

					//Disable the form so that it is obvious to the user that it cannot be used when the process is running
					this.Enabled = false;

					//Start the process and wait for it to complete. By the time the starting process exits, the other process
					//will have loaded the file.
					process.Start();
					process.WaitForExit();
				}

				this.DialogResult = System.Windows.Forms.DialogResult.OK;
			}
			catch (Exception ex)
			{
				ErrorMessage.ShowErrorMessageBox(this, "Unable to save the Plug-in Profile.", "Profile", ex);
			}
			finally
			{
				this.Enabled = true;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (!this.ParseReport(false))
			{
				this.EnableDisableButtons();
				return;
			}

			try
			{
				if (System.Windows.Forms.DialogResult.OK == ExportFileDialog.ShowDialog())
				{
					this.SaveFormattedReport(ExportFileDialog.FileName);
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				ErrorMessage.ShowErrorMessageBox(this, "Unable to save the Plug-in Profile.", "Profile", ex);
			}
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void LogPathControl_PathChanged(object sender, EventArgs e)
		{
			if (this.EnableDisableButtons())
			{
				this.ParseReport(true);
			}
		}
		#endregion

		#region Private Helper Methods
		private bool EnableDisableButtons()
		{
			if (LogPathControl.FileExists)
			{
				ViewButton.Enabled = true;
				SaveButton.Enabled = true;

				return true;
			}

			ViewButton.Enabled = false;
			SaveButton.Enabled = false;
			return false;
		}

		private void SaveFormattedReport(string fileName)
		{
			if (this.ParseReport(false))
			{
				string report = this.m_report.ToString(true);
				File.WriteAllText(fileName, report);
			}
		}

		private bool ParseReport(bool requireReportParse)
		{
			return OrganizationHelper.ParseReportOrShowError(this, this.LogPathControl, requireReportParse, ref this.m_report);
		}
		#endregion
	}
}
