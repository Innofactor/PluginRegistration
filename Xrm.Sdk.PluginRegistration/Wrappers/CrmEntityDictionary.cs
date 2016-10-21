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
    using System.Collections;
    using System.Collections.Generic;

    public class CrmEntityDictionary<EntityType> : IEnumerable<EntityType>, IEnumerable
        where EntityType : ICrmEntity
    {
        #region Private Fields

        private Dictionary<Guid, EntityType> m_entityList = new Dictionary<Guid, EntityType>();

        #endregion Private Fields

        #region Public Constructors

        public CrmEntityDictionary(Dictionary<Guid, EntityType> entityList)
        {
            if (entityList == null)
            {
                throw new ArgumentNullException("entityList");
            }

            m_entityList = entityList;
        }

        #endregion Public Constructors

        #region Public Properties

        public int Count
        {
            get
            {
                return m_entityList.Count;
            }
        }

        public Dictionary<Guid, EntityType>.KeyCollection Keys
        {
            get
            {
                return m_entityList.Keys;
            }
        }

        public Dictionary<Guid, EntityType>.ValueCollection Values
        {
            get
            {
                return m_entityList.Values;
            }
        }

        #endregion Public Properties

        #region Public Indexers

        public EntityType this[Guid id]
        {
            get
            {
                return m_entityList[id];
            }
        }

        #endregion Public Indexers

        #region Public Methods

        public bool ContainsKey(Guid id)
        {
            return m_entityList.ContainsKey(id);
        }

        public IEnumerator<EntityType> GetEnumerator()
        {
            return m_entityList.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_entityList.Values.GetEnumerator();
        }

        public EntityType[] ToArray()
        {
            EntityType[] items = new EntityType[m_entityList.Count];
            m_entityList.Values.CopyTo(items, 0);

            return items;
        }

        public bool TryGetValue(Guid id, out EntityType value)
        {
            return m_entityList.TryGetValue(id, out value);
        }

        #endregion Public Methods
    }
}