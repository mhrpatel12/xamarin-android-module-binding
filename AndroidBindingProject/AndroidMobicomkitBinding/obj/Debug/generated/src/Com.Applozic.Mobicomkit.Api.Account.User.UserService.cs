using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/UserService", DoNotGenerateAcw=true)]
	public partial class UserService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/UserService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserService); }
		}

		protected UserService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getMutedUserList;
#pragma warning disable 0169
		static Delegate GetGetMutedUserListHandler ()
		{
			if (cb_getMutedUserList == null)
				cb_getMutedUserList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMutedUserList);
			return cb_getMutedUserList;
		}

		static IntPtr n_GetMutedUserList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse>.ToLocalJniHandle (__this.MutedUserList);
		}
#pragma warning restore 0169

		static IntPtr id_getMutedUserList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> MutedUserList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='getMutedUserList' and count(parameter)=0]"
			[Register ("getMutedUserList", "()Ljava/util/List;", "GetGetMutedUserListHandler")]
			get {
				if (id_getMutedUserList == IntPtr.Zero)
					id_getMutedUserList = JNIEnv.GetMethodID (class_ref, "getMutedUserList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMutedUserList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMutedUserList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/account/user/UserService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.UserService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/account/user/UserService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getOnlineUsers_I;
#pragma warning disable 0169
		static Delegate GetGetOnlineUsers_IHandler ()
		{
			if (cb_getOnlineUsers_I == null)
				cb_getOnlineUsers_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetOnlineUsers_I);
			return cb_getOnlineUsers_I;
		}

		static IntPtr n_GetOnlineUsers_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetOnlineUsers (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getOnlineUsers_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='getOnlineUsers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOnlineUsers", "(I)[Ljava/lang/String;", "GetGetOnlineUsers_IHandler")]
		public virtual unsafe string[] GetOnlineUsers (int p0)
		{
			if (id_getOnlineUsers_I == IntPtr.Zero)
				id_getOnlineUsers_I = JNIEnv.GetMethodID (class_ref, "getOnlineUsers", "(I)[Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOnlineUsers_I, __args), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOnlineUsers", "(I)[Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getRegisteredUsersList_Ljava_lang_Long_I;
#pragma warning disable 0169
		static Delegate GetGetRegisteredUsersList_Ljava_lang_Long_IHandler ()
		{
			if (cb_getRegisteredUsersList_Ljava_lang_Long_I == null)
				cb_getRegisteredUsersList_Ljava_lang_Long_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetRegisteredUsersList_Ljava_lang_Long_I);
			return cb_getRegisteredUsersList_Ljava_lang_Long_I;
		}

		static IntPtr n_GetRegisteredUsersList_Ljava_lang_Long_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetRegisteredUsersList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getRegisteredUsersList_Ljava_lang_Long_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='getRegisteredUsersList' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='int']]"
		[Register ("getRegisteredUsersList", "(Ljava/lang/Long;I)Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;", "GetGetRegisteredUsersList_Ljava_lang_Long_IHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse GetRegisteredUsersList (global::Java.Lang.Long p0, int p1)
		{
			if (id_getRegisteredUsersList_Ljava_lang_Long_I == IntPtr.Zero)
				id_getRegisteredUsersList_Ljava_lang_Long_I = JNIEnv.GetMethodID (class_ref, "getRegisteredUsersList", "(Ljava/lang/Long;I)Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRegisteredUsersList_Ljava_lang_Long_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisteredUsersList", "(Ljava/lang/Long;I)Lcom/applozic/mobicomkit/feed/RegisteredUsersApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetMuteUserNotifications_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_MuteUserNotifications_Ljava_lang_String_Ljava_lang_Long_);
			return cb_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_;
		}

		static IntPtr n_MuteUserNotifications_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MuteUserNotifications (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='muteUserNotifications' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("muteUserNotifications", "(Ljava/lang/String;Ljava/lang/Long;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetMuteUserNotifications_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse MuteUserNotifications (string p0, global::Java.Lang.Long p1)
		{
			if (id_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "muteUserNotifications", "(Ljava/lang/String;Ljava/lang/Long;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_muteUserNotifications_Ljava_lang_String_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "muteUserNotifications", "(Ljava/lang/String;Ljava/lang/Long;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_;
#pragma warning disable 0169
		static Delegate GetProcessMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_Handler ()
		{
			if (cb_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_ == null)
				cb_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_);
			return cb_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_;
		}

		static void n_ProcessMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessMuteUserResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processMuteUserResponse' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.notification.MuteUserResponse']]"
		[Register ("processMuteUserResponse", "(Lcom/applozic/mobicomkit/api/notification/MuteUserResponse;)V", "GetProcessMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_Handler")]
		public virtual unsafe void ProcessMuteUserResponse (global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse p0)
		{
			if (id_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_ == IntPtr.Zero)
				id_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_ = JNIEnv.GetMethodID (class_ref, "processMuteUserResponse", "(Lcom/applozic/mobicomkit/api/notification/MuteUserResponse;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processMuteUserResponse_Lcom_applozic_mobicomkit_api_notification_MuteUserResponse_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processMuteUserResponse", "(Lcom/applozic/mobicomkit/api/notification/MuteUserResponse;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processPackageDetail;
#pragma warning disable 0169
		static Delegate GetProcessPackageDetailHandler ()
		{
			if (cb_processPackageDetail == null)
				cb_processPackageDetail = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessPackageDetail);
			return cb_processPackageDetail;
		}

		static void n_ProcessPackageDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessPackageDetail ();
		}
#pragma warning restore 0169

		static IntPtr id_processPackageDetail;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processPackageDetail' and count(parameter)=0]"
		[Register ("processPackageDetail", "()V", "GetProcessPackageDetailHandler")]
		public virtual unsafe void ProcessPackageDetail ()
		{
			if (id_processPackageDetail == IntPtr.Zero)
				id_processPackageDetail = JNIEnv.GetMethodID (class_ref, "processPackageDetail", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processPackageDetail);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processPackageDetail", "()V"));
			} finally {
			}
		}

		static Delegate cb_processSyncUserBlock;
#pragma warning disable 0169
		static Delegate GetProcessSyncUserBlockHandler ()
		{
			if (cb_processSyncUserBlock == null)
				cb_processSyncUserBlock = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessSyncUserBlock);
			return cb_processSyncUserBlock;
		}

		static void n_ProcessSyncUserBlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessSyncUserBlock ();
		}
#pragma warning restore 0169

		static IntPtr id_processSyncUserBlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processSyncUserBlock' and count(parameter)=0]"
		[Register ("processSyncUserBlock", "()V", "GetProcessSyncUserBlockHandler")]
		public virtual unsafe void ProcessSyncUserBlock ()
		{
			if (id_processSyncUserBlock == IntPtr.Zero)
				id_processSyncUserBlock = JNIEnv.GetMethodID (class_ref, "processSyncUserBlock", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processSyncUserBlock);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processSyncUserBlock", "()V"));
			} finally {
			}
		}

		static Delegate cb_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_);
			return cb_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ProcessUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ProcessUpdateUserPassword (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUpdateUserPassword' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("processUpdateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetProcessUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string ProcessUpdateUserPassword (string p0, string p1)
		{
			if (id_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processUpdateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processUpdateUserPassword_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUpdateUserPassword", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_;
#pragma warning disable 0169
		static Delegate GetProcessUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_Handler ()
		{
			if (cb_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_ == null)
				cb_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_);
			return cb_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_;
		}

		static void n_ProcessUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUser (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUser' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.user.UserDetail']]"
		[Register ("processUser", "(Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V", "GetProcessUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_Handler")]
		public virtual unsafe void ProcessUser (global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail p0)
		{
			if (id_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_ == IntPtr.Zero)
				id_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_ = JNIEnv.GetMethodID (class_ref, "processUser", "(Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUser_Lcom_applozic_mobicomkit_api_account_user_UserDetail_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUser", "(Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processUserBlock_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetProcessUserBlock_Ljava_lang_String_ZHandler ()
		{
			if (cb_processUserBlock_Ljava_lang_String_Z == null)
				cb_processUserBlock_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_ProcessUserBlock_Ljava_lang_String_Z);
			return cb_processUserBlock_Ljava_lang_String_Z;
		}

		static IntPtr n_ProcessUserBlock_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessUserBlock (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processUserBlock_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserBlock' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("processUserBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetProcessUserBlock_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse ProcessUserBlock (string p0, bool p1)
		{
			if (id_processUserBlock_Ljava_lang_String_Z == IntPtr.Zero)
				id_processUserBlock_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "processUserBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processUserBlock_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserBlock", "(Ljava/lang/String;Z)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserDetail_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetail_Ljava_util_Set_Handler ()
		{
			if (cb_processUserDetail_Ljava_util_Set_ == null)
				cb_processUserDetail_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetail_Ljava_util_Set_);
			return cb_processUserDetail_Ljava_util_Set_;
		}

		static void n_ProcessUserDetail_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetail (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetail_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserDetail' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.applozic.mobicomkit.api.account.user.UserDetail&gt;']]"
		[Register ("processUserDetail", "(Ljava/util/Set;)V", "GetProcessUserDetail_Ljava_util_Set_Handler")]
		public virtual unsafe void ProcessUserDetail (global::System.Collections.Generic.ICollection<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> p0)
		{
			if (id_processUserDetail_Ljava_util_Set_ == IntPtr.Zero)
				id_processUserDetail_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "processUserDetail", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetail_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetail", "(Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserDetails_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetails_Ljava_lang_String_Handler ()
		{
			if (cb_processUserDetails_Ljava_lang_String_ == null)
				cb_processUserDetails_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetails_Ljava_lang_String_);
			return cb_processUserDetails_Ljava_lang_String_;
		}

		static void n_ProcessUserDetails_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetails (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetails_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserDetails' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processUserDetails", "(Ljava/lang/String;)V", "GetProcessUserDetails_Ljava_lang_String_Handler")]
		public virtual unsafe void ProcessUserDetails (string p0)
		{
			if (id_processUserDetails_Ljava_lang_String_ == IntPtr.Zero)
				id_processUserDetails_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processUserDetails", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetails_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetails", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserDetails_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetails_Ljava_util_Set_Handler ()
		{
			if (cb_processUserDetails_Ljava_util_Set_ == null)
				cb_processUserDetails_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetails_Ljava_util_Set_);
			return cb_processUserDetails_Ljava_util_Set_;
		}

		static void n_ProcessUserDetails_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetails (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetails_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserDetails' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("processUserDetails", "(Ljava/util/Set;)V", "GetProcessUserDetails_Ljava_util_Set_Handler")]
		public virtual unsafe void ProcessUserDetails (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_processUserDetails_Ljava_util_Set_ == IntPtr.Zero)
				id_processUserDetails_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "processUserDetails", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetails_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetails", "(Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserDetailsByUserIds_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetailsByUserIds_Ljava_util_Set_Handler ()
		{
			if (cb_processUserDetailsByUserIds_Ljava_util_Set_ == null)
				cb_processUserDetailsByUserIds_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetailsByUserIds_Ljava_util_Set_);
			return cb_processUserDetailsByUserIds_Ljava_util_Set_;
		}

		static void n_ProcessUserDetailsByUserIds_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetailsByUserIds (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetailsByUserIds_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserDetailsByUserIds' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("processUserDetailsByUserIds", "(Ljava/util/Set;)V", "GetProcessUserDetailsByUserIds_Ljava_util_Set_Handler")]
		public virtual unsafe void ProcessUserDetailsByUserIds (global::System.Collections.Generic.ICollection<string> p0)
		{
			if (id_processUserDetailsByUserIds_Ljava_util_Set_ == IntPtr.Zero)
				id_processUserDetailsByUserIds_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "processUserDetailsByUserIds", "(Ljava/util/Set;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetailsByUserIds_Ljava_util_Set_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetailsByUserIds", "(Ljava/util/Set;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserDetailsResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetailsResponse_Ljava_lang_String_Handler ()
		{
			if (cb_processUserDetailsResponse_Ljava_lang_String_ == null)
				cb_processUserDetailsResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetailsResponse_Ljava_lang_String_);
			return cb_processUserDetailsResponse_Ljava_lang_String_;
		}

		static void n_ProcessUserDetailsResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetailsResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetailsResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserDetailsResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processUserDetailsResponse", "(Ljava/lang/String;)V", "GetProcessUserDetailsResponse_Ljava_lang_String_Handler")]
		public virtual unsafe void ProcessUserDetailsResponse (string p0)
		{
			if (id_processUserDetailsResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_processUserDetailsResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processUserDetailsResponse", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetailsResponse_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetailsResponse", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserReadConversation;
#pragma warning disable 0169
		static Delegate GetProcessUserReadConversationHandler ()
		{
			if (cb_processUserReadConversation == null)
				cb_processUserReadConversation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ProcessUserReadConversation);
			return cb_processUserReadConversation;
		}

		static IntPtr n_ProcessUserReadConversation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProcessUserReadConversation ());
		}
#pragma warning restore 0169

		static IntPtr id_processUserReadConversation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='processUserReadConversation' and count(parameter)=0]"
		[Register ("processUserReadConversation", "()Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetProcessUserReadConversationHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse ProcessUserReadConversation ()
		{
			if (id_processUserReadConversation == IntPtr.Zero)
				id_processUserReadConversation = JNIEnv.GetMethodID (class_ref, "processUserReadConversation", "()Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processUserReadConversation), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserReadConversation", "()Lcom/applozic/mobicomkit/feed/ApiResponse;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdateDisplayNameORImageLink (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='updateDisplayNameORImageLink' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string UpdateDisplayNameORImageLink (string p0, string p1, string p2, string p3)
		{
			if (id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_UpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.UpdateDisplayNameORImageLink (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserService']/method[@name='updateDisplayNameORImageLink' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetUpdateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string UpdateDisplayNameORImageLink (string p0, string p1, string p2, string p3, string p4)
		{
			if (id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateDisplayNameORImageLink_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDisplayNameORImageLink", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

	}
}
