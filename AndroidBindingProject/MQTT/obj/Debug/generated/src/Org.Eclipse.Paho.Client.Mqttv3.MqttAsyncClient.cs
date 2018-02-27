using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttAsyncClient", DoNotGenerateAcw=true)]
	public partial class MqttAsyncClient : global::Java.Lang.Object, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient {


		static IntPtr comms_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/field[@name='comms']"
		[Register ("comms")]
		protected global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms Comms {
			get {
				if (comms_jfieldId == IntPtr.Zero)
					comms_jfieldId = JNIEnv.GetFieldID (class_ref, "comms", "Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, comms_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (comms_jfieldId == IntPtr.Zero)
					comms_jfieldId = JNIEnv.GetFieldID (class_ref, "comms", "Lorg/eclipse/paho/client/mqttv3/internal/ClientComms;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, comms_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttAsyncClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttAsyncClient); }
		}

		protected MqttAsyncClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_serverURI);
				__args [1] = new JValue (native_clientId);
				if (((object) this).GetType () != typeof (MqttAsyncClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_serverURI);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (persistence);
				if (((object) this).GetType () != typeof (MqttAsyncClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/constructor[@name='MqttAsyncClient' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.MqttPingSender']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", "")]
		public unsafe MqttAsyncClient (string serverURI, string clientId, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_serverURI = JNIEnv.NewString (serverURI);
			IntPtr native_clientId = JNIEnv.NewString (clientId);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_serverURI);
				__args [1] = new JValue (native_clientId);
				__args [2] = new JValue (persistence);
				__args [3] = new JValue (pingSender);
				if (((object) this).GetType () != typeof (MqttAsyncClient)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_serverURI);
				JNIEnv.DeleteLocalRef (native_clientId);
			}
		}

		static Delegate cb_getBufferedMessageCount;
#pragma warning disable 0169
		static Delegate GetGetBufferedMessageCountHandler ()
		{
			if (cb_getBufferedMessageCount == null)
				cb_getBufferedMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBufferedMessageCount);
			return cb_getBufferedMessageCount;
		}

		static int n_GetBufferedMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedMessageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferedMessageCount;
		public virtual unsafe int BufferedMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getBufferedMessageCount' and count(parameter)=0]"
			[Register ("getBufferedMessageCount", "()I", "GetGetBufferedMessageCountHandler")]
			get {
				if (id_getBufferedMessageCount == IntPtr.Zero)
					id_getBufferedMessageCount = JNIEnv.GetMethodID (class_ref, "getBufferedMessageCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedMessageCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferedMessageCount", "()I"));
				} finally {
				}
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientId);
		}
#pragma warning restore 0169

		static IntPtr id_getClientId;
		public virtual unsafe string ClientId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getClientId' and count(parameter)=0]"
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

		static Delegate cb_getCurrentServerURI;
#pragma warning disable 0169
		static Delegate GetGetCurrentServerURIHandler ()
		{
			if (cb_getCurrentServerURI == null)
				cb_getCurrentServerURI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentServerURI);
			return cb_getCurrentServerURI;
		}

		static IntPtr n_GetCurrentServerURI (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CurrentServerURI);
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentServerURI;
		public virtual unsafe string CurrentServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getCurrentServerURI' and count(parameter)=0]"
			[Register ("getCurrentServerURI", "()Ljava/lang/String;", "GetGetCurrentServerURIHandler")]
			get {
				if (id_getCurrentServerURI == IntPtr.Zero)
					id_getCurrentServerURI = JNIEnv.GetMethodID (class_ref, "getCurrentServerURI", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentServerURI), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentServerURI", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDebug;
#pragma warning disable 0169
		static Delegate GetGetDebugHandler ()
		{
			if (cb_getDebug == null)
				cb_getDebug = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDebug);
			return cb_getDebug;
		}

		static IntPtr n_GetDebug (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		static IntPtr id_getDebug;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getDebug' and count(parameter)=0]"
			[Register ("getDebug", "()Lorg/eclipse/paho/client/mqttv3/util/Debug;", "GetGetDebugHandler")]
			get {
				if (id_getDebug == IntPtr.Zero)
					id_getDebug = JNIEnv.GetMethodID (class_ref, "getDebug", "()Lorg/eclipse/paho/client/mqttv3/util/Debug;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDebug), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Util.Debug> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDebug", "()Lorg/eclipse/paho/client/mqttv3/util/Debug;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='isConnected' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerURI);
		}
#pragma warning restore 0169

		static IntPtr id_getServerURI;
		public virtual unsafe string ServerURI {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getServerURI' and count(parameter)=0]"
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

		static IntPtr id_Character_isHighSurrogate_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='Character_isHighSurrogate' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("Character_isHighSurrogate", "(C)Z", "")]
		protected static unsafe bool Character_isHighSurrogate (char ch)
		{
			if (id_Character_isHighSurrogate_C == IntPtr.Zero)
				id_Character_isHighSurrogate_C = JNIEnv.GetStaticMethodID (class_ref, "Character_isHighSurrogate", "(C)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ch);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_Character_isHighSurrogate_C, __args);
			} finally {
			}
		}

		static Delegate cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetCheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_CheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckPing (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='checkPing' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("checkPing", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetCheckPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken CheckPing (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "checkPing", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (userContext);
				__args [1] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkPing_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkPing", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='close' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Connect ());
		}
#pragma warning restore 0169

		static IntPtr id_connect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=0]"
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

		static IntPtr n_Connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (userContext);
				__args [1] = new JValue (@callback);

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

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);

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

		static IntPtr n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Connect (options, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='connect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (options);
				__args [1] = new JValue (userContext);
				__args [2] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
#pragma warning disable 0169
		static Delegate GetCreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler ()
		{
			if (cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == null)
				cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_);
			return cb_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		}

		static IntPtr n_CreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_address, IntPtr native_options)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string address = JNIEnv.GetString (native_address, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.CreateNetworkModules (address, options));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='createNetworkModules' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions']]"
		[Register ("createNetworkModules", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;", "GetCreateNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] CreateNetworkModules (string address, global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options)
		{
			if (id_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ == IntPtr.Zero)
				id_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_ = JNIEnv.GetMethodID (class_ref, "createNetworkModules", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;");
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_address);
				__args [1] = new JValue (options);

				global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createNetworkModules_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
				else
					__ret = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createNetworkModules", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;)[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		static Delegate cb_deleteBufferedMessage_I;
#pragma warning disable 0169
		static Delegate GetDeleteBufferedMessage_IHandler ()
		{
			if (cb_deleteBufferedMessage_I == null)
				cb_deleteBufferedMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeleteBufferedMessage_I);
			return cb_deleteBufferedMessage_I;
		}

		static void n_DeleteBufferedMessage_I (IntPtr jnienv, IntPtr native__this, int bufferIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteBufferedMessage (bufferIndex);
		}
#pragma warning restore 0169

		static IntPtr id_deleteBufferedMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='deleteBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deleteBufferedMessage", "(I)V", "GetDeleteBufferedMessage_IHandler")]
		public virtual unsafe void DeleteBufferedMessage (int bufferIndex)
		{
			if (id_deleteBufferedMessage_I == IntPtr.Zero)
				id_deleteBufferedMessage_I = JNIEnv.GetMethodID (class_ref, "deleteBufferedMessage", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferIndex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteBufferedMessage_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteBufferedMessage", "(I)V"), __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect ());
		}
#pragma warning restore 0169

		static IntPtr id_disconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=0]"
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

		static IntPtr n_Disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (userContext);
				__args [1] = new JValue (@callback);

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

		static IntPtr n_Disconnect_J (IntPtr jnienv, IntPtr native__this, long quiesceTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Disconnect (quiesceTimeout));
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long quiesceTimeout)
		{
			if (id_disconnect_J == IntPtr.Zero)
				id_disconnect_J = JNIEnv.GetMethodID (class_ref, "disconnect", "(J)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (quiesceTimeout);

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

		static IntPtr n_Disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Disconnect (quiesceTimeout, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetDisconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Disconnect (long quiesceTimeout, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_disconnect_JLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(JLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (quiesceTimeout);
				__args [1] = new JValue (userContext);
				__args [2] = new JValue (@callback);

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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly ();
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=0]"
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

		static void n_DisconnectForcibly_J (IntPtr jnienv, IntPtr native__this, long disconnectTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (disconnectTimeout);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("disconnectForcibly", "(J)V", "GetDisconnectForcibly_JHandler")]
		public virtual unsafe void DisconnectForcibly (long disconnectTimeout)
		{
			if (id_disconnectForcibly_J == IntPtr.Zero)
				id_disconnectForcibly_J = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disconnectTimeout);

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

		static void n_DisconnectForcibly_JJ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, long disconnectTimeout)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("disconnectForcibly", "(JJ)V", "GetDisconnectForcibly_JJHandler")]
		public virtual unsafe void DisconnectForcibly (long quiesceTimeout, long disconnectTimeout)
		{
			if (id_disconnectForcibly_JJ == IntPtr.Zero)
				id_disconnectForcibly_JJ = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(JJ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (quiesceTimeout);
				__args [1] = new JValue (disconnectTimeout);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_JJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectForcibly", "(JJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnectForcibly_JJZ;
#pragma warning disable 0169
		static Delegate GetDisconnectForcibly_JJZHandler ()
		{
			if (cb_disconnectForcibly_JJZ == null)
				cb_disconnectForcibly_JJZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, long, bool>) n_DisconnectForcibly_JJZ);
			return cb_disconnectForcibly_JJZ;
		}

		static void n_DisconnectForcibly_JJZ (IntPtr jnienv, IntPtr native__this, long quiesceTimeout, long disconnectTimeout, bool sendDisconnectPacket)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout, sendDisconnectPacket);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_JJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='disconnectForcibly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
		[Register ("disconnectForcibly", "(JJZ)V", "GetDisconnectForcibly_JJZHandler")]
		public virtual unsafe void DisconnectForcibly (long quiesceTimeout, long disconnectTimeout, bool sendDisconnectPacket)
		{
			if (id_disconnectForcibly_JJZ == IntPtr.Zero)
				id_disconnectForcibly_JJZ = JNIEnv.GetMethodID (class_ref, "disconnectForcibly", "(JJZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (quiesceTimeout);
				__args [1] = new JValue (disconnectTimeout);
				__args [2] = new JValue (sendDisconnectPacket);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnectForcibly_JJZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnectForcibly", "(JJZ)V"), __args);
			} finally {
			}
		}

		static IntPtr id_generateClientId;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='generateClientId' and count(parameter)=0]"
		[Register ("generateClientId", "()Ljava/lang/String;", "")]
		public static unsafe string GenerateClientId ()
		{
			if (id_generateClientId == IntPtr.Zero)
				id_generateClientId = JNIEnv.GetStaticMethodID (class_ref, "generateClientId", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateClientId), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBufferedMessage_I;
#pragma warning disable 0169
		static Delegate GetGetBufferedMessage_IHandler ()
		{
			if (cb_getBufferedMessage_I == null)
				cb_getBufferedMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBufferedMessage_I);
			return cb_getBufferedMessage_I;
		}

		static IntPtr n_GetBufferedMessage_I (IntPtr jnienv, IntPtr native__this, int bufferIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBufferedMessage (bufferIndex));
		}
#pragma warning restore 0169

		static IntPtr id_getBufferedMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBufferedMessage", "(I)Lorg/eclipse/paho/client/mqttv3/MqttMessage;", "GetGetBufferedMessage_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage GetBufferedMessage (int bufferIndex)
		{
			if (id_getBufferedMessage_I == IntPtr.Zero)
				id_getBufferedMessage_I = JNIEnv.GetMethodID (class_ref, "getBufferedMessage", "(I)Lorg/eclipse/paho/client/mqttv3/MqttMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferIndex);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBufferedMessage_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBufferedMessage", "(I)Lorg/eclipse/paho/client/mqttv3/MqttMessage;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		static IntPtr id_getPendingDeliveryTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
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

		static Delegate cb_getTopic_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetTopic_Ljava_lang_String_Handler ()
		{
			if (cb_getTopic_Ljava_lang_String_ == null)
				cb_getTopic_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTopic_Ljava_lang_String_);
			return cb_getTopic_Ljava_lang_String_;
		}

		static IntPtr n_GetTopic_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTopic (topic));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTopic_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='getTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;", "GetGetTopic_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic GetTopic (string topic)
		{
			if (id_getTopic_Ljava_lang_String_ == IntPtr.Zero)
				id_getTopic_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;");
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topic);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopic_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttTopic> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopic", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/MqttTopic;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_messageArrivedComplete_II;
#pragma warning disable 0169
		static Delegate GetMessageArrivedComplete_IIHandler ()
		{
			if (cb_messageArrivedComplete_II == null)
				cb_messageArrivedComplete_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_MessageArrivedComplete_II);
			return cb_messageArrivedComplete_II;
		}

		static void n_MessageArrivedComplete_II (IntPtr jnienv, IntPtr native__this, int messageId, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrivedComplete_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("messageArrivedComplete", "(II)V", "GetMessageArrivedComplete_IIHandler")]
		public virtual unsafe void MessageArrivedComplete (int messageId, int qos)
		{
			if (id_messageArrivedComplete_II == IntPtr.Zero)
				id_messageArrivedComplete_II = JNIEnv.GetMethodID (class_ref, "messageArrivedComplete", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (messageId);
				__args [1] = new JValue (qos);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageArrivedComplete_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "messageArrivedComplete", "(II)V"), __args);
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

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_payload, int qos, bool retained)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, payload, qos, retained));
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_arrayBIZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, byte[] payload, int qos, bool retained)
		{
			if (id_publish_Ljava_lang_String_arrayBIZ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_topic = JNIEnv.NewString (topic);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_topic);
				__args [1] = new JValue (native_payload);
				__args [2] = new JValue (qos);
				__args [3] = new JValue (retained);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;[BIZ)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
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

		static IntPtr n_Publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_payload, int qos, bool retained, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, payload, qos, retained, userContext, @callback));
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.Object'] and parameter[6][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, byte[] payload, int qos, bool retained, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_topic = JNIEnv.NewString (topic);
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_topic);
				__args [1] = new JValue (native_payload);
				__args [2] = new JValue (qos);
				__args [3] = new JValue (retained);
				__args [4] = new JValue (userContext);
				__args [5] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_arrayBIZLjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;[BIZLjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
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

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, message));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_topic);
				__args [1] = new JValue (message);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
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

		static IntPtr n_Publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topic, IntPtr native_message, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Publish (topic, message, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='publish' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttMessage'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;", "GetPublish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken Publish (string topic, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage message, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;");
			IntPtr native_topic = JNIEnv.NewString (topic);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_topic);
				__args [1] = new JValue (message);
				__args [2] = new JValue (userContext);
				__args [3] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_publish_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_MqttMessage_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttDeliveryToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "publish", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/MqttMessage;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttDeliveryToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topic);
			}
		}

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_reconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public virtual unsafe void Reconnect ()
		{
			if (id_reconnect == IntPtr.Zero)
				id_reconnect = JNIEnv.GetMethodID (class_ref, "reconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
#pragma warning disable 0169
		static Delegate GetSetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_Handler ()
		{
			if (cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ == null)
				cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_);
			return cb_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
		}

		static void n_SetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bufferOpts)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions bufferOpts = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions> (native_bufferOpts, JniHandleOwnership.DoNotTransfer);
			__this.SetBufferOpts (bufferOpts);
		}
