using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/MobiComUserPreference", DoNotGenerateAcw=true)]
	public partial class MobiComUserPreference : global::Java.Lang.Object {


		static IntPtr sharedPreferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/field[@name='sharedPreferences']"
		[Register ("sharedPreferences")]
		public global::Android.Content.ISharedPreferences SharedPreferences {
			get {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userpref_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/field[@name='userpref']"
		[Register ("userpref")]
		public static global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference Userpref {
			get {
				if (userpref_jfieldId == IntPtr.Zero)
					userpref_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "userpref", "Lcom/applozic/mobicomkit/api/account/user/MobiComUserPreference;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, userpref_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userpref_jfieldId == IntPtr.Zero)
					userpref_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "userpref", "Lcom/applozic/mobicomkit/api/account/user/MobiComUserPreference;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, userpref_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/MobiComUserPreference", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComUserPreference); }
		}

		protected MobiComUserPreference (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApplicationInfoCall;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfoCallHandler ()
		{
			if (cb_getApplicationInfoCall == null)
				cb_getApplicationInfoCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetApplicationInfoCall);
			return cb_getApplicationInfoCall;
		}

		static bool n_GetApplicationInfoCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplicationInfoCall;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationInfoCall;
		public virtual unsafe bool ApplicationInfoCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getApplicationInfoCall' and count(parameter)=0]"
			[Register ("getApplicationInfoCall", "()Z", "GetGetApplicationInfoCallHandler")]
			get {
				if (id_getApplicationInfoCall == IntPtr.Zero)
					id_getApplicationInfoCall = JNIEnv.GetMethodID (class_ref, "getApplicationInfoCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationInfoCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationInfoCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getAuthenticationType;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationTypeHandler ()
		{
			if (cb_getAuthenticationType == null)
				cb_getAuthenticationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthenticationType);
			return cb_getAuthenticationType;
		}

		static IntPtr n_GetAuthenticationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthenticationType);
		}
#pragma warning restore 0169

		static Delegate cb_setAuthenticationType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAuthenticationType_Ljava_lang_String_Handler ()
		{
			if (cb_setAuthenticationType_Ljava_lang_String_ == null)
				cb_setAuthenticationType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthenticationType_Ljava_lang_String_);
			return cb_setAuthenticationType_Ljava_lang_String_;
		}

		static void n_SetAuthenticationType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AuthenticationType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAuthenticationType;
		static IntPtr id_setAuthenticationType_Ljava_lang_String_;
		public virtual unsafe string AuthenticationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getAuthenticationType' and count(parameter)=0]"
			[Register ("getAuthenticationType", "()Ljava/lang/String;", "GetGetAuthenticationTypeHandler")]
			get {
				if (id_getAuthenticationType == IntPtr.Zero)
					id_getAuthenticationType = JNIEnv.GetMethodID (class_ref, "getAuthenticationType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthenticationType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthenticationType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setAuthenticationType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAuthenticationType", "(Ljava/lang/String;)V", "GetSetAuthenticationType_Ljava_lang_String_Handler")]
			set {
				if (id_setAuthenticationType_Ljava_lang_String_ == IntPtr.Zero)
					id_setAuthenticationType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAuthenticationType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthenticationType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthenticationType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAutoDownloadOnCellular;
#pragma warning disable 0169
		static Delegate GetGetAutoDownloadOnCellularHandler ()
		{
			if (cb_getAutoDownloadOnCellular == null)
				cb_getAutoDownloadOnCellular = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoDownloadOnCellular);
			return cb_getAutoDownloadOnCellular;
		}

		static bool n_GetAutoDownloadOnCellular (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoDownloadOnCellular;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoDownloadOnCellular_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoDownloadOnCellular_ZHandler ()
		{
			if (cb_setAutoDownloadOnCellular_Z == null)
				cb_setAutoDownloadOnCellular_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoDownloadOnCellular_Z);
			return cb_setAutoDownloadOnCellular_Z;
		}

		static void n_SetAutoDownloadOnCellular_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoDownloadOnCellular = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoDownloadOnCellular;
		static IntPtr id_setAutoDownloadOnCellular_Z;
		public virtual unsafe bool AutoDownloadOnCellular {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getAutoDownloadOnCellular' and count(parameter)=0]"
			[Register ("getAutoDownloadOnCellular", "()Z", "GetGetAutoDownloadOnCellularHandler")]
			get {
				if (id_getAutoDownloadOnCellular == IntPtr.Zero)
					id_getAutoDownloadOnCellular = JNIEnv.GetMethodID (class_ref, "getAutoDownloadOnCellular", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoDownloadOnCellular);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoDownloadOnCellular", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setAutoDownloadOnCellular' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoDownloadOnCellular", "(Z)V", "GetSetAutoDownloadOnCellular_ZHandler")]
			set {
				if (id_setAutoDownloadOnCellular_Z == IntPtr.Zero)
					id_setAutoDownloadOnCellular_Z = JNIEnv.GetMethodID (class_ref, "setAutoDownloadOnCellular", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoDownloadOnCellular_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoDownloadOnCellular", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAutoDownloadOnWifi;
#pragma warning disable 0169
		static Delegate GetGetAutoDownloadOnWifiHandler ()
		{
			if (cb_getAutoDownloadOnWifi == null)
				cb_getAutoDownloadOnWifi = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAutoDownloadOnWifi);
			return cb_getAutoDownloadOnWifi;
		}

		static bool n_GetAutoDownloadOnWifi (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoDownloadOnWifi;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoDownloadOnWifi_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoDownloadOnWifi_ZHandler ()
		{
			if (cb_setAutoDownloadOnWifi_Z == null)
				cb_setAutoDownloadOnWifi_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoDownloadOnWifi_Z);
			return cb_setAutoDownloadOnWifi_Z;
		}

		static void n_SetAutoDownloadOnWifi_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoDownloadOnWifi = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAutoDownloadOnWifi;
		static IntPtr id_setAutoDownloadOnWifi_Z;
		public virtual unsafe bool AutoDownloadOnWifi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getAutoDownloadOnWifi' and count(parameter)=0]"
			[Register ("getAutoDownloadOnWifi", "()Z", "GetGetAutoDownloadOnWifiHandler")]
			get {
				if (id_getAutoDownloadOnWifi == IntPtr.Zero)
					id_getAutoDownloadOnWifi = JNIEnv.GetMethodID (class_ref, "getAutoDownloadOnWifi", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAutoDownloadOnWifi);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAutoDownloadOnWifi", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setAutoDownloadOnWifi' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoDownloadOnWifi", "(Z)V", "GetSetAutoDownloadOnWifi_ZHandler")]
			set {
				if (id_setAutoDownloadOnWifi_Z == IntPtr.Zero)
					id_setAutoDownloadOnWifi_Z = JNIEnv.GetMethodID (class_ref, "setAutoDownloadOnWifi", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAutoDownloadOnWifi_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAutoDownloadOnWifi", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelSyncTime;
#pragma warning disable 0169
		static Delegate GetGetChannelSyncTimeHandler ()
		{
			if (cb_getChannelSyncTime == null)
				cb_getChannelSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelSyncTime);
			return cb_getChannelSyncTime;
		}

		static IntPtr n_GetChannelSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setChannelSyncTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetChannelSyncTime_Ljava_lang_String_Handler ()
		{
			if (cb_setChannelSyncTime_Ljava_lang_String_ == null)
				cb_setChannelSyncTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannelSyncTime_Ljava_lang_String_);
			return cb_setChannelSyncTime_Ljava_lang_String_;
		}

		static void n_SetChannelSyncTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChannelSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelSyncTime;
		static IntPtr id_setChannelSyncTime_Ljava_lang_String_;
		public virtual unsafe string ChannelSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getChannelSyncTime' and count(parameter)=0]"
			[Register ("getChannelSyncTime", "()Ljava/lang/String;", "GetGetChannelSyncTimeHandler")]
			get {
				if (id_getChannelSyncTime == IntPtr.Zero)
					id_getChannelSyncTime = JNIEnv.GetMethodID (class_ref, "getChannelSyncTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelSyncTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setChannelSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setChannelSyncTime", "(Ljava/lang/String;)V", "GetSetChannelSyncTime_Ljava_lang_String_Handler")]
			set {
				if (id_setChannelSyncTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setChannelSyncTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setChannelSyncTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannelSyncTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelSyncTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCompressedImageSizeInMB;
#pragma warning disable 0169
		static Delegate GetGetCompressedImageSizeInMBHandler ()
		{
			if (cb_getCompressedImageSizeInMB == null)
				cb_getCompressedImageSizeInMB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCompressedImageSizeInMB);
			return cb_getCompressedImageSizeInMB;
		}

		static int n_GetCompressedImageSizeInMB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompressedImageSizeInMB;
		}
#pragma warning restore 0169

		static Delegate cb_setCompressedImageSizeInMB_I;
