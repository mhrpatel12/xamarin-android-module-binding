using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/UserClientService", DoNotGenerateAcw=true)]
	public partial class UserClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='APPLICATION_INFO_UPDATE_URL']"
		[Register ("APPLICATION_INFO_UPDATE_URL")]
		public const string ApplicationInfoUpdateUrl = (string) "/apps/customer/application/info/update";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='BATCH_SIZE']"
		[Register ("BATCH_SIZE")]
		public const int BatchSize = (int) 60;

		static IntPtr MOBICOMKIT_VERSION_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='MOBICOMKIT_VERSION_CODE']"
		[Register ("MOBICOMKIT_VERSION_CODE")]
		public static global::Java.Lang.Short MobicomkitVersionCode {
			get {
				if (MOBICOMKIT_VERSION_CODE_jfieldId == IntPtr.Zero)
					MOBICOMKIT_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBICOMKIT_VERSION_CODE", "Ljava/lang/Short;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBICOMKIT_VERSION_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='SHARED_PREFERENCE_VERSION_UPDATE_KEY']"
		[Register ("SHARED_PREFERENCE_VERSION_UPDATE_KEY")]
		public const string SharedPreferenceVersionUpdateKey = (string) "mck.version.update";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='UNBLOCK_USER_SYNC_URL']"
		[Register ("UNBLOCK_USER_SYNC_URL")]
		public const string UnblockUserSyncUrl = (string) "/rest/ws/user/unblock";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='USER_DETAILS_URL']"
		[Register ("USER_DETAILS_URL")]
		public const string UserDetailsUrl = (string) "/rest/ws/user/detail?";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/field[@name='USER_DISPLAY_NAME_UPDATE']"
		[Register ("USER_DISPLAY_NAME_UPDATE")]
		public const string UserDisplayNameUpdate = (string) "/rest/ws/user/name?";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/UserClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserClientService); }
		}

		protected UserClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/constructor[@name='UserClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe UserClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (UserClientService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAppVersionUpdateUrl;
#pragma warning disable 0169
		static Delegate GetGetAppVersionUpdateUrlHandler ()
		{
			if (cb_getAppVersionUpdateUrl == null)
				cb_getAppVersionUpdateUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppVersionUpdateUrl);
			return cb_getAppVersionUpdateUrl;
		}

		static IntPtr n_GetAppVersionUpdateUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppVersionUpdateUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAppVersionUpdateUrl;
		public virtual unsafe string AppVersionUpdateUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getAppVersionUpdateUrl' and count(parameter)=0]"
			[Register ("getAppVersionUpdateUrl", "()Ljava/lang/String;", "GetGetAppVersionUpdateUrlHandler")]
			get {
				if (id_getAppVersionUpdateUrl == IntPtr.Zero)
					id_getAppVersionUpdateUrl = JNIEnv.GetMethodID (class_ref, "getAppVersionUpdateUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppVersionUpdateUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppVersionUpdateUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationInfoUrl;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfoUrlHandler ()
		{
			if (cb_getApplicationInfoUrl == null)
				cb_getApplicationInfoUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationInfoUrl);
			return cb_getApplicationInfoUrl;
		}

		static IntPtr n_GetApplicationInfoUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationInfoUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationInfoUrl;
		public virtual unsafe string ApplicationInfoUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getApplicationInfoUrl' and count(parameter)=0]"
			[Register ("getApplicationInfoUrl", "()Ljava/lang/String;", "GetGetApplicationInfoUrlHandler")]
			get {
				if (id_getApplicationInfoUrl == IntPtr.Zero)
					id_getApplicationInfoUrl = JNIEnv.GetMethodID (class_ref, "getApplicationInfoUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationInfoUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationInfoUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBlockUserSyncUrl;
#pragma warning disable 0169
		static Delegate GetGetBlockUserSyncUrlHandler ()
		{
			if (cb_getBlockUserSyncUrl == null)
				cb_getBlockUserSyncUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockUserSyncUrl);
			return cb_getBlockUserSyncUrl;
		}

		static IntPtr n_GetBlockUserSyncUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BlockUserSyncUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getBlockUserSyncUrl;
		public virtual unsafe string BlockUserSyncUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getBlockUserSyncUrl' and count(parameter)=0]"
			[Register ("getBlockUserSyncUrl", "()Ljava/lang/String;", "GetGetBlockUserSyncUrlHandler")]
			get {
				if (id_getBlockUserSyncUrl == IntPtr.Zero)
					id_getBlockUserSyncUrl = JNIEnv.GetMethodID (class_ref, "getBlockUserSyncUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockUserSyncUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockUserSyncUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBlockUserUrl;
#pragma warning disable 0169
		static Delegate GetGetBlockUserUrlHandler ()
		{
			if (cb_getBlockUserUrl == null)
				cb_getBlockUserUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockUserUrl);
			return cb_getBlockUserUrl;
		}

		static IntPtr n_GetBlockUserUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BlockUserUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getBlockUserUrl;
		public virtual unsafe string BlockUserUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getBlockUserUrl' and count(parameter)=0]"
			[Register ("getBlockUserUrl", "()Ljava/lang/String;", "GetGetBlockUserUrlHandler")]
			get {
				if (id_getBlockUserUrl == IntPtr.Zero)
					id_getBlockUserUrl = JNIEnv.GetMethodID (class_ref, "getBlockUserUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockUserUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockUserUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNotifyContactsAboutJoiningMt;
#pragma warning disable 0169
		static Delegate GetGetNotifyContactsAboutJoiningMtHandler ()
		{
			if (cb_getNotifyContactsAboutJoiningMt == null)
				cb_getNotifyContactsAboutJoiningMt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotifyContactsAboutJoiningMt);
			return cb_getNotifyContactsAboutJoiningMt;
		}

		static IntPtr n_GetNotifyContactsAboutJoiningMt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotifyContactsAboutJoiningMt);
		}
#pragma warning restore 0169

		static IntPtr id_getNotifyContactsAboutJoiningMt;
		public virtual unsafe string NotifyContactsAboutJoiningMt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getNotifyContactsAboutJoiningMt' and count(parameter)=0]"
			[Register ("getNotifyContactsAboutJoiningMt", "()Ljava/lang/String;", "GetGetNotifyContactsAboutJoiningMtHandler")]
			get {
				if (id_getNotifyContactsAboutJoiningMt == IntPtr.Zero)
					id_getNotifyContactsAboutJoiningMt = JNIEnv.GetMethodID (class_ref, "getNotifyContactsAboutJoiningMt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotifyContactsAboutJoiningMt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotifyContactsAboutJoiningMt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOnlineUserListUrl;
#pragma warning disable 0169
		static Delegate GetGetOnlineUserListUrlHandler ()
		{
			if (cb_getOnlineUserListUrl == null)
				cb_getOnlineUserListUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnlineUserListUrl);
			return cb_getOnlineUserListUrl;
		}

		static IntPtr n_GetOnlineUserListUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OnlineUserListUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getOnlineUserListUrl;
		public virtual unsafe string OnlineUserListUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getOnlineUserListUrl' and count(parameter)=0]"
			[Register ("getOnlineUserListUrl", "()Ljava/lang/String;", "GetGetOnlineUserListUrlHandler")]
			get {
				if (id_getOnlineUserListUrl == IntPtr.Zero)
					id_getOnlineUserListUrl = JNIEnv.GetMethodID (class_ref, "getOnlineUserListUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnlineUserListUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnlineUserListUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPhoneNumberUpdateUrl;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumberUpdateUrlHandler ()
		{
			if (cb_getPhoneNumberUpdateUrl == null)
				cb_getPhoneNumberUpdateUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumberUpdateUrl);
			return cb_getPhoneNumberUpdateUrl;
		}

		static IntPtr n_GetPhoneNumberUpdateUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneNumberUpdateUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumberUpdateUrl;
		public virtual unsafe string PhoneNumberUpdateUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getPhoneNumberUpdateUrl' and count(parameter)=0]"
			[Register ("getPhoneNumberUpdateUrl", "()Ljava/lang/String;", "GetGetPhoneNumberUpdateUrlHandler")]
			get {
				if (id_getPhoneNumberUpdateUrl == IntPtr.Zero)
					id_getPhoneNumberUpdateUrl = JNIEnv.GetMethodID (class_ref, "getPhoneNumberUpdateUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumberUpdateUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumberUpdateUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRegisteredUserListUrl;
#pragma warning disable 0169
		static Delegate GetGetRegisteredUserListUrlHandler ()
		{
			if (cb_getRegisteredUserListUrl == null)
				cb_getRegisteredUserListUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRegisteredUserListUrl);
			return cb_getRegisteredUserListUrl;
		}

		static IntPtr n_GetRegisteredUserListUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegisteredUserListUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRegisteredUserListUrl;
		public virtual unsafe string RegisteredUserListUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getRegisteredUserListUrl' and count(parameter)=0]"
			[Register ("getRegisteredUserListUrl", "()Ljava/lang/String;", "GetGetRegisteredUserListUrlHandler")]
			get {
				if (id_getRegisteredUserListUrl == IntPtr.Zero)
					id_getRegisteredUserListUrl = JNIEnv.GetMethodID (class_ref, "getRegisteredUserListUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegisteredUserListUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisteredUserListUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSettingUpdateUrl;
#pragma warning disable 0169
		static Delegate GetGetSettingUpdateUrlHandler ()
		{
			if (cb_getSettingUpdateUrl == null)
				cb_getSettingUpdateUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSettingUpdateUrl);
			return cb_getSettingUpdateUrl;
		}

		static IntPtr n_GetSettingUpdateUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SettingUpdateUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getSettingUpdateUrl;
		public virtual unsafe string SettingUpdateUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getSettingUpdateUrl' and count(parameter)=0]"
			[Register ("getSettingUpdateUrl", "()Ljava/lang/String;", "GetGetSettingUpdateUrlHandler")]
			get {
				if (id_getSettingUpdateUrl == IntPtr.Zero)
					id_getSettingUpdateUrl = JNIEnv.GetMethodID (class_ref, "getSettingUpdateUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSettingUpdateUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSettingUpdateUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimezoneUpdataeUrl;
#pragma warning disable 0169
		static Delegate GetGetTimezoneUpdataeUrlHandler ()
		{
			if (cb_getTimezoneUpdataeUrl == null)
				cb_getTimezoneUpdataeUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimezoneUpdataeUrl);
			return cb_getTimezoneUpdataeUrl;
		}

		static IntPtr n_GetTimezoneUpdataeUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TimezoneUpdataeUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getTimezoneUpdataeUrl;
		public virtual unsafe string TimezoneUpdataeUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getTimezoneUpdataeUrl' and count(parameter)=0]"
			[Register ("getTimezoneUpdataeUrl", "()Ljava/lang/String;", "GetGetTimezoneUpdataeUrlHandler")]
			get {
				if (id_getTimezoneUpdataeUrl == IntPtr.Zero)
					id_getTimezoneUpdataeUrl = JNIEnv.GetMethodID (class_ref, "getTimezoneUpdataeUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimezoneUpdataeUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimezoneUpdataeUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUnBlockUserSyncUrl;
#pragma warning disable 0169
		static Delegate GetGetUnBlockUserSyncUrlHandler ()
		{
			if (cb_getUnBlockUserSyncUrl == null)
				cb_getUnBlockUserSyncUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnBlockUserSyncUrl);
			return cb_getUnBlockUserSyncUrl;
		}

		static IntPtr n_GetUnBlockUserSyncUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UnBlockUserSyncUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUnBlockUserSyncUrl;
		public virtual unsafe string UnBlockUserSyncUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUnBlockUserSyncUrl' and count(parameter)=0]"
			[Register ("getUnBlockUserSyncUrl", "()Ljava/lang/String;", "GetGetUnBlockUserSyncUrlHandler")]
			get {
				if (id_getUnBlockUserSyncUrl == IntPtr.Zero)
					id_getUnBlockUserSyncUrl = JNIEnv.GetMethodID (class_ref, "getUnBlockUserSyncUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnBlockUserSyncUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnBlockUserSyncUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateUserDisplayNameUrl;
#pragma warning disable 0169
		static Delegate GetGetUpdateUserDisplayNameUrlHandler ()
		{
			if (cb_getUpdateUserDisplayNameUrl == null)
				cb_getUpdateUserDisplayNameUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateUserDisplayNameUrl);
			return cb_getUpdateUserDisplayNameUrl;
		}

		static IntPtr n_GetUpdateUserDisplayNameUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateUserDisplayNameUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateUserDisplayNameUrl;
		public virtual unsafe string UpdateUserDisplayNameUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUpdateUserDisplayNameUrl' and count(parameter)=0]"
			[Register ("getUpdateUserDisplayNameUrl", "()Ljava/lang/String;", "GetGetUpdateUserDisplayNameUrlHandler")]
			get {
				if (id_getUpdateUserDisplayNameUrl == IntPtr.Zero)
					id_getUpdateUserDisplayNameUrl = JNIEnv.GetMethodID (class_ref, "getUpdateUserDisplayNameUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateUserDisplayNameUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateUserDisplayNameUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateUserPasswordUrl;
#pragma warning disable 0169
		static Delegate GetGetUpdateUserPasswordUrlHandler ()
		{
			if (cb_getUpdateUserPasswordUrl == null)
				cb_getUpdateUserPasswordUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateUserPasswordUrl);
			return cb_getUpdateUserPasswordUrl;
		}

		static IntPtr n_GetUpdateUserPasswordUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateUserPasswordUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateUserPasswordUrl;
		public virtual unsafe string UpdateUserPasswordUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUpdateUserPasswordUrl' and count(parameter)=0]"
			[Register ("getUpdateUserPasswordUrl", "()Ljava/lang/String;", "GetGetUpdateUserPasswordUrlHandler")]
			get {
				if (id_getUpdateUserPasswordUrl == IntPtr.Zero)
					id_getUpdateUserPasswordUrl = JNIEnv.GetMethodID (class_ref, "getUpdateUserPasswordUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateUserPasswordUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateUserPasswordUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserDetailsListPostUrl;
#pragma warning disable 0169
		static Delegate GetGetUserDetailsListPostUrlHandler ()
		{
			if (cb_getUserDetailsListPostUrl == null)
				cb_getUserDetailsListPostUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserDetailsListPostUrl);
			return cb_getUserDetailsListPostUrl;
		}

		static IntPtr n_GetUserDetailsListPostUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserDetailsListPostUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetailsListPostUrl;
		public virtual unsafe string UserDetailsListPostUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserDetailsListPostUrl' and count(parameter)=0]"
			[Register ("getUserDetailsListPostUrl", "()Ljava/lang/String;", "GetGetUserDetailsListPostUrlHandler")]
			get {
				if (id_getUserDetailsListPostUrl == IntPtr.Zero)
					id_getUserDetailsListPostUrl = JNIEnv.GetMethodID (class_ref, "getUserDetailsListPostUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetailsListPostUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetailsListPostUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserDetailsListUrl;
#pragma warning disable 0169
		static Delegate GetGetUserDetailsListUrlHandler ()
		{
			if (cb_getUserDetailsListUrl == null)
				cb_getUserDetailsListUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserDetailsListUrl);
			return cb_getUserDetailsListUrl;
		}

		static IntPtr n_GetUserDetailsListUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserDetailsListUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetailsListUrl;
		public virtual unsafe string UserDetailsListUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserDetailsListUrl' and count(parameter)=0]"
			[Register ("getUserDetailsListUrl", "()Ljava/lang/String;", "GetGetUserDetailsListUrlHandler")]
			get {
				if (id_getUserDetailsListUrl == IntPtr.Zero)
					id_getUserDetailsListUrl = JNIEnv.GetMethodID (class_ref, "getUserDetailsListUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetailsListUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetailsListUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserInfoUrl;
#pragma warning disable 0169
		static Delegate GetGetUserInfoUrlHandler ()
		{
			if (cb_getUserInfoUrl == null)
				cb_getUserInfoUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserInfoUrl);
			return cb_getUserInfoUrl;
		}

		static IntPtr n_GetUserInfoUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserInfoUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfoUrl;
		public virtual unsafe string UserInfoUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserInfoUrl' and count(parameter)=0]"
			[Register ("getUserInfoUrl", "()Ljava/lang/String;", "GetGetUserInfoUrlHandler")]
			get {
				if (id_getUserInfoUrl == IntPtr.Zero)
					id_getUserInfoUrl = JNIEnv.GetMethodID (class_ref, "getUserInfoUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserInfoUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfoUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserLogout;
#pragma warning disable 0169
		static Delegate GetGetUserLogoutHandler ()
		{
			if (cb_getUserLogout == null)
				cb_getUserLogout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserLogout);
			return cb_getUserLogout;
		}

		static IntPtr n_GetUserLogout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserLogout);
		}
#pragma warning restore 0169

		static IntPtr id_getUserLogout;
		public virtual unsafe string UserLogout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserLogout' and count(parameter)=0]"
			[Register ("getUserLogout", "()Ljava/lang/String;", "GetGetUserLogoutHandler")]
			get {
				if (id_getUserLogout == IntPtr.Zero)
					id_getUserLogout = JNIEnv.GetMethodID (class_ref, "getUserLogout", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserLogout), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserLogout", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserProfileUpdateUrl;
#pragma warning disable 0169
		static Delegate GetGetUserProfileUpdateUrlHandler ()
		{
			if (cb_getUserProfileUpdateUrl == null)
				cb_getUserProfileUpdateUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserProfileUpdateUrl);
			return cb_getUserProfileUpdateUrl;
		}

		static IntPtr n_GetUserProfileUpdateUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserProfileUpdateUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserProfileUpdateUrl;
		public virtual unsafe string UserProfileUpdateUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserProfileUpdateUrl' and count(parameter)=0]"
			[Register ("getUserProfileUpdateUrl", "()Ljava/lang/String;", "GetGetUserProfileUpdateUrlHandler")]
			get {
				if (id_getUserProfileUpdateUrl == IntPtr.Zero)
					id_getUserProfileUpdateUrl = JNIEnv.GetMethodID (class_ref, "getUserProfileUpdateUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserProfileUpdateUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserProfileUpdateUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserReadServerCall;
#pragma warning disable 0169
		static Delegate GetGetUserReadServerCallHandler ()
		{
			if (cb_getUserReadServerCall == null)
				cb_getUserReadServerCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserReadServerCall);
			return cb_getUserReadServerCall;
		}

		static IntPtr n_GetUserReadServerCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserReadServerCall);
		}
#pragma warning restore 0169

		static IntPtr id_getUserReadServerCall;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UserReadServerCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserReadServerCall' and count(parameter)=0]"
			[Register ("getUserReadServerCall", "()Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetGetUserReadServerCallHandler")]
			get {
				if (id_getUserReadServerCall == IntPtr.Zero)
					id_getUserReadServerCall = JNIEnv.GetMethodID (class_ref, "getUserReadServerCall", "()Lcom/applozic/mobicomkit/feed/ApiResponse;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserReadServerCall), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserReadServerCall", "()Lcom/applozic/mobicomkit/feed/ApiResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserReadUrl;
#pragma warning disable 0169
		static Delegate GetGetUserReadUrlHandler ()
		{
			if (cb_getUserReadUrl == null)
				cb_getUserReadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserReadUrl);
			return cb_getUserReadUrl;
		}

		static IntPtr n_GetUserReadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserReadUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserReadUrl;
		public virtual unsafe string UserReadUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserReadUrl' and count(parameter)=0]"
			[Register ("getUserReadUrl", "()Ljava/lang/String;", "GetGetUserReadUrlHandler")]
			get {
				if (id_getUserReadUrl == IntPtr.Zero)
					id_getUserReadUrl = JNIEnv.GetMethodID (class_ref, "getUserReadUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserReadUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserReadUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVerificationCodeContactNumberUrl;
#pragma warning disable 0169
		static Delegate GetGetVerificationCodeContactNumberUrlHandler ()
		{
			if (cb_getVerificationCodeContactNumberUrl == null)
				cb_getVerificationCodeContactNumberUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerificationCodeContactNumberUrl);
			return cb_getVerificationCodeContactNumberUrl;
		}

		static IntPtr n_GetVerificationCodeContactNumberUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerificationCodeContactNumberUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getVerificationCodeContactNumberUrl;
		public virtual unsafe string VerificationCodeContactNumberUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getVerificationCodeContactNumberUrl' and count(parameter)=0]"
			[Register ("getVerificationCodeContactNumberUrl", "()Ljava/lang/String;", "GetGetVerificationCodeContactNumberUrlHandler")]
			get {
				if (id_getVerificationCodeContactNumberUrl == IntPtr.Zero)
					id_getVerificationCodeContactNumberUrl = JNIEnv.GetMethodID (class_ref, "getVerificationCodeContactNumberUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerificationCodeContactNumberUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerificationCodeContactNumberUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVerificationContactNumberUrl;
#pragma warning disable 0169
		static Delegate GetGetVerificationContactNumberUrlHandler ()
		{
			if (cb_getVerificationContactNumberUrl == null)
				cb_getVerificationContactNumberUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerificationContactNumberUrl);
			return cb_getVerificationContactNumberUrl;
		}

		static IntPtr n_GetVerificationContactNumberUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VerificationContactNumberUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getVerificationContactNumberUrl;
		public virtual unsafe string VerificationContactNumberUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getVerificationContactNumberUrl' and count(parameter)=0]"
			[Register ("getVerificationContactNumberUrl", "()Ljava/lang/String;", "GetGetVerificationContactNumberUrlHandler")]
			get {
				if (id_getVerificationContactNumberUrl == IntPtr.Zero)
					id_getVerificationContactNumberUrl = JNIEnv.GetMethodID (class_ref, "getVerificationContactNumberUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVerificationContactNumberUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerificationContactNumberUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clearDataAndPreference;
#pragma warning disable 0169
		static Delegate GetClearDataAndPreferenceHandler ()
		{
			if (cb_clearDataAndPreference == null)
				cb_clearDataAndPreference = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearDataAndPreference);
			return cb_clearDataAndPreference;
		}

		static void n_ClearDataAndPreference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearDataAndPreference ();
		}
#pragma warning restore 0169

		static IntPtr id_clearDataAndPreference;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='clearDataAndPreference' and count(parameter)=0]"
		[Register ("clearDataAndPreference", "()V", "GetClearDataAndPreferenceHandler")]
		public virtual unsafe void ClearDataAndPreference ()
		{
			if (id_clearDataAndPreference == IntPtr.Zero)
				id_clearDataAndPreference = JNIEnv.GetMethodID (class_ref, "clearDataAndPreference", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearDataAndPreference);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearDataAndPreference", "()V"));
			} finally {
			}
		}

		static Delegate cb_getOnlineUserList_I;
#pragma warning disable 0169
		static Delegate GetGetOnlineUserList_IHandler ()
		{
			if (cb_getOnlineUserList_I == null)
				cb_getOnlineUserList_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetOnlineUserList_I);
			return cb_getOnlineUserList_I;
		}

		static IntPtr n_GetOnlineUserList_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetOnlineUserList (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getOnlineUserList_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getOnlineUserList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOnlineUserList", "(I)Ljava/util/Map;", "GetGetOnlineUserList_IHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetOnlineUserList (int p0)
		{
			if (id_getOnlineUserList_I == IntPtr.Zero)
				id_getOnlineUserList_I = JNIEnv.GetMethodID (class_ref, "getOnlineUserList", "(I)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnlineUserList_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnlineUserList", "(I)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRegisteredUsers_Ljava_lang_Long_I;
#pragma warning disable 0169
		static Delegate GetGetRegisteredUsers_Ljava_lang_Long_IHandler ()
		{
			if (cb_getRegisteredUsers_Ljava_lang_Long_I == null)
				cb_getRegisteredUsers_Ljava_lang_Long_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetRegisteredUsers_Ljava_lang_Long_I);
			return cb_getRegisteredUsers_Ljava_lang_Long_I;
		}

		static IntPtr n_GetRegisteredUsers_Ljava_lang_Long_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetRegisteredUsers (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRegisteredUsers_Ljava_lang_Long_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getRegisteredUsers' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='int']]"
		[Register ("getRegisteredUsers", "(Ljava/lang/Long;I)Ljava/lang/String;", "GetGetRegisteredUsers_Ljava_lang_Long_IHandler")]
		public virtual unsafe string GetRegisteredUsers (global::Java.Lang.Long p0, int p1)
		{
			if (id_getRegisteredUsers_Ljava_lang_Long_I == IntPtr.Zero)
				id_getRegisteredUsers_Ljava_lang_Long_I = JNIEnv.GetMethodID (class_ref, "getRegisteredUsers", "(Ljava/lang/Long;I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegisteredUsers_Ljava_lang_Long_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisteredUsers", "(Ljava/lang/Long;I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSyncUserBlockList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSyncUserBlockList_Ljava_lang_String_Handler ()
		{
			if (cb_getSyncUserBlockList_Ljava_lang_String_ == null)
				cb_getSyncUserBlockList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSyncUserBlockList_Ljava_lang_String_);
			return cb_getSyncUserBlockList_Ljava_lang_String_;
		}

		static IntPtr n_GetSyncUserBlockList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSyncUserBlockList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSyncUserBlockList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getSyncUserBlockList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSyncUserBlockList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/SyncBlockUserApiResponse;", "GetGetSyncUserBlockList_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse GetSyncUserBlockList (string p0)
		{
			if (id_getSyncUserBlockList_Ljava_lang_String_ == IntPtr.Zero)
				id_getSyncUserBlockList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSyncUserBlockList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/SyncBlockUserApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncUserBlockList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSyncUserBlockList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/SyncBlockUserApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUserDetails_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGetUserDetails_Ljava_util_Set_Handler ()
		{
			if (cb_getUserDetails_Ljava_util_Set_ == null)
				cb_getUserDetails_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserDetails_Ljava_util_Set_);
			return cb_getUserDetails_Ljava_util_Set_;
		}

		static IntPtr n_GetUserDetails_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetUserDetails (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetails_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserDetails' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getUserDetails", "(Ljava/util/Set;)Ljava/lang/String;", "GetGetUserDetails_Ljava_util_Set_Handler")]
		public virtual unsafe string GetUserDetails (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_getUserDetails_Ljava_util_Set_ == IntPtr.Zero)
				id_getUserDetails_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "getUserDetails", "(Ljava/util/Set;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetails_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetails", "(Ljava/util/Set;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUserInfo_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetGetUserInfo_Ljava_util_Set_Handler ()
		{
			if (cb_getUserInfo_Ljava_util_Set_ == null)
				cb_getUserInfo_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserInfo_Ljava_util_Set_);
			return cb_getUserInfo_Ljava_util_Set_;
		}

		static IntPtr n_GetUserInfo_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetUserInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserInfo_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='getUserInfo' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("getUserInfo", "(Ljava/util/Set;)Ljava/util/Map;", "GetGetUserInfo_Ljava_util_Set_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetUserInfo (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_getUserInfo_Ljava_util_Set_ == IntPtr.Zero)
				id_getUserInfo_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "getUserInfo", "(Ljava/util/Set;)Ljava/util/Map;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IDictionary<string, string> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserInfo_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserInfo", "(Ljava/util/Set;)Ljava/util/Map;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_logout;
#pragma warning disable 0169
		static Delegate GetLogoutHandler ()
		{
			if (cb_logout == null)
				cb_logout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Logout);
			return cb_logout;
		}

		static IntPtr n_Logout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logout ());
		}
#pragma warning restore 0169

		static IntPtr id_logout;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='logout' and count(parameter)=0]"
		[Register ("logout", "()Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetLogoutHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse Logout ()
		{
			if (id_logout == IntPtr.Zero)
				id_logout = JNIEnv.GetMethodID (class_ref, "logout", "()Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_logout), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "()Lcom/applozic/mobicomkit/feed/ApiResponse;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_logout_Z;
#pragma warning disable 0169
		static Delegate GetLogout_ZHandler ()
		{
			if (cb_logout_Z == null)
				cb_logout_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Logout_Z);
			return cb_logout_Z;
		}

		static IntPtr n_Logout_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Logout (p0));
		}
#pragma warning restore 0169

		static IntPtr id_logout_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='logout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("logout", "(Z)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetLogout_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse Logout (bool p0)
		{
			if (id_logout_Z == IntPtr.Zero)
				id_logout_Z = JNIEnv.GetMethodID (class_ref, "logout", "(Z)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_logout_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "logout", "(Z)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_notifyFriendsAboutJoiningThePlatform;
#pragma warning disable 0169
		static Delegate GetNotifyFriendsAboutJoiningThePlatformHandler ()
		{
			if (cb_notifyFriendsAboutJoiningThePlatform == null)
				cb_notifyFriendsAboutJoiningThePlatform = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyFriendsAboutJoiningThePlatform);
			return cb_notifyFriendsAboutJoiningThePlatform;
		}

		static void n_NotifyFriendsAboutJoiningThePlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyFriendsAboutJoiningThePlatform ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyFriendsAboutJoiningThePlatform;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='notifyFriendsAboutJoiningThePlatform' and count(parameter)=0]"
		[Register ("notifyFriendsAboutJoiningThePlatform", "()V", "GetNotifyFriendsAboutJoiningThePlatformHandler")]
		public virtual unsafe void NotifyFriendsAboutJoiningThePlatform ()
		{
			if (id_notifyFriendsAboutJoiningThePlatform == IntPtr.Zero)
				id_notifyFriendsAboutJoiningThePlatform = JNIEnv.GetMethodID (class_ref, "notifyFriendsAboutJoiningThePlatform", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyFriendsAboutJoiningThePlatform);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyFriendsAboutJoiningThePlatform", "()V"));
			} finally {
			}
		}

		static Delegate cb_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_;
#pragma warning disable 0169
		static Delegate GetPackageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_Handler ()
		{
			if (cb_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_ == null)
				cb_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PackageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_);
			return cb_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_;
		}

		static IntPtr n_PackageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.User.CustomerPackageDetail p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.CustomerPackageDetail> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PackageDetail (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='packageDetail' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.user.CustomerPackageDetail']]"
		[Register ("packageDetail", "(Lcom/applozic/mobicomkit/api/account/user/CustomerPackageDetail;)Ljava/lang/String;", "GetPackageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_Handler")]
		public virtual unsafe string PackageDetail (global::Com.Applozic.Mobicomkit.Api.Account.User.CustomerPackageDetail p0)
		{
			if (id_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_ == IntPtr.Zero)
				id_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_ = JNIEnv.GetMethodID (class_ref, "packageDetail", "(Lcom/applozic/mobicomkit/api/account/user/CustomerPackageDetail;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_packageDetail_Lcom_applozic_mobicomkit_api_account_user_CustomerPackageDetail_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "packageDetail", "(Lcom/applozic/mobicomkit/api/account/user/CustomerPackageDetail;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_postUserDetailsByUserIds_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetPostUserDetailsByUserIds_Ljava_util_Set_Handler ()
		{
			if (cb_postUserDetailsByUserIds_Ljava_util_Set_ == null)
				cb_postUserDetailsByUserIds_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PostUserDetailsByUserIds_Ljava_util_Set_);
			return cb_postUserDetailsByUserIds_Ljava_util_Set_;
		}

		static IntPtr n_PostUserDetailsByUserIds_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PostUserDetailsByUserIds (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postUserDetailsByUserIds_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='postUserDetailsByUserIds' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("postUserDetailsByUserIds", "(Ljava/util/Set;)Ljava/lang/String;", "GetPostUserDetailsByUserIds_Ljava_util_Set_Handler")]
		public virtual unsafe string PostUserDetailsByUserIds (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_postUserDetailsByUserIds_Ljava_util_Set_ == IntPtr.Zero)
				id_postUserDetailsByUserIds_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "postUserDetailsByUserIds", "(Ljava/util/Set;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postUserDetailsByUserIds_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postUserDetailsByUserIds", "(Ljava/util/Set;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_SendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_SendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendPhoneNumberForVerification (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='sendPhoneNumberForVerification' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("sendPhoneNumberForVerification", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "GetSendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe string SendPhoneNumberForVerification (string p0, string p1, bool p2)
		{
			if (id_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "sendPhoneNumberForVerification", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendPhoneNumberForVerification_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPhoneNumberForVerification", "(Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendVerificationCodeToServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendVerificationCodeToServer_Ljava_lang_String_Handler ()
		{
			if (cb_sendVerificationCodeToServer_Ljava_lang_String_ == null)
				cb_sendVerificationCodeToServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SendVerificationCodeToServer_Ljava_lang_String_);
			return cb_sendVerificationCodeToServer_Ljava_lang_String_;
		}

		static bool n_SendVerificationCodeToServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SendVerificationCodeToServer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendVerificationCodeToServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='sendVerificationCodeToServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendVerificationCodeToServer", "(Ljava/lang/String;)Z", "GetSendVerificationCodeToServer_Ljava_lang_String_Handler")]
		public virtual unsafe bool SendVerificationCodeToServer (string p0)
		{
			if (id_sendVerificationCodeToServer_Ljava_lang_String_ == IntPtr.Zero)
				id_sendVerificationCodeToServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendVerificationCodeToServer", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_sendVerificationCodeToServer_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendVerificationCodeToServer", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateCodeVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateCodeVersion_Ljava_lang_String_Handler ()
		{
			if (cb_updateCodeVersion_Ljava_lang_String_ == null)
				cb_updateCodeVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateCodeVersion_Ljava_lang_String_);
			return cb_updateCodeVersion_Ljava_lang_String_;
		}

		static void n_UpdateCodeVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCodeVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateCodeVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updateCodeVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateCodeVersion", "(Ljava/lang/String;)V", "GetUpdateCodeVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateCodeVersion (string p0)
		{
			if (id_updateCodeVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_updateCodeVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateCodeVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCodeVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCodeVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateDisplayNameORImageLink (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updateDisplayNameORImageLink' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UpdateDisplayNameORImageLink (string p0, string p1, string p2)
		{
			if (id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_updatePhoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePhoneNumber_Ljava_lang_String_Handler ()
		{
			if (cb_updatePhoneNumber_Ljava_lang_String_ == null)
				cb_updatePhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePhoneNumber_Ljava_lang_String_);
			return cb_updatePhoneNumber_Ljava_lang_String_;
		}

		static IntPtr n_UpdatePhoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdatePhoneNumber (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updatePhoneNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updatePhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updatePhoneNumber", "(Ljava/lang/String;)Ljava/lang/String;", "GetUpdatePhoneNumber_Ljava_lang_String_Handler")]
		public virtual unsafe string UpdatePhoneNumber (string p0)
		{
			if (id_updatePhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_updatePhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updatePhoneNumber", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updatePhoneNumber_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePhoneNumber", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateSetting_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateSetting_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateSetting_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateSetting_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateSetting_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateSetting_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateSetting_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSetting (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateSetting_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updateSetting' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateSetting", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateSetting_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateSetting (string p0, string p1)
		{
			if (id_updateSetting_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateSetting_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateSetting", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSetting_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSetting", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateUserDisplayName_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateUserDisplayName_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateUserDisplayName_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserDisplayName (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updateUserDisplayName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateUserDisplayName", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateUserDisplayName_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateUserDisplayName (string p0, string p1)
		{
			if (id_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateUserDisplayName", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserDisplayName_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserDisplayName", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateUserPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateUserPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateUserPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateUserPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateUserPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdateUserPassword (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateUserPassword_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='updateUserPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string UpdateUserPassword (string p0, string p1)
		{
			if (id_updateUserPassword_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateUserPassword_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateUserPassword_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_userBlock_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUserBlock_Ljava_lang_String_ZHandler ()
		{
			if (cb_userBlock_Ljava_lang_String_Z == null)
				cb_userBlock_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_UserBlock_Ljava_lang_String_Z);
			return cb_userBlock_Ljava_lang_String_Z;
		}

		static IntPtr n_UserBlock_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UserBlock (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_userBlock_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='userBlock' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("userBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetUserBlock_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UserBlock (string p0, bool p1)
		{
			if (id_userBlock_Ljava_lang_String_Z == IntPtr.Zero)
				id_userBlock_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "userBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_userBlock_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_userLogoutResponse;
#pragma warning disable 0169
		static Delegate GetUserLogoutResponseHandler ()
		{
			if (cb_userLogoutResponse == null)
				cb_userLogoutResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_UserLogoutResponse);
			return cb_userLogoutResponse;
		}

		static IntPtr n_UserLogoutResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserLogoutResponse ());
		}
#pragma warning restore 0169

		static IntPtr id_userLogoutResponse;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='userLogoutResponse' and count(parameter)=0]"
		[Register ("userLogoutResponse", "()Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetUserLogoutResponseHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UserLogoutResponse ()
		{
			if (id_userLogoutResponse == IntPtr.Zero)
				id_userLogoutResponse = JNIEnv.GetMethodID (class_ref, "userLogoutResponse", "()Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_userLogoutResponse), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userLogoutResponse", "()Lcom/applozic/mobicomkit/feed/ApiResponse;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_userUnBlock_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUserUnBlock_Ljava_lang_String_Handler ()
		{
			if (cb_userUnBlock_Ljava_lang_String_ == null)
				cb_userUnBlock_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UserUnBlock_Ljava_lang_String_);
			return cb_userUnBlock_Ljava_lang_String_;
		}

		static IntPtr n_UserUnBlock_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UserUnBlock (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_userUnBlock_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserClientService']/method[@name='userUnBlock' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("userUnBlock", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetUserUnBlock_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UserUnBlock (string p0)
		{
			if (id_userUnBlock_Ljava_lang_String_ == IntPtr.Zero)
				id_userUnBlock_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "userUnBlock", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_userUnBlock_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "userUnBlock", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
