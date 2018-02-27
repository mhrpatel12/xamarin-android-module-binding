using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/LoggerFactory", DoNotGenerateAcw=true)]
	public partial class LoggerFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/field[@name='MQTT_CLIENT_MSG_CAT']"
		[Register ("MQTT_CLIENT_MSG_CAT")]
		public const string MqttClientMsgCat = (string) "org.eclipse.paho.client.mqttv3.internal.nls.logcat";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/logging/LoggerFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LoggerFactory); }
		}

		protected LoggerFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/constructor[@name='LoggerFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LoggerFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LoggerFactory)) {
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

		static IntPtr id_getLogger_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='getLogger' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLogger", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/logging/Logger;", "")]
		public static unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger GetLogger (string messageCatalogName, string loggerID)
		{
			if (id_getLogger_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getLogger_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/logging/Logger;");
			IntPtr native_messageCatalogName = JNIEnv.NewString (messageCatalogName);
			IntPtr native_loggerID = JNIEnv.NewString (loggerID);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_messageCatalogName);
				__args [1] = new JValue (native_loggerID);
				global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.ILogger> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLogger_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_messageCatalogName);
				JNIEnv.DeleteLocalRef (native_loggerID);
			}
		}

		static IntPtr id_getLoggingProperty_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='getLoggingProperty' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLoggingProperty", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLoggingProperty (string name)
		{
			if (id_getLoggingProperty_Ljava_lang_String_ == IntPtr.Zero)
				id_getLoggingProperty_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLoggingProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLoggingProperty_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_setLogger_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='LoggerFactory']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLogger", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetLogger (string loggerClassName)
		{
			if (id_setLogger_Ljava_lang_String_ == IntPtr.Zero)
				id_setLogger_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Ljava/lang/String;)V");
			IntPtr native_loggerClassName = JNIEnv.NewString (loggerClassName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_loggerClassName);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_loggerClassName);
			}
		}

	}
}
