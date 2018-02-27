using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/ApplozicClient", DoNotGenerateAcw=true)]
	public partial class ApplozicClient : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/field[@name='AL_MESSAGE_META_DATA_KEY']"
		[Register ("AL_MESSAGE_META_DATA_KEY")]
		public const string AlMessageMetaDataKey = (string) "AL_MESSAGE_META_DATA_KEY";

		static IntPtr applozicClientInstance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/field[@name='applozicClientInstance']"
		[Register ("applozicClientInstance")]
		public static global::Com.Applozic.Mobicomkit.ApplozicClient ApplozicClientInstance {
			get {
				if (applozicClientInstance_jfieldId == IntPtr.Zero)
					applozicClientInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicClientInstance", "Lcom/applozic/mobicomkit/ApplozicClient;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, applozicClientInstance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (applozicClientInstance_jfieldId == IntPtr.Zero)
					applozicClientInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicClientInstance", "Lcom/applozic/mobicomkit/ApplozicClient;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, applozicClientInstance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sharedPreferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/field[@name='sharedPreferences']"
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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/ApplozicClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicClient); }
		}

		protected ApplozicClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAppName;
#pragma warning disable 0169
		static Delegate GetGetAppNameHandler ()
		{
			if (cb_getAppName == null)
				cb_getAppName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppName);
			return cb_getAppName;
		}

		static IntPtr n_GetAppName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		static IntPtr id_getAppName;
		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				if (id_getAppName == IntPtr.Zero)
					id_getAppName = JNIEnv.GetMethodID (class_ref, "getAppName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		public virtual unsafe string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultChannelImage;
#pragma warning disable 0169
		static Delegate GetGetDefaultChannelImageHandler ()
		{
			if (cb_getDefaultChannelImage == null)
				cb_getDefaultChannelImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultChannelImage);
			return cb_getDefaultChannelImage;
		}

		static IntPtr n_GetDefaultChannelImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultChannelImage);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultChannelImage;
		public virtual unsafe string DefaultChannelImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getDefaultChannelImage' and count(parameter)=0]"
			[Register ("getDefaultChannelImage", "()Ljava/lang/String;", "GetGetDefaultChannelImageHandler")]
			get {
				if (id_getDefaultChannelImage == IntPtr.Zero)
					id_getDefaultChannelImage = JNIEnv.GetMethodID (class_ref, "getDefaultChannelImage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultChannelImage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultChannelImage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultContactImage;
#pragma warning disable 0169
		static Delegate GetGetDefaultContactImageHandler ()
		{
			if (cb_getDefaultContactImage == null)
				cb_getDefaultContactImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultContactImage);
			return cb_getDefaultContactImage;
		}

		static IntPtr n_GetDefaultContactImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DefaultContactImage);
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultContactImage;
		public virtual unsafe string DefaultContactImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getDefaultContactImage' and count(parameter)=0]"
			[Register ("getDefaultContactImage", "()Ljava/lang/String;", "GetGetDefaultContactImageHandler")]
			get {
				if (id_getDefaultContactImage == IntPtr.Zero)
					id_getDefaultContactImage = JNIEnv.GetMethodID (class_ref, "getDefaultContactImage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultContactImage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultContactImage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIPCallEnabled;
#pragma warning disable 0169
		static Delegate GetIsIPCallEnabledHandler ()
		{
			if (cb_isIPCallEnabled == null)
				cb_isIPCallEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIPCallEnabled);
			return cb_isIPCallEnabled;
		}

		static bool n_IsIPCallEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IPCallEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setIPCallEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetIPCallEnabled_ZHandler ()
		{
			if (cb_setIPCallEnabled_Z == null)
				cb_setIPCallEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetIPCallEnabled_Z);
			return cb_setIPCallEnabled_Z;
		}

		static void n_SetIPCallEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IPCallEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isIPCallEnabled;
		static IntPtr id_setIPCallEnabled_Z;
		public virtual unsafe bool IPCallEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isIPCallEnabled' and count(parameter)=0]"
			[Register ("isIPCallEnabled", "()Z", "GetIsIPCallEnabledHandler")]
			get {
				if (id_isIPCallEnabled == IntPtr.Zero)
					id_isIPCallEnabled = JNIEnv.GetMethodID (class_ref, "isIPCallEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isIPCallEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isIPCallEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setIPCallEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIPCallEnabled", "(Z)V", "GetSetIPCallEnabled_ZHandler")]
			set {
				if (id_setIPCallEnabled_Z == IntPtr.Zero)
					id_setIPCallEnabled_Z = JNIEnv.GetMethodID (class_ref, "setIPCallEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIPCallEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIPCallEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAccountClosed;
#pragma warning disable 0169
		static Delegate GetIsAccountClosedHandler ()
		{
			if (cb_isAccountClosed == null)
				cb_isAccountClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAccountClosed);
			return cb_isAccountClosed;
		}

		static bool n_IsAccountClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAccountClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isAccountClosed;
		public virtual unsafe bool IsAccountClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isAccountClosed' and count(parameter)=0]"
			[Register ("isAccountClosed", "()Z", "GetIsAccountClosedHandler")]
			get {
				if (id_isAccountClosed == IntPtr.Zero)
					id_isAccountClosed = JNIEnv.GetMethodID (class_ref, "isAccountClosed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAccountClosed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAccountClosed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isChatListOnNotificationIsHidden;
#pragma warning disable 0169
		static Delegate GetIsChatListOnNotificationIsHiddenHandler ()
		{
			if (cb_isChatListOnNotificationIsHidden == null)
				cb_isChatListOnNotificationIsHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChatListOnNotificationIsHidden);
			return cb_isChatListOnNotificationIsHidden;
		}

		static bool n_IsChatListOnNotificationIsHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsChatListOnNotificationIsHidden;
		}
#pragma warning restore 0169

		static IntPtr id_isChatListOnNotificationIsHidden;
		public virtual unsafe bool IsChatListOnNotificationIsHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isChatListOnNotificationIsHidden' and count(parameter)=0]"
			[Register ("isChatListOnNotificationIsHidden", "()Z", "GetIsChatListOnNotificationIsHiddenHandler")]
			get {
				if (id_isChatListOnNotificationIsHidden == IntPtr.Zero)
					id_isChatListOnNotificationIsHidden = JNIEnv.GetMethodID (class_ref, "isChatListOnNotificationIsHidden", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChatListOnNotificationIsHidden);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChatListOnNotificationIsHidden", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isContextBasedChat;
#pragma warning disable 0169
		static Delegate GetIsContextBasedChatHandler ()
		{
			if (cb_isContextBasedChat == null)
				cb_isContextBasedChat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContextBasedChat);
			return cb_isContextBasedChat;
		}

		static bool n_IsContextBasedChat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsContextBasedChat;
		}
