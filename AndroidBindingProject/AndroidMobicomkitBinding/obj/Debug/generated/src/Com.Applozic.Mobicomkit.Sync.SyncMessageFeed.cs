using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/sync/SyncMessageFeed", DoNotGenerateAcw=true)]
	public partial class SyncMessageFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/sync/SyncMessageFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncMessageFeed); }
		}

		protected SyncMessageFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/constructor[@name='SyncMessageFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncMessageFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SyncMessageFeed)) {
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

		static Delegate cb_getCurrentSyncTime;
#pragma warning disable 0169
		static Delegate GetGetCurrentSyncTimeHandler ()
		{
			if (cb_getCurrentSyncTime == null)
				cb_getCurrentSyncTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentSyncTime);
			return cb_getCurrentSyncTime;
		}

		static IntPtr n_GetCurrentSyncTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentSyncTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentSyncTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCurrentSyncTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setCurrentSyncTime_Ljava_lang_Long_ == null)
				cb_setCurrentSyncTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentSyncTime_Ljava_lang_Long_);
			return cb_setCurrentSyncTime_Ljava_lang_Long_;
		}

		static void n_SetCurrentSyncTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrentSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentSyncTime;
		static IntPtr id_setCurrentSyncTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long CurrentSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='getCurrentSyncTime' and count(parameter)=0]"
			[Register ("getCurrentSyncTime", "()Ljava/lang/Long;", "GetGetCurrentSyncTimeHandler")]
			get {
				if (id_getCurrentSyncTime == IntPtr.Zero)
					id_getCurrentSyncTime = JNIEnv.GetMethodID (class_ref, "getCurrentSyncTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentSyncTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentSyncTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='setCurrentSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCurrentSyncTime", "(Ljava/lang/Long;)V", "GetSetCurrentSyncTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setCurrentSyncTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setCurrentSyncTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setCurrentSyncTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentSyncTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentSyncTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeliveredMessageKeys;
#pragma warning disable 0169
		static Delegate GetGetDeliveredMessageKeysHandler ()
		{
			if (cb_getDeliveredMessageKeys == null)
				cb_getDeliveredMessageKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeliveredMessageKeys);
			return cb_getDeliveredMessageKeys;
		}

		static IntPtr n_GetDeliveredMessageKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DeliveredMessageKeys);
		}
#pragma warning restore 0169

		static Delegate cb_setDeliveredMessageKeys_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDeliveredMessageKeys_Ljava_util_List_Handler ()
		{
			if (cb_setDeliveredMessageKeys_Ljava_util_List_ == null)
				cb_setDeliveredMessageKeys_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeliveredMessageKeys_Ljava_util_List_);
			return cb_setDeliveredMessageKeys_Ljava_util_List_;
		}

		static void n_SetDeliveredMessageKeys_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliveredMessageKeys = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeliveredMessageKeys;
		static IntPtr id_setDeliveredMessageKeys_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> DeliveredMessageKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='getDeliveredMessageKeys' and count(parameter)=0]"
			[Register ("getDeliveredMessageKeys", "()Ljava/util/List;", "GetGetDeliveredMessageKeysHandler")]
			get {
				if (id_getDeliveredMessageKeys == IntPtr.Zero)
					id_getDeliveredMessageKeys = JNIEnv.GetMethodID (class_ref, "getDeliveredMessageKeys", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeliveredMessageKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeliveredMessageKeys", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='setDeliveredMessageKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setDeliveredMessageKeys", "(Ljava/util/List;)V", "GetSetDeliveredMessageKeys_Ljava_util_List_Handler")]
			set {
				if (id_setDeliveredMessageKeys_Ljava_util_List_ == IntPtr.Zero)
					id_setDeliveredMessageKeys_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDeliveredMessageKeys", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeliveredMessageKeys_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeliveredMessageKeys", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastSyncTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSyncTime;
		static IntPtr id_setLastSyncTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long LastSyncTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='getLastSyncTime' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='setLastSyncTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
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

		static Delegate cb_getMessages;
#pragma warning disable 0169
		static Delegate GetGetMessagesHandler ()
		{
			if (cb_getMessages == null)
				cb_getMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessages);
			return cb_getMessages;
		}

		static IntPtr n_GetMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.Messages);
		}
#pragma warning restore 0169

		static Delegate cb_setMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMessages_Ljava_util_List_Handler ()
		{
			if (cb_setMessages_Ljava_util_List_ == null)
				cb_setMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessages_Ljava_util_List_);
			return cb_setMessages_Ljava_util_List_;
		}

		static void n_SetMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Messages = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages;
		static IntPtr id_setMessages_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> Messages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='getMessages' and count(parameter)=0]"
			[Register ("getMessages", "()Ljava/util/List;", "GetGetMessagesHandler")]
			get {
				if (id_getMessages == IntPtr.Zero)
					id_getMessages = JNIEnv.GetMethodID (class_ref, "getMessages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='setMessages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
			[Register ("setMessages", "(Ljava/util/List;)V", "GetSetMessages_Ljava_util_List_Handler")]
			set {
				if (id_setMessages_Ljava_util_List_ == IntPtr.Zero)
					id_setMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMessages", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessages_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessages", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isRegIdInvalid;
#pragma warning disable 0169
		static Delegate GetIsRegIdInvalidHandler ()
		{
			if (cb_isRegIdInvalid == null)
				cb_isRegIdInvalid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegIdInvalid);
			return cb_isRegIdInvalid;
		}

		static bool n_IsRegIdInvalid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RegIdInvalid;
		}
#pragma warning restore 0169

		static Delegate cb_setRegIdInvalid_Z;
#pragma warning disable 0169
		static Delegate GetSetRegIdInvalid_ZHandler ()
		{
			if (cb_setRegIdInvalid_Z == null)
				cb_setRegIdInvalid_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRegIdInvalid_Z);
			return cb_setRegIdInvalid_Z;
		}

		static void n_SetRegIdInvalid_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegIdInvalid = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRegIdInvalid;
		static IntPtr id_setRegIdInvalid_Z;
		public virtual unsafe bool RegIdInvalid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='isRegIdInvalid' and count(parameter)=0]"
			[Register ("isRegIdInvalid", "()Z", "GetIsRegIdInvalidHandler")]
			get {
				if (id_isRegIdInvalid == IntPtr.Zero)
					id_isRegIdInvalid = JNIEnv.GetMethodID (class_ref, "isRegIdInvalid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegIdInvalid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegIdInvalid", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncMessageFeed']/method[@name='setRegIdInvalid' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRegIdInvalid", "(Z)V", "GetSetRegIdInvalid_ZHandler")]
			set {
				if (id_setRegIdInvalid_Z == IntPtr.Zero)
					id_setRegIdInvalid_Z = JNIEnv.GetMethodID (class_ref, "setRegIdInvalid", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRegIdInvalid_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRegIdInvalid", "(Z)V"), __args);
				} finally {
				}
			}
		}

	}
}
