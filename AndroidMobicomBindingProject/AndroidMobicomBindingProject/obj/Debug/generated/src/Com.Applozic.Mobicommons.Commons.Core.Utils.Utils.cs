using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/Utils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Utils); }
		}

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDeviceInformation;
		public static unsafe string DeviceInformation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getDeviceInformation' and count(parameter)=0]"
			[Register ("getDeviceInformation", "()Ljava/lang/String;", "GetGetDeviceInformationHandler")]
			get {
				if (id_getDeviceInformation == IntPtr.Zero)
					id_getDeviceInformation = JNIEnv.GetStaticMethodID (class_ref, "getDeviceInformation", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDeviceInformation), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_hasFroyo;
		public static unsafe bool HasFroyo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasFroyo' and count(parameter)=0]"
			[Register ("hasFroyo", "()Z", "GetHasFroyoHandler")]
			get {
				if (id_hasFroyo == IntPtr.Zero)
					id_hasFroyo = JNIEnv.GetStaticMethodID (class_ref, "hasFroyo", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasFroyo);
				} finally {
				}
			}
		}

		static IntPtr id_hasGingerbread;
		public static unsafe bool HasGingerbread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasGingerbread' and count(parameter)=0]"
			[Register ("hasGingerbread", "()Z", "GetHasGingerbreadHandler")]
			get {
				if (id_hasGingerbread == IntPtr.Zero)
					id_hasGingerbread = JNIEnv.GetStaticMethodID (class_ref, "hasGingerbread", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasGingerbread);
				} finally {
				}
			}
		}

		static IntPtr id_hasHoneycomb;
		public static unsafe bool HasHoneycomb {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasHoneycomb' and count(parameter)=0]"
			[Register ("hasHoneycomb", "()Z", "GetHasHoneycombHandler")]
			get {
				if (id_hasHoneycomb == IntPtr.Zero)
					id_hasHoneycomb = JNIEnv.GetStaticMethodID (class_ref, "hasHoneycomb", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasHoneycomb);
				} finally {
				}
			}
		}

		static IntPtr id_hasHoneycombMR1;
		public static unsafe bool HasHoneycombMR1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasHoneycombMR1' and count(parameter)=0]"
			[Register ("hasHoneycombMR1", "()Z", "GetHasHoneycombMR1Handler")]
			get {
				if (id_hasHoneycombMR1 == IntPtr.Zero)
					id_hasHoneycombMR1 = JNIEnv.GetStaticMethodID (class_ref, "hasHoneycombMR1", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasHoneycombMR1);
				} finally {
				}
			}
		}

		static IntPtr id_hasICS;
		public static unsafe bool HasICS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasICS' and count(parameter)=0]"
			[Register ("hasICS", "()Z", "GetHasICSHandler")]
			get {
				if (id_hasICS == IntPtr.Zero)
					id_hasICS = JNIEnv.GetStaticMethodID (class_ref, "hasICS", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasICS);
				} finally {
				}
			}
		}

		static IntPtr id_hasKitkat;
		public static unsafe bool HasKitkat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasKitkat' and count(parameter)=0]"
			[Register ("hasKitkat", "()Z", "GetHasKitkatHandler")]
			get {
				if (id_hasKitkat == IntPtr.Zero)
					id_hasKitkat = JNIEnv.GetStaticMethodID (class_ref, "hasKitkat", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasKitkat);
				} finally {
				}
			}
		}

		static IntPtr id_hasLollipop;
		public static unsafe bool HasLollipop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasLollipop' and count(parameter)=0]"
			[Register ("hasLollipop", "()Z", "GetHasLollipopHandler")]
			get {
				if (id_hasLollipop == IntPtr.Zero)
					id_hasLollipop = JNIEnv.GetStaticMethodID (class_ref, "hasLollipop", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasLollipop);
				} finally {
				}
			}
		}

		static IntPtr id_hasMarshmallow;
		public static unsafe bool HasMarshmallow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasMarshmallow' and count(parameter)=0]"
			[Register ("hasMarshmallow", "()Z", "GetHasMarshmallowHandler")]
			get {
				if (id_hasMarshmallow == IntPtr.Zero)
					id_hasMarshmallow = JNIEnv.GetStaticMethodID (class_ref, "hasMarshmallow", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasMarshmallow);
				} finally {
				}
			}
		}

		static IntPtr id_hasNougat;
		public static unsafe bool HasNougat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='hasNougat' and count(parameter)=0]"
			[Register ("hasNougat", "()Z", "GetHasNougatHandler")]
			get {
				if (id_hasNougat == IntPtr.Zero)
					id_hasNougat = JNIEnv.GetStaticMethodID (class_ref, "hasNougat", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasNougat);
				} finally {
				}
			}
		}

		static IntPtr id_isBetweenGingerBreadAndKitKat;
		public static unsafe bool IsBetweenGingerBreadAndKitKat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='isBetweenGingerBreadAndKitKat' and count(parameter)=0]"
			[Register ("isBetweenGingerBreadAndKitKat", "()Z", "GetIsBetweenGingerBreadAndKitKatHandler")]
			get {
				if (id_isBetweenGingerBreadAndKitKat == IntPtr.Zero)
					id_isBetweenGingerBreadAndKitKat = JNIEnv.GetStaticMethodID (class_ref, "isBetweenGingerBreadAndKitKat", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isBetweenGingerBreadAndKitKat);
				} finally {
				}
			}
		}

		static IntPtr id_dpToPx_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='dpToPx' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("dpToPx", "(I)I", "")]
		public static unsafe int DpToPx (int p0)
		{
			if (id_dpToPx_I == IntPtr.Zero)
				id_dpToPx_I = JNIEnv.GetStaticMethodID (class_ref, "dpToPx", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_dpToPx_I, __args);
			} finally {
			}
		}

		static IntPtr id_enableStrictMode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='enableStrictMode' and count(parameter)=0]"
		[Register ("enableStrictMode", "()V", "")]
		public static unsafe void EnableStrictMode ()
		{
			if (id_enableStrictMode == IntPtr.Zero)
				id_enableStrictMode = JNIEnv.GetStaticMethodID (class_ref, "enableStrictMode", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_enableStrictMode);
			} finally {
			}
		}

		static IntPtr id_getAppVersion_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getAppVersion' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAppVersion", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetAppVersion (global::Android.Content.Context p0)
		{
			if (id_getAppVersion_Landroid_content_Context_ == IntPtr.Zero)
				id_getAppVersion_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getAppVersion", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getAppVersion_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLauncherIcon_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getLauncherIcon' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getLauncherIcon", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetLauncherIcon (global::Android.Content.Context p0)
		{
			if (id_getLauncherIcon_Landroid_content_Context_ == IntPtr.Zero)
				id_getLauncherIcon_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getLauncherIcon", "(Landroid/content/Context;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getLauncherIcon_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMetaDataValue_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getMetaDataValue' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMetaDataValue", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMetaDataValue (global::Android.Content.Context p0, string p1)
		{
			if (id_getMetaDataValue_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetaDataValue_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMetaDataValue", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMetaDataValue_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getMetaDataValueForReceiver_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getMetaDataValueForReceiver' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getMetaDataValueForReceiver", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMetaDataValueForReceiver (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getMetaDataValueForReceiver_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetaDataValueForReceiver_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMetaDataValueForReceiver", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMetaDataValueForReceiver_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getMetaDataValueForResources_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getMetaDataValueForResources' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMetaDataValueForResources", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Integer;", "")]
		public static unsafe global::Java.Lang.Integer GetMetaDataValueForResources (global::Android.Content.Context p0, string p1)
		{
			if (id_getMetaDataValueForResources_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getMetaDataValueForResources_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getMetaDataValueForResources", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.Integer __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMetaDataValueForResources_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getStyleString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getStyleString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStyleString", "(Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GetStyleStringFormatted (string p0)
		{
			if (id_getStyleString_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyleString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyleString", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStyleString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static string GetStyleString (string p0)
		{
			global::Java.Lang.ICharSequence __result = GetStyleStringFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_getStyleStringForMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getStyleStringForMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStyleStringForMessage", "(Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GetStyleStringForMessageFormatted (string p0)
		{
			if (id_getStyleStringForMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyleStringForMessage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyleStringForMessage", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStyleStringForMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static string GetStyleStringForMessage (string p0)
		{
			global::Java.Lang.ICharSequence __result = GetStyleStringForMessageFormatted (p0);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_getStyledStringForChannel_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getStyledStringForChannel' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getStyledStringForChannel", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GetStyledStringForChannelFormatted (string p0, string p1, string p2)
		{
			if (id_getStyledStringForChannel_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyledStringForChannel_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyledStringForChannel", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStyledStringForChannel_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		public static string GetStyledStringForChannel (string p0, string p1, string p2)
		{
			global::Java.Lang.ICharSequence __result = GetStyledStringForChannelFormatted (p0, p1, p2);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_getStyledStringForContact_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getStyledStringForContact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getStyledStringForContact", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;", "")]
		public static unsafe global::Java.Lang.ICharSequence GetStyledStringForContactFormatted (string p0, string p1)
		{
			if (id_getStyledStringForContact_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getStyledStringForContact_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getStyledStringForContact", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/CharSequence;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				global::Java.Lang.ICharSequence __ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getStyledStringForContact_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		public static string GetStyledStringForContact (string p0, string p1)
		{
			global::Java.Lang.ICharSequence __result = GetStyledStringForContactFormatted (p0, p1);
			return __result == null ? null : __result.ToString ();
		}

		static IntPtr id_getTimeDurationInFormat_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getTimeDurationInFormat' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getTimeDurationInFormat", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static unsafe string GetTimeDurationInFormat (global::Java.Lang.Long p0)
		{
			if (id_getTimeDurationInFormat_Ljava_lang_Long_ == IntPtr.Zero)
				id_getTimeDurationInFormat_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getTimeDurationInFormat", "(Ljava/lang/Long;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getTimeDurationInFormat_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getUserImageUri_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='getUserImageUri' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getUserImageUri", "(Landroid/content/Context;)Landroid/net/Uri;", "")]
		public static unsafe global::Android.Net.Uri GetUserImageUri (global::Android.Content.Context p0)
		{
			if (id_getUserImageUri_Landroid_content_Context_ == IntPtr.Zero)
				id_getUserImageUri_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getUserImageUri", "(Landroid/content/Context;)Landroid/net/Uri;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Android.Net.Uri __ret = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getUserImageUri_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isInternetAvailable_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='isInternetAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isInternetAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsInternetAvailable (global::Android.Content.Context p0)
		{
			if (id_isInternetAvailable_Landroid_content_Context_ == IntPtr.Zero)
				id_isInternetAvailable_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "isInternetAvailable", "(Landroid/content/Context;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInternetAvailable_Landroid_content_Context_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isNetworkAvailable_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='isNetworkAvailable' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("isNetworkAvailable", "(Landroid/app/Activity;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.App.Activity p0, string p1)
		{
			if (id_isNetworkAvailable_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_isNetworkAvailable_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isNetworkAvailable", "(Landroid/app/Activity;Ljava/lang/String;)Z");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isNetworkAvailable_Landroid_app_Activity_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_makePlaceHolders_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='makePlaceHolders' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("makePlaceHolders", "(I)Ljava/lang/String;", "")]
		public static unsafe string MakePlaceHolders (int p0)
		{
			if (id_makePlaceHolders_I == IntPtr.Zero)
				id_makePlaceHolders_I = JNIEnv.GetStaticMethodID (class_ref, "makePlaceHolders", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_makePlaceHolders_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_printLog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='printLog' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("printLog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void PrintLog (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_printLog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_printLog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "printLog", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_printLog_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_pxToDp_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='pxToDp' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pxToDp", "(I)I", "")]
		public static unsafe int PxToDp (int p0)
		{
			if (id_pxToDp_I == IntPtr.Zero)
				id_pxToDp_I = JNIEnv.GetStaticMethodID (class_ref, "pxToDp", "(I)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticIntMethod  (class_ref, id_pxToDp_I, __args);
			} finally {
			}
		}

		static IntPtr id_toggleSoftKeyBoard_Landroid_app_Activity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Utils']/method[@name='toggleSoftKeyBoard' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='boolean']]"
		[Register ("toggleSoftKeyBoard", "(Landroid/app/Activity;Z)V", "")]
		public static unsafe void ToggleSoftKeyBoard (global::Android.App.Activity p0, bool p1)
		{
			if (id_toggleSoftKeyBoard_Landroid_app_Activity_Z == IntPtr.Zero)
				id_toggleSoftKeyBoard_Landroid_app_Activity_Z = JNIEnv.GetStaticMethodID (class_ref, "toggleSoftKeyBoard", "(Landroid/app/Activity;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_toggleSoftKeyBoard_Landroid_app_Activity_Z, __args);
			} finally {
			}
		}

	}
}