#pragma warning disable 0169
		static Delegate GetSetCompressedImageSizeInMB_IHandler ()
		{
			if (cb_setCompressedImageSizeInMB_I == null)
				cb_setCompressedImageSizeInMB_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCompressedImageSizeInMB_I);
			return cb_setCompressedImageSizeInMB_I;
		}

		static void n_SetCompressedImageSizeInMB_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompressedImageSizeInMB = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCompressedImageSizeInMB;
		static IntPtr id_setCompressedImageSizeInMB_I;
		public virtual unsafe int CompressedImageSizeInMB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getCompressedImageSizeInMB' and count(parameter)=0]"
			[Register ("getCompressedImageSizeInMB", "()I", "GetGetCompressedImageSizeInMBHandler")]
			get {
				if (id_getCompressedImageSizeInMB == IntPtr.Zero)
					id_getCompressedImageSizeInMB = JNIEnv.GetMethodID (class_ref, "getCompressedImageSizeInMB", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCompressedImageSizeInMB);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCompressedImageSizeInMB", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setCompressedImageSizeInMB' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCompressedImageSizeInMB", "(I)V", "GetSetCompressedImageSizeInMB_IHandler")]
			set {
				if (id_setCompressedImageSizeInMB_I == IntPtr.Zero)
					id_setCompressedImageSizeInMB_I = JNIEnv.GetMethodID (class_ref, "setCompressedImageSizeInMB", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCompressedImageSizeInMB_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCompressedImageSizeInMB", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContactNumber;
#pragma warning disable 0169
		static Delegate GetGetContactNumberHandler ()
		{
			if (cb_getContactNumber == null)
				cb_getContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactNumber);
			return cb_getContactNumber;
		}

		static IntPtr n_GetContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setContactNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContactNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setContactNumber_Ljava_lang_String_ == null)
				cb_setContactNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactNumber_Ljava_lang_String_);
			return cb_setContactNumber_Ljava_lang_String_;
		}

		static void n_SetContactNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getContactNumber' and count(parameter)=0]"
			[Register ("getContactNumber", "()Ljava/lang/String;", "GetGetContactNumberHandler")]
			get {
				if (id_getContactNumber == IntPtr.Zero)
					id_getContactNumber = JNIEnv.GetMethodID (class_ref, "getContactNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContactNumber", "(Ljava/lang/String;)V", "GetSetContactNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setContactNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setContactNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContactNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCountryCode;
#pragma warning disable 0169
		static Delegate GetGetCountryCodeHandler ()
		{
			if (cb_getCountryCode == null)
				cb_getCountryCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCountryCode);
			return cb_getCountryCode;
		}

		static IntPtr n_GetCountryCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountryCode);
		}
#pragma warning restore 0169

		static Delegate cb_setCountryCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountryCode_Ljava_lang_String_Handler ()
		{
			if (cb_setCountryCode_Ljava_lang_String_ == null)
				cb_setCountryCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountryCode_Ljava_lang_String_);
			return cb_setCountryCode_Ljava_lang_String_;
		}

		static void n_SetCountryCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountryCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCountryCode;
		static IntPtr id_setCountryCode_Ljava_lang_String_;
		public virtual unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				if (id_getCountryCode == IntPtr.Zero)
					id_getCountryCode = JNIEnv.GetMethodID (class_ref, "getCountryCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCountryCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCountryCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setCountryCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountryCode", "(Ljava/lang/String;)V", "GetSetCountryCode_Ljava_lang_String_Handler")]
			set {
				if (id_setCountryCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setCountryCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountryCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountryCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountryCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceKeyString;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyStringHandler ()
		{
			if (cb_getDeviceKeyString == null)
				cb_getDeviceKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceKeyString);
			return cb_getDeviceKeyString;
		}

		static IntPtr n_GetDeviceKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceKeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceKeyString_Ljava_lang_String_ == null)
				cb_setDeviceKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceKeyString_Ljava_lang_String_);
			return cb_setDeviceKeyString_Ljava_lang_String_;
		}

		static void n_SetDeviceKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceKeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceKeyString;
		static IntPtr id_setDeviceKeyString_Ljava_lang_String_;
		public virtual unsafe string DeviceKeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getDeviceKeyString' and count(parameter)=0]"
			[Register ("getDeviceKeyString", "()Ljava/lang/String;", "GetGetDeviceKeyStringHandler")]
			get {
				if (id_getDeviceKeyString == IntPtr.Zero)
					id_getDeviceKeyString = JNIEnv.GetMethodID (class_ref, "getDeviceKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDeviceKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceKeyString", "(Ljava/lang/String;)V", "GetSetDeviceKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceRegistrationId;
#pragma warning disable 0169
		static Delegate GetGetDeviceRegistrationIdHandler ()
		{
			if (cb_getDeviceRegistrationId == null)
				cb_getDeviceRegistrationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceRegistrationId);
			return cb_getDeviceRegistrationId;
		}

		static IntPtr n_GetDeviceRegistrationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceRegistrationId);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceRegistrationId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceRegistrationId_Ljava_lang_String_ == null)
				cb_setDeviceRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceRegistrationId_Ljava_lang_String_);
			return cb_setDeviceRegistrationId_Ljava_lang_String_;
		}

		static void n_SetDeviceRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceRegistrationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceRegistrationId;
		static IntPtr id_setDeviceRegistrationId_Ljava_lang_String_;
		public virtual unsafe string DeviceRegistrationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getDeviceRegistrationId' and count(parameter)=0]"
			[Register ("getDeviceRegistrationId", "()Ljava/lang/String;", "GetGetDeviceRegistrationIdHandler")]
			get {
				if (id_getDeviceRegistrationId == IntPtr.Zero)
					id_getDeviceRegistrationId = JNIEnv.GetMethodID (class_ref, "getDeviceRegistrationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceRegistrationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceRegistrationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDeviceRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceRegistrationId", "(Ljava/lang/String;)V", "GetSetDeviceRegistrationId_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceRegistrationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceRegistrationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceRegistrationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeviceTimeOffset;
#pragma warning disable 0169
		static Delegate GetGetDeviceTimeOffsetHandler ()
		{
			if (cb_getDeviceTimeOffset == null)
				cb_getDeviceTimeOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetDeviceTimeOffset);
			return cb_getDeviceTimeOffset;
		}

		static long n_GetDeviceTimeOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceTimeOffset;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceTimeOffset;
		public virtual unsafe long DeviceTimeOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getDeviceTimeOffset' and count(parameter)=0]"
			[Register ("getDeviceTimeOffset", "()J", "GetGetDeviceTimeOffsetHandler")]
			get {
				if (id_getDeviceTimeOffset == IntPtr.Zero)
					id_getDeviceTimeOffset = JNIEnv.GetMethodID (class_ref, "getDeviceTimeOffset", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceTimeOffset);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceTimeOffset", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_isDisplayCallRecordEnable;
#pragma warning disable 0169
		static Delegate GetIsDisplayCallRecordEnableHandler ()
		{
			if (cb_isDisplayCallRecordEnable == null)
				cb_isDisplayCallRecordEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisplayCallRecordEnable);
			return cb_isDisplayCallRecordEnable;
		}

		static bool n_IsDisplayCallRecordEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayCallRecordEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayCallRecordEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetDisplayCallRecordEnable_ZHandler ()
		{
			if (cb_setDisplayCallRecordEnable_Z == null)
				cb_setDisplayCallRecordEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDisplayCallRecordEnable_Z);
			return cb_setDisplayCallRecordEnable_Z;
		}

		static void n_SetDisplayCallRecordEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisplayCallRecordEnable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDisplayCallRecordEnable;
		static IntPtr id_setDisplayCallRecordEnable_Z;
		public virtual unsafe bool DisplayCallRecordEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isDisplayCallRecordEnable' and count(parameter)=0]"
			[Register ("isDisplayCallRecordEnable", "()Z", "GetIsDisplayCallRecordEnableHandler")]
			get {
				if (id_isDisplayCallRecordEnable == IntPtr.Zero)
					id_isDisplayCallRecordEnable = JNIEnv.GetMethodID (class_ref, "isDisplayCallRecordEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisplayCallRecordEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisplayCallRecordEnable", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDisplayCallRecordEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDisplayCallRecordEnable", "(Z)V", "GetSetDisplayCallRecordEnable_ZHandler")]
			set {
				if (id_setDisplayCallRecordEnable_Z == IntPtr.Zero)
					id_setDisplayCallRecordEnable_Z = JNIEnv.GetMethodID (class_ref, "setDisplayCallRecordEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayCallRecordEnable_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayCallRecordEnable", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplayName_Ljava_lang_String_ == null)
				cb_setDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_setDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplayName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplayName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmailIdValue;
#pragma warning disable 0169
		static Delegate GetGetEmailIdValueHandler ()
		{
			if (cb_getEmailIdValue == null)
				cb_getEmailIdValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailIdValue);
			return cb_getEmailIdValue;
		}

		static IntPtr n_GetEmailIdValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmailIdValue);
		}
