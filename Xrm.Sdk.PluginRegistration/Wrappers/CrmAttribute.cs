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
    using Microsoft.Xrm.Sdk.Metadata;

    public sealed class CrmAttribute
    {
        private string m_schemaName;
        private string m_friendlyName;
        private AttributeTypeCode m_attributeType;
        private bool m_validForCreate = false;
        private bool m_validForUpdate = false;
        private bool m_validForRead = false;
        private bool m_isPrimaryId = false;

        public CrmAttribute(string schemaName, string friendlyName, AttributeTypeCode type,
            bool validForCreate, bool validForUpdate, bool validForRead, bool isPrimaryId)
        {
            if (schemaName == null)
            {
                throw new ArgumentNullException("schemaName");
            }
            else if (friendlyName == null)
            {
                throw new ArgumentNullException("friendlyName");
            }

            this.m_schemaName = schemaName;
            this.m_friendlyName = friendlyName;
            this.m_attributeType = type;
            this.m_validForCreate = validForCreate;
            this.m_validForRead = validForRead;
            this.m_validForUpdate = validForUpdate;
            this.m_isPrimaryId = isPrimaryId;
        }

        public CrmAttribute(AttributeMetadata md, bool isPrimaryId)
        {
            if (md == null)
            {
                throw new ArgumentNullException("md");
            }

            this.m_schemaName = md.LogicalName;
            if (md.DisplayName.LocalizedLabels.Count == 0)
            {
                this.m_friendlyName = md.LogicalName;
            }
            else
            {
                this.m_friendlyName = md.DisplayName.UserLocalizedLabel.Label;
            }

            this.m_attributeType = md.AttributeType.Value;
            this.m_validForCreate = md.IsValidForCreate.Value;
            this.m_validForRead = md.IsValidForUpdate.Value;
            this.m_validForUpdate = md.IsValidForUpdate.Value;
            this.m_isPrimaryId = isPrimaryId;
        }

        #region Properties
        public string LogicalName
        {
            get
            {
                return this.m_schemaName;
            }
        }

        public string FriendlyName
        {
            get
            {
                return this.m_friendlyName;
            }
        }

        public AttributeTypeCode Type
        {
            get
            {
                return this.m_attributeType;
            }
        }

        public bool ValidForCreate
        {
            get
            {
                return this.m_validForCreate;
            }
        }

        public bool ValidForUpdate
        {
            get
            {
                return this.m_validForUpdate;
            }
        }

        public bool ValidForRead
        {
            get
            {
                return this.m_validForRead;
            }
        }

        public bool IsPrimaryId
        {
            get
            {
                return this.m_isPrimaryId;
            }
        }
        #endregion
    }
}
