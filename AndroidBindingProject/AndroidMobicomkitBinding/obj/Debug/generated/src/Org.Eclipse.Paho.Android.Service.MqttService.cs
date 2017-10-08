using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']"
	[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttService", DoNotGenerateAcw=true)]
	public partial class MqttService : global::Android.App.Service, global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService.BackgroundDataPreferenceReceiver']"
		[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttService$BackgroundDataPreferenceReceiver", DoNotGenerateAcw=true)]
		public partial class BackgroundDataPreferenceReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttService$BackgroundDataPreferenceReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (BackgroundDataPreferenceReceiver); }
			}

			protected BackgroundDataPreferenceReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Eclipse.Paho.Android.Service.MqttService.BackgroundDataPreferenceReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService.BackgroundDataPreferenceReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService.BackgroundDataPreferenceReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService.NetworkConnectionIntentReceiver']"
		[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttService$NetworkConnectionIntentReceiver", DoNotGenerateAcw=true)]
		public partial class NetworkConnectionIntentReceiver : global::Android.Content.BroadcastReceiver {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttService$NetworkConnectionIntentReceiver", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (NetworkConnectionIntentReceiver); }
			}

			protected NetworkConnectionIntentReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Org.Eclipse.Paho.Android.Service.MqttService.NetworkConnectionIntentReceiver __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService.NetworkConnectionIntentReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService.NetworkConnectionIntentReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context p0, global::Android.Content.Intent p1)
			{
				if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
					id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V"), __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttService); }
		}

		protected MqttService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/constructor[@name='MqttService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MqttService)) {
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

		static Delegate cb_isOnline;
#pragma warning disable 0169
		static Delegate GetIsOnlineHandler ()
		{
			if (cb_isOnline == null)
				cb_isOnline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnline);
			return cb_isOnline;
		}

		static bool n_IsOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnline;
		}
