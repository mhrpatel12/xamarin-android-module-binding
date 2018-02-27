using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/SyncCallService", DoNotGenerateAcw=true)]
	public partial class SyncCallService : global::Java.Lang.Object {


		static IntPtr refreshView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/field[@name='refreshView']"
		[Register ("refreshView")]
		public static bool RefreshView {
			get {
				if (refreshView_jfieldId == IntPtr.Zero)
					refreshView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "refreshView", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, refreshView_jfieldId);
			}
			set {
				if (refreshView_jfieldId == IntPtr.Zero)
					refreshView_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "refreshView", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, refreshView_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/SyncCallService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncCallService); }
		}

		protected SyncCallService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLatestMessagesGroupByPeople;
#pragma warning disable 0169
		static Delegate GetGetLatestMessagesGroupByPeopleHandler ()
		{
			if (cb_getLatestMessagesGroupByPeople == null)
				cb_getLatestMessagesGroupByPeople = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLatestMessagesGroupByPeople);
			return cb_getLatestMessagesGroupByPeople;
		}

		static IntPtr n_GetLatestMessagesGroupByPeople (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.LatestMessagesGroupByPeople);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessagesGroupByPeople;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> LatestMessagesGroupByPeople {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='getLatestMessagesGroupByPeople' and count(parameter)=0]"
			[Register ("getLatestMessagesGroupByPeople", "()Ljava/util/List;", "GetGetLatestMessagesGroupByPeopleHandler")]
			get {
				if (id_getLatestMessagesGroupByPeople == IntPtr.Zero)
					id_getLatestMessagesGroupByPeople = JNIEnv.GetMethodID (class_ref, "getLatestMessagesGroupByPeople", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessagesGroupByPeople), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessagesGroupByPeople", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_checkAccountStatus;
#pragma warning disable 0169
		static Delegate GetCheckAccountStatusHandler ()
		{
			if (cb_checkAccountStatus == null)
				cb_checkAccountStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CheckAccountStatus);
			return cb_checkAccountStatus;
		}

		static void n_CheckAccountStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CheckAccountStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_checkAccountStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='checkAccountStatus' and count(parameter)=0]"
		[Register ("checkAccountStatus", "()V", "GetCheckAccountStatusHandler")]
		public virtual unsafe void CheckAccountStatus ()
		{
			if (id_checkAccountStatus == IntPtr.Zero)
				id_checkAccountStatus = JNIEnv.GetMethodID (class_ref, "checkAccountStatus", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_checkAccountStatus);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "checkAccountStatus", "()V"));
			} finally {
			}
		}

		static Delegate cb_deleteChannelConversationThread_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteChannelConversationThread_Ljava_lang_String_Handler ()
		{
			if (cb_deleteChannelConversationThread_Ljava_lang_String_ == null)
				cb_deleteChannelConversationThread_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteChannelConversationThread_Ljava_lang_String_);
			return cb_deleteChannelConversationThread_Ljava_lang_String_;
		}

		static void n_DeleteChannelConversationThread_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteChannelConversationThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannelConversationThread_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='deleteChannelConversationThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteChannelConversationThread", "(Ljava/lang/String;)V", "GetDeleteChannelConversationThread_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteChannelConversationThread (string p0)
		{
			if (id_deleteChannelConversationThread_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteChannelConversationThread_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteChannelConversationThread", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannelConversationThread_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannelConversationThread", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteConversationThread_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteConversationThread_Ljava_lang_String_Handler ()
		{
			if (cb_deleteConversationThread_Ljava_lang_String_ == null)
				cb_deleteConversationThread_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteConversationThread_Ljava_lang_String_);
			return cb_deleteConversationThread_Ljava_lang_String_;
		}

		static void n_DeleteConversationThread_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversationThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversationThread_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='deleteConversationThread' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteConversationThread", "(Ljava/lang/String;)V", "GetDeleteConversationThread_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteConversationThread (string p0)
		{
			if (id_deleteConversationThread_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteConversationThread_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteConversationThread", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteConversationThread_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteConversationThread", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Ljava_lang_String_Handler ()
		{
			if (cb_deleteMessage_Ljava_lang_String_ == null)
				cb_deleteMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Ljava_lang_String_);
			return cb_deleteMessage_Ljava_lang_String_;
		}

		static void n_DeleteMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteMessage", "(Ljava/lang/String;)V", "GetDeleteMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteMessage (string p0)
		{
			if (id_deleteMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/SyncCallService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/SyncCallService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_ == null)
				cb_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_);
			return cb_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessagesGroupByPeople (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='getLatestMessagesGroupByPeople' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getLatestMessagesGroupByPeople", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;", "GetGetLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessagesGroupByPeople (global::Java.Lang.Long p0, string p1)
		{
			if (id_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestMessagesGroupByPeople", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessagesGroupByPeople", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getLatestMessagesGroupByPeople_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestMessagesGroupByPeople_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestMessagesGroupByPeople_Ljava_lang_String_ == null)
				cb_getLatestMessagesGroupByPeople_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestMessagesGroupByPeople_Ljava_lang_String_);
			return cb_getLatestMessagesGroupByPeople_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestMessagesGroupByPeople_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessagesGroupByPeople (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessagesGroupByPeople_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='getLatestMessagesGroupByPeople' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLatestMessagesGroupByPeople", "(Ljava/lang/String;)Ljava/util/List;", "GetGetLatestMessagesGroupByPeople_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessagesGroupByPeople (string p0)
		{
			if (id_getLatestMessagesGroupByPeople_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestMessagesGroupByPeople_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestMessagesGroupByPeople", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessagesGroupByPeople_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessagesGroupByPeople", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processUserStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessUserStatus_Ljava_lang_String_Handler ()
		{
			if (cb_processUserStatus_Ljava_lang_String_ == null)
				cb_processUserStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserStatus_Ljava_lang_String_);
			return cb_processUserStatus_Ljava_lang_String_;
		}

		static void n_ProcessUserStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='processUserStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processUserStatus", "(Ljava/lang/String;)V", "GetProcessUserStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void ProcessUserStatus (string p0)
		{
			if (id_processUserStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_processUserStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processUserStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserStatus_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserStatus", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_syncBlockUsers;
#pragma warning disable 0169
		static Delegate GetSyncBlockUsersHandler ()
		{
			if (cb_syncBlockUsers == null)
				cb_syncBlockUsers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncBlockUsers);
			return cb_syncBlockUsers;
		}

		static void n_SyncBlockUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncBlockUsers ();
		}
#pragma warning restore 0169

		static IntPtr id_syncBlockUsers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='syncBlockUsers' and count(parameter)=0]"
		[Register ("syncBlockUsers", "()V", "GetSyncBlockUsersHandler")]
		public virtual unsafe void SyncBlockUsers ()
		{
			if (id_syncBlockUsers == IntPtr.Zero)
				id_syncBlockUsers = JNIEnv.GetMethodID (class_ref, "syncBlockUsers", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncBlockUsers);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncBlockUsers", "()V"));
			} finally {
			}
		}

		static Delegate cb_syncMessageMetadataUpdate_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSyncMessageMetadataUpdate_Ljava_lang_String_ZHandler ()
		{
			if (cb_syncMessageMetadataUpdate_Ljava_lang_String_Z == null)
				cb_syncMessageMetadataUpdate_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SyncMessageMetadataUpdate_Ljava_lang_String_Z);
			return cb_syncMessageMetadataUpdate_Ljava_lang_String_Z;
		}

		static void n_SyncMessageMetadataUpdate_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SyncMessageMetadataUpdate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_syncMessageMetadataUpdate_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='syncMessageMetadataUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("syncMessageMetadataUpdate", "(Ljava/lang/String;Z)V", "GetSyncMessageMetadataUpdate_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SyncMessageMetadataUpdate (string p0, bool p1)
		{
			if (id_syncMessageMetadataUpdate_Ljava_lang_String_Z == IntPtr.Zero)
				id_syncMessageMetadataUpdate_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "syncMessageMetadataUpdate", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMessageMetadataUpdate_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessageMetadataUpdate", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_syncMessages_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSyncMessages_Ljava_lang_String_Handler ()
		{
			if (cb_syncMessages_Ljava_lang_String_ == null)
				cb_syncMessages_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SyncMessages_Ljava_lang_String_);
			return cb_syncMessages_Ljava_lang_String_;
		}

		static void n_SyncMessages_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SyncMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_syncMessages_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='syncMessages' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("syncMessages", "(Ljava/lang/String;)V", "GetSyncMessages_Ljava_lang_String_Handler")]
		public virtual unsafe void SyncMessages (string p0)
		{
			if (id_syncMessages_Ljava_lang_String_ == IntPtr.Zero)
				id_syncMessages_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "syncMessages", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMessages_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessages", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_syncMutedUserList_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSyncMutedUserList_ZLjava_lang_String_Handler ()
		{
			if (cb_syncMutedUserList_ZLjava_lang_String_ == null)
				cb_syncMutedUserList_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_SyncMutedUserList_ZLjava_lang_String_);
			return cb_syncMutedUserList_ZLjava_lang_String_;
		}

		static void n_SyncMutedUserList_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SyncMutedUserList (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_syncMutedUserList_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='syncMutedUserList' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("syncMutedUserList", "(ZLjava/lang/String;)V", "GetSyncMutedUserList_ZLjava_lang_String_Handler")]
		public virtual unsafe void SyncMutedUserList (bool p0, string p1)
		{
			if (id_syncMutedUserList_ZLjava_lang_String_ == IntPtr.Zero)
				id_syncMutedUserList_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "syncMutedUserList", "(ZLjava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMutedUserList_ZLjava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMutedUserList", "(ZLjava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_syncUserDetail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSyncUserDetail_Ljava_lang_String_Handler ()
		{
			if (cb_syncUserDetail_Ljava_lang_String_ == null)
				cb_syncUserDetail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SyncUserDetail_Ljava_lang_String_);
			return cb_syncUserDetail_Ljava_lang_String_;
		}

		static void n_SyncUserDetail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SyncUserDetail (p0);
		}
