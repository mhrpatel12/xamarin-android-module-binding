using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPubRel']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPubRel", DoNotGenerateAcw=true)]
	public partial class MqttPubRel : global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPersistableWireMessage {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MqttPubRel", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttPubRel); }
		}

		protected MqttPubRel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPubRel']/constructor[@name='MqttPubRel' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte[]']]"
		[Register (".ctor", "(B[B)V", "")]
		public unsafe MqttPubRel (sbyte info, byte[] data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (info);
				__args [1] = new JValue (native_data);
				if (((object) this).GetType () != typeof (MqttPubRel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(B[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(B[B)V", __args);
					return;
				}

				if (id_ctor_BarrayB == IntPtr.Zero)
					id_ctor_BarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(B[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_BarrayB, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static IntPtr id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPubRec_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPubRel']/constructor[@name='MqttPubRel' and count(parameter)=1 and parameter[1][@type='org.eclipse.paho.client.mqttv3.internal.wire.MqttPubRec']]"
		[Register (".ctor", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPubRec;)V", "")]
		public unsafe MqttPubRel (global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPubRec pubRec)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pubRec);
				if (((object) this).GetType () != typeof (MqttPubRel)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPubRec;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPubRec;)V", __args);
					return;
				}

				if (id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPubRec_ == IntPtr.Zero)
					id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPubRec_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/eclipse/paho/client/mqttv3/internal/wire/MqttPubRec;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPubRec_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_eclipse_paho_client_mqttv3_internal_wire_MqttPubRec_, __args);
			} finally {
			}
		}

		static Delegate cb_getMessageInfo;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoHandler ()
		{
			if (cb_getMessageInfo == null)
				cb_getMessageInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetMessageInfo);
			return cb_getMessageInfo;
		}

		static sbyte n_GetMessageInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPubRel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPubRel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MessageInfo;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageInfo;
		protected override unsafe sbyte MessageInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPubRel']/method[@name='getMessageInfo' and count(parameter)=0]"
			[Register ("getMessageInfo", "()B", "GetGetMessageInfoHandler")]
			get {
				if (id_getMessageInfo == IntPtr.Zero)
					id_getMessageInfo = JNIEnv.GetMethodID (class_ref, "getMessageInfo", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getMessageInfo);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageInfo", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getVariableHeader;
#pragma warning disable 0169
		static Delegate GetGetVariableHeaderHandler ()
		{
			if (cb_getVariableHeader == null)
				cb_getVariableHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVariableHeader);
			return cb_getVariableHeader;
		}

		static IntPtr n_GetVariableHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPubRel __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MqttPubRel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetVariableHeader ());
		}
#pragma warning restore 0169

		static IntPtr id_getVariableHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MqttPubRel']/method[@name='getVariableHeader' and count(parameter)=0]"
		[Register ("getVariableHeader", "()[B", "GetGetVariableHeaderHandler")]
		protected override unsafe byte[] GetVariableHeader ()
		{
			if (id_getVariableHeader == IntPtr.Zero)
				id_getVariableHeader = JNIEnv.GetMethodID (class_ref, "getVariableHeader", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVariableHeader), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVariableHeader", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
