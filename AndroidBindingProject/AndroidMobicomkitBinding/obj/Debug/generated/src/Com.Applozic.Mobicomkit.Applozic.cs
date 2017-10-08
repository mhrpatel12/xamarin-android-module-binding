using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/Applozic", DoNotGenerateAcw=true)]
	public partial class Applozic : global::Java.Lang.Object {


		static IntPtr applozicInstance_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/field[@name='applozicInstance']"
		[Register ("applozicInstance")]
		public static global::Com.Applozic.Mobicomkit.Applozic ApplozicInstance {
			get {
				if (applozicInstance_jfieldId == IntPtr.Zero)
					applozicInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicInstance", "Lcom/applozic/mobicomkit/Applozic;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, applozicInstance_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (applozicInstance_jfieldId == IntPtr.Zero)
					applozicInstance_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "applozicInstance", "Lcom/applozic/mobicomkit/Applozic;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, applozicInstance_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr sharedPreferences_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/field[@name='sharedPreferences']"
		[Register ("sharedPreferences")]
		public global::Android.Content.ISharedPreferences SharedPreferences {
			get {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (sharedPreferences_jfieldId == IntPtr.Zero)
					sharedPreferences_jfieldId = JNIEnv.GetFieldID (class_ref, "sharedPreferences", "Landroid/content/SharedPreferences;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, sharedPreferences_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/Applozic", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Applozic); }
		}

		protected Applozic (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		public virtual unsafe string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceRegistrationId;
#pragma warning disable 0169
		static Delegate GetGetDeviceRegistrationIdHandler ()
		{
			if (cb_getDeviceRegistrationId == null)
				cb_getDeviceRegistrationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceRegistrationId);
			return cb_getDeviceRegistrationId;
		}

		static IntPtr n_GetDeviceRegistrationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceRegistrationId);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceRegistrationId;
		public virtual unsafe string DeviceRegistrationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='getDeviceRegistrationId' and count(parameter)=0]"
			[Register ("getDeviceRegistrationId", "()Ljava/lang/String;", "GetGetDeviceRegistrationIdHandler")]
			get {
				if (id_getDeviceRegistrationId == IntPtr.Zero)
					id_getDeviceRegistrationId = JNIEnv.GetMethodID (class_ref, "getDeviceRegistrationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceRegistrationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceRegistrationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/Applozic;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Applozic GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/Applozic;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Applozic __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_init_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='init' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("init", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Applozic Init (global::Android.Content.Context p0, string p1)
		{
			if (id_init_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Applozic.Mobicomkit.Applozic __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallStaticObjectMethod  (class_ref, id_init_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setApplicationKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationKey_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationKey_Ljava_lang_String_ == null)
				cb_setApplicationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetApplicationKey_Ljava_lang_String_);
			return cb_setApplicationKey_Ljava_lang_String_;
		}

		static IntPtr n_SetApplicationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetApplicationKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setApplicationKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='setApplicationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;", "GetSetApplicationKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Applozic SetApplicationKey (string p0)
		{
			if (id_setApplicationKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setApplicationKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Applozic __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationKey", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setDeviceRegistrationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceRegistrationId_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceRegistrationId_Ljava_lang_String_ == null)
				cb_setDeviceRegistrationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDeviceRegistrationId_Ljava_lang_String_);
			return cb_setDeviceRegistrationId_Ljava_lang_String_;
		}

		static IntPtr n_SetDeviceRegistrationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDeviceRegistrationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDeviceRegistrationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='setDeviceRegistrationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDeviceRegistrationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;", "GetSetDeviceRegistrationId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Applozic SetDeviceRegistrationId (string p0)
		{
			if (id_setDeviceRegistrationId_Ljava_lang_String_ == IntPtr.Zero)
				id_setDeviceRegistrationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceRegistrationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Applozic __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceRegistrationId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceRegistrationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/Applozic;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
