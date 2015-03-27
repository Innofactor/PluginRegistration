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
using System.Text;
using System.Windows.Forms;

namespace PluginRegistrationTool
{
	internal static class Program
	{
		/// <summary>
		/// Operations that can occur from the console
		/// </summary>
		internal enum ConsoleOperation
		{
			None = -1,
			Export = 1,
			Import = 2,
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			AssemblyResolver.AttachResolver();

			string connectionsFile = "Connections.config";
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			if (args.Length != 0)
			{
				bool showHelp = false;

				#region Argument Parsing
				for (int i = 0; i < args.Length; i++)
				{
					string[] keyValue = null;
					keyValue = args[i].Split(":".ToCharArray(), 2, StringSplitOptions.RemoveEmptyEntries);
					if (keyValue.Length < 2)
					{
						showHelp = true;
						break;
					}
					switch (keyValue[0].ToUpperInvariant())
					{
						case "/C": //Connections File
							connectionsFile = keyValue[1];
							break;
						default:
							showHelp = true;
							break;
					}

					if (showHelp)
					{
						break;
					}
				}
				#endregion

				#region Help Display
				if (showHelp)
				{
					StringBuilder builder = new StringBuilder();
					builder.AppendLine("Correct usage as follows:");
					builder.AppendLine("  /c:<connectionFileName>");
					builder.AppendLine("  Parameter information: ");
					builder.AppendLine("      <connectionFileName> name of the connections file, default: Connections.config");
					builder.AppendLine("  /? Show this help");

					Console.WriteLine(builder.ToString());
					return;
				}
				#endregion
			} 
			
			Application.Run(new MainForm(connectionsFile));
		}
	}
}
