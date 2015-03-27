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
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using CrmSdk;
    using Microsoft.Xrm.Sdk;
    using PluginRegistrationTool.Controls;

	[Serializable]
	public sealed class CrmPluginAssembly : ICrmEntity, ICrmTreeNode, ICloneable
	{
		public const string RelationshipAssemblyToType = "pluginassembly_plugintype";

		private CrmOrganization m_org = null;
		private string m_Name = null;
		private Guid m_assemblyId = Guid.Empty;
		private int m_customizationLevel;

		private CrmEntityDictionary<CrmPlugin> m_pluginReadOnlyList = null;
		private Dictionary<Guid, CrmPlugin> m_pluginList = new Dictionary<Guid, CrmPlugin>();

		public CrmPluginAssembly(CrmOrganization org)
		{
			this.m_org = org;
			this.CustomizationLevel = 1;
		}

		public CrmPluginAssembly(CrmOrganization org, Guid id, string name, DateTime? createdOn, DateTime? modifiedOn,
			CrmAssemblySourceType type, CrmAssemblyIsolationMode isolationMode, string path, string version,
			string publicKeyToken, string culture, int customizationLevel, bool enabled)
			: this(org)
		{
			this.AssemblyId = id;
			this.Name = name;
			this.SourceType = type;
			this.ServerFileName = path;
			this.Version = version;
			this.PublicKeyToken = publicKeyToken;
			this.Culture = culture;
			this.CustomizationLevel = customizationLevel;
			this.Enabled = enabled;
			this.UpdateDates(createdOn, modifiedOn);
		}

		public CrmPluginAssembly(CrmOrganization org, PluginAssembly assembly)
			: this(org)
		{
			this.RefreshFromPluginAssembly(assembly);
		}

		#region Properties
		[Browsable(false)]
		public CrmOrganization Organization
		{
			get
			{
				return this.m_org;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException();
				}
				else if (this.m_org == null)
				{
					this.m_org = value;
					foreach (CrmPlugin plugin in this.m_pluginList.Values)
					{
						if (plugin.Organization == null)
						{
							plugin.Organization = this.m_org;
						}
						this.m_org.AddPlugin(this, plugin);
					}
				}
				else
				{
					throw new NotSupportedException("Cannot change the Organization once it has been set");
				}
			}
		}

		[Category("Information"), Browsable(true), Description("Name of the Assembly"), ReadOnly(true)]
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				if (value == this.m_Name)
				{
					return;
				}

				this.m_Name = value;

				if (this.m_pluginList != null)
				{
					foreach (CrmPlugin plugin in this.m_pluginList.Values)
					{
						plugin.AssemblyName = value;
					}
				}
			}
		}

		[Category("Information"), Browsable(true), Description("Unique identifier of Assembly"), ReadOnly(true)]
		public Guid AssemblyId
		{
			get
			{
				return this.m_assemblyId;
			}
			set
			{
				if (value == this.m_assemblyId)
				{
					return;
				}

				this.m_assemblyId = value;

				if (this.m_pluginList != null)
				{
					foreach (CrmPlugin plugin in this.m_pluginList.Values)
					{
						plugin.AssemblyId = value;
					}
				}
			}
		}

		/// <summary>
		/// Retrieves the Created On date of the entity. To update, see UpdateDates.
		/// </summary>
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public DateTime? CreatedOn { get; private set; }

		/// <summary>
		/// Retrieves the Modified On date of the entity. To update, see UpdateDates.
		/// </summary>
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public DateTime? ModifiedOn { get; private set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmAssemblyIsolationMode IsolationMode { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmAssemblySourceType SourceType { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string ServerFileName { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Version { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string PublicKeyToken { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string Culture { get; set; }

		[Category("Editable"), Browsable(true), Description("Description of the Assembly"), ReadOnly(false)]
		public string Description { get; set; }

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public int CustomizationLevel
		{
			get
			{
				return this.m_customizationLevel;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Invalid CustomizationLevel specified");
				}
				
				//If the customization level is 0, then this is a system assembly (which will depend on the current version of CRM)
				if (0 == value && null == this.SdkVersion)
				{
					this.SdkVersion = this.Organization.ServerBuild;
				}

				this.m_customizationLevel = value;
			}
		}

		[Category("Information"), DisplayName("SDK Version"), Description("Version of the CRM SDK Assemblies referenced by this Assembly.")]
		[Browsable(true), ReadOnly(true)]
		public Version SdkVersion { get; set; }

		[Browsable(false)]
		public CrmEntityDictionary<CrmPlugin> Plugins
		{
			get
			{
				if (this.m_pluginReadOnlyList == null)
				{
					this.m_pluginReadOnlyList = new CrmEntityDictionary<CrmPlugin>(this.m_pluginList);
				}

				return this.m_pluginReadOnlyList;
			}
		}

		[Browsable(false)]
		public CrmPlugin this[Guid pluginId]
		{
			get
			{
				return this.m_pluginList[pluginId];
			}
		}

		[Browsable(false)]
		public bool Enabled { get; set; }

		[Browsable(false)]
		public bool IsProfilerAssembly { get; set; }
		#endregion

		#region Public Helper Methods
		public void RefreshFromPluginAssembly(PluginAssembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}

			if (assembly.Name != null)
			{
				this.Name = assembly.Name;
			}

			if (assembly.PluginAssemblyId != null)
			{
				this.AssemblyId = assembly.PluginAssemblyId.Value;
			}

			if (assembly.CreatedOn != null && (assembly.CreatedOn.HasValue))
			{
				this.CreatedOn = assembly.CreatedOn.Value;
			}

			if (assembly.ModifiedOn != null && (assembly.ModifiedOn.HasValue))
			{
				this.ModifiedOn = assembly.ModifiedOn.Value;
			}

			if (assembly.SourceType != null)
			{
				this.SourceType = (CrmAssemblySourceType)Enum.ToObject(typeof(CrmAssemblySourceType), assembly.SourceType.Value);
			}

			if (assembly.IsolationMode != null)
			{
				this.IsolationMode = (CrmAssemblyIsolationMode)Enum.ToObject(typeof(CrmAssemblyIsolationMode),
					assembly.IsolationMode.Value);
			}

			if (assembly.Path != null)
			{
				this.ServerFileName = assembly.Path;
			}

			if (assembly.Version != null)
			{
				this.Version = assembly.Version;
			}

			if (assembly.PublicKeyToken != null)
			{
				this.PublicKeyToken = assembly.PublicKeyToken;
			}

			if (assembly.Culture != null)
			{
				this.Culture = assembly.Culture;
			}

			if (assembly.CustomizationLevel != null)
			{
				this.CustomizationLevel = assembly.CustomizationLevel.Value;
			}

			this.Description = assembly.Description;

			if (null == this.SdkVersion && CrmAssemblyIsolationMode.Sandbox == this.IsolationMode &&
				null != this.m_org)
			{
				//Sandbox was not supported in CRM 4. It is safe to assume CRM 2011 is used here.
				//TODO: When the next version of CRM rolls out, will this assumption create problems?
				this.SdkVersion = new Version(5, 0);
			}
		}

		public override string ToString()
		{
			return this.NodeText;
		}

		#region Management Methods
		public void AddPlugin(CrmPlugin plugin)
		{
			if (plugin == null)
			{
				throw new ArgumentNullException("plugin");
			}

			this.m_pluginList.Add(plugin.PluginId, plugin);

			if (this.m_org != null)
			{
				this.Organization.AddPlugin(this, plugin);
			}
		}

		public void ClearPlugins()
		{
			this.m_pluginList.Clear();

			if (this.m_org != null)
			{
				this.Organization.ClearPlugins(this.AssemblyId);
			}
		}

		public void RemovePlugin(Guid pluginId)
		{
			if (this.m_pluginList.ContainsKey(pluginId))
			{
				this.m_pluginList.Remove(pluginId);

				if (this.m_org != null)
				{
					this.Organization.RemovePlugin(this, pluginId);
				}
			}
			else
			{
				throw new ArgumentException("Invalid Plugin Id", "pluginId");
			}
		}
		#endregion
		#endregion

		#region Private Helper Methods
		private string ConvertNullStringToEmpty(string val)
		{
			if (string.IsNullOrEmpty(val))
			{
				return string.Empty;
			}
			else
			{
				return val;
			}
		}
		#endregion

		#region ICrmTreeNode Members
		[XmlIgnore]
		[Browsable(false)]
		public string NodeText
		{
			get
			{
				return string.Format("({0}) {1}", this.NodeTypeLabel, this.Name);
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid NodeId
		{
			get
			{
				return this.AssemblyId;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				if (this.m_pluginList == null || this.m_pluginList.Count == 0)
				{
					return new CrmPlugin[0];
				}
				else
				{
					CrmPlugin[] children = new CrmPlugin[this.m_pluginList.Count];
					this.m_pluginList.Values.CopyTo(children, 0);

					return children;
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeImageType
		{
			get
			{
				return CrmTreeNodeImageType.Assembly;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				return CrmTreeNodeImageType.AssemblySelected;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeType NodeType
		{
			get
			{
				return CrmTreeNodeType.Assembly;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public string NodeTypeLabel
		{
			get
			{
				return "Assembly";
			}
		}
		#endregion

		#region ICrmEntity Members
		[XmlIgnore]
		[Browsable(false)]
		public string EntityType
		{
			get
			{
				return CrmSdk.PluginAssembly.EntityLogicalName;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid EntityId
		{
			get
			{
				return this.AssemblyId;
			}
		}

		public Dictionary<string, object> GenerateCrmEntities()
		{
			Dictionary<string, object> entityList = new Dictionary<string, object>();

			PluginAssembly assembly = new PluginAssembly();
			if (this.AssemblyId != Guid.Empty)
			{
				assembly.PluginAssemblyId = new Guid?();
				assembly["pluginassemblyid"] = this.AssemblyId;
			}

			assembly.SourceType = new OptionSetValue();
			assembly.SourceType.Value = (int)this.SourceType;

			assembly.IsolationMode = new OptionSetValue();
			assembly.IsolationMode.Value = (int)this.IsolationMode;

			assembly.Culture = this.Culture;
			assembly.PublicKeyToken = this.PublicKeyToken;
			assembly.Version = this.Version;
			assembly.Name = this.Name;
			assembly.Description = this.Description;

			if (this.AssemblyId != Guid.Empty)
			{
				assembly.PluginAssemblyId = new Guid?();
				assembly["pluginassemblyid"] = this.AssemblyId;
			}

			switch (this.SourceType)
			{
				case CrmAssemblySourceType.Disk:
					assembly.Path = this.ServerFileName;
					break;
				case CrmAssemblySourceType.Database:
					//Do nothing in this method
					break;
				case CrmAssemblySourceType.GAC:
					//Do nothing
					break;
				default:
					throw new NotImplementedException("SourceType = " + this.SourceType.ToString());
			}

			entityList.Add(PluginAssembly.EntityLogicalName, assembly);

			return entityList;
		}

		private static CrmEntityColumn[] m_entityColumns = null;
		[XmlIgnore]
		[Browsable(false)]
		public static CrmEntityColumn[] Columns
		{
			get
			{
				if (m_entityColumns == null)
				{
					m_entityColumns = new CrmEntityColumn[] { 
						new CrmEntityColumn("Name", "Name", typeof(string)),
						new CrmEntityColumn("Description", "Description", typeof(string)),
						new CrmEntityColumn("ModifiedOn", "Modified On", typeof(string)),
						new CrmEntityColumn("SourceType", "Source", typeof(string)),
						new CrmEntityColumn("Version", "Version", typeof(string)),
						new CrmEntityColumn("Path", "Path", typeof(string)),
						new CrmEntityColumn("PublicKeyToken", "Public Key Token", typeof(string)),
						new CrmEntityColumn("Culture", "Culture", typeof(string)),
						new CrmEntityColumn("IsolationMode", "Isolation Mode", typeof(string)),
						new CrmEntityColumn("Enabled", "Enabled", typeof(bool)),
						new CrmEntityColumn("Id", "AssemblyId", typeof(Guid)),
						};
				}

				return m_entityColumns;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Dictionary<string, object> Values
		{
			get
			{
				Dictionary<string, object> valueList = new Dictionary<string, object>();
				valueList.Add("Id", this.AssemblyId);
				valueList.Add("Description", String.IsNullOrEmpty(this.Description) ? string.Empty : this.Description);
				valueList.Add("Name", this.Name);
				valueList.Add("ModifiedOn",
					(this.ModifiedOn.HasValue ? this.ModifiedOn.ToString() : ""));
				valueList.Add("SourceType", this.SourceType.ToString());
				valueList.Add("Version", ConvertNullStringToEmpty(this.Version));
				valueList.Add("Path", ConvertNullStringToEmpty(this.ServerFileName));
				valueList.Add("PublicKeyToken", ConvertNullStringToEmpty(this.PublicKeyToken));
				valueList.Add("Culture", ConvertNullStringToEmpty(this.Culture));

				if (CrmAssemblyIsolationMode.Sandbox == this.IsolationMode)
				{
					valueList.Add("IsolationMode", "Sandbox");
				}
				else
				{
					valueList.Add("IsolationMode", "None");
				}

				valueList.Add("Enabled", this.Enabled);

				return valueList;
			}
		}

		[XmlIgnore]
		public bool IsSystemCrmEntity
		{
			get
			{
				return this.CustomizationLevel == 0;
			}
		}

		public void UpdateDates(DateTime? createdOn, DateTime? modifiedOn)
		{
			if (createdOn != null)
			{
				this.CreatedOn = createdOn;
			}

			if (modifiedOn != null)
			{
				this.ModifiedOn = modifiedOn;
			}
		}
		#endregion

		#region ICloneable Members
		public object Clone()
		{
			return this.Clone(true);
		}

		public CrmPluginAssembly Clone(bool includeOrganization)
		{
			CrmPluginAssembly newAssembly;
			if (includeOrganization)
			{
				newAssembly = new CrmPluginAssembly(this.m_org);
			}
			else
			{
				newAssembly = new CrmPluginAssembly(null);
			}

			newAssembly.m_assemblyId = this.m_assemblyId;
			newAssembly.m_Name = this.m_Name;
			newAssembly.CreatedOn = this.CreatedOn;
			newAssembly.Culture = this.Culture;
			newAssembly.CustomizationLevel = this.m_customizationLevel;
			newAssembly.Enabled = this.Enabled;
			newAssembly.IsolationMode = this.IsolationMode;
			newAssembly.ModifiedOn = this.ModifiedOn;
			newAssembly.ServerFileName = this.ServerFileName;
			newAssembly.PublicKeyToken = this.PublicKeyToken;
			newAssembly.SourceType = this.SourceType;
			newAssembly.Version = this.Version;

			//Create a new plugin list
			Dictionary<Guid, CrmPlugin> newPluginList = new Dictionary<Guid, CrmPlugin>();
			foreach (CrmPlugin plugin in this.m_pluginList.Values)
			{
				//Clone the plugin
				CrmPlugin clonedPlugin = (CrmPlugin)plugin.Clone(includeOrganization);

				//Add the plugin to the new list
				newPluginList.Add(clonedPlugin.PluginId, clonedPlugin);
			}

			//Assign the list to the new object
			newAssembly.m_pluginList = newPluginList;

			return newAssembly;
		}
		#endregion
	}

	public enum CrmAssemblySourceType
	{
		Database = 0,
		Disk = 1,
		GAC = 2
	}

	public enum CrmAssemblyIsolationMode
	{
		None = 1,
		Sandbox = 2
	}
}
