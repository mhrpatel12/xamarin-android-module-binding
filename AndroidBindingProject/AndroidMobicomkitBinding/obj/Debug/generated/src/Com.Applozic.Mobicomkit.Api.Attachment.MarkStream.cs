using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/MarkStream", DoNotGenerateAcw=true)]
	public partial class MarkStream : global::Java.IO.InputStream {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/MarkStream", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkStream); }
		}

		protected MarkStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_InputStream_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/constructor[@name='MarkStream' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/io/InputStream;I)V", "")]
		public unsafe MarkStream (global::System.IO.Stream p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MarkStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/InputStream;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/InputStream;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_I == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_InputStream_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_io_InputStream_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/constructor[@name='MarkStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe MarkStream (global::System.IO.Stream p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (MarkStream)) {
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
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_allowMarksToExpire_Z;
#pragma warning disable 0169
		static Delegate GetAllowMarksToExpire_ZHandler ()
		{
			if (cb_allowMarksToExpire_Z == null)
				cb_allowMarksToExpire_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_AllowMarksToExpire_Z);
			return cb_allowMarksToExpire_Z;
		}

		static void n_AllowMarksToExpire_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AllowMarksToExpire (p0);
		}
#pragma warning restore 0169

		static IntPtr id_allowMarksToExpire_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/method[@name='allowMarksToExpire' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("allowMarksToExpire", "(Z)V", "GetAllowMarksToExpire_ZHandler")]
		public virtual unsafe void AllowMarksToExpire (bool p0)
		{
			if (id_allowMarksToExpire_Z == IntPtr.Zero)
				id_allowMarksToExpire_Z = JNIEnv.GetMethodID (class_ref, "allowMarksToExpire", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_allowMarksToExpire_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "allowMarksToExpire", "(Z)V"), __args);
			} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/method[@name='read' and count(parameter)=0]"
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

		static Delegate cb_resetPos_J;
#pragma warning disable 0169
		static Delegate GetResetPos_JHandler ()
		{
			if (cb_resetPos_J == null)
				cb_resetPos_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_ResetPos_J);
			return cb_resetPos_J;
		}

		static void n_ResetPos_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetPos (p0);
		}
#pragma warning restore 0169

		static IntPtr id_resetPos_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/method[@name='resetPos' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("resetPos", "(J)V", "GetResetPos_JHandler")]
		public virtual unsafe void ResetPos (long p0)
		{
			if (id_resetPos_J == IntPtr.Zero)
				id_resetPos_J = JNIEnv.GetMethodID (class_ref, "resetPos", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetPos_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetPos", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPos_I;
#pragma warning disable 0169
		static Delegate GetSetPos_IHandler ()
		{
			if (cb_setPos_I == null)
				cb_setPos_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_SetPos_I);
			return cb_setPos_I;
		}

		static long n_SetPos_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.MarkStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetPos (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPos_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='MarkStream']/method[@name='setPos' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPos", "(I)J", "GetSetPos_IHandler")]
		public virtual unsafe long SetPos (int p0)
		{
			if (id_setPos_I == IntPtr.Zero)
				id_setPos_I = JNIEnv.GetMethodID (class_ref, "setPos", "(I)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_setPos_I, __args);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPos", "(I)J"), __args);
			} finally {
			}
		}

	}
}
