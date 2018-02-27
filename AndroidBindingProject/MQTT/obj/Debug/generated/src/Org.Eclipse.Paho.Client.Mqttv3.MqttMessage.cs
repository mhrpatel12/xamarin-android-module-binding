using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3 {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/MqttMessage", DoNotGenerateAcw=true)]
	public partial class MqttMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/MqttMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MqttMessage); }
		}

		protected MqttMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MqttMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MqttMessage)) {
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

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/constructor[@name='MqttMessage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe MqttMessage (byte[] payload)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_payload);
				if (((object) this).GetType () != typeof (MqttMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		static Delegate cb_setId_I;
#pragma warning disable 0169
		static Delegate GetSetId_IHandler ()
		{
			if (cb_setId_I == null)
				cb_setId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetId_I);
			return cb_setId_I;
		}

		static void n_SetId_I (IntPtr jnienv, IntPtr native__this, int messageId)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Id = messageId;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_I;
		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setId", "(I)V", "GetSetId_IHandler")]
			set {
				if (id_setId_I == IntPtr.Zero)
					id_setId_I = JNIEnv.GetMethodID (class_ref, "setId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDuplicate;
#pragma warning disable 0169
		static Delegate GetIsDuplicateHandler ()
		{
			if (cb_isDuplicate == null)
				cb_isDuplicate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDuplicate);
			return cb_isDuplicate;
		}

		static bool n_IsDuplicate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDuplicate;
		}
#pragma warning restore 0169

		static IntPtr id_isDuplicate;
		public virtual unsafe bool IsDuplicate {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isDuplicate' and count(parameter)=0]"
			[Register ("isDuplicate", "()Z", "GetIsDuplicateHandler")]
			get {
				if (id_isDuplicate == IntPtr.Zero)
					id_isDuplicate = JNIEnv.GetMethodID (class_ref, "isDuplicate", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDuplicate);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDuplicate", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getQos;
#pragma warning disable 0169
		static Delegate GetGetQosHandler ()
		{
			if (cb_getQos == null)
				cb_getQos = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetQos);
			return cb_getQos;
		}

		static int n_GetQos (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Qos;
		}
#pragma warning restore 0169

		static Delegate cb_setQos_I;
#pragma warning disable 0169
		static Delegate GetSetQos_IHandler ()
		{
			if (cb_setQos_I == null)
				cb_setQos_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetQos_I);
			return cb_setQos_I;
		}

		static void n_SetQos_I (IntPtr jnienv, IntPtr native__this, int qos)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Qos = qos;
		}
#pragma warning restore 0169

		static IntPtr id_getQos;
		static IntPtr id_setQos_I;
		public virtual unsafe int Qos {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getQos' and count(parameter)=0]"
			[Register ("getQos", "()I", "GetGetQosHandler")]
			get {
				if (id_getQos == IntPtr.Zero)
					id_getQos = JNIEnv.GetMethodID (class_ref, "getQos", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getQos);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getQos", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setQos' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setQos", "(I)V", "GetSetQos_IHandler")]
			set {
				if (id_setQos_I == IntPtr.Zero)
					id_setQos_I = JNIEnv.GetMethodID (class_ref, "setQos", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQos_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQos", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRetained;
#pragma warning disable 0169
		static Delegate GetIsRetainedHandler ()
		{
			if (cb_isRetained == null)
				cb_isRetained = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRetained);
			return cb_isRetained;
		}

		static bool n_IsRetained (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Retained;
		}
#pragma warning restore 0169

		static Delegate cb_setRetained_Z;
#pragma warning disable 0169
		static Delegate GetSetRetained_ZHandler ()
		{
			if (cb_setRetained_Z == null)
				cb_setRetained_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRetained_Z);
			return cb_setRetained_Z;
		}

		static void n_SetRetained_Z (IntPtr jnienv, IntPtr native__this, bool retained)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Retained = retained;
		}
#pragma warning restore 0169

		static IntPtr id_isRetained;
		static IntPtr id_setRetained_Z;
		public virtual unsafe bool Retained {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='isRetained' and count(parameter)=0]"
			[Register ("isRetained", "()Z", "GetIsRetainedHandler")]
			get {
				if (id_isRetained == IntPtr.Zero)
					id_isRetained = JNIEnv.GetMethodID (class_ref, "isRetained", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRetained);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRetained", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setRetained' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRetained", "(Z)V", "GetSetRetained_ZHandler")]
			set {
				if (id_setRetained_Z == IntPtr.Zero)
					id_setRetained_Z = JNIEnv.GetMethodID (class_ref, "setRetained", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRetained_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetained", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkMutable;
#pragma warning disable 0169
		static Delegate GetCheckMutableHandler ()
		{
			if (cb_checkMutable == null)
				cb_checkMutable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckMutable);
			return cb_checkMutable;
		}

		static void n_CheckMutable (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckMutable ();
		}
#pragma warning restore 0169

		static IntPtr id_checkMutable;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='checkMutable' and count(parameter)=0]"
		[Register ("checkMutable", "()V", "GetCheckMutableHandler")]
		protected virtual unsafe void CheckMutable ()
		{
			if (id_checkMutable == IntPtr.Zero)
				id_checkMutable = JNIEnv.GetMethodID (class_ref, "checkMutable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkMutable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkMutable", "()V"));
			} finally {
			}
		}

		static Delegate cb_clearPayload;