#pragma warning restore 0169

		static Delegate cb_setEmailIdValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmailIdValue_Ljava_lang_String_Handler ()
		{
			if (cb_setEmailIdValue_Ljava_lang_String_ == null)
				cb_setEmailIdValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmailIdValue_Ljava_lang_String_);
			return cb_setEmailIdValue_Ljava_lang_String_;
		}

		static void n_SetEmailIdValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmailIdValue = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmailIdValue;
		static IntPtr id_setEmailIdValue_Ljava_lang_String_;
		public virtual unsafe string EmailIdValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getEmailIdValue' and count(parameter)=0]"
			[Register ("getEmailIdValue", "()Ljava/lang/String;", "GetGetEmailIdValueHandler")]
			get {
				if (id_getEmailIdValue == IntPtr.Zero)
					id_getEmailIdValue = JNIEnv.GetMethodID (class_ref, "getEmailIdValue", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailIdValue), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmailIdValue", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setEmailIdValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmailIdValue", "(Ljava/lang/String;)V", "GetSetEmailIdValue_Ljava_lang_String_Handler")]
			set {
				if (id_setEmailIdValue_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmailIdValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmailIdValue", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailIdValue_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailIdValue", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isEmailVerified;
#pragma warning disable 0169
		static Delegate GetIsEmailVerifiedHandler ()
		{
			if (cb_isEmailVerified == null)
				cb_isEmailVerified = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmailVerified);
			return cb_isEmailVerified;
		}

		static bool n_IsEmailVerified (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EmailVerified;
		}
#pragma warning restore 0169

		static Delegate cb_setEmailVerified_Z;
#pragma warning disable 0169
		static Delegate GetSetEmailVerified_ZHandler ()
		{
			if (cb_setEmailVerified_Z == null)
				cb_setEmailVerified_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEmailVerified_Z);
			return cb_setEmailVerified_Z;
		}

		static void n_SetEmailVerified_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EmailVerified = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEmailVerified;
		static IntPtr id_setEmailVerified_Z;
		public virtual unsafe bool EmailVerified {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isEmailVerified' and count(parameter)=0]"
			[Register ("isEmailVerified", "()Z", "GetIsEmailVerifiedHandler")]
			get {
				if (id_isEmailVerified == IntPtr.Zero)
					id_isEmailVerified = JNIEnv.GetMethodID (class_ref, "isEmailVerified", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEmailVerified);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEmailVerified", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setEmailVerified' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEmailVerified", "(Z)V", "GetSetEmailVerified_ZHandler")]
			set {
				if (id_setEmailVerified_Z == IntPtr.Zero)
					id_setEmailVerified_Z = JNIEnv.GetMethodID (class_ref, "setEmailVerified", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailVerified_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailVerified", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEncryptionKey;
#pragma warning disable 0169
		static Delegate GetGetEncryptionKeyHandler ()
		{
			if (cb_getEncryptionKey == null)
				cb_getEncryptionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptionKey);
			return cb_getEncryptionKey;
		}

		static IntPtr n_GetEncryptionKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptionKey);
		}
#pragma warning restore 0169

		static Delegate cb_setEncryptionKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncryptionKey_Ljava_lang_String_Handler ()
		{
			if (cb_setEncryptionKey_Ljava_lang_String_ == null)
				cb_setEncryptionKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncryptionKey_Ljava_lang_String_);
			return cb_setEncryptionKey_Ljava_lang_String_;
		}

		static void n_SetEncryptionKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncryptionKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptionKey;
		static IntPtr id_setEncryptionKey_Ljava_lang_String_;
		public virtual unsafe string EncryptionKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getEncryptionKey' and count(parameter)=0]"
			[Register ("getEncryptionKey", "()Ljava/lang/String;", "GetGetEncryptionKeyHandler")]
			get {
				if (id_getEncryptionKey == IntPtr.Zero)
					id_getEncryptionKey = JNIEnv.GetMethodID (class_ref, "getEncryptionKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptionKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptionKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setEncryptionKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncryptionKey", "(Ljava/lang/String;)V", "GetSetEncryptionKey_Ljava_lang_String_Handler")]
			set {
				if (id_setEncryptionKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncryptionKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncryptionKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncryptionKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncryptionKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGroupSmsDelayInSec;
#pragma warning disable 0169
		static Delegate GetGetGroupSmsDelayInSecHandler ()
		{
			if (cb_getGroupSmsDelayInSec == null)
				cb_getGroupSmsDelayInSec = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGroupSmsDelayInSec);
			return cb_getGroupSmsDelayInSec;
		}

		static int n_GetGroupSmsDelayInSec (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GroupSmsDelayInSec;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupSmsDelayInSec;
		public virtual unsafe int GroupSmsDelayInSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getGroupSmsDelayInSec' and count(parameter)=0]"
			[Register ("getGroupSmsDelayInSec", "()I", "GetGetGroupSmsDelayInSecHandler")]
			get {
				if (id_getGroupSmsDelayInSec == IntPtr.Zero)
					id_getGroupSmsDelayInSec = JNIEnv.GetMethodID (class_ref, "getGroupSmsDelayInSec", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGroupSmsDelayInSec);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupSmsDelayInSec", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isImageCompressionEnabled;
#pragma warning disable 0169
		static Delegate GetIsImageCompressionEnabledHandler ()
		{
			if (cb_isImageCompressionEnabled == null)
				cb_isImageCompressionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImageCompressionEnabled);
			return cb_isImageCompressionEnabled;
		}

		static bool n_IsImageCompressionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ImageCompressionEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setImageCompressionEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetImageCompressionEnabled_ZHandler ()
		{
			if (cb_setImageCompressionEnabled_Z == null)
				cb_setImageCompressionEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetImageCompressionEnabled_Z);
			return cb_setImageCompressionEnabled_Z;
		}

		static void n_SetImageCompressionEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageCompressionEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isImageCompressionEnabled;
		static IntPtr id_setImageCompressionEnabled_Z;
		public virtual unsafe bool ImageCompressionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isImageCompressionEnabled' and count(parameter)=0]"
			[Register ("isImageCompressionEnabled", "()Z", "GetIsImageCompressionEnabledHandler")]
			get {
				if (id_isImageCompressionEnabled == IntPtr.Zero)
					id_isImageCompressionEnabled = JNIEnv.GetMethodID (class_ref, "isImageCompressionEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImageCompressionEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImageCompressionEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setImageCompressionEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setImageCompressionEnabled", "(Z)V", "GetSetImageCompressionEnabled_ZHandler")]
			set {
				if (id_setImageCompressionEnabled_Z == IntPtr.Zero)
					id_setImageCompressionEnabled_Z = JNIEnv.GetMethodID (class_ref, "setImageCompressionEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageCompressionEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageCompressionEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageLink;
#pragma warning disable 0169
		static Delegate GetGetImageLinkHandler ()
		{
			if (cb_getImageLink == null)
				cb_getImageLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageLink);
			return cb_getImageLink;
		}

		static IntPtr n_GetImageLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageLink);
		}
#pragma warning restore 0169

		static Delegate cb_setImageLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageLink_Ljava_lang_String_Handler ()
		{
			if (cb_setImageLink_Ljava_lang_String_ == null)
				cb_setImageLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageLink_Ljava_lang_String_);
			return cb_setImageLink_Ljava_lang_String_;
		}

		static void n_SetImageLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLink;
		static IntPtr id_setImageLink_Ljava_lang_String_;
		public virtual unsafe string ImageLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getImageLink' and count(parameter)=0]"
			[Register ("getImageLink", "()Ljava/lang/String;", "GetGetImageLinkHandler")]
			get {
				if (id_getImageLink == IntPtr.Zero)
					id_getImageLink = JNIEnv.GetMethodID (class_ref, "getImageLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setImageLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageLink", "(Ljava/lang/String;)V", "GetSetImageLink_Ljava_lang_String_Handler")]
			set {
				if (id_setImageLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isChannelDeleted;
#pragma warning disable 0169
		static Delegate GetIsChannelDeletedHandler ()
		{
			if (cb_isChannelDeleted == null)
				cb_isChannelDeleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChannelDeleted);
			return cb_isChannelDeleted;
		}

		static bool n_IsChannelDeleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChannelDeleted;
		}
