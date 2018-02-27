using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer", DoNotGenerateAcw=true)]
	public partial class DisconnectedMessageBuffer : global::Java.Lang.Object, global::Java.Lang.IRunnable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/DisconnectedMessageBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DisconnectedMessageBuffer); }
		}

		protected DisconnectedMessageBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/constructor[@name='DisconnectedMessageBuffer' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.DisconnectedBufferOptions']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", "")]
		public unsafe DisconnectedMessageBuffer (global::Org.Eclipse.Paho.Client.Mqttv3.DisconnectedBufferOptions options)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (options);
				if (((object) this).GetType () != typeof (DisconnectedMessageBuffer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/DisconnectedBufferOptions;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_DisconnectedBufferOptions_, __args);
			} finally {
			}
		}

		static Delegate cb_isPersistBuffer;
#pragma warning disable 0169
		static Delegate GetIsPersistBufferHandler ()
		{
			if (cb_isPersistBuffer == null)
				cb_isPersistBuffer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPersistBuffer);
			return cb_isPersistBuffer;
		}

		static bool n_IsPersistBuffer (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPersistBuffer;
		}
#pragma warning restore 0169

		static IntPtr id_isPersistBuffer;
		public virtual unsafe bool IsPersistBuffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='isPersistBuffer' and count(parameter)=0]"
			[Register ("isPersistBuffer", "()Z", "GetIsPersistBufferHandler")]
			get {
				if (id_isPersistBuffer == IntPtr.Zero)
					id_isPersistBuffer = JNIEnv.GetMethodID (class_ref, "isPersistBuffer", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPersistBuffer);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPersistBuffer", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageCount;
#pragma warning disable 0169
		static Delegate GetGetMessageCountHandler ()
		{
			if (cb_getMessageCount == null)
				cb_getMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMessageCount);
			return cb_getMessageCount;
		}

		static int n_GetMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageCount;
		public virtual unsafe int MessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='getMessageCount' and count(parameter)=0]"
			[Register ("getMessageCount", "()I", "GetGetMessageCountHandler")]
			get {
				if (id_getMessageCount == IntPtr.Zero)
					id_getMessageCount = JNIEnv.GetMethodID (class_ref, "getMessageCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMessageCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_deleteMessage_I;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_IHandler ()
		{
			if (cb_deleteMessage_I == null)
				cb_deleteMessage_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_DeleteMessage_I);
			return cb_deleteMessage_I;
		}

		static void n_DeleteMessage_I (IntPtr jnienv, IntPtr native__this, int messageIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (messageIndex);
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("deleteMessage", "(I)V", "GetDeleteMessage_IHandler")]
		public virtual unsafe void DeleteMessage (int messageIndex)
		{
			if (id_deleteMessage_I == IntPtr.Zero)
				id_deleteMessage_I = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (messageIndex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getMessage_I;
#pragma warning disable 0169
		static Delegate GetGetMessage_IHandler ()
		{
			if (cb_getMessage_I == null)
				cb_getMessage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMessage_I);
			return cb_getMessage_I;
		}

		static IntPtr n_GetMessage_I (IntPtr jnienv, IntPtr native__this, int messageIndex)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMessage (messageIndex));
		}
#pragma warning restore 0169

		static IntPtr id_getMessage_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMessage", "(I)Lorg/eclipse/paho/client/mqttv3/BufferedMessage;", "GetGetMessage_IHandler")]
		public virtual unsafe global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage GetMessage (int messageIndex)
		{
			if (id_getMessage_I == IntPtr.Zero)
				id_getMessage_I = JNIEnv.GetMethodID (class_ref, "getMessage", "(I)Lorg/eclipse/paho/client/mqttv3/BufferedMessage;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (messageIndex);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.BufferedMessage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "(I)Lorg/eclipse/paho/client/mqttv3/BufferedMessage;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
#pragma warning disable 0169
		static Delegate GetPutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler ()
		{
			if (cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == null)
				cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_);
			return cb_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		}

		static void n_PutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_token)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken> (native_token, JniHandleOwnership.DoNotTransfer);
			__this.PutMessage (message, token);
		}
#pragma warning restore 0169

		static IntPtr id_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='putMessage' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage'] and parameter[2][@type='org.eclipse.paho.client.mqttv3.MqttToken']]"
		[Register ("putMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V", "GetPutMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_Handler")]
		public virtual unsafe void PutMessage (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message, global::Org.Eclipse.Paho.Client.Mqttv3.MqttToken token)
		{
			if (id_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ == IntPtr.Zero)
				id_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_ = JNIEnv.GetMethodID (class_ref, "putMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (message);
				__args [1] = new JValue (token);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putMessage_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Lorg_eclipse_paho_client_mqttv3_MqttToken_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMessage", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;Lorg/eclipse/paho/client/mqttv3/MqttToken;)V"), __args);
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='run' and count(parameter)=0]"
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

		static Delegate cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_;
#pragma warning disable 0169
		static Delegate GetSetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_Handler ()
		{
			if (cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ == null)
				cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_);
			return cb_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_;
		}

		static void n_SetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.DisconnectedMessageBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback @callback = (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback)global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.SetPublishCallback (@callback);
		}
#pragma warning restore 0169

		static IntPtr id_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal']/class[@name='DisconnectedMessageBuffer']/method[@name='setPublishCallback' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.IDisconnectedBufferCallback']]"
		[Register ("setPublishCallback", "(Lorg/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback;)V", "GetSetPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_Handler")]
		public virtual unsafe void SetPublishCallback (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.IDisconnectedBufferCallback @callback)
		{
			if (id_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ == IntPtr.Zero)
				id_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_ = JNIEnv.GetMethodID (class_ref, "setPublishCallback", "(Lorg/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (@callback);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPublishCallback_Lorg_eclipse_paho_client_mqttv3_internal_IDisconnectedBufferCallback_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPublishCallback", "(Lorg/eclipse/paho/client/mqttv3/internal/IDisconnectedBufferCallback;)V"), __args);
			} finally {
			}
		}

	}
}