#pragma warning restore 0169

		static IntPtr id_isContextBasedChat;
		public virtual unsafe bool IsContextBasedChat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isContextBasedChat' and count(parameter)=0]"
			[Register ("isContextBasedChat", "()Z", "GetIsContextBasedChatHandler")]
			get {
				if (id_isContextBasedChat == IntPtr.Zero)
					id_isContextBasedChat = JNIEnv.GetMethodID (class_ref, "isContextBasedChat", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContextBasedChat);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContextBasedChat", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCustomStorageServiceEnabled;
#pragma warning disable 0169
		static Delegate GetIsCustomStorageServiceEnabledHandler ()
		{
			if (cb_isCustomStorageServiceEnabled == null)
				cb_isCustomStorageServiceEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCustomStorageServiceEnabled);
			return cb_isCustomStorageServiceEnabled;
		}

		static bool n_IsCustomStorageServiceEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCustomStorageServiceEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isCustomStorageServiceEnabled;
		public virtual unsafe bool IsCustomStorageServiceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isCustomStorageServiceEnabled' and count(parameter)=0]"
			[Register ("isCustomStorageServiceEnabled", "()Z", "GetIsCustomStorageServiceEnabledHandler")]
			get {
				if (id_isCustomStorageServiceEnabled == IntPtr.Zero)
					id_isCustomStorageServiceEnabled = JNIEnv.GetMethodID (class_ref, "isCustomStorageServiceEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCustomStorageServiceEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCustomStorageServiceEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHandleDial;
#pragma warning disable 0169
		static Delegate GetIsHandleDialHandler ()
		{
			if (cb_isHandleDial == null)
				cb_isHandleDial = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHandleDial);
			return cb_isHandleDial;
		}

		static bool n_IsHandleDial (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHandleDial;
		}
#pragma warning restore 0169

		static IntPtr id_isHandleDial;
		public virtual unsafe bool IsHandleDial {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isHandleDial' and count(parameter)=0]"
			[Register ("isHandleDial", "()Z", "GetIsHandleDialHandler")]
			get {
				if (id_isHandleDial == IntPtr.Zero)
					id_isHandleDial = JNIEnv.GetMethodID (class_ref, "isHandleDial", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHandleDial);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHandleDial", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHandleDisplayName;
#pragma warning disable 0169
		static Delegate GetIsHandleDisplayNameHandler ()
		{
			if (cb_isHandleDisplayName == null)
				cb_isHandleDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHandleDisplayName);
			return cb_isHandleDisplayName;
		}

		static bool n_IsHandleDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHandleDisplayName;
		}
#pragma warning restore 0169

		static IntPtr id_isHandleDisplayName;
		public virtual unsafe bool IsHandleDisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isHandleDisplayName' and count(parameter)=0]"
			[Register ("isHandleDisplayName", "()Z", "GetIsHandleDisplayNameHandler")]
			get {
				if (id_isHandleDisplayName == IntPtr.Zero)
					id_isHandleDisplayName = JNIEnv.GetMethodID (class_ref, "isHandleDisplayName", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHandleDisplayName);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHandleDisplayName", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNotAllowed;
#pragma warning disable 0169
		static Delegate GetIsNotAllowedHandler ()
		{
			if (cb_isNotAllowed == null)
				cb_isNotAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotAllowed);
			return cb_isNotAllowed;
		}

		static bool n_IsNotAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_isNotAllowed;
		public virtual unsafe bool IsNotAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isNotAllowed' and count(parameter)=0]"
			[Register ("isNotAllowed", "()Z", "GetIsNotAllowedHandler")]
			get {
				if (id_isNotAllowed == IntPtr.Zero)
					id_isNotAllowed = JNIEnv.GetMethodID (class_ref, "isNotAllowed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotAllowed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotAllowed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNotificationDisabled;
#pragma warning disable 0169
		static Delegate GetIsNotificationDisabledHandler ()
		{
			if (cb_isNotificationDisabled == null)
				cb_isNotificationDisabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotificationDisabled);
			return cb_isNotificationDisabled;
		}

		static bool n_IsNotificationDisabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotificationDisabled;
		}
#pragma warning restore 0169

		static IntPtr id_isNotificationDisabled;
		public virtual unsafe bool IsNotificationDisabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isNotificationDisabled' and count(parameter)=0]"
			[Register ("isNotificationDisabled", "()Z", "GetIsNotificationDisabledHandler")]
			get {
				if (id_isNotificationDisabled == IntPtr.Zero)
					id_isNotificationDisabled = JNIEnv.GetMethodID (class_ref, "isNotificationDisabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotificationDisabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotificationDisabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isNotificationSmallIconHidden;
#pragma warning disable 0169
		static Delegate GetIsNotificationSmallIconHiddenHandler ()
		{
			if (cb_isNotificationSmallIconHidden == null)
				cb_isNotificationSmallIconHidden = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotificationSmallIconHidden);
			return cb_isNotificationSmallIconHidden;
		}

		static bool n_IsNotificationSmallIconHidden (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNotificationSmallIconHidden;
		}
#pragma warning restore 0169

		static IntPtr id_isNotificationSmallIconHidden;
		public virtual unsafe bool IsNotificationSmallIconHidden {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isNotificationSmallIconHidden' and count(parameter)=0]"
			[Register ("isNotificationSmallIconHidden", "()Z", "GetIsNotificationSmallIconHiddenHandler")]
			get {
				if (id_isNotificationSmallIconHidden == IntPtr.Zero)
					id_isNotificationSmallIconHidden = JNIEnv.GetMethodID (class_ref, "isNotificationSmallIconHidden", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotificationSmallIconHidden);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotificationSmallIconHidden", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowAppIconInNotification;
#pragma warning disable 0169
		static Delegate GetIsShowAppIconInNotificationHandler ()
		{
			if (cb_isShowAppIconInNotification == null)
				cb_isShowAppIconInNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowAppIconInNotification);
			return cb_isShowAppIconInNotification;
		}

		static bool n_IsShowAppIconInNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowAppIconInNotification;
		}
#pragma warning restore 0169

		static IntPtr id_isShowAppIconInNotification;
		public virtual unsafe bool IsShowAppIconInNotification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isShowAppIconInNotification' and count(parameter)=0]"
			[Register ("isShowAppIconInNotification", "()Z", "GetIsShowAppIconInNotificationHandler")]
			get {
				if (id_isShowAppIconInNotification == IntPtr.Zero)
					id_isShowAppIconInNotification = JNIEnv.GetMethodID (class_ref, "isShowAppIconInNotification", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowAppIconInNotification);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowAppIconInNotification", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowMyContacts;
#pragma warning disable 0169
		static Delegate GetIsShowMyContactsHandler ()
		{
			if (cb_isShowMyContacts == null)
				cb_isShowMyContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowMyContacts);
			return cb_isShowMyContacts;
		}

		static bool n_IsShowMyContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowMyContacts;
		}
#pragma warning restore 0169

		static IntPtr id_isShowMyContacts;
		public virtual unsafe bool IsShowMyContacts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isShowMyContacts' and count(parameter)=0]"
			[Register ("isShowMyContacts", "()Z", "GetIsShowMyContactsHandler")]
			get {
				if (id_isShowMyContacts == IntPtr.Zero)
					id_isShowMyContacts = JNIEnv.GetMethodID (class_ref, "isShowMyContacts", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowMyContacts);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowMyContacts", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartGroupOfTwo;
#pragma warning disable 0169
		static Delegate GetIsStartGroupOfTwoHandler ()
		{
			if (cb_isStartGroupOfTwo == null)
				cb_isStartGroupOfTwo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartGroupOfTwo);
			return cb_isStartGroupOfTwo;
		}

		static bool n_IsStartGroupOfTwo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartGroupOfTwo;
		}
