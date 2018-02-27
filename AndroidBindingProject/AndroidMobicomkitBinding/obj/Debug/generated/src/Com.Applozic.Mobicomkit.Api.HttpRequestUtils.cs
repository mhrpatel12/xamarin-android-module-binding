using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/HttpRequestUtils", DoNotGenerateAcw=true)]
	public partial class HttpRequestUtils : global::Java.Lang.Object {


		static IntPtr ACCESS_TOKEN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		public static string AccessToken {
			get {
				if (ACCESS_TOKEN_jfieldId == IntPtr.Zero)
					ACCESS_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCESS_TOKEN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACCESS_TOKEN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ACCESS_TOKEN_jfieldId == IntPtr.Zero)
					ACCESS_TOKEN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACCESS_TOKEN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ACCESS_TOKEN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPLICATION_KEY_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='APPLICATION_KEY_HEADER']"
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

		static IntPtr APP_MODULE_NAME_KEY_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='APP_MODULE_NAME_KEY_HEADER']"
		[Register ("APP_MODULE_NAME_KEY_HEADER")]
		public static string AppModuleNameKeyHeader {
			get {
				if (APP_MODULE_NAME_KEY_HEADER_jfieldId == IntPtr.Zero)
					APP_MODULE_NAME_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MODULE_NAME_KEY_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APP_MODULE_NAME_KEY_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APP_MODULE_NAME_KEY_HEADER_jfieldId == IntPtr.Zero)
					APP_MODULE_NAME_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APP_MODULE_NAME_KEY_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APP_MODULE_NAME_KEY_HEADER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DEVICE_KEY_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='DEVICE_KEY_HEADER']"
		[Register ("DEVICE_KEY_HEADER")]
		public static string DeviceKeyHeader {
			get {
				if (DEVICE_KEY_HEADER_jfieldId == IntPtr.Zero)
					DEVICE_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_KEY_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEVICE_KEY_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DEVICE_KEY_HEADER_jfieldId == IntPtr.Zero)
					DEVICE_KEY_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEVICE_KEY_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DEVICE_KEY_HEADER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr USERID_HEADER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='USERID_HEADER']"
		[Register ("USERID_HEADER")]
		public static string UseridHeader {
			get {
				if (USERID_HEADER_jfieldId == IntPtr.Zero)
					USERID_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERID_HEADER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USERID_HEADER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USERID_HEADER_jfieldId == IntPtr.Zero)
					USERID_HEADER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERID_HEADER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, USERID_HEADER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr USERID_HEADER_VALUE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/field[@name='USERID_HEADER_VALUE']"
		[Register ("USERID_HEADER_VALUE")]
		public static string UseridHeaderValue {
			get {
				if (USERID_HEADER_VALUE_jfieldId == IntPtr.Zero)
					USERID_HEADER_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERID_HEADER_VALUE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, USERID_HEADER_VALUE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (USERID_HEADER_VALUE_jfieldId == IntPtr.Zero)
					USERID_HEADER_VALUE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "USERID_HEADER_VALUE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, USERID_HEADER_VALUE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/HttpRequestUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpRequestUtils); }
		}

		protected HttpRequestUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/constructor[@name='HttpRequestUtils' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HttpRequestUtils (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (HttpRequestUtils)) {
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
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Credentials);
		}
#pragma warning restore 0169

		static IntPtr id_getCredentials;
		public virtual unsafe global::Java.Net.PasswordAuthentication Credentials {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='getCredentials' and count(parameter)=0]"
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

		static Delegate cb_addGlobalHeaders_Ljava_net_HttpURLConnection_;
#pragma warning disable 0169
		static Delegate GetAddGlobalHeaders_Ljava_net_HttpURLConnection_Handler ()
		{
			if (cb_addGlobalHeaders_Ljava_net_HttpURLConnection_ == null)
				cb_addGlobalHeaders_Ljava_net_HttpURLConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddGlobalHeaders_Ljava_net_HttpURLConnection_);
			return cb_addGlobalHeaders_Ljava_net_HttpURLConnection_;
		}

		static void n_AddGlobalHeaders_Ljava_net_HttpURLConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.HttpURLConnection p0 = global::Java.Lang.Object.GetObject<global::Java.Net.HttpURLConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddGlobalHeaders (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addGlobalHeaders_Ljava_net_HttpURLConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='addGlobalHeaders' and count(parameter)=1 and parameter[1][@type='java.net.HttpURLConnection']]"
		[Register ("addGlobalHeaders", "(Ljava/net/HttpURLConnection;)V", "GetAddGlobalHeaders_Ljava_net_HttpURLConnection_Handler")]
		public virtual unsafe void AddGlobalHeaders (global::Java.Net.HttpURLConnection p0)
		{
			if (id_addGlobalHeaders_Ljava_net_HttpURLConnection_ == IntPtr.Zero)
				id_addGlobalHeaders_Ljava_net_HttpURLConnection_ = JNIEnv.GetMethodID (class_ref, "addGlobalHeaders", "(Ljava/net/HttpURLConnection;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addGlobalHeaders_Ljava_net_HttpURLConnection_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addGlobalHeaders", "(Ljava/net/HttpURLConnection;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetResponse (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='getResponse' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetResponse (string p0, string p1, string p2)
		{
			if (id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_GetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetResponse (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='getResponse' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;", "GetGetResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe string GetResponse (string p0, string p1, string p2, bool p3)
		{
			if (id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PostData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PostData (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='postData' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("postData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPostData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PostData (string p0, string p1, string p2, string p3)
		{
			if (id_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
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
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postData_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postData", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_postJsonToServer_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPostJsonToServer_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_postJsonToServer_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_postJsonToServer_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PostJsonToServer_Ljava_lang_String_Ljava_lang_String_);
			return cb_postJsonToServer_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_PostJsonToServer_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.HttpRequestUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.PostJsonToServer (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_postJsonToServer_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api']/class[@name='HttpRequestUtils']/method[@name='postJsonToServer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("postJsonToServer", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetPostJsonToServer_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string PostJsonToServer (string p0, string p1)
		{
			if (id_postJsonToServer_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_postJsonToServer_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "postJsonToServer", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_postJsonToServer_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "postJsonToServer", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
