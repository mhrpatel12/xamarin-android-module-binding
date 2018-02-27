using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Logging {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/logging/SimpleLogFormatter", DoNotGenerateAcw=true)]
	public partial class SimpleLogFormatter : global::Java.Util.Logging.Formatter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/logging/SimpleLogFormatter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SimpleLogFormatter); }
		}

		protected SimpleLogFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/constructor[@name='SimpleLogFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SimpleLogFormatter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SimpleLogFormatter)) {
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

		static Delegate cb_format_Ljava_util_logging_LogRecord_;
#pragma warning disable 0169
		static Delegate GetFormat_Ljava_util_logging_LogRecord_Handler ()
		{
			if (cb_format_Ljava_util_logging_LogRecord_ == null)
				cb_format_Ljava_util_logging_LogRecord_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_util_logging_LogRecord_);
			return cb_format_Ljava_util_logging_LogRecord_;
		}

		static IntPtr n_Format_Ljava_util_logging_LogRecord_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Logging.SimpleLogFormatter __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Logging.SimpleLogFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Logging.LogRecord r = global::Java.Lang.Object.GetObject<global::Java.Util.Logging.LogRecord> (native_r, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Format (r));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_format_Ljava_util_logging_LogRecord_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/method[@name='format' and count(parameter)=1 and parameter[1][@type='java.util.logging.LogRecord']]"
		[Register ("format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;", "GetFormat_Ljava_util_logging_LogRecord_Handler")]
		public override unsafe string Format (global::Java.Util.Logging.LogRecord r)
		{
			if (id_format_Ljava_util_logging_LogRecord_ == IntPtr.Zero)
				id_format_Ljava_util_logging_LogRecord_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (r);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_util_logging_LogRecord_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/util/logging/LogRecord;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_left_Ljava_lang_String_IC;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.logging']/class[@name='SimpleLogFormatter']/method[@name='left' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='char']]"
		[Register ("left", "(Ljava/lang/String;IC)Ljava/lang/String;", "")]
		public static unsafe string Left (string s, int width, char fillChar)
		{
			if (id_left_Ljava_lang_String_IC == IntPtr.Zero)
				id_left_Ljava_lang_String_IC = JNIEnv.GetStaticMethodID (class_ref, "left", "(Ljava/lang/String;IC)Ljava/lang/String;");
			IntPtr native_s = JNIEnv.NewString (s);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_s);
				__args [1] = new JValue (width);
				__args [2] = new JValue (fillChar);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_left_Ljava_lang_String_IC, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_s);
			}
		}

	}
}