#pragma warning restore 0169

		static IntPtr id_isStartGroupOfTwo;
		public virtual unsafe bool IsStartGroupOfTwo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isStartGroupOfTwo' and count(parameter)=0]"
			[Register ("isStartGroupOfTwo", "()Z", "GetIsStartGroupOfTwoHandler")]
			get {
				if (id_isStartGroupOfTwo == IntPtr.Zero)
					id_isStartGroupOfTwo = JNIEnv.GetMethodID (class_ref, "isStartGroupOfTwo", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartGroupOfTwo);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartGroupOfTwo", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStorageServiceEnabled;
#pragma warning disable 0169
		static Delegate GetIsStorageServiceEnabledHandler ()
		{
			if (cb_isStorageServiceEnabled == null)
				cb_isStorageServiceEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStorageServiceEnabled);
			return cb_isStorageServiceEnabled;
		}

		static bool n_IsStorageServiceEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStorageServiceEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isStorageServiceEnabled;
		public virtual unsafe bool IsStorageServiceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isStorageServiceEnabled' and count(parameter)=0]"
			[Register ("isStorageServiceEnabled", "()Z", "GetIsStorageServiceEnabledHandler")]
			get {
				if (id_isStorageServiceEnabled == IntPtr.Zero)
					id_isStorageServiceEnabled = JNIEnv.GetMethodID (class_ref, "isStorageServiceEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStorageServiceEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStorageServiceEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUnreadCountBadgeEnabled;
#pragma warning disable 0169
		static Delegate GetIsUnreadCountBadgeEnabledHandler ()
		{
			if (cb_isUnreadCountBadgeEnabled == null)
				cb_isUnreadCountBadgeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUnreadCountBadgeEnabled);
			return cb_isUnreadCountBadgeEnabled;
		}

		static bool n_IsUnreadCountBadgeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUnreadCountBadgeEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isUnreadCountBadgeEnabled;
		public virtual unsafe bool IsUnreadCountBadgeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isUnreadCountBadgeEnabled' and count(parameter)=0]"
			[Register ("isUnreadCountBadgeEnabled", "()Z", "GetIsUnreadCountBadgeEnabledHandler")]
			get {
				if (id_isUnreadCountBadgeEnabled == IntPtr.Zero)
					id_isUnreadCountBadgeEnabled = JNIEnv.GetMethodID (class_ref, "isUnreadCountBadgeEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUnreadCountBadgeEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUnreadCountBadgeEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageMetaData;
#pragma warning disable 0169
		static Delegate GetGetMessageMetaDataHandler ()
		{
			if (cb_getMessageMetaData == null)
				cb_getMessageMetaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageMetaData);
			return cb_getMessageMetaData;
		}

		static IntPtr n_GetMessageMetaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageMetaData);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageMetaData;
		public virtual unsafe string MessageMetaData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getMessageMetaData' and count(parameter)=0]"
			[Register ("getMessageMetaData", "()Ljava/lang/String;", "GetGetMessageMetaDataHandler")]
			get {
				if (id_getMessageMetaData == IntPtr.Zero)
					id_getMessageMetaData = JNIEnv.GetMethodID (class_ref, "getMessageMetaData", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageMetaData), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageMetaData", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageMetaDataServiceName;
#pragma warning disable 0169
		static Delegate GetGetMessageMetaDataServiceNameHandler ()
		{
			if (cb_getMessageMetaDataServiceName == null)
				cb_getMessageMetaDataServiceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageMetaDataServiceName);
			return cb_getMessageMetaDataServiceName;
		}

		static IntPtr n_GetMessageMetaDataServiceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageMetaDataServiceName);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageMetaDataServiceName;
		public virtual unsafe string MessageMetaDataServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getMessageMetaDataServiceName' and count(parameter)=0]"
			[Register ("getMessageMetaDataServiceName", "()Ljava/lang/String;", "GetGetMessageMetaDataServiceNameHandler")]
			get {
				if (id_getMessageMetaDataServiceName == IntPtr.Zero)
					id_getMessageMetaDataServiceName = JNIEnv.GetMethodID (class_ref, "getMessageMetaDataServiceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageMetaDataServiceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageMetaDataServiceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isNotificationStacking;
#pragma warning disable 0169
		static Delegate GetIsNotificationStackingHandler ()
		{
			if (cb_isNotificationStacking == null)
				cb_isNotificationStacking = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotificationStacking);
			return cb_isNotificationStacking;
		}

		static bool n_IsNotificationStacking (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotificationStacking;
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationStacking_Z;
#pragma warning disable 0169
		static Delegate GetSetNotificationStacking_ZHandler ()
		{
			if (cb_setNotificationStacking_Z == null)
				cb_setNotificationStacking_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotificationStacking_Z);
			return cb_setNotificationStacking_Z;
		}

		static void n_SetNotificationStacking_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotificationStacking = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNotificationStacking;
		static IntPtr id_setNotificationStacking_Z;
		public virtual unsafe bool NotificationStacking {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='isNotificationStacking' and count(parameter)=0]"
			[Register ("isNotificationStacking", "()Z", "GetIsNotificationStackingHandler")]
			get {
				if (id_isNotificationStacking == IntPtr.Zero)
					id_isNotificationStacking = JNIEnv.GetMethodID (class_ref, "isNotificationStacking", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotificationStacking);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotificationStacking", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setNotificationStacking' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotificationStacking", "(Z)V", "GetSetNotificationStacking_ZHandler")]
			set {
				if (id_setNotificationStacking_Z == IntPtr.Zero)
					id_setNotificationStacking_Z = JNIEnv.GetMethodID (class_ref, "setNotificationStacking", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationStacking_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationStacking", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVibrationOnNotification;
#pragma warning disable 0169
		static Delegate GetGetVibrationOnNotificationHandler ()
		{
			if (cb_getVibrationOnNotification == null)
				cb_getVibrationOnNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetVibrationOnNotification);
			return cb_getVibrationOnNotification;
		}

		static bool n_GetVibrationOnNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VibrationOnNotification;
		}
