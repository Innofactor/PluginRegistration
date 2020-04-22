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
    using Microsoft.Xrm.Sdk.Metadata;
    using System;

    public sealed class CrmAttribute
    {
        #region Private Fields

        private AttributeTypeCode m_attributeType;
        private string m_attributeTypeName;
        private string m_friendlyName;
        private bool m_isPrimaryId = false;
        private string m_schemaName;
        private bool m_validForCreate = false;
        private bool m_validForRead = false;
        private bool m_validForUpdate = false;

        #endregion Private Fields

        #region Public Constructors

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

            m_schemaName = schemaName;
            m_friendlyName = friendlyName;
            m_attributeType = type;
            m_validForCreate = validForCreate;
            m_validForRead = validForRead;
            m_validForUpdate = validForUpdate;
            m_isPrimaryId = isPrimaryId;
        }

        public CrmAttribute(AttributeMetadata md, bool isPrimaryId)
        {
            if (md == null)
            {
                throw new ArgumentNullException("md");
            }

            m_schemaName = md.LogicalName;
            if (md.DisplayName.LocalizedLabels.Count == 0)
            {
                m_friendlyName = md.LogicalName;
            }
            else
            {
                m_friendlyName = md.DisplayName.UserLocalizedLabel.Label;
            }

            m_attributeType = md.AttributeType.Value;
            m_attributeTypeName = md.AttributeTypeName.Value;
            m_validForCreate = md.IsValidForCreate.Value;
            m_validForRead = md.IsValidForUpdate.Value;
            m_validForUpdate = md.IsValidForUpdate.Value;
            m_isPrimaryId = isPrimaryId;
        }

        #endregion Public Constructors

        #region Public Properties

        public string FriendlyName
        {
            get
            {
                return m_friendlyName;
            }
        }

        public bool IsPrimaryId
        {
            get
            {
                return m_isPrimaryId;
            }
        }

        public string LogicalName
        {
            get
            {
                return m_schemaName;
            }
        }

        public AttributeTypeCode Type
        {
            get
            {
                return m_attributeType;
            }
        }

        public string TypeName
        {
            get
            {
                return m_attributeTypeName;
            }
        }

        public bool ValidForCreate
        {
            get
            {
                return m_validForCreate;
            }
        }

        public bool ValidForRead
        {
            get
            {
                return m_validForRead;
            }
        }

        public bool ValidForUpdate
        {
            get
            {
                return m_validForUpdate;
            }
        }

        #endregion Public Properties
    }
}