namespace Xrm.Sdk.PluginRegistration.Controls
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Windows.Forms;

    [DefaultEvent("PathChanged")]
    public sealed partial class FileBrowserControl : UserControl
    {
        #region Private Fields

        private bool _isPathChanged;

        #endregion Private Fields

        #region Public Constructors

        public FileBrowserControl()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Events

        public event EventHandler<EventArgs> BrowseCompleted;

        public event EventHandler<EventArgs> PathChanged;

        #endregion Public Events

        #region Public Properties

        public string DefaultExtension
        {
            get
            {
                return Dialog.DefaultExt;
            }

            set
            {
                Dialog.DefaultExt = value;
            }
        }

        public string DialogTitle
        {
            get
            {
                return Dialog.Title;
            }

            set
            {
                Dialog.Title = value;
            }
        }

        [Browsable(false)]
        public bool FileExists
        {
            get
            {
                return (HasFileName && File.Exists(FileName));
            }
        }

        [Browsable(false)]
        public string FileName
        {
            get
            {
                return PathBox.Text;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    PathBox.Clear();
                }
                else
                {
                    PathBox.Text = value.Trim();
                }
            }
        }

        public string Filter
        {
            get
            {
                return Dialog.Filter;
            }

            set
            {
                Dialog.Filter = value;
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

        public string InitialDirectory
        {
            get
            {
                return Dialog.InitialDirectory;
            }

            set
            {
                Dialog.InitialDirectory = value;
            }
        }

        #endregion Public Properties

        #region Private Methods

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == Dialog.ShowDialog())
            {
                PathBox.Text = Dialog.FileName;

                //Execute the same behavior as if the path had been entered manually
                PathBox_Leave(sender, e);

                //Indicate that the browse has been completed.
                if (null != BrowseCompleted)
                {
                    BrowseCompleted(sender, e);
                }
            }
        }

        private void PathBox_Leave(object sender, EventArgs e)
        {
            if (_isPathChanged)
            {
                //Ensure that the flag is unset before calling into the event to ensure that any behavior of the event handler
                //does not unintentionally use the old value of this flag.
                _isPathChanged = false;

                if (null != PathChanged)
                {
                    PathChanged(sender, e);
                }
            }
        }

        private void PathBox_TextChanged(object sender, EventArgs e)
        {
            //The content of the box has changed. The next time that the text box loses focus, it the PathChanged event
            //will need to be fired. The event should only be fired when text has changed, not when the box receives and loses focus
            //without a change.
            _isPathChanged = true;
        }

        #endregion Private Methods
    }
}