#pragma warning restore 0169

		static Delegate cb_setVibrationOnNotification_Z;
#pragma warning disable 0169
		static Delegate GetSetVibrationOnNotification_ZHandler ()
		{
			if (cb_setVibrationOnNotification_Z == null)
				cb_setVibrationOnNotification_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVibrationOnNotification_Z);
			return cb_setVibrationOnNotification_Z;
		}

		static void n_SetVibrationOnNotification_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VibrationOnNotification = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVibrationOnNotification;
		static IntPtr id_setVibrationOnNotification_Z;
		public virtual unsafe bool VibrationOnNotification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getVibrationOnNotification' and count(parameter)=0]"
			[Register ("getVibrationOnNotification", "()Z", "GetGetVibrationOnNotificationHandler")]
			get {
				if (id_getVibrationOnNotification == IntPtr.Zero)
					id_getVibrationOnNotification = JNIEnv.GetMethodID (class_ref, "getVibrationOnNotification", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getVibrationOnNotification);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVibrationOnNotification", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setVibrationOnNotification' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVibrationOnNotification", "(Z)V", "GetSetVibrationOnNotification_ZHandler")]
			set {
				if (id_setVibrationOnNotification_Z == IntPtr.Zero)
					id_setVibrationOnNotification_Z = JNIEnv.GetMethodID (class_ref, "setVibrationOnNotification", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVibrationOnNotification_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVibrationOnNotification", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_disableNotification;
#pragma warning disable 0169
		static Delegate GetDisableNotificationHandler ()
		{
			if (cb_disableNotification == null)
				cb_disableNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableNotification);
			return cb_disableNotification;
		}

		static IntPtr n_DisableNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableNotification ());
		}