#pragma warning restore 0169

		static IntPtr id_isChannelDeleted;
		public virtual unsafe bool IsChannelDeleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isChannelDeleted' and count(parameter)=0]"
			[Register ("isChannelDeleted", "()Z", "GetIsChannelDeletedHandler")]
			get {
				if (id_isChannelDeleted == IntPtr.Zero)
					id_isChannelDeleted = JNIEnv.GetMethodID (class_ref, "isChannelDeleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChannelDeleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChannelDeleted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isEncryptionEnabled;
#pragma warning disable 0169
		static Delegate GetIsEncryptionEnabledHandler ()
		{
			if (cb_isEncryptionEnabled == null)
				cb_isEncryptionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEncryptionEnabled);
			return cb_isEncryptionEnabled;
		}

		static bool n_IsEncryptionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEncryptionEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEncryptionEnabled;
		public virtual unsafe bool IsEncryptionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isEncryptionEnabled' and count(parameter)=0]"
			[Register ("isEncryptionEnabled", "()Z", "GetIsEncryptionEnabledHandler")]
			get {
				if (id_isEncryptionEnabled == IntPtr.Zero)
					id_isEncryptionEnabled = JNIEnv.GetMethodID (class_ref, "isEncryptionEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEncryptionEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEncryptionEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLoggedIn;
#pragma warning disable 0169
		static Delegate GetIsLoggedInHandler ()
		{
			if (cb_isLoggedIn == null)
				cb_isLoggedIn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLoggedIn);
			return cb_isLoggedIn;
		}

		static bool n_IsLoggedIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLoggedIn;
		}
#pragma warning restore 0169

		static IntPtr id_isLoggedIn;
		public virtual unsafe bool IsLoggedIn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isLoggedIn' and count(parameter)=0]"
			[Register ("isLoggedIn", "()Z", "GetIsLoggedInHandler")]
			get {
				if (id_isLoggedIn == IntPtr.Zero)
					id_isLoggedIn = JNIEnv.GetMethodID (class_ref, "isLoggedIn", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLoggedIn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLoggedIn", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPatchAvailable;
#pragma warning disable 0169
		static Delegate GetIsPatchAvailableHandler ()
		{
			if (cb_isPatchAvailable == null)
				cb_isPatchAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPatchAvailable);
			return cb_isPatchAvailable;
		}

		static bool n_IsPatchAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPatchAvailable;
		}
#pragma warning restore 0169

		static IntPtr id_isPatchAvailable;
		public virtual unsafe bool IsPatchAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isPatchAvailable' and count(parameter)=0]"
			[Register ("isPatchAvailable", "()Z", "GetIsPatchAvailableHandler")]
			get {
				if (id_isPatchAvailable == IntPtr.Zero)
					id_isPatchAvailable = JNIEnv.GetMethodID (class_ref, "isPatchAvailable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPatchAvailable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPatchAvailable", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRegistered;
#pragma warning disable 0169
		static Delegate GetIsRegisteredHandler ()
		{
			if (cb_isRegistered == null)
				cb_isRegistered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegistered);
			return cb_isRegistered;
		}

		static bool n_IsRegistered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegistered;
		}
#pragma warning restore 0169

		static IntPtr id_isRegistered;
		public virtual unsafe bool IsRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isRegistered' and count(parameter)=0]"
			[Register ("isRegistered", "()Z", "GetIsRegisteredHandler")]
			get {
				if (id_isRegistered == IntPtr.Zero)
					id_isRegistered = JNIEnv.GetMethodID (class_ref, "isRegistered", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegistered);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegistered", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStopServiceFlag;
#pragma warning disable 0169
		static Delegate GetIsStopServiceFlagHandler ()
		{
			if (cb_isStopServiceFlag == null)
				cb_isStopServiceFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStopServiceFlag);
			return cb_isStopServiceFlag;
		}

		static bool n_IsStopServiceFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStopServiceFlag;
		}
#pragma warning restore 0169

		static IntPtr id_isStopServiceFlag;
		public virtual unsafe bool IsStopServiceFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isStopServiceFlag' and count(parameter)=0]"
			[Register ("isStopServiceFlag", "()Z", "GetIsStopServiceFlagHandler")]
			get {
				if (id_isStopServiceFlag == IntPtr.Zero)
					id_isStopServiceFlag = JNIEnv.GetMethodID (class_ref, "isStopServiceFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStopServiceFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStopServiceFlag", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastInboxSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastInboxSyncTimeHandler ()
		{
			if (cb_getLastInboxSyncTime == null)
				cb_getLastInboxSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastInboxSyncTime);
			return cb_getLastInboxSyncTime;
		}

		static long n_GetLastInboxSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastInboxSyncTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLastInboxSyncTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastInboxSyncTime_JHandler ()
		{
			if (cb_setLastInboxSyncTime_J == null)
				cb_setLastInboxSyncTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastInboxSyncTime_J);
			return cb_setLastInboxSyncTime_J;
		}

		static void n_SetLastInboxSyncTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastInboxSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastInboxSyncTime;
		static IntPtr id_setLastInboxSyncTime_J;
		public virtual unsafe long LastInboxSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getLastInboxSyncTime' and count(parameter)=0]"
			[Register ("getLastInboxSyncTime", "()J", "GetGetLastInboxSyncTimeHandler")]
			get {
				if (id_getLastInboxSyncTime == IntPtr.Zero)
					id_getLastInboxSyncTime = JNIEnv.GetMethodID (class_ref, "getLastInboxSyncTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastInboxSyncTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastInboxSyncTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setLastInboxSyncTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastInboxSyncTime", "(J)V", "GetSetLastInboxSyncTime_JHandler")]
			set {
				if (id_setLastInboxSyncTime_J == IntPtr.Zero)
					id_setLastInboxSyncTime_J = JNIEnv.GetMethodID (class_ref, "setLastInboxSyncTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastInboxSyncTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastInboxSyncTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastMessageStatSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastMessageStatSyncTimeHandler ()
		{
			if (cb_getLastMessageStatSyncTime == null)
				cb_getLastMessageStatSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastMessageStatSyncTime);
			return cb_getLastMessageStatSyncTime;
		}

		static IntPtr n_GetLastMessageStatSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastMessageStatSyncTime);
		}
#pragma warning restore 0169

		static IntPtr id_getLastMessageStatSyncTime;
		public virtual unsafe global::Java.Lang.Long LastMessageStatSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getLastMessageStatSyncTime' and count(parameter)=0]"
			[Register ("getLastMessageStatSyncTime", "()Ljava/lang/Long;", "GetGetLastMessageStatSyncTimeHandler")]
			get {
				if (id_getLastMessageStatSyncTime == IntPtr.Zero)
					id_getLastMessageStatSyncTime = JNIEnv.GetMethodID (class_ref, "getLastMessageStatSyncTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastMessageStatSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastMessageStatSyncTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLastOutboxSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastOutboxSyncTimeHandler ()
		{
			if (cb_getLastOutboxSyncTime == null)
				cb_getLastOutboxSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastOutboxSyncTime);
			return cb_getLastOutboxSyncTime;
		}

		static long n_GetLastOutboxSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastOutboxSyncTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLastOutboxSyncTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastOutboxSyncTime_JHandler ()
		{
			if (cb_setLastOutboxSyncTime_J == null)
				cb_setLastOutboxSyncTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastOutboxSyncTime_J);
			return cb_setLastOutboxSyncTime_J;
		}

		static void n_SetLastOutboxSyncTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastOutboxSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastOutboxSyncTime;
		static IntPtr id_setLastOutboxSyncTime_J;
		public virtual unsafe long LastOutboxSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getLastOutboxSyncTime' and count(parameter)=0]"
			[Register ("getLastOutboxSyncTime", "()J", "GetGetLastOutboxSyncTimeHandler")]
			get {
				if (id_getLastOutboxSyncTime == IntPtr.Zero)
					id_getLastOutboxSyncTime = JNIEnv.GetMethodID (class_ref, "getLastOutboxSyncTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastOutboxSyncTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastOutboxSyncTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setLastOutboxSyncTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastOutboxSyncTime", "(J)V", "GetSetLastOutboxSyncTime_JHandler")]
			set {
				if (id_setLastOutboxSyncTime_J == IntPtr.Zero)
					id_setLastOutboxSyncTime_J = JNIEnv.GetMethodID (class_ref, "setLastOutboxSyncTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastOutboxSyncTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastOutboxSyncTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastSeenAtSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastSeenAtSyncTimeHandler ()
		{
			if (cb_getLastSeenAtSyncTime == null)
				cb_getLastSeenAtSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastSeenAtSyncTime);
			return cb_getLastSeenAtSyncTime;
		}

		static IntPtr n_GetLastSeenAtSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastSeenAtSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setLastSeenAtSyncTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastSeenAtSyncTime_Ljava_lang_String_Handler ()
		{
			if (cb_setLastSeenAtSyncTime_Ljava_lang_String_ == null)
				cb_setLastSeenAtSyncTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastSeenAtSyncTime_Ljava_lang_String_);
			return cb_setLastSeenAtSyncTime_Ljava_lang_String_;
		}

		static void n_SetLastSeenAtSyncTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastSeenAtSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSeenAtSyncTime;
		static IntPtr id_setLastSeenAtSyncTime_Ljava_lang_String_;
		public virtual unsafe string LastSeenAtSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getLastSeenAtSyncTime' and count(parameter)=0]"
			[Register ("getLastSeenAtSyncTime", "()Ljava/lang/String;", "GetGetLastSeenAtSyncTimeHandler")]
			get {
				if (id_getLastSeenAtSyncTime == IntPtr.Zero)
					id_getLastSeenAtSyncTime = JNIEnv.GetMethodID (class_ref, "getLastSeenAtSyncTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastSeenAtSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSeenAtSyncTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setLastSeenAtSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastSeenAtSyncTime", "(Ljava/lang/String;)V", "GetSetLastSeenAtSyncTime_Ljava_lang_String_Handler")]
			set {
				if (id_setLastSeenAtSyncTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastSeenAtSyncTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastSeenAtSyncTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSeenAtSyncTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSeenAtSyncTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLastSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastSyncTimeHandler ()
		{
			if (cb_getLastSyncTime == null)
				cb_getLastSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastSyncTime);
			return cb_getLastSyncTime;
		}

		static IntPtr n_GetLastSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setLastSyncTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastSyncTime_Ljava_lang_String_Handler ()
		{
			if (cb_setLastSyncTime_Ljava_lang_String_ == null)
				cb_setLastSyncTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastSyncTime_Ljava_lang_String_);
			return cb_setLastSyncTime_Ljava_lang_String_;
		}

		static void n_SetLastSyncTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSyncTime;
		static IntPtr id_setLastSyncTime_Ljava_lang_String_;
		public virtual unsafe string LastSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getLastSyncTime' and count(parameter)=0]"
			[Register ("getLastSyncTime", "()Ljava/lang/String;", "GetGetLastSyncTimeHandler")]
			get {
				if (id_getLastSyncTime == IntPtr.Zero)
					id_getLastSyncTime = JNIEnv.GetMethodID (class_ref, "getLastSyncTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSyncTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setLastSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastSyncTime", "(Ljava/lang/String;)V", "GetSetLastSyncTime_Ljava_lang_String_Handler")]
			set {
				if (id_setLastSyncTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastSyncTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastSyncTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSyncTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSyncTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isMobiTexterContactSyncCompleted;
#pragma warning disable 0169
		static Delegate GetIsMobiTexterContactSyncCompletedHandler ()
		{
			if (cb_isMobiTexterContactSyncCompleted == null)
				cb_isMobiTexterContactSyncCompleted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMobiTexterContactSyncCompleted);
			return cb_isMobiTexterContactSyncCompleted;
		}

		static bool n_IsMobiTexterContactSyncCompleted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MobiTexterContactSyncCompleted;
		}
