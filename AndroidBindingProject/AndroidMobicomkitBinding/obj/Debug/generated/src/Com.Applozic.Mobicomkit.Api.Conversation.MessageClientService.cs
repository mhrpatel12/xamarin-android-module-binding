using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/MessageClientService", DoNotGenerateAcw=true)]
	public partial class MessageClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='ARGUMRNT_SAPERATOR']"
		[Register ("ARGUMRNT_SAPERATOR")]
		public const string ArgumrntSaperator = (string) "&";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='DEVICE_KEY']"
		[Register ("DEVICE_KEY")]
		public const string DeviceKey = (string) "deviceKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='FILE_META']"
		[Register ("FILE_META")]
		public const string FileMeta = (string) "fileMeta";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='LAST_SYNC_KEY']"
		[Register ("LAST_SYNC_KEY")]
		public const string LastSyncKey = (string) "lastSyncTime";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='PRODUCT_CONVERSATION_ID_URL']"
		[Register ("PRODUCT_CONVERSATION_ID_URL")]
		public const string ProductConversationIdUrl = (string) "/rest/ws/conversation/id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='REGISTRATION_ID']"
		[Register ("REGISTRATION_ID")]
		public const string RegistrationId = (string) "registrationId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='SMS_SYNC_BATCH_SIZE']"
		[Register ("SMS_SYNC_BATCH_SIZE")]
		public const int SmsSyncBatchSize = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='UPDATE_READ_STATUS_FOR_SINGLE_MESSAGE_URL']"
		[Register ("UPDATE_READ_STATUS_FOR_SINGLE_MESSAGE_URL")]
		public const string UpdateReadStatusForSingleMessageUrl = (string) "/rest/ws/message/read";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/field[@name='USER_DETAILS_URL']"
		[Register ("USER_DETAILS_URL")]
		public const string UserDetailsUrl = (string) "/rest/ws/user/detail";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/MessageClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageClientService); }
		}

		protected MessageClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/constructor[@name='MessageClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MessageClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessageClientService)) {
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

		static Delegate cb_getMessageByMessageKeysUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageByMessageKeysUrlHandler ()
		{
			if (cb_getMessageByMessageKeysUrl == null)
				cb_getMessageByMessageKeysUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageByMessageKeysUrl);
			return cb_getMessageByMessageKeysUrl;
		}

		static IntPtr n_GetMessageByMessageKeysUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageByMessageKeysUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageByMessageKeysUrl;
		public virtual unsafe string MessageByMessageKeysUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageByMessageKeysUrl' and count(parameter)=0]"
			[Register ("getMessageByMessageKeysUrl", "()Ljava/lang/String;", "GetGetMessageByMessageKeysUrlHandler")]
			get {
				if (id_getMessageByMessageKeysUrl == IntPtr.Zero)
					id_getMessageByMessageKeysUrl = JNIEnv.GetMethodID (class_ref, "getMessageByMessageKeysUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageByMessageKeysUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageByMessageKeysUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageDeleteUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageDeleteUrlHandler ()
		{
			if (cb_getMessageDeleteUrl == null)
				cb_getMessageDeleteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageDeleteUrl);
			return cb_getMessageDeleteUrl;
		}

		static IntPtr n_GetMessageDeleteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageDeleteUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageDeleteUrl;
		public virtual unsafe string MessageDeleteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageDeleteUrl' and count(parameter)=0]"
			[Register ("getMessageDeleteUrl", "()Ljava/lang/String;", "GetGetMessageDeleteUrlHandler")]
			get {
				if (id_getMessageDeleteUrl == IntPtr.Zero)
					id_getMessageDeleteUrl = JNIEnv.GetMethodID (class_ref, "getMessageDeleteUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageDeleteUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageDeleteUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageInfoUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoUrlHandler ()
		{
			if (cb_getMessageInfoUrl == null)
				cb_getMessageInfoUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageInfoUrl);
			return cb_getMessageInfoUrl;
		}

		static IntPtr n_GetMessageInfoUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageInfoUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageInfoUrl;
		public virtual unsafe string MessageInfoUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageInfoUrl' and count(parameter)=0]"
			[Register ("getMessageInfoUrl", "()Ljava/lang/String;", "GetGetMessageInfoUrlHandler")]
			get {
				if (id_getMessageInfoUrl == IntPtr.Zero)
					id_getMessageInfoUrl = JNIEnv.GetMethodID (class_ref, "getMessageInfoUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageInfoUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageInfoUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageListUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageListUrlHandler ()
		{
			if (cb_getMessageListUrl == null)
				cb_getMessageListUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageListUrl);
			return cb_getMessageListUrl;
		}

		static IntPtr n_GetMessageListUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageListUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageListUrl;
		public virtual unsafe string MessageListUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageListUrl' and count(parameter)=0]"
			[Register ("getMessageListUrl", "()Ljava/lang/String;", "GetGetMessageListUrlHandler")]
			get {
				if (id_getMessageListUrl == IntPtr.Zero)
					id_getMessageListUrl = JNIEnv.GetMethodID (class_ref, "getMessageListUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageListUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageListUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageThreadDeleteUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageThreadDeleteUrlHandler ()
		{
			if (cb_getMessageThreadDeleteUrl == null)
				cb_getMessageThreadDeleteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageThreadDeleteUrl);
			return cb_getMessageThreadDeleteUrl;
		}

		static IntPtr n_GetMessageThreadDeleteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageThreadDeleteUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageThreadDeleteUrl;
		public virtual unsafe string MessageThreadDeleteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageThreadDeleteUrl' and count(parameter)=0]"
			[Register ("getMessageThreadDeleteUrl", "()Ljava/lang/String;", "GetGetMessageThreadDeleteUrlHandler")]
			get {
				if (id_getMessageThreadDeleteUrl == IntPtr.Zero)
					id_getMessageThreadDeleteUrl = JNIEnv.GetMethodID (class_ref, "getMessageThreadDeleteUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageThreadDeleteUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageThreadDeleteUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMtextDeliveryUrl;
#pragma warning disable 0169
		static Delegate GetGetMtextDeliveryUrlHandler ()
		{
			if (cb_getMtextDeliveryUrl == null)
				cb_getMtextDeliveryUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMtextDeliveryUrl);
			return cb_getMtextDeliveryUrl;
		}

		static IntPtr n_GetMtextDeliveryUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MtextDeliveryUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMtextDeliveryUrl;
		public virtual unsafe string MtextDeliveryUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMtextDeliveryUrl' and count(parameter)=0]"
			[Register ("getMtextDeliveryUrl", "()Ljava/lang/String;", "GetGetMtextDeliveryUrlHandler")]
			get {
				if (id_getMtextDeliveryUrl == IntPtr.Zero)
					id_getMtextDeliveryUrl = JNIEnv.GetMethodID (class_ref, "getMtextDeliveryUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMtextDeliveryUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMtextDeliveryUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductConversationUrl;
#pragma warning disable 0169
		static Delegate GetGetProductConversationUrlHandler ()
		{
			if (cb_getProductConversationUrl == null)
				cb_getProductConversationUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductConversationUrl);
			return cb_getProductConversationUrl;
		}

		static IntPtr n_GetProductConversationUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductConversationUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getProductConversationUrl;
		public virtual unsafe string ProductConversationUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getProductConversationUrl' and count(parameter)=0]"
			[Register ("getProductConversationUrl", "()Ljava/lang/String;", "GetGetProductConversationUrlHandler")]
			get {
				if (id_getProductConversationUrl == IntPtr.Zero)
					id_getProductConversationUrl = JNIEnv.GetMethodID (class_ref, "getProductConversationUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductConversationUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductConversationUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductTopicIdUrl;
#pragma warning disable 0169
		static Delegate GetGetProductTopicIdUrlHandler ()
		{
			if (cb_getProductTopicIdUrl == null)
				cb_getProductTopicIdUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductTopicIdUrl);
			return cb_getProductTopicIdUrl;
		}

		static IntPtr n_GetProductTopicIdUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductTopicIdUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getProductTopicIdUrl;
		public virtual unsafe string ProductTopicIdUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getProductTopicIdUrl' and count(parameter)=0]"
			[Register ("getProductTopicIdUrl", "()Ljava/lang/String;", "GetGetProductTopicIdUrlHandler")]
			get {
				if (id_getProductTopicIdUrl == IntPtr.Zero)
					id_getProductTopicIdUrl = JNIEnv.GetMethodID (class_ref, "getProductTopicIdUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProductTopicIdUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProductTopicIdUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSendMessageUrl;
#pragma warning disable 0169
		static Delegate GetGetSendMessageUrlHandler ()
		{
			if (cb_getSendMessageUrl == null)
				cb_getSendMessageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendMessageUrl);
			return cb_getSendMessageUrl;
		}

		static IntPtr n_GetSendMessageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SendMessageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getSendMessageUrl;
		public virtual unsafe string SendMessageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getSendMessageUrl' and count(parameter)=0]"
			[Register ("getSendMessageUrl", "()Ljava/lang/String;", "GetGetSendMessageUrlHandler")]
			get {
				if (id_getSendMessageUrl == IntPtr.Zero)
					id_getSendMessageUrl = JNIEnv.GetMethodID (class_ref, "getSendMessageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSendMessageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendMessageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServerSyncUrl;
#pragma warning disable 0169
		static Delegate GetGetServerSyncUrlHandler ()
		{
			if (cb_getServerSyncUrl == null)
				cb_getServerSyncUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetServerSyncUrl);
			return cb_getServerSyncUrl;
		}

		static IntPtr n_GetServerSyncUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServerSyncUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getServerSyncUrl;
		public virtual unsafe string ServerSyncUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getServerSyncUrl' and count(parameter)=0]"
			[Register ("getServerSyncUrl", "()Ljava/lang/String;", "GetGetServerSyncUrlHandler")]
			get {
				if (id_getServerSyncUrl == IntPtr.Zero)
					id_getServerSyncUrl = JNIEnv.GetMethodID (class_ref, "getServerSyncUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerSyncUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerSyncUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSingleMessageReadUrl;
#pragma warning disable 0169
		static Delegate GetGetSingleMessageReadUrlHandler ()
		{
			if (cb_getSingleMessageReadUrl == null)
				cb_getSingleMessageReadUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSingleMessageReadUrl);
			return cb_getSingleMessageReadUrl;
		}

		static IntPtr n_GetSingleMessageReadUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SingleMessageReadUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getSingleMessageReadUrl;
		public virtual unsafe string SingleMessageReadUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getSingleMessageReadUrl' and count(parameter)=0]"
			[Register ("getSingleMessageReadUrl", "()Ljava/lang/String;", "GetGetSingleMessageReadUrlHandler")]
			get {
				if (id_getSingleMessageReadUrl == IntPtr.Zero)
					id_getSingleMessageReadUrl = JNIEnv.GetMethodID (class_ref, "getSingleMessageReadUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSingleMessageReadUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSingleMessageReadUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSyncSmsUrl;
#pragma warning disable 0169
		static Delegate GetGetSyncSmsUrlHandler ()
		{
			if (cb_getSyncSmsUrl == null)
				cb_getSyncSmsUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSyncSmsUrl);
			return cb_getSyncSmsUrl;
		}

		static IntPtr n_GetSyncSmsUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SyncSmsUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getSyncSmsUrl;
		public virtual unsafe string SyncSmsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getSyncSmsUrl' and count(parameter)=0]"
			[Register ("getSyncSmsUrl", "()Ljava/lang/String;", "GetGetSyncSmsUrlHandler")]
			get {
				if (id_getSyncSmsUrl == IntPtr.Zero)
					id_getSyncSmsUrl = JNIEnv.GetMethodID (class_ref, "getSyncSmsUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSyncSmsUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSyncSmsUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateDeliveryFlagUrl;
#pragma warning disable 0169
		static Delegate GetGetUpdateDeliveryFlagUrlHandler ()
		{
			if (cb_getUpdateDeliveryFlagUrl == null)
				cb_getUpdateDeliveryFlagUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateDeliveryFlagUrl);
			return cb_getUpdateDeliveryFlagUrl;
		}

		static IntPtr n_GetUpdateDeliveryFlagUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateDeliveryFlagUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateDeliveryFlagUrl;
		public virtual unsafe string UpdateDeliveryFlagUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getUpdateDeliveryFlagUrl' and count(parameter)=0]"
			[Register ("getUpdateDeliveryFlagUrl", "()Ljava/lang/String;", "GetGetUpdateDeliveryFlagUrlHandler")]
			get {
				if (id_getUpdateDeliveryFlagUrl == IntPtr.Zero)
					id_getUpdateDeliveryFlagUrl = JNIEnv.GetMethodID (class_ref, "getUpdateDeliveryFlagUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateDeliveryFlagUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateDeliveryFlagUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdateReadStatusUrl;
#pragma warning disable 0169
		static Delegate GetGetUpdateReadStatusUrlHandler ()
		{
			if (cb_getUpdateReadStatusUrl == null)
				cb_getUpdateReadStatusUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdateReadStatusUrl);
			return cb_getUpdateReadStatusUrl;
		}

		static IntPtr n_GetUpdateReadStatusUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UpdateReadStatusUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateReadStatusUrl;
		public virtual unsafe string UpdateReadStatusUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getUpdateReadStatusUrl' and count(parameter)=0]"
			[Register ("getUpdateReadStatusUrl", "()Ljava/lang/String;", "GetGetUpdateReadStatusUrlHandler")]
			get {
				if (id_getUpdateReadStatusUrl == IntPtr.Zero)
					id_getUpdateReadStatusUrl = JNIEnv.GetMethodID (class_ref, "getUpdateReadStatusUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateReadStatusUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateReadStatusUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserDetailUrl;
#pragma warning disable 0169
		static Delegate GetGetUserDetailUrlHandler ()
		{
			if (cb_getUserDetailUrl == null)
				cb_getUserDetailUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserDetailUrl);
			return cb_getUserDetailUrl;
		}

		static IntPtr n_GetUserDetailUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserDetailUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetailUrl;
		public virtual unsafe string UserDetailUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getUserDetailUrl' and count(parameter)=0]"
			[Register ("getUserDetailUrl", "()Ljava/lang/String;", "GetGetUserDetailUrlHandler")]
			get {
				if (id_getUserDetailUrl == IntPtr.Zero)
					id_getUserDetailUrl = JNIEnv.GetMethodID (class_ref, "getUserDetailUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetailUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetailUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserDetailsListUrl;
#pragma warning disable 0169
		static Delegate GetGetUserDetailsListUrlHandler ()
		{
			if (cb_getUserDetailsListUrl == null)
				cb_getUserDetailsListUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserDetailsListUrl);
			return cb_getUserDetailsListUrl;
		}

		static IntPtr n_GetUserDetailsListUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserDetailsListUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetailsListUrl;
		public virtual unsafe string UserDetailsListUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getUserDetailsListUrl' and count(parameter)=0]"
			[Register ("getUserDetailsListUrl", "()Ljava/lang/String;", "GetGetUserDetailsListUrlHandler")]
			get {
				if (id_getUserDetailsListUrl == IntPtr.Zero)
					id_getUserDetailsListUrl = JNIEnv.GetMethodID (class_ref, "getUserDetailsListUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetailsListUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetailsListUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_DeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversationThreadFromServer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='deleteConversationThreadFromServer' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("deleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void DeleteConversationThreadFromServer (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "deleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static IntPtr n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;", "GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe string DeleteMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='deleteMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;", "GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe string DeleteMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1)
		{
			if (id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Ljava_lang_String_Handler ()
		{
			if (cb_deleteMessage_Ljava_lang_String_ == null)
				cb_deleteMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessage_Ljava_lang_String_);
			return cb_deleteMessage_Ljava_lang_String_;
		}

		static IntPtr n_DeleteMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteMessage", "(Ljava/lang/String;)Ljava/lang/String;", "GetDeleteMessage_Ljava_lang_String_Handler")]
		public virtual unsafe string DeleteMessage (string p0)
		{
			if (id_deleteMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
#pragma warning disable 0169
		static Delegate GetDeletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ZHandler ()
		{
			if (cb_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z == null)
				cb_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_DeletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z);
			return cb_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
		}

		static void n_DeletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeletePendingMessages (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='deletePendingMessages' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='boolean']]"
		[Register ("deletePendingMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V", "GetDeletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_ZHandler")]
		public virtual unsafe void DeletePendingMessages (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, bool p1)
		{
			if (id_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z == IntPtr.Zero)
				id_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z = JNIEnv.GetMethodID (class_ref, "deletePendingMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deletePendingMessages_Lcom_applozic_mobicomkit_api_conversation_Message_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deletePendingMessages", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getConnectedUsers;
#pragma warning disable 0169
		static Delegate GetGetConnectedUsersHandler ()
		{
			if (cb_getConnectedUsers == null)
				cb_getConnectedUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConnectedUsers);
			return cb_getConnectedUsers;
		}

		static IntPtr n_GetConnectedUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConnectedUsers ());
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedUsers;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getConnectedUsers' and count(parameter)=0]"
		[Register ("getConnectedUsers", "()[Ljava/lang/String;", "GetGetConnectedUsersHandler")]
		public virtual unsafe string[] GetConnectedUsers ()
		{
			if (id_getConnectedUsers == IntPtr.Zero)
				id_getConnectedUsers = JNIEnv.GetMethodID (class_ref, "getConnectedUsers", "()[Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (string[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedUsers), JniHandleOwnership.TransferLocalRef, typeof (string));
				else
					return (string[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedUsers", "()[Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getMessageByMessageKeys_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetMessageByMessageKeys_Ljava_util_List_Handler ()
		{
			if (cb_getMessageByMessageKeys_Ljava_util_List_ == null)
				cb_getMessageByMessageKeys_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageByMessageKeys_Ljava_util_List_);
			return cb_getMessageByMessageKeys_Ljava_util_List_;
		}

		static IntPtr n_GetMessageByMessageKeys_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessageByMessageKeys (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageByMessageKeys_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageByMessageKeys' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getMessageByMessageKeys", "(Ljava/util/List;)Ljava/lang/String;", "GetGetMessageByMessageKeys_Ljava_util_List_Handler")]
		public virtual unsafe string GetMessageByMessageKeys (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getMessageByMessageKeys_Ljava_util_List_ == IntPtr.Zero)
				id_getMessageByMessageKeys_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getMessageByMessageKeys", "(Ljava/util/List;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageByMessageKeys_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageByMessageKeys", "(Ljava/util/List;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessageFeed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessageFeed_Ljava_lang_String_Handler ()
		{
			if (cb_getMessageFeed_Ljava_lang_String_ == null)
				cb_getMessageFeed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageFeed_Ljava_lang_String_);
			return cb_getMessageFeed_Ljava_lang_String_;
		}

		static IntPtr n_GetMessageFeed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageFeed (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageFeed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageFeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessageFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncMessageFeed;", "GetGetMessageFeed_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed GetMessageFeed (string p0)
		{
			if (id_getMessageFeed_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessageFeed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessageFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncMessageFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageFeed_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncMessageFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncMessageFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessageInfoList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoList_Ljava_lang_String_Handler ()
		{
			if (cb_getMessageInfoList_Ljava_lang_String_ == null)
				cb_getMessageInfoList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageInfoList_Ljava_lang_String_);
			return cb_getMessageInfoList_Ljava_lang_String_;
		}

		static IntPtr n_GetMessageInfoList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageInfoList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageInfoList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessageInfoList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessageInfoList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;", "GetGetMessageInfoList_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse GetMessageInfoList (string p0)
		{
			if (id_getMessageInfoList_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessageInfoList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessageInfoList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageInfoList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageInfoList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Handler ()
		{
			if (cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ == null)
				cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_);
			return cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_;
		}

		static IntPtr n_GetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessages (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessages' and count(parameter)=5 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.Integer']]"
		[Register ("getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;)Ljava/lang/String;", "GetGetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetMessages (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Java.Lang.Long p2, global::Java.Lang.Long p3, global::Java.Lang.Integer p4)
		{
			if (id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z;
#pragma warning disable 0169
		static Delegate GetGetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ZHandler ()
		{
			if (cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z == null)
				cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z);
			return cb_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z;
		}

		static IntPtr n_GetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetMessages (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getMessages' and count(parameter)=6 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.Integer'] and parameter[6][@type='boolean']]"
		[Register ("getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;Z)Ljava/lang/String;", "GetGetMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_ZHandler")]
		public virtual unsafe string GetMessages (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Java.Lang.Long p2, global::Java.Lang.Long p3, global::Java.Lang.Integer p4, bool p5)
		{
			if (id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z == IntPtr.Zero)
				id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z = JNIEnv.GetMethodID (class_ref, "getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_Integer_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/Integer;Z)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getTopicId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetTopicId_Ljava_lang_Integer_Handler ()
		{
			if (cb_getTopicId_Ljava_lang_Integer_ == null)
				cb_getTopicId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTopicId_Ljava_lang_Integer_);
			return cb_getTopicId_Ljava_lang_Integer_;
		}

		static IntPtr n_GetTopicId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetTopicId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getTopicId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getTopicId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getTopicId", "(Ljava/lang/Integer;)Ljava/lang/String;", "GetGetTopicId_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetTopicId (global::Java.Lang.Integer p0)
		{
			if (id_getTopicId_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getTopicId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getTopicId", "(Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopicId_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopicId", "(Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getUserDetailsList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetUserDetailsList_Ljava_lang_String_Handler ()
		{
			if (cb_getUserDetailsList_Ljava_lang_String_ == null)
				cb_getUserDetailsList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUserDetailsList_Ljava_lang_String_);
			return cb_getUserDetailsList_Ljava_lang_String_;
		}

		static IntPtr n_GetUserDetailsList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUserDetailsList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUserDetailsList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='getUserDetailsList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUserDetailsList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncUserDetailsResponse;", "GetGetUserDetailsList_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Sync.SyncUserDetailsResponse GetUserDetailsList (string p0)
		{
			if (id_getUserDetailsList_Ljava_lang_String_ == IntPtr.Zero)
				id_getUserDetailsList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getUserDetailsList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncUserDetailsResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Sync.SyncUserDetailsResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserDetailsResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserDetailsList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserDetailsResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserDetailsList", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncUserDetailsResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_ProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='processMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void ProcessMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetProcessUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_ProcessUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='processUserStatus' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("processUserStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetProcessUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void ProcessUserStatus (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "processUserStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserStatus_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserStatus (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserStatus_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='processUserStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static IntPtr n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;", "GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe string SendMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageToServer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='sendMessageToServer' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void SendMessageToServer (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_Handler ()
		{
			if (cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ == null)
				cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_);
			return cb_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
		}

		static void n_SendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessageToServer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='sendMessageToServer' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.Class']]"
		[Register ("sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V", "GetSendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_Handler")]
		public virtual unsafe void SendMessageToServer (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Java.Lang.Class p1)
		{
			if (id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ == IntPtr.Zero)
				id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
#pragma warning disable 0169
		static Delegate GetSendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ZHandler ()
		{
			if (cb_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z == null)
				cb_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z);
			return cb_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
		}

		static void n_SendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendPendingMessageToServer (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='sendPendingMessageToServer' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='boolean']]"
		[Register ("sendPendingMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V", "GetSendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_ZHandler")]
		public virtual unsafe void SendPendingMessageToServer (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, bool p1)
		{
			if (id_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z == IntPtr.Zero)
				id_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z = JNIEnv.GetMethodID (class_ref, "sendPendingMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendPendingMessageToServer_Lcom_applozic_mobicomkit_api_conversation_Message_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendPendingMessageToServer", "(Lcom/applozic/mobicomkit/api/conversation/Message;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetSyncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static IntPtr n_SyncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SyncDeleteConversationThreadFromServer (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='syncDeleteConversationThreadFromServer' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("syncDeleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/String;", "GetSyncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe string SyncDeleteConversationThreadFromServer (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "syncDeleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_syncDeleteConversationThreadFromServer_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncDeleteConversationThreadFromServer", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_syncDeleteMessages_Z;
#pragma warning disable 0169
		static Delegate GetSyncDeleteMessages_ZHandler ()
		{
			if (cb_syncDeleteMessages_Z == null)
				cb_syncDeleteMessages_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SyncDeleteMessages_Z);
			return cb_syncDeleteMessages_Z;
		}

		static void n_SyncDeleteMessages_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncDeleteMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_syncDeleteMessages_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='syncDeleteMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("syncDeleteMessages", "(Z)V", "GetSyncDeleteMessages_ZHandler")]
		public virtual unsafe void SyncDeleteMessages (bool p0)
		{
			if (id_syncDeleteMessages_Z == IntPtr.Zero)
				id_syncDeleteMessages_Z = JNIEnv.GetMethodID (class_ref, "syncDeleteMessages", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncDeleteMessages_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncDeleteMessages", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_;
#pragma warning disable 0169
		static Delegate GetSyncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_Handler ()
		{
			if (cb_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_ == null)
				cb_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SyncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_);
			return cb_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_;
		}

		static IntPtr n_SyncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SyncMessages (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='syncMessages' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.sync.SmsSyncRequest']]"
		[Register ("syncMessages", "(Lcom/applozic/mobicomkit/sync/SmsSyncRequest;)Ljava/lang/String;", "GetSyncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_Handler")]
		public virtual unsafe string SyncMessages (global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest p0)
		{
			if (id_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_ == IntPtr.Zero)
				id_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_ = JNIEnv.GetMethodID (class_ref, "syncMessages", "(Lcom/applozic/mobicomkit/sync/SmsSyncRequest;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_syncMessages_Lcom_applozic_mobicomkit_sync_SmsSyncRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessages", "(Lcom/applozic/mobicomkit/sync/SmsSyncRequest;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_syncMessagesWithServer_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSyncMessagesWithServer_Ljava_util_List_Handler ()
		{
			if (cb_syncMessagesWithServer_Ljava_util_List_ == null)
				cb_syncMessagesWithServer_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SyncMessagesWithServer_Ljava_util_List_);
			return cb_syncMessagesWithServer_Ljava_util_List_;
		}

		static bool n_SyncMessagesWithServer_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SyncMessagesWithServer (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_syncMessagesWithServer_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='syncMessagesWithServer' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
		[Register ("syncMessagesWithServer", "(Ljava/util/List;)Z", "GetSyncMessagesWithServer_Ljava_util_List_Handler")]
		public virtual unsafe bool SyncMessagesWithServer (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p0)
		{
			if (id_syncMessagesWithServer_Ljava_util_List_ == IntPtr.Zero)
				id_syncMessagesWithServer_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "syncMessagesWithServer", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_syncMessagesWithServer_Ljava_util_List_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessagesWithServer", "(Ljava/util/List;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_syncPendingMessages_Z;
#pragma warning disable 0169
		static Delegate GetSyncPendingMessages_ZHandler ()
		{
			if (cb_syncPendingMessages_Z == null)
				cb_syncPendingMessages_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SyncPendingMessages_Z);
			return cb_syncPendingMessages_Z;
		}

		static void n_SyncPendingMessages_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncPendingMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_syncPendingMessages_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='syncPendingMessages' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("syncPendingMessages", "(Z)V", "GetSyncPendingMessages_ZHandler")]
		public virtual unsafe void SyncPendingMessages (bool p0)
		{
			if (id_syncPendingMessages_Z == IntPtr.Zero)
				id_syncPendingMessages_Z = JNIEnv.GetMethodID (class_ref, "syncPendingMessages", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncPendingMessages_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncPendingMessages", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_UpdateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeliveryStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='updateDeliveryStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("updateDeliveryStatus", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetUpdateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateDeliveryStatus (string p0, string p1, string p2)
		{
			if (id_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateDeliveryStatus", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDeliveryStatus_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDeliveryStatus", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_UpdateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateReadStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='updateReadStatus' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("updateReadStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetUpdateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void UpdateReadStatus (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "updateReadStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatus_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatus", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateReadStatusForSingleMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateReadStatusForSingleMessage_Ljava_lang_String_Handler ()
		{
			if (cb_updateReadStatusForSingleMessage_Ljava_lang_String_ == null)
				cb_updateReadStatusForSingleMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateReadStatusForSingleMessage_Ljava_lang_String_);
			return cb_updateReadStatusForSingleMessage_Ljava_lang_String_;
		}

		static void n_UpdateReadStatusForSingleMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateReadStatusForSingleMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateReadStatusForSingleMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageClientService']/method[@name='updateReadStatusForSingleMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateReadStatusForSingleMessage", "(Ljava/lang/String;)V", "GetUpdateReadStatusForSingleMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateReadStatusForSingleMessage (string p0)
		{
			if (id_updateReadStatusForSingleMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_updateReadStatusForSingleMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateReadStatusForSingleMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateReadStatusForSingleMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateReadStatusForSingleMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