#pragma warning restore 0169

		static IntPtr id_isOnline;
		public virtual unsafe bool IsOnline {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='isOnline' and count(parameter)=0]"
			[Register ("isOnline", "()Z", "GetIsOnlineHandler")]
			get {
				if (id_isOnline == IntPtr.Zero)
					id_isOnline = JNIEnv.GetMethodID (class_ref, "isOnline", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnline);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnline", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTraceEnabled;
#pragma warning disable 0169
		static Delegate GetIsTraceEnabledHandler ()
		{
			if (cb_isTraceEnabled == null)
				cb_isTraceEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTraceEnabled);
			return cb_isTraceEnabled;
		}

		static bool n_IsTraceEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TraceEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setTraceEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTraceEnabled_ZHandler ()
		{
			if (cb_setTraceEnabled_Z == null)
				cb_setTraceEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTraceEnabled_Z);
			return cb_setTraceEnabled_Z;
		}

		static void n_SetTraceEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TraceEnabled = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isTraceEnabled;
		static IntPtr id_setTraceEnabled_Z;
		public virtual unsafe bool TraceEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='isTraceEnabled' and count(parameter)=0]"
			[Register ("isTraceEnabled", "()Z", "GetIsTraceEnabledHandler")]
			get {
				if (id_isTraceEnabled == IntPtr.Zero)
					id_isTraceEnabled = JNIEnv.GetMethodID (class_ref, "isTraceEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTraceEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTraceEnabled", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='setTraceEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTraceEnabled", "(Z)V", "GetSetTraceEnabled_ZHandler")]
			set {
				if (id_setTraceEnabled_Z == IntPtr.Zero)
					id_setTraceEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTraceEnabled", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTraceEnabled_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTraceEnabled", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_close_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClose_Ljava_lang_String_Handler ()
		{
			if (cb_close_Ljava_lang_String_ == null)
				cb_close_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Close_Ljava_lang_String_);
			return cb_close_Ljava_lang_String_;
		}

		static void n_Close_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Close (p0);
		}
#pragma warning restore 0169

		static IntPtr id_close_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='close' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("close", "(Ljava/lang/String;)V", "GetClose_Ljava_lang_String_Handler")]
		public virtual unsafe void Close (string p0)
		{
			if (id_close_Ljava_lang_String_ == IntPtr.Zero)
				id_close_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "close", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_);
			return cb_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='connect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("connect", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/String;Ljava/lang/String;)V", "GetConnect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Connect (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p1, string p2, string p3)
		{
			if (id_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string p0, string p1, string p2)
		{
			if (id_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ == null)
				cb_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_);
			return cb_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
		}

		static void n_Disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='disconnect' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("disconnect", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V", "GetDisconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Disconnect (string p0, long p1, string p2, string p3)
		{
			if (id_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_String_JLjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/String;JLjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_;
#pragma warning disable 0169
		static Delegate GetGetClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Handler ()
		{
			if (cb_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ == null)
				cb_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_);
			return cb_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_;
		}

		static IntPtr n_GetClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetClient (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='getClient' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence']]"
		[Register ("getClient", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)Ljava/lang/String;", "GetGetClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Handler")]
		public virtual unsafe string GetClient (string p0, string p1, string p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p3)
		{
			if (id_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ == IntPtr.Zero)
				id_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ = JNIEnv.GetMethodID (class_ref, "getClient", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)Ljava/lang/String;");
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
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClient_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClient", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getPendingDeliveryTokens_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPendingDeliveryTokens_Ljava_lang_String_Handler ()
		{
			if (cb_getPendingDeliveryTokens_Ljava_lang_String_ == null)
				cb_getPendingDeliveryTokens_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPendingDeliveryTokens_Ljava_lang_String_);
			return cb_getPendingDeliveryTokens_Ljava_lang_String_;
		}

		static IntPtr n_GetPendingDeliveryTokens_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetPendingDeliveryTokens (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getPendingDeliveryTokens_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='getPendingDeliveryTokens' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPendingDeliveryTokens", "(Ljava/lang/String;)[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetGetPendingDeliveryTokens_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] GetPendingDeliveryTokens (string p0)
		{
			if (id_getPendingDeliveryTokens_Ljava_lang_String_ == IntPtr.Zero)
				id_getPendingDeliveryTokens_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getPendingDeliveryTokens", "(Ljava/lang/String;)[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDeliveryTokens_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
				else
					__ret = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingDeliveryTokens", "(Ljava/lang/String;)[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isConnected_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConnected_Ljava_lang_String_Handler ()
		{
			if (cb_isConnected_Ljava_lang_String_ == null)
				cb_isConnected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConnected_Ljava_lang_String_);
			return cb_isConnected_Ljava_lang_String_;
		}

		static bool n_IsConnected_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConnected (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='isConnected' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isConnected", "(Ljava/lang/String;)Z", "GetIsConnected_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsConnected (string p0)
		{
			if (id_isConnected_Ljava_lang_String_ == IntPtr.Zero)
				id_isConnected_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConnected", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_notifyClientsOffline;
#pragma warning disable 0169
		static Delegate GetNotifyClientsOfflineHandler ()
		{
			if (cb_notifyClientsOffline == null)
				cb_notifyClientsOffline = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyClientsOffline);
			return cb_notifyClientsOffline;
		}

		static void n_NotifyClientsOffline (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyClientsOffline ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyClientsOffline;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='notifyClientsOffline' and count(parameter)=0]"
		[Register ("notifyClientsOffline", "()V", "GetNotifyClientsOfflineHandler")]
		public virtual unsafe void NotifyClientsOffline ()
		{
			if (id_notifyClientsOffline == IntPtr.Zero)
				id_notifyClientsOffline = JNIEnv.GetMethodID (class_ref, "notifyClientsOffline", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyClientsOffline);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyClientsOffline", "()V"));
			} finally {
			}
		}

		static Delegate cb_onBind_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnBind_Landroid_content_Intent_Handler ()
		{
			if (cb_onBind_Landroid_content_Intent_ == null)
				cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnBind_Landroid_content_Intent_);
			return cb_onBind_Landroid_content_Intent_;
		}

		static IntPtr n_OnBind_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnBind (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onBind_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='onBind' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.OS.IBinder OnBind (global::Android.Content.Intent p0)
		{
			if (id_onBind_Landroid_content_Intent_ == IntPtr.Zero)
				id_onBind_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.OS.IBinder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onBind_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_ == null)
				cb_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_);
			return cb_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, bool p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3, p4, p5, p6));
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='publish' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='byte[]'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String']]"
		[Register ("publish", "(Ljava/lang/String;Ljava/lang/String;[BIZLjava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, string p1, byte[] p2, int p3, bool p4, string p5, string p6)
		{
			if (id_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Ljava/lang/String;[BIZLjava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (native_p6);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Ljava_lang_String_arrayBIZLjava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Ljava/lang/String;[BIZLjava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p5);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p2 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='publish' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("publish", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, string p1, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p2, string p3, string p4)
		{
			if (id_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/String;Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_setTraceCallbackId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTraceCallbackId_Ljava_lang_String_Handler ()
		{
			if (cb_setTraceCallbackId_Ljava_lang_String_ == null)
				cb_setTraceCallbackId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTraceCallbackId_Ljava_lang_String_);
			return cb_setTraceCallbackId_Ljava_lang_String_;
		}

		static void n_SetTraceCallbackId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTraceCallbackId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTraceCallbackId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='setTraceCallbackId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTraceCallbackId", "(Ljava/lang/String;)V", "GetSetTraceCallbackId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTraceCallbackId (string p0)
		{
			if (id_setTraceCallbackId_Ljava_lang_String_ == IntPtr.Zero)
				id_setTraceCallbackId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTraceCallbackId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTraceCallbackId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTraceCallbackId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == null)
				cb_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_);
			return cb_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("subscribe", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "GetSubscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Subscribe (string p0, string p1, int p2, string p3, string p4)
		{
			if (id_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_Ljava_lang_String_ILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_ == null)
				cb_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_);
			return cb_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_;
		}

		static void n_Subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p2 = (int[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (int));
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Subscribe (p0, p1, p2, p3, p4);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='int[]'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("subscribe", "(Ljava/lang/String;[Ljava/lang/String;[ILjava/lang/String;Ljava/lang/String;)V", "GetSubscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Subscribe (string p0, string[] p1, int[] p2, string p3, string p4)
		{
			if (id_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;[Ljava/lang/String;[ILjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_arrayLjava_lang_String_arrayILjava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;[Ljava/lang/String;[ILjava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
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
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TraceDebug (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_traceDebug_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='traceDebug' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("traceDebug", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTraceDebug_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void TraceDebug (string p0, string p1)
		{
			if (id_traceDebug_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_traceDebug_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "traceDebug", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceDebug_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "traceDebug", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.TraceError (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_traceError_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='traceError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("traceError", "(Ljava/lang/String;Ljava/lang/String;)V", "GetTraceError_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void TraceError (string p0, string p1)
		{
			if (id_traceError_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_traceError_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "traceError", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceError_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "traceError", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
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
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.TraceException (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='traceException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Exception']]"
		[Register ("traceException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V", "GetTraceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_Handler")]
		public virtual unsafe void TraceException (string p0, string p1, global::Java.Lang.Exception p2)
		{
			if (id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ == IntPtr.Zero)
				id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "traceException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_traceException_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Exception_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "traceException", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Exception;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='unsubscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUnsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Unsubscribe (string p0, string p1, string p2, string p3)
		{
			if (id_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
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

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttService __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Unsubscribe (p0, p1, p2, p3);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttService']/method[@name='unsubscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUnsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Unsubscribe (string p0, string[] p1, string p2, string p3)
		{
			if (id_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_arrayLjava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