#pragma warning restore 0169

		static Delegate cb_setMobiTexterContactSyncCompleted_Z;
#pragma warning disable 0169
		static Delegate GetSetMobiTexterContactSyncCompleted_ZHandler ()
		{
			if (cb_setMobiTexterContactSyncCompleted_Z == null)
				cb_setMobiTexterContactSyncCompleted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMobiTexterContactSyncCompleted_Z);
			return cb_setMobiTexterContactSyncCompleted_Z;
		}

		static void n_SetMobiTexterContactSyncCompleted_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MobiTexterContactSyncCompleted = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isMobiTexterContactSyncCompleted;
		static IntPtr id_setMobiTexterContactSyncCompleted_Z;
		public virtual unsafe bool MobiTexterContactSyncCompleted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isMobiTexterContactSyncCompleted' and count(parameter)=0]"
			[Register ("isMobiTexterContactSyncCompleted", "()Z", "GetIsMobiTexterContactSyncCompletedHandler")]
			get {
				if (id_isMobiTexterContactSyncCompleted == IntPtr.Zero)
					id_isMobiTexterContactSyncCompleted = JNIEnv.GetMethodID (class_ref, "isMobiTexterContactSyncCompleted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMobiTexterContactSyncCompleted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMobiTexterContactSyncCompleted", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setMobiTexterContactSyncCompleted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMobiTexterContactSyncCompleted", "(Z)V", "GetSetMobiTexterContactSyncCompleted_ZHandler")]
			set {
				if (id_setMobiTexterContactSyncCompleted_Z == IntPtr.Zero)
					id_setMobiTexterContactSyncCompleted_Z = JNIEnv.GetMethodID (class_ref, "setMobiTexterContactSyncCompleted", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMobiTexterContactSyncCompleted_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMobiTexterContactSyncCompleted", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMqttBrokerUrl;
#pragma warning disable 0169
		static Delegate GetGetMqttBrokerUrlHandler ()
		{
			if (cb_getMqttBrokerUrl == null)
				cb_getMqttBrokerUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMqttBrokerUrl);
			return cb_getMqttBrokerUrl;
		}

		static IntPtr n_GetMqttBrokerUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MqttBrokerUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setMqttBrokerUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMqttBrokerUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setMqttBrokerUrl_Ljava_lang_String_ == null)
				cb_setMqttBrokerUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMqttBrokerUrl_Ljava_lang_String_);
			return cb_setMqttBrokerUrl_Ljava_lang_String_;
		}

		static void n_SetMqttBrokerUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MqttBrokerUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMqttBrokerUrl;
		static IntPtr id_setMqttBrokerUrl_Ljava_lang_String_;
		public virtual unsafe string MqttBrokerUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getMqttBrokerUrl' and count(parameter)=0]"
			[Register ("getMqttBrokerUrl", "()Ljava/lang/String;", "GetGetMqttBrokerUrlHandler")]
			get {
				if (id_getMqttBrokerUrl == IntPtr.Zero)
					id_getMqttBrokerUrl = JNIEnv.GetMethodID (class_ref, "getMqttBrokerUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMqttBrokerUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMqttBrokerUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setMqttBrokerUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMqttBrokerUrl", "(Ljava/lang/String;)V", "GetSetMqttBrokerUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setMqttBrokerUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setMqttBrokerUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMqttBrokerUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMqttBrokerUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMqttBrokerUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNewMessageFlag;
#pragma warning disable 0169
		static Delegate GetGetNewMessageFlagHandler ()
		{
			if (cb_getNewMessageFlag == null)
				cb_getNewMessageFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetNewMessageFlag);
			return cb_getNewMessageFlag;
		}

		static bool n_GetNewMessageFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NewMessageFlag;
		}
#pragma warning restore 0169

		static Delegate cb_setNewMessageFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetNewMessageFlag_ZHandler ()
		{
			if (cb_setNewMessageFlag_Z == null)
				cb_setNewMessageFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNewMessageFlag_Z);
			return cb_setNewMessageFlag_Z;
		}

		static void n_SetNewMessageFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NewMessageFlag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewMessageFlag;
		static IntPtr id_setNewMessageFlag_Z;
		public virtual unsafe bool NewMessageFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getNewMessageFlag' and count(parameter)=0]"
			[Register ("getNewMessageFlag", "()Z", "GetGetNewMessageFlagHandler")]
			get {
				if (id_getNewMessageFlag == IntPtr.Zero)
					id_getNewMessageFlag = JNIEnv.GetMethodID (class_ref, "getNewMessageFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getNewMessageFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewMessageFlag", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setNewMessageFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNewMessageFlag", "(Z)V", "GetSetNewMessageFlag_ZHandler")]
			set {
				if (id_setNewMessageFlag_Z == IntPtr.Zero)
					id_setNewMessageFlag_Z = JNIEnv.GetMethodID (class_ref, "setNewMessageFlag", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNewMessageFlag_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewMessageFlag", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationSoundFilePath;
#pragma warning disable 0169
		static Delegate GetGetNotificationSoundFilePathHandler ()
		{
			if (cb_getNotificationSoundFilePath == null)
				cb_getNotificationSoundFilePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationSoundFilePath);
			return cb_getNotificationSoundFilePath;
		}

		static IntPtr n_GetNotificationSoundFilePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotificationSoundFilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationSoundFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotificationSoundFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setNotificationSoundFilePath_Ljava_lang_String_ == null)
				cb_setNotificationSoundFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationSoundFilePath_Ljava_lang_String_);
			return cb_setNotificationSoundFilePath_Ljava_lang_String_;
		}

		static void n_SetNotificationSoundFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationSoundFilePath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationSoundFilePath;
		static IntPtr id_setNotificationSoundFilePath_Ljava_lang_String_;
		public virtual unsafe string NotificationSoundFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getNotificationSoundFilePath' and count(parameter)=0]"
			[Register ("getNotificationSoundFilePath", "()Ljava/lang/String;", "GetGetNotificationSoundFilePathHandler")]
			get {
				if (id_getNotificationSoundFilePath == IntPtr.Zero)
					id_getNotificationSoundFilePath = JNIEnv.GetMethodID (class_ref, "getNotificationSoundFilePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationSoundFilePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationSoundFilePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setNotificationSoundFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationSoundFilePath", "(Ljava/lang/String;)V", "GetSetNotificationSoundFilePath_Ljava_lang_String_Handler")]
			set {
				if (id_setNotificationSoundFilePath_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotificationSoundFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationSoundFilePath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSoundFilePath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationSoundFilePath", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static Delegate cb_setPassword_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPassword_Ljava_lang_String_Handler ()
		{
			if (cb_setPassword_Ljava_lang_String_ == null)
				cb_setPassword_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPassword_Ljava_lang_String_);
			return cb_setPassword_Ljava_lang_String_;
		}

		static void n_SetPassword_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Password = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		static IntPtr id_setPassword_Ljava_lang_String_;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setPassword' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPassword", "(Ljava/lang/String;)V", "GetSetPassword_Ljava_lang_String_Handler")]
			set {
				if (id_setPassword_Ljava_lang_String_ == IntPtr.Zero)
					id_setPassword_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPassword", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPassword_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPassword", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPricingPackage;
#pragma warning disable 0169
		static Delegate GetGetPricingPackageHandler ()
		{
			if (cb_getPricingPackage == null)
				cb_getPricingPackage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPricingPackage);
			return cb_getPricingPackage;
		}

		static int n_GetPricingPackage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PricingPackage;
		}
#pragma warning restore 0169

		static Delegate cb_setPricingPackage_I;
#pragma warning disable 0169
		static Delegate GetSetPricingPackage_IHandler ()
		{
			if (cb_setPricingPackage_I == null)
				cb_setPricingPackage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPricingPackage_I);
			return cb_setPricingPackage_I;
		}

		static void n_SetPricingPackage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PricingPackage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPricingPackage;
		static IntPtr id_setPricingPackage_I;
		public virtual unsafe int PricingPackage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getPricingPackage' and count(parameter)=0]"
			[Register ("getPricingPackage", "()I", "GetGetPricingPackageHandler")]
			get {
				if (id_getPricingPackage == IntPtr.Zero)
					id_getPricingPackage = JNIEnv.GetMethodID (class_ref, "getPricingPackage", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPricingPackage);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPricingPackage", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setPricingPackage' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPricingPackage", "(I)V", "GetSetPricingPackage_IHandler")]
			set {
				if (id_setPricingPackage_I == IntPtr.Zero)
					id_setPricingPackage_I = JNIEnv.GetMethodID (class_ref, "setPricingPackage", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPricingPackage_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPricingPackage", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedSmsSyncFlag;
#pragma warning disable 0169
		static Delegate GetGetReceivedSmsSyncFlagHandler ()
		{
			if (cb_getReceivedSmsSyncFlag == null)
				cb_getReceivedSmsSyncFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetReceivedSmsSyncFlag);
			return cb_getReceivedSmsSyncFlag;
		}

		static bool n_GetReceivedSmsSyncFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReceivedSmsSyncFlag;
		}
