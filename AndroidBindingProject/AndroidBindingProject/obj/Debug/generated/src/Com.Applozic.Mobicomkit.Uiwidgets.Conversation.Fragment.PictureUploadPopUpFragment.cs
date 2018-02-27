using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/PictureUploadPopUpFragment", DoNotGenerateAcw=true)]
	public partial class PictureUploadPopUpFragment : global::Android.Support.V4.App.DialogFragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']/field[@name='REMOVE_OPTION']"
		[Register ("REMOVE_OPTION")]
		public const string RemoveOption = (string) "REMOVE_OPTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']/field[@name='REMOVE_PHOTO']"
		[Register ("REMOVE_PHOTO")]
		public const string RemovePhoto = (string) "REMOVE_PHOTO";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/fragment/PictureUploadPopUpFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PictureUploadPopUpFragment); }
		}

		protected PictureUploadPopUpFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']/constructor[@name='PictureUploadPopUpFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PictureUploadPopUpFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PictureUploadPopUpFragment)) {
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

		static Delegate cb_imageCapture;
#pragma warning disable 0169
		static Delegate GetImageCaptureHandler ()
		{
			if (cb_imageCapture == null)
				cb_imageCapture = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ImageCapture);
			return cb_imageCapture;
		}

		static void n_ImageCapture (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.PictureUploadPopUpFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.PictureUploadPopUpFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ImageCapture ();
		}
#pragma warning restore 0169

		static IntPtr id_imageCapture;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']/method[@name='imageCapture' and count(parameter)=0]"
		[Register ("imageCapture", "()V", "GetImageCaptureHandler")]
		public virtual unsafe void ImageCapture ()
		{
			if (id_imageCapture == IntPtr.Zero)
				id_imageCapture = JNIEnv.GetMethodID (class_ref, "imageCapture", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_imageCapture);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "imageCapture", "()V"));
			} finally {
			}
		}

		static IntPtr id_newInstance_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.fragment']/class[@name='PictureUploadPopUpFragment']/method[@name='newInstance' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='boolean']]"
		[Register ("newInstance", "(ZZ)Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/PictureUploadPopUpFragment;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.PictureUploadPopUpFragment NewInstance (bool p0, bool p1)
		{
			if (id_newInstance_ZZ == IntPtr.Zero)
				id_newInstance_ZZ = JNIEnv.GetStaticMethodID (class_ref, "newInstance", "(ZZ)Lcom/applozic/mobicomkit/uiwidgets/conversation/fragment/PictureUploadPopUpFragment;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Fragment.PictureUploadPopUpFragment> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newInstance_ZZ, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
