using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='ContactService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/contact/ContactService", DoNotGenerateAcw=true)]
	public partial class ContactService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/contact/ContactService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactService); }
		}

		protected ContactService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='ContactService']/constructor[@name='ContactService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ContactService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ContactService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_vCard_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetVCard_Landroid_net_Uri_Handler ()
		{
			if (cb_vCard_Landroid_net_Uri_ == null)
				cb_vCard_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_VCard_Landroid_net_Uri_);
			return cb_vCard_Landroid_net_Uri_;
		}

		static IntPtr n_VCard_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.ContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.ContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.VCard (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_vCard_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='ContactService']/method[@name='vCard' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("vCard", "(Landroid/net/Uri;)Ljava/io/File;", "GetVCard_Landroid_net_Uri_Handler")]
		public virtual unsafe global::Java.IO.File VCard (global::Android.Net.Uri p0)
		{
			if (id_vCard_Landroid_net_Uri_ == IntPtr.Zero)
				id_vCard_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "vCard", "(Landroid/net/Uri;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.IO.File __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_vCard_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "vCard", "(Landroid/net/Uri;)Ljava/io/File;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
