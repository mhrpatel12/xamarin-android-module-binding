using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlPushNotificationHandler']"
	[Register ("com/applozic/mobicomkit/listners/AlPushNotificationHandler", "", "Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandlerInvoker")]
	public partial interface IAlPushNotificationHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlPushNotificationHandler']/method[@name='onFailure' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.account.register.RegistrationResponse'] and parameter[2][@type='java.lang.Exception']]"
		[Register ("onFailure", "(Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;Ljava/lang/Exception;)V", "GetOnFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_Handler:Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandlerInvoker, AndroidMobicomkitBinding")]
		void OnFailure (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0, global::Java.Lang.Exception p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='AlPushNotificationHandler']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.register.RegistrationResponse']]"
		[Register ("onSuccess", "(Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;)V", "GetOnSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Handler:Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandlerInvoker, AndroidMobicomkitBinding")]
		void OnSuccess (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/AlPushNotificationHandler", DoNotGenerateAcw=true)]
	internal class IAlPushNotificationHandlerInvoker : global::Java.Lang.Object, IAlPushNotificationHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/AlPushNotificationHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IAlPushNotificationHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IAlPushNotificationHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAlPushNotificationHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.AlPushNotificationHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAlPushNotificationHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_ == null)
				cb_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_);
			return cb_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_;
		}

		static void n_OnFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_;
		public unsafe void OnFailure (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0, global::Java.Lang.Exception p1)
		{
			if (id_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_;
#pragma warning disable 0169
		static Delegate GetOnSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_Handler ()
		{
			if (cb_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_ == null)
				cb_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_);
			return cb_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_;
		}

		static void n_OnSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_;
		public unsafe void OnSuccess (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse p0)
		{
			if (id_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_ == IntPtr.Zero)
				id_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_ = JNIEnv.GetMethodID (class_ref, "onSuccess", "(Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_Lcom_applozic_mobicomkit_api_account_register_RegistrationResponse_, __args);
		}

	}

}
