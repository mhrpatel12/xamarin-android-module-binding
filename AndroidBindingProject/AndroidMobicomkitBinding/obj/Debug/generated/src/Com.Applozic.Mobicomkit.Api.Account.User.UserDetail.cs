using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Account.User {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/account/user/UserDetail", DoNotGenerateAcw=true)]
	public partial class UserDetail : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/account/user/UserDetail", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserDetail); }
		}

		protected UserDetail (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/constructor[@name='UserDetail' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserDetail ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UserDetail)) {
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

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connected;
		}
#pragma warning restore 0169

		static Delegate cb_setConnected_Z;
#pragma warning disable 0169
		static Delegate GetSetConnected_ZHandler ()
		{
			if (cb_setConnected_Z == null)
				cb_setConnected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConnected_Z);
			return cb_setConnected_Z;
		}

		static void n_SetConnected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		static IntPtr id_setConnected_Z;
		public virtual unsafe bool Connected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setConnected", "(Z)V", "GetSetConnected_ZHandler")]
			set {
				if (id_setConnected_Z == IntPtr.Zero)
					id_setConnected_Z = JNIEnv.GetMethodID (class_ref, "setConnected", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnected_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnected", "(Z)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisplayName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		static IntPtr id_setDisplayName_Ljava_lang_String_;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getDisplayName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLink;
		static IntPtr id_setImageLink_Ljava_lang_String_;
		public virtual unsafe string ImageLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getImageLink' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setImageLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLastSeenAtTime;
#pragma warning disable 0169
		static Delegate GetGetLastSeenAtTimeHandler ()
		{
			if (cb_getLastSeenAtTime == null)
				cb_getLastSeenAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastSeenAtTime);
			return cb_getLastSeenAtTime;
		}

		static IntPtr n_GetLastSeenAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastSeenAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setLastSeenAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetLastSeenAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setLastSeenAtTime_Ljava_lang_Long_ == null)
				cb_setLastSeenAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastSeenAtTime_Ljava_lang_Long_);
			return cb_setLastSeenAtTime_Ljava_lang_Long_;
		}

		static void n_SetLastSeenAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastSeenAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSeenAtTime;
		static IntPtr id_setLastSeenAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long LastSeenAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getLastSeenAtTime' and count(parameter)=0]"
			[Register ("getLastSeenAtTime", "()Ljava/lang/Long;", "GetGetLastSeenAtTimeHandler")]
			get {
				if (id_getLastSeenAtTime == IntPtr.Zero)
					id_getLastSeenAtTime = JNIEnv.GetMethodID (class_ref, "getLastSeenAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastSeenAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSeenAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setLastSeenAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setLastSeenAtTime", "(Ljava/lang/Long;)V", "GetSetLastSeenAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setLastSeenAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setLastSeenAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setLastSeenAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSeenAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSeenAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPhoneNumber;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumberHandler ()
		{
			if (cb_getPhoneNumber == null)
				cb_getPhoneNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumber);
			return cb_getPhoneNumber;
		}

		static IntPtr n_GetPhoneNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PhoneNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setPhoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPhoneNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setPhoneNumber_Ljava_lang_String_ == null)
				cb_setPhoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhoneNumber_Ljava_lang_String_);
			return cb_setPhoneNumber_Ljava_lang_String_;
		}

		static void n_SetPhoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PhoneNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumber;
		static IntPtr id_setPhoneNumber_Ljava_lang_String_;
		public virtual unsafe string PhoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getPhoneNumber' and count(parameter)=0]"
			[Register ("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler")]
			get {
				if (id_getPhoneNumber == IntPtr.Zero)
					id_getPhoneNumber = JNIEnv.GetMethodID (class_ref, "getPhoneNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setPhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPhoneNumber", "(Ljava/lang/String;)V", "GetSetPhoneNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setPhoneNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setPhoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StatusMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatusMessage;
		static IntPtr id_setStatusMessage_Ljava_lang_String_;
		public virtual unsafe string StatusMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getStatusMessage' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setStatusMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadCountHandler ()
		{
			if (cb_getUnreadCount == null)
				cb_getUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnreadCount);
			return cb_getUnreadCount;
		}

		static IntPtr n_GetUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnreadCount);
		}
#pragma warning restore 0169

		static Delegate cb_setUnreadCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetUnreadCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setUnreadCount_Ljava_lang_Integer_ == null)
				cb_setUnreadCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnreadCount_Ljava_lang_Integer_);
			return cb_setUnreadCount_Ljava_lang_Integer_;
		}

		static void n_SetUnreadCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getUnreadCount' and count(parameter)=0]"
			[Register ("getUnreadCount", "()Ljava/lang/Integer;", "GetGetUnreadCountHandler")]
			get {
				if (id_getUnreadCount == IntPtr.Zero)
					id_getUnreadCount = JNIEnv.GetMethodID (class_ref, "getUnreadCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setUnreadCount", "(Ljava/lang/Integer;)V", "GetSetUnreadCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setUnreadCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setUnreadCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setUnreadCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnreadCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnreadCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getUserId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getUserTypeId;
#pragma warning disable 0169
		static Delegate GetGetUserTypeIdHandler ()
		{
			if (cb_getUserTypeId == null)
				cb_getUserTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserTypeId);
			return cb_getUserTypeId;
		}

		static IntPtr n_GetUserTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserTypeId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetUserTypeId_Ljava_lang_Short_Handler ()
		{
			if (cb_setUserTypeId_Ljava_lang_Short_ == null)
				cb_setUserTypeId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserTypeId_Ljava_lang_Short_);
			return cb_setUserTypeId_Ljava_lang_Short_;
		}

		static void n_SetUserTypeId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserTypeId;
		static IntPtr id_setUserTypeId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short UserTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='getUserTypeId' and count(parameter)=0]"
			[Register ("getUserTypeId", "()Ljava/lang/Short;", "GetGetUserTypeIdHandler")]
			get {
				if (id_getUserTypeId == IntPtr.Zero)
					id_getUserTypeId = JNIEnv.GetMethodID (class_ref, "getUserTypeId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserTypeId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.account.user']/class[@name='UserDetail']/method[@name='setUserTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setUserTypeId", "(Ljava/lang/Short;)V", "GetSetUserTypeId_Ljava_lang_Short_Handler")]
			set {
				if (id_setUserTypeId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setUserTypeId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setUserTypeId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserTypeId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserTypeId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

	}
}
