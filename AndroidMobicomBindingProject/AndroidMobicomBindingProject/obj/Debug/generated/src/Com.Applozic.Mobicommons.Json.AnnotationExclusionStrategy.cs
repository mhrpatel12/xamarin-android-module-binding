using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Json {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='AnnotationExclusionStrategy']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/json/AnnotationExclusionStrategy", DoNotGenerateAcw=true)]
	public partial class AnnotationExclusionStrategy : global::Java.Lang.Object, global::GoogleGson.IExclusionStrategy {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/json/AnnotationExclusionStrategy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AnnotationExclusionStrategy); }
		}

		protected AnnotationExclusionStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='AnnotationExclusionStrategy']/constructor[@name='AnnotationExclusionStrategy' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnnotationExclusionStrategy ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AnnotationExclusionStrategy)) {
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

		static Delegate cb_shouldSkipClass_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetShouldSkipClass_Ljava_lang_Class_Handler ()
		{
			if (cb_shouldSkipClass_Ljava_lang_Class_ == null)
				cb_shouldSkipClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldSkipClass_Ljava_lang_Class_);
			return cb_shouldSkipClass_Ljava_lang_Class_;
		}

		static bool n_ShouldSkipClass_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.Json.AnnotationExclusionStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Json.AnnotationExclusionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldSkipClass (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_shouldSkipClass_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='AnnotationExclusionStrategy']/method[@name='shouldSkipClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("shouldSkipClass", "(Ljava/lang/Class;)Z", "GetShouldSkipClass_Ljava_lang_Class_Handler")]
		public virtual unsafe bool ShouldSkipClass (global::Java.Lang.Class p0)
		{
			if (id_shouldSkipClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_shouldSkipClass_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "shouldSkipClass", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldSkipClass_Ljava_lang_Class_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldSkipClass", "(Ljava/lang/Class;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_shouldSkipField_Lcom_google_gson_FieldAttributes_;
#pragma warning disable 0169
		static Delegate GetShouldSkipField_Lcom_google_gson_FieldAttributes_Handler ()
		{
			if (cb_shouldSkipField_Lcom_google_gson_FieldAttributes_ == null)
				cb_shouldSkipField_Lcom_google_gson_FieldAttributes_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldSkipField_Lcom_google_gson_FieldAttributes_);
			return cb_shouldSkipField_Lcom_google_gson_FieldAttributes_;
		}

		static bool n_ShouldSkipField_Lcom_google_gson_FieldAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.Json.AnnotationExclusionStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Json.AnnotationExclusionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::GoogleGson.FieldAttributes p0 = global::Java.Lang.Object.GetObject<global::GoogleGson.FieldAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldSkipField (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_shouldSkipField_Lcom_google_gson_FieldAttributes_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.json']/class[@name='AnnotationExclusionStrategy']/method[@name='shouldSkipField' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldAttributes']]"
		[Register ("shouldSkipField", "(Lcom/google/gson/FieldAttributes;)Z", "GetShouldSkipField_Lcom_google_gson_FieldAttributes_Handler")]
		public virtual unsafe bool ShouldSkipField (global::GoogleGson.FieldAttributes p0)
		{
			if (id_shouldSkipField_Lcom_google_gson_FieldAttributes_ == IntPtr.Zero)
				id_shouldSkipField_Lcom_google_gson_FieldAttributes_ = JNIEnv.GetMethodID (class_ref, "shouldSkipField", "(Lcom/google/gson/FieldAttributes;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldSkipField_Lcom_google_gson_FieldAttributes_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldSkipField", "(Lcom/google/gson/FieldAttributes;)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
