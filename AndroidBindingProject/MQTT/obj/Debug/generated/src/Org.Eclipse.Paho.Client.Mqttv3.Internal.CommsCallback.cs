using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", DoNotGenerateAcw=true)]
	public partial class CommsCallback : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		static IntPtr running_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/field[@name='running']"
		[Register ("running")]
		public bool Running {
			get {
				if (running_jfieldId == IntPtr.Zero)
					running_jfieldId = JNIEnv.GetFieldID (class_ref, "running", "Z");
				return JNIEnv.GetBooleanField (((global::Java.Lang.Object) this).Handle, running_jfieldId);
			}
			set {
				if (running_jfieldId == IntPtr.Zero)
					running_jfieldId = JNIEnv.GetFieldID (class_ref, "running", "Z");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, running_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/CommsCallback", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommsCallback); }
		}

		protected CommsCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isQuiesced;
#pragma warning disable 0169
		static Delegate GetIsQuiescedHandler ()
		{
			if (cb_isQuiesced == null)
				cb_isQuiesced = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsQuiesced);
			return cb_isQuiesced;
		}

		static bool n_IsQuiesced (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsQuiesced;
		}
#pragma warning restore 0169

		static IntPtr id_isQuiesced;
		public virtual unsafe bool IsQuiesced {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='isQuiesced' and count(parameter)=0]"
			[Register ("isQuiesced", "()Z", "GetIsQuiescedHandler")]
			get {
				if (id_isQuiesced == IntPtr.Zero)
					id_isQuiesced = JNIEnv.GetMethodID (class_ref, "isQuiesced", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isQuiesced);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isQuiesced", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getThread;
#pragma warning disable 0169
		static Delegate GetGetThreadHandler ()
		{
			if (cb_getThread == null)
				cb_getThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThread);
			return cb_getThread;
		}

		static IntPtr n_GetThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thread);
		}
#pragma warning restore 0169

		static IntPtr id_getThread;
		protected virtual unsafe global::Java.Lang.Thread Thread {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='getThread' and count(parameter)=0]"
			[Register ("getThread", "()Ljava/lang/Thread;", "GetGetThreadHandler")]
			get {
				if (id_getThread == IntPtr.Zero)
					id_getThread = JNIEnv.GetMethodID (class_ref, "getThread", "()Ljava/lang/Thread;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThread), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThread", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_AsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.AsyncOperationComplete (token);
		}
#pragma warning restore 0169

		static IntPtr id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='asyncOperationComplete' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetAsyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void AsyncOperationComplete (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_asyncOperationComplete_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asyncOperationComplete", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
#pragma warning disable 0169
		static Delegate GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler ()
		{
			if (cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ == null)
				cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_);
			return cb_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		}

		static void n_ConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cause)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttException cause = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttException> (native_cause, JniHandleOwnership.DoNotTransfer);
			__this.ConnectionLost (cause);
		}
#pragma warning restore 0169

		static IntPtr id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='connectionLost' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttException']]"
		[Register ("connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V", "GetConnectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_Handler")]
		public virtual unsafe void ConnectionLost (global::Org.Eclipse.Paho.Client.Mqttv3.MqttException cause)
		{
			if (id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ == IntPtr.Zero)
				id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_ = JNIEnv.GetMethodID (class_ref, "connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (cause);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_connectionLost_Lorg_eclipse_paho_client_mqttv3_MqttException_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "connectionLost", "(Lorg/eclipse/paho/client/mqttv3/MqttException;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_;
#pragma warning disable 0169
		static Delegate GetDeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_Handler ()
		{
			if (cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ == null)
				cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_DeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_);
			return cb_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_;
		}

		static bool n_DeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_topicName, int messageId, IntPtr native_aMessage)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicName = JNIEnv.GetString (native_topicName, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage aMessage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (native_aMessage, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeliverMessage (topicName, messageId, aMessage);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='deliverMessage' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='org.eclipse.paho.client.mqttv3.MqttMessage']]"
		[Register ("deliverMessage", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/MqttMessage;)Z", "GetDeliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_Handler")]
		protected virtual unsafe bool DeliverMessage (string topicName, int messageId, global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage aMessage)
		{
			if (id_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ == IntPtr.Zero)
				id_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_ = JNIEnv.GetMethodID (class_ref, "deliverMessage", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/MqttMessage;)Z");
			IntPtr native_topicName = JNIEnv.NewString (topicName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_topicName);
				__args [1] = new JValue (messageId);
				__args [2] = new JValue (aMessage);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deliverMessage_Ljava_lang_String_ILorg_eclipse_paho_client_mqttv3_MqttMessage_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverMessage", "(Ljava/lang/String;ILorg/eclipse/paho/client/mqttv3/MqttMessage;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_topicName);
			}
		}

		static Delegate cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_FireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.FireActionEvent (token);
		}