#pragma warning restore 0169

		static IntPtr id_syncUserDetail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='syncUserDetail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("syncUserDetail", "(Ljava/lang/String;)V", "GetSyncUserDetail_Ljava_lang_String_Handler")]
		public virtual unsafe void SyncUserDetail (string p0)
		{
			if (id_syncUserDetail_Ljava_lang_String_ == IntPtr.Zero)
				id_syncUserDetail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "syncUserDetail", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncUserDetail_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncUserDetail", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
#pragma warning disable 0169
		static Delegate GetUpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler ()
		{
			if (cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == null)
				cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z);
			return cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		}

		static void n_UpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConnectedStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateConnectedStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='boolean']]"
		[Register ("updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V", "GetUpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler")]
		public virtual unsafe void UpdateConnectedStatus (string p0, global::Java.Util.Date p1, bool p2)
		{
			if (id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == IntPtr.Zero)
				id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNIEnv.GetMethodID (class_ref, "updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateConversationReadStatus_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateConversationReadStatus_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateConversationReadStatus_Ljava_lang_String_Z == null)
				cb_updateConversationReadStatus_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateConversationReadStatus_Ljava_lang_String_Z);
			return cb_updateConversationReadStatus_Ljava_lang_String_Z;
		}

		static void n_UpdateConversationReadStatus_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConversationReadStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateConversationReadStatus_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateConversationReadStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateConversationReadStatus", "(Ljava/lang/String;Z)V", "GetUpdateConversationReadStatus_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateConversationReadStatus (string p0, bool p1)
		{
			if (id_updateConversationReadStatus_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateConversationReadStatus_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateConversationReadStatus", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConversationReadStatus_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConversationReadStatus", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDeliveryStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDeliveryStatus_Ljava_lang_String_Handler ()
		{
			if (cb_updateDeliveryStatus_Ljava_lang_String_ == null)
				cb_updateDeliveryStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateDeliveryStatus_Ljava_lang_String_);
			return cb_updateDeliveryStatus_Ljava_lang_String_;
		}

		static void n_UpdateDeliveryStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeliveryStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeliveryStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateDeliveryStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateDeliveryStatus", "(Ljava/lang/String;)V", "GetUpdateDeliveryStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateDeliveryStatus (string p0)
		{
			if (id_updateDeliveryStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDeliveryStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDeliveryStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDeliveryStatus_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDeliveryStatus", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDeliveryStatusForContact_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateDeliveryStatusForContact_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateDeliveryStatusForContact_Ljava_lang_String_Z == null)
				cb_updateDeliveryStatusForContact_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateDeliveryStatusForContact_Ljava_lang_String_Z);
			return cb_updateDeliveryStatusForContact_Ljava_lang_String_Z;
		}

		static void n_UpdateDeliveryStatusForContact_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeliveryStatusForContact (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeliveryStatusForContact_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateDeliveryStatusForContact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateDeliveryStatusForContact", "(Ljava/lang/String;Z)V", "GetUpdateDeliveryStatusForContact_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateDeliveryStatusForContact (string p0, bool p1)
		{
			if (id_updateDeliveryStatusForContact_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateDeliveryStatusForContact_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateDeliveryStatusForContact", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDeliveryStatusForContact_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDeliveryStatusForContact", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateReadStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatus_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatus_Ljava_lang_String_ == null)
				cb_updateReadStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateReadStatus_Ljava_lang_String_);
			return cb_updateReadStatus_Ljava_lang_String_;
		}

		static void n_UpdateReadStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateReadStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateReadStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatus", "(Ljava/lang/String;)V", "GetUpdateReadStatus_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateReadStatus (string p0)
		{
			if (id_updateReadStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatus", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatus_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatus", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateUserBlocked_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlocked_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlocked_Ljava_lang_String_Z == null)
				cb_updateUserBlocked_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlocked_Ljava_lang_String_Z);
			return cb_updateUserBlocked_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlocked_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlocked (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlocked_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateUserBlocked' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlocked", "(Ljava/lang/String;Z)V", "GetUpdateUserBlocked_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlocked (string p0, bool p1)
		{
			if (id_updateUserBlocked_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlocked_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlocked", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlocked_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlocked", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateUserBlockedBy_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlockedBy_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlockedBy_Ljava_lang_String_Z == null)
				cb_updateUserBlockedBy_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlockedBy_Ljava_lang_String_Z);
			return cb_updateUserBlockedBy_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlockedBy_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.SyncCallService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlockedBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlockedBy_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='SyncCallService']/method[@name='updateUserBlockedBy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlockedBy", "(Ljava/lang/String;Z)V", "GetUpdateUserBlockedBy_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlockedBy (string p0, bool p1)
		{
			if (id_updateUserBlockedBy_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlockedBy_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlockedBy", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlockedBy_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlockedBy", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
