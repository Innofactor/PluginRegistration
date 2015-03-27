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

namespace PluginRegistrationTool.Wrappers
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

	public class CrmEntityDictionary<EntityType> : IEnumerable<EntityType>, IEnumerable
		where EntityType : ICrmEntity
	{
		private Dictionary<Guid, EntityType> m_entityList = new Dictionary<Guid, EntityType>();

		public CrmEntityDictionary(Dictionary<Guid, EntityType> entityList)
		{
			if (entityList == null)
			{
				throw new ArgumentNullException("entityList");
			}

			this.m_entityList = entityList;
		}

		#region Properties
		public int Count
		{
			get
			{
				return this.m_entityList.Count;
			}
		}

		public Dictionary<Guid, EntityType>.KeyCollection Keys
		{
			get
			{
				return this.m_entityList.Keys;
			}
		}

		public Dictionary<Guid, EntityType>.ValueCollection Values
		{
			get
			{
				return this.m_entityList.Values;
			}
		}

		public EntityType this[Guid id]
		{
			get
			{
				return this.m_entityList[id];
			}
		}
		#endregion

		#region Public Methods
		public bool TryGetValue(Guid id, out EntityType value)
		{
			return this.m_entityList.TryGetValue(id, out value);
		}

		public bool ContainsKey(Guid id)
		{
			return this.m_entityList.ContainsKey(id);
		}

		public EntityType[] ToArray()
		{
			EntityType[] items = new EntityType[this.m_entityList.Count];
			this.m_entityList.Values.CopyTo(items, 0);

			return items;
		}
		#endregion

		#region IEnumerable<EntityType> Members
		public IEnumerator<EntityType> GetEnumerator()
		{
			return this.m_entityList.Values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_entityList.Values.GetEnumerator();
		}
		#endregion
	}
}
