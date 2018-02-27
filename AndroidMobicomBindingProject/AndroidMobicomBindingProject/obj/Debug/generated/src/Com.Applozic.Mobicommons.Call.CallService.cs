using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Call {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.call']/class[@name='CallService']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/call/CallService", DoNotGenerateAcw=true)]
	public partial class CallService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/call/CallService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CallService); }
		}

		protected CallService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.call']/class[@name='CallService']/constructor[@name='CallService' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallService ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CallService)) {
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

		static IntPtr id_cancelCall_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.call']/class[@name='CallService']/method[@name='cancelCall' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("cancelCall", "(Landroid/content/Context;)V", "")]
		public static unsafe void CancelCall (global::Android.Content.Context p0)
		{
			if (id_cancelCall_Landroid_content_Context_ == IntPtr.Zero)
				id_cancelCall_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "cancelCall", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelCall_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
