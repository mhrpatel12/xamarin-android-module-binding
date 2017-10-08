using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='ArrayAdapterFactory']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/json/ArrayAdapterFactory", DoNotGenerateAcw=true)]
	public partial class ArrayAdapterFactory : global::Java.Lang.Object, global::GoogleGson.ITypeAdapterFactory {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/json/ArrayAdapterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayAdapterFactory); }
		}

		protected ArrayAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='ArrayAdapterFactory']/constructor[@name='ArrayAdapterFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ArrayAdapterFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ArrayAdapterFactory)) {
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

		static Delegate cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
#pragma warning disable 0169
		static Delegate GetCreate_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Handler ()
		{
			if (cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == null)
				cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_);
			return cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		}

		static IntPtr n_Create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.Json.ArrayAdapterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Json.ArrayAdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::GoogleGson.Gson p0 = global::Java.Lang.Object.GetObject<global::GoogleGson.Gson> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::GoogleGson.Reflect.TypeToken p1 = global::Java.Lang.Object.GetObject<global::GoogleGson.Reflect.TypeToken> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='ArrayAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "GetCreate_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::GoogleGson.TypeAdapter Create (global::GoogleGson.Gson p0, global::GoogleGson.Reflect.TypeToken p1)
		{
			if (id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::GoogleGson.TypeAdapter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::GoogleGson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::GoogleGson.TypeAdapter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
