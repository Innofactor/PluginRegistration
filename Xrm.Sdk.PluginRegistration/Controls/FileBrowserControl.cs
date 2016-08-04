namespace Xrm.Sdk.PluginRegistration.Controls
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Windows.Forms;

    [DefaultEvent("PathChanged")]
    public sealed partial class FileBrowserControl : UserControl
    {
        private bool _isPathChanged;

        public FileBrowserControl()
        {
            InitializeComponent();
        }

        #region Events

        public event EventHandler<EventArgs> BrowseCompleted;

        public event EventHandler<EventArgs> PathChanged;

        #endregion Events

        #region Events Handlers

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.Dialog.ShowDialog())
            {
                PathBox.Text = this.Dialog.FileName;

                //Execute the same behavior as if the path had been entered manually
                PathBox_Leave(sender, e);

                //Indicate that the browse has been completed.
                if (null != this.BrowseCompleted)
                {
                    this.BrowseCompleted(sender, e);
                }
            }
        }

        private void PathBox_Leave(object sender, EventArgs e)
        {
            if (this._isPathChanged)
            {
                //Ensure that the flag is unset before calling into the event to ensure that any behavior of the event handler
                //does not unintentionally use the old value of this flag.
                this._isPathChanged = false;

                if (null != this.PathChanged)
                {
                    this.PathChanged(sender, e);
                }
            }
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            //The content of the box has changed. The next time that the text box loses focus, it the PathChanged event
            //will need to be fired. The event should only be fired when text has changed, not when the box receives and loses focus
            //without a change.
            this._isPathChanged = true;
        }

        #endregion Events Handlers

        #region Properties

        public string DialogTitle
        {
            get
            {
                return this.Dialog.Title;
            }

            set
            {
                this.Dialog.Title = value;
            }
        }

        public string DefaultExtension
        {
            get
            {
                return this.Dialog.DefaultExt;
            }

            set
            {
                this.Dialog.DefaultExt = value;
            }
        }

        public string InitialDirectory
        {
            get
            {
                return this.Dialog.InitialDirectory;
            }

            set
            {
                this.Dialog.InitialDirectory = value;
            }
        }

        public string Filter
        {
            get
            {
                return this.Dialog.Filter;
            }

            set
            {
                this.Dialog.Filter = value;
            }
        }

        [Browsable(false)]
        public string FileName
        {
            get
            {
                return this.PathBox.Text;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    this.PathBox.Clear();
                }
                else
                {
                    this.PathBox.Text = value.Trim();
                }
            }
        }

        [Browsable(false)]
        public bool HasFileName
        {
            get
            {
                return !string.IsNullOrWhiteSpace(PathBox.Text);
            }
        }

        [Browsable(false)]
        public bool FileExists
        {
            get
            {
                return (this.HasFileName && File.Exists(this.FileName));
            }
        }

        #endregion Properties
    }
}