#pragma warning restore 0169

		static Delegate cb_setReceivedSmsSyncFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetReceivedSmsSyncFlag_ZHandler ()
		{
			if (cb_setReceivedSmsSyncFlag_Z == null)
				cb_setReceivedSmsSyncFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReceivedSmsSyncFlag_Z);
			return cb_setReceivedSmsSyncFlag_Z;
		}

		static void n_SetReceivedSmsSyncFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReceivedSmsSyncFlag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedSmsSyncFlag;
		static IntPtr id_setReceivedSmsSyncFlag_Z;
		public virtual unsafe bool ReceivedSmsSyncFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getReceivedSmsSyncFlag' and count(parameter)=0]"
			[Register ("getReceivedSmsSyncFlag", "()Z", "GetGetReceivedSmsSyncFlagHandler")]
			get {
				if (id_getReceivedSmsSyncFlag == IntPtr.Zero)
					id_getReceivedSmsSyncFlag = JNIEnv.GetMethodID (class_ref, "getReceivedSmsSyncFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedSmsSyncFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedSmsSyncFlag", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setReceivedSmsSyncFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReceivedSmsSyncFlag", "(Z)V", "GetSetReceivedSmsSyncFlag_ZHandler")]
			set {
				if (id_setReceivedSmsSyncFlag_Z == IntPtr.Zero)
					id_setReceivedSmsSyncFlag_Z = JNIEnv.GetMethodID (class_ref, "setReceivedSmsSyncFlag", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReceivedSmsSyncFlag_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceivedSmsSyncFlag", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRegisteredUsersLastFetchTime;
#pragma warning disable 0169
		static Delegate GetGetRegisteredUsersLastFetchTimeHandler ()
		{
			if (cb_getRegisteredUsersLastFetchTime == null)
				cb_getRegisteredUsersLastFetchTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRegisteredUsersLastFetchTime);
			return cb_getRegisteredUsersLastFetchTime;
		}

		static long n_GetRegisteredUsersLastFetchTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegisteredUsersLastFetchTime;
		}
#pragma warning restore 0169

		static Delegate cb_setRegisteredUsersLastFetchTime_J;
#pragma warning disable 0169
		static Delegate GetSetRegisteredUsersLastFetchTime_JHandler ()
		{
			if (cb_setRegisteredUsersLastFetchTime_J == null)
				cb_setRegisteredUsersLastFetchTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetRegisteredUsersLastFetchTime_J);
			return cb_setRegisteredUsersLastFetchTime_J;
		}

		static void n_SetRegisteredUsersLastFetchTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisteredUsersLastFetchTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRegisteredUsersLastFetchTime;
		static IntPtr id_setRegisteredUsersLastFetchTime_J;
		public virtual unsafe long RegisteredUsersLastFetchTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getRegisteredUsersLastFetchTime' and count(parameter)=0]"
			[Register ("getRegisteredUsersLastFetchTime", "()J", "GetGetRegisteredUsersLastFetchTimeHandler")]
			get {
				if (id_getRegisteredUsersLastFetchTime == IntPtr.Zero)
					id_getRegisteredUsersLastFetchTime = JNIEnv.GetMethodID (class_ref, "getRegisteredUsersLastFetchTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRegisteredUsersLastFetchTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRegisteredUsersLastFetchTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setRegisteredUsersLastFetchTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setRegisteredUsersLastFetchTime", "(J)V", "GetSetRegisteredUsersLastFetchTime_JHandler")]
			set {
				if (id_setRegisteredUsersLastFetchTime_J == IntPtr.Zero)
					id_setRegisteredUsersLastFetchTime_J = JNIEnv.GetMethodID (class_ref, "setRegisteredUsersLastFetchTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegisteredUsersLastFetchTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegisteredUsersLastFetchTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isReportEnable;
#pragma warning disable 0169
		static Delegate GetIsReportEnableHandler ()
		{
			if (cb_isReportEnable == null)
				cb_isReportEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReportEnable);
			return cb_isReportEnable;
		}

		static bool n_IsReportEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReportEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setReportEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetReportEnable_ZHandler ()
		{
			if (cb_setReportEnable_Z == null)
				cb_setReportEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReportEnable_Z);
			return cb_setReportEnable_Z;
		}

		static void n_SetReportEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReportEnable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isReportEnable;
		static IntPtr id_setReportEnable_Z;
		public virtual unsafe bool ReportEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isReportEnable' and count(parameter)=0]"
			[Register ("isReportEnable", "()Z", "GetIsReportEnableHandler")]
			get {
				if (id_isReportEnable == IntPtr.Zero)
					id_isReportEnable = JNIEnv.GetMethodID (class_ref, "isReportEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReportEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReportEnable", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setReportEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReportEnable", "(Z)V", "GetSetReportEnable_ZHandler")]
			set {
				if (id_setReportEnable_Z == IntPtr.Zero)
					id_setReportEnable_Z = JNIEnv.GetMethodID (class_ref, "setReportEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReportEnable_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReportEnable", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isSentSmsSyncFlag;
#pragma warning disable 0169
		static Delegate GetIsSentSmsSyncFlagHandler ()
		{
			if (cb_isSentSmsSyncFlag == null)
				cb_isSentSmsSyncFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSentSmsSyncFlag);
			return cb_isSentSmsSyncFlag;
		}

		static bool n_IsSentSmsSyncFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SentSmsSyncFlag;
		}
#pragma warning restore 0169

		static Delegate cb_setSentSmsSyncFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetSentSmsSyncFlag_ZHandler ()
		{
			if (cb_setSentSmsSyncFlag_Z == null)
				cb_setSentSmsSyncFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSentSmsSyncFlag_Z);
			return cb_setSentSmsSyncFlag_Z;
		}

		static void n_SetSentSmsSyncFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SentSmsSyncFlag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isSentSmsSyncFlag;
		static IntPtr id_setSentSmsSyncFlag_Z;
		public virtual unsafe bool SentSmsSyncFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isSentSmsSyncFlag' and count(parameter)=0]"
			[Register ("isSentSmsSyncFlag", "()Z", "GetIsSentSmsSyncFlagHandler")]
			get {
				if (id_isSentSmsSyncFlag == IntPtr.Zero)
					id_isSentSmsSyncFlag = JNIEnv.GetMethodID (class_ref, "isSentSmsSyncFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSentSmsSyncFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSentSmsSyncFlag", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setSentSmsSyncFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSentSmsSyncFlag", "(Z)V", "GetSetSentSmsSyncFlag_ZHandler")]
			set {
				if (id_setSentSmsSyncFlag_Z == IntPtr.Zero)
					id_setSentSmsSyncFlag_Z = JNIEnv.GetMethodID (class_ref, "setSentSmsSyncFlag", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSentSmsSyncFlag_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSentSmsSyncFlag", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSuUserKeyString;
#pragma warning disable 0169
		static Delegate GetGetSuUserKeyStringHandler ()
		{
			if (cb_getSuUserKeyString == null)
				cb_getSuUserKeyString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSuUserKeyString);
			return cb_getSuUserKeyString;
		}

		static IntPtr n_GetSuUserKeyString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SuUserKeyString);
		}
#pragma warning restore 0169

		static Delegate cb_setSuUserKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuUserKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_setSuUserKeyString_Ljava_lang_String_ == null)
				cb_setSuUserKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSuUserKeyString_Ljava_lang_String_);
			return cb_setSuUserKeyString_Ljava_lang_String_;
		}

		static void n_SetSuUserKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SuUserKeyString = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSuUserKeyString;
		static IntPtr id_setSuUserKeyString_Ljava_lang_String_;
		public virtual unsafe string SuUserKeyString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getSuUserKeyString' and count(parameter)=0]"
			[Register ("getSuUserKeyString", "()Ljava/lang/String;", "GetGetSuUserKeyStringHandler")]
			get {
				if (id_getSuUserKeyString == IntPtr.Zero)
					id_getSuUserKeyString = JNIEnv.GetMethodID (class_ref, "getSuUserKeyString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSuUserKeyString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSuUserKeyString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setSuUserKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSuUserKeyString", "(Ljava/lang/String;)V", "GetSetSuUserKeyString_Ljava_lang_String_Handler")]
			set {
				if (id_setSuUserKeyString_Ljava_lang_String_ == IntPtr.Zero)
					id_setSuUserKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSuUserKeyString", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSuUserKeyString_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSuUserKeyString", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isUpdateRegFlag;
#pragma warning disable 0169
		static Delegate GetIsUpdateRegFlagHandler ()
		{
			if (cb_isUpdateRegFlag == null)
				cb_isUpdateRegFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUpdateRegFlag);
			return cb_isUpdateRegFlag;
		}

		static bool n_IsUpdateRegFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UpdateRegFlag;
		}