#pragma warning restore 0169

		static IntPtr id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='fireActionEvent' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetFireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void FireActionEvent (global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fireActionEvent_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fireActionEvent", "(Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
#pragma warning disable 0169
		static Delegate GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler ()
		{
			if (cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == null)
				cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_);
			return cb_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		}

		static void n_MessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sendMessage)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish sendMessage = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish> (native_sendMessage, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrived (sendMessage);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='messageArrived' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPublish']]"
		[Register ("messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V", "GetMessageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_Handler")]
		public virtual unsafe void MessageArrived (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPublish sendMessage)
		{
			if (id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ == IntPtr.Zero)
				id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_ = JNIEnv.GetMethodID (class_ref, "messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sendMessage);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_messageArrived_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPublish_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "messageArrived", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPublish;)V"), __args);
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MessageArrivedComplete (messageId, qos);
		}
#pragma warning restore 0169

		static IntPtr id_messageArrivedComplete_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='messageArrivedComplete' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
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

		static Delegate cb_quiesce;
#pragma warning disable 0169
		static Delegate GetQuiesceHandler ()
		{
			if (cb_quiesce == null)
				cb_quiesce = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Quiesce);
			return cb_quiesce;
		}

		static void n_Quiesce (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Quiesce ();
		}
#pragma warning restore 0169

		static IntPtr id_quiesce;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='quiesce' and count(parameter)=0]"
		[Register ("quiesce", "()V", "GetQuiesceHandler")]
		public virtual unsafe void Quiesce ()
		{
			if (id_quiesce == IntPtr.Zero)
				id_quiesce = JNIEnv.GetMethodID (class_ref, "quiesce", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_quiesce);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "quiesce", "()V"));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListener (topicFilter);
		}
#pragma warning restore 0169

		static IntPtr id_removeMessageListener_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='removeMessageListener' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_removeMessageListeners;
#pragma warning disable 0169
		static Delegate GetRemoveMessageListenersHandler ()
		{
			if (cb_removeMessageListeners == null)
				cb_removeMessageListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveMessageListeners);
			return cb_removeMessageListeners;
		}

		static void n_RemoveMessageListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMessageListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_removeMessageListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='removeMessageListeners' and count(parameter)=0]"
		[Register ("removeMessageListeners", "()V", "GetRemoveMessageListenersHandler")]
		public virtual unsafe void RemoveMessageListeners ()
		{
			if (id_removeMessageListeners == IntPtr.Zero)
				id_removeMessageListeners = JNIEnv.GetMethodID (class_ref, "removeMessageListeners", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMessageListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMessageListeners", "()V"));
			} finally {
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='run' and count(parameter)=0]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback mqttCallback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallback> (native_mqttCallback, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (mqttCallback);
		}
#pragma warning restore 0169

		static IntPtr id_setCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallback']]"
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

		static Delegate cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
#pragma warning disable 0169
		static Delegate GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler ()
		{
			if (cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ == null)
				cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_);
			return cb_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
		}

		static void n_SetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clientState)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState> (native_clientState, JniHandleOwnership.DoNotTransfer);
			__this.SetClientState (clientState);
		}
#pragma warning restore 0169

		static IntPtr id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setClientState' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState']]"
		[Register ("setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V", "GetSetClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Handler")]
		public virtual unsafe void SetClientState (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState)
		{
			if (id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ == IntPtr.Zero)
				id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_ = JNIEnv.GetMethodID (class_ref, "setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (clientState);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientState_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientState", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;)V"), __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetManualAcks (manualAcks);
		}
#pragma warning restore 0169

		static IntPtr id_setManualAcks_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setManualAcks' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string topicFilter = JNIEnv.GetString (native_topicFilter, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener messageListener = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttMessageListener> (native_messageListener, JniHandleOwnership.DoNotTransfer);
			__this.SetMessageListener (topicFilter, messageListener);
		}
#pragma warning restore 0169

		static IntPtr id_setMessageListener_Ljava_lang_String_Lorg_eclipse_paho_client_mqttv3_IMqttMessageListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setMessageListener' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.IMqttMessageListener']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.IMqttCallbackExtended> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetReconnectCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_setReconnectCallback_Lorg_eclipse_paho_client_mqttv3_MqttCallbackExtended_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='setReconnectCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.MqttCallbackExtended']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string threadName = JNIEnv.GetString (native_threadName, JniHandleOwnership.DoNotTransfer);
			__this.Start (threadName);
		}
#pragma warning restore 0169

		static IntPtr id_start_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='start' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.CommsCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='CommsCallback']/method[@name='stop' and count(parameter)=0]"
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
