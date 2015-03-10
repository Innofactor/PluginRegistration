using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.Management
{
	/// <summary>
	/// This class obtains a SWT token and adds it to the HTTP authorize header 
	/// for every request to the management service.
	/// </summary>
	public partial class ManagementServiceHelper
	{
		public static void ClearCachedSwtToken()
		{
			lock (padlock)
			{
				cachedSwtToken = null;
			}
		}
	}
}
