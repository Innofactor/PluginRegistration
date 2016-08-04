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

namespace Xrm.Sdk.PluginRegistration.Wrappers
{
    using System;
    using Entities;

    public sealed class CrmUser
    {
        private CrmOrganization m_org;

        public CrmUser(CrmOrganization org)
        {
            if (org == null)
            {
                throw new ArgumentNullException("org");
            }

            m_org = org;
        }

        public CrmUser(CrmOrganization org, SystemUser user)
            : this(org)
        {
            if (user.SystemUserId != null)
            {
                UserId = user.SystemUserId.Value;
            }

            Name = user.FullName;

            if (user.IsDisabled != null && (user.IsDisabled.HasValue))
            {
                Enabled = !user.IsDisabled.Value;
            }

            DomainName = user.DomainName;
            InternalEmailAddress = user.InternalEMailAddress;
        }

        #region Properties
        public CrmOrganization Organization
        {
            get
            {
                return m_org;
            }
        }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string DomainName { get; set; }

        public string InternalEmailAddress { get; set; }

        public bool Enabled { get; set; }

        public override string ToString()
        {
            if (Enabled)
            {
                if (null != Name)
                {
                    return Name;
                }
                else
                {
                    return string.Format("null {0}", DomainName);
                }
            }
            else
            {
                return string.Format("{0} (Disabled)", Name);
            }
        }
        #endregion
    }
}
