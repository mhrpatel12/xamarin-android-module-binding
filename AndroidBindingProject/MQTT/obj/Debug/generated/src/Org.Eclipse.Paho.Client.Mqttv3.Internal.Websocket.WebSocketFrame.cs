using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']"
	[global::Android.Runtime.Register ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketFrame", DoNotGenerateAcw=true)]
	public partial class WebSocketFrame : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/field[@name='frameLengthOverhead']"
		[Register ("frameLengthOverhead")]
		public const int FrameLengthOverhead = (int) 6;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/eclipse/paho/client/mqttv3/internal/websocket/WebSocketFrame", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WebSocketFrame); }
		}

		protected WebSocketFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_BZarrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=3 and parameter[1][@type='byte'] and parameter[2][@type='boolean'] and parameter[3][@type='byte[]']]"
		[Register (".ctor", "(BZ[B)V", "")]
		public unsafe WebSocketFrame (sbyte opcode, bool fin, byte[] payload)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_payload = JNIEnv.NewArray (payload);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (opcode);
				__args [1] = new JValue (fin);
				__args [2] = new JValue (native_payload);
				if (((object) this).GetType () != typeof (WebSocketFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(BZ[B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(BZ[B)V", __args);
					return;
				}

				if (id_ctor_BZarrayB == IntPtr.Zero)
					id_ctor_BZarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(BZ[B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_BZarrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_BZarrayB, __args);
			} finally {
				if (payload != null) {
					JNIEnv.CopyArray (native_payload, payload);
					JNIEnv.DeleteLocalRef (native_payload);
				}
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe WebSocketFrame (byte[] rawFrame)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_rawFrame = JNIEnv.NewArray (rawFrame);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_rawFrame);
				if (((object) this).GetType () != typeof (WebSocketFrame)) {
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
				if (rawFrame != null) {
					JNIEnv.CopyArray (native_rawFrame, rawFrame);
					JNIEnv.DeleteLocalRef (native_rawFrame);
				}
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/constructor[@name='WebSocketFrame' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe WebSocketFrame (global::System.IO.Stream input)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);
				if (((object) this).GetType () != typeof (WebSocketFrame)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_isCloseFlag;
#pragma warning disable 0169
		static Delegate GetIsCloseFlagHandler ()
		{
			if (cb_isCloseFlag == null)
				cb_isCloseFlag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCloseFlag);
			return cb_isCloseFlag;
		}

		static bool n_IsCloseFlag (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCloseFlag;
		}
#pragma warning restore 0169

		static IntPtr id_isCloseFlag;
		public virtual unsafe bool IsCloseFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='isCloseFlag' and count(parameter)=0]"
			[Register ("isCloseFlag", "()Z", "GetIsCloseFlagHandler")]
			get {
				if (id_isCloseFlag == IntPtr.Zero)
					id_isCloseFlag = JNIEnv.GetMethodID (class_ref, "isCloseFlag", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCloseFlag);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCloseFlag", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFin;
#pragma warning disable 0169
		static Delegate GetIsFinHandler ()
		{
			if (cb_isFin == null)
				cb_isFin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFin);
			return cb_isFin;
		}

		static bool n_IsFin (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFin;
		}
#pragma warning restore 0169

		static IntPtr id_isFin;
		public virtual unsafe bool IsFin {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='isFin' and count(parameter)=0]"
			[Register ("isFin", "()Z", "GetIsFinHandler")]
			get {
				if (id_isFin == IntPtr.Zero)
					id_isFin = JNIEnv.GetMethodID (class_ref, "isFin", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFin);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFin", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOpcode;
#pragma warning disable 0169
		static Delegate GetGetOpcodeHandler ()
		{
			if (cb_getOpcode == null)
				cb_getOpcode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetOpcode);
			return cb_getOpcode;
		}

		static sbyte n_GetOpcode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Opcode;
		}
#pragma warning restore 0169

		static IntPtr id_getOpcode;
		public virtual unsafe sbyte Opcode {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='getOpcode' and count(parameter)=0]"
			[Register ("getOpcode", "()B", "GetGetOpcodeHandler")]
			get {
				if (id_getOpcode == IntPtr.Zero)
					id_getOpcode = JNIEnv.GetMethodID (class_ref, "getOpcode", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getOpcode);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOpcode", "()B"));
				} finally {
				}
			}
		}

		static IntPtr id_appendFinAndOpCode_Ljava_nio_ByteBuffer_BZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='appendFinAndOpCode' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte'] and parameter[3][@type='boolean']]"
		[Register ("appendFinAndOpCode", "(Ljava/nio/ByteBuffer;BZ)V", "")]
		public static unsafe void AppendFinAndOpCode (global::Java.Nio.ByteBuffer buffer, sbyte opcode, bool fin)
		{
			if (id_appendFinAndOpCode_Ljava_nio_ByteBuffer_BZ == IntPtr.Zero)
				id_appendFinAndOpCode_Ljava_nio_ByteBuffer_BZ = JNIEnv.GetStaticMethodID (class_ref, "appendFinAndOpCode", "(Ljava/nio/ByteBuffer;BZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (opcode);
				__args [2] = new JValue (fin);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_appendFinAndOpCode_Ljava_nio_ByteBuffer_BZ, __args);
			} finally {
			}
		}

		static IntPtr id_appendLengthAndMask_Ljava_nio_ByteBuffer_IarrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='appendLengthAndMask' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("appendLengthAndMask", "(Ljava/nio/ByteBuffer;I[B)V", "")]
		public static unsafe void AppendLengthAndMask (global::Java.Nio.ByteBuffer buffer, int length, byte[] mask)
		{
			if (id_appendLengthAndMask_Ljava_nio_ByteBuffer_IarrayB == IntPtr.Zero)
				id_appendLengthAndMask_Ljava_nio_ByteBuffer_IarrayB = JNIEnv.GetStaticMethodID (class_ref, "appendLengthAndMask", "(Ljava/nio/ByteBuffer;I[B)V");
			IntPtr native_mask = JNIEnv.NewArray (mask);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (buffer);
				__args [1] = new JValue (length);
				__args [2] = new JValue (native_mask);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_appendLengthAndMask_Ljava_nio_ByteBuffer_IarrayB, __args);
			} finally {
				if (mask != null) {
					JNIEnv.CopyArray (native_mask, mask);
					JNIEnv.DeleteLocalRef (native_mask);
				}
			}
		}

		static Delegate cb_encodeFrame;
