using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.Register {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/register/RegistrationResponse", DoNotGenerateAcw=true)]
	public partial class RegistrationResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType", DoNotGenerateAcw=true)]
		public sealed partial class PricingType : global::Java.Lang.Enum {


			static IntPtr BETA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='BETA']"
			[Register ("BETA")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Beta {
				get {
					if (BETA_jfieldId == IntPtr.Zero)
						BETA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BETA", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BETA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CLOSED_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='CLOSED']"
			[Register ("CLOSED")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Closed {
				get {
					if (CLOSED_jfieldId == IntPtr.Zero)
						CLOSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLOSED", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLOSED_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ENTERPRISE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='ENTERPRISE']"
			[Register ("ENTERPRISE")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Enterprise {
				get {
					if (ENTERPRISE_jfieldId == IntPtr.Zero)
						ENTERPRISE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENTERPRISE", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENTERPRISE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr GROWTH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='GROWTH']"
			[Register ("GROWTH")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Growth {
				get {
					if (GROWTH_jfieldId == IntPtr.Zero)
						GROWTH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GROWTH", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GROWTH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LAUNCH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='LAUNCH']"
			[Register ("LAUNCH")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Launch {
				get {
					if (LAUNCH_jfieldId == IntPtr.Zero)
						LAUNCH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAUNCH", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAUNCH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr STARTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/field[@name='STARTER']"
			[Register ("STARTER")]
			public static global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType Starter {
				get {
					if (STARTER_jfieldId == IntPtr.Zero)
						STARTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STARTER", "Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STARTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PricingType); }
			}

			internal PricingType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getValue;
			public unsafe global::Java.Lang.Short Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()Ljava/lang/Short;", "GetGetValueHandler")]
				get {
					if (id_getValue == IntPtr.Zero)
						id_getValue = JNIEnv.GetMethodID (class_ref, "getValue", "()Ljava/lang/Short;");
					try {
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValue), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse.PricingType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;", "")]
			public static unsafe global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/applozic/mobicomkit/api/account/register/RegistrationResponse$PricingType;");
				try {
					return (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse.PricingType));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/register/RegistrationResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegistrationResponse); }
		}

		protected RegistrationResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/constructor[@name='RegistrationResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegistrationResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RegistrationResponse)) {
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

		static Delegate cb_getBrokerUrl;
#pragma warning disable 0169
		static Delegate GetGetBrokerUrlHandler ()
		{
			if (cb_getBrokerUrl == null)
				cb_getBrokerUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBrokerUrl);
			return cb_getBrokerUrl;
		}

		static IntPtr n_GetBrokerUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BrokerUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setBrokerUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBrokerUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setBrokerUrl_Ljava_lang_String_ == null)
				cb_setBrokerUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBrokerUrl_Ljava_lang_String_);
			return cb_setBrokerUrl_Ljava_lang_String_;
		}

		static void n_SetBrokerUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BrokerUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBrokerUrl;
		static IntPtr id_setBrokerUrl_Ljava_lang_String_;
		public virtual unsafe string BrokerUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getBrokerUrl' and count(parameter)=0]"
			[Register ("getBrokerUrl", "()Ljava/lang/String;", "GetGetBrokerUrlHandler")]
			get {
				if (id_getBrokerUrl == IntPtr.Zero)
					id_getBrokerUrl = JNIEnv.GetMethodID (class_ref, "getBrokerUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBrokerUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBrokerUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setBrokerUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBrokerUrl", "(Ljava/lang/String;)V", "GetSetBrokerUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setBrokerUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setBrokerUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBrokerUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrokerUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrokerUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContactNumber;
#pragma warning disable 0169
		static Delegate GetGetContactNumberHandler ()
		{
			if (cb_getContactNumber == null)
				cb_getContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactNumber);
			return cb_getContactNumber;
		}

		static IntPtr n_GetContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setContactNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContactNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setContactNumber_Ljava_lang_String_ == null)
				cb_setContactNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactNumber_Ljava_lang_String_);
			return cb_setContactNumber_Ljava_lang_String_;
		}

		static void n_SetContactNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getContactNumber' and count(parameter)=0]"
			[Register ("getContactNumber", "()Ljava/lang/String;", "GetGetContactNumberHandler")]
			get {
				if (id_getContactNumber == IntPtr.Zero)
					id_getContactNumber = JNIEnv.GetMethodID (class_ref, "getContactNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContactNumber", "(Ljava/lang/String;)V", "GetSetContactNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setContactNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setContactNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContactNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCurrentTimeStamp;
#pragma warning disable 0169
		static Delegate GetGetCurrentTimeStampHandler ()
		{
			if (cb_getCurrentTimeStamp == null)
				cb_getCurrentTimeStamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentTimeStamp);
			return cb_getCurrentTimeStamp;
		}

		static IntPtr n_GetCurrentTimeStamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentTimeStamp);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentTimeStamp_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCurrentTimeStamp_Ljava_lang_Long_Handler ()
		{
			if (cb_setCurrentTimeStamp_Ljava_lang_Long_ == null)
				cb_setCurrentTimeStamp_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentTimeStamp_Ljava_lang_Long_);
			return cb_setCurrentTimeStamp_Ljava_lang_Long_;
		}

		static void n_SetCurrentTimeStamp_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrentTimeStamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentTimeStamp;
		static IntPtr id_setCurrentTimeStamp_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long CurrentTimeStamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getCurrentTimeStamp' and count(parameter)=0]"
			[Register ("getCurrentTimeStamp", "()Ljava/lang/Long;", "GetGetCurrentTimeStampHandler")]
			get {
				if (id_getCurrentTimeStamp == IntPtr.Zero)
					id_getCurrentTimeStamp = JNIEnv.GetMethodID (class_ref, "getCurrentTimeStamp", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentTimeStamp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentTimeStamp", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setCurrentTimeStamp' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCurrentTimeStamp", "(Ljava/lang/Long;)V", "GetSetCurrentTimeStamp_Ljava_lang_Long_Handler")]
			set {
				if (id_setCurrentTimeStamp_Ljava_lang_Long_ == IntPtr.Zero)
					id_setCurrentTimeStamp_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setCurrentTimeStamp", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentTimeStamp_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentTimeStamp", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeviceKey;
#pragma warning disable 0169
		static Delegate GetGetDeviceKeyHandler ()
		{
			if (cb_getDeviceKey == null)
				cb_getDeviceKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceKey);
			return cb_getDeviceKey;
		}

		static IntPtr n_GetDeviceKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceKey);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceKey_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceKey_Ljava_lang_String_ == null)
				cb_setDeviceKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeviceKey_Ljava_lang_String_);
			return cb_setDeviceKey_Ljava_lang_String_;
		}

		static void n_SetDeviceKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceKey;
		static IntPtr id_setDeviceKey_Ljava_lang_String_;
		public virtual unsafe string DeviceKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getDeviceKey' and count(parameter)=0]"
			[Register ("getDeviceKey", "()Ljava/lang/String;", "GetGetDeviceKeyHandler")]
			get {
				if (id_getDeviceKey == IntPtr.Zero)
					id_getDeviceKey = JNIEnv.GetMethodID (class_ref, "getDeviceKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setDeviceKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceKey", "(Ljava/lang/String;)V", "GetSetDeviceKey_Ljava_lang_String_Handler")]
			set {
				if (id_setDeviceKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeviceKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeviceKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeviceKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeviceKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static Delegate cb_setDisplayName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDisplayName_Ljava_lang_String_Handler ()
		{
			if (cb_setDisplayName_Ljava_lang_String_ == null)
				cb_setDisplayName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisplayName_Ljava_lang_String_);
			return cb_setDisplayName_Ljava_lang_String_;
		}

		static void n_SetDisplayName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDisplayName", "(Ljava/lang/String;)V", "GetSetDisplayName_Ljava_lang_String_Handler")]
			set {
				if (id_setDisplayName_Ljava_lang_String_ == IntPtr.Zero)
					id_setDisplayName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDisplayName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isEnableEncryption;
#pragma warning disable 0169
		static Delegate GetIsEnableEncryptionHandler ()
		{
			if (cb_isEnableEncryption == null)
				cb_isEnableEncryption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnableEncryption);
			return cb_isEnableEncryption;
		}

		static bool n_IsEnableEncryption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableEncryption;
		}
#pragma warning restore 0169

		static Delegate cb_setEnableEncryption_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableEncryption_ZHandler ()
		{
			if (cb_setEnableEncryption_Z == null)
				cb_setEnableEncryption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableEncryption_Z);
			return cb_setEnableEncryption_Z;
		}

		static void n_SetEnableEncryption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableEncryption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isEnableEncryption;
		static IntPtr id_setEnableEncryption_Z;
		public virtual unsafe bool EnableEncryption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='isEnableEncryption' and count(parameter)=0]"
			[Register ("isEnableEncryption", "()Z", "GetIsEnableEncryptionHandler")]
			get {
				if (id_isEnableEncryption == IntPtr.Zero)
					id_isEnableEncryption = JNIEnv.GetMethodID (class_ref, "isEnableEncryption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnableEncryption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnableEncryption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setEnableEncryption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnableEncryption", "(Z)V", "GetSetEnableEncryption_ZHandler")]
			set {
				if (id_setEnableEncryption_Z == IntPtr.Zero)
					id_setEnableEncryption_Z = JNIEnv.GetMethodID (class_ref, "setEnableEncryption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEnableEncryption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableEncryption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEncryptionKey;
#pragma warning disable 0169
		static Delegate GetGetEncryptionKeyHandler ()
		{
			if (cb_getEncryptionKey == null)
				cb_getEncryptionKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptionKey);
			return cb_getEncryptionKey;
		}

		static IntPtr n_GetEncryptionKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptionKey);
		}
