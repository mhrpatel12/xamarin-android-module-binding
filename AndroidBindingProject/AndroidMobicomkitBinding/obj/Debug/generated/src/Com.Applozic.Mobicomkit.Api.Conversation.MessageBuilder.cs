using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/MessageBuilder", DoNotGenerateAcw=true)]
	public partial class MessageBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/MessageBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageBuilder); }
		}

		protected MessageBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/constructor[@name='MessageBuilder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MessageBuilder (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessageBuilder)) {
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

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		static IntPtr id_send;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual unsafe void Send ()
		{
			if (id_send == IntPtr.Zero)
				id_send = JNIEnv.GetMethodID (class_ref, "send", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "()V"));
			} finally {
			}
		}

		static Delegate cb_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Handler ()
		{
			if (cb_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ == null)
				cb_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_);
			return cb_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
		}

		static void n_Send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p0 = (global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Send (p0);
		}
#pragma warning restore 0169

		static IntPtr id_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.listners.MediaUploadProgressHandler']]"
		[Register ("send", "(Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V", "GetSend_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Handler")]
		public virtual unsafe void Send (global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p0)
		{
			if (id_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ == IntPtr.Zero)
				id_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ = JNIEnv.GetMethodID (class_ref, "send", "(Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_send_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "send", "(Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientGroupId_Ljava_lang_String_ == null)
				cb_setClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetClientGroupId_Ljava_lang_String_);
			return cb_setClientGroupId_Ljava_lang_String_;
		}

		static IntPtr n_SetClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetClientGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetClientGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetClientGroupId (string p0)
		{
			if (id_setClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
				id_setClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setClientGroupId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientGroupId", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setContentType_S;
#pragma warning disable 0169
		static Delegate GetSetContentType_SHandler ()
		{
			if (cb_setContentType_S == null)
				cb_setContentType_S = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short, IntPtr>) n_SetContentType_S);
			return cb_setContentType_S;
		}

		static IntPtr n_SetContentType_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetContentType (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setContentType_S;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setContentType' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("setContentType", "(S)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetContentType_SHandler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetContentType (short p0)
		{
			if (id_setContentType_S == IntPtr.Zero)
				id_setContentType_S = JNIEnv.GetMethodID (class_ref, "setContentType", "(S)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setContentType_S, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentType", "(S)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setFilePath_Ljava_lang_String_ == null)
				cb_setFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetFilePath_Ljava_lang_String_);
			return cb_setFilePath_Ljava_lang_String_;
		}

		static IntPtr n_SetFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetFilePath (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setFilePath_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFilePath", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetFilePath_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetFilePath (string p0)
		{
			if (id_setFilePath_Ljava_lang_String_ == IntPtr.Zero)
				id_setFilePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFilePath", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFilePath_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilePath", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGroupId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetGroupId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setGroupId_Ljava_lang_Integer_ == null)
				cb_setGroupId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetGroupId_Ljava_lang_Integer_);
			return cb_setGroupId_Ljava_lang_Integer_;
		}

		static IntPtr n_SetGroupId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setGroupId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("setGroupId", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetGroupId_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetGroupId (global::Java.Lang.Integer p0)
		{
			if (id_setGroupId_Ljava_lang_Integer_ == IntPtr.Zero)
				id_setGroupId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setGroupId", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setGroupId_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupId", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setMessage_Ljava_lang_String_ == null)
				cb_setMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMessage_Ljava_lang_String_);
			return cb_setMessage_Ljava_lang_String_;
		}

		static IntPtr n_SetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetMessage (string p0)
		{
			if (id_setMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_setMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Ljava_util_Map_ == null)
				cb_setMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMetadata_Ljava_util_Map_);
			return cb_setMetadata_Ljava_util_Map_;
		}

		static IntPtr n_SetMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMetadata (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setMetadata_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("setMetadata", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetMetadata_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetMetadata (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
				id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setMetadata_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadata", "(Ljava/util/Map;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTo_Ljava_lang_String_Handler ()
		{
			if (cb_setTo_Ljava_lang_String_ == null)
				cb_setTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTo_Ljava_lang_String_);
			return cb_setTo_Ljava_lang_String_;
		}

		static IntPtr n_SetTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetTo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetTo (string p0)
		{
			if (id_setTo_Ljava_lang_String_ == IntPtr.Zero)
				id_setTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setTo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setType_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_Short_Handler ()
		{
			if (cb_setType_Ljava_lang_Short_ == null)
				cb_setType_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_Short_);
			return cb_setType_Ljava_lang_Short_;
		}

		static IntPtr n_SetType_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setType_Ljava_lang_Short_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageBuilder']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
		[Register ("setType", "(Ljava/lang/Short;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;", "GetSetType_Ljava_lang_Short_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder SetType (global::Java.Lang.Short p0)
		{
			if (id_setType_Ljava_lang_Short_ == IntPtr.Zero)
				id_setType_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/Short;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_Short_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageBuilder> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/Short;)Lcom/applozic/mobicomkit/api/conversation/MessageBuilder;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
