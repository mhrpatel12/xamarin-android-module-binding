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
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
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

		static IntPtr id_connectPublish_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='connectPublish' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("connectPublish", "(Landroid/content/Context;)V", "")]
		public static unsafe void ConnectPublish (global::Android.Content.Context p0)
		{
			if (id_connectPublish_Landroid_content_Context_ == IntPtr.Zero)
				id_connectPublish_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "connectPublish", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_connectPublish_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_disconnectPublish_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='disconnectPublish' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("disconnectPublish", "(Landroid/content/Context;)V", "")]
		public static unsafe void DisconnectPublish (global::Android.Content.Context p0)
		{
			if (id_disconnectPublish_Landroid_content_Context_ == IntPtr.Zero)
				id_disconnectPublish_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "disconnectPublish", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disconnectPublish_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_disconnectPublish_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='disconnectPublish' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("disconnectPublish", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void DisconnectPublish (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_disconnectPublish_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_disconnectPublish_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "disconnectPublish", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_disconnectPublish_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
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

		static IntPtr id_loginUser_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Lcom_applozic_mobicomkit_listners_AlLoginHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='loginUser' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.account.user.ApplozicUser'] and parameter[3][@type='com.applozic.mobicomkit.listners.AlLoginHandler']]"
		[Register ("loginUser", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;Lcom/applozic/mobicomkit/listners/AlLoginHandler;)V", "")]
		public static unsafe void LoginUser (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Account.User.ApplozicUser p1, global::Com.Applozic.Mobicomkit.Listners.IAlLoginHandler p2)
		{
			if (id_loginUser_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Lcom_applozic_mobicomkit_listners_AlLoginHandler_ == IntPtr.Zero)
				id_loginUser_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Lcom_applozic_mobicomkit_listners_AlLoginHandler_ = JNIEnv.GetStaticMethodID (class_ref, "loginUser", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/account/user/ApplozicUser;Lcom/applozic/mobicomkit/listners/AlLoginHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_loginUser_Landroid_content_Context_Lcom_applozic_mobicomkit_api_account_user_ApplozicUser_Lcom_applozic_mobicomkit_listners_AlLoginHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_logoutUser_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlLogoutHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='logoutUser' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.listners.AlLogoutHandler']]"
		[Register ("logoutUser", "(Landroid/content/Context;Lcom/applozic/mobicomkit/listners/AlLogoutHandler;)V", "")]
		public static unsafe void LogoutUser (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Listners.IAlLogoutHandler p1)
		{
			if (id_logoutUser_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlLogoutHandler_ == IntPtr.Zero)
				id_logoutUser_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlLogoutHandler_ = JNIEnv.GetStaticMethodID (class_ref, "logoutUser", "(Landroid/content/Context;Lcom/applozic/mobicomkit/listners/AlLogoutHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logoutUser_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlLogoutHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_publishTypingStatus_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='publishTypingStatus' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[4][@type='boolean']]"
		[Register ("publishTypingStatus", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;Z)V", "")]
		public static unsafe void PublishTypingStatus (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2, bool p3)
		{
			if (id_publishTypingStatus_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Z == IntPtr.Zero)
				id_publishTypingStatus_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Z = JNIEnv.GetStaticMethodID (class_ref, "publishTypingStatus", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;Z)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_publishTypingStatus_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Z, __args);
			} finally {
			}
		}

		static IntPtr id_registerForPushNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='registerForPushNotification' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.listners.AlPushNotificationHandler']]"
		[Register ("registerForPushNotification", "(Landroid/content/Context;Lcom/applozic/mobicomkit/listners/AlPushNotificationHandler;)V", "")]
		public static unsafe void RegisterForPushNotification (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler p1)
		{
			if (id_registerForPushNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_ == IntPtr.Zero)
				id_registerForPushNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_ = JNIEnv.GetStaticMethodID (class_ref, "registerForPushNotification", "(Landroid/content/Context;Lcom/applozic/mobicomkit/listners/AlPushNotificationHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerForPushNotification_Landroid_content_Context_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_registerForPushNotification_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='registerForPushNotification' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.applozic.mobicomkit.listners.AlPushNotificationHandler']]"
		[Register ("registerForPushNotification", "(Landroid/content/Context;Ljava/lang/String;Lcom/applozic/mobicomkit/listners/AlPushNotificationHandler;)V", "")]
		public static unsafe void RegisterForPushNotification (global::Android.Content.Context p0, string p1, global::Com.Applozic.Mobicomkit.Listners.IAlPushNotificationHandler p2)
		{
			if (id_registerForPushNotification_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_ == IntPtr.Zero)
				id_registerForPushNotification_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_ = JNIEnv.GetStaticMethodID (class_ref, "registerForPushNotification", "(Landroid/content/Context;Ljava/lang/String;Lcom/applozic/mobicomkit/listners/AlPushNotificationHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_registerForPushNotification_Landroid_content_Context_Ljava_lang_String_Lcom_applozic_mobicomkit_listners_AlPushNotificationHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_;
#pragma warning disable 0169
		static Delegate GetRegisterUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_Handler ()
		{
			if (cb_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_ == null)
				cb_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_);
			return cb_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_;
		}

		static void n_RegisterUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener p0 = (global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterUIListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='registerUIListener' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.listners.ApplozicUIListener']]"
		[Register ("registerUIListener", "(Lcom/applozic/mobicomkit/listners/ApplozicUIListener;)V", "GetRegisterUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_Handler")]
		public virtual unsafe void RegisterUIListener (global::Com.Applozic.Mobicomkit.Listners.IApplozicUIListener p0)
		{
			if (id_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_ == IntPtr.Zero)
				id_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_ = JNIEnv.GetMethodID (class_ref, "registerUIListener", "(Lcom/applozic/mobicomkit/listners/ApplozicUIListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerUIListener_Lcom_applozic_mobicomkit_listners_ApplozicUIListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerUIListener", "(Lcom/applozic/mobicomkit/listners/ApplozicUIListener;)V"), __args);
			} finally {
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

		static IntPtr id_subscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='subscribeToTyping' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("subscribeToTyping", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V", "")]
		public static unsafe void SubscribeToTyping (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2)
		{
			if (id_subscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_subscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetStaticMethodID (class_ref, "subscribeToTyping", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_subscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
			} finally {
			}
		}

		static IntPtr id_unSubscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='unSubscribeToTyping' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("unSubscribeToTyping", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V", "")]
		public static unsafe void UnSubscribeToTyping (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2)
		{
			if (id_unSubscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_unSubscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetStaticMethodID (class_ref, "unSubscribeToTyping", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_unSubscribeToTyping_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterUIListener;
#pragma warning disable 0169
		static Delegate GetUnregisterUIListenerHandler ()
		{
			if (cb_unregisterUIListener == null)
				cb_unregisterUIListener = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnregisterUIListener);
			return cb_unregisterUIListener;
		}

		static void n_UnregisterUIListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Applozic __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Applozic> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterUIListener ();
		}
#pragma warning restore 0169

		static IntPtr id_unregisterUIListener;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit']/class[@name='Applozic']/method[@name='unregisterUIListener' and count(parameter)=0]"
		[Register ("unregisterUIListener", "()V", "GetUnregisterUIListenerHandler")]
		public virtual unsafe void UnregisterUIListener ()
		{
			if (id_unregisterUIListener == IntPtr.Zero)
				id_unregisterUIListener = JNIEnv.GetMethodID (class_ref, "unregisterUIListener", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unregisterUIListener);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unregisterUIListener", "()V"));
			} finally {
			}
		}

	}
}
