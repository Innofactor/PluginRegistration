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

namespace PluginRegistrationTool
{
    using System;
    using XrmToolBox.Extensibility.Args;

    public class ProgressIndicator
    {
        private ProgressIndicatorInitialize m_init;
        private ProgressIndicatorSetValue m_setValue;
        private ProgressIndicatorIncrement m_increment;
        private ProgressIndicatorAppendStatusText m_appendText;
        private ProgressIndicatorSetStatusText m_setText;
        private ProgressIndicatorComplete m_complete;

        public int Min { get; private set; }
        public int Max { get; private set; }
        public int Step { get; private set; }
        public int Initial { get; private set; }

        private enum MethodType
        {
            Initialize,
            SetValue,
            Increment,
            AppendStatusText,
            SetStatusText,
            Complete
        }

        public ProgressIndicator(ProgressIndicatorInitialize init, ProgressIndicatorComplete complete,
            ProgressIndicatorAppendStatusText appendText, ProgressIndicatorSetStatusText setText,
            ProgressIndicatorIncrement increment, ProgressIndicatorSetValue setValue)
        {
            if (init == null)
            {
                throw new ArgumentNullException("init");
            }

            this.m_init = init;
            this.m_appendText = appendText;
            this.m_setText = setText;
            this.m_setValue = setValue;
            this.m_increment = increment;
            this.m_complete = complete;
        }

        public ProgressIndicator(Action<StatusBarMessageEventArgs> action)
        {
            m_init = delegate(int min, int max, int initial)
            {
                if (min < 0 || max < 0)
                {
                    return;
                }

                Min = 0;
                Max = 100;
                Step = (int)Math.Floor((decimal)100 / max);
                Initial = (int)Math.Round((decimal)initial / max * 100);

                action(new StatusBarMessageEventArgs(Initial));
            };

            m_setText = delegate(string message)
            {
                action(new StatusBarMessageEventArgs(message));
            };

            m_complete = delegate ()
            {
                action(new StatusBarMessageEventArgs(string.Empty));
            };
        }

        #region Overloaded Methods
        public void Initialize(int max)
        {
            Initialize(max, (string)null);
        }

        public void Initialize(int max, string initialStatusText)
        {
            Initialize(0, max, null, initialStatusText);
        }

        public void Initialize(int max, int? initialValue)
        {
            Initialize(0, max, initialValue);
        }

        public void Initialize(int min, int max, int? initialValue)
        {
            Initialize(min, max, initialValue, null);
        }

        public void Increment()
        {
            Increment(Step, null);
        }

        public void Increment(string message)
        {
            Increment(Step, message);
        }

        public void Increment(int value)
        {
            Increment(value, null);
        }

        public void Complete()
        {
            Complete(false);
        }
        #endregion

        #region Methods
        public void Initialize(int min, int max, int? initialValue, string initialStatusText)
        {
            if (min > max)
            {
                throw new ArgumentOutOfRangeException("Minimum cannot be greater than maximum");
            }
            else if (initialValue != null && (initialValue < min || initialValue > max))
            {
                throw new ArgumentOutOfRangeException("Cannot be less than Minimum or greater than Maximum", "initialValue");
            }

            int value;
            if (initialValue == null)
            {
                value = min;
            }
            else
            {
                value = (int)initialValue;
            }

            this.m_init(min, max, value);

            if (initialStatusText != null)
            {
                SetText(initialStatusText);
            }

            //UI doesn't always refresh properly. This will allow the UI to refresh
            System.Windows.Forms.Application.DoEvents();
        }

        public void AppendText(string text)
        {
            if (this.m_setText == null && this.m_appendText == null)
            {
                return;
            }

            if (this.m_appendText != null && !string.IsNullOrEmpty(text))
            {
                this.m_appendText(text);
            }
            else if (this.m_setText != null)
            {
                this.m_setText(text);
            }

            //UI doesn't always refresh properly. This will allow the UI to refresh
            System.Windows.Forms.Application.DoEvents();
        }

        public void SetText(string text)
        {
            if (this.m_setText == null && this.m_appendText == null)
            {
                return;
            }

            if (this.m_setText != null)
            {
                this.m_setText(text);
            }
            else if (null != this.m_appendText && !string.IsNullOrEmpty(text))
            {
                this.m_appendText(text);
            }

            //UI doesn't always refresh properly. This will allow the UI to refresh
            System.Windows.Forms.Application.DoEvents();
        }

        public void ClearText()
        {
            this.SetText(string.Empty);
        }

        public void Increment(int value, string message)
        {
            if (this.m_increment != null)
            {
                this.m_increment(value);
            }

            if (message != null)
            {
                AppendText(message);
            }

            //UI doesn't always refresh properly. This will allow the UI to refresh
            System.Windows.Forms.Application.DoEvents();
        }

        public void Complete(bool clearStatusText)
        {
            if (clearStatusText)
            {
                this.SetText(string.Empty);
            }

            if (m_complete != null)
            {
                this.m_complete();
            }

            //UI doesn't always refresh properly. This will allow the UI to refresh
            System.Windows.Forms.Application.DoEvents();
        }
        #endregion
    }

    public delegate void ProgressIndicatorInitialize(int min, int max, int initialValue);
    public delegate void ProgressIndicatorSetValue(int value);
    public delegate void ProgressIndicatorIncrement(int incrementBy);
    public delegate void ProgressIndicatorAppendStatusText(string text);
    public delegate void ProgressIndicatorSetStatusText(string text);
    public delegate void ProgressIndicatorComplete();
}