#pragma warning disable 0169
		static Delegate GetClearPayloadHandler ()
		{
			if (cb_clearPayload == null)
				cb_clearPayload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearPayload);
			return cb_clearPayload;
		}

		static void n_ClearPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearPayload ();
		}
#pragma warning restore 0169

		static IntPtr id_clearPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='clearPayload' and count(parameter)=0]"
		[Register ("clearPayload", "()V", "GetClearPayloadHandler")]
		public virtual unsafe void ClearPayload ()
		{
			if (id_clearPayload == IntPtr.Zero)
				id_clearPayload = JNIEnv.GetMethodID (class_ref, "clearPayload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearPayload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearPayload", "()V"));
			} finally {
			}
		}

		static Delegate cb_getPayload;
#pragma warning disable 0169
		static Delegate GetGetPayloadHandler ()
		{
			if (cb_getPayload == null)
				cb_getPayload = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPayload);
			return cb_getPayload;
		}

		static IntPtr n_GetPayload (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='getPayload' and count(parameter)=0]"
		[Register ("getPayload", "()[B", "GetGetPayloadHandler")]
		public virtual unsafe byte[] GetPayload ()
		{
			if (id_getPayload == IntPtr.Zero)
				id_getPayload = JNIEnv.GetMethodID (class_ref, "getPayload", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPayload), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPayload", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setDuplicate_Z;
#pragma warning disable 0169
		static Delegate GetSetDuplicate_ZHandler ()
		{
			if (cb_setDuplicate_Z == null)
				cb_setDuplicate_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDuplicate_Z);
			return cb_setDuplicate_Z;
		}

		static void n_SetDuplicate_Z (IntPtr jnienv, IntPtr native__this, bool dup)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuplicate (dup);
		}
#pragma warning restore 0169

		static IntPtr id_setDuplicate_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setDuplicate' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDuplicate", "(Z)V", "GetSetDuplicate_ZHandler")]
		protected virtual unsafe void SetDuplicate (bool dup)
		{
			if (id_setDuplicate_Z == IntPtr.Zero)
				id_setDuplicate_Z = JNIEnv.GetMethodID (class_ref, "setDuplicate", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (dup);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDuplicate_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDuplicate", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMutable_Z;
#pragma warning disable 0169
		static Delegate GetSetMutable_ZHandler ()
		{
			if (cb_setMutable_Z == null)
				cb_setMutable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMutable_Z);
			return cb_setMutable_Z;
		}

		static void n_SetMutable_Z (IntPtr jnienv, IntPtr native__this, bool mutable)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMutable (mutable);
		}
#pragma warning restore 0169

		static IntPtr id_setMutable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setMutable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMutable", "(Z)V", "GetSetMutable_ZHandler")]
		protected virtual unsafe void SetMutable (bool mutable)
		{
			if (id_setMutable_Z == IntPtr.Zero)
				id_setMutable_Z = JNIEnv.GetMethodID (class_ref, "setMutable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mutable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMutable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMutable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPayload_arrayB;
#pragma warning disable 0169
		static Delegate GetSetPayload_arrayBHandler ()
		{
			if (cb_setPayload_arrayB == null)
				cb_setPayload_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPayload_arrayB);
			return cb_setPayload_arrayB;
		}

		static void n_SetPayload_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.MqttMessage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] payload = (byte[]) JNIEnv.GetArray (native_payload, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetPayload (payload);
			if (payload != null)
				JNIEnv.CopyArray (payload, native_payload);
		}
#pragma warning restore 0169

		static IntPtr id_setPayload_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='setPayload' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setPayload", "([B)V", "GetSetPayload_arrayBHandler")]
		public virtual unsafe void SetPayload (byte[] payload)
		{
			if (id_setPayload_arrayB == IntPtr.Zero)
				id_setPayload_arrayB = JNIEnv.GetMethodID (class_ref, "setPayload", "([B)V");
			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_payload);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPayload_arrayB, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPayload", "([B)V"), __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static IntPtr id_validateQos_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3']/class[@name='MqttMessage']/method[@name='validateQos' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("validateQos", "(I)V", "")]
		public static unsafe void ValidateQos (int qos)
		{
			if (id_validateQos_I == IntPtr.Zero)
				id_validateQos_I = JNIEnv.GetStaticMethodID (class_ref, "validateQos", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (qos);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_validateQos_I, __args);
			} finally {
			}
		}

	}
}
