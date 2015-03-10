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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace PluginRegistrationTool
{
	/// <summary>
	/// Displays a dialog box and promts the user for login credentials.
	/// </summary>
	[ToolboxItem(true)]
	[DesignerCategory("Dialogs")]
	public sealed class UserCredentialsDialog : CommonDialog
	{
		#region Fields
		private Guid _targetId;
		private string _user;
		private SecureString _password;
		private string _domain;
		private string _message;
		private string _caption;
		private Image _bannerImage;
		private bool _isSaveChecked;
		#endregion

		#region Constructors
		public UserCredentialsDialog(Guid targetId)
		{
			this.Reset();
			this._targetId = targetId;
		}
		#endregion

		#region Properties

		public string User
		{
			get
			{
				return _user;
			}

			set
			{
				//If the value has no actual value, set it to null
				if (string.IsNullOrWhiteSpace(value))
				{
					value = null;
				}

				if (value != null)
				{
					if (value.Length > NativeMethods.CREDUI_MAX_USERNAME_LENGTH)
					{
						throw new ArgumentException(string.Format(
							"The user name has a maximum length of {0} characters.",
							NativeMethods.CREDUI_MAX_USERNAME_LENGTH), "User");
					}
				}
				_user = value;
			}
		}

		public SecureString Password
		{
			get { return _password; }
			set
			{
				if (value != null)
				{
					if (value.Length > NativeMethods.CREDUI_MAX_PASSWORD_LENGTH)
					{
						throw new ArgumentException(string.Format(
							"The password has a maximum length of {0} characters.",
							NativeMethods.CREDUI_MAX_PASSWORD_LENGTH), "Password");
					}
				}
				_password = value;
			}
		}

		public string Domain
		{
			get { return _domain; }
			set
			{
				//If the value has no actual value, set it to null
				if (string.IsNullOrWhiteSpace(value))
				{
					value = null;
				}

				if (value != null)
				{
					if (value.Length > NativeMethods.CREDUI_MAX_DOMAIN_TARGET_LENGTH)
					{
						throw new ArgumentException(string.Format(
							"The domain name has a maximum length of {0} characters.",
							NativeMethods.CREDUI_MAX_DOMAIN_TARGET_LENGTH), "Domain");
					}
				}
				_domain = value;
			}
		}

		public string Message
		{
			get { return _message; }
			set
			{
				if (value != null)
				{
					if (value.Length > NativeMethods.CREDUI_MAX_MESSAGE_LENGTH)
					{
						throw new ArgumentException(
							string.Format("The message has a maximum length of {0} characters.",
							NativeMethods.CREDUI_MAX_MESSAGE_LENGTH), "Message");
					}
				}
				_message = value;
			}
		}

		public string Caption
		{
			get { return _caption; }
			set
			{
				if (null != value && value.Length > NativeMethods.CREDUI_MAX_CAPTION_LENGTH)
				{
					throw new ArgumentException(
						string.Format("The caption has a maximum length of {0} characters.",
						NativeMethods.CREDUI_MAX_CAPTION_LENGTH), "value");
				}
				_caption = value;
			}
		}

		public Image BannerImage
		{
			get { return _bannerImage; }
			set
			{
				if (value != null)
				{
					if (value.Width != NativeMethods.CREDUI_BANNER_WIDTH)
					{
						throw new ArgumentException(
							string.Format("The banner image width must be {0} pixels.",
							NativeMethods.CREDUI_BANNER_WIDTH), "Banner");
					}
					if (value.Height != NativeMethods.CREDUI_BANNER_HEIGHT)
					{
						throw new ArgumentException(
							string.Format("The banner image height must be {0} pixels.",
							NativeMethods.CREDUI_BANNER_HEIGHT), "Banner");
					}
				}
				_bannerImage = value;
			}
		}

		public bool IsSaveChecked
		{
			get
			{
				return _isSaveChecked;
			}
			private set
			{
				this._isSaveChecked = value;
			}
		}
		#endregion

		#region Public methods
		public void ConfirmCredentials(bool confirm)
		{
			new UIPermission(UIPermissionWindow.SafeSubWindows).Demand();

			CredUIReturnCodes result = NativeMethods.CredUIConfirmCredentialsW(this._targetId.ToString(), confirm);

			if (result != CredUIReturnCodes.NO_ERROR &&
				result != CredUIReturnCodes.ERROR_NOT_FOUND &&
				result != CredUIReturnCodes.ERROR_INVALID_PARAMETER)
			{
				throw new InvalidOperationException(TranslateReturnCode(result));
			}
		}
		#endregion

		#region CommonDialog overrides

		protected override bool RunDialog(IntPtr hwndOwner)
		{
			if (Environment.OSVersion.Version.Major < 5)
			{
				throw new PlatformNotSupportedException("The Credential Management API requires Windows XP / Windows Server 2003 or later.");
			}

			CredUIInfo credInfo = new CredUIInfo(hwndOwner, this._caption, this._message, this._bannerImage);
			StringBuilder usr = new StringBuilder(NativeMethods.CREDUI_MAX_USERNAME_LENGTH);
			StringBuilder pwd = new StringBuilder(NativeMethods.CREDUI_MAX_PASSWORD_LENGTH);

			if (!string.IsNullOrEmpty(this.User))
			{
				if (!string.IsNullOrEmpty(this.Domain))
				{
					usr.Append(this.Domain + "\\");
				}
				usr.Append(this.User);
			}
			if (this.Password != null)
			{
				pwd.Append(this.Password.ToUnsecureString());
			}

			try
			{
				CredUIReturnCodes result = NativeMethods.CredUIPromptForCredentials(
														ref credInfo, this._targetId.ToString(),
														IntPtr.Zero, 0,
														usr, NativeMethods.CREDUI_MAX_USERNAME_LENGTH,
														pwd, NativeMethods.CREDUI_MAX_PASSWORD_LENGTH,
														ref this._isSaveChecked, UserCredentialsDialogFlags.Default);
				switch (result)
				{
					case CredUIReturnCodes.NO_ERROR:
						LoadUserDomainValues(usr);
						LoadPasswordValue(pwd);

						//If the target is not set, then the credentials should never be checked
						if (Guid.Empty == this._targetId)
						{
							this._isSaveChecked = false;
						}
						return true;
					case CredUIReturnCodes.ERROR_CANCELLED:
						this.User = null;
						this.Password = null;
						return false;
					default:
						throw new InvalidOperationException(TranslateReturnCode(result));
				}
			}
			finally
			{
				usr.Remove(0, usr.Length);
				pwd.Remove(0, pwd.Length);
				if (this._bannerImage != null)
				{
					NativeMethods.DeleteObject(credInfo.hbmBanner);
				}
			}
		}

		/// <summary>
		/// Set all properties to it's default values.
		/// </summary>
		public override void Reset()
		{
			this._user = null;
			this._password = null;
			this._domain = null;
			this._caption = null;
			this._message = null;
			this._bannerImage = null;
			this._isSaveChecked = false;
		}
		#endregion

		#region Private methods
		private static string TranslateReturnCode(CredUIReturnCodes result)
		{
			return string.Format("Invalid operation: {0}", result.ToString());
		}

		private void LoadPasswordValue(StringBuilder password)
		{
			char[] pwd = new char[password.Length];
			SecureString securePassword = new SecureString();
			try
			{
				password.CopyTo(0, pwd, 0, pwd.Length);
				foreach (char c in pwd)
				{
					securePassword.AppendChar(c);
				}
				securePassword.MakeReadOnly();
				this.Password = securePassword.Copy();
			}
			finally
			{
				// discard the char array
				Array.Clear(pwd, 0, pwd.Length);
			}
		}

		private void LoadUserDomainValues(StringBuilder principalName)
		{
			StringBuilder user = new StringBuilder(NativeMethods.CREDUI_MAX_USERNAME_LENGTH);
			StringBuilder domain = new StringBuilder(NativeMethods.CREDUI_MAX_DOMAIN_TARGET_LENGTH);
			CredUIReturnCodes result = NativeMethods.CredUIParseUserNameW(principalName.ToString(),
				user, NativeMethods.CREDUI_MAX_USERNAME_LENGTH, domain, NativeMethods.CREDUI_MAX_DOMAIN_TARGET_LENGTH);

			if (result == CredUIReturnCodes.NO_ERROR)
			{
				this.User = user.ToString();
				this.Domain = domain.ToString();
			}
			else
			{
				this.User = principalName.ToString();

				//Check whether this is a domain joined machine. If it is, then use the user's domain name
				if (string.IsNullOrEmpty(Environment.UserDomainName))
				{
					this.Domain = Environment.MachineName;
				}
				else
				{
					this.Domain = Environment.UserDomainName;
				}
			}
		}
		#endregion

		#region Private Classes
		[SuppressUnmanagedCodeSecurity]
		private static class NativeMethods
		{
			internal const int CREDUI_MAX_MESSAGE_LENGTH = 100;
			internal const int CREDUI_MAX_CAPTION_LENGTH = 100;
			internal const int CREDUI_MAX_GENERIC_TARGET_LENGTH = 100;
			internal const int CREDUI_MAX_DOMAIN_TARGET_LENGTH = 100;
			internal const int CREDUI_MAX_USERNAME_LENGTH = 100;
			internal const int CREDUI_MAX_PASSWORD_LENGTH = 100;
			internal const int CREDUI_BANNER_HEIGHT = 60;
			internal const int CREDUI_BANNER_WIDTH = 320;

			[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
			internal static extern bool DeleteObject(IntPtr hObject);

			[DllImport("credui.dll", EntryPoint = "CredUIPromptForCredentialsW", SetLastError = true, CharSet = CharSet.Unicode)]
			internal extern static CredUIReturnCodes CredUIPromptForCredentials(
				ref CredUIInfo creditUR,
				string targetName,
				IntPtr reserved1,
				int iError,
				StringBuilder userName,
				int maxUserName,
				StringBuilder password,
				int maxPassword,
				ref bool iSave,
				UserCredentialsDialogFlags flags);

			[DllImport("credui.dll", SetLastError = true, CharSet = CharSet.Unicode)]
			internal static extern uint CredUIPromptForWindowsCredentials(
				ref CredUIInfo creditUR,
				int authError,
				ref uint authPackage,
				IntPtr InAuthBuffer,
				uint InAuthBufferSize,
				out IntPtr refOutAuthBuffer,
				out uint refOutAuthBufferSize,
				ref bool fSave,
				int flags);


			[DllImport("credui.dll", SetLastError = true, CharSet = CharSet.Unicode)]
			internal extern static CredUIReturnCodes CredUIParseUserNameW(
				string userName,
				StringBuilder user,
				int userMaxChars,
				StringBuilder domain,
				int domainMaxChars);

			[DllImport("credui.dll", SetLastError = true, CharSet = CharSet.Unicode)]
			internal extern static CredUIReturnCodes CredUIConfirmCredentialsW(string targetName, bool confirm);
		}

		private enum CredUIReturnCodes
		{
			NO_ERROR = 0,
			ERROR_CANCELLED = 1223,
			ERROR_NO_SUCH_LOGON_SESSION = 1312,
			ERROR_NOT_FOUND = 1168,
			ERROR_INVALID_ACCOUNT_NAME = 1315,
			ERROR_INSUFFICIENT_BUFFER = 122,
			ERROR_INVALID_PARAMETER = 87,
			ERROR_INVALID_FLAGS = 1004
		}

		private struct CredUIInfo
		{
			internal CredUIInfo(IntPtr owner, string caption, string message, Image banner)
			{
				this.cbSize = Marshal.SizeOf(typeof(CredUIInfo));
				this.hwndParent = owner;
				this.pszCaptionText = caption;
				this.pszMessageText = message;

				if (banner != null)
				{
					this.hbmBanner = new Bitmap(banner,
						NativeMethods.CREDUI_BANNER_WIDTH, NativeMethods.CREDUI_BANNER_HEIGHT).GetHbitmap();
				}
				else
				{
					this.hbmBanner = IntPtr.Zero;
				}
			}

			internal int cbSize;
			internal IntPtr hwndParent;
			[MarshalAs(UnmanagedType.LPWStr)]
			internal string pszMessageText;
			[MarshalAs(UnmanagedType.LPWStr)]
			internal string pszCaptionText;
			internal IntPtr hbmBanner;
		}

		[Flags]
		private enum UserCredentialsDialogFlags
		{
			Default = GenericCredentials |
						AlwaysShowUI |
						ShowSaveCheckbox |
						ExpectConfirmation,
			None = 0x0,
			IncorrectPassword = 0x1,
			DoNotPersist = 0x2,
			RequestAdministrator = 0x4,
			ExcludesCertificates = 0x8,
			RequireCertificate = 0x10,
			ShowSaveCheckbox = 0x40,
			AlwaysShowUI = 0x80,
			RequireSmartCard = 0x100,
			PasswordOnlyOk = 0x200,
			ValidateUsername = 0x400,
			CompleteUserName = 0x800,
			Persist = 0x1000,
			ServerCredential = 0x4000,
			ExpectConfirmation = 0x20000,
			GenericCredentials = 0x40000,
			UsernameTargetCredentials = 0x80000,
			KeepUsername = 0x100000
		}
		#endregion
	}

	#region Extension Methods for SecureString
	internal static class SecureStringExtensions
	{
		public static string ToUnsecureString(this SecureString value)
		{
			if (null == value)
			{
				throw new ArgumentNullException("value");
			}

			//Get a pointer
			IntPtr ptr = Marshal.SecureStringToGlobalAllocUnicode(value);
			try
			{
				//Convert to an unsecure string
				return Marshal.PtrToStringUni(ptr);
			}
			finally
			{
				//Clean up the pointer
				Marshal.ZeroFreeGlobalAllocUnicode(ptr);
			}
		}
	}
	#endregion
}