#pragma warning disable 0169
		static Delegate GetEncodeFrameHandler ()
		{
			if (cb_encodeFrame == null)
				cb_encodeFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EncodeFrame);
			return cb_encodeFrame;
		}

		static IntPtr n_EncodeFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.EncodeFrame ());
		}
#pragma warning restore 0169

		static IntPtr id_encodeFrame;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='encodeFrame' and count(parameter)=0]"
		[Register ("encodeFrame", "()[B", "GetEncodeFrameHandler")]
		public virtual unsafe byte[] EncodeFrame ()
		{
			if (id_encodeFrame == IntPtr.Zero)
				id_encodeFrame = JNIEnv.GetMethodID (class_ref, "encodeFrame", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encodeFrame), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encodeFrame", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_generateMaskingKey;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='generateMaskingKey' and count(parameter)=0]"
		[Register ("generateMaskingKey", "()[B", "")]
		public static unsafe byte[] GenerateMaskingKey ()
		{
			if (id_generateMaskingKey == IntPtr.Zero)
				id_generateMaskingKey = JNIEnv.GetStaticMethodID (class_ref, "generateMaskingKey", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_generateMaskingKey), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame __this = global::Java.Lang.Object.GetObject<global::Org.Eclipse.Paho.Client.Mqttv3.Internal.Websocket.WebSocketFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPayload ());
		}
#pragma warning restore 0169

		static IntPtr id_getPayload;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.eclipse.paho.client.mqttv3.internal.websocket']/class[@name='WebSocketFrame']/method[@name='getPayload' and count(parameter)=0]"
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

	}
}