#pragma warning restore 0169

		static Delegate cb_setUpdateRegFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetUpdateRegFlag_ZHandler ()
		{
			if (cb_setUpdateRegFlag_Z == null)
				cb_setUpdateRegFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUpdateRegFlag_Z);
			return cb_setUpdateRegFlag_Z;
		}

		static void n_SetUpdateRegFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateRegFlag = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isUpdateRegFlag;
		static IntPtr id_setUpdateRegFlag_Z;
		public virtual unsafe bool UpdateRegFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isUpdateRegFlag' and count(parameter)=0]"
			[Register ("isUpdateRegFlag", "()Z", "GetIsUpdateRegFlagHandler")]
			get {
				if (id_isUpdateRegFlag == IntPtr.Zero)
					id_isUpdateRegFlag = JNIEnv.GetMethodID (class_ref, "isUpdateRegFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUpdateRegFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUpdateRegFlag", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setUpdateRegFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUpdateRegFlag", "(Z)V", "GetSetUpdateRegFlag_ZHandler")]
			set {
				if (id_setUpdateRegFlag_Z == IntPtr.Zero)
					id_setUpdateRegFlag_Z = JNIEnv.GetMethodID (class_ref, "setUpdateRegFlag", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdateRegFlag_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdateRegFlag", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Url = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		static IntPtr id_setUrl_Ljava_lang_String_;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserBlockSyncTime;
#pragma warning disable 0169
		static Delegate GetGetUserBlockSyncTimeHandler ()
		{
			if (cb_getUserBlockSyncTime == null)
				cb_getUserBlockSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserBlockSyncTime);
			return cb_getUserBlockSyncTime;
		}

		static IntPtr n_GetUserBlockSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserBlockSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setUserBlockSyncTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserBlockSyncTime_Ljava_lang_String_Handler ()
		{
			if (cb_setUserBlockSyncTime_Ljava_lang_String_ == null)
				cb_setUserBlockSyncTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserBlockSyncTime_Ljava_lang_String_);
			return cb_setUserBlockSyncTime_Ljava_lang_String_;
		}

		static void n_SetUserBlockSyncTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserBlockSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserBlockSyncTime;
		static IntPtr id_setUserBlockSyncTime_Ljava_lang_String_;
		public virtual unsafe string UserBlockSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getUserBlockSyncTime' and count(parameter)=0]"
			[Register ("getUserBlockSyncTime", "()Ljava/lang/String;", "GetGetUserBlockSyncTimeHandler")]
			get {
				if (id_getUserBlockSyncTime == IntPtr.Zero)
					id_getUserBlockSyncTime = JNIEnv.GetMethodID (class_ref, "getUserBlockSyncTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserBlockSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserBlockSyncTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setUserBlockSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserBlockSyncTime", "(Ljava/lang/String;)V", "GetSetUserBlockSyncTime_Ljava_lang_String_Handler")]
			set {
				if (id_setUserBlockSyncTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserBlockSyncTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserBlockSyncTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserBlockSyncTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserBlockSyncTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserTypeId;
#pragma warning disable 0169
		static Delegate GetGetUserTypeIdHandler ()
		{
			if (cb_getUserTypeId == null)
				cb_getUserTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserTypeId);
			return cb_getUserTypeId;
		}

		static IntPtr n_GetUserTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserTypeId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserTypeId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserTypeId_Ljava_lang_String_ == null)
				cb_setUserTypeId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserTypeId_Ljava_lang_String_);
			return cb_setUserTypeId_Ljava_lang_String_;
		}

		static void n_SetUserTypeId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserTypeId;
		static IntPtr id_setUserTypeId_Ljava_lang_String_;
		public virtual unsafe string UserTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getUserTypeId' and count(parameter)=0]"
			[Register ("getUserTypeId", "()Ljava/lang/String;", "GetGetUserTypeIdHandler")]
			get {
				if (id_getUserTypeId == IntPtr.Zero)
					id_getUserTypeId = JNIEnv.GetMethodID (class_ref, "getUserTypeId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserTypeId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setUserTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserTypeId", "(Ljava/lang/String;)V", "GetSetUserTypeId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserTypeId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserTypeId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserTypeId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserTypeId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserTypeId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isVerifyContactNumber;
#pragma warning disable 0169
		static Delegate GetIsVerifyContactNumberHandler ()
		{
			if (cb_isVerifyContactNumber == null)
				cb_isVerifyContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVerifyContactNumber);
			return cb_isVerifyContactNumber;
		}

		static bool n_IsVerifyContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerifyContactNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setVerifyContactNumber_Z;
#pragma warning disable 0169
		static Delegate GetSetVerifyContactNumber_ZHandler ()
		{
			if (cb_setVerifyContactNumber_Z == null)
				cb_setVerifyContactNumber_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVerifyContactNumber_Z);
			return cb_setVerifyContactNumber_Z;
		}

		static void n_SetVerifyContactNumber_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VerifyContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isVerifyContactNumber;
		static IntPtr id_setVerifyContactNumber_Z;
		public virtual unsafe bool VerifyContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isVerifyContactNumber' and count(parameter)=0]"
			[Register ("isVerifyContactNumber", "()Z", "GetIsVerifyContactNumberHandler")]
			get {
				if (id_isVerifyContactNumber == IntPtr.Zero)
					id_isVerifyContactNumber = JNIEnv.GetMethodID (class_ref, "isVerifyContactNumber", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVerifyContactNumber);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVerifyContactNumber", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setVerifyContactNumber' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVerifyContactNumber", "(Z)V", "GetSetVerifyContactNumber_ZHandler")]
			set {
				if (id_setVerifyContactNumber_Z == IntPtr.Zero)
					id_setVerifyContactNumber_Z = JNIEnv.GetMethodID (class_ref, "setVerifyContactNumber", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVerifyContactNumber_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVerifyContactNumber", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoCallToken;
#pragma warning disable 0169
		static Delegate GetGetVideoCallTokenHandler ()
		{
			if (cb_getVideoCallToken == null)
				cb_getVideoCallToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVideoCallToken);
			return cb_getVideoCallToken;
		}

		static IntPtr n_GetVideoCallToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VideoCallToken);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoCallToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoCallToken_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoCallToken_Ljava_lang_String_ == null)
				cb_setVideoCallToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVideoCallToken_Ljava_lang_String_);
			return cb_setVideoCallToken_Ljava_lang_String_;
		}

		static void n_SetVideoCallToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VideoCallToken = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVideoCallToken;
		static IntPtr id_setVideoCallToken_Ljava_lang_String_;
		public virtual unsafe string VideoCallToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getVideoCallToken' and count(parameter)=0]"
			[Register ("getVideoCallToken", "()Ljava/lang/String;", "GetGetVideoCallTokenHandler")]
			get {
				if (id_getVideoCallToken == IntPtr.Zero)
					id_getVideoCallToken = JNIEnv.GetMethodID (class_ref, "getVideoCallToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVideoCallToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVideoCallToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setVideoCallToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVideoCallToken", "(Ljava/lang/String;)V", "GetSetVideoCallToken_Ljava_lang_String_Handler")]
			set {
				if (id_setVideoCallToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setVideoCallToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVideoCallToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVideoCallToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVideoCallToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getWasContactListServerCallAlreadyDone;
#pragma warning disable 0169
		static Delegate GetGetWasContactListServerCallAlreadyDoneHandler ()
		{
			if (cb_getWasContactListServerCallAlreadyDone == null)
				cb_getWasContactListServerCallAlreadyDone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetWasContactListServerCallAlreadyDone);
			return cb_getWasContactListServerCallAlreadyDone;
		}

		static bool n_GetWasContactListServerCallAlreadyDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WasContactListServerCallAlreadyDone;
		}
#pragma warning restore 0169

		static IntPtr id_getWasContactListServerCallAlreadyDone;
		public virtual unsafe bool WasContactListServerCallAlreadyDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getWasContactListServerCallAlreadyDone' and count(parameter)=0]"
			[Register ("getWasContactListServerCallAlreadyDone", "()Z", "GetGetWasContactListServerCallAlreadyDoneHandler")]
			get {
				if (id_getWasContactListServerCallAlreadyDone == IntPtr.Zero)
					id_getWasContactListServerCallAlreadyDone = JNIEnv.GetMethodID (class_ref, "getWasContactListServerCallAlreadyDone", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getWasContactListServerCallAlreadyDone);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWasContactListServerCallAlreadyDone", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isWebHookEnable;
#pragma warning disable 0169
		static Delegate GetIsWebHookEnableHandler ()
		{
			if (cb_isWebHookEnable == null)
				cb_isWebHookEnable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWebHookEnable);
			return cb_isWebHookEnable;
		}

		static bool n_IsWebHookEnable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebHookEnable;
		}
