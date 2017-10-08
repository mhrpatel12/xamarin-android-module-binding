using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Android.Service {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.eclipse.paho.android.service']/interface[@name='MqttTraceHandler']"
	[Register ("org/eclipse/paho/android/service/MqttTraceHandler", "", "Org.Eclipse.Paho.Android.Service.IMqttTraceHandlerInvoker")]
	public partial interface IMqttTraceHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/interface[@name='MqttTraceHandler']/method[@name='traceDebug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("traceDebug", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTraceDebug_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Android.Service.IMqttTraceHandlerInvoker, AndroidMobicomkitBinding")]
		void TraceDebug (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/interface[@name='MqttTraceHandler']/method[@name='traceError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("traceError", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTraceError_Ljava_lang_String_Ljava_lang_String_Handler:Org.Eclipse.Paho.Android.Service.IMqttTraceHandlerInvoker, AndroidMobicomkitBinding")]
		void TraceError (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/interface[@name='MqttTraceHandler']/method[@name='traceException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("traceException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "GetTraceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler:Org.Eclipse.Paho.Android.Service.IMqttTraceHandlerInvoker, AndroidMobicomkitBinding")]
		void TraceException (string p0, string p1, global::Java.Lang.Exception p2);

	}

	[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttTraceHandler", DoNotGenerateAcw=true)]
	internal class IMqttTraceHandlerInvoker : global::Java.Lang.Object, IMqttTraceHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttTraceHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMqttTraceHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMqttTraceHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMqttTraceHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.eclipse.paho.android.service.MqttTraceHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMqttTraceHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_traceDebug_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTraceDebug_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_traceDebug_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_traceDebug_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TraceDebug_Ljava_lang_String_Ljava_lang_String_);
			return cb_traceDebug_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TraceDebug_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TraceDebug (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_traceDebug_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void TraceDebug (string p0, string p1)
		{
			if (id_traceDebug_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_traceDebug_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "traceDebug", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceDebug_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_traceError_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTraceError_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_traceError_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_traceError_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_TraceError_Ljava_lang_String_Ljava_lang_String_);
			return cb_traceError_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_TraceError_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TraceError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_traceError_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void TraceError (string p0, string p1)
		{
			if (id_traceError_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_traceError_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "traceError", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceError_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetTraceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler ()
		{
			if (cb_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == null)
				cb_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_TraceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_);
			return cb_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		}

		static void n_TraceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TraceException (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		public unsafe void TraceException (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "traceException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
