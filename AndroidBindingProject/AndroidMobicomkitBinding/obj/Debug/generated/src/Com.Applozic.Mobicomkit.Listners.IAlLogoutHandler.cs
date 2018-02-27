using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlLogoutHandler']"
	[Register ("com/applozic/mobicomkit/listners/AlLogoutHandler", "", "Com.Applozic.Mobicomkit.Listners.IAlLogoutHandlerInvoker")]
	public partial interface IAlLogoutHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlLogoutHandler']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onFailure", "(Ljava/lang/Exception;)V", "GetOnFailure_Ljava_lang_Exception_Handler:Com.Applozic.Mobicomkit.Listners.IAlLogoutHandlerInvoker, AndroidMobicomkitBinding")]
		void OnFailure (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlLogoutHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onSuccess", "(Landroid/content/Context;)V", "GetOnSuccess_Landroid_content_Context_Handler:Com.Applozic.Mobicomkit.Listners.IAlLogoutHandlerInvoker, AndroidMobicomkitBinding")]
		void OnSuccess (global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/AlLogoutHandler", DoNotGenerateAcw=true)]
	internal class IAlLogoutHandlerInvoker : global::Java.Lang.Object, IAlLogoutHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/AlLogoutHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAlLogoutHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IAlLogoutHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlLogoutHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.AlLogoutHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlLogoutHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Exception_ == null)
				cb_onFailure_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailure_Ljava_lang_Exception_);
			return cb_onFailure_Ljava_lang_Exception_;
		}

		static void n_OnFailure_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IAlLogoutHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IAlLogoutHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Exception_;
		public unsafe void OnFailure (global::Java.Lang.Exception p0)
		{
			if (id_onFailure_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Landroid_content_Context_Handler ()
		{
			if (cb_onSuccess_Landroid_content_Context_ == null)
				cb_onSuccess_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Landroid_content_Context_);
			return cb_onSuccess_Landroid_content_Context_;
		}

		static void n_OnSuccess_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IAlLogoutHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IAlLogoutHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Landroid_content_Context_;
		public unsafe void OnSuccess (global::Android.Content.Context p0)
		{
			if (id_onSuccess_Landroid_content_Context_ == IntPtr.Zero)
				id_onSuccess_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Landroid_content_Context_, __args);
		}

	}

}
