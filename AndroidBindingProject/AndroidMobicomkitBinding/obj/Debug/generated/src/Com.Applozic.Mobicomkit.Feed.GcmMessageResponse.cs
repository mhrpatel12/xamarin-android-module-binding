using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/GcmMessageResponse", DoNotGenerateAcw=true)]
	public partial class GcmMessageResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/GcmMessageResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GcmMessageResponse); }
		}

		protected GcmMessageResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/constructor[@name='GcmMessageResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GcmMessageResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GcmMessageResponse)) {
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
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_String_;
		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				if (id_setId_Ljava_lang_String_ == IntPtr.Zero)
					id_setId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
			[Register ("setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
			set {
				if (id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
					id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNotifyUser;
#pragma warning disable 0169
		static Delegate GetIsNotifyUserHandler ()
		{
			if (cb_isNotifyUser == null)
				cb_isNotifyUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsNotifyUser);
			return cb_isNotifyUser;
		}

		static bool n_IsNotifyUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NotifyUser;
		}
#pragma warning restore 0169

		static Delegate cb_setNotifyUser_Z;
#pragma warning disable 0169
		static Delegate GetSetNotifyUser_ZHandler ()
		{
			if (cb_setNotifyUser_Z == null)
				cb_setNotifyUser_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNotifyUser_Z);
			return cb_setNotifyUser_Z;
		}

		static void n_SetNotifyUser_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUser = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isNotifyUser;
		static IntPtr id_setNotifyUser_Z;
		public virtual unsafe bool NotifyUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='isNotifyUser' and count(parameter)=0]"
			[Register ("isNotifyUser", "()Z", "GetIsNotifyUserHandler")]
			get {
				if (id_isNotifyUser == IntPtr.Zero)
					id_isNotifyUser = JNIEnv.GetMethodID (class_ref, "isNotifyUser", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNotifyUser);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNotifyUser", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='setNotifyUser' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNotifyUser", "(Z)V", "GetSetNotifyUser_ZHandler")]
			set {
				if (id_setNotifyUser_Z == IntPtr.Zero)
					id_setNotifyUser_Z = JNIEnv.GetMethodID (class_ref, "setNotifyUser", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotifyUser_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotifyUser", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GcmMessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GcmMessageResponse']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
