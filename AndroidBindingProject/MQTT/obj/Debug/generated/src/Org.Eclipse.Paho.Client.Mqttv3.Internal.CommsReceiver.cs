using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsReceiver", DoNotGenerateAcw=true)]
	public partial class CommsReceiver : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/CommsReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommsReceiver); }
		}

		protected CommsReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/constructor[@name='CommsReceiver' and count(parameter)=4 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientComms'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.internal.CommsTokenStore'] and parameter[4][@type='java.io.InputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/InputStream;)V", "")]
		public unsafe CommsReceiver (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms clientComms, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState, global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsTokenStore tokenStore, global::System.IO.Stream @in)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__in = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@in);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (clientComms);
				__args [1] = new JValue (clientState);
				__args [2] = new JValue (tokenStore);
				__args [3] = new JValue (native__in);
				if (((object) this).GetType () != typeof (CommsReceiver)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Lorg/eclipse/paho/client/mqttv3/internal/CommsTokenStore;Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientComms_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Lorg_eclipse_paho_client_mqttv3_internal_CommsTokenStore_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__in);
			}
		}

		static Delegate cb_isReceiving;
#pragma warning disable 0169
		static Delegate GetIsReceivingHandler ()
		{
			if (cb_isReceiving == null)
				cb_isReceiving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReceiving);
			return cb_isReceiving;
		}

		static bool n_IsReceiving (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsReceiving;
		}
#pragma warning restore 0169

		static IntPtr id_isReceiving;
		public virtual unsafe bool IsReceiving {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/method[@name='isReceiving' and count(parameter)=0]"
			[Register ("isReceiving", "()Z", "GetIsReceivingHandler")]
			get {
				if (id_isReceiving == IntPtr.Zero)
					id_isReceiving = JNIEnv.GetMethodID (class_ref, "isReceiving", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReceiving);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReceiving", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunning);
			return cb_isRunning;
		}

		static bool n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunning;
		}
#pragma warning restore 0169

		static IntPtr id_isRunning;
		public virtual unsafe bool IsRunning {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/method[@name='isRunning' and count(parameter)=0]"
			[Register ("isRunning", "()Z", "GetIsRunningHandler")]
			get {
				if (id_isRunning == IntPtr.Zero)
					id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRunning);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRunning", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

		static Delegate cb_start_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStart_Ljava_lang_String_Handler ()
		{
			if (cb_start_Ljava_lang_String_ == null)
				cb_start_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Start_Ljava_lang_String_);
			return cb_start_Ljava_lang_String_;
		}

		static void n_Start_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_threadName)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			__this.Start (threadName);
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("start", "(Ljava/lang/String;)V", "GetStart_Ljava_lang_String_Handler")]
		public virtual unsafe void Start (string threadName)
		{
			if (id_start_Ljava_lang_String_ == IntPtr.Zero)
				id_start_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "start", "(Ljava/lang/String;)V");
			IntPtr native_threadName = JNIEnv.NewString (threadName);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_threadName);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_threadName);
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsReceiver']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