#pragma warning restore 0169

		static Delegate cb_setEncryptionKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEncryptionKey_Ljava_lang_String_Handler ()
		{
			if (cb_setEncryptionKey_Ljava_lang_String_ == null)
				cb_setEncryptionKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEncryptionKey_Ljava_lang_String_);
			return cb_setEncryptionKey_Ljava_lang_String_;
		}

		static void n_SetEncryptionKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EncryptionKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptionKey;
		static IntPtr id_setEncryptionKey_Ljava_lang_String_;
		public virtual unsafe string EncryptionKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getEncryptionKey' and count(parameter)=0]"
			[Register ("getEncryptionKey", "()Ljava/lang/String;", "GetGetEncryptionKeyHandler")]
			get {
				if (id_getEncryptionKey == IntPtr.Zero)
					id_getEncryptionKey = JNIEnv.GetMethodID (class_ref, "getEncryptionKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptionKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptionKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setEncryptionKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEncryptionKey", "(Ljava/lang/String;)V", "GetSetEncryptionKey_Ljava_lang_String_Handler")]
			set {
				if (id_setEncryptionKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setEncryptionKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEncryptionKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEncryptionKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEncryptionKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getImageLink;
#pragma warning disable 0169
		static Delegate GetGetImageLinkHandler ()
		{
			if (cb_getImageLink == null)
				cb_getImageLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageLink);
			return cb_getImageLink;
		}

		static IntPtr n_GetImageLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageLink);
		}
