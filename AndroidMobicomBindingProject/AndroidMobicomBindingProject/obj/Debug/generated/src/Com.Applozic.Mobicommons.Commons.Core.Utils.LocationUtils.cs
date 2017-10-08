using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/LocationUtils", DoNotGenerateAcw=true)]
	public partial class LocationUtils : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/LocationUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LocationUtils); }
		}

		protected LocationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationUtils']/constructor[@name='LocationUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (LocationUtils)) {
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

		static IntPtr id_getAddress_Landroid_content_Context_Landroid_location_Location_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationUtils']/method[@name='getAddress' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.location.Location']]"
		[Register ("getAddress", "(Landroid/content/Context;Landroid/location/Location;)Ljava/lang/String;", "")]
		public static unsafe string GetAddress (global::Android.Content.Context p0, global::Android.Locations.Location p1)
		{
			if (id_getAddress_Landroid_content_Context_Landroid_location_Location_ == IntPtr.Zero)
				id_getAddress_Landroid_content_Context_Landroid_location_Location_ = JNIEnv.GetStaticMethodID (class_ref, "getAddress", "(Landroid/content/Context;Landroid/location/Location;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getAddress_Landroid_content_Context_Landroid_location_Location_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLocationFromMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationUtils']/method[@name='getLocationFromMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLocationFromMessage", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetLocationFromMessage (string p0)
		{
			if (id_getLocationFromMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getLocationFromMessage_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getLocationFromMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLocationFromMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_loadStaticMap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='LocationUtils']/method[@name='loadStaticMap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadStaticMap", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string LoadStaticMap (string p0)
		{
			if (id_loadStaticMap_Ljava_lang_String_ == IntPtr.Zero)
				id_loadStaticMap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadStaticMap", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadStaticMap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
