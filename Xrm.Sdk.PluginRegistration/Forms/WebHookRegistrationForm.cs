using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Xrm.Sdk.PluginRegistration.Helpers;
using Xrm.Sdk.PluginRegistration.Wrappers;
using XrmToolBox.Extensibility;

namespace Xrm.Sdk.PluginRegistration.Forms
{
    public partial class WebHookRegistrationForm : Form
    {
        private CrmOrganization m_org;
        private CrmServiceEndpoint m_webhook;
        private MainControl m_orgControl;

        public WebHookRegistrationForm(CrmOrganization org, MainControl orgControl, CrmServiceEndpoint webhook)
        {
            m_org = org ?? throw new ArgumentNullException("org");
            m_webhook = webhook;
            m_orgControl = orgControl;

            InitializeComponent();

            if (m_webhook != null)
            {
                txtName.Text = m_webhook.Name;
                txtEndpointUrl.Text = m_webhook.Url;
                cmbAuth.SelectedItem = m_webhook.AuthType.ToString();
            }
            else
            {
                cmbAuth.SelectedItem = CrmServiceEndpointAuthType.HttpHeader.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAuthMethod = (string)cmbAuth.SelectedItem;

            if (selectedAuthMethod == "WebhookKey")
            {
                lblValue.Visible = true;
                txtValue.Visible = true;
                dgvKeyValue.Visible = false;

                dgvKeyValue.Rows.Clear();
            }
            else
            {
                lblValue.Visible = false;
                txtValue.Visible = false;
                dgvKeyValue.Visible = true;

                txtValue.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var errorMsgs = new List<string>();

            if (txtName.Text == string.Empty)
            {
                errorMsgs.Add("Endpoint Name is required");
            }
            
            if(txtEndpointUrl.Text == string.Empty)
            {
                errorMsgs.Add("Endpoint URL is required");
            }
            else
            {
                var isValid = Uri.TryCreate(txtEndpointUrl.Text, UriKind.Absolute, out _);
                if (!isValid)
                {
                    errorMsgs.Add("Endpoint URL should be valid.");
                }
            }

            var authValue = GenerateAuthValue();

            if (errorMsgs.Count == 0 && authValue == string.Empty)
            {
                errorMsgs.Add("Auth Value is required.");
            }

            if (errorMsgs.Count == 0)
            {
                UpsertWebhook();
            }
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine,errorMsgs),
                    "Invalid configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void UpsertWebhook()
        {
            var authValue = GenerateAuthValue();

            var webhook = new CrmServiceEndpoint(m_org)
            {
                Url = txtEndpointUrl.Text,
                Name = txtName.Text,
                AuthType = (CrmServiceEndpointAuthType)Enum.Parse(typeof(CrmServiceEndpointAuthType),
                    cmbAuth.SelectedItem.ToString(), true),
                ServiceEndpointId = m_webhook?.ServiceEndpointId ?? Guid.Empty,
                AuthValue = authValue,
                ConnectionMode = CrmServiceEndpointConnectionMode.Normal,
                Contract = CrmServiceEndpointContract.Webhook,
                UserClaim = CrmServiceEndpointUserClaim.None
            };

            Close();

            var isNew = webhook.ServiceEndpointId == Guid.Empty;

            m_orgControl.WorkAsync(new WorkAsyncInfo($"{(isNew ? "Creating" : "Updating")} webhook...",
                (eventargs) => {
                    if (isNew)
                    {
                        RegistrationHelper.RegisterWebHook(m_org, webhook);
                    }
                    else
                    {
                        RegistrationHelper.UpdatewebHook(m_org, webhook);
                    }
                })
            {
                PostWorkCallBack = (completedargs) => {
                    if (completedargs.Error == null)
                    {
                        m_orgControl.RefreshFullTreeView();
                    }
                    else
                    {
                        MessageBox.Show(completedargs.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            });
        }

        private string GenerateAuthValue()
        {
            return txtValue.Text != string.Empty ? txtValue.Text : GenerateKeyValueXml();
        }

        private string GenerateKeyValueXml()
        {
            var settingStrings = string.Empty;

            foreach (DataGridViewRow row in dgvKeyValue.Rows)
            {
                var key = row.Cells[0].Value?.ToString();
                var value = row.Cells[1].Value?.ToString();

                if(key == null && value == null){continue;}

                settingStrings += $"<setting name='{key}' value='{value}' />";
            }

            return settingStrings != string.Empty ? $@"<settings>{settingStrings}</settings>" : string.Empty;
        }
    }
}
