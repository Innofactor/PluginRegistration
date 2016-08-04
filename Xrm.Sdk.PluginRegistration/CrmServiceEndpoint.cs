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

namespace Xrm.Sdk.PluginRegistration
{
    using Controls;
    using Entities;
    using Microsoft.Xrm.Sdk;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Xml.Serialization;
    using Wrappers;

    public sealed class CrmServiceEndpoint : ICrmEntity, ICrmTreeNode
    {
        public readonly Guid ServiceBusPlugin = new Guid("EF521E63-CD2B-4170-99F6-447466A7161E");
        public const string ServiceBusPluginName = "Microsoft.Crm.ServiceBus.ServiceBusPlugin";
        public const string ServiceBusPluginAssemblyName = "Microsoft.Crm.ServiceBus";
        public readonly Guid ServiceBusPluginAssembly = new Guid("A430B185-D19D-428C-B156-5EBE3F391564");

        private CrmOrganization m_org = null;

        public CrmServiceEndpoint(CrmOrganization org)
        {
            this.m_org = org;
        }

        public CrmServiceEndpoint(CrmOrganization org, ServiceEndpoint serviceEndpoint)
            : this(org)
        {
            this.RefreshFromServiceEndpoint(serviceEndpoint);
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string Name
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string Description
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string SolutionNamespace
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public string Path
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public CrmServiceEndpointContract Contract
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public CrmServiceEndpointUserClaim UserClaim
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public CrmServiceEndpointConnectionMode ConnectionMode
        {
            get;
            set;
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public Guid ServiceEndpointId
        {
            get;
            set;
        }

        [Browsable(false)]
        public Guid PluginId
        {
            get { return ServiceBusPlugin; }
        }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? CreatedOn { get; private set; }

        [Category("Information"), Browsable(true), ReadOnly(true)]
        public DateTime? ModifiedOn { get; private set; }

        [Category("Information"), Browsable(false), ReadOnly(true)]
        public String AcsManagementKey
        {
            get;
            set;
        }

        [Category("Information"), Browsable(false), ReadOnly(true)]
        public String AcsPublicCertificate
        {
            get;
            set;
        }

        [Category("Information"), Browsable(false), ReadOnly(true)]
        public String AcsIssuerName
        {
            get;
            set;
        }

        #region ICrmEntity Members

        [Browsable(false)]
        public bool IsSystemCrmEntity
        {
            get { return false; }
        }

        [Browsable(false)]
        public string EntityType
        {
            get { return Entities.ServiceEndpoint.EntityLogicalName; }
        }

        [Browsable(false)]
        public Guid EntityId
        {
            get { return ServiceEndpointId; }
        }

        public Dictionary<string, object> GenerateCrmEntities()
        {
            Dictionary<string, object> entityList = new Dictionary<string, object>();

            ServiceEndpoint serviceEndPoint = new ServiceEndpoint();
            if (this.ServiceEndpointId != Guid.Empty)
            {
                serviceEndPoint.Id = this.ServiceEndpointId;
            }

            serviceEndPoint.ConnectionMode = new OptionSetValue();
            serviceEndPoint.ConnectionMode.Value = (int)this.ConnectionMode;

            serviceEndPoint.Contract = new OptionSetValue();
            serviceEndPoint.Contract.Value = (int)this.Contract;

            serviceEndPoint.UserClaim = new OptionSetValue((int)this.UserClaim);

            serviceEndPoint.Description = this.Description;
            serviceEndPoint.Name = this.Name;
            serviceEndPoint.Path = this.Path;
            serviceEndPoint.SolutionNamespace = this.SolutionNamespace;

            entityList.Add(ServiceEndpoint.EntityLogicalName, serviceEndPoint);

            return entityList;
        }

        public void RefreshFromServiceEndpoint(ServiceEndpoint serviceEndPoint)
        {
            if (serviceEndPoint == null)
            {
                throw new ArgumentNullException("serviceEndPoint");
            }

            this.Name = serviceEndPoint.Name;
            this.Description = serviceEndPoint.Description;
            this.Path = serviceEndPoint.Path;
            this.SolutionNamespace = serviceEndPoint.SolutionNamespace;

            if (serviceEndPoint.ServiceEndpointId != Guid.Empty)
            {
                this.ServiceEndpointId = serviceEndPoint.ServiceEndpointId.Value;
            }

            if (serviceEndPoint.CreatedOn != null && (serviceEndPoint.CreatedOn.HasValue))
            {
                this.CreatedOn = serviceEndPoint.CreatedOn.Value;
            }

            if (serviceEndPoint.ModifiedOn != null && (serviceEndPoint.ModifiedOn.HasValue))
            {
                this.ModifiedOn = serviceEndPoint.ModifiedOn.Value;
            }

            if (serviceEndPoint.ConnectionMode != null)
            {
                this.ConnectionMode = (CrmServiceEndpointConnectionMode)Enum.ToObject(typeof(CrmServiceEndpointConnectionMode), serviceEndPoint.ConnectionMode.Value);
            }

            if (serviceEndPoint.Contract != null)
            {
                this.Contract = (CrmServiceEndpointContract)Enum.ToObject(typeof(CrmServiceEndpointContract),
                    serviceEndPoint.Contract.Value);
            }
            if (serviceEndPoint.UserClaim != null)
            {
                this.UserClaim = (CrmServiceEndpointUserClaim)Enum.ToObject(typeof(CrmServiceEndpointUserClaim),
                    serviceEndPoint.UserClaim.Value);
            }
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
                        new CrmEntityColumn("Id", "ServiceEndpointId", typeof(Guid)),
                        new CrmEntityColumn("Name", "Name", typeof(string)),
                        new CrmEntityColumn("Description", "Description", typeof(string)),
                        new CrmEntityColumn("SolutionNamespace", "Solution Namespace", typeof(string)),
                        new CrmEntityColumn("Path", "Path", typeof(string)),
                        new CrmEntityColumn("Contract", "Path", typeof(string)),
                        new CrmEntityColumn("UserClaim", "Path", typeof(string)),
                        new CrmEntityColumn("ConnectionMode", "Connection Mode", typeof(string)),
                        new CrmEntityColumn("ModifiedOn", "Modified On", typeof(string)),
                        new CrmEntityColumn("Isolatable", "Isolatable", typeof(string)),
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
                valueList.Add("Id", this.ServiceEndpointId.ToString());
                valueList.Add("Name", this.Name);
                valueList.Add("Description", this.Description);
                valueList.Add("SolutionNamespace", this.SolutionNamespace);
                valueList.Add("Path", this.Path);
                valueList.Add("Contract", this.Contract.ToString());
                valueList.Add("UserClaim", this.UserClaim.ToString());
                valueList.Add("ConnectionMode", this.ConnectionMode.ToString());
                valueList.Add("ModifiedOn", this.ModifiedOn);
                valueList.Add("CreatedOn", this.CreatedOn);
                return valueList;
            }
        }

        public void UpdateDates(DateTime? createdOn, DateTime? modifiedOn)
        {
            if (createdOn != null)
            {
                CreatedOn = createdOn;
            }

            if (modifiedOn != null)
            {
                ModifiedOn = modifiedOn;
            }
        }

        [Browsable(false)]
        public CrmEntityDictionary<CrmPluginStep> Steps
        {
            get
            {
                Dictionary<Guid, CrmPluginStep> steps = new Dictionary<Guid, CrmPluginStep>();

                foreach (CrmPluginStep step in m_org.Steps.Values)
                {
                    if (step.ServiceBusConfigurationId == this.ServiceEndpointId)
                    {
                        steps.Add(step.StepId, step);
                    }
                }
                return new CrmEntityDictionary<CrmPluginStep>(steps);
            }
        }

        #endregion ICrmEntity Members

        #region ICrmTreeNode Members

        [Browsable(false)]
        public Guid NodeId
        {
            get { return ServiceEndpointId; }
        }

        [Browsable(false)]
        public CrmTreeNodeType NodeType
        {
            get { return CrmTreeNodeType.ServiceEndpoint; }
        }

        [Browsable(false)]
        public string NodeTypeLabel
        {
            get { return "ServiceEndpoint"; }
        }

        [Browsable(false)]
        public ICrmTreeNode[] NodeChildren
        {
            get
            {
                List<CrmPluginStep> steps = new List<CrmPluginStep>();

                foreach (CrmPluginStep step in m_org.Steps.Values)
                {
                    if (step.ServiceBusConfigurationId == this.ServiceEndpointId)
                    {
                        steps.Add(step);
                    }
                }
                return steps.ToArray();
            }
        }

        [Browsable(false)]
        public string NodeText
        {
            get
            {
                return string.Format("({0}) {1}", this.NodeTypeLabel, string.IsNullOrWhiteSpace(this.Name) ? this.Description : this.Name);
            }
        }

        [Browsable(false)]
        public CrmTreeNodeImageType NodeImageType
        {
            get { return CrmTreeNodeImageType.ServiceEndpoint; }
        }

        [Browsable(false)]
        public CrmTreeNodeImageType NodeSelectedImageType
        {
            get { return CrmTreeNodeImageType.ServiceEndpointSelected; }
        }

        #endregion ICrmTreeNode Members
    }

    public enum CrmServiceEndpointContract
    {
        OneWay = 1,
        Queue = 2,
        Rest = 3,
        TwoWay = 4
    }

    public enum CrmServiceEndpointUserClaim
    {
        None = 1,
        UserId = 2,
        UserInfo = 3
    }

    public enum CrmServiceEndpointConnectionMode
    {
        Normal = 1,
        Federated = 2
    }
}