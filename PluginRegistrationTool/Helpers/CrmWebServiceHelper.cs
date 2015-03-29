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

namespace PluginRegistrationTool.Helpers
{
    using System.Collections.Generic;
    using System.Threading;

    internal static class CrmWebServiceHelper
    {
        private volatile static List<Thread> m_threadList = new List<Thread>(2);

        public static void InitializeWebServices()
        {
            lock (m_threadList)
            {
                m_threadList.Add(new Thread(new ThreadStart(InitializeCrmService)));
                m_threadList.Add(new Thread(new ThreadStart(InitializeDiscoveryService)));

                for (int i = 0; i < m_threadList.Count; i++)
                {
                    m_threadList[i].Start();
                }
            }
        }

        public static void CancelInitialization()
        {
            lock (m_threadList)
            {
                for (int i = 0; i < m_threadList.Count; i++)
                {
                    m_threadList[i].Abort();
                    m_threadList[i].Join();
                }

                m_threadList.Clear();
            }
        }

        #region Private Methods
        private static void InitializeCrmService()
        {
            //Microsoft.Xrm.Sdk.IOrganizationService service = new Microsoft.Xrm.Sdk.IOrganizationService();
        }

        private static void InitializeDiscoveryService()
        {
            //Microsoft.Xrm.Sdk.Discovery.IDiscoveryService service = new Microsoft.Xrm.Sdk.Discovery.IDiscoveryService();
        }
        #endregion
    }
}
