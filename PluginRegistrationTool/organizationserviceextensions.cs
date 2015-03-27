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

namespace PluginRegistrationTool
{
    using System;
    using System.Reflection;
    using Microsoft.Xrm.Sdk;
    using Microsoft.Xrm.Sdk.Query;

	public static class OrganizationServiceExtensions
	{
		/// <summary>
		/// Retrieves all pages for a given query
		/// </summary>
		public static EntityCollection RetrieveMultipleAllPages(this IOrganizationService service, QueryBase query)
		{
			if (null == service)
			{
				throw new ArgumentNullException("service");
			}
			else if (null == query)
			{
				throw new ArgumentNullException("query");
			}

			EntityCollection fullResults = service.RetrieveMultiple(query);
			if (!fullResults.MoreRecords)
			{
				return fullResults;
			}

			PropertyInfo property = query.GetType().GetProperty("PageInfo");
			if (null == property)
			{
				throw new NotSupportedException("The specified query object does not have a PageInfo property defined.");
			}

			PagingInfo paging = new PagingInfo() { PageNumber = 1, ReturnTotalRecordCount = false };
			property.SetValue(query, paging, null);

			EntityCollection results = fullResults;
			while (results.MoreRecords)
			{
				//Update the paging information
				paging.PagingCookie = results.PagingCookie;
				paging.PageNumber++;

				//Retrieve the next page
				results = service.RetrieveMultiple(query);

				//Add the results to the full list
				fullResults.Entities.AddRange(results.Entities);
			}

			return fullResults;
		}
	}
}
