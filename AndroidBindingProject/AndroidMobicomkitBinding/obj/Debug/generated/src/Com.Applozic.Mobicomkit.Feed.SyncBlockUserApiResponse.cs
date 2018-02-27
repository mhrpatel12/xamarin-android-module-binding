using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/SyncBlockUserApiResponse", DoNotGenerateAcw=true)]
	public partial class SyncBlockUserApiResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const string Success = (string) "success";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/SyncBlockUserApiResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncBlockUserApiResponse); }
		}

		protected SyncBlockUserApiResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/constructor[@name='SyncBlockUserApiResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncBlockUserApiResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SyncBlockUserApiResponse)) {
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

		static Delegate cb_getGeneratedAt;
#pragma warning disable 0169
		static Delegate GetGetGeneratedAtHandler ()
		{
			if (cb_getGeneratedAt == null)
				cb_getGeneratedAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGeneratedAt);
			return cb_getGeneratedAt;
		}

		static IntPtr n_GetGeneratedAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GeneratedAt);
		}
#pragma warning restore 0169

		static Delegate cb_setGeneratedAt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGeneratedAt_Ljava_lang_String_Handler ()
		{
			if (cb_setGeneratedAt_Ljava_lang_String_ == null)
				cb_setGeneratedAt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGeneratedAt_Ljava_lang_String_);
			return cb_setGeneratedAt_Ljava_lang_String_;
		}

		static void n_SetGeneratedAt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GeneratedAt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGeneratedAt;
		static IntPtr id_setGeneratedAt_Ljava_lang_String_;
		public virtual unsafe string GeneratedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='getGeneratedAt' and count(parameter)=0]"
			[Register ("getGeneratedAt", "()Ljava/lang/String;", "GetGetGeneratedAtHandler")]
			get {
				if (id_getGeneratedAt == IntPtr.Zero)
					id_getGeneratedAt = JNIEnv.GetMethodID (class_ref, "getGeneratedAt", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGeneratedAt), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGeneratedAt", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='setGeneratedAt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGeneratedAt", "(Ljava/lang/String;)V", "GetSetGeneratedAt_Ljava_lang_String_Handler")]
			set {
				if (id_setGeneratedAt_Ljava_lang_String_ == IntPtr.Zero)
					id_setGeneratedAt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGeneratedAt", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGeneratedAt_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGeneratedAt", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSuccess);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static Delegate cb_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_Handler ()
		{
			if (cb_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_ == null)
				cb_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_);
			return cb_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_;
		}

		static void n_SetResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Response = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.sync.SyncUserBlockListFeed']]"
			[Register ("setResponse", "(Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;)V", "GetSetResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_Handler")]
			set {
				if (id_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_ == IntPtr.Zero)
					id_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponse_Lcom_applozic_mobicomkit_sync_SyncUserBlockListFeed_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponse", "(Lcom/applozic/mobicomkit/sync/SyncUserBlockListFeed;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.SyncBlockUserApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='SyncBlockUserApiResponse']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