#pragma warning restore 0169

		static IntPtr id_disableNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='disableNotification' and count(parameter)=0]"
		[Register ("disableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetDisableNotificationHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient DisableNotification ()
		{
			if (id_disableNotification == IntPtr.Zero)
				id_disableNotification = JNIEnv.GetMethodID (class_ref, "disableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableNotification), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableShowMyContacts;
#pragma warning disable 0169
		static Delegate GetDisableShowMyContactsHandler ()
		{
			if (cb_disableShowMyContacts == null)
				cb_disableShowMyContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableShowMyContacts);
			return cb_disableShowMyContacts;
		}

		static IntPtr n_DisableShowMyContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableShowMyContacts ());
		}
#pragma warning restore 0169

		static IntPtr id_disableShowMyContacts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='disableShowMyContacts' and count(parameter)=0]"
		[Register ("disableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetDisableShowMyContactsHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient DisableShowMyContacts ()
		{
			if (id_disableShowMyContacts == IntPtr.Zero)
				id_disableShowMyContacts = JNIEnv.GetMethodID (class_ref, "disableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableShowMyContacts), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disableStartGroupOfTwo;
#pragma warning disable 0169
		static Delegate GetDisableStartGroupOfTwoHandler ()
		{
			if (cb_disableStartGroupOfTwo == null)
				cb_disableStartGroupOfTwo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DisableStartGroupOfTwo);
			return cb_disableStartGroupOfTwo;
		}

		static IntPtr n_DisableStartGroupOfTwo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisableStartGroupOfTwo ());
		}
#pragma warning restore 0169

		static IntPtr id_disableStartGroupOfTwo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='disableStartGroupOfTwo' and count(parameter)=0]"
		[Register ("disableStartGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetDisableStartGroupOfTwoHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient DisableStartGroupOfTwo ()
		{
			if (id_disableStartGroupOfTwo == IntPtr.Zero)
				id_disableStartGroupOfTwo = JNIEnv.GetMethodID (class_ref, "disableStartGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableStartGroupOfTwo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableStartGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableCustomStorageService;
#pragma warning disable 0169
		static Delegate GetEnableCustomStorageServiceHandler ()
		{
			if (cb_enableCustomStorageService == null)
				cb_enableCustomStorageService = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableCustomStorageService);
			return cb_enableCustomStorageService;
		}

		static IntPtr n_EnableCustomStorageService (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableCustomStorageService ());
		}
#pragma warning restore 0169

		static IntPtr id_enableCustomStorageService;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='enableCustomStorageService' and count(parameter)=0]"
		[Register ("enableCustomStorageService", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetEnableCustomStorageServiceHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient EnableCustomStorageService ()
		{
			if (id_enableCustomStorageService == IntPtr.Zero)
				id_enableCustomStorageService = JNIEnv.GetMethodID (class_ref, "enableCustomStorageService", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableCustomStorageService), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableCustomStorageService", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableNotification;
#pragma warning disable 0169
		static Delegate GetEnableNotificationHandler ()
		{
			if (cb_enableNotification == null)
				cb_enableNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableNotification);
			return cb_enableNotification;
		}

		static IntPtr n_EnableNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableNotification ());
		}
#pragma warning restore 0169

		static IntPtr id_enableNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='enableNotification' and count(parameter)=0]"
		[Register ("enableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetEnableNotificationHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient EnableNotification ()
		{
			if (id_enableNotification == IntPtr.Zero)
				id_enableNotification = JNIEnv.GetMethodID (class_ref, "enableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableNotification), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableShowMyContacts;
#pragma warning disable 0169
		static Delegate GetEnableShowMyContactsHandler ()
		{
			if (cb_enableShowMyContacts == null)
				cb_enableShowMyContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableShowMyContacts);
			return cb_enableShowMyContacts;
		}

		static IntPtr n_EnableShowMyContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableShowMyContacts ());
		}
#pragma warning restore 0169

		static IntPtr id_enableShowMyContacts;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='enableShowMyContacts' and count(parameter)=0]"
		[Register ("enableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetEnableShowMyContactsHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient EnableShowMyContacts ()
		{
			if (id_enableShowMyContacts == IntPtr.Zero)
				id_enableShowMyContacts = JNIEnv.GetMethodID (class_ref, "enableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableShowMyContacts), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableShowMyContacts", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_enableShowUnreadCountBadge;
#pragma warning disable 0169
		static Delegate GetEnableShowUnreadCountBadgeHandler ()
		{
			if (cb_enableShowUnreadCountBadge == null)
				cb_enableShowUnreadCountBadge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EnableShowUnreadCountBadge);
			return cb_enableShowUnreadCountBadge;
		}

		static IntPtr n_EnableShowUnreadCountBadge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EnableShowUnreadCountBadge ());
		}
#pragma warning restore 0169

		static IntPtr id_enableShowUnreadCountBadge;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='enableShowUnreadCountBadge' and count(parameter)=0]"
		[Register ("enableShowUnreadCountBadge", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetEnableShowUnreadCountBadgeHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient EnableShowUnreadCountBadge ()
		{
			if (id_enableShowUnreadCountBadge == IntPtr.Zero)
				id_enableShowUnreadCountBadge = JNIEnv.GetMethodID (class_ref, "enableShowUnreadCountBadge", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableShowUnreadCountBadge), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableShowUnreadCountBadge", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/ApplozicClient;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.ApplozicClient GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.ApplozicClient __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_hideChatListOnNotification;
#pragma warning disable 0169
		static Delegate GetHideChatListOnNotificationHandler ()
		{
			if (cb_hideChatListOnNotification == null)
				cb_hideChatListOnNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideChatListOnNotification);
			return cb_hideChatListOnNotification;
		}

		static IntPtr n_HideChatListOnNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideChatListOnNotification ());
		}
