//---------------------------------------------------------------------------------
// Microsoft (R)  Windows Azure Platform AppFabric SDK
// Software Development Kit
// 
// Copyright (c) Microsoft Corporation. All rights reserved.  
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES 
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE. 
//---------------------------------------------------------------------------------

namespace Microsoft.AccessControl.Samples.AcmTool
{
    using System;
    using AcmTool.Commands;
    using AcmTool.Resources;
	using System.Collections.Generic;

    internal class Acm
    {
		internal string ConfigureACS(string[] args)
        {
			string returnString = String.Empty;            
            CommandLineArguments commandLineArgs = new CommandLineArguments();

            bool parseSuccess = true;
            try
            {
                commandLineArgs.Parse(args);
            }
            catch (ArgumentException argException)
            {              
                parseSuccess = false;               
				throw argException;
            }

            if (parseSuccess)
            {              
                ResponseMessage responseMessage;
                commandLineArgs.Validate();
                Command command = commandLineArgs.CreateCommand();
                command.Parse();
                command.Validate();

				responseMessage = command.Execute();
				
				returnString = responseMessage.Message;					
            }           
			return returnString;
        }

		internal List<Resource> ConfigureACSGetResources(string[] args)
		{			
			CommandLineArguments commandLineArgs = new CommandLineArguments();

			bool parseSuccess = true;
			try
			{
				commandLineArgs.Parse(args);
			}
			catch (ArgumentException argException)
			{				
				parseSuccess = false;				
				throw argException;
			}

			if (parseSuccess)
			{
				List<Resource> responseMessage1;
				commandLineArgs.Validate();
				Command command = commandLineArgs.CreateCommand();
				command.Parse();
				command.Validate();

				responseMessage1 = ((GetAllCommand)command).ExecuteReturnResourceList();
				return responseMessage1;						
			}			
			return null;
		}
    }
}
