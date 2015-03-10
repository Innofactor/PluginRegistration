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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace PluginRegistrationTool
{
	public partial class AboutForm : Form
	{
		public AboutForm()
		{
			InitializeComponent();

			//Retrieve the information about the assembly
			foreach (Attribute att in Attribute.GetCustomAttributes(typeof(AboutForm).Assembly))
			{
				if (typeof(AssemblyTitleAttribute) == att.GetType())
				{
					lblTitle.Text = ((AssemblyTitleAttribute)att).Title;
				}
				else if (typeof(AssemblyDescriptionAttribute) == att.GetType())
				{
					lblDescription.Text = ((AssemblyDescriptionAttribute)att).Description;
				}
				else if (typeof(AssemblyFileVersionAttribute) == att.GetType())
				{
					lblVersion.Text = string.Format("Version {0}", ((AssemblyFileVersionAttribute)att).Version);
				}
			}
		}

		private void AboutForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				this.Close();
			}
		}
	}
}