#pragma warning restore 0169

		static Delegate cb_setImageLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageLink_Ljava_lang_String_Handler ()
		{
			if (cb_setImageLink_Ljava_lang_String_ == null)
				cb_setImageLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageLink_Ljava_lang_String_);
			return cb_setImageLink_Ljava_lang_String_;
		}

		static void n_SetImageLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLink;
		static IntPtr id_setImageLink_Ljava_lang_String_;
		public virtual unsafe string ImageLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getImageLink' and count(parameter)=0]"
			[Register ("getImageLink", "()Ljava/lang/String;", "GetGetImageLinkHandler")]
			get {
				if (id_getImageLink == IntPtr.Zero)
					id_getImageLink = JNIEnv.GetMethodID (class_ref, "getImageLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setImageLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageLink", "(Ljava/lang/String;)V", "GetSetImageLink_Ljava_lang_String_Handler")]
			set {
				if (id_setImageLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageLink", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isPasswordInvalid;
#pragma warning disable 0169
		static Delegate GetIsPasswordInvalidHandler ()
		{
			if (cb_isPasswordInvalid == null)
				cb_isPasswordInvalid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPasswordInvalid);
			return cb_isPasswordInvalid;
		}

		static bool n_IsPasswordInvalid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPasswordInvalid;
		}
