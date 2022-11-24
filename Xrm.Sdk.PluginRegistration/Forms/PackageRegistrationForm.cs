﻿using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Xrm.Sdk.PluginRegistration.Helpers;
using Xrm.Sdk.PluginRegistration.Models;
using Xrm.Sdk.PluginRegistration.Wrappers;

namespace Xrm.Sdk.PluginRegistration.Forms
{
    public partial class PackageRegistrationForm : Form
    {
        #region Private Fields

        private readonly CrmOrganization _org;
        private readonly IOrganizationService _service;
        private PluginAssemblyFileMapping _mapping;
        private List<PluginAssemblyFileMapping> _mappings;
        private string content = null;
        private MainControl mainControl;
        private CrmPluginPackage package;

        #endregion Private Fields

        #region Public Constructors

        public PackageRegistrationForm(CrmOrganization org, MainControl mainControl, List<PluginAssemblyFileMapping> mappings)
        {
            InitializeComponent();
            this.mainControl = mainControl;
            _service = org.OrganizationService;
            _org = org;
            _mappings = mappings;
            LoadSolutions();
        }

        public PackageRegistrationForm(CrmOrganization organization, MainControl mainControl, CrmPluginPackage package, List<PluginAssemblyFileMapping> mappings)
        {
            InitializeComponent();
            _org = organization;
            _service = organization.OrganizationService;

            this.mainControl = mainControl;
            this.package = package;
            _mappings = mappings;

            Text = "Update Package";
            btnImport.Text = "Update";
            pnlSolution.Visible = false;
            panel1.Visible = false;

            _mapping = _mappings.FirstOrDefault(m => m.PluginAssemblyName == $"{package.Name}" && m.ConnectionId == organization.ConnectionDetail.ConnectionId.Value);

            if (_mapping == null)
            {
                _mapping = mappings.FirstOrDefault(m => m.PluginAssemblyName == $"{package.Name}");

                if (_mapping != null)
                {
                    mappings.Remove(_mapping);
                    _mapping = new PluginAssemblyFileMapping
                    {
                        ConnectionId = _org.ConnectionDetail.ConnectionId.Value,
                        PluginAssemblyName = _mapping.PluginAssemblyName,
                        FilePath = _mapping.FilePath
                    };
                    _mappings.Add(_mapping);
                }
            }

            if (_mapping != null)
            {
                _mapping.ConnectionId = organization.ConnectionDetail.ConnectionId.Value;
                txtPluginPackageFile.Text = _mapping.FilePath;
            }

            txtPrefix.Text = package.Name.Split('_')[0];
            txtName.Text = package.Name.Split('_')[1];
            txtVersion.Text = package.Version;

            AnalyzePackage();

            Height = Height - 50;
        }

        #endregion Public Constructors

        #region Private Methods

