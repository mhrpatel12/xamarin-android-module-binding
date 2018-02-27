using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttOutputStream", DoNotGenerateAcw=true)]
	public partial class MqttOutputStream : global::Java.IO.OutputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttOutputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttOutputStream); }
		}

		protected MqttOutputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_OutputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/constructor[@name='MqttOutputStream' and count(parameter)=2 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.ClientState'] and parameter[2][@type='java.io.OutputStream']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V", "")]
		public unsafe MqttOutputStream (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.ClientState clientState, global::System.IO.Stream @out)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native__out = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (@out);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (clientState);
				__args [1] = new JValue (native__out);
				if (((object) this).GetType () != typeof (MqttOutputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_OutputStream_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_OutputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/ClientState;Ljava/io/OutputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_OutputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_ClientState_Ljava_io_OutputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__out);
			}
		}

		static Delegate cb_write_I;
#pragma warning disable 0169
		static Delegate GetWrite_IHandler ()
		{
			if (cb_write_I == null)
				cb_write_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Write_I);
			return cb_write_I;
		}

		static void n_Write_I (IntPtr jnienv, IntPtr native__this, int b)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Write (b);
		}
#pragma warning restore 0169

		static IntPtr id_write_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("write", "(I)V", "GetWrite_IHandler")]
		public override unsafe void Write (int b)
		{
			if (id_write_I == IntPtr.Zero)
				id_write_I = JNIEnv.GetMethodID (class_ref, "write", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (b);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
#pragma warning disable 0169
		static Delegate GetWrite_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler ()
		{
			if (cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == null)
				cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_);
			return cb_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		}

		static void n_Write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttOutputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage> (native_message, JniHandleOwnership.DoNotTransfer);
			__this.Write (message);
		}
#pragma warning restore 0169

		static IntPtr id_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttOutputStream']/method[@name='write' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttWireMessage']]"
		[Register ("write", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V", "GetWrite_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_Handler")]
		public virtual unsafe void Write (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttWireMessage message)
		{
			if (id_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ == IntPtr.Zero)
				id_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_ = JNIEnv.GetMethodID (class_ref, "write", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (message);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttWireMessage_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttWireMessage;)V"), __args);
			} finally {
			}
		}

	}
}