#pragma warning restore 0169

		static IntPtr id_isPasswordInvalid;
		public virtual unsafe bool IsPasswordInvalid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='isPasswordInvalid' and count(parameter)=0]"
			[Register ("isPasswordInvalid", "()Z", "GetIsPasswordInvalidHandler")]
			get {
				if (id_isPasswordInvalid == IntPtr.Zero)
					id_isPasswordInvalid = JNIEnv.GetMethodID (class_ref, "isPasswordInvalid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPasswordInvalid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPasswordInvalid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastSyncTime;
#pragma warning disable 0169
		static Delegate GetGetLastSyncTimeHandler ()
		{
			if (cb_getLastSyncTime == null)
				cb_getLastSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastSyncTime);
			return cb_getLastSyncTime;
		}

		static IntPtr n_GetLastSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setLastSyncTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetLastSyncTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setLastSyncTime_Ljava_lang_Long_ == null)
				cb_setLastSyncTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastSyncTime_Ljava_lang_Long_);
			return cb_setLastSyncTime_Ljava_lang_Long_;
		}

		static void n_SetLastSyncTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSyncTime;
		static IntPtr id_setLastSyncTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long LastSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getLastSyncTime' and count(parameter)=0]"
			[Register ("getLastSyncTime", "()Ljava/lang/Long;", "GetGetLastSyncTimeHandler")]
			get {
				if (id_getLastSyncTime == IntPtr.Zero)
					id_getLastSyncTime = JNIEnv.GetMethodID (class_ref, "getLastSyncTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSyncTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setLastSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setLastSyncTime", "(Ljava/lang/Long;)V", "GetSetLastSyncTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setLastSyncTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setLastSyncTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setLastSyncTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSyncTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSyncTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static void n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Ljava_lang_String_;
		public virtual unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessage", "(Ljava/lang/String;)V", "GetSetMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationResponse;
#pragma warning disable 0169
		static Delegate GetGetNotificationResponseHandler ()
		{
			if (cb_getNotificationResponse == null)
				cb_getNotificationResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationResponse);
			return cb_getNotificationResponse;
		}

		static IntPtr n_GetNotificationResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NotificationResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotificationResponse_Ljava_lang_String_Handler ()
		{
			if (cb_setNotificationResponse_Ljava_lang_String_ == null)
				cb_setNotificationResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationResponse_Ljava_lang_String_);
			return cb_setNotificationResponse_Ljava_lang_String_;
		}

		static void n_SetNotificationResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationResponse;
		static IntPtr id_setNotificationResponse_Ljava_lang_String_;
		public virtual unsafe string NotificationResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getNotificationResponse' and count(parameter)=0]"
			[Register ("getNotificationResponse", "()Ljava/lang/String;", "GetGetNotificationResponseHandler")]
			get {
				if (id_getNotificationResponse == IntPtr.Zero)
					id_getNotificationResponse = JNIEnv.GetMethodID (class_ref, "getNotificationResponse", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationResponse), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationResponse", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setNotificationResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNotificationResponse", "(Ljava/lang/String;)V", "GetSetNotificationResponse_Ljava_lang_String_Handler")]
			set {
				if (id_setNotificationResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_setNotificationResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNotificationResponse", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationResponse_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationResponse", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPricingPackage;
#pragma warning disable 0169
		static Delegate GetGetPricingPackageHandler ()
		{
			if (cb_getPricingPackage == null)
				cb_getPricingPackage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPricingPackage);
			return cb_getPricingPackage;
		}

		static IntPtr n_GetPricingPackage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PricingPackage);
		}