#pragma warning restore 0169

		static Delegate cb_setWebHookEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetWebHookEnable_ZHandler ()
		{
			if (cb_setWebHookEnable_Z == null)
				cb_setWebHookEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWebHookEnable_Z);
			return cb_setWebHookEnable_Z;
		}

		static void n_SetWebHookEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebHookEnable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isWebHookEnable;
		static IntPtr id_setWebHookEnable_Z;
		public virtual unsafe bool WebHookEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='isWebHookEnable' and count(parameter)=0]"
			[Register ("isWebHookEnable", "()Z", "GetIsWebHookEnableHandler")]
			get {
				if (id_isWebHookEnable == IntPtr.Zero)
					id_isWebHookEnable = JNIEnv.GetMethodID (class_ref, "isWebHookEnable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isWebHookEnable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isWebHookEnable", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setWebHookEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWebHookEnable", "(Z)V", "GetSetWebHookEnable_ZHandler")]
			set {
				if (id_setWebHookEnable_Z == IntPtr.Zero)
					id_setWebHookEnable_Z = JNIEnv.GetMethodID (class_ref, "setWebHookEnable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWebHookEnable_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWebHookEnable", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_clearAll;
#pragma warning disable 0169
		static Delegate GetClearAllHandler ()
		{
			if (cb_clearAll == null)
				cb_clearAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ClearAll);
			return cb_clearAll;
		}

		static bool n_ClearAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ClearAll ();
		}
#pragma warning restore 0169

		static IntPtr id_clearAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='clearAll' and count(parameter)=0]"
		[Register ("clearAll", "()Z", "GetClearAllHandler")]
		public virtual unsafe bool ClearAll ()
		{
			if (id_clearAll == IntPtr.Zero)
				id_clearAll = JNIEnv.GetMethodID (class_ref, "clearAll", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_clearAll);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearAll", "()Z"));
			} finally {
			}
		}

		static Delegate cb_enableEncryption_Z;
#pragma warning disable 0169
		static Delegate GetEnableEncryption_ZHandler ()
		{
			if (cb_enableEncryption_Z == null)
				cb_enableEncryption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_EnableEncryption_Z);
			return cb_enableEncryption_Z;
		}

		static void n_EnableEncryption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableEncryption (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enableEncryption_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='enableEncryption' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableEncryption", "(Z)V", "GetEnableEncryption_ZHandler")]
		public virtual unsafe void EnableEncryption (bool p0)
		{
			if (id_enableEncryption_Z == IntPtr.Zero)
				id_enableEncryption_Z = JNIEnv.GetMethodID (class_ref, "enableEncryption", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enableEncryption_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableEncryption", "(Z)V"), __args);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/account/user/MobiComUserPreference;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/account/user/MobiComUserPreference;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_ == null)
				cb_initialize_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Initialize_Landroid_content_Context_);
			return cb_initialize_Landroid_content_Context_;
		}

		static void n_Initialize_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_initialize_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "GetInitialize_Landroid_content_Context_Handler")]
		public virtual unsafe void Initialize (global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initialize", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setApplicationInfoCallDone_Z;
#pragma warning disable 0169
		static Delegate GetSetApplicationInfoCallDone_ZHandler ()
		{
			if (cb_setApplicationInfoCallDone_Z == null)
				cb_setApplicationInfoCallDone_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetApplicationInfoCallDone_Z);
			return cb_setApplicationInfoCallDone_Z;
		}

		static void n_SetApplicationInfoCallDone_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetApplicationInfoCallDone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setApplicationInfoCallDone_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setApplicationInfoCallDone' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setApplicationInfoCallDone", "(Z)V", "GetSetApplicationInfoCallDone_ZHandler")]
		public virtual unsafe void SetApplicationInfoCallDone (bool p0)
		{
			if (id_setApplicationInfoCallDone_Z == IntPtr.Zero)
				id_setApplicationInfoCallDone_Z = JNIEnv.GetMethodID (class_ref, "setApplicationInfoCallDone", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationInfoCallDone_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationInfoCallDone", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDelayGroupSmsDelayTime_I;
#pragma warning disable 0169
		static Delegate GetSetDelayGroupSmsDelayTime_IHandler ()
		{
			if (cb_setDelayGroupSmsDelayTime_I == null)
				cb_setDelayGroupSmsDelayTime_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDelayGroupSmsDelayTime_I);
			return cb_setDelayGroupSmsDelayTime_I;
		}

		static void n_SetDelayGroupSmsDelayTime_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDelayGroupSmsDelayTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDelayGroupSmsDelayTime_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDelayGroupSmsDelayTime' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDelayGroupSmsDelayTime", "(I)V", "GetSetDelayGroupSmsDelayTime_IHandler")]
		public virtual unsafe void SetDelayGroupSmsDelayTime (int p0)
		{
			if (id_setDelayGroupSmsDelayTime_I == IntPtr.Zero)
				id_setDelayGroupSmsDelayTime_I = JNIEnv.GetMethodID (class_ref, "setDelayGroupSmsDelayTime", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDelayGroupSmsDelayTime_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelayGroupSmsDelayTime", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDeleteChannel_Z;
#pragma warning disable 0169
		static Delegate GetSetDeleteChannel_ZHandler ()
		{
			if (cb_setDeleteChannel_Z == null)
				cb_setDeleteChannel_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeleteChannel_Z);
			return cb_setDeleteChannel_Z;
		}

		static void n_SetDeleteChannel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDeleteChannel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDeleteChannel_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDeleteChannel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDeleteChannel", "(Z)V", "GetSetDeleteChannel_ZHandler")]
		public virtual unsafe void SetDeleteChannel (bool p0)
		{
			if (id_setDeleteChannel_Z == IntPtr.Zero)
				id_setDeleteChannel_Z = JNIEnv.GetMethodID (class_ref, "setDeleteChannel", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeleteChannel_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeleteChannel", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDeviceTimeOffset_J;
#pragma warning disable 0169
		static Delegate GetSetDeviceTimeOffset_JHandler ()
		{
			if (cb_setDeviceTimeOffset_J == null)
				cb_setDeviceTimeOffset_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_SetDeviceTimeOffset_J);
			return cb_setDeviceTimeOffset_J;
		}

		static bool n_SetDeviceTimeOffset_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetDeviceTimeOffset (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceTimeOffset_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setDeviceTimeOffset' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDeviceTimeOffset", "(J)Z", "GetSetDeviceTimeOffset_JHandler")]
		public virtual unsafe bool SetDeviceTimeOffset (long p0)
		{
			if (id_setDeviceTimeOffset_J == IntPtr.Zero)
				id_setDeviceTimeOffset_J = JNIEnv.GetMethodID (class_ref, "setDeviceTimeOffset", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceTimeOffset_J, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceTimeOffset", "(J)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_setLastMessageStatSyncTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastMessageStatSyncTime_JHandler ()
		{
			if (cb_setLastMessageStatSyncTime_J == null)
				cb_setLastMessageStatSyncTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastMessageStatSyncTime_J);
			return cb_setLastMessageStatSyncTime_J;
		}

		static void n_SetLastMessageStatSyncTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLastMessageStatSyncTime (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastMessageStatSyncTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setLastMessageStatSyncTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setLastMessageStatSyncTime", "(J)V", "GetSetLastMessageStatSyncTime_JHandler")]
		public virtual unsafe void SetLastMessageStatSyncTime (long p0)
		{
			if (id_setLastMessageStatSyncTime_J == IntPtr.Zero)
				id_setLastMessageStatSyncTime_J = JNIEnv.GetMethodID (class_ref, "setLastMessageStatSyncTime", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastMessageStatSyncTime_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastMessageStatSyncTime", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPatchAvailable_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetPatchAvailable_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setPatchAvailable_Ljava_lang_Boolean_ == null)
				cb_setPatchAvailable_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPatchAvailable_Ljava_lang_Boolean_);
			return cb_setPatchAvailable_Ljava_lang_Boolean_;
		}

		static void n_SetPatchAvailable_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPatchAvailable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPatchAvailable_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setPatchAvailable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setPatchAvailable", "(Ljava/lang/Boolean;)V", "GetSetPatchAvailable_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetPatchAvailable (global::Java.Lang.Boolean p0)
		{
			if (id_setPatchAvailable_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setPatchAvailable_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setPatchAvailable", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPatchAvailable_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPatchAvailable", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setStopServiceFlag_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetStopServiceFlag_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setStopServiceFlag_Ljava_lang_Boolean_ == null)
				cb_setStopServiceFlag_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStopServiceFlag_Ljava_lang_Boolean_);
			return cb_setStopServiceFlag_Ljava_lang_Boolean_;
		}

		static void n_SetStopServiceFlag_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStopServiceFlag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStopServiceFlag_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setStopServiceFlag' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setStopServiceFlag", "(Ljava/lang/Boolean;)V", "GetSetStopServiceFlag_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetStopServiceFlag (global::Java.Lang.Boolean p0)
		{
			if (id_setStopServiceFlag_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setStopServiceFlag_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setStopServiceFlag", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStopServiceFlag_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStopServiceFlag", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_ == null)
				cb_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_);
			return cb_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_;
		}

		static void n_SetWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.MobiComUserPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWasContactListServerCallAlreadyDone (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='MobiComUserPreference']/method[@name='setWasContactListServerCallAlreadyDone' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("setWasContactListServerCallAlreadyDone", "(Ljava/lang/Boolean;)V", "GetSetWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void SetWasContactListServerCallAlreadyDone (global::Java.Lang.Boolean p0)
		{
			if (id_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setWasContactListServerCallAlreadyDone", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setWasContactListServerCallAlreadyDone_Ljava_lang_Boolean_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setWasContactListServerCallAlreadyDone", "(Ljava/lang/Boolean;)V"), __args);
			} finally {
			}
		}

	}
}
