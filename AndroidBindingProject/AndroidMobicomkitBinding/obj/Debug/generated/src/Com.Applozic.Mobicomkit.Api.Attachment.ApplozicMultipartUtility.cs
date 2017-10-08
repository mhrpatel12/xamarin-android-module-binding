using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='ApplozicMultipartUtility']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/ApplozicMultipartUtility", DoNotGenerateAcw=true)]
	public partial class ApplozicMultipartUtility : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/ApplozicMultipartUtility", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicMultipartUtility); }
		}

		protected ApplozicMultipartUtility (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='ApplozicMultipartUtility']/constructor[@name='ApplozicMultipartUtility' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", "")]
		public unsafe ApplozicMultipartUtility (string p0, string p1, global::Android.Content.Context p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ApplozicMultipartUtility)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.ApplozicMultipartUtility __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.ApplozicMultipartUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe string Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='ApplozicMultipartUtility']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/String;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFilePart_Ljava_lang_String_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetAddFilePart_Ljava_lang_String_Ljava_io_File_Handler ()
		{
			if (cb_addFilePart_Ljava_lang_String_Ljava_io_File_ == null)
				cb_addFilePart_Ljava_lang_String_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddFilePart_Ljava_lang_String_Ljava_io_File_);
			return cb_addFilePart_Ljava_lang_String_Ljava_io_File_;
		}

		static void n_AddFilePart_Ljava_lang_String_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.ApplozicMultipartUtility __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.ApplozicMultipartUtility> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p1 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddFilePart (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addFilePart_Ljava_lang_String_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='ApplozicMultipartUtility']/method[@name='addFilePart' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("addFilePart", "(Ljava/lang/String;Ljava/io/File;)V", "GetAddFilePart_Ljava_lang_String_Ljava_io_File_Handler")]
		public virtual unsafe void AddFilePart (string p0, global::Java.IO.File p1)
		{
			if (id_addFilePart_Ljava_lang_String_Ljava_io_File_ == IntPtr.Zero)
				id_addFilePart_Ljava_lang_String_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "addFilePart", "(Ljava/lang/String;Ljava/io/File;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFilePart_Ljava_lang_String_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFilePart", "(Ljava/lang/String;Ljava/io/File;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
