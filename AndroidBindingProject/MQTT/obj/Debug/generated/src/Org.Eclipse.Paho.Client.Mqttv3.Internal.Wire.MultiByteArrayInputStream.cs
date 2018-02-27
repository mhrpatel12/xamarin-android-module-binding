using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteArrayInputStream", DoNotGenerateAcw=true)]
	public partial class MultiByteArrayInputStream : global::Java.IO.InputStream {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/wire/MultiByteArrayInputStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MultiByteArrayInputStream); }
		}

		protected MultiByteArrayInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBIIarrayBII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']/constructor[@name='MultiByteArrayInputStream' and count(parameter)=6 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register (".ctor", "([BII[BII)V", "")]
		public unsafe MultiByteArrayInputStream (byte[] bytesA, int offsetA, int lengthA, byte[] bytesB, int offsetB, int lengthB)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_bytesA = JNIEnv.NewArray (bytesA);
			IntPtr native_bytesB = JNIEnv.NewArray (bytesB);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_bytesA);
				__args [1] = new JValue (offsetA);
				__args [2] = new JValue (lengthA);
				__args [3] = new JValue (native_bytesB);
				__args [4] = new JValue (offsetB);
				__args [5] = new JValue (lengthB);
				if (((object) this).GetType () != typeof (MultiByteArrayInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BII[BII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BII[BII)V", __args);
					return;
				}

				if (id_ctor_arrayBIIarrayBII == IntPtr.Zero)
					id_ctor_arrayBIIarrayBII = JNIEnv.GetMethodID (class_ref, "<init>", "([BII[BII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBIIarrayBII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBIIarrayBII, __args);
			} finally {
				if (bytesA != null) {
					JNIEnv.CopyArray (native_bytesA, bytesA);
					JNIEnv.DeleteLocalRef (native_bytesA);
				}
				if (bytesB != null) {
					JNIEnv.CopyArray (native_bytesB, bytesB);
					JNIEnv.DeleteLocalRef (native_bytesB);
				}
			}
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteArrayInputStream __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Wire.MultiByteArrayInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.wire']/class[@name='MultiByteArrayInputStream']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		public override unsafe int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			} finally {
			}
		}

	}
}