#pragma warning restore 0169

		static Delegate cb_setPricingPackage_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetPricingPackage_Ljava_lang_Short_Handler ()
		{
			if (cb_setPricingPackage_Ljava_lang_Short_ == null)
				cb_setPricingPackage_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPricingPackage_Ljava_lang_Short_);
			return cb_setPricingPackage_Ljava_lang_Short_;
		}

		static void n_SetPricingPackage_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PricingPackage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPricingPackage;
		static IntPtr id_setPricingPackage_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short PricingPackage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getPricingPackage' and count(parameter)=0]"
			[Register ("getPricingPackage", "()Ljava/lang/Short;", "GetGetPricingPackageHandler")]
			get {
				if (id_getPricingPackage == IntPtr.Zero)
					id_getPricingPackage = JNIEnv.GetMethodID (class_ref, "getPricingPackage", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPricingPackage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPricingPackage", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setPricingPackage' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setPricingPackage", "(Ljava/lang/Short;)V", "GetSetPricingPackage_Ljava_lang_Short_Handler")]
			set {
				if (id_setPricingPackage_Ljava_lang_Short_ == IntPtr.Zero)
					id_setPricingPackage_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setPricingPackage", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPricingPackage_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPricingPackage", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatusMessage;
#pragma warning disable 0169
		static Delegate GetGetStatusMessageHandler ()
		{
			if (cb_getStatusMessage == null)
				cb_getStatusMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatusMessage);
			return cb_getStatusMessage;
		}

		static IntPtr n_GetStatusMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.StatusMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setStatusMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatusMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setStatusMessage_Ljava_lang_String_ == null)
				cb_setStatusMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatusMessage_Ljava_lang_String_);
			return cb_setStatusMessage_Ljava_lang_String_;
		}

		static void n_SetStatusMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StatusMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusMessage;
		static IntPtr id_setStatusMessage_Ljava_lang_String_;
		public virtual unsafe string StatusMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getStatusMessage' and count(parameter)=0]"
			[Register ("getStatusMessage", "()Ljava/lang/String;", "GetGetStatusMessageHandler")]
			get {
				if (id_getStatusMessage == IntPtr.Zero)
					id_getStatusMessage = JNIEnv.GetMethodID (class_ref, "getStatusMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatusMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatusMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setStatusMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatusMessage", "(Ljava/lang/String;)V", "GetSetStatusMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setStatusMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatusMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatusMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatusMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatusMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserKey;
#pragma warning disable 0169
		static Delegate GetGetUserKeyHandler ()
		{
			if (cb_getUserKey == null)
				cb_getUserKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserKey);
			return cb_getUserKey;
		}

		static IntPtr n_GetUserKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserKey);
		}
#pragma warning restore 0169

		static Delegate cb_setUserKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserKey_Ljava_lang_String_Handler ()
		{
			if (cb_setUserKey_Ljava_lang_String_ == null)
				cb_setUserKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserKey_Ljava_lang_String_);
			return cb_setUserKey_Ljava_lang_String_;
		}

		static void n_SetUserKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.Register.RegistrationResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserKey;
		static IntPtr id_setUserKey_Ljava_lang_String_;
		public virtual unsafe string UserKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='getUserKey' and count(parameter)=0]"
			[Register ("getUserKey", "()Ljava/lang/String;", "GetGetUserKeyHandler")]
			get {
				if (id_getUserKey == IntPtr.Zero)
					id_getUserKey = JNIEnv.GetMethodID (class_ref, "getUserKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.register']/class[@name='RegistrationResponse']/method[@name='setUserKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserKey", "(Ljava/lang/String;)V", "GetSetUserKey_Ljava_lang_String_Handler")]
			set {
				if (id_setUserKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
