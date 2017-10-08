using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.Register {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/register/RegisterUserClientService", DoNotGenerateAcw=true)]
	public partial class RegisterUserClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/field[@name='CHECK_PRICING_PACKAGE']"
		[Register ("CHECK_PRICING_PACKAGE")]
		public const string CheckPricingPackage = (string) "/rest/ws/application/pricing/package";

		static IntPtr MOBICOMKIT_VERSION_CODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/field[@name='MOBICOMKIT_VERSION_CODE']"
		[Register ("MOBICOMKIT_VERSION_CODE")]
		public static global::Java.Lang.Short MobicomkitVersionCode {
			get {
				if (MOBICOMKIT_VERSION_CODE_jfieldId == IntPtr.Zero)
					MOBICOMKIT_VERSION_CODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBICOMKIT_VERSION_CODE", "Ljava/lang/Short;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBICOMKIT_VERSION_CODE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/register/RegisterUserClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegisterUserClientService); }
		}

		protected RegisterUserClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/constructor[@name='RegisterUserClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RegisterUserClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RegisterUserClientService)) {
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

		static Delegate cb_getCreateAccountUrl;
#pragma warning disable 0169
		static Delegate GetGetCreateAccountUrlHandler ()
		{
			if (cb_getCreateAccountUrl == null)
				cb_getCreateAccountUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateAccountUrl);
			return cb_getCreateAccountUrl;
		}

		static IntPtr n_GetCreateAccountUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateAccountUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateAccountUrl;
		public virtual unsafe string CreateAccountUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='getCreateAccountUrl' and count(parameter)=0]"
			[Register ("getCreateAccountUrl", "()Ljava/lang/String;", "GetGetCreateAccountUrlHandler")]
			get {
				if (id_getCreateAccountUrl == IntPtr.Zero)
					id_getCreateAccountUrl = JNIEnv.GetMethodID (class_ref, "getCreateAccountUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateAccountUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateAccountUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPricingPackageUrl;
#pragma warning disable 0169
		static Delegate GetGetPricingPackageUrlHandler ()
		{
			if (cb_getPricingPackageUrl == null)
				cb_getPricingPackageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPricingPackageUrl);
			return cb_getPricingPackageUrl;
		}

		static IntPtr n_GetPricingPackageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PricingPackageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getPricingPackageUrl;
		public virtual unsafe string PricingPackageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='getPricingPackageUrl' and count(parameter)=0]"
			[Register ("getPricingPackageUrl", "()Ljava/lang/String;", "GetGetPricingPackageUrlHandler")]
			get {
				if (id_getPricingPackageUrl == IntPtr.Zero)
					id_getPricingPackageUrl = JNIEnv.GetMethodID (class_ref, "getPricingPackageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPricingPackageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPricingPackageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateAccountUrl;
#pragma warning disable 0169
		static Delegate GetGetUpdateAccountUrlHandler ()
		{
			if (cb_getUpdateAccountUrl == null)
				cb_getUpdateAccountUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateAccountUrl);
			return cb_getUpdateAccountUrl;
		}

		static IntPtr n_GetUpdateAccountUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateAccountUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateAccountUrl;
		public virtual unsafe string UpdateAccountUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='getUpdateAccountUrl' and count(parameter)=0]"
			[Register ("getUpdateAccountUrl", "()Ljava/lang/String;", "GetGetUpdateAccountUrlHandler")]
			get {
				if (id_getUpdateAccountUrl == IntPtr.Zero)
					id_getUpdateAccountUrl = JNIEnv.GetMethodID (class_ref, "getUpdateAccountUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateAccountUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateAccountUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
#pragma warning disable 0169
		static Delegate GetCreateAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Handler ()
		{
			if (cb_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ == null)
				cb_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_);
			return cb_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
		}

		static IntPtr n_CreateAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='createAccount' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.user.ApplozicUser']]"
		[Register ("createAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;", "GetCreateAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse CreateAccount (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser p0)
		{
			if (id_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ == IntPtr.Zero)
				id_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ = JNIEnv.GetMethodID (class_ref, "createAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCreateAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_CreateAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateAccount (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='createAccount' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("createAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;", "GetCreateAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse CreateAccount (string p0, string p1, string p2, string p3, string p4, string p5)
		{
			if (id_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "createAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);

				global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createAccount_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createAccount", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_syncAccountStatus;
#pragma warning disable 0169
		static Delegate GetSyncAccountStatusHandler ()
		{
			if (cb_syncAccountStatus == null)
				cb_syncAccountStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncAccountStatus);
			return cb_syncAccountStatus;
		}

		static void n_SyncAccountStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncAccountStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_syncAccountStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='syncAccountStatus' and count(parameter)=0]"
		[Register ("syncAccountStatus", "()V", "GetSyncAccountStatusHandler")]
		public virtual unsafe void SyncAccountStatus ()
		{
			if (id_syncAccountStatus == IntPtr.Zero)
				id_syncAccountStatus = JNIEnv.GetMethodID (class_ref, "syncAccountStatus", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncAccountStatus);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncAccountStatus", "()V"));
			} finally {
			}
		}

		static Delegate cb_updatePushNotificationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdatePushNotificationId_Ljava_lang_String_Handler ()
		{
			if (cb_updatePushNotificationId_Ljava_lang_String_ == null)
				cb_updatePushNotificationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdatePushNotificationId_Ljava_lang_String_);
			return cb_updatePushNotificationId_Ljava_lang_String_;
		}

		static IntPtr n_UpdatePushNotificationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdatePushNotificationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updatePushNotificationId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='updatePushNotificationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updatePushNotificationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;", "GetUpdatePushNotificationId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse UpdatePushNotificationId (string p0)
		{
			if (id_updatePushNotificationId_Ljava_lang_String_ == IntPtr.Zero)
				id_updatePushNotificationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updatePushNotificationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updatePushNotificationId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updatePushNotificationId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
#pragma warning disable 0169
		static Delegate GetUpdateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Handler ()
		{
			if (cb_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ == null)
				cb_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_);
			return cb_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
		}

		static IntPtr n_UpdateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegisterUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateRegisteredAccount (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegisterUserClientService']/method[@name='updateRegisteredAccount' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.user.ApplozicUser']]"
		[Register ("updateRegisteredAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;", "GetUpdateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse UpdateRegisteredAccount (global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser p0)
		{
			if (id_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ == IntPtr.Zero)
				id_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_ = JNIEnv.GetMethodID (class_ref, "updateRegisteredAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateRegisteredAccount_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateRegisteredAccount", "(Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