#pragma warning restore 0169

		static IntPtr id_hideChatListOnNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='hideChatListOnNotification' and count(parameter)=0]"
		[Register ("hideChatListOnNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetHideChatListOnNotificationHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient HideChatListOnNotification ()
		{
			if (id_hideChatListOnNotification == IntPtr.Zero)
				id_hideChatListOnNotification = JNIEnv.GetMethodID (class_ref, "hideChatListOnNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideChatListOnNotification), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideChatListOnNotification", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_hideNotificationSmallIcon;
#pragma warning disable 0169
		static Delegate GetHideNotificationSmallIconHandler ()
		{
			if (cb_hideNotificationSmallIcon == null)
				cb_hideNotificationSmallIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_HideNotificationSmallIcon);
			return cb_hideNotificationSmallIcon;
		}

		static IntPtr n_HideNotificationSmallIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HideNotificationSmallIcon ());
		}
#pragma warning restore 0169

		static IntPtr id_hideNotificationSmallIcon;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='hideNotificationSmallIcon' and count(parameter)=0]"
		[Register ("hideNotificationSmallIcon", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetHideNotificationSmallIconHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient HideNotificationSmallIcon ()
		{
			if (id_hideNotificationSmallIcon == IntPtr.Zero)
				id_hideNotificationSmallIcon = JNIEnv.GetMethodID (class_ref, "hideNotificationSmallIcon", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_hideNotificationSmallIcon), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideNotificationSmallIcon", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAppName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppName_Ljava_lang_String_ == null)
				cb_setAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetAppName_Ljava_lang_String_);
			return cb_setAppName_Ljava_lang_String_;
		}

		static IntPtr n_SetAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetAppName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setAppName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetAppName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetAppName (string p0)
		{
			if (id_setAppName_Ljava_lang_String_ == IntPtr.Zero)
				id_setAppName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setAppName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setApplicationKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationKey_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationKey_Ljava_lang_String_ == null)
				cb_setApplicationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApplicationKey_Ljava_lang_String_);
			return cb_setApplicationKey_Ljava_lang_String_;
		}

		static IntPtr n_SetApplicationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApplicationKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setApplicationKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setApplicationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetApplicationKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetApplicationKey (string p0)
		{
			if (id_setApplicationKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setApplicationKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setContextBasedChat_Z;
#pragma warning disable 0169
		static Delegate GetSetContextBasedChat_ZHandler ()
		{
			if (cb_setContextBasedChat_Z == null)
				cb_setContextBasedChat_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetContextBasedChat_Z);
			return cb_setContextBasedChat_Z;
		}

		static IntPtr n_SetContextBasedChat_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContextBasedChat (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setContextBasedChat_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setContextBasedChat' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setContextBasedChat", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetContextBasedChat_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetContextBasedChat (bool p0)
		{
			if (id_setContextBasedChat_Z == IntPtr.Zero)
				id_setContextBasedChat_Z = JNIEnv.GetMethodID (class_ref, "setContextBasedChat", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContextBasedChat_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContextBasedChat", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDefaultChannelImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultChannelImage_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultChannelImage_Ljava_lang_String_ == null)
				cb_setDefaultChannelImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDefaultChannelImage_Ljava_lang_String_);
			return cb_setDefaultChannelImage_Ljava_lang_String_;
		}

		static IntPtr n_SetDefaultChannelImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDefaultChannelImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultChannelImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setDefaultChannelImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDefaultChannelImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetDefaultChannelImage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetDefaultChannelImage (string p0)
		{
			if (id_setDefaultChannelImage_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultChannelImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultChannelImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultChannelImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultChannelImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDefaultContactImage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDefaultContactImage_Ljava_lang_String_Handler ()
		{
			if (cb_setDefaultContactImage_Ljava_lang_String_ == null)
				cb_setDefaultContactImage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDefaultContactImage_Ljava_lang_String_);
			return cb_setDefaultContactImage_Ljava_lang_String_;
		}

		static IntPtr n_SetDefaultContactImage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDefaultContactImage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDefaultContactImage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setDefaultContactImage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDefaultContactImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetDefaultContactImage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetDefaultContactImage (string p0)
		{
			if (id_setDefaultContactImage_Ljava_lang_String_ == IntPtr.Zero)
				id_setDefaultContactImage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDefaultContactImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultContactImage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultContactImage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setHandleDial_Z;
#pragma warning disable 0169
		static Delegate GetSetHandleDial_ZHandler ()
		{
			if (cb_setHandleDial_Z == null)
				cb_setHandleDial_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHandleDial_Z);
			return cb_setHandleDial_Z;
		}

		static IntPtr n_SetHandleDial_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHandleDial (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHandleDial_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setHandleDial' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHandleDial", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetHandleDial_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetHandleDial (bool p0)
		{
			if (id_setHandleDial_Z == IntPtr.Zero)
				id_setHandleDial_Z = JNIEnv.GetMethodID (class_ref, "setHandleDial", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHandleDial_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandleDial", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHandleDisplayName_Z;
#pragma warning disable 0169
		static Delegate GetSetHandleDisplayName_ZHandler ()
		{
			if (cb_setHandleDisplayName_Z == null)
				cb_setHandleDisplayName_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetHandleDisplayName_Z);
			return cb_setHandleDisplayName_Z;
		}

		static IntPtr n_SetHandleDisplayName_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHandleDisplayName (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHandleDisplayName_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setHandleDisplayName' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHandleDisplayName", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetHandleDisplayName_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetHandleDisplayName (bool p0)
		{
			if (id_setHandleDisplayName_Z == IntPtr.Zero)
				id_setHandleDisplayName_Z = JNIEnv.GetMethodID (class_ref, "setHandleDisplayName", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHandleDisplayName_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHandleDisplayName", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMessageMetaData_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMessageMetaData_Ljava_util_Map_Handler ()
		{
			if (cb_setMessageMetaData_Ljava_util_Map_ == null)
				cb_setMessageMetaData_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageMetaData_Ljava_util_Map_);
			return cb_setMessageMetaData_Ljava_util_Map_;
		}

		static IntPtr n_SetMessageMetaData_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessageMetaData (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessageMetaData_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setMessageMetaData' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setMessageMetaData", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetMessageMetaData_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetMessageMetaData (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setMessageMetaData_Ljava_util_Map_ == IntPtr.Zero)
				id_setMessageMetaData_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMessageMetaData", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessageMetaData_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageMetaData", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMessageMetaDataServiceName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageMetaDataServiceName_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageMetaDataServiceName_Ljava_lang_String_ == null)
				cb_setMessageMetaDataServiceName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageMetaDataServiceName_Ljava_lang_String_);
			return cb_setMessageMetaDataServiceName_Ljava_lang_String_;
		}

		static IntPtr n_SetMessageMetaDataServiceName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessageMetaDataServiceName (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessageMetaDataServiceName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setMessageMetaDataServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessageMetaDataServiceName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetMessageMetaDataServiceName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetMessageMetaDataServiceName (string p0)
		{
			if (id_setMessageMetaDataServiceName_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessageMetaDataServiceName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageMetaDataServiceName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.ApplozicClient __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessageMetaDataServiceName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageMetaDataServiceName", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setStorageServiceEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetStorageServiceEnabled_ZHandler ()
		{
			if (cb_setStorageServiceEnabled_Z == null)
				cb_setStorageServiceEnabled_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetStorageServiceEnabled_Z);
			return cb_setStorageServiceEnabled_Z;
		}

		static IntPtr n_SetStorageServiceEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetStorageServiceEnabled (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setStorageServiceEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='setStorageServiceEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setStorageServiceEnabled", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;", "GetSetStorageServiceEnabled_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient SetStorageServiceEnabled (bool p0)
		{
			if (id_setStorageServiceEnabled_Z == IntPtr.Zero)
				id_setStorageServiceEnabled_Z = JNIEnv.GetMethodID (class_ref, "setStorageServiceEnabled", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setStorageServiceEnabled_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStorageServiceEnabled", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_showAppIconInNotification_Z;
#pragma warning disable 0169
		static Delegate GetShowAppIconInNotification_ZHandler ()
		{
			if (cb_showAppIconInNotification_Z == null)
				cb_showAppIconInNotification_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_ShowAppIconInNotification_Z);
			return cb_showAppIconInNotification_Z;
		}

		static IntPtr n_ShowAppIconInNotification_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShowAppIconInNotification (p0));
		}
#pragma warning restore 0169

		static IntPtr id_showAppIconInNotification_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='showAppIconInNotification' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showAppIconInNotification", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;", "GetShowAppIconInNotification_ZHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient ShowAppIconInNotification (bool p0)
		{
			if (id_showAppIconInNotification_Z == IntPtr.Zero)
				id_showAppIconInNotification_Z = JNIEnv.GetMethodID (class_ref, "showAppIconInNotification", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_showAppIconInNotification_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showAppIconInNotification", "(Z)Lcom/applozic/mobicomkit/ApplozicClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startGroupOfTwo;
#pragma warning disable 0169
		static Delegate GetStartGroupOfTwoHandler ()
		{
			if (cb_startGroupOfTwo == null)
				cb_startGroupOfTwo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_StartGroupOfTwo);
			return cb_startGroupOfTwo;
		}

		static IntPtr n_StartGroupOfTwo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.ApplozicClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StartGroupOfTwo ());
		}
#pragma warning restore 0169

		static IntPtr id_startGroupOfTwo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='ApplozicClient']/method[@name='startGroupOfTwo' and count(parameter)=0]"
		[Register ("startGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;", "GetStartGroupOfTwoHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.ApplozicClient StartGroupOfTwo ()
		{
			if (id_startGroupOfTwo == IntPtr.Zero)
				id_startGroupOfTwo = JNIEnv.GetMethodID (class_ref, "startGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_startGroupOfTwo), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.ApplozicClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startGroupOfTwo", "()Lcom/applozic/mobicomkit/ApplozicClient;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