        private void AnalyzePackage()
        {
            if (!File.Exists(txtPluginPackageFile.Text))
            {
                MessageBox.Show(this, $"File not found : {txtPluginPackageFile.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = null, version = null;

            using (Package p = Package.Open(txtPluginPackageFile.Text, FileMode.Open))
            {
                foreach (var part in p.GetParts())
                {
                    if (part.Uri.ToString().EndsWith(".nuspec"))
                    {
                        using (var stream = part.GetStream())
                        {
                            XmlTextReader xReader = new XmlTextReader(stream);
                            var doc = new XmlDocument();
                            doc.Load(xReader);

                            XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                            nsmgr.AddNamespace("ns", "http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd");

                            var metadata = doc.SelectSingleNode("ns:package/ns:metadata", nsmgr);
                            id = metadata.SelectSingleNode("ns:id", nsmgr).InnerText;
                            version = metadata.SelectSingleNode("ns:version", nsmgr).InnerText;
                        }
                    }
                }
            }

            using (FileStream reader = new FileStream(txtPluginPackageFile.Text, FileMode.Open))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    reader.CopyTo(ms);

                    content = Convert.ToBase64String(ms.ToArray());
                }
            }

            txtName.Text = id;
            txtVersion.Text = version;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Title = "Select a Nuget package",
                Filter = "Nuget package (*.nupkg)|*.nupkg",
                Multiselect = false
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                txtPluginPackageFile.Text = ofd.FileName;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            var name = $"{txtPrefix.Text}_{txtName.Text }";
            string solutionUniqueName = null;
            Guid solutionId = Guid.Empty;

            if (((Button)sender).Text == "Import")
            {
                var solution = (Solution)cbbSolution.SelectedItem;
                solutionUniqueName = solution.Record.GetAttributeValue<string>("uniquename");
                solutionId = solution.Record.Id;
            }

            Entity pluginPackage;
            if (package != null)
            {
                pluginPackage = new Entity("pluginpackage")
                {
                    Id = package.PackageId,
                    Attributes =
                    {
                          {"content", content },
                    }
                };
                SetWorkingStatus(true, true);
            }
            else
            {
                pluginPackage = new Entity("pluginpackage")
                {
                    Attributes =
                    {
                        {"name", name},
                        {"content",content },
                        {"version",txtVersion.Text },
                        {"solutionid", solutionId },
                        {"uniquename", name },
                    }
                };
                SetWorkingStatus(true);
            }

            bool isCreate = false;
            var worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += (bw, evt) =>
            {
                if (pluginPackage.Id != Guid.Empty)
                {
                    _service.Update(pluginPackage);
                }
                else
                {
                    isCreate = true;
                    pluginPackage.Id = _service.Create(pluginPackage);

                    package = new CrmPluginPackage(_org, pluginPackage.Id, name, DateTime.Now, DateTime.Now, txtVersion.Text, solutionId);

                    if (!_org.Packages.ContainsKey(package.PackageId))
                    {
                        _org.AddPackage(package);
                    }
                }

                if (chkAddToSolution.Checked)
                {
                    ((BackgroundWorker)bw).ReportProgress(0, "Adding to solution...");
                    _service.Execute(new AddSolutionComponentRequest
                    {
                        AddRequiredComponents = false,
                        ComponentId = pluginPackage.Id,
                        ComponentType = 10090,
                        SolutionUniqueName = solutionUniqueName
                    });
                }

                ((BackgroundWorker)bw).ReportProgress(0, "Reloading assemblies...");
                OrganizationHelper.LoadAssemblies(_org, pluginPackage.Id);
                ((BackgroundWorker)bw).ReportProgress(0, "Reloading plugins...");
                OrganizationHelper.LoadPlugins(_org, out _, pluginPackage.Id);
            };
            worker.RunWorkerCompleted += (bw, evt) =>
            {
                SetWorkingStatus(false);
                if (evt.Error != null)
                {
                    MessageBox.Show(this, $"Error when registering package : {evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (isCreate)
                {
                    mainControl.AddPackage(package);
                }
                else
                {
                    mainControl.RefreshPackage(package, true);
                }

                if (_mapping == null)
                {
                    _mapping = new PluginAssemblyFileMapping();
                    _mappings.Add(_mapping);
                }
                _mapping.FilePath = txtPluginPackageFile.Text;
                _mapping.PluginAssemblyName = name;
                _mapping.ConnectionId = _org.ConnectionDetail.ConnectionId.Value;

                DialogResult = DialogResult.OK;
                Close();
            };
            worker.ProgressChanged += (bw, evt) =>
            {
                lblProgress.Text = evt.UserState.ToString();
            };
            worker.RunWorkerAsync();
        }

        private void cbbSolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbSolution.SelectedItem == null) return;

            txtPrefix.Text = ((Solution)cbbSolution.SelectedItem).Prefix;
        }

        private void LoadSolutions()
        {
            var bw = new BackgroundWorker();
            bw.DoWork += (sender, e) =>
            {
                QueryExpression qe = new QueryExpression("solution");
                qe.Distinct = true;
                qe.ColumnSet = Solution.Columns;
                qe.Criteria = new FilterExpression();
                qe.Criteria.AddCondition(new ConditionExpression("ismanaged", ConditionOperator.Equal, false));
                qe.Criteria.AddCondition(new ConditionExpression("isvisible", ConditionOperator.Equal, true));
                qe.Criteria.AddCondition(new ConditionExpression("uniquename", ConditionOperator.NotEqual, "Default"));
                qe.LinkEntities.Add(new LinkEntity
                {
                    LinkFromEntityName = "solution",
                    LinkFromAttributeName = "publisherid",
                    LinkToAttributeName = "publisherid",
                    LinkToEntityName = "publisher",
                    EntityAlias = "publisher",
                    Columns = new ColumnSet("customizationprefix")
                });
                qe.AddOrder("friendlyname", OrderType.Ascending);
                e.Result = _service.RetrieveMultiple(qe);
            };
            bw.RunWorkerCompleted += (sender, e) =>
            {
                cbbSolution.Items.AddRange(((EntityCollection)e.Result).Entities.Select(r => new Solution(r)).ToArray());
                cbbSolution.SelectedIndex = 0;

                if (package != null)
                {
                    var solution = cbbSolution.Items.Cast<Solution>().FirstOrDefault(s => s.Record.Id == package.SolutionId);
                    if (solution != null)
                    {
                        cbbSolution.SelectedItem = solution;
                    }
                }
            };
            bw.RunWorkerAsync();
        }

        private void SetWorkingStatus(bool working, bool isUpdate = false)
        {
            lblProgress.Text = working ? (isUpdate ? "Updating package..." : "Registering package...") : "";
            btnBrowse.Enabled = !working;
            btnImport.Enabled = !working;
            btnClose.Enabled = !working;
            cbbSolution.Enabled = !working;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = txtPrefix.Text.Length > 0 && txtName.Text.Length > 0
                && txtPluginPackageFile.Text.Length > 0 && File.Exists(txtPluginPackageFile.Text);

            if (sender == txtPluginPackageFile)
            {
                AnalyzePackage();
            }
        }

        #endregion Private Methods
    }
}