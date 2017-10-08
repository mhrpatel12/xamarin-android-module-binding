using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/database/MessageDatabaseService", DoNotGenerateAcw=true)]
	public partial class MessageDatabaseService : global::Java.Lang.Object {


		static IntPtr recentlyAddedMessage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/field[@name='recentlyAddedMessage']"
		[Register ("recentlyAddedMessage")]
		public static global::System.Collections.IList RecentlyAddedMessage {
			get {
				if (recentlyAddedMessage_jfieldId == IntPtr.Zero)
					recentlyAddedMessage_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "recentlyAddedMessage", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, recentlyAddedMessage_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (recentlyAddedMessage_jfieldId == IntPtr.Zero)
					recentlyAddedMessage_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "recentlyAddedMessage", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, recentlyAddedMessage_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/database/MessageDatabaseService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageDatabaseService); }
		}

		protected MessageDatabaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/constructor[@name='MessageDatabaseService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MessageDatabaseService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessageDatabaseService)) {
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

		static Delegate cb_isMessageTableEmpty;
#pragma warning disable 0169
		static Delegate GetIsMessageTableEmptyHandler ()
		{
			if (cb_isMessageTableEmpty == null)
				cb_isMessageTableEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMessageTableEmpty);
			return cb_isMessageTableEmpty;
		}

		static bool n_IsMessageTableEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMessageTableEmpty;
		}
#pragma warning restore 0169

		static IntPtr id_isMessageTableEmpty;
		public virtual unsafe bool IsMessageTableEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='isMessageTableEmpty' and count(parameter)=0]"
			[Register ("isMessageTableEmpty", "()Z", "GetIsMessageTableEmptyHandler")]
			get {
				if (id_isMessageTableEmpty == IntPtr.Zero)
					id_isMessageTableEmpty = JNIEnv.GetMethodID (class_ref, "isMessageTableEmpty", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMessageTableEmpty);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessageTableEmpty", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMinCreatedAtFromMessageTable;
#pragma warning disable 0169
		static Delegate GetGetMinCreatedAtFromMessageTableHandler ()
		{
			if (cb_getMinCreatedAtFromMessageTable == null)
				cb_getMinCreatedAtFromMessageTable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMinCreatedAtFromMessageTable);
			return cb_getMinCreatedAtFromMessageTable;
		}

		static long n_GetMinCreatedAtFromMessageTable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinCreatedAtFromMessageTable;
		}
#pragma warning restore 0169

		static IntPtr id_getMinCreatedAtFromMessageTable;
		public virtual unsafe long MinCreatedAtFromMessageTable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMinCreatedAtFromMessageTable' and count(parameter)=0]"
			[Register ("getMinCreatedAtFromMessageTable", "()J", "GetGetMinCreatedAtFromMessageTableHandler")]
			get {
				if (id_getMinCreatedAtFromMessageTable == IntPtr.Zero)
					id_getMinCreatedAtFromMessageTable = JNIEnv.GetMethodID (class_ref, "getMinCreatedAtFromMessageTable", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getMinCreatedAtFromMessageTable);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinCreatedAtFromMessageTable", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getPendingDeleteMessages;
#pragma warning disable 0169
		static Delegate GetGetPendingDeleteMessagesHandler ()
		{
			if (cb_getPendingDeleteMessages == null)
				cb_getPendingDeleteMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingDeleteMessages);
			return cb_getPendingDeleteMessages;
		}

		static IntPtr n_GetPendingDeleteMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.PendingDeleteMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getPendingDeleteMessages;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> PendingDeleteMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getPendingDeleteMessages' and count(parameter)=0]"
			[Register ("getPendingDeleteMessages", "()Ljava/util/List;", "GetGetPendingDeleteMessagesHandler")]
			get {
				if (id_getPendingDeleteMessages == IntPtr.Zero)
					id_getPendingDeleteMessages = JNIEnv.GetMethodID (class_ref, "getPendingDeleteMessages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDeleteMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingDeleteMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPendingMessages;
#pragma warning disable 0169
		static Delegate GetGetPendingMessagesHandler ()
		{
			if (cb_getPendingMessages == null)
				cb_getPendingMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPendingMessages);
			return cb_getPendingMessages;
		}

		static IntPtr n_GetPendingMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.PendingMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getPendingMessages;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> PendingMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getPendingMessages' and count(parameter)=0]"
			[Register ("getPendingMessages", "()Ljava/util/List;", "GetGetPendingMessagesHandler")]
			get {
				if (id_getPendingMessages == IntPtr.Zero)
					id_getPendingMessages = JNIEnv.GetMethodID (class_ref, "getPendingMessages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPendingMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetTotalUnreadCountHandler ()
		{
			if (cb_getTotalUnreadCount == null)
				cb_getTotalUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalUnreadCount);
			return cb_getTotalUnreadCount;
		}

		static int n_GetTotalUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalUnreadCount;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalUnreadCount;
		public virtual unsafe int TotalUnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getTotalUnreadCount' and count(parameter)=0]"
			[Register ("getTotalUnreadCount", "()I", "GetGetTotalUnreadCountHandler")]
			get {
				if (id_getTotalUnreadCount == IntPtr.Zero)
					id_getTotalUnreadCount = JNIEnv.GetMethodID (class_ref, "getTotalUnreadCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalUnreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalUnreadCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadConversationCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadConversationCountHandler ()
		{
			if (cb_getUnreadConversationCount == null)
				cb_getUnreadConversationCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadConversationCount);
			return cb_getUnreadConversationCount;
		}

		static int n_GetUnreadConversationCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadConversationCount;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadConversationCount;
		public virtual unsafe int UnreadConversationCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getUnreadConversationCount' and count(parameter)=0]"
			[Register ("getUnreadConversationCount", "()I", "GetGetUnreadConversationCountHandler")]
			get {
				if (id_getUnreadConversationCount == IntPtr.Zero)
					id_getUnreadConversationCount = JNIEnv.GetMethodID (class_ref, "getUnreadConversationCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadConversationCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadConversationCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadMessageCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessageCountHandler ()
		{
			if (cb_getUnreadMessageCount == null)
				cb_getUnreadMessageCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadMessageCount);
			return cb_getUnreadMessageCount;
		}

		static int n_GetUnreadMessageCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadMessageCount;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessageCount;
		public virtual unsafe int UnreadMessageCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getUnreadMessageCount' and count(parameter)=0]"
			[Register ("getUnreadMessageCount", "()I", "GetGetUnreadMessageCountHandler")]
			get {
				if (id_getUnreadMessageCount == IntPtr.Zero)
					id_getUnreadMessageCount = JNIEnv.GetMethodID (class_ref, "getUnreadMessageCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessageCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessageCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadMessages;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessagesHandler ()
		{
			if (cb_getUnreadMessages == null)
				cb_getUnreadMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnreadMessages);
			return cb_getUnreadMessages;
		}

		static IntPtr n_GetUnreadMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.UnreadMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessages;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> UnreadMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getUnreadMessages' and count(parameter)=0]"
			[Register ("getUnreadMessages", "()Ljava/util/List;", "GetGetUnreadMessagesHandler")]
			get {
				if (id_getUnreadMessages == IntPtr.Zero)
					id_getUnreadMessages = JNIEnv.GetMethodID (class_ref, "getUnreadMessages", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessages), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessages", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetCreateMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_CreateMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static long n_CreateMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CreateMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='createMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("createMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J", "GetCreateMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe long CreateMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "createMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetCreateSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_CreateSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static long n_CreateSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.CreateSingleMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='createSingleMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("createSingleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J", "GetCreateSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe long CreateSingleMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "createSingleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_createSingleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createSingleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)J"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteChannelConversation_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteChannelConversation_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteChannelConversation_Ljava_lang_Integer_ == null)
				cb_deleteChannelConversation_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteChannelConversation_Ljava_lang_Integer_);
			return cb_deleteChannelConversation_Ljava_lang_Integer_;
		}

		static void n_DeleteChannelConversation_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteChannelConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannelConversation_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteChannelConversation' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("deleteChannelConversation", "(Ljava/lang/Integer;)V", "GetDeleteChannelConversation_Ljava_lang_Integer_Handler")]
		public virtual unsafe void DeleteChannelConversation (global::Java.Lang.Integer p0)
		{
			if (id_deleteChannelConversation_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteChannelConversation_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteChannelConversation", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannelConversation_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannelConversation", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteConversation_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteConversation_Ljava_lang_String_Handler ()
		{
			if (cb_deleteConversation_Ljava_lang_String_ == null)
				cb_deleteConversation_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteConversation_Ljava_lang_String_);
			return cb_deleteConversation_Ljava_lang_String_;
		}

		static void n_DeleteConversation_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteConversation", "(Ljava/lang/String;)V", "GetDeleteConversation_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteConversation (string p0)
		{
			if (id_deleteConversation_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteConversation_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteConversation", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteConversation_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteConversation", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static IntPtr n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;", "GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe string DeleteMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetDeleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_DeleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteMessageFromDb (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteMessageFromDb' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("deleteMessageFromDb", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetDeleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void DeleteMessageFromDb (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "deleteMessageFromDb", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessageFromDb_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessageFromDb", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteScheduledMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteScheduledMessage_Ljava_lang_String_Handler ()
		{
			if (cb_deleteScheduledMessage_Ljava_lang_String_ == null)
				cb_deleteScheduledMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteScheduledMessage_Ljava_lang_String_);
			return cb_deleteScheduledMessage_Ljava_lang_String_;
		}

		static bool n_DeleteScheduledMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteScheduledMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteScheduledMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteScheduledMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteScheduledMessage", "(Ljava/lang/String;)Z", "GetDeleteScheduledMessage_Ljava_lang_String_Handler")]
		public virtual unsafe bool DeleteScheduledMessage (string p0)
		{
			if (id_deleteScheduledMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteScheduledMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteScheduledMessage", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteScheduledMessage_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteScheduledMessage", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteScheduledMessages_J;
#pragma warning disable 0169
		static Delegate GetDeleteScheduledMessages_JHandler ()
		{
			if (cb_deleteScheduledMessages_J == null)
				cb_deleteScheduledMessages_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_DeleteScheduledMessages_J);
			return cb_deleteScheduledMessages_J;
		}

		static void n_DeleteScheduledMessages_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteScheduledMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteScheduledMessages_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='deleteScheduledMessages' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("deleteScheduledMessages", "(J)V", "GetDeleteScheduledMessages_JHandler")]
		public virtual unsafe void DeleteScheduledMessages (long p0)
		{
			if (id_deleteScheduledMessages_J == IntPtr.Zero)
				id_deleteScheduledMessages_J = JNIEnv.GetMethodID (class_ref, "deleteScheduledMessages", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteScheduledMessages_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteScheduledMessages", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMessagesByChannelKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_ == null)
				cb_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelCustomMessagesByChannelKey_Ljava_lang_Integer_);
			return cb_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelCustomMessagesByChannelKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetChannelCustomMessagesByChannelKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getChannelCustomMessagesByChannelKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelCustomMessagesByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;", "GetGetChannelCustomMessagesByChannelKey_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetChannelCustomMessagesByChannelKey (global::Java.Lang.Integer p0)
		{
			if (id_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelCustomMessagesByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMessagesByChannelKey_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMessagesByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMessagesByClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_ == null)
				cb_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelCustomMessagesByClientGroupId_Ljava_lang_String_);
			return cb_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelCustomMessagesByClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetChannelCustomMessagesByClientGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getChannelCustomMessagesByClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelCustomMessagesByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;", "GetGetChannelCustomMessagesByClientGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetChannelCustomMessagesByClientGroupId (string p0)
		{
			if (id_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelCustomMessagesByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMessagesByClientGroupId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMessagesByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLatestMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestMessage_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestMessage_Ljava_lang_String_ == null)
				cb_getLatestMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestMessage_Ljava_lang_String_);
			return cb_getLatestMessage_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getLatestMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLatestMessage", "(Ljava/lang/String;)Ljava/util/List;", "GetGetLatestMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessage (string p0)
		{
			if (id_getLatestMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestMessage", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessage", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLatestMessageByChannelKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetLatestMessageByChannelKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_getLatestMessageByChannelKey_Ljava_lang_Integer_ == null)
				cb_getLatestMessageByChannelKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestMessageByChannelKey_Ljava_lang_Integer_);
			return cb_getLatestMessageByChannelKey_Ljava_lang_Integer_;
		}

		static IntPtr n_GetLatestMessageByChannelKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessageByChannelKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessageByChannelKey_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getLatestMessageByChannelKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getLatestMessageByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;", "GetGetLatestMessageByChannelKey_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessageByChannelKey (global::Java.Lang.Integer p0)
		{
			if (id_getLatestMessageByChannelKey_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getLatestMessageByChannelKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getLatestMessageByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessageByChannelKey_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessageByChannelKey", "(Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getLatestMessageByClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLatestMessageByClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_getLatestMessageByClientGroupId_Ljava_lang_String_ == null)
				cb_getLatestMessageByClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetLatestMessageByClientGroupId_Ljava_lang_String_);
			return cb_getLatestMessageByClientGroupId_Ljava_lang_String_;
		}

		static IntPtr n_GetLatestMessageByClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessageByClientGroupId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessageByClientGroupId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getLatestMessageByClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLatestMessageByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;", "GetGetLatestMessageByClientGroupId_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessageByClientGroupId (string p0)
		{
			if (id_getLatestMessageByClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
				id_getLatestMessageByClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getLatestMessageByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLatestMessageByClientGroupId_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatestMessageByClientGroupId", "(Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getLatestMessageList_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getLatestMessageList' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getLatestMessageList", "(Landroid/database/Cursor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessageList (global::Android.Database.ICursor p0)
		{
			if (id_getLatestMessageList_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getLatestMessageList_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getLatestMessageList", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLatestMessageList_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getLatestMessageListForNotification_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getLatestMessageListForNotification' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getLatestMessageListForNotification", "(Landroid/database/Cursor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetLatestMessageListForNotification (global::Android.Database.ICursor p0)
		{
			if (id_getLatestMessageListForNotification_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getLatestMessageListForNotification_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getLatestMessageListForNotification", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getLatestMessageListForNotification_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getMessage_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getMessage", "(Landroid/database/Cursor;)Lcom/applozic/mobicomkit/api/conversation/Message;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message GetMessage (global::Android.Database.ICursor p0)
		{
			if (id_getMessage_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getMessage_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getMessage", "(Landroid/database/Cursor;)Lcom/applozic/mobicomkit/api/conversation/Message;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Conversation.Message __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessage_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessage_Ljava_lang_String_Handler ()
		{
			if (cb_getMessage_Ljava_lang_String_ == null)
				cb_getMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessage_Ljava_lang_String_);
			return cb_getMessage_Ljava_lang_String_;
		}

		static IntPtr n_GetMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessage_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message GetMessage (string p0)
		{
			if (id_getMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.Message __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessage_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessage_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMessage_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMessage_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessage_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMessage_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMessage_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessage_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message GetMessage (string p0, string p1)
		{
			if (id_getMessage_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessage_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Api.Conversation.Message __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getMessageList_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessageList' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getMessageList", "(Landroid/database/Cursor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessageList (global::Android.Database.ICursor p0)
		{
			if (id_getMessageList_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getMessageList_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageList", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getMessageList_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessages_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_lang_Long_Handler ()
		{
			if (cb_getMessages_Ljava_lang_Long_ == null)
				cb_getMessages_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Ljava_lang_Long_);
			return cb_getMessages_Ljava_lang_Long_;
		}

		static IntPtr n_GetMessages_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getMessages", "(Ljava/lang/Long;)Ljava/util/List;", "GetGetMessages_Ljava_lang_Long_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessages (global::Java.Lang.Long p0)
		{
			if (id_getMessages_Ljava_lang_Long_ == IntPtr.Zero)
				id_getMessages_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/lang/Long;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Ljava/lang/Long;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler ()
		{
			if (cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == null)
				cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_);
			return cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		}

		static IntPtr n_GetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p3 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetMessages (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessages' and count(parameter)=5 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[4][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[5][@type='java.lang.Integer']]"
		[Register ("getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/util/List;", "GetGetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessages (global::Java.Lang.Long p0, global::Java.Lang.Long p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2, global::Com.Applozic.Mobicommons.People.Channel.Channel p3, global::Java.Lang.Integer p4)
		{
			if (id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessages_Ljava_lang_Long_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_lang_Long_Ljava_lang_String_Handler ()
		{
			if (cb_getMessages_Ljava_lang_Long_Ljava_lang_String_ == null)
				cb_getMessages_Ljava_lang_Long_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Ljava_lang_Long_Ljava_lang_String_);
			return cb_getMessages_Ljava_lang_Long_Ljava_lang_String_;
		}

		static IntPtr n_GetMessages_Ljava_lang_Long_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetMessages (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getMessages' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMessages", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;", "GetGetMessages_Ljava_lang_Long_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessages (global::Java.Lang.Long p0, string p1)
		{
			if (id_getMessages_Ljava_lang_Long_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessages_Ljava_lang_Long_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Ljava_lang_Long_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Ljava/lang/Long;Ljava/lang/String;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getScheduledMessages_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetScheduledMessages_Ljava_lang_Long_Handler ()
		{
			if (cb_getScheduledMessages_Ljava_lang_Long_ == null)
				cb_getScheduledMessages_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScheduledMessages_Ljava_lang_Long_);
			return cb_getScheduledMessages_Ljava_lang_Long_;
		}

		static IntPtr n_GetScheduledMessages_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetScheduledMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getScheduledMessages_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getScheduledMessages' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getScheduledMessages", "(Ljava/lang/Long;)Ljava/util/List;", "GetGetScheduledMessages_Ljava_lang_Long_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetScheduledMessages (global::Java.Lang.Long p0)
		{
			if (id_getScheduledMessages_Ljava_lang_Long_ == IntPtr.Zero)
				id_getScheduledMessages_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "getScheduledMessages", "(Ljava/lang/Long;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScheduledMessages_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScheduledMessages", "(Ljava/lang/Long;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getUnreadMessageCountForChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessageCountForChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_getUnreadMessageCountForChannel_Ljava_lang_Integer_ == null)
				cb_getUnreadMessageCountForChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUnreadMessageCountForChannel_Ljava_lang_Integer_);
			return cb_getUnreadMessageCountForChannel_Ljava_lang_Integer_;
		}

		static int n_GetUnreadMessageCountForChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUnreadMessageCountForChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessageCountForChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getUnreadMessageCountForChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getUnreadMessageCountForChannel", "(Ljava/lang/Integer;)I", "GetGetUnreadMessageCountForChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetUnreadMessageCountForChannel (global::Java.Lang.Integer p0)
		{
			if (id_getUnreadMessageCountForChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getUnreadMessageCountForChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getUnreadMessageCountForChannel", "(Ljava/lang/Integer;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessageCountForChannel_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessageCountForChannel", "(Ljava/lang/Integer;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getUnreadMessageCountForContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUnreadMessageCountForContact_Ljava_lang_String_Handler ()
		{
			if (cb_getUnreadMessageCountForContact_Ljava_lang_String_ == null)
				cb_getUnreadMessageCountForContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetUnreadMessageCountForContact_Ljava_lang_String_);
			return cb_getUnreadMessageCountForContact_Ljava_lang_String_;
		}

		static int n_GetUnreadMessageCountForContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUnreadMessageCountForContact (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadMessageCountForContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='getUnreadMessageCountForContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUnreadMessageCountForContact", "(Ljava/lang/String;)I", "GetGetUnreadMessageCountForContact_Ljava_lang_String_Handler")]
		public virtual unsafe int GetUnreadMessageCountForContact (string p0)
		{
			if (id_getUnreadMessageCountForContact_Ljava_lang_String_ == IntPtr.Zero)
				id_getUnreadMessageCountForContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUnreadMessageCountForContact", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadMessageCountForContact_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadMessageCountForContact", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isMessagePresent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsMessagePresent_Ljava_lang_String_Handler ()
		{
			if (cb_isMessagePresent_Ljava_lang_String_ == null)
				cb_isMessagePresent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsMessagePresent_Ljava_lang_String_);
			return cb_isMessagePresent_Ljava_lang_String_;
		}

		static bool n_IsMessagePresent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMessagePresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMessagePresent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='isMessagePresent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isMessagePresent", "(Ljava/lang/String;)Z", "GetIsMessagePresent_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsMessagePresent (string p0)
		{
			if (id_isMessagePresent_Ljava_lang_String_ == IntPtr.Zero)
				id_isMessagePresent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isMessagePresent", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMessagePresent_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessagePresent", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetIsMessagePresent_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsMessagePresent_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static bool n_IsMessagePresent_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMessagePresent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='isMessagePresent' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("isMessagePresent", "(Ljava/lang/String;Ljava/lang/Integer;)Z", "GetIsMessagePresent_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool IsMessagePresent (string p0, global::Java.Lang.Integer p1)
		{
			if (id_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "isMessagePresent", "(Ljava/lang/String;Ljava/lang/Integer;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMessagePresent_Ljava_lang_String_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessagePresent", "(Ljava/lang/String;Ljava/lang/Integer;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateCanceledFlag_JI;
#pragma warning disable 0169
		static Delegate GetUpdateCanceledFlag_JIHandler ()
		{
			if (cb_updateCanceledFlag_JI == null)
				cb_updateCanceledFlag_JI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, int>) n_UpdateCanceledFlag_JI);
			return cb_updateCanceledFlag_JI;
		}

		static void n_UpdateCanceledFlag_JI (IntPtr jnienv, IntPtr native__this, long p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateCanceledFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateCanceledFlag_JI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateCanceledFlag' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("updateCanceledFlag", "(JI)V", "GetUpdateCanceledFlag_JIHandler")]
		public virtual unsafe void UpdateCanceledFlag (long p0, int p1)
		{
			if (id_updateCanceledFlag_JI == IntPtr.Zero)
				id_updateCanceledFlag_JI = JNIEnv.GetMethodID (class_ref, "updateCanceledFlag", "(JI)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateCanceledFlag_JI, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateCanceledFlag", "(JI)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateChannelUnreadCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetUpdateChannelUnreadCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_updateChannelUnreadCount_Ljava_lang_Integer_ == null)
				cb_updateChannelUnreadCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateChannelUnreadCount_Ljava_lang_Integer_);
			return cb_updateChannelUnreadCount_Ljava_lang_Integer_;
		}

		static void n_UpdateChannelUnreadCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannelUnreadCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannelUnreadCount_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateChannelUnreadCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("updateChannelUnreadCount", "(Ljava/lang/Integer;)V", "GetUpdateChannelUnreadCount_Ljava_lang_Integer_Handler")]
		public virtual unsafe void UpdateChannelUnreadCount (global::Java.Lang.Integer p0)
		{
			if (id_updateChannelUnreadCount_Ljava_lang_Integer_ == IntPtr.Zero)
				id_updateChannelUnreadCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "updateChannelUnreadCount", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannelUnreadCount_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannelUnreadCount", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateChannelUnreadCountToZero_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetUpdateChannelUnreadCountToZero_Ljava_lang_Integer_Handler ()
		{
			if (cb_updateChannelUnreadCountToZero_Ljava_lang_Integer_ == null)
				cb_updateChannelUnreadCountToZero_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateChannelUnreadCountToZero_Ljava_lang_Integer_);
			return cb_updateChannelUnreadCountToZero_Ljava_lang_Integer_;
		}

		static void n_UpdateChannelUnreadCountToZero_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateChannelUnreadCountToZero (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateChannelUnreadCountToZero_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateChannelUnreadCountToZero' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("updateChannelUnreadCountToZero", "(Ljava/lang/Integer;)V", "GetUpdateChannelUnreadCountToZero_Ljava_lang_Integer_Handler")]
		public virtual unsafe void UpdateChannelUnreadCountToZero (global::Java.Lang.Integer p0)
		{
			if (id_updateChannelUnreadCountToZero_Ljava_lang_Integer_ == IntPtr.Zero)
				id_updateChannelUnreadCountToZero_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "updateChannelUnreadCountToZero", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateChannelUnreadCountToZero_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannelUnreadCountToZero", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateContactUnreadCount_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateContactUnreadCount_Ljava_lang_String_Handler ()
		{
			if (cb_updateContactUnreadCount_Ljava_lang_String_ == null)
				cb_updateContactUnreadCount_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateContactUnreadCount_Ljava_lang_String_);
			return cb_updateContactUnreadCount_Ljava_lang_String_;
		}

		static void n_UpdateContactUnreadCount_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContactUnreadCount (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContactUnreadCount_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateContactUnreadCount' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateContactUnreadCount", "(Ljava/lang/String;)V", "GetUpdateContactUnreadCount_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateContactUnreadCount (string p0)
		{
			if (id_updateContactUnreadCount_Ljava_lang_String_ == IntPtr.Zero)
				id_updateContactUnreadCount_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateContactUnreadCount", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContactUnreadCount_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContactUnreadCount", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateContactUnreadCountToZero_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateContactUnreadCountToZero_Ljava_lang_String_Handler ()
		{
			if (cb_updateContactUnreadCountToZero_Ljava_lang_String_ == null)
				cb_updateContactUnreadCountToZero_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateContactUnreadCountToZero_Ljava_lang_String_);
			return cb_updateContactUnreadCountToZero_Ljava_lang_String_;
		}

		static void n_UpdateContactUnreadCountToZero_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContactUnreadCountToZero (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContactUnreadCountToZero_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateContactUnreadCountToZero' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateContactUnreadCountToZero", "(Ljava/lang/String;)V", "GetUpdateContactUnreadCountToZero_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateContactUnreadCountToZero (string p0)
		{
			if (id_updateContactUnreadCountToZero_Ljava_lang_String_ == IntPtr.Zero)
				id_updateContactUnreadCountToZero_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateContactUnreadCountToZero", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContactUnreadCountToZero_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContactUnreadCountToZero", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_UpdateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeleteSyncStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateDeleteSyncStatus' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateDeleteSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetUpdateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateDeleteSyncStatus (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDeleteSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDeleteSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDeleteSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateInternalFilePath_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateInternalFilePath_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateInternalFilePath_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateInternalFilePath (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateInternalFilePath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateInternalFilePath", "(Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateInternalFilePath_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateInternalFilePath (string p0, string p1)
		{
			if (id_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateInternalFilePath", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateInternalFilePath_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateInternalFilePath", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z == null)
				cb_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z);
			return cb_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z;
		}

		static void n_UpdateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessage (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessage' and count(parameter)=4 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='boolean']]"
		[Register ("updateMessage", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Z)V", "GetUpdateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateMessage (global::Java.Lang.Long p0, global::Java.Lang.Long p1, string p2, bool p3)
		{
			if (id_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateMessage", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Z)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessage_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessage", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateMessageDeliveryReportForContact_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Z == null)
				cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool, int>) n_UpdateMessageDeliveryReportForContact_Ljava_lang_String_Z);
			return cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Z;
		}

		static int n_UpdateMessageDeliveryReportForContact_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateMessageDeliveryReportForContact (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageDeliveryReportForContact_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageDeliveryReportForContact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateMessageDeliveryReportForContact", "(Ljava/lang/String;Z)I", "GetUpdateMessageDeliveryReportForContact_Ljava_lang_String_ZHandler")]
		public virtual unsafe int UpdateMessageDeliveryReportForContact (string p0, bool p1)
		{
			if (id_updateMessageDeliveryReportForContact_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateMessageDeliveryReportForContact_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateMessageDeliveryReportForContact", "(Ljava/lang/String;Z)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageDeliveryReportForContact_Ljava_lang_String_Z, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageDeliveryReportForContact", "(Ljava/lang/String;Z)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static void n_UpdateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageDeliveryReportForContact (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageDeliveryReportForContact' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("updateMessageDeliveryReportForContact", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetUpdateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateMessageDeliveryReportForContact (string p0, string p1, bool p2)
		{
			if (id_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateMessageDeliveryReportForContact", "(Ljava/lang/String;Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageDeliveryReportForContact_Ljava_lang_String_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageDeliveryReportForContact", "(Ljava/lang/String;Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, IntPtr>) n_UpdateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_UpdateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageFileMetas (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageFileMetas' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("updateMessageFileMetas", "(JLcom/applozic/mobicomkit/api/conversation/Message;)V", "GetUpdateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void UpdateMessageFileMetas (long p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1)
		{
			if (id_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "updateMessageFileMetas", "(JLcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageFileMetas_JLcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageFileMetas", "(JLcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateMessageReadFlag_JZ;
#pragma warning disable 0169
		static Delegate GetUpdateMessageReadFlag_JZHandler ()
		{
			if (cb_updateMessageReadFlag_JZ == null)
				cb_updateMessageReadFlag_JZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long, bool>) n_UpdateMessageReadFlag_JZ);
			return cb_updateMessageReadFlag_JZ;
		}

		static void n_UpdateMessageReadFlag_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageReadFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageReadFlag_JZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageReadFlag' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("updateMessageReadFlag", "(JZ)V", "GetUpdateMessageReadFlag_JZHandler")]
		public virtual unsafe void UpdateMessageReadFlag (long p0, bool p1)
		{
			if (id_updateMessageReadFlag_JZ == IntPtr.Zero)
				id_updateMessageReadFlag_JZ = JNIEnv.GetMethodID (class_ref, "updateMessageReadFlag", "(JZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageReadFlag_JZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageReadFlag", "(JZ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static void n_UpdateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageReplyType (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageReplyType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("updateMessageReplyType", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetUpdateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe void UpdateMessageReplyType (string p0, global::Java.Lang.Integer p1)
		{
			if (id_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "updateMessageReplyType", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageReplyType_Ljava_lang_String_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageReplyType", "(Ljava/lang/String;Ljava/lang/Integer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_UpdateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMessageSyncStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateMessageSyncStatus' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateMessageSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetUpdateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateMessageSyncStatus (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateMessageSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMessageSyncStatus_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMessageSyncStatus", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateReadStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatus_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatus_Ljava_lang_String_ == null)
				cb_updateReadStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_UpdateReadStatus_Ljava_lang_String_);
			return cb_updateReadStatus_Ljava_lang_String_;
		}

		static int n_UpdateReadStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateReadStatus (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateReadStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatus", "(Ljava/lang/String;)I", "GetUpdateReadStatus_Ljava_lang_String_Handler")]
		public virtual unsafe int UpdateReadStatus (string p0)
		{
			if (id_updateReadStatus_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatus", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatus_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatus", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateReadStatusForChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatusForChannel_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatusForChannel_Ljava_lang_String_ == null)
				cb_updateReadStatusForChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_UpdateReadStatusForChannel_Ljava_lang_String_);
			return cb_updateReadStatusForChannel_Ljava_lang_String_;
		}

		static int n_UpdateReadStatusForChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateReadStatusForChannel (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatusForChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateReadStatusForChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatusForChannel", "(Ljava/lang/String;)I", "GetUpdateReadStatusForChannel_Ljava_lang_String_Handler")]
		public virtual unsafe int UpdateReadStatusForChannel (string p0)
		{
			if (id_updateReadStatusForChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatusForChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatusForChannel", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatusForChannel_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatusForChannel", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateReadStatusForContact_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatusForContact_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatusForContact_Ljava_lang_String_ == null)
				cb_updateReadStatusForContact_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_UpdateReadStatusForContact_Ljava_lang_String_);
			return cb_updateReadStatusForContact_Ljava_lang_String_;
		}

		static int n_UpdateReadStatusForContact_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateReadStatusForContact (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatusForContact_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateReadStatusForContact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatusForContact", "(Ljava/lang/String;)I", "GetUpdateReadStatusForContact_Ljava_lang_String_Handler")]
		public virtual unsafe int UpdateReadStatusForContact (string p0)
		{
			if (id_updateReadStatusForContact_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatusForContact_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatusForContact", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatusForContact_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatusForContact", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateReadStatusForKeyString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatusForKeyString_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatusForKeyString_Ljava_lang_String_ == null)
				cb_updateReadStatusForKeyString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_UpdateReadStatusForKeyString_Ljava_lang_String_);
			return cb_updateReadStatusForKeyString_Ljava_lang_String_;
		}

		static int n_UpdateReadStatusForKeyString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.UpdateReadStatusForKeyString (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatusForKeyString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateReadStatusForKeyString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatusForKeyString", "(Ljava/lang/String;)I", "GetUpdateReadStatusForKeyString_Ljava_lang_String_Handler")]
		public virtual unsafe int UpdateReadStatusForKeyString (string p0)
		{
			if (id_updateReadStatusForKeyString_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatusForKeyString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatusForKeyString", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatusForKeyString_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatusForKeyString", "(Ljava/lang/String;)I"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateReplyFlag_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetUpdateReplyFlag_Ljava_lang_String_IHandler ()
		{
			if (cb_updateReplyFlag_Ljava_lang_String_I == null)
				cb_updateReplyFlag_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_UpdateReplyFlag_Ljava_lang_String_I);
			return cb_updateReplyFlag_Ljava_lang_String_I;
		}

		static void n_UpdateReplyFlag_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateReplyFlag (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateReplyFlag_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateReplyFlag' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("updateReplyFlag", "(Ljava/lang/String;I)V", "GetUpdateReplyFlag_Ljava_lang_String_IHandler")]
		public virtual unsafe void UpdateReplyFlag (string p0, int p1)
		{
			if (id_updateReplyFlag_Ljava_lang_String_I == IntPtr.Zero)
				id_updateReplyFlag_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "updateReplyFlag", "(Ljava/lang/String;I)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateReplyFlag_Ljava_lang_String_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReplyFlag", "(Ljava/lang/String;I)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_;
#pragma warning disable 0169
		static Delegate GetUpdateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_Handler ()
		{
			if (cb_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_ == null)
				cb_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_);
			return cb_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_;
		}

		static void n_UpdateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSmsType (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='MessageDatabaseService']/method[@name='updateSmsType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message.MessageType']]"
		[Register ("updateSmsType", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;)V", "GetUpdateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_Handler")]
		public virtual unsafe void UpdateSmsType (string p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message.MessageType p1)
		{
			if (id_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_ == IntPtr.Zero)
				id_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_ = JNIEnv.GetMethodID (class_ref, "updateSmsType", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateSmsType_Ljava_lang_String_Lcom_applozic_mobicomkit_api_conversation_Message_MessageType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateSmsType", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/conversation/Message$MessageType;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
