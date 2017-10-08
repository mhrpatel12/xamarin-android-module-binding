using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Android.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']"
	[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttAndroidClient", DoNotGenerateAcw=true)]
	public partial class MqttAndroidClient : global::Android.Content.BroadcastReceiver, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.Ack']"
		[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttAndroidClient$Ack", DoNotGenerateAcw=true)]
		public sealed partial class Ack : global::Java.Lang.Enum {


			static IntPtr AUTO_ACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.Ack']/field[@name='AUTO_ACK']"
			[Register ("AUTO_ACK")]
			public static global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack AutoAck {
				get {
					if (AUTO_ACK_jfieldId == IntPtr.Zero)
						AUTO_ACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_ACK", "Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_ACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MANUAL_ACK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.Ack']/field[@name='MANUAL_ACK']"
			[Register ("MANUAL_ACK")]
			public static global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack ManualAck {
				get {
					if (MANUAL_ACK_jfieldId == IntPtr.Zero)
						MANUAL_ACK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANUAL_ACK", "Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANUAL_ACK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttAndroidClient$Ack", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Ack); }
			}

			internal Ack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.Ack']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;", "")]
			public static unsafe global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack __ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.Ack']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;", "")]
			public static unsafe global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;");
				try {
					return (global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.MyServiceConnection']"
		[global::Android.Runtime.Register ("org/eclipse/paho/android/service/MqttAndroidClient$MyServiceConnection", DoNotGenerateAcw=true)]
		public sealed partial class MyServiceConnection : global::Java.Lang.Object, global::Android.Content.IServiceConnection {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttAndroidClient$MyServiceConnection", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MyServiceConnection); }
			}

			internal MyServiceConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.MyServiceConnection']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
			[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "")]
			public unsafe void OnServiceConnected (global::Android.Content.ComponentName p0, global::Android.OS.IBinder p1)
			{
				if (id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == IntPtr.Zero)
					id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNIEnv.GetMethodID (class_ref, "onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_, __args);
				} finally {
				}
			}

			static IntPtr id_onServiceDisconnected_Landroid_content_ComponentName_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient.MyServiceConnection']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
			[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "")]
			public unsafe void OnServiceDisconnected (global::Android.Content.ComponentName p0)
			{
				if (id_onServiceDisconnected_Landroid_content_ComponentName_ == IntPtr.Zero)
					id_onServiceDisconnected_Landroid_content_ComponentName_ = JNIEnv.GetMethodID (class_ref, "onServiceDisconnected", "(Landroid/content/ComponentName;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onServiceDisconnected_Landroid_content_ComponentName_, __args);
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/android/service/MqttAndroidClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttAndroidClient); }
		}

		protected MqttAndroidClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/constructor[@name='MqttAndroidClient' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[5][@type='org.eclipse.paho.android.service.MqttAndroidClient.Ack']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", "")]
		public unsafe MqttAndroidClient (global::Android.Content.Context p0, string p1, string p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p3, global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (MqttAndroidClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/constructor[@name='MqttAndroidClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", "")]
		public unsafe MqttAndroidClient (global::Android.Content.Context p0, string p1, string p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (MqttAndroidClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/constructor[@name='MqttAndroidClient' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='org.eclipse.paho.android.service.MqttAndroidClient.Ack']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", "")]
		public unsafe MqttAndroidClient (global::Android.Content.Context p0, string p1, string p2, global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient.Ack p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (MqttAndroidClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/android/service/MqttAndroidClient$Ack;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_android_service_MqttAndroidClient_Ack_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/constructor[@name='MqttAndroidClient' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MqttAndroidClient (global::Android.Content.Context p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MqttAndroidClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getClientId;
#pragma warning disable 0169
		static Delegate GetGetClientIdHandler ()
		{
			if (cb_getClientId == null)
				cb_getClientId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientId);
			return cb_getClientId;
		}

		static IntPtr n_GetClientId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='getClientId' and count(parameter)=0]"
			[Register ("getClientId", "()Ljava/lang/String;", "GetGetClientIdHandler")]
			get {
				if (id_getClientId == IntPtr.Zero)
					id_getClientId = JNIEnv.GetMethodID (class_ref, "getClientId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getServerURI;
#pragma warning disable 0169
		static Delegate GetGetServerURIHandler ()
		{
			if (cb_getServerURI == null)
				cb_getServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerURI);
			return cb_getServerURI;
		}

		static IntPtr n_GetServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		static IntPtr id_getServerURI;
		public virtual unsafe string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='getServerURI' and count(parameter)=0]"
			[Register ("getServerURI", "()Ljava/lang/String;", "GetGetServerURIHandler")]
			get {
				if (id_getServerURI == IntPtr.Zero)
					id_getServerURI = JNIEnv.GetMethodID (class_ref, "getServerURI", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerURI), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerURI", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_acknowledgeMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAcknowledgeMessage_Ljava_lang_String_Handler ()
		{
			if (cb_acknowledgeMessage_Ljava_lang_String_ == null)
				cb_acknowledgeMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AcknowledgeMessage_Ljava_lang_String_);
			return cb_acknowledgeMessage_Ljava_lang_String_;
		}

		static bool n_AcknowledgeMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AcknowledgeMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_acknowledgeMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='acknowledgeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("acknowledgeMessage", "(Ljava/lang/String;)Z", "GetAcknowledgeMessage_Ljava_lang_String_Handler")]
		public virtual unsafe bool AcknowledgeMessage (string p0)
		{
			if (id_acknowledgeMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_acknowledgeMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "acknowledgeMessage", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_acknowledgeMessage_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acknowledgeMessage", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_connect;
#pragma warning disable 0169
		static Delegate GetConnectHandler ()
		{
			if (cb_connect == null)
				cb_connect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Connect);
			return cb_connect;
		}

		static IntPtr n_Connect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='connect' and count(parameter)=0]"
		[Register ("connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnectHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect ()
		{
			if (id_connect == IntPtr.Zero)
				id_connect = JNIEnv.GetMethodID (class_ref, "connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1)
		{
			if (id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Disconnect);
			return cb_disconnect;
		}

		static IntPtr n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect ());
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnectHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect ()
		{
			if (id_disconnect == IntPtr.Zero)
				id_disconnect = JNIEnv.GetMethodID (class_ref, "disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "()Lorg/eclipse/paho/client/mqttv3/IMqttToken;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (global::Java.Lang.Object p0, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p1)
		{
			if (id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_disconnect_J;
#pragma warning disable 0169
		static Delegate GetDisconnect_JHandler ()
		{
			if (cb_disconnect_J == null)
				cb_disconnect_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Disconnect_J);
			return cb_disconnect_J;
		}

		static IntPtr n_Disconnect_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect (p0));
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0)
		{
			if (id_disconnect_J == IntPtr.Zero)
				id_disconnect_J = JNIEnv.GetMethodID (class_ref, "disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly;
#pragma warning disable 0169
		static Delegate GetDisconnectForciblyHandler ()
		{
			if (cb_disconnectForcibly == null)
				cb_disconnectForcibly = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisconnectForcibly);
			return cb_disconnectForcibly;
		}

		static void n_DisconnectForcibly (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnectForcibly' and count(parameter)=0]"
		[Register ("disconnectForcibly", "()V", "GetDisconnectForciblyHandler")]
		public virtual unsafe void DisconnectForcibly ()
		{
			if (id_disconnectForcibly == IntPtr.Zero)
				id_disconnectForcibly = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectForcibly", "()V"));
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_J;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JHandler ()
		{
			if (cb_disconnectForcibly_J == null)
				cb_disconnectForcibly_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DisconnectForcibly_J);
			return cb_disconnectForcibly_J;
		}

		static void n_DisconnectForcibly_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (p0);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnectForcibly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnectForcibly", "(J)V", "GetDisconnectForcibly_JHandler")]
		public virtual unsafe void DisconnectForcibly (long p0)
		{
			if (id_disconnectForcibly_J == IntPtr.Zero)
				id_disconnectForcibly_J = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectForcibly", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_JJ;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JJHandler ()
		{
			if (cb_disconnectForcibly_JJ == null)
				cb_disconnectForcibly_JJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long>) n_DisconnectForcibly_JJ);
			return cb_disconnectForcibly_JJ;
		}

		static void n_DisconnectForcibly_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("disconnectForcibly", "(JJ)V", "GetDisconnectForcibly_JJHandler")]
		public virtual unsafe void DisconnectForcibly (long p0, long p1)
		{
			if (id_disconnectForcibly_JJ == IntPtr.Zero)
				id_disconnectForcibly_JJ = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectForcibly", "(JJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getPendingDeliveryTokens;
#pragma warning disable 0169
		static Delegate GetGetPendingDeliveryTokensHandler ()
		{
			if (cb_getPendingDeliveryTokens == null)
				cb_getPendingDeliveryTokens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingDeliveryTokens);
			return cb_getPendingDeliveryTokens;
		}

		static IntPtr n_GetPendingDeliveryTokens (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		static IntPtr id_getPendingDeliveryTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
		[Register ("getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetGetPendingDeliveryTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[] GetPendingDeliveryTokens ()
		{
			if (id_getPendingDeliveryTokens == IntPtr.Zero)
				id_getPendingDeliveryTokens = JNIEnv.GetMethodID (class_ref, "getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDeliveryTokens), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
				else
					return (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken));
			} finally {
			}
		}

		static Delegate cb_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_Handler ()
		{
			if (cb_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_ == null)
				cb_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_);
			return cb_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_;
		}

		static IntPtr n_GetSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSSLSocketFactory (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='getSSLSocketFactory' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='java.lang.String']]"
		[Register ("getSSLSocketFactory", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;", "GetGetSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_Handler")]
		public virtual unsafe global::Javax.Net.Ssl.SSLSocketFactory GetSSLSocketFactory (global::System.IO.Stream p0, string p1)
		{
			if (id_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_ == IntPtr.Zero)
				id_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSSLSocketFactory", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Javax.Net.Ssl.SSLSocketFactory __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSSLSocketFactory_Ljava_io_InputStream_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Javax.Net.Ssl.SSLSocketFactory> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSSLSocketFactory", "(Ljava/io/InputStream;Ljava/lang/String;)Ljavax/net/ssl/SSLSocketFactory;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

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
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnReceive (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
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

		static Delegate cb_publish_Ljava_lang_String_arrayBIZ;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZHandler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZ == null)
				cb_publish_Ljava_lang_String_arrayBIZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZ);
			return cb_publish_Ljava_lang_String_arrayBIZ;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3)
		{
			if (id_publish_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, bool p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Lang.Object p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p5 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3, p4, p5));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='publish' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, byte[] p1, int p2, bool p3, global::Java.Lang.Object p4, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p5)
		{
			if (id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='publish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1 = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string p0, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerResources_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetRegisterResources_Landroid_content_Context_Handler ()
		{
			if (cb_registerResources_Landroid_content_Context_ == null)
				cb_registerResources_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterResources_Landroid_content_Context_);
			return cb_registerResources_Landroid_content_Context_;
		}

		static void n_RegisterResources_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterResources (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerResources_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='registerResources' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("registerResources", "(Landroid/content/Context;)V", "GetRegisterResources_Landroid_content_Context_Handler")]
		public virtual unsafe void RegisterResources (global::Android.Content.Context p0)
		{
			if (id_registerResources_Landroid_content_Context_ == IntPtr.Zero)
				id_registerResources_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "registerResources", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerResources_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerResources", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler ()
		{
			if (cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == null)
				cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_);
			return cb_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		}

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback p0)
		{
			if (id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == IntPtr.Zero)
				id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_;
#pragma warning disable 0169
		static Delegate GetSetTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_Handler ()
		{
			if (cb_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_ == null)
				cb_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_);
			return cb_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_;
		}

		static void n_SetTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler p0 = (global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTraceCallback (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='setTraceCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.android.service.MqttTraceHandler']]"
		[Register ("setTraceCallback", "(Lorg/eclipse/paho/android/service/MqttTraceHandler;)V", "GetSetTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_Handler")]
		public virtual unsafe void SetTraceCallback (global::Org.Eclipse.Paho.Android.Service.IMqttTraceHandler p0)
		{
			if (id_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_ == IntPtr.Zero)
				id_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_ = JNIEnv.GetMethodID (class_ref, "setTraceCallback", "(Lorg/eclipse/paho/android/service/MqttTraceHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTraceCallback_Lorg_eclipse_paho_android_service_MqttTraceHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTraceCallback", "(Lorg/eclipse/paho/android/service/MqttTraceHandler;)V"), __args);
			} finally {
			}
		}

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
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTraceEnabled (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTraceEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='setTraceEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTraceEnabled", "(Z)V", "GetSetTraceEnabled_ZHandler")]
		public virtual unsafe void SetTraceEnabled (bool p0)
		{
			if (id_setTraceEnabled_Z == IntPtr.Zero)
				id_setTraceEnabled_Z = JNIEnv.GetMethodID (class_ref, "setTraceEnabled", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTraceEnabled_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTraceEnabled", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_IHandler ()
		{
			if (cb_subscribe_Ljava_lang_String_I == null)
				cb_subscribe_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Subscribe_Ljava_lang_String_I);
			return cb_subscribe_Ljava_lang_String_I;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1)
		{
			if (id_subscribe_Ljava_lang_String_I == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string p0, int p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayI;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIHandler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayI == null)
				cb_subscribe_arrayLjava_lang_String_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayI);
			return cb_subscribe_arrayLjava_lang_String_arrayI;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2, p3));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] p0, int[] p1, global::Java.Lang.Object p2, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p3)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_unregisterResources;
#pragma warning disable 0169
		static Delegate GetUnregisterResourcesHandler ()
		{
			if (cb_unregisterResources == null)
				cb_unregisterResources = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterResources);
			return cb_unregisterResources;
		}

		static void n_UnregisterResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterResources ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterResources;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='unregisterResources' and count(parameter)=0]"
		[Register ("unregisterResources", "()V", "GetUnregisterResourcesHandler")]
		public virtual unsafe void UnregisterResources ()
		{
			if (id_unregisterResources == IntPtr.Zero)
				id_unregisterResources = JNIEnv.GetMethodID (class_ref, "unregisterResources", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterResources);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterResources", "()V"));
			} finally {
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_ == null)
				cb_unsubscribe_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_);
			return cb_unsubscribe_Ljava_lang_String_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0)
		{
			if (id_unsubscribe_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_ == null)
				cb_unsubscribe_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_);
			return cb_unsubscribe_arrayLjava_lang_String_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0)
		{
			if (id_unsubscribe_arrayLjava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Android.Service.MqttAndroidClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2 = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0, p1, p2));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.android.service']/class[@name='MqttAndroidClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] p0, global::Java.Lang.Object p1, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener p2)
		{
			if (id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
