using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ApiResponse", DoNotGenerateAcw=true)]
	public partial class ApiResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ApiResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApiResponse); }
		}

		protected ApiResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/constructor[@name='ApiResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApiResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApiResponse)) {
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

		static Delegate cb_getErrorResponse;
#pragma warning disable 0169
		static Delegate GetGetErrorResponseHandler ()
		{
			if (cb_getErrorResponse == null)
				cb_getErrorResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorResponse);
			return cb_getErrorResponse;
		}

		static IntPtr n_GetErrorResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed>.ToLocalJniHandle (__this.ErrorResponse);
		}
#pragma warning restore 0169

		static Delegate cb_setErrorResponse_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetErrorResponse_Ljava_util_List_Handler ()
		{
			if (cb_setErrorResponse_Ljava_util_List_ == null)
				cb_setErrorResponse_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetErrorResponse_Ljava_util_List_);
			return cb_setErrorResponse_Ljava_util_List_;
		}

		static void n_SetErrorResponse_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ErrorResponse = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getErrorResponse;
		static IntPtr id_setErrorResponse_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed> ErrorResponse {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='getErrorResponse' and count(parameter)=0]"
			[Register ("getErrorResponse", "()Ljava/util/List;", "GetGetErrorResponseHandler")]
			get {
				if (id_getErrorResponse == IntPtr.Zero)
					id_getErrorResponse = JNIEnv.GetMethodID (class_ref, "getErrorResponse", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorResponse", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='setErrorResponse' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.feed.ErrorResponseFeed&gt;']]"
			[Register ("setErrorResponse", "(Ljava/util/List;)V", "GetSetErrorResponse_Ljava_util_List_Handler")]
			set {
				if (id_setErrorResponse_Ljava_util_List_ == IntPtr.Zero)
					id_setErrorResponse_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setErrorResponse", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ErrorResponseFeed>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setErrorResponse_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setErrorResponse", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GeneratedAt = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGeneratedAt;
		static IntPtr id_setGeneratedAt_Ljava_lang_String_;
		public virtual unsafe string GeneratedAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='getGeneratedAt' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='setGeneratedAt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='isSuccess' and count(parameter)=0]"
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static Delegate cb_setResponse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetResponse_Ljava_lang_Object_Handler ()
		{
			if (cb_setResponse_Ljava_lang_Object_ == null)
				cb_setResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetResponse_Ljava_lang_Object_);
			return cb_setResponse_Ljava_lang_Object_;
		}

		static void n_SetResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Response = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		static IntPtr id_setResponse_Ljava_lang_Object_;
		public virtual unsafe global::Java.Lang.Object Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Ljava/lang/Object;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Ljava/lang/Object;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='setResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setResponse", "(Ljava/lang/Object;)V", "GetSetResponse_Ljava_lang_Object_Handler")]
			set {
				if (id_setResponse_Ljava_lang_Object_ == IntPtr.Zero)
					id_setResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setResponse", "(Ljava/lang/Object;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setResponse_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setResponse", "(Ljava/lang/Object;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='getStatus' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ApiResponse']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