#pragma warning restore 0169

		static IntPtr id_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setBufferOpts' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.DisconnectedBufferOptions']]"
		[Register ("setBufferOpts", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", "GetSetBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_Handler")]
		public virtual unsafe void SetBufferOpts (global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions bufferOpts)
		{
			if (id_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ == IntPtr.Zero)
				id_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ = JNIEnv.GetMethodID (class_ref, "setBufferOpts", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bufferOpts);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBufferOpts_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBufferOpts", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V"), __args);
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

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback @callback)
		{
			if (id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == IntPtr.Zero)
				id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setManualAcks_Z;
#pragma warning disable 0169
		static Delegate GetSetManualAcks_ZHandler ()
		{
			if (cb_setManualAcks_Z == null)
				cb_setManualAcks_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetManualAcks_Z);
			return cb_setManualAcks_Z;
		}

		static void n_SetManualAcks_Z (IntPtr jnienv, IntPtr native__this, bool manualAcks)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		static IntPtr id_setManualAcks_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setManualAcks", "(Z)V", "GetSetManualAcks_ZHandler")]
		public virtual unsafe void SetManualAcks (bool manualAcks)
		{
			if (id_setManualAcks_Z == IntPtr.Zero)
				id_setManualAcks_Z = JNIEnv.GetMethodID (class_ref, "setManualAcks", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (manualAcks);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setManualAcks_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setManualAcks", "(Z)V"), __args);
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

		static IntPtr n_Subscribe_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos)
		{
			if (id_subscribe_Ljava_lang_String_I == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (qos);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
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

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (qos);
				__args [2] = new JValue (userContext);
				__args [3] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_userContext, IntPtr native__callback, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, userContext, @callback, messageListener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			if (id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (qos);
				__args [2] = new JValue (userContext);
				__args [3] = new JValue (@callback);
				__args [4] = new JValue (messageListener);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, int qos, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilter, qos, messageListener));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string topicFilter, int qos, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			if (id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (qos);
				__args [2] = new JValue (messageListener);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
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

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayI == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayI = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_topicFilters);
				__args [1] = new JValue (native_qos);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[I)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
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

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, userContext, @callback));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_topicFilters);
				__args [1] = new JValue (native_qos);
				__args [2] = new JValue (userContext);
				__args [3] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_userContext, IntPtr native__callback, IntPtr native_messageListeners)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_messageListeners, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, userContext, @callback, messageListeners));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			if (messageListeners != null)
				JNIEnv.CopyArray (messageListeners, native_messageListeners);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener'] and parameter[5][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			IntPtr native_messageListeners = JNIEnv.NewArray (messageListeners);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_topicFilters);
				__args [1] = new JValue (native_qos);
				__args [2] = new JValue (userContext);
				__args [3] = new JValue (@callback);
				__args [4] = new JValue (native_messageListeners);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayILjava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_arrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[ILjava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
				if (messageListeners != null) {
					JNIEnv.CopyArray (native_messageListeners, messageListeners);
					JNIEnv.DeleteLocalRef (native_messageListeners);
				}
			}
		}

		static Delegate cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static IntPtr n_Subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_qos, IntPtr native_messageListeners)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			int[] qos = (int[]) JNIEnv.GetArray (native_qos, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[]) JNIEnv.GetArray (native_messageListeners, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (topicFilters, qos, messageListeners));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			if (qos != null)
				JNIEnv.CopyArray (qos, native_qos);
			if (messageListeners != null)
				JNIEnv.CopyArray (messageListeners, native_messageListeners);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='int[]'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener[]']]"
		[Register ("subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetSubscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Subscribe (string[] topicFilters, int[] qos, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener[] messageListeners)
		{
			if (id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			IntPtr native_qos = JNIEnv.NewArray (qos);
			IntPtr native_messageListeners = JNIEnv.NewArray (messageListeners);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_topicFilters);
				__args [1] = new JValue (native_qos);
				__args [2] = new JValue (native_messageListeners);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_arrayLjava_lang_String_arrayIarrayLorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subscribe", "([Ljava/lang/String;[I[Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
				if (qos != null) {
					JNIEnv.CopyArray (native_qos, qos);
					JNIEnv.DeleteLocalRef (native_qos);
				}
				if (messageListeners != null) {
					JNIEnv.CopyArray (native_messageListeners, messageListeners);
					JNIEnv.DeleteLocalRef (native_messageListeners);
				}
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

		static IntPtr n_Unsubscribe_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilter));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string topicFilter)
		{
			if (id_unsubscribe_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topicFilter);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
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

		static IntPtr n_Unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilter, userContext, @callback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string topicFilter, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (userContext);
				__args [2] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Ljava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "(Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
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

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilters));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] topicFilters)
		{
			if (id_unsubscribe_arrayLjava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topicFilters);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "([Ljava/lang/String;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
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

		static IntPtr n_Unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilters, IntPtr native_userContext, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttAsyncClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] topicFilters = (string[]) JNIEnv.GetArray (native_topicFilters, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Java.Lang.Object userContext = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_userContext, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (topicFilters, userContext, @callback));
			if (topicFilters != null)
				JNIEnv.CopyArray (topicFilters, native_topicFilters);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttAsyncClient']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.Object'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;", "GetUnsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken Unsubscribe (string[] topicFilters, global::Java.Lang.Object userContext, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener @callback)
		{
			if (id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;");
			IntPtr native_topicFilters = JNIEnv.NewArray (topicFilters);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_topicFilters);
				__args [1] = new JValue (userContext);
				__args [2] = new JValue (@callback);

				global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_arrayLjava_lang_String_Ljava_lang_Object_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unsubscribe", "([Ljava/lang/String;Ljava/lang/Object;Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/IMqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (topicFilters != null) {
					JNIEnv.CopyArray (native_topicFilters, topicFilters);
					JNIEnv.DeleteLocalRef (native_topicFilters);
				}
			}
		}

	}
}
