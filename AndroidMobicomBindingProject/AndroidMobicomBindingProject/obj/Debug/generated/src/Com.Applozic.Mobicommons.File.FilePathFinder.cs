using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.File {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/file/FilePathFinder", DoNotGenerateAcw=true)]
	public partial class FilePathFinder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/file/FilePathFinder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FilePathFinder); }
		}

		protected FilePathFinder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/constructor[@name='FilePathFinder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FilePathFinder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FilePathFinder)) {
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

		static IntPtr id_getDataColumn_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='getDataColumn' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("getDataColumn", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetDataColumn (global::Android.Content.Context p0, global::Android.Net.Uri p1, string p2, string[] p3)
		{
			if (id_getDataColumn_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getDataColumn_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getDataColumn", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDataColumn_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		static IntPtr id_getPath_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='getPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getPath", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetPath (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getPath_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getPath_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getPath", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPath_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDownloadsDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='isDownloadsDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isDownloadsDocument", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsDownloadsDocument (global::Android.Net.Uri p0)
		{
			if (id_isDownloadsDocument_Landroid_net_Uri_ == IntPtr.Zero)
				id_isDownloadsDocument_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isDownloadsDocument", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDownloadsDocument_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isExternalStorageDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='isExternalStorageDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isExternalStorageDocument", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsExternalStorageDocument (global::Android.Net.Uri p0)
		{
			if (id_isExternalStorageDocument_Landroid_net_Uri_ == IntPtr.Zero)
				id_isExternalStorageDocument_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isExternalStorageDocument", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isExternalStorageDocument_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMediaDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='isMediaDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isMediaDocument", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsMediaDocument (global::Android.Net.Uri p0)
		{
			if (id_isMediaDocument_Landroid_net_Uri_ == IntPtr.Zero)
				id_isMediaDocument_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isMediaDocument", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMediaDocument_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetMf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_Handler ()
		{
			if (cb_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_ == null)
				cb_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_);
			return cb_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_;
		}

		static IntPtr n_Mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.File.FilePathFinder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.File.FilePathFinder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Mf_szGetRealPathFromURI (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FilePathFinder']/method[@name='mf_szGetRealPathFromURI' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("mf_szGetRealPathFromURI", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "GetMf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_Handler")]
		public virtual unsafe string Mf_szGetRealPathFromURI (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "mf_szGetRealPathFromURI", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_mf_szGetRealPathFromURI_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "mf_szGetRealPathFromURI", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
