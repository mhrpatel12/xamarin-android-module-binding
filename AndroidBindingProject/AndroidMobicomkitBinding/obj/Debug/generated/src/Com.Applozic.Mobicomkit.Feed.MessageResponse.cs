using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/MessageResponse", DoNotGenerateAcw=true)]
	public partial class MessageResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/MessageResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageResponse); }
		}

		protected MessageResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/constructor[@name='MessageResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageResponse)) {
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

		static Delegate cb_getConversationId;
#pragma warning disable 0169
		static Delegate GetGetConversationIdHandler ()
		{
			if (cb_getConversationId == null)
				cb_getConversationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationId);
			return cb_getConversationId;
		}

		static IntPtr n_GetConversationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationId);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetConversationId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setConversationId_Ljava_lang_Integer_ == null)
				cb_setConversationId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationId_Ljava_lang_Integer_);
			return cb_setConversationId_Ljava_lang_Integer_;
		}

		static void n_SetConversationId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationId;
		static IntPtr id_setConversationId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ConversationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='getConversationId' and count(parameter)=0]"
			[Register ("getConversationId", "()Ljava/lang/Integer;", "GetGetConversationIdHandler")]
			get {
				if (id_getConversationId == IntPtr.Zero)
					id_getConversationId = JNIEnv.GetMethodID (class_ref, "getConversationId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='setConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setConversationId", "(Ljava/lang/Integer;)V", "GetSetConversationId_Ljava_lang_Integer_Handler")]
			set {
				if (id_setConversationId_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setConversationId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setConversationId", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationId_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationId", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCreatedAtTime;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtTimeHandler ()
		{
			if (cb_getCreatedAtTime == null)
				cb_getCreatedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAtTime);
			return cb_getCreatedAtTime;
		}

		static IntPtr n_GetCreatedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreatedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedAtTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreatedAtTime_Ljava_lang_String_Handler ()
		{
			if (cb_setCreatedAtTime_Ljava_lang_String_ == null)
				cb_setCreatedAtTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedAtTime_Ljava_lang_String_);
			return cb_setCreatedAtTime_Ljava_lang_String_;
		}

		static void n_SetCreatedAtTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAtTime;
		static IntPtr id_setCreatedAtTime_Ljava_lang_String_;
		public virtual unsafe string CreatedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='getCreatedAtTime' and count(parameter)=0]"
			[Register ("getCreatedAtTime", "()Ljava/lang/String;", "GetGetCreatedAtTimeHandler")]
			get {
				if (id_getCreatedAtTime == IntPtr.Zero)
					id_getCreatedAtTime = JNIEnv.GetMethodID (class_ref, "getCreatedAtTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedAtTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='setCreatedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreatedAtTime", "(Ljava/lang/String;)V", "GetSetCreatedAtTime_Ljava_lang_String_Handler")]
			set {
				if (id_setCreatedAtTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreatedAtTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreatedAtTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedAtTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedAtTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMessageKey;
#pragma warning disable 0169
		static Delegate GetGetMessageKeyHandler ()
		{
			if (cb_getMessageKey == null)
				cb_getMessageKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageKey);
			return cb_getMessageKey;
		}

		static IntPtr n_GetMessageKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageKey);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMessageKey_Ljava_lang_String_Handler ()
		{
			if (cb_setMessageKey_Ljava_lang_String_ == null)
				cb_setMessageKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageKey_Ljava_lang_String_);
			return cb_setMessageKey_Ljava_lang_String_;
		}

		static void n_SetMessageKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.MessageResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.MessageResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageKey;
		static IntPtr id_setMessageKey_Ljava_lang_String_;
		public virtual unsafe string MessageKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='getMessageKey' and count(parameter)=0]"
			[Register ("getMessageKey", "()Ljava/lang/String;", "GetGetMessageKeyHandler")]
			get {
				if (id_getMessageKey == IntPtr.Zero)
					id_getMessageKey = JNIEnv.GetMethodID (class_ref, "getMessageKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='MessageResponse']/method[@name='setMessageKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMessageKey", "(Ljava/lang/String;)V", "GetSetMessageKey_Ljava_lang_String_Handler")]
			set {
				if (id_setMessageKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setMessageKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMessageKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
