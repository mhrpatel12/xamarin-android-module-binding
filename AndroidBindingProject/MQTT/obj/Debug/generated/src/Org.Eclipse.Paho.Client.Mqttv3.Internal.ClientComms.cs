using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/ClientComms", DoNotGenerateAcw=true)]
	public partial class ClientComms : global::Java.Lang.Object {


		static IntPtr BUILD_LEVEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/field[@name='BUILD_LEVEL']"
		[Register ("BUILD_LEVEL")]
		public static string BuildLevel {
			get {
				if (BUILD_LEVEL_jfieldId == IntPtr.Zero)
					BUILD_LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUILD_LEVEL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BUILD_LEVEL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (BUILD_LEVEL_jfieldId == IntPtr.Zero)
					BUILD_LEVEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BUILD_LEVEL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, BUILD_LEVEL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr VERSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/field[@name='VERSION']"
		[Register ("VERSION")]
		public static string Version {
			get {
				if (VERSION_jfieldId == IntPtr.Zero)
					VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERSION_jfieldId == IntPtr.Zero)
					VERSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, VERSION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/ClientComms", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientComms); }
		}

		protected ClientComms (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/constructor[@name='ClientComms' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttAsyncClient'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttClientPersistence'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttPingSender']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", "")]
		public unsafe ClientComms (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient client, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttClientPersistence persistence, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttPingSender pingSender)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (client);
				__args [1] = new JValue (persistence);
				__args [2] = new JValue (pingSender);
				if (((object) this).GetType () != typeof (ClientComms)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;Lorg/eclipse/paho/client/mqttv3/MqttClientPersistence;Lorg/eclipse/paho/client/mqttv3/MqttPingSender;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_IMqttAsyncClient_Lorg_eclipse_paho_client_mqttv3_MqttClientPersistence_Lorg_eclipse_paho_client_mqttv3_MqttPingSender_, __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BufferedMessageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getBufferedMessageCount;
		public virtual unsafe int BufferedMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getBufferedMessageCount' and count(parameter)=0]"
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

		static Delegate cb_getClient;
#pragma warning disable 0169
		static Delegate GetGetClientHandler ()
		{
			if (cb_getClient == null)
				cb_getClient = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClient);
			return cb_getClient;
		}

		static IntPtr n_GetClient (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Client);
		}
#pragma warning restore 0169

		static IntPtr id_getClient;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient Client {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getClient' and count(parameter)=0]"
			[Register ("getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;", "GetGetClientHandler")]
			get {
				if (id_getClient == IntPtr.Zero)
					id_getClient = JNIEnv.GetMethodID (class_ref, "getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClient), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttAsyncClient> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClient", "()Lorg/eclipse/paho/client/mqttv3/IMqttAsyncClient;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClientState;
#pragma warning disable 0169
		static Delegate GetGetClientStateHandler ()
		{
			if (cb_getClientState == null)
				cb_getClientState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientState);
			return cb_getClientState;
		}

		static IntPtr n_GetClientState (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClientState);
		}
#pragma warning restore 0169

		static IntPtr id_getClientState;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState ClientState {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getClientState' and count(parameter)=0]"
			[Register ("getClientState", "()Lorg/eclipse/paho/client/mqttv3/internal/ClientState;", "GetGetClientStateHandler")]
			get {
				if (id_getClientState == IntPtr.Zero)
					id_getClientState = JNIEnv.GetMethodID (class_ref, "getClientState", "()Lorg/eclipse/paho/client/mqttv3/internal/ClientState;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientState), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientState", "()Lorg/eclipse/paho/client/mqttv3/internal/ClientState;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConOptions;
#pragma warning disable 0169
		static Delegate GetGetConOptionsHandler ()
		{
			if (cb_getConOptions == null)
				cb_getConOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConOptions);
			return cb_getConOptions;
		}

		static IntPtr n_GetConOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConOptions);
		}
#pragma warning restore 0169

		static IntPtr id_getConOptions;
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions ConOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getConOptions' and count(parameter)=0]"
			[Register ("getConOptions", "()Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;", "GetGetConOptionsHandler")]
			get {
				if (id_getConOptions == IntPtr.Zero)
					id_getConOptions = JNIEnv.GetMethodID (class_ref, "getConOptions", "()Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConOptions", "()Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;")), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Debug);
		}
#pragma warning restore 0169

		static IntPtr id_getDebug;
		public virtual unsafe global::Java.Util.Properties Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getDebug' and count(parameter)=0]"
			[Register ("getDebug", "()Ljava/util/Properties;", "GetGetDebugHandler")]
			get {
				if (id_getDebug == IntPtr.Zero)
					id_getDebug = JNIEnv.GetMethodID (class_ref, "getDebug", "()Ljava/util/Properties;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDebug), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Util.Properties> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDebug", "()Ljava/util/Properties;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		public virtual unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isConnected' and count(parameter)=0]"
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

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isConnecting;
		public virtual unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				if (id_isConnecting == IntPtr.Zero)
					id_isConnecting = JNIEnv.GetMethodID (class_ref, "isConnecting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnecting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnecting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDisconnected;
#pragma warning disable 0169
		static Delegate GetIsDisconnectedHandler ()
		{
			if (cb_isDisconnected == null)
				cb_isDisconnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisconnected);
			return cb_isDisconnected;
		}

		static bool n_IsDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisconnected;
		}
#pragma warning restore 0169

		static IntPtr id_isDisconnected;
		public virtual unsafe bool IsDisconnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isDisconnected' and count(parameter)=0]"
			[Register ("isDisconnected", "()Z", "GetIsDisconnectedHandler")]
			get {
				if (id_isDisconnected == IntPtr.Zero)
					id_isDisconnected = JNIEnv.GetMethodID (class_ref, "isDisconnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisconnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisconnected", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isDisconnecting;
#pragma warning disable 0169
		static Delegate GetIsDisconnectingHandler ()
		{
			if (cb_isDisconnecting == null)
				cb_isDisconnecting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDisconnecting);
			return cb_isDisconnecting;
		}

		static bool n_IsDisconnecting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDisconnecting;
		}
#pragma warning restore 0169

		static IntPtr id_isDisconnecting;
		public virtual unsafe bool IsDisconnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isDisconnecting' and count(parameter)=0]"
			[Register ("isDisconnecting", "()Z", "GetIsDisconnectingHandler")]
			get {
				if (id_isDisconnecting == IntPtr.Zero)
					id_isDisconnecting = JNIEnv.GetMethodID (class_ref, "isDisconnecting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDisconnecting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDisconnecting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isResting;
#pragma warning disable 0169
		static Delegate GetIsRestingHandler ()
		{
			if (cb_isResting == null)
				cb_isResting = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsResting);
			return cb_isResting;
		}

		static bool n_IsResting (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsResting;
		}
#pragma warning restore 0169

		static IntPtr id_isResting;
		public virtual unsafe bool IsResting {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='isResting' and count(parameter)=0]"
			[Register ("isResting", "()Z", "GetIsRestingHandler")]
			get {
				if (id_isResting == IntPtr.Zero)
					id_isResting = JNIEnv.GetMethodID (class_ref, "isResting", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isResting);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isResting", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getKeepAlive;
#pragma warning disable 0169
		static Delegate GetGetKeepAliveHandler ()
		{
			if (cb_getKeepAlive == null)
				cb_getKeepAlive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetKeepAlive);
			return cb_getKeepAlive;
		}

		static long n_GetKeepAlive (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepAlive;
		}
#pragma warning restore 0169

		static IntPtr id_getKeepAlive;
		public virtual unsafe long KeepAlive {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getKeepAlive' and count(parameter)=0]"
			[Register ("getKeepAlive", "()J", "GetGetKeepAliveHandler")]
			get {
				if (id_getKeepAlive == IntPtr.Zero)
					id_getKeepAlive = JNIEnv.GetMethodID (class_ref, "getKeepAlive", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getKeepAlive);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKeepAlive", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getNetworkModuleIndex;
#pragma warning disable 0169
		static Delegate GetGetNetworkModuleIndexHandler ()
		{
			if (cb_getNetworkModuleIndex == null)
				cb_getNetworkModuleIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNetworkModuleIndex);
			return cb_getNetworkModuleIndex;
		}

		static int n_GetNetworkModuleIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NetworkModuleIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setNetworkModuleIndex_I;
#pragma warning disable 0169
		static Delegate GetSetNetworkModuleIndex_IHandler ()
		{
			if (cb_setNetworkModuleIndex_I == null)
				cb_setNetworkModuleIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNetworkModuleIndex_I);
			return cb_setNetworkModuleIndex_I;
		}

		static void n_SetNetworkModuleIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NetworkModuleIndex = index;
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkModuleIndex;
		static IntPtr id_setNetworkModuleIndex_I;
		public virtual unsafe int NetworkModuleIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getNetworkModuleIndex' and count(parameter)=0]"
			[Register ("getNetworkModuleIndex", "()I", "GetGetNetworkModuleIndexHandler")]
			get {
				if (id_getNetworkModuleIndex == IntPtr.Zero)
					id_getNetworkModuleIndex = JNIEnv.GetMethodID (class_ref, "getNetworkModuleIndex", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkModuleIndex);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkModuleIndex", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setNetworkModuleIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNetworkModuleIndex", "(I)V", "GetSetNetworkModuleIndex_IHandler")]
			set {
				if (id_setNetworkModuleIndex_I == IntPtr.Zero)
					id_setNetworkModuleIndex_I = JNIEnv.GetMethodID (class_ref, "setNetworkModuleIndex", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkModuleIndex_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkModuleIndex", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkForActivity;
#pragma warning disable 0169
		static Delegate GetCheckForActivityHandler ()
		{
			if (cb_checkForActivity == null)
				cb_checkForActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_CheckForActivity);
			return cb_checkForActivity;
		}

		static IntPtr n_CheckForActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CheckForActivity ());
		}
#pragma warning restore 0169

		static IntPtr id_checkForActivity;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='checkForActivity' and count(parameter)=0]"
		[Register ("checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetCheckForActivityHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken CheckForActivity ()
		{
			if (id_checkForActivity == IntPtr.Zero)
				id_checkForActivity = JNIEnv.GetMethodID (class_ref, "checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkForActivity), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkForActivity", "()Lorg/eclipse/paho/client/mqttv3/MqttToken;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
#pragma warning disable 0169
		static Delegate GetCheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler ()
		{
			if (cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == null)
				cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_);
			return cb_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		}

		static IntPtr n_CheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pingCallback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener pingCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener> (native_pingCallback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CheckForActivity (pingCallback));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='checkForActivity' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.IMqttActionListener']]"
		[Register ("checkForActivity", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/MqttToken;", "GetCheckForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_Handler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken CheckForActivity (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttActionListener pingCallback)
		{
			if (id_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ == IntPtr.Zero)
				id_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_ = JNIEnv.GetMethodID (class_ref, "checkForActivity", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/MqttToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pingCallback);

				global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_checkForActivity_Lorg_eclipse_paho_client_mqttv3_IMqttActionListener_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkForActivity", "(Lorg/eclipse/paho/client/mqttv3/IMqttActionListener;)Lorg/eclipse/paho/client/mqttv3/MqttToken;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='close' and count(parameter)=0]"
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

		static Delegate cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Connect (options, token);
		}
#pragma warning restore 0169

		static IntPtr id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='connect' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttConnectOptions'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetConnect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Connect (global::Org.Eclipse.Paho.Client.Mqttv3.MqttConnectOptions options, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (options);
				__args [1] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connect_Lorg_eclipse_paho_client_mqttv3_MqttConnectOptions_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connect", "(Lorg/eclipse/paho/client/mqttv3/MqttConnectOptions;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cack, IntPtr native_mex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack cack = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack> (native_cack, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException mex = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_mex, JniHandleOwnership.DoNotTransfer);
			__this.ConnectComplete (cack, mex);
		}
#pragma warning restore 0169

		static IntPtr id_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='connectComplete' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttConnack'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("connectComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttConnack;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetConnectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ConnectComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttConnack cack, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException mex)
		{
			if (id_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "connectComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttConnack;Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (cack);
				__args [1] = new JValue (mex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttConnack_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttConnack;Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteBufferedMessage (bufferIndex);
		}
#pragma warning restore 0169

		static IntPtr id_deleteBufferedMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deleteBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_deliveryComplete_I;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_IHandler ()
		{
			if (cb_deliveryComplete_I == null)
				cb_deliveryComplete_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeliveryComplete_I);
			return cb_deliveryComplete_I;
		}

		static void n_DeliveryComplete_I (IntPtr jnienv, IntPtr native__this, int messageId)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (messageId);
		}
#pragma warning restore 0169

		static IntPtr id_deliveryComplete_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deliveryComplete", "(I)V", "GetDeliveryComplete_IHandler")]
		protected virtual unsafe void DeliveryComplete (int messageId)
		{
			if (id_deliveryComplete_I == IntPtr.Zero)
				id_deliveryComplete_I = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (messageId);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliveryComplete_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryComplete", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_DeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish msg = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.DeliveryComplete (msg);
		}
#pragma warning restore 0169

		static IntPtr id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='deliveryComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetDeliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		protected virtual unsafe void DeliveryComplete (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish msg)
		{
			if (id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (msg);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deliveryComplete_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliveryComplete", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetDisconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_Disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_Disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disconnect, long quiesceTimeout, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect disconnect = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect> (native_disconnect, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect (disconnect, quiesceTimeout, token);
		}
#pragma warning restore 0169

		static IntPtr id_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnect' and count(parameter)=3 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttDisconnect'] and parameter[2][@type='long'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("disconnect", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttDisconnect;JLorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetDisconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void Disconnect (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttDisconnect disconnect, long quiesceTimeout, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "disconnect", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttDisconnect;JLorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (disconnect);
				__args [1] = new JValue (quiesceTimeout);
				__args [2] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disconnect_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttDisconnect_JLorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disconnect", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttDisconnect;JLorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnectForcibly' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisconnectForcibly (quiesceTimeout, disconnectTimeout, sendDisconnectPacket);
		}
#pragma warning restore 0169

		static IntPtr id_disconnectForcibly_JJZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='disconnectForcibly' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='boolean']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetBufferedMessage (bufferIndex));
		}
#pragma warning restore 0169

		static IntPtr id_getBufferedMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getBufferedMessage' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getNetworkModules;
#pragma warning disable 0169
		static Delegate GetGetNetworkModulesHandler ()
		{
			if (cb_getNetworkModules == null)
				cb_getNetworkModules = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNetworkModules);
			return cb_getNetworkModules;
		}

		static IntPtr n_GetNetworkModules (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetNetworkModules ());
		}
#pragma warning restore 0169

		static IntPtr id_getNetworkModules;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getNetworkModules' and count(parameter)=0]"
		[Register ("getNetworkModules", "()[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;", "GetGetNetworkModulesHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] GetNetworkModules ()
		{
			if (id_getNetworkModules == IntPtr.Zero)
				id_getNetworkModules = JNIEnv.GetMethodID (class_ref, "getNetworkModules", "()[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNetworkModules), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
				else
					return (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNetworkModules", "()[Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPendingDeliveryTokens ());
		}
#pragma warning restore 0169

		static IntPtr id_getPendingDeliveryTokens;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getPendingDeliveryTokens' and count(parameter)=0]"
		[Register ("getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;", "GetGetPendingDeliveryTokensHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[] GetPendingDeliveryTokens ()
		{
			if (id_getPendingDeliveryTokens == IntPtr.Zero)
				id_getPendingDeliveryTokens = JNIEnv.GetMethodID (class_ref, "getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDeliveryTokens), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
				else
					return (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingDeliveryTokens", "()[Lorg/eclipse/paho/client/mqttv3/MqttDeliveryToken;")), JniHandleOwnership.TransferLocalRef, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.MqttDeliveryToken));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topic = JNIEnv.GetString (native_topic, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTopic (topic));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTopic_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='getTopic' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrivedComplete_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_notifyReconnect;
#pragma warning disable 0169
		static Delegate GetNotifyReconnectHandler ()
		{
			if (cb_notifyReconnect == null)
				cb_notifyReconnect = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyReconnect);
			return cb_notifyReconnect;
		}

		static void n_NotifyReconnect (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyReconnect ();
		}
#pragma warning restore 0169

		static IntPtr id_notifyReconnect;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='notifyReconnect' and count(parameter)=0]"
		[Register ("notifyReconnect", "()V", "GetNotifyReconnectHandler")]
		public virtual unsafe void NotifyReconnect ()
		{
			if (id_notifyReconnect == IntPtr.Zero)
				id_notifyReconnect = JNIEnv.GetMethodID (class_ref, "notifyReconnect", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyReconnect);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyReconnect", "()V"));
			} finally {
			}
		}

		static Delegate cb_removeMessageListener_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMessageListener_Ljava_lang_String_Handler ()
		{
			if (cb_removeMessageListener_Ljava_lang_String_ == null)
				cb_removeMessageListener_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMessageListener_Ljava_lang_String_);
			return cb_removeMessageListener_Ljava_lang_String_;
		}

		static void n_RemoveMessageListener_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListener (topicFilter);
		}
#pragma warning restore 0169

		static IntPtr id_removeMessageListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='removeMessageListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeMessageListener", "(Ljava/lang/String;)V", "GetRemoveMessageListener_Ljava_lang_String_Handler")]
		public virtual unsafe void RemoveMessageListener (string topicFilter)
		{
			if (id_removeMessageListener_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMessageListener_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMessageListener", "(Ljava/lang/String;)V");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_topicFilter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMessageListener_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMessageListener", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetSendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_SendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.SendNoWait (message, token);
		}
#pragma warning restore 0169

		static IntPtr id_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='sendNoWait' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("sendNoWait", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetSendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void SendNoWait (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "sendNoWait", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (message);
				__args [1] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendNoWait_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendNoWait", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
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

		static void n_SetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mqttCallback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_mqttCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (mqttCallback);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
		[Register ("setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V", "GetSetCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_Handler")]
		public virtual unsafe void SetCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback)
		{
			if (id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ == IntPtr.Zero)
				id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_ = JNIEnv.GetMethodID (class_ref, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mqttCallback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallback;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_;
#pragma warning disable 0169
		static Delegate GetSetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_Handler ()
		{
			if (cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ == null)
				cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_);
			return cb_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_;
		}

		static void n_SetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disconnectedMessageBuffer)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer disconnectedMessageBuffer = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (native_disconnectedMessageBuffer, JniHandleOwnership.DoNotTransfer);
			__this.SetDisconnectedMessageBuffer (disconnectedMessageBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setDisconnectedMessageBuffer' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.DisconnectedMessageBuffer']]"
		[Register ("setDisconnectedMessageBuffer", "(Lorg/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer;)V", "GetSetDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_Handler")]
		public virtual unsafe void SetDisconnectedMessageBuffer (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer disconnectedMessageBuffer)
		{
			if (id_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ == IntPtr.Zero)
				id_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_ = JNIEnv.GetMethodID (class_ref, "setDisconnectedMessageBuffer", "(Lorg/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (disconnectedMessageBuffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisconnectedMessageBuffer_Lorg_eclipse_paho_client_mqttv3_internal_DisconnectedMessageBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisconnectedMessageBuffer", "(Lorg/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer;)V"), __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		static IntPtr id_setManualAcks_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
#pragma warning disable 0169
		static Delegate GetSetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler ()
		{
			if (cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == null)
				cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_);
			return cb_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		}

		static void n_SetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicFilter, IntPtr native_messageListener)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageListener (topicFilter, messageListener);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setMessageListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
		[Register ("setMessageListener", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)V", "GetSetMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_Handler")]
		public virtual unsafe void SetMessageListener (string topicFilter, global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener)
		{
			if (id_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ == IntPtr.Zero)
				id_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_ = JNIEnv.GetMethodID (class_ref, "setMessageListener", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)V");
			IntPtr native_topicFilter = JNIEnv.NewString (topicFilter);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_topicFilter);
				__args [1] = new JValue (messageListener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageListener", "(Ljava/lang/String;Lorg/eclipse/paho/client/mqttv3/IMqttMessageListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_topicFilter);
			}
		}

		static Delegate cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_;
#pragma warning disable 0169
		static Delegate GetSetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_Handler ()
		{
			if (cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ == null)
				cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_);
			return cb_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_;
		}

		static void n_SetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ (IntPtr jnienv, IntPtr native__this, IntPtr native_networkModules)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] networkModules = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[]) JNIEnv.GetArray (native_networkModules, JniHandleOwnership.DoNotTransfer, typeof (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule));
			__this.SetNetworkModules (networkModules);
			if (networkModules != null)
				JNIEnv.CopyArray (networkModules, native_networkModules);
		}
#pragma warning restore 0169

		static IntPtr id_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setNetworkModules' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.NetworkModule[]']]"
		[Register ("setNetworkModules", "([Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;)V", "GetSetNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_Handler")]
		public virtual unsafe void SetNetworkModules (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.INetworkModule[] networkModules)
		{
			if (id_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ == IntPtr.Zero)
				id_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_ = JNIEnv.GetMethodID (class_ref, "setNetworkModules", "([Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;)V");
			IntPtr native_networkModules = JNIEnv.NewArray (networkModules);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_networkModules);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNetworkModules_arrayLorg_eclipse_paho_client_mqttv3_internal_NetworkModule_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNetworkModules", "([Lorg/eclipse/paho/client/mqttv3/internal/NetworkModule;)V"), __args);
			} finally {
				if (networkModules != null) {
					JNIEnv.CopyArray (native_networkModules, networkModules);
					JNIEnv.DeleteLocalRef (native_networkModules);
				}
			}
		}

		static Delegate cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
#pragma warning disable 0169
		static Delegate GetSetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler ()
		{
			if (cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ == null)
				cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_);
			return cb_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
		}

		static void n_SetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetReconnectCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setReconnectCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallbackExtended']]"
		[Register ("setReconnectCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V", "GetSetReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_Handler")]
		public virtual unsafe void SetReconnectCallback (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback)
		{
			if (id_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ == IntPtr.Zero)
				id_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_ = JNIEnv.GetMethodID (class_ref, "setReconnectCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReconnectCallback", "(Lorg/eclipse/paho/client/mqttv3/MqttCallbackExtended;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRestingState_Z;
#pragma warning disable 0169
		static Delegate GetSetRestingState_ZHandler ()
		{
			if (cb_setRestingState_Z == null)
				cb_setRestingState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRestingState_Z);
			return cb_setRestingState_Z;
		}

		static void n_SetRestingState_Z (IntPtr jnienv, IntPtr native__this, bool resting)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRestingState (resting);
		}
#pragma warning restore 0169

		static IntPtr id_setRestingState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='setRestingState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setRestingState", "(Z)V", "GetSetRestingState_ZHandler")]
		public virtual unsafe void SetRestingState (bool resting)
		{
			if (id_setRestingState_Z == IntPtr.Zero)
				id_setRestingState_Z = JNIEnv.GetMethodID (class_ref, "setRestingState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (resting);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRestingState_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRestingState", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token, IntPtr native_reason)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientComms> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_reason, JniHandleOwnership.DoNotTransfer);
			__this.ShutdownConnection (token, reason);
		}
#pragma warning restore 0169

		static IntPtr id_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='ClientComms']/method[@name='shutdownConnection' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("shutdownConnection", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetShutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ShutdownConnection (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token, global::Org.Eclipse.Paho.Client.Mqttv3.MqttException reason)
		{
			if (id_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "shutdownConnection", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (token);
				__args [1] = new JValue (reason);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_shutdownConnection_Lorg_eclipse_paho_client_mqttv3_MqttToken_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shutdownConnection", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

	}
}
