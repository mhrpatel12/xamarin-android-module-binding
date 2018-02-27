using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/database/ConversationDatabaseService", DoNotGenerateAcw=true)]
	public partial class ConversationDatabaseService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/database/ConversationDatabaseService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationDatabaseService); }
		}

		protected ConversationDatabaseService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetAddConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddConversation_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static void n_AddConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='addConversation' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("addConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V", "GetAddConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe void AddConversation (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "addConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='deleteConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static IntPtr id_getConversation_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getConversation", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/Conversation;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation GetConversation (global::Android.Database.ICursor p0)
		{
			if (id_getConversation_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getConversation_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getConversation", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/channel/Conversation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicommons.People.Channel.Conversation __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversation_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getConversationByConversationId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetConversationByConversationId_Ljava_lang_Integer_Handler ()
		{
			if (cb_getConversationByConversationId_Ljava_lang_Integer_ == null)
				cb_getConversationByConversationId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationByConversationId_Ljava_lang_Integer_);
			return cb_getConversationByConversationId_Ljava_lang_Integer_;
		}

		static IntPtr n_GetConversationByConversationId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationByConversationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationByConversationId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getConversationByConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getConversationByConversationId", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;", "GetGetConversationByConversationId_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation GetConversationByConversationId (global::Java.Lang.Integer p0)
		{
			if (id_getConversationByConversationId_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getConversationByConversationId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getConversationByConversationId", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Channel.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationByConversationId_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationByConversationId", "(Ljava/lang/Integer;)Lcom/applozic/mobicommons/people/channel/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetConversationByTopicId_Ljava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_ == null)
				cb_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationByTopicId_Ljava_lang_String_Landroid_content_Context_);
			return cb_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetConversationByTopicId_Ljava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationByTopicId (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getConversationByTopicId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("getConversationByTopicId", "(Ljava/lang/String;Landroid/content/Context;)Lcom/applozic/mobicommons/people/channel/Conversation;", "GetGetConversationByTopicId_Ljava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation GetConversationByTopicId (string p0, global::Android.Content.Context p1)
		{
			if (id_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "getConversationByTopicId", "(Ljava/lang/String;Landroid/content/Context;)Lcom/applozic/mobicommons/people/channel/Conversation;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicommons.People.Channel.Conversation __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationByTopicId_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationByTopicId", "(Ljava/lang/String;Landroid/content/Context;)Lcom/applozic/mobicommons/people/channel/Conversation;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getConversationList_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getConversationList' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getConversationList", "(Landroid/database/Cursor;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Conversation> GetConversationList (global::Android.Database.ICursor p0)
		{
			if (id_getConversationList_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getConversationList_Landroid_database_Cursor_ = JNIEnv.GetStaticMethodID (class_ref, "getConversationList", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Conversation> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Conversation>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getConversationList_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetGetConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_GetConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Conversation>.ToLocalJniHandle (__this.GetConversationList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getConversationList' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("getConversationList", "(Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/util/List;", "GetGetConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Conversation> GetConversationList (global::Com.Applozic.Mobicommons.People.Channel.Channel p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1)
		{
			if (id_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "getConversationList", "(Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Channel.Conversation> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Conversation>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Conversation>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationList", "(Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/database/ConversationDatabaseService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/database/ConversationDatabaseService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isConversationExit_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConversationExit_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isConversationExit_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isConversationExit_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_IsConversationExit_Ljava_lang_String_Ljava_lang_String_);
			return cb_isConversationExit_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_IsConversationExit_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsConversationExit (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationExit_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='isConversationExit' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isConversationExit", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;", "GetIsConversationExit_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Integer IsConversationExit (string p0, string p1)
		{
			if (id_isConversationExit_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isConversationExit_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConversationExit", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Integer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isConversationExit_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationExit", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isConversationPresent_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetIsConversationPresent_Ljava_lang_Integer_Handler ()
		{
			if (cb_isConversationPresent_Ljava_lang_Integer_ == null)
				cb_isConversationPresent_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsConversationPresent_Ljava_lang_Integer_);
			return cb_isConversationPresent_Ljava_lang_Integer_;
		}

		static bool n_IsConversationPresent_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsConversationPresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationPresent_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='isConversationPresent' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("isConversationPresent", "(Ljava/lang/Integer;)Z", "GetIsConversationPresent_Ljava_lang_Integer_Handler")]
		public virtual unsafe bool IsConversationPresent (global::Java.Lang.Integer p0)
		{
			if (id_isConversationPresent_Ljava_lang_Integer_ == IntPtr.Zero)
				id_isConversationPresent_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "isConversationPresent", "(Ljava/lang/Integer;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationPresent_Ljava_lang_Integer_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationPresent", "(Ljava/lang/Integer;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetPrepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static IntPtr n_PrepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareConversationValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='prepareConversationValue' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("prepareConversationValue", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/content/ContentValues;", "GetPrepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe global::Android.Content.ContentValues PrepareConversationValue (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "prepareConversationValue", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/content/ContentValues;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Content.ContentValues __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareConversationValue_Lcom_applozic_mobicommons_people_channel_Conversation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareConversationValue", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Landroid/content/ContentValues;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetUpdateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static void n_UpdateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='updateConversation' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("updateConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V", "GetUpdateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe void UpdateConversation (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "updateConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetUpdateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static void n_UpdateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Database.ConversationDatabaseService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopicLocalImageUri (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.database']/class[@name='ConversationDatabaseService']/method[@name='updateTopicLocalImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("updateTopicLocalImageUri", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetUpdateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe void UpdateTopicLocalImageUri (string p0, global::Java.Lang.Integer p1)
		{
			if (id_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "updateTopicLocalImageUri", "(Ljava/lang/String;Ljava/lang/Integer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateTopicLocalImageUri", "(Ljava/lang/String;Ljava/lang/Integer;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
