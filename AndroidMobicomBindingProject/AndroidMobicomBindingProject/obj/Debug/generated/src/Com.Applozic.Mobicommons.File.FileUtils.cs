using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.File {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/file/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='HIDDEN_PREFIX']"
		[Register ("HIDDEN_PREFIX")]
		public const string HiddenPrefix = (string) ".";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='MIME_TYPE_APP']"
		[Register ("MIME_TYPE_APP")]
		public const string MimeTypeApp = (string) "application/*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='MIME_TYPE_AUDIO']"
		[Register ("MIME_TYPE_AUDIO")]
		public const string MimeTypeAudio = (string) "audio/*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='MIME_TYPE_IMAGE']"
		[Register ("MIME_TYPE_IMAGE")]
		public const string MimeTypeImage = (string) "image/*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='MIME_TYPE_TEXT']"
		[Register ("MIME_TYPE_TEXT")]
		public const string MimeTypeText = (string) "text/*";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='MIME_TYPE_VIDEO']"
		[Register ("MIME_TYPE_VIDEO")]
		public const string MimeTypeVideo = (string) "video/*";

		static IntPtr sComparator_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='sComparator']"
		[Register ("sComparator")]
		public static global::Java.Util.IComparator SComparator {
			get {
				if (sComparator_jfieldId == IntPtr.Zero)
					sComparator_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sComparator", "Ljava/util/Comparator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sComparator_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sComparator_jfieldId == IntPtr.Zero)
					sComparator_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sComparator", "Ljava/util/Comparator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, sComparator_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sDirFilter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='sDirFilter']"
		[Register ("sDirFilter")]
		public static global::Java.IO.IFileFilter SDirFilter {
			get {
				if (sDirFilter_jfieldId == IntPtr.Zero)
					sDirFilter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sDirFilter", "Ljava/io/FileFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sDirFilter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.IFileFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sDirFilter_jfieldId == IntPtr.Zero)
					sDirFilter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sDirFilter", "Ljava/io/FileFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, sDirFilter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sFileFilter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/field[@name='sFileFilter']"
		[Register ("sFileFilter")]
		public static global::Java.IO.IFileFilter SFileFilter {
			get {
				if (sFileFilter_jfieldId == IntPtr.Zero)
					sFileFilter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sFileFilter", "Ljava/io/FileFilter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, sFileFilter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.IO.IFileFilter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sFileFilter_jfieldId == IntPtr.Zero)
					sFileFilter_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "sFileFilter", "Ljava/io/FileFilter;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, sFileFilter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/file/FileUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FileUtils); }
		}

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_calculateInSampleSize_Landroid_graphics_BitmapFactory_Options_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='calculateInSampleSize' and count(parameter)=3 and parameter[1][@type='android.graphics.BitmapFactory.Options'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
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

		static IntPtr id_compressImageFiles_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='compressImageFiles' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("compressImageFiles", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File CompressImageFiles (string p0, string p1, int p2)
		{
			if (id_compressImageFiles_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
				id_compressImageFiles_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "compressImageFiles", "(Ljava/lang/String;Ljava/lang/String;I)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_compressImageFiles_Ljava_lang_String_Ljava_lang_String_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_createGetContentIntent;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='createGetContentIntent' and count(parameter)=0]"
		[Register ("createGetContentIntent", "()Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent CreateGetContentIntent ()
		{
			if (id_createGetContentIntent == IntPtr.Zero)
				id_createGetContentIntent = JNIEnv.GetStaticMethodID (class_ref, "createGetContentIntent", "()Landroid/content/Intent;");
			try {
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createGetContentIntent), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDataColumn_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getDataColumn' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String[]']]"
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

		static IntPtr id_getExtension_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getExtension' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtension", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetExtension (string p0)
		{
			if (id_getExtension_Ljava_lang_String_ == IntPtr.Zero)
				id_getExtension_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getExtension", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getExtension_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFile_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getFile' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getFile", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetFile (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getFile_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getFile_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getFile", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFile_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFileFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getFileFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileFormat", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFileFormat (string p0)
		{
			if (id_getFileFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_getFileFormat_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFileFormat", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileFormat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFileName_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getFileName' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getFileName", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getFileName_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getFileName_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getFileName", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileName_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFileName_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getFileName' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("getFileName", "(Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetFileName (global::Android.Net.Uri p0)
		{
			if (id_getFileName_Landroid_net_Uri_ == IntPtr.Zero)
				id_getFileName_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getFileName", "(Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFileName_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLastModifiedFile_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getLastModifiedFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLastModifiedFile", "(Ljava/lang/String;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetLastModifiedFile (string p0)
		{
			if (id_getLastModifiedFile_Ljava_lang_String_ == IntPtr.Zero)
				id_getLastModifiedFile_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLastModifiedFile", "(Ljava/lang/String;)Ljava/io/File;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLastModifiedFile_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getMimeType_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getMimeType' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getMimeType", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetMimeType (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getMimeType_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getMimeType_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeType", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeType_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMimeType_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getMimeType' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getMimeType", "(Ljava/io/File;)Ljava/lang/String;", "")]
		public static unsafe string GetMimeType (global::Java.IO.File p0)
		{
			if (id_getMimeType_Ljava_io_File_ == IntPtr.Zero)
				id_getMimeType_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeType", "(Ljava/io/File;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeType_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMimeType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getMimeType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMimeType", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMimeType (string p0)
		{
			if (id_getMimeType_Ljava_lang_String_ == IntPtr.Zero)
				id_getMimeType_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeType", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeType_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getMimeTypeByContentUriOrOther_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getMimeTypeByContentUriOrOther' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getMimeTypeByContentUriOrOther", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetMimeTypeByContentUriOrOther (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getMimeTypeByContentUriOrOther_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getMimeTypeByContentUriOrOther_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getMimeTypeByContentUriOrOther", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMimeTypeByContentUriOrOther_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetName (string p0)
		{
			if (id_getName_Ljava_lang_String_ == IntPtr.Zero)
				id_getName_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getName", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getName_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getPath_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getPath' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
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

		static IntPtr id_getPathWithoutFilename_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getPathWithoutFilename' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getPathWithoutFilename", "(Ljava/io/File;)Ljava/io/File;", "")]
		public static unsafe global::Java.IO.File GetPathWithoutFilename (global::Java.IO.File p0)
		{
			if (id_getPathWithoutFilename_Ljava_io_File_ == IntPtr.Zero)
				id_getPathWithoutFilename_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getPathWithoutFilename", "(Ljava/io/File;)Ljava/io/File;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.File __ret = global::Java.Lang.Object.GetObject<global::Java.IO.File> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPathWithoutFilename_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPreview_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getPreview' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getPreview", "(Ljava/lang/String;II)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetPreview (string p0, int p1, int p2)
		{
			if (id_getPreview_Ljava_lang_String_II == IntPtr.Zero)
				id_getPreview_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "getPreview", "(Ljava/lang/String;II)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreview_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getPreview_Ljava_lang_String_IIZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getPreview' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String']]"
		[Register ("getPreview", "(Ljava/lang/String;IIZLjava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetPreview (string p0, int p1, int p2, bool p3, string p4)
		{
			if (id_getPreview_Ljava_lang_String_IIZLjava_lang_String_ == IntPtr.Zero)
				id_getPreview_Ljava_lang_String_IIZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getPreview", "(Ljava/lang/String;IIZLjava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPreview_Ljava_lang_String_IIZLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getReadableFileSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getReadableFileSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getReadableFileSize", "(I)Ljava/lang/String;", "")]
		public static unsafe string GetReadableFileSize (int p0)
		{
			if (id_getReadableFileSize_I == IntPtr.Zero)
				id_getReadableFileSize_I = JNIEnv.GetStaticMethodID (class_ref, "getReadableFileSize", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getReadableFileSize_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getSize_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getSize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getSize", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;", "")]
		public static unsafe string GetSize (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getSize_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getSize_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getSize", "(Landroid/content/Context;Landroid/net/Uri;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSize_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getThumbnail' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getThumbnail", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetThumbnail (global::Android.Content.Context p0, global::Android.Net.Uri p1)
		{
			if (id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_ == IntPtr.Zero)
				id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getThumbnail", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getThumbnail' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.lang.String']]"
		[Register ("getThumbnail", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetThumbnail (global::Android.Content.Context p0, global::Android.Net.Uri p1, string p2)
		{
			if (id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ == IntPtr.Zero)
				id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getThumbnail", "(Landroid/content/Context;Landroid/net/Uri;Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThumbnail_Landroid_content_Context_Landroid_net_Uri_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getThumbnail_Landroid_content_Context_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getThumbnail' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.io.File']]"
		[Register ("getThumbnail", "(Landroid/content/Context;Ljava/io/File;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap GetThumbnail (global::Android.Content.Context p0, global::Java.IO.File p1)
		{
			if (id_getThumbnail_Landroid_content_Context_Ljava_io_File_ == IntPtr.Zero)
				id_getThumbnail_Landroid_content_Context_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getThumbnail", "(Landroid/content/Context;Ljava/io/File;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getThumbnail_Landroid_content_Context_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUri_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='getUri' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("getUri", "(Ljava/io/File;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetUri (global::Java.IO.File p0)
		{
			if (id_getUri_Ljava_io_File_ == IntPtr.Zero)
				id_getUri_Ljava_io_File_ = JNIEnv.GetStaticMethodID (class_ref, "getUri", "(Ljava/io/File;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUri_Ljava_io_File_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isContentScheme_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isContentScheme' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isContentScheme", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsContentScheme (global::Android.Net.Uri p0)
		{
			if (id_isContentScheme_Landroid_net_Uri_ == IntPtr.Zero)
				id_isContentScheme_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isContentScheme", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isContentScheme_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isDownloadsDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isDownloadsDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isExternalStorageDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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

		static IntPtr id_isFileExist_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isFileExist' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isFileExist", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFileExist (string p0)
		{
			if (id_isFileExist_Ljava_lang_String_ == IntPtr.Zero)
				id_isFileExist_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isFileExist", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFileExist_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isGooglePhotosUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isGooglePhotosUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isGooglePhotosUri", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsGooglePhotosUri (global::Android.Net.Uri p0)
		{
			if (id_isGooglePhotosUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_isGooglePhotosUri_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isGooglePhotosUri", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isGooglePhotosUri_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isLocal_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isLocal' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isLocal", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsLocal (string p0)
		{
			if (id_isLocal_Ljava_lang_String_ == IntPtr.Zero)
				id_isLocal_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isLocal", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocal_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_isLocalStorageDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isLocalStorageDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isLocalStorageDocument", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsLocalStorageDocument (global::Android.Net.Uri p0)
		{
			if (id_isLocalStorageDocument_Landroid_net_Uri_ == IntPtr.Zero)
				id_isLocalStorageDocument_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isLocalStorageDocument", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isLocalStorageDocument_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMaxUploadSizeReached_Landroid_content_Context_Landroid_net_Uri_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isMaxUploadSizeReached' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("isMaxUploadSizeReached", "(Landroid/content/Context;Landroid/net/Uri;I)Z", "")]
		public static unsafe bool IsMaxUploadSizeReached (global::Android.Content.Context p0, global::Android.Net.Uri p1, int p2)
		{
			if (id_isMaxUploadSizeReached_Landroid_content_Context_Landroid_net_Uri_I == IntPtr.Zero)
				id_isMaxUploadSizeReached_Landroid_content_Context_Landroid_net_Uri_I = JNIEnv.GetStaticMethodID (class_ref, "isMaxUploadSizeReached", "(Landroid/content/Context;Landroid/net/Uri;I)Z");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMaxUploadSizeReached_Landroid_content_Context_Landroid_net_Uri_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isMediaDocument_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isMediaDocument' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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

		static IntPtr id_isMediaUri_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='isMediaUri' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("isMediaUri", "(Landroid/net/Uri;)Z", "")]
		public static unsafe bool IsMediaUri (global::Android.Net.Uri p0)
		{
			if (id_isMediaUri_Landroid_net_Uri_ == IntPtr.Zero)
				id_isMediaUri_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "isMediaUri", "(Landroid/net/Uri;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isMediaUri_Landroid_net_Uri_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadRestrictedWordsFile_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='loadRestrictedWordsFile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadRestrictedWordsFile", "(Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> LoadRestrictedWordsFile (global::Android.Content.Context p0)
		{
			if (id_loadRestrictedWordsFile_Landroid_content_Context_ == IntPtr.Zero)
				id_loadRestrictedWordsFile_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadRestrictedWordsFile", "(Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<string> __ret = global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadRestrictedWordsFile_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadSettingsJsonFile_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.file']/class[@name='FileUtils']/method[@name='loadSettingsJsonFile' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("loadSettingsJsonFile", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string LoadSettingsJsonFile (global::Android.Content.Context p0)
		{
			if (id_loadSettingsJsonFile_Landroid_content_Context_ == IntPtr.Zero)
				id_loadSettingsJsonFile_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadSettingsJsonFile", "(Landroid/content/Context;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadSettingsJsonFile_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
