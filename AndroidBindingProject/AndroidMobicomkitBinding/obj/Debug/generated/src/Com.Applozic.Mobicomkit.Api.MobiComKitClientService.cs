using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/MobiComKitClientService", DoNotGenerateAcw=true)]
	public partial class MobiComKitClientService : global::Java.Lang.Object {


		static IntPtr APPLICATION_KEY_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='APPLICATION_KEY_HEADER']"
		[Register ("APPLICATION_KEY_HEADER")]
		public static string ApplicationKeyHeader {
			get {
				if (APPLICATION_KEY_HEADER_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_KEY_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_KEY_HEADER_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_KEY_HEADER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='APPLICATION_KEY_HEADER_VALUE_METADATA']"
		[Register ("APPLICATION_KEY_HEADER_VALUE_METADATA")]
		public static string ApplicationKeyHeaderValueMetadata {
			get {
				if (APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_HEADER_VALUE_METADATA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId == IntPtr.Zero)
					APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION_KEY_HEADER_VALUE_METADATA", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_KEY_HEADER_VALUE_METADATA_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APP_MODULE_NAME_META_DATA_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='APP_MODULE_NAME_META_DATA_KEY']"
		[Register ("APP_MODULE_NAME_META_DATA_KEY")]
		public static string AppModuleNameMetaDataKey {
			get {
				if (APP_MODULE_NAME_META_DATA_KEY_jfieldId == IntPtr.Zero)
					APP_MODULE_NAME_META_DATA_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MODULE_NAME_META_DATA_KEY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_MODULE_NAME_META_DATA_KEY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_MODULE_NAME_META_DATA_KEY_jfieldId == IntPtr.Zero)
					APP_MODULE_NAME_META_DATA_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MODULE_NAME_META_DATA_KEY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APP_MODULE_NAME_META_DATA_KEY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APP_MOUDLE_NAME_KEY_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='APP_MOUDLE_NAME_KEY_HEADER']"
		[Register ("APP_MOUDLE_NAME_KEY_HEADER")]
		public static string AppMoudleNameKeyHeader {
			get {
				if (APP_MOUDLE_NAME_KEY_HEADER_jfieldId == IntPtr.Zero)
					APP_MOUDLE_NAME_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MOUDLE_NAME_KEY_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_MOUDLE_NAME_KEY_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_MOUDLE_NAME_KEY_HEADER_jfieldId == IntPtr.Zero)
					APP_MOUDLE_NAME_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MOUDLE_NAME_KEY_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APP_MOUDLE_NAME_KEY_HEADER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='BASE_URL_METADATA']"
		[Register ("BASE_URL_METADATA")]
		public const string BaseUrlMetadata = (string) "com.applozic.server.url";

		static IntPtr DEFAULT_MQTT_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='DEFAULT_MQTT_URL']"
		[Register ("DEFAULT_MQTT_URL")]
		protected string DefaultMqttUrl {
			get {
				if (DEFAULT_MQTT_URL_jfieldId == IntPtr.Zero)
					DEFAULT_MQTT_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_MQTT_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DEFAULT_MQTT_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_MQTT_URL_jfieldId == IntPtr.Zero)
					DEFAULT_MQTT_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_MQTT_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DEFAULT_MQTT_URL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DEFAULT_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='DEFAULT_URL']"
		[Register ("DEFAULT_URL")]
		protected string DefaultUrl {
			get {
				if (DEFAULT_URL_jfieldId == IntPtr.Zero)
					DEFAULT_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, DEFAULT_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEFAULT_URL_jfieldId == IntPtr.Zero)
					DEFAULT_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "DEFAULT_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, DEFAULT_URL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FILE_BASE_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='FILE_BASE_URL']"
		[Register ("FILE_BASE_URL")]
		protected string FileBaseUrl {
			get {
				if (FILE_BASE_URL_jfieldId == IntPtr.Zero)
					FILE_BASE_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "FILE_BASE_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, FILE_BASE_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FILE_BASE_URL_jfieldId == IntPtr.Zero)
					FILE_BASE_URL_jfieldId = JNIEnv.GetFieldID (class_ref, "FILE_BASE_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, FILE_BASE_URL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='MQTT_BASE_URL_METADATA']"
		[Register ("MQTT_BASE_URL_METADATA")]
		public const string MqttBaseUrlMetadata = (string) "com.applozic.mqtt.server.url";

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/MobiComKitClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComKitClientService); }
		}

		protected MobiComKitClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/constructor[@name='MobiComKitClientService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MobiComKitClientService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MobiComKitClientService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/constructor[@name='MobiComKitClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobiComKitClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobiComKitClientService)) {
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

		static Delegate cb_getBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetBaseUrlHandler ()
		{
			if (cb_getBaseUrl == null)
				cb_getBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUrl);
			return cb_getBaseUrl;
		}

		static IntPtr n_GetBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BaseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getBaseUrl;
		protected virtual unsafe string BaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getBaseUrl' and count(parameter)=0]"
			[Register ("getBaseUrl", "()Ljava/lang/String;", "GetGetBaseUrlHandler")]
			get {
				if (id_getBaseUrl == IntPtr.Zero)
					id_getBaseUrl = JNIEnv.GetMethodID (class_ref, "getBaseUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCredentials;
#pragma warning disable 0169
		static Delegate GetGetCredentialsHandler ()
		{
			if (cb_getCredentials == null)
				cb_getCredentials = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCredentials);
			return cb_getCredentials;
		}

		static IntPtr n_GetCredentials (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		static IntPtr id_getCredentials;
		public virtual unsafe global::Java.Net.PasswordAuthentication Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getCredentials' and count(parameter)=0]"
			[Register ("getCredentials", "()Ljava/net/PasswordAuthentication;", "GetGetCredentialsHandler")]
			get {
				if (id_getCredentials == IntPtr.Zero)
					id_getCredentials = JNIEnv.GetMethodID (class_ref, "getCredentials", "()Ljava/net/PasswordAuthentication;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Net.PasswordAuthentication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCredentials), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Net.PasswordAuthentication> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCredentials", "()Ljava/net/PasswordAuthentication;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFileUrl;
#pragma warning disable 0169
		static Delegate GetGetFileUrlHandler ()
		{
			if (cb_getFileUrl == null)
				cb_getFileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFileUrl);
			return cb_getFileUrl;
		}

		static IntPtr n_GetFileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getFileUrl;
		public virtual unsafe string FileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getFileUrl' and count(parameter)=0]"
			[Register ("getFileUrl", "()Ljava/lang/String;", "GetGetFileUrlHandler")]
			get {
				if (id_getFileUrl == IntPtr.Zero)
					id_getFileUrl = JNIEnv.GetMethodID (class_ref, "getFileUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFileUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFileUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMqttBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetMqttBaseUrlHandler ()
		{
			if (cb_getMqttBaseUrl == null)
				cb_getMqttBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMqttBaseUrl);
			return cb_getMqttBaseUrl;
		}

		static IntPtr n_GetMqttBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MqttBaseUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMqttBaseUrl;
		protected virtual unsafe string MqttBaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getMqttBaseUrl' and count(parameter)=0]"
			[Register ("getMqttBaseUrl", "()Ljava/lang/String;", "GetGetMqttBaseUrlHandler")]
			get {
				if (id_getMqttBaseUrl == IntPtr.Zero)
					id_getMqttBaseUrl = JNIEnv.GetMethodID (class_ref, "getMqttBaseUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMqttBaseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMqttBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAppModuleName_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getAppModuleName' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppModuleName", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAppModuleName (global::Android.Content.Context p0)
		{
			if (id_getAppModuleName_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppModuleName_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppModuleName", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAppModuleName_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getApplicationKey_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='getApplicationKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getApplicationKey", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetApplicationKey (global::Android.Content.Context p0)
		{
			if (id_getApplicationKey_Landroid_content_Context_ == IntPtr.Zero)
				id_getApplicationKey_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getApplicationKey", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getApplicationKey_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_openHttpConnection_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenHttpConnection_Ljava_lang_String_Handler ()
		{
			if (cb_openHttpConnection_Ljava_lang_String_ == null)
				cb_openHttpConnection_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenHttpConnection_Ljava_lang_String_);
			return cb_openHttpConnection_Ljava_lang_String_;
		}

		static IntPtr n_OpenHttpConnection_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenHttpConnection (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_openHttpConnection_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='MobiComKitClientService']/method[@name='openHttpConnection' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openHttpConnection", "(Ljava/lang/String;)Ljava/net/HttpURLConnection;", "GetOpenHttpConnection_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Net.HttpURLConnection OpenHttpConnection (string p0)
		{
			if (id_openHttpConnection_Ljava_lang_String_ == IntPtr.Zero)
				id_openHttpConnection_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "openHttpConnection", "(Ljava/lang/String;)Ljava/net/HttpURLConnection;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Java.Net.HttpURLConnection __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_openHttpConnection_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "openHttpConnection", "(Ljava/lang/String;)Ljava/net/HttpURLConnection;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
