using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/json/GsonUtils", DoNotGenerateAcw=true)]
	public partial class GsonUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/json/GsonUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonUtils); }
		}

		protected GsonUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']/constructor[@name='GsonUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GsonUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GsonUtils)) {
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

		static IntPtr id_getJsonFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']/method[@name='getJsonFromObject' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("getJsonFromObject", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public static unsafe string GetJsonFromObject (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_getJsonFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getJsonFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getJsonFromObject", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsonFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getJsonWithExposeFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']/method[@name='getJsonWithExposeFromObject' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("getJsonWithExposeFromObject", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public static unsafe string GetJsonWithExposeFromObject (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_getJsonWithExposeFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getJsonWithExposeFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getJsonWithExposeFromObject", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getJsonWithExposeFromObject_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getObjectFromJson_Ljava_lang_String_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']/method[@name='getObjectFromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("getObjectFromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetObjectFromJson (string p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_getObjectFromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getObjectFromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getObjectFromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getObjectFromJson_Ljava_lang_String_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getObjectListFromJson_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='GsonUtils']/method[@name='getObjectListFromJson' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.reflect.Type']]"
		[Register ("getObjectListFromJson", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		public static unsafe global::Java.Lang.Object GetObjectListFromJson (string p0, string p1, global::Java.Lang.Reflect.IType p2)
		{
			if (id_getObjectListFromJson_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_getObjectListFromJson_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "getObjectListFromJson", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getObjectListFromJson_Ljava_lang_String_Ljava_lang_String_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
