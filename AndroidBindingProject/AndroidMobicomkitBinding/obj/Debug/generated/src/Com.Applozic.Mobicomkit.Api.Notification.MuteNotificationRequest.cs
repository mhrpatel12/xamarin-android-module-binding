using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MuteNotificationRequest", DoNotGenerateAcw=true)]
	public partial class MuteNotificationRequest : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MuteNotificationRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuteNotificationRequest); }
		}

		protected MuteNotificationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/constructor[@name='MuteNotificationRequest' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/String;)V", "")]
		public unsafe MuteNotificationRequest (global::Java.Lang.Long p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (MuteNotificationRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Long;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Long;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/constructor[@name='MuteNotificationRequest' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Long']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/Long;)V", "")]
		public unsafe MuteNotificationRequest (global::Java.Lang.Integer p0, global::Java.Lang.Long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MuteNotificationRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/Long;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Ljava/lang/Long;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_Long_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_Long_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/constructor[@name='MuteNotificationRequest' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Long;)V", "")]
		public unsafe MuteNotificationRequest (string p0, global::Java.Lang.Long p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MuteNotificationRequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Long;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Long;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Long;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Long_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getClientGroupId;
#pragma warning disable 0169
		static Delegate GetGetClientGroupIdHandler ()
		{
			if (cb_getClientGroupId == null)
				cb_getClientGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientGroupId);
			return cb_getClientGroupId;
		}

		static IntPtr n_GetClientGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientGroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientGroupId_Ljava_lang_String_ == null)
				cb_setClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientGroupId_Ljava_lang_String_);
			return cb_setClientGroupId_Ljava_lang_String_;
		}

		static void n_SetClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='getClientGroupId' and count(parameter)=0]"
			[Register ("getClientGroupId", "()Ljava/lang/String;", "GetGetClientGroupIdHandler")]
			get {
				if (id_getClientGroupId == IntPtr.Zero)
					id_getClientGroupId = JNIEnv.GetMethodID (class_ref, "getClientGroupId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientGroupId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientGroupId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientGroupId", "(Ljava/lang/String;)V", "GetSetClientGroupId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientGroupId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientGroupId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientGroupId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setId_Ljava_lang_Integer_ == null)
				cb_setId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_Integer_);
			return cb_setId_Ljava_lang_Integer_;
		}

		static void n_SetId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/Integer;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setId", "(Ljava/lang/Integer;)V", "GetSetId_Ljava_lang_Integer_Handler")]
			set {
				if (id_setId_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRequestValid;
#pragma warning disable 0169
		static Delegate GetIsRequestValidHandler ()
		{
			if (cb_isRequestValid == null)
				cb_isRequestValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRequestValid);
			return cb_isRequestValid;
		}

		static bool n_IsRequestValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRequestValid;
		}
#pragma warning restore 0169

		static IntPtr id_isRequestValid;
		public virtual unsafe bool IsRequestValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='isRequestValid' and count(parameter)=0]"
			[Register ("isRequestValid", "()Z", "GetIsRequestValidHandler")]
			get {
				if (id_isRequestValid == IntPtr.Zero)
					id_isRequestValid = JNIEnv.GetMethodID (class_ref, "isRequestValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRequestValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRequestValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getNotificationAfterTime;
#pragma warning disable 0169
		static Delegate GetGetNotificationAfterTimeHandler ()
		{
			if (cb_getNotificationAfterTime == null)
				cb_getNotificationAfterTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationAfterTime);
			return cb_getNotificationAfterTime;
		}

		static IntPtr n_GetNotificationAfterTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationAfterTime);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationAfterTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetNotificationAfterTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setNotificationAfterTime_Ljava_lang_Long_ == null)
				cb_setNotificationAfterTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationAfterTime_Ljava_lang_Long_);
			return cb_setNotificationAfterTime_Ljava_lang_Long_;
		}

		static void n_SetNotificationAfterTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationAfterTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationAfterTime;
		static IntPtr id_setNotificationAfterTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long NotificationAfterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='getNotificationAfterTime' and count(parameter)=0]"
			[Register ("getNotificationAfterTime", "()Ljava/lang/Long;", "GetGetNotificationAfterTimeHandler")]
			get {
				if (id_getNotificationAfterTime == IntPtr.Zero)
					id_getNotificationAfterTime = JNIEnv.GetMethodID (class_ref, "getNotificationAfterTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationAfterTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationAfterTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='setNotificationAfterTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setNotificationAfterTime", "(Ljava/lang/Long;)V", "GetSetNotificationAfterTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setNotificationAfterTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setNotificationAfterTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setNotificationAfterTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationAfterTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationAfterTime", "(Ljava/lang/Long;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='getUserId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteNotificationRequest']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
