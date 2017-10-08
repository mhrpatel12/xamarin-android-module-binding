using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Image {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/image/ImageUtils", DoNotGenerateAcw=true)]
	public partial class ImageUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/image/ImageUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ImageUtils); }
		}

		protected ImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/constructor[@name='ImageUtils' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ImageUtils (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ImageUtils)) {
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

		static IntPtr id_addImageToGallery_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='addImageToGallery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("addImageToGallery", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void AddImageToGallery (string p0, global::Android.Content.Context p1)
		{
			if (id_addImageToGallery_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_addImageToGallery_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "addImageToGallery", "(Ljava/lang/String;Landroid/content/Context;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addImageToGallery_Ljava_lang_String_Landroid_content_Context_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_calculateInSampleSize_Landroid_graphics_BitmapFactory_Options_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='calculateInSampleSize' and count(parameter)=3 and parameter[1][@type='android.graphics.BitmapFactory.Options'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("calculateInSampleSize", "(Landroid/graphics/BitmapFactory$Options;II)I", "")]
		public static unsafe int CalculateInSampleSize (global::Android.Graphics.BitmapFactory.Options p0, int p1, int p2)
		{
			if (id_calculateInSampleSize_Landroid_graphics_BitmapFactory_Options_II == IntPtr.Zero)
				id_calculateInSampleSize_Landroid_graphics_BitmapFactory_Options_II = JNIEnv.GetStaticMethodID (class_ref, "calculateInSampleSize", "(Landroid/graphics/BitmapFactory$Options;II)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_calculateInSampleSize_Landroid_graphics_BitmapFactory_Options_II, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getBitMapFromLocalPath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='getBitMapFromLocalPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitMapFromLocalPath", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetBitMapFromLocalPath (string p0)
		{
			if (id_getBitMapFromLocalPath_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitMapFromLocalPath_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBitMapFromLocalPath", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBitMapFromLocalPath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getImageRotatedBitmap_Landroid_graphics_Bitmap_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='getImageRotatedBitmap' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getImageRotatedBitmap", "(Landroid/graphics/Bitmap;Ljava/lang/String;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetImageRotatedBitmap (global::Android.Graphics.Bitmap p0, string p1, int p2, int p3)
		{
			if (id_getImageRotatedBitmap_Landroid_graphics_Bitmap_Ljava_lang_String_II == IntPtr.Zero)
				id_getImageRotatedBitmap_Landroid_graphics_Bitmap_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "getImageRotatedBitmap", "(Landroid/graphics/Bitmap;Ljava/lang/String;II)Landroid/graphics/Bitmap;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageRotatedBitmap_Landroid_graphics_Bitmap_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getImageUri_Landroid_content_Context_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='getImageUri' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("getImageUri", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetImageUri (global::Android.Content.Context p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_getImageUri_Landroid_content_Context_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getImageUri_Landroid_content_Context_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "getImageUri", "(Landroid/content/Context;Landroid/graphics/Bitmap;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getImageUri_Landroid_content_Context_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLargestScreenDimension_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='getLargestScreenDimension' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getLargestScreenDimension", "(Landroid/app/Activity;)I", "")]
		public static unsafe int GetLargestScreenDimension (global::Android.App.Activity p0)
		{
			if (id_getLargestScreenDimension_Landroid_app_Activity_ == IntPtr.Zero)
				id_getLargestScreenDimension_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "getLargestScreenDimension", "(Landroid/app/Activity;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLargestScreenDimension_Landroid_app_Activity_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPreview_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='getPreview' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getPreview", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetPreview (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getPreview_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getPreview_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getPreview", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreview_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_saveImageToInternalStorage_Ljava_io_File_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.image']/class[@name='ImageUtils']/method[@name='saveImageToInternalStorage' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='android.graphics.Bitmap']]"
		[Register ("saveImageToInternalStorage", "(Ljava/io/File;Landroid/graphics/Bitmap;)Ljava/lang/String;", "")]
		public static unsafe string SaveImageToInternalStorage (global::Java.IO.File p0, global::Android.Graphics.Bitmap p1)
		{
			if (id_saveImageToInternalStorage_Ljava_io_File_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_saveImageToInternalStorage_Ljava_io_File_Landroid_graphics_Bitmap_ = JNIEnv.GetStaticMethodID (class_ref, "saveImageToInternalStorage", "(Ljava/io/File;Landroid/graphics/Bitmap;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_saveImageToInternalStorage_Ljava_io_File_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
