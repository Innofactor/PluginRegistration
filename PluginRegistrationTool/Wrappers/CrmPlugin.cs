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
    using Microsoft.Xrm.Sdk;
    using PluginRegistrationTool.Controls;
    using PluginRegistrationTool.Entities;

	[Serializable]
	public sealed class CrmPlugin : ICrmEntity, ICrmTreeNode, ICloneable
	{
		private const string V3CalloutProxyTypeName = "Microsoft.Crm.Extensibility.V3CalloutProxyPlugin";
		public const string RelationshipTypeToStep = "plugintype_sdkmessageprocessingstep";

		private string m_typeName = null;
		private bool m_friendlyNameIgnore;
		private string m_friendlyName;
		private CrmOrganization m_org;
		private CrmPluginType m_plugType = CrmPluginType.Plugin;
		private Guid m_pluginId = Guid.Empty;
		private Guid m_pluginAssemblyId = Guid.Empty;
		private string m_assemblyName = null;
		private DateTime? m_createdOn = null;
		private DateTime? m_modifiedOn = null;
		private int m_customizationLevel = 1;
		private CrmPluginIsolatable m_isolatable = CrmPluginIsolatable.Unknown;
		private string m_name = null;
		private string m_workflowActivityGroupName = null;

		private CrmEntityDictionary<CrmPluginStep> m_stepReadOnlyList = null;
		private Dictionary<Guid, CrmPluginStep> m_stepList = new Dictionary<Guid, CrmPluginStep>();

		public CrmPlugin(CrmOrganization org)
		{
			this.m_org = org;
			this.FriendlyName = Guid.NewGuid().ToString();
		}

		public CrmPlugin(CrmOrganization org, Guid pluginId, Guid assemblyId, string assemblyName, string friendlyName,
			string typeName, CrmPluginType type, CrmPluginIsolatable isolatable, DateTime? createdOn, DateTime? modifiedOn)
			: this(org)
		{
			this.PluginId = pluginId;
			this.AssemblyId = assemblyId;
			this.AssemblyName = assemblyName;
			this.TypeName = typeName;
			this.Name = typeName;
			this.FriendlyName = friendlyName;
			this.PluginType = type;
			this.Isolatable = isolatable;
			this.UpdateDates(createdOn, modifiedOn);
		}

		public CrmPlugin(CrmOrganization org, PluginType type)
			: this(org)
		{
			this.RefreshFromPluginType(type);
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

					foreach (CrmPluginStep step in this.m_stepList.Values)
					{
						if (step.Organization == null)
						{
							step.Organization = m_org;
						}

						this.Organization.AddStep(this, step);
					}
				}
				else
				{
					throw new NotSupportedException("Cannot change the Organization once it has been set");
				}
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string AssemblyName
		{
			get
			{
				return this.m_assemblyName;
			}

			set
			{
				this.m_assemblyName = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public string TypeName
		{
			get
			{
				return this.m_typeName;
			}

			set
			{
				this.m_typeName = value;
			}
		}

		[Category("Editable"), Browsable(true), ReadOnly(false)]
		public string Description
		{
			get;
			set;
		}

		[Category("Editable"), Browsable(true), ReadOnly(false)]
		public string FriendlyName
		{
			get
			{
				return this.m_friendlyName;
			}
			set
			{
				this.m_friendlyName = this.GenerateFriendlyName(value, out this.m_friendlyNameIgnore);
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginType PluginType
		{
			get
			{
				return this.m_plugType;
			}
			set
			{
				this.m_plugType = value;
			}
		}

		/// <summary>
		/// Retrieves the Created On date of the entity. To update, see UpdateDates.
		/// </summary>
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public DateTime? CreatedOn
		{
			get
			{
				return this.m_createdOn;
			}
		}

		/// <summary>
		/// Retrieves the Modified On date of the entity. To update, see UpdateDates.
		/// </summary>
		[Category("Information"), Browsable(true), ReadOnly(true)]
		public DateTime? ModifiedOn
		{
			get
			{
				return this.m_modifiedOn;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public CrmPluginIsolatable Isolatable
		{
			get
			{
				return this.m_isolatable;
			}

			set
			{
				this.m_isolatable = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid PluginId
		{
			get
			{
				return this.m_pluginId;
			}
			set
			{
				if (value == this.m_pluginId)
				{
					return;
				}

				this.m_pluginId = value;

				foreach (CrmPluginStep step in this.m_stepList.Values)
				{
					step.PluginId = value;
				}
			}
		}

		[Category("Editable"), Browsable(true), ReadOnly(false)]
		public string Name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				m_name = value;
			}
		}

		[Category("Editable"), Browsable(true), ReadOnly(false)]
		public string WorkflowActivityGroupName
		{
			get
			{
				return this.m_workflowActivityGroupName;
			}
			set
			{
				m_workflowActivityGroupName = value;
			}
		}

		[Category("Information"), Browsable(true), ReadOnly(true)]
		public Guid AssemblyId
		{
			get
			{
				return this.m_pluginAssemblyId;
			}
			set
			{
				if (value == this.m_pluginAssemblyId)
				{
					return;
				}

				this.m_pluginAssemblyId = value;

				foreach (CrmPluginStep step in this.m_stepList.Values)
				{
					step.AssemblyId = value;
				}
			}
		}

		[Browsable(false)]
		public CrmPluginStep this[Guid stepId]
		{
			get
			{
				return this.m_stepList[stepId];
			}
		}

		[Browsable(false)]
		public CrmEntityDictionary<CrmPluginStep> Steps
		{
			get
			{
				if (this.m_stepReadOnlyList == null)
				{
					this.m_stepReadOnlyList = new CrmEntityDictionary<CrmPluginStep>(this.m_stepList);
				}

				return this.m_stepReadOnlyList;
			}
		}

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

				this.m_customizationLevel = value;
			}
		}

		[Browsable(false)]
		public bool IsProfilerPlugin { get; set; }
		#endregion

		#region Public Helper Methods
		public void RefreshFromPluginType(PluginType type)
		{

			if (type == null)
			{
				throw new ArgumentNullException("type");
			}

			if (type.AssemblyName != null)
			{
				this.AssemblyName = type.AssemblyName;
			}

			if (type.TypeName != null)
			{
				this.TypeName = type.TypeName;
			}

			if (type.FriendlyName != null)
			{
				this.FriendlyName = type.FriendlyName;
			}

			if (type.Name != null)
			{
				this.Name = type.Name;
			}

			this.Description = type.Description;

			if (type.PluginTypeId != null)
			{
				this.PluginId = type.PluginTypeId.Value;
			}

			if (type.PluginAssemblyId != null)
			{
				this.AssemblyId = type.PluginAssemblyId.Id;
			}

			if (type.CustomizationLevel != null)
			{
				this.CustomizationLevel = type.CustomizationLevel.Value;
			}

			if (type.CreatedOn != null && (type.CreatedOn.HasValue))
			{
				this.m_createdOn = type.CreatedOn.Value;
			}

			if (type.ModifiedOn != null && (type.ModifiedOn.HasValue))
			{
				this.m_modifiedOn = type.ModifiedOn.Value;
			}

			if (type.IsWorkflowActivity != null && (type.IsWorkflowActivity.HasValue))
			{
				if (type.IsWorkflowActivity.Value)
				{
					this.PluginType = CrmPluginType.WorkflowActivity;
				}
				else
				{
					this.PluginType = CrmPluginType.Plugin;
				}
			}

			this.WorkflowActivityGroupName = type.WorkflowActivityGroupName;
		}

		public string GenerateNodeText(string newFriendlyName)
		{
			bool ignoreFriendlyName;
			string newText = this.GenerateFriendlyName(newFriendlyName, out ignoreFriendlyName);

			if (ignoreFriendlyName)
			{
				return this.TypeName;
			}
			else
			{
				return newText;
			}
		}

		public override string ToString()
		{
			return this.NodeText;
		}

		#region Management Methods
		public void AddStep(CrmPluginStep step)
		{
			if (step == null)
			{
				throw new ArgumentNullException("step");
			}

			this.m_stepList.Add(step.StepId, step);

			if (this.Organization != null)
			{
				this.Organization.AddStep(this, step);
			}
		}

		public void ClearSteps()
		{
			this.m_stepList.Clear();

			if (this.Organization != null)
			{
				this.Organization.ClearSteps(this.PluginId);
			}
		}

		public void RemoveStep(Guid stepId)
		{
			if (this.m_stepList.ContainsKey(stepId))
			{
				this.m_stepList.Remove(stepId);

				if (this.Organization != null)
				{
					this.Organization.RemoveStep(this, stepId);
				}
			}
			else
			{
				throw new ArgumentException("Invalid Step Id", "stepId");
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

		private string GenerateFriendlyName(string newName, out bool ignoreFriendlyName)
		{
			if (string.IsNullOrEmpty(newName) ||
				string.Equals(this.m_typeName, newName, StringComparison.InvariantCultureIgnoreCase))
			{
				ignoreFriendlyName = true;
				if (this.m_friendlyNameIgnore)
				{
					return this.m_friendlyName;
				}
				else
				{
					return Guid.NewGuid().ToString();
				}
			}
			else
			{
				try
				{
					new Guid(newName);
					ignoreFriendlyName = true;
				}
				catch
				{
					ignoreFriendlyName = false;
				}

				return newName;
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
				if (this.IsProfilerPlugin)
				{
					return "Plug-in Profiler";
				}

				string format;
				if (CrmPluginIsolatable.Yes == this.Isolatable)
				{
					format = "({0}) {2} - Isolatable";
				}
				else if (string.IsNullOrWhiteSpace(this.WorkflowActivityGroupName) ||
					this.WorkflowActivityGroupName.StartsWith(this.AssemblyName + " (", StringComparison.Ordinal))
				{
					format = "({0}) {2}";
				}
				else
				{
					format = "({0}) {1}: {2}";
				}

				return string.Format(format, this.NodeTypeLabel, this.WorkflowActivityGroupName, string.IsNullOrWhiteSpace(this.Name) ? this.Description : this.Name);
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid NodeId
		{
			get
			{
				return this.m_pluginId;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public ICrmTreeNode[] NodeChildren
		{
			get
			{
				if (this.m_stepList == null || this.m_stepList.Count == 0)
				{
					return new CrmPluginStep[0];
				}
				else
				{
					CrmPluginStep[] children = new CrmPluginStep[this.m_stepList.Count];
					this.m_stepList.Values.CopyTo(children, 0);

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
				if (this.IsProfilerPlugin)
				{
					return CrmTreeNodeImageType.PluginProfiler;
				}
				else
				{
					switch (this.m_plugType)
					{
						case CrmPluginType.Plugin:
							return CrmTreeNodeImageType.Plugin;

						case CrmPluginType.WorkflowActivity:
							return CrmTreeNodeImageType.WorkflowActivity;

						default:
							throw new NotImplementedException("PluginType = " + this.m_plugType);
					}
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeImageType NodeSelectedImageType
		{
			get
			{
				if (this.IsProfilerPlugin)
				{
					return CrmTreeNodeImageType.PluginProfilerSelected;
				}
				else
				{
					switch (this.m_plugType)
					{
						case CrmPluginType.Plugin:
							return CrmTreeNodeImageType.PluginSelected;

						case CrmPluginType.WorkflowActivity:
							return CrmTreeNodeImageType.WorkflowActivitySelected;

						default:
							throw new NotImplementedException("PluginType = " + this.m_plugType);
					}
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public CrmTreeNodeType NodeType
		{
			get
			{
				switch (this.m_plugType)
				{
					case CrmPluginType.Plugin:
						return CrmTreeNodeType.Plugin;

					case CrmPluginType.WorkflowActivity:
						return CrmTreeNodeType.WorkflowActivity;

					default:
						throw new NotImplementedException("PluginType = " + this.m_plugType);
				}
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public string NodeTypeLabel
		{
			get
			{
				switch (this.PluginType)
				{
					case CrmPluginType.Plugin:
						return "Plugin";
					case CrmPluginType.WorkflowActivity:
						return "Workflow Activity";
					default:
						throw new NotImplementedException("PluginType = " + this.PluginType.ToString());
				}
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
				return Entities.PluginType.EntityLogicalName;
			}
		}

		[XmlIgnore]
		[Browsable(false)]
		public Guid EntityId
		{
			get
			{
				return this.m_pluginId;
			}
		}

		public Dictionary<string, object> GenerateCrmEntities()
		{
			PluginType plugin = new PluginType();
			if (this.PluginId != Guid.Empty)
			{
				plugin["plugintypeid"] = new Guid?();
				plugin["plugintypeid"] = this.PluginId;
			}

			if (this.AssemblyId != Guid.Empty)
			{
				plugin.PluginAssemblyId = new EntityReference();
				plugin.PluginAssemblyId.LogicalName = PluginAssembly.EntityLogicalName;
				plugin.PluginAssemblyId.Id = this.AssemblyId;
			}
			else
			{
				throw new ArgumentException("PluginAssembly has not been set", "plugin");
			}

			plugin.TypeName = this.TypeName;
			plugin.FriendlyName = this.m_friendlyName;

			plugin.Name = this.Name;
			plugin.Description = this.Description;
			plugin.WorkflowActivityGroupName = this.WorkflowActivityGroupName;

			Dictionary<string, object> entityList = new Dictionary<string, object>();
			entityList.Add(Entities.PluginType.EntityLogicalName, plugin);

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
						new CrmEntityColumn("Assembly", "Assembly", typeof(string)),
						new CrmEntityColumn("ModifiedOn", "Modified On", typeof(string)),
						new CrmEntityColumn("FriendlyName", "Friendly Name", typeof(string)),
						new CrmEntityColumn("Name", "Name", typeof(string)),
						new CrmEntityColumn("TypeName", "Type Name", typeof(string)),
						new CrmEntityColumn("WorkflowActivityGroupName", "WorkflowActivityGroupName", typeof(string)),
						new CrmEntityColumn("Description", "Description", typeof(string)),
						new CrmEntityColumn("Isolatable", "Isolatable", typeof(string)),
						new CrmEntityColumn("Id", "PluginId", typeof(Guid)) };
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
				valueList.Add("Id", this.PluginId);
				valueList.Add("Assembly", this.AssemblyName);
				valueList.Add("ModifiedOn", this.ModifiedOn);
				valueList.Add("FriendlyName", this.FriendlyName);
				valueList.Add("Name", this.Name);
				valueList.Add("TypeName", this.TypeName);
				valueList.Add("WorkflowActivityGroupName", this.WorkflowActivityGroupName);
				valueList.Add("Isolatable", this.Isolatable.ToString());
				valueList.Add("Description", this.Description);
				return valueList;
			}
		}

		[XmlIgnore]
		[Category("Information"), Browsable(true), ReadOnly(true)]
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
				this.m_createdOn = createdOn;
			}

			if (modifiedOn != null)
			{
				this.m_modifiedOn = modifiedOn;
			}
		}
		#endregion

		#region ICloneable Members
		public object Clone()
		{
			return this.Clone(true);
		}

		public CrmPlugin Clone(bool includeOrganization)
		{
			CrmPlugin newPlugin;
			if (includeOrganization)
			{
				newPlugin = new CrmPlugin(this.m_org);
			}
			else
			{
				newPlugin = new CrmPlugin(null);
			}

			newPlugin.m_assemblyName = this.m_assemblyName;
			newPlugin.m_createdOn = this.m_createdOn;
			newPlugin.m_customizationLevel = this.m_customizationLevel;
			newPlugin.m_friendlyName = this.m_friendlyName;
			newPlugin.m_friendlyNameIgnore = this.m_friendlyNameIgnore;
			newPlugin.m_isolatable = this.m_isolatable;
			newPlugin.m_modifiedOn = this.m_modifiedOn;
			newPlugin.m_pluginAssemblyId = this.m_pluginAssemblyId;
			newPlugin.m_pluginId = this.m_pluginId;
			newPlugin.m_plugType = this.m_plugType;
			newPlugin.m_typeName = this.m_typeName;

			//Create a new step list
			Dictionary<Guid, CrmPluginStep> newStepList = new Dictionary<Guid, CrmPluginStep>();
			foreach (CrmPluginStep step in this.m_stepList.Values)
			{
				//Clone the step
				CrmPluginStep clonedStep = (CrmPluginStep)step.Clone(includeOrganization);

				//Add the step to the new list
				newStepList.Add(clonedStep.StepId, clonedStep);
			}

			//Assign the list to the new object
			newPlugin.m_stepList = newStepList;

			return newPlugin;
		}
		#endregion
	}

	public enum CrmPluginType
	{
		Plugin,
		WorkflowActivity
	}

	public enum CrmPluginIsolatable
	{
		Yes,
		No,
		Unknown
	}
}
