using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/MobiComMessageService", DoNotGenerateAcw=true)]
	public partial class MobiComMessageService : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='DELAY']"
		[Register ("DELAY")]
		public const long Delay = (long) 60000L;

		static IntPtr baseContactService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='baseContactService']"
		[Register ("baseContactService")]
		protected global::Com.Applozic.Mobicomkit.Contact.IBaseContactService BaseContactService {
			get {
				if (baseContactService_jfieldId == IntPtr.Zero)
					baseContactService_jfieldId = JNIEnv.GetFieldID (class_ref, "baseContactService", "Lcom/applozic/mobicomkit/contact/BaseContactService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, baseContactService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.IBaseContactService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (baseContactService_jfieldId == IntPtr.Zero)
					baseContactService_jfieldId = JNIEnv.GetFieldID (class_ref, "baseContactService", "Lcom/applozic/mobicomkit/contact/BaseContactService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, baseContactService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr context_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='context']"
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

		static IntPtr conversationService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='conversationService']"
		[Register ("conversationService")]
		protected global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService ConversationService {
			get {
				if (conversationService_jfieldId == IntPtr.Zero)
					conversationService_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationService", "Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, conversationService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (conversationService_jfieldId == IntPtr.Zero)
					conversationService_jfieldId = JNIEnv.GetFieldID (class_ref, "conversationService", "Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, conversationService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr fileClientService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='fileClientService']"
		[Register ("fileClientService")]
		protected global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService FileClientService {
			get {
				if (fileClientService_jfieldId == IntPtr.Zero)
					fileClientService_jfieldId = JNIEnv.GetFieldID (class_ref, "fileClientService", "Lcom/applozic/mobicomkit/api/attachment/FileClientService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, fileClientService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.FileClientService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (fileClientService_jfieldId == IntPtr.Zero)
					fileClientService_jfieldId = JNIEnv.GetFieldID (class_ref, "fileClientService", "Lcom/applozic/mobicomkit/api/attachment/FileClientService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, fileClientService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr map_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='map']"
		[Register ("map")]
		public static global::System.Collections.IDictionary Map {
			get {
				if (map_jfieldId == IntPtr.Zero)
					map_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "map", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, map_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (map_jfieldId == IntPtr.Zero)
					map_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "map", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, map_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr messageClientService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='messageClientService']"
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

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='messageDatabaseService']"
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

		static IntPtr messageIntentServiceClass_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='messageIntentServiceClass']"
		[Register ("messageIntentServiceClass")]
		protected global::Java.Lang.Class MessageIntentServiceClass {
			get {
				if (messageIntentServiceClass_jfieldId == IntPtr.Zero)
					messageIntentServiceClass_jfieldId = JNIEnv.GetFieldID (class_ref, "messageIntentServiceClass", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, messageIntentServiceClass_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (messageIntentServiceClass_jfieldId == IntPtr.Zero)
					messageIntentServiceClass_jfieldId = JNIEnv.GetFieldID (class_ref, "messageIntentServiceClass", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, messageIntentServiceClass_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mtMessages_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='mtMessages']"
		[Register ("mtMessages")]
		public static global::System.Collections.IDictionary MtMessages {
			get {
				if (mtMessages_jfieldId == IntPtr.Zero)
					mtMessages_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mtMessages", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mtMessages_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mtMessages_jfieldId == IntPtr.Zero)
					mtMessages_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mtMessages", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, mtMessages_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr userService_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/field[@name='userService']"
		[Register ("userService")]
		protected global::Com.Applozic.Mobicomkit.Api.Account.User.UserService UserService {
			get {
				if (userService_jfieldId == IntPtr.Zero)
					userService_jfieldId = JNIEnv.GetFieldID (class_ref, "userService", "Lcom/applozic/mobicomkit/api/account/user/UserService;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, userService_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Account.User.UserService> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (userService_jfieldId == IntPtr.Zero)
					userService_jfieldId = JNIEnv.GetFieldID (class_ref, "userService", "Lcom/applozic/mobicomkit/api/account/user/UserService;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, userService_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/MobiComMessageService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MobiComMessageService); }
		}

		protected MobiComMessageService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/constructor[@name='MobiComMessageService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public unsafe MobiComMessageService (global::Android.Content.Context p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MobiComMessageService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static Delegate cb_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetAddMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static IntPtr n_AddMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMTMessage (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='addMTMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("addMTMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Lcom/applozic/mobicommons/people/contact/Contact;", "GetAddMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact AddMTMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "addMTMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Lcom/applozic/mobicommons/people/contact/Contact;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMTMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMTMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)Lcom/applozic/mobicommons/people/contact/Contact;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_addWelcomeMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddWelcomeMessage_Ljava_lang_String_Handler ()
		{
			if (cb_addWelcomeMessage_Ljava_lang_String_ == null)
				cb_addWelcomeMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddWelcomeMessage_Ljava_lang_String_);
			return cb_addWelcomeMessage_Ljava_lang_String_;
		}

		static void n_AddWelcomeMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddWelcomeMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addWelcomeMessage_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='addWelcomeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addWelcomeMessage", "(Ljava/lang/String;)V", "GetAddWelcomeMessage_Ljava_lang_String_Handler")]
		public virtual unsafe void AddWelcomeMessage (string p0)
		{
			if (id_addWelcomeMessage_Ljava_lang_String_ == IntPtr.Zero)
				id_addWelcomeMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addWelcomeMessage", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addWelcomeMessage_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addWelcomeMessage", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetCreateEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_CreateEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateEmptyMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='createEmptyMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("createEmptyMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetCreateEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void CreateEmptyMessage (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "createEmptyMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createEmptyMessage_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createEmptyMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_createEmptyMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreateEmptyMessages_Ljava_util_List_Handler ()
		{
			if (cb_createEmptyMessages_Ljava_util_List_ == null)
				cb_createEmptyMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CreateEmptyMessages_Ljava_util_List_);
			return cb_createEmptyMessages_Ljava_util_List_;
		}

		static void n_CreateEmptyMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateEmptyMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_createEmptyMessages_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='createEmptyMessages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
		[Register ("createEmptyMessages", "(Ljava/util/List;)V", "GetCreateEmptyMessages_Ljava_util_List_Handler")]
		public virtual unsafe void CreateEmptyMessages (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> p0)
		{
			if (id_createEmptyMessages_Ljava_util_List_ == IntPtr.Zero)
				id_createEmptyMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "createEmptyMessages", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createEmptyMessages_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createEmptyMessages", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMessageInfoResponse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoResponse_Ljava_lang_String_Handler ()
		{
			if (cb_getMessageInfoResponse_Ljava_lang_String_ == null)
				cb_getMessageInfoResponse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMessageInfoResponse_Ljava_lang_String_);
			return cb_getMessageInfoResponse_Ljava_lang_String_;
		}

		static IntPtr n_GetMessageInfoResponse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMessageInfoResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageInfoResponse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='getMessageInfoResponse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMessageInfoResponse", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;", "GetGetMessageInfoResponse_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse GetMessageInfoResponse (string p0)
		{
			if (id_getMessageInfoResponse_Ljava_lang_String_ == IntPtr.Zero)
				id_getMessageInfoResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMessageInfoResponse", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageInfoResponse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageInfoResponse", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/MessageInfoResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGetUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_);
			return cb_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GetUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetUpdateMessageMetadata (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='getUpdateMessageMetadata' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("getUpdateMessageMetadata", "(Ljava/lang/String;Ljava/util/Map;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetGetUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse GetUpdateMessageMetadata (string p0, global::System.Collections.Generic.IDictionary<string, string> p1)
		{
			if (id_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "getUpdateMessageMetadata", "(Ljava/lang/String;Ljava/util/Map;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdateMessageMetadata_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdateMessageMetadata", "(Ljava/lang/String;Ljava/util/Map;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsMessagePresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isMessagePresent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='isMessagePresent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static IntPtr n_PrepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='prepareMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("prepareMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;", "GetPrepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message PrepareMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prepareMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Api.Conversation.Message __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_processContactFromMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetProcessContactFromMessages_Ljava_util_List_Handler ()
		{
			if (cb_processContactFromMessages_Ljava_util_List_ == null)
				cb_processContactFromMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessContactFromMessages_Ljava_util_List_);
			return cb_processContactFromMessages_Ljava_util_List_;
		}

		static void n_ProcessContactFromMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessContactFromMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processContactFromMessages_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='processContactFromMessages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
		[Register ("processContactFromMessages", "(Ljava/util/List;)V", "GetProcessContactFromMessages_Ljava_util_List_Handler")]
		public virtual unsafe void ProcessContactFromMessages (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p0)
		{
			if (id_processContactFromMessages_Ljava_util_List_ == IntPtr.Zero)
				id_processContactFromMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "processContactFromMessages", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processContactFromMessages_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processContactFromMessages", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static IntPtr n_ProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProcessMessage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='processMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;", "GetProcessMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message ProcessMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Api.Conversation.Message __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_processMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)Lcom/applozic/mobicomkit/api/conversation/Message;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_processUserDetailFromMessages_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetProcessUserDetailFromMessages_Ljava_util_List_Handler ()
		{
			if (cb_processUserDetailFromMessages_Ljava_util_List_ == null)
				cb_processUserDetailFromMessages_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessUserDetailFromMessages_Ljava_util_List_);
			return cb_processUserDetailFromMessages_Ljava_util_List_;
		}

		static void n_ProcessUserDetailFromMessages_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessUserDetailFromMessages (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processUserDetailFromMessages_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='processUserDetailFromMessages' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
		[Register ("processUserDetailFromMessages", "(Ljava/util/List;)V", "GetProcessUserDetailFromMessages_Ljava_util_List_Handler")]
		public virtual unsafe void ProcessUserDetailFromMessages (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p0)
		{
			if (id_processUserDetailFromMessages_Ljava_util_List_ == IntPtr.Zero)
				id_processUserDetailFromMessages_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "processUserDetailFromMessages", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processUserDetailFromMessages_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processUserDetailFromMessages", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_putMtextToDatabase_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutMtextToDatabase_Ljava_lang_String_Handler ()
		{
			if (cb_putMtextToDatabase_Ljava_lang_String_ == null)
				cb_putMtextToDatabase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutMtextToDatabase_Ljava_lang_String_);
			return cb_putMtextToDatabase_Ljava_lang_String_;
		}

		static void n_PutMtextToDatabase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PutMtextToDatabase (p0);
		}
#pragma warning restore 0169

		static IntPtr id_putMtextToDatabase_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='putMtextToDatabase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("putMtextToDatabase", "(Ljava/lang/String;)V", "GetPutMtextToDatabase_Ljava_lang_String_Handler")]
		public virtual unsafe void PutMtextToDatabase (string p0)
		{
			if (id_putMtextToDatabase_Ljava_lang_String_ == IntPtr.Zero)
				id_putMtextToDatabase_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "putMtextToDatabase", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putMtextToDatabase_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putMtextToDatabase", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendCustomMessage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='sendCustomMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendCustomMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void SendCustomMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "sendCustomMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendCustomMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendCustomMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendNotification (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='sendNotification' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("sendNotification", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void SendNotification (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "sendNotification", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendNotification_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendNotification", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_syncMessageForMetadataUpdate;
#pragma warning disable 0169
		static Delegate GetSyncMessageForMetadataUpdateHandler ()
		{
			if (cb_syncMessageForMetadataUpdate == null)
				cb_syncMessageForMetadataUpdate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncMessageForMetadataUpdate);
			return cb_syncMessageForMetadataUpdate;
		}

		static void n_SyncMessageForMetadataUpdate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncMessageForMetadataUpdate ();
		}
#pragma warning restore 0169

		static IntPtr id_syncMessageForMetadataUpdate;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='syncMessageForMetadataUpdate' and count(parameter)=0]"
		[Register ("syncMessageForMetadataUpdate", "()V", "GetSyncMessageForMetadataUpdateHandler")]
		public virtual unsafe void SyncMessageForMetadataUpdate ()
		{
			if (id_syncMessageForMetadataUpdate == IntPtr.Zero)
				id_syncMessageForMetadataUpdate = JNIEnv.GetMethodID (class_ref, "syncMessageForMetadataUpdate", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMessageForMetadataUpdate);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessageForMetadataUpdate", "()V"));
			} finally {
			}
		}

		static Delegate cb_syncMessages;
#pragma warning disable 0169
		static Delegate GetSyncMessagesHandler ()
		{
			if (cb_syncMessages == null)
				cb_syncMessages = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SyncMessages);
			return cb_syncMessages;
		}

		static void n_SyncMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SyncMessages ();
		}
#pragma warning restore 0169

		static IntPtr id_syncMessages;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='syncMessages' and count(parameter)=0]"
		[Register ("syncMessages", "()V", "GetSyncMessagesHandler")]
		public virtual unsafe void SyncMessages ()
		{
			if (id_syncMessages == IntPtr.Zero)
				id_syncMessages = JNIEnv.GetMethodID (class_ref, "syncMessages", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMessages);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessages", "()V"));
			} finally {
			}
		}

		static Delegate cb_syncMessagesWithServer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSyncMessagesWithServer_Ljava_lang_String_Handler ()
		{
			if (cb_syncMessagesWithServer_Ljava_lang_String_ == null)
				cb_syncMessagesWithServer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SyncMessagesWithServer_Ljava_lang_String_);
			return cb_syncMessagesWithServer_Ljava_lang_String_;
		}

		static void n_SyncMessagesWithServer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SyncMessagesWithServer (p0);
		}
#pragma warning restore 0169

		static IntPtr id_syncMessagesWithServer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='syncMessagesWithServer' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("syncMessagesWithServer", "(Ljava/lang/String;)V", "GetSyncMessagesWithServer_Ljava_lang_String_Handler")]
		public virtual unsafe void SyncMessagesWithServer (string p0)
		{
			if (id_syncMessagesWithServer_Ljava_lang_String_ == IntPtr.Zero)
				id_syncMessagesWithServer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "syncMessagesWithServer", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_syncMessagesWithServer_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "syncMessagesWithServer", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateDeliveryStatus_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateDeliveryStatus_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateDeliveryStatus_Ljava_lang_String_Z == null)
				cb_updateDeliveryStatus_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateDeliveryStatus_Ljava_lang_String_Z);
			return cb_updateDeliveryStatus_Ljava_lang_String_Z;
		}

		static void n_UpdateDeliveryStatus_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeliveryStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeliveryStatus_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='updateDeliveryStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateDeliveryStatus", "(Ljava/lang/String;Z)V", "GetUpdateDeliveryStatus_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateDeliveryStatus (string p0, bool p1)
		{
			if (id_updateDeliveryStatus_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateDeliveryStatus_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateDeliveryStatus", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDeliveryStatus_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDeliveryStatus", "(Ljava/lang/String;Z)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateDeliveryStatusForContact (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateDeliveryStatusForContact_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MobiComMessageService']/method[@name='updateDeliveryStatusForContact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
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

	}
}
