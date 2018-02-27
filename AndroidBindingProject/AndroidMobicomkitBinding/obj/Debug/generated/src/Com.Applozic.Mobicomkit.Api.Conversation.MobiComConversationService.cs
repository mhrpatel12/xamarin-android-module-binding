using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/MobiComConversationService", DoNotGenerateAcw=true)]
	public partial class MobiComConversationService : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='MESSAGE_SENT']"
		[Register ("MESSAGE_SENT")]
		public const int MessageSent = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='SERVER_SYNC']"
		[Register ("SERVER_SYNC")]
		public const string ServerSync = (string) "SERVER_SYNC_[CONVERSATION]_[CONTACT]_[CHANNEL]";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='UPLOAD_CANCELLED']"
		[Register ("UPLOAD_CANCELLED")]
		public const int UploadCancelled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='UPLOAD_COMPLETED']"
		[Register ("UPLOAD_COMPLETED")]
		public const int UploadCompleted = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='UPLOAD_PROGRESS']"
		[Register ("UPLOAD_PROGRESS")]
		public const int UploadProgress = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='UPLOAD_STARTED']"
		[Register ("UPLOAD_STARTED")]
		public const int UploadStarted = (int) 1;

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='context']"
		[Register ("context")]
		protected global::Android.Content.Context Context {
			get {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, context_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (context_jfieldId == IntPtr.Zero)
					context_jfieldId = JNIEnv.GetFieldID (class_ref, "context", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, context_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageClientService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='messageClientService']"
		[Register ("messageClientService")]
		protected global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService MessageClientService {
			get {
				if (messageClientService_jfieldId == IntPtr.Zero)
					messageClientService_jfieldId = JNIEnv.GetFieldID (class_ref, "messageClientService", "Lcom/applozic/mobicomkit/api/conversation/MessageClientService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, messageClientService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageClientService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageClientService_jfieldId == IntPtr.Zero)
					messageClientService_jfieldId = JNIEnv.GetFieldID (class_ref, "messageClientService", "Lcom/applozic/mobicomkit/api/conversation/MessageClientService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, messageClientService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageDatabaseService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/field[@name='messageDatabaseService']"
		[Register ("messageDatabaseService")]
		protected global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService MessageDatabaseService {
			get {
				if (messageDatabaseService_jfieldId == IntPtr.Zero)
					messageDatabaseService_jfieldId = JNIEnv.GetFieldID (class_ref, "messageDatabaseService", "Lcom/applozic/mobicomkit/api/conversation/database/MessageDatabaseService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, messageDatabaseService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.MessageDatabaseService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageDatabaseService_jfieldId == IntPtr.Zero)
					messageDatabaseService_jfieldId = JNIEnv.GetFieldID (class_ref, "messageDatabaseService", "Lcom/applozic/mobicomkit/api/conversation/database/MessageDatabaseService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, messageDatabaseService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/MobiComConversationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComConversationService); }
		}

		protected MobiComConversationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/constructor[@name='MobiComConversationService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MobiComConversationService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MobiComConversationService)) {
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.LatestMessagesGroupByPeople);
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessagesGroupByPeople;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> LatestMessagesGroupByPeople {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getLatestMessagesGroupByPeople' and count(parameter)=0]"
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

		static Delegate cb_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z;
#pragma warning disable 0169
		static Delegate GetDeleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_ZHandler ()
		{
			if (cb_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z == null)
				cb_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_DeleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z);
			return cb_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z;
		}

		static void n_DeleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAndBroadCast (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteAndBroadCast' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='boolean']]"
		[Register ("deleteAndBroadCast", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)V", "GetDeleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_ZHandler")]
		public virtual unsafe void DeleteAndBroadCast (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, bool p1)
		{
			if (id_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z == IntPtr.Zero)
				id_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z = JNIEnv.GetMethodID (class_ref, "deleteAndBroadCast", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAndBroadCast_Lcom_applozic_mobicommons_people_contact_Contact_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAndBroadCast", "(Lcom/applozic/mobicommons/people/contact/Contact;Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteChannelConversationFromDevice_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteChannelConversationFromDevice_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteChannelConversationFromDevice_Ljava_lang_Integer_ == null)
				cb_deleteChannelConversationFromDevice_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteChannelConversationFromDevice_Ljava_lang_Integer_);
			return cb_deleteChannelConversationFromDevice_Ljava_lang_Integer_;
		}

		static void n_DeleteChannelConversationFromDevice_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteChannelConversationFromDevice (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannelConversationFromDevice_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteChannelConversationFromDevice' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("deleteChannelConversationFromDevice", "(Ljava/lang/Integer;)V", "GetDeleteChannelConversationFromDevice_Ljava_lang_Integer_Handler")]
		public virtual unsafe void DeleteChannelConversationFromDevice (global::Java.Lang.Integer p0)
		{
			if (id_deleteChannelConversationFromDevice_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteChannelConversationFromDevice_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteChannelConversationFromDevice", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannelConversationFromDevice_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannelConversationFromDevice", "(Ljava/lang/Integer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteConversationFromDevice_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteConversationFromDevice_Ljava_lang_String_Handler ()
		{
			if (cb_deleteConversationFromDevice_Ljava_lang_String_ == null)
				cb_deleteConversationFromDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteConversationFromDevice_Ljava_lang_String_);
			return cb_deleteConversationFromDevice_Ljava_lang_String_;
		}

		static void n_DeleteConversationFromDevice_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversationFromDevice (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversationFromDevice_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteConversationFromDevice' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteConversationFromDevice", "(Ljava/lang/String;)V", "GetDeleteConversationFromDevice_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteConversationFromDevice (string p0)
		{
			if (id_deleteConversationFromDevice_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteConversationFromDevice_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteConversationFromDevice", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteConversationFromDevice_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteConversationFromDevice", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static bool n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteMessage (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z", "GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe bool DeleteMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static bool n_DeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteMessage (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Z", "GetDeleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe bool DeleteMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1)
		{
			if (id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicommons/people/contact/Contact;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static IntPtr n_DeleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessageFromDevice (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteMessageFromDevice' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteMessageFromDevice", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;", "GetDeleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe string DeleteMessageFromDevice (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteMessageFromDevice", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessageFromDevice_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessageFromDevice", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_DeleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteMessageFromDevice (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteMessageFromDevice' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteMessageFromDevice", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetDeleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string DeleteMessageFromDevice (string p0, string p1)
		{
			if (id_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteMessageFromDevice", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteMessageFromDevice_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteMessageFromDevice", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == null)
				cb_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_);
			return cb_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		}

		static IntPtr n_DeleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.DeleteSync (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='deleteSync' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("deleteSync", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;", "GetDeleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler")]
		public virtual unsafe string DeleteSync (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Java.Lang.Integer p2)
		{
			if (id_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteSync", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteSync_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteSync", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getConversationIdString_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetConversationIdString_Ljava_lang_Integer_Handler ()
		{
			if (cb_getConversationIdString_Ljava_lang_Integer_ == null)
				cb_getConversationIdString_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationIdString_Ljava_lang_Integer_);
			return cb_getConversationIdString_Ljava_lang_Integer_;
		}

		static IntPtr n_GetConversationIdString_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetConversationIdString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationIdString_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getConversationIdString' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getConversationIdString", "(Ljava/lang/Integer;)Ljava/lang/String;", "GetGetConversationIdString_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetConversationIdString (global::Java.Lang.Integer p0)
		{
			if (id_getConversationIdString_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getConversationIdString_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getConversationIdString", "(Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationIdString_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationIdString", "(Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetLatestMessagesGroupByPeople (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getLatestMessagesGroupByPeople_Ljava_lang_Long_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getLatestMessagesGroupByPeople' and count(parameter)=2 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String']]"
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

		static Delegate cb_getMessageListByKeyList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetMessageListByKeyList_Ljava_util_List_Handler ()
		{
			if (cb_getMessageListByKeyList_Ljava_util_List_ == null)
				cb_getMessageListByKeyList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageListByKeyList_Ljava_util_List_);
			return cb_getMessageListByKeyList_Ljava_util_List_;
		}

		static IntPtr n_GetMessageListByKeyList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetMessageListByKeyList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageListByKeyList_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getMessageListByKeyList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getMessageListByKeyList", "(Ljava/util/List;)[Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessageListByKeyList_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message[] GetMessageListByKeyList (global::System.Collections.Generic.IList<string> p0)
		{
			if (id_getMessageListByKeyList_Ljava_util_List_ == IntPtr.Zero)
				id_getMessageListByKeyList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getMessageListByKeyList", "(Ljava/util/List;)[Lcom/applozic/mobicomkit/api/conversation/Message;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.Message[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::Com.Applozic.Mobicomkit.Api.Conversation.Message[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageListByKeyList_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message));
				else
					__ret = (global::Com.Applozic.Mobicomkit.Api.Conversation.Message[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageListByKeyList", "(Ljava/util/List;)[Lcom/applozic/mobicomkit/api/conversation/Message;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Applozic.Mobicomkit.Api.Conversation.Message));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getMessages' and count(parameter)=5 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[4][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[5][@type='java.lang.Integer']]"
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

		static Delegate cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ZHandler ()
		{
			if (cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z == null)
				cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_GetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z);
			return cb_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z;
		}

		static IntPtr n_GetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p3 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetMessages (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getMessages' and count(parameter)=6 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[4][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[5][@type='java.lang.Integer'] and parameter[6][@type='boolean']]"
		[Register ("getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Z)Ljava/util/List;", "GetGetMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ZHandler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessages (global::Java.Lang.Long p0, global::Java.Lang.Long p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2, global::Com.Applozic.Mobicommons.People.Channel.Channel p3, global::Java.Lang.Integer p4, bool p5)
		{
			if (id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z == IntPtr.Zero)
				id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Z)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				__args [5] = new JValue (p5);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Ljava_lang_Long_Ljava_lang_Long_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Ljava/lang/Long;Ljava/lang/Long;Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;Z)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Handler ()
		{
			if (cb_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_ == null)
				cb_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_);
			return cb_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_;
		}

		static IntPtr n_GetMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.GetMessages (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getMessages' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.Long']]"
		[Register ("getMessages", "(Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;)Ljava/util/List;", "GetGetMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> GetMessages (string p0, global::Java.Lang.Long p1, global::Java.Lang.Long p2)
		{
			if (id_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_ == IntPtr.Zero)
				id_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "getMessages", "(Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessages_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessages", "(Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler ()
		{
			if (cb_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == null)
				cb_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_);
			return cb_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		}

		static IntPtr n_GetServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetServerSyncCallKey (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='getServerSyncCallKey' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='java.lang.Integer']]"
		[Register ("getServerSyncCallKey", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;", "GetGetServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_Handler")]
		public virtual unsafe string GetServerSyncCallKey (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Java.Lang.Integer p2)
		{
			if (id_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getServerSyncCallKey", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getServerSyncCallKey_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getServerSyncCallKey", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Integer;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_processLastSeenAtStatus;
#pragma warning disable 0169
		static Delegate GetProcessLastSeenAtStatusHandler ()
		{
			if (cb_processLastSeenAtStatus == null)
				cb_processLastSeenAtStatus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessLastSeenAtStatus);
			return cb_processLastSeenAtStatus;
		}

		static void n_ProcessLastSeenAtStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessLastSeenAtStatus ();
		}
#pragma warning restore 0169

		static IntPtr id_processLastSeenAtStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='processLastSeenAtStatus' and count(parameter)=0]"
		[Register ("processLastSeenAtStatus", "()V", "GetProcessLastSeenAtStatusHandler")]
		public virtual unsafe void ProcessLastSeenAtStatus ()
		{
			if (id_processLastSeenAtStatus == IntPtr.Zero)
				id_processLastSeenAtStatus = JNIEnv.GetMethodID (class_ref, "processLastSeenAtStatus", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processLastSeenAtStatus);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processLastSeenAtStatus", "()V"));
			} finally {
			}
		}

		static Delegate cb_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_Handler ()
		{
			if (cb_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_ == null)
				cb_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_);
			return cb_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_;
		}

		static void n_ProcessUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail[] p0 = (global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail));
			__this.ProcessUserDetails (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='processUserDetails' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.account.user.UserDetail[]']]"
		[Register ("processUserDetails", "([Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V", "GetProcessUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_Handler")]
		public virtual unsafe void ProcessUserDetails (global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail[] p0)
		{
			if (id_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_ == IntPtr.Zero)
				id_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_ = JNIEnv.GetMethodID (class_ref, "processUserDetails", "([Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetails_arrayLcom_applozic_mobicomkit_api_account_user_UserDetail_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetails", "([Lcom/applozic/mobicomkit/api/account/user/UserDetail;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static void n_Read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Read (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='read' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("read", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V", "GetRead_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe void Read (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='sendMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void SendMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Handler ()
		{
			if (cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ == null)
				cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_);
			return cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
		}

		static void n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p1 = (global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='com.applozic.mobicomkit.listners.MediaUploadProgressHandler']]"
		[Register ("sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V", "GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Handler")]
		public virtual unsafe void SendMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p1)
		{
			if (id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ == IntPtr.Zero)
				id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_Handler ()
		{
			if (cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_ == null)
				cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_);
			return cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_;
		}

		static void n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p1 = (global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='sendMessage' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='com.applozic.mobicomkit.listners.MediaUploadProgressHandler'] and parameter[3][@type='java.lang.Class']]"
		[Register ("sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;Ljava/lang/Class;)V", "GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_Handler")]
		public virtual unsafe void SendMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler p1, global::Java.Lang.Class p2)
		{
			if (id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_ == IntPtr.Zero)
				id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaUploadProgressHandler_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaUploadProgressHandler;Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_Handler ()
		{
			if (cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ == null)
				cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_);
			return cb_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
		}

		static void n_SendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='sendMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.Class']]"
		[Register ("sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V", "GetSendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_Handler")]
		public virtual unsafe void SendMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Java.Lang.Class p1)
		{
			if (id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ == IntPtr.Zero)
				id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSetFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SetFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFilePathifExist (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComConversationService']/method[@name='setFilePathifExist' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("setFilePathifExist", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSetFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void SetFilePathifExist (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "setFilePathifExist", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilePathifExist_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilePathifExist", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

	}
}
