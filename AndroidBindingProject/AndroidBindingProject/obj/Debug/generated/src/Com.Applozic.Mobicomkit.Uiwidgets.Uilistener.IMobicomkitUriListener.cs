using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Uilistener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.uilistener']/interface[@name='MobicomkitUriListener']"
	[Register ("com/applozic/mobicomkit/uiwidgets/uilistener/MobicomkitUriListener", "", "Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListenerInvoker")]
	public partial interface IMobicomkitUriListener : IJavaObject {

		global::Android.Net.Uri CurrentImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.uilistener']/interface[@name='MobicomkitUriListener']/method[@name='getCurrentImageUri' and count(parameter)=0]"
			[Register ("getCurrentImageUri", "()Landroid/net/Uri;", "GetGetCurrentImageUriHandler:Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListenerInvoker, AndroidBindingProject")] get;
		}

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/uilistener/MobicomkitUriListener", DoNotGenerateAcw=true)]
	internal class IMobicomkitUriListenerInvoker : global::Java.Lang.Object, IMobicomkitUriListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/uilistener/MobicomkitUriListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMobicomkitUriListenerInvoker); }
		}

		IntPtr class_ref;

		public static IMobicomkitUriListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMobicomkitUriListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.uiwidgets.uilistener.MobicomkitUriListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMobicomkitUriListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCurrentImageUri;
#pragma warning disable 0169
		static Delegate GetGetCurrentImageUriHandler ()
		{
			if (cb_getCurrentImageUri == null)
				cb_getCurrentImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentImageUri);
			return cb_getCurrentImageUri;
		}

		static IntPtr n_GetCurrentImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IMobicomkitUriListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentImageUri);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentImageUri;
		public unsafe global::Android.Net.Uri CurrentImageUri {
			get {
				if (id_getCurrentImageUri == IntPtr.Zero)
					id_getCurrentImageUri = JNIEnv.GetMethodID (class_ref, "getCurrentImageUri", "()Landroid/net/Uri;");
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentImageUri), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
