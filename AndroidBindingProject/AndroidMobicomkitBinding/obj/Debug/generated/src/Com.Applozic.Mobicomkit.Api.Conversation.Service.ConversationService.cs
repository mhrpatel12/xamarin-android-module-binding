using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/service/ConversationService", DoNotGenerateAcw=true)]
	public partial class ConversationService : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/service/ConversationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationService); }
		}

		protected ConversationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='addConversation' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
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

		static Delegate cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetCreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static IntPtr n_CreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConversation (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='createConversation' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
		[Register ("createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Ljava/lang/Integer;", "GetCreateConversation_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
		public virtual unsafe global::Java.Lang.Integer CreateConversation (global::Com.Applozic.Mobicommons.People.Channel.Conversation p0)
		{
			if (id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
				id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Ljava/lang/Integer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Java.Lang.Integer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createConversation_Lcom_applozic_mobicommons_people_channel_Conversation_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createConversation", "(Lcom/applozic/mobicommons/people/channel/Conversation;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteConversation_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='deleteConversation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getConversation_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetConversation_Ljava_lang_Integer_Handler ()
		{
			if (cb_getConversation_Ljava_lang_Integer_ == null)
				cb_getConversation_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetConversation_Ljava_lang_Integer_);
			return cb_getConversation_Ljava_lang_Integer_;
		}

		static void n_GetConversation_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetConversation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getConversation_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='getConversation' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getConversation", "(Ljava/lang/Integer;)V", "GetGetConversation_Ljava_lang_Integer_Handler")]
		public virtual unsafe void GetConversation (global::Java.Lang.Integer p0)
		{
			if (id_getConversation_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getConversation_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getConversation", "(Ljava/lang/Integer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getConversation_Ljava_lang_Integer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversation", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConversationByConversationId (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationByConversationId_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='getConversationByConversationId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Channel.Conversation>.ToLocalJniHandle (__this.GetConversationList (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationList_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='getConversationList' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
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
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/service/ConversationService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/api/conversation/service/ConversationService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isConversationExist_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsConversationExist_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_isConversationExist_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_isConversationExist_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_IsConversationExist_Ljava_lang_String_Ljava_lang_String_);
			return cb_isConversationExist_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_IsConversationExist_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsConversationExist (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationExist_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='isConversationExist' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isConversationExist", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;", "GetIsConversationExist_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Integer IsConversationExist (string p0, string p1)
		{
			if (id_isConversationExist_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isConversationExist_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isConversationExist", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Java.Lang.Integer __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isConversationExist_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationExist", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/Integer;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetProcessConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ProcessConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_ProcessConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation[] p0 = (global::Com.Applozic.Mobicommons.People.Channel.Conversation[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Applozic.Mobicommons.People.Channel.Conversation));
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.ProcessConversationArray (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='processConversationArray' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation[]'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("processConversationArray", "([Lcom/applozic/mobicommons/people/channel/Conversation;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetProcessConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void ProcessConversationArray (global::Com.Applozic.Mobicommons.People.Channel.Conversation[] p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicommons.People.Contact.Contact p2)
		{
			if (id_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "processConversationArray", "([Lcom/applozic/mobicommons/people/channel/Conversation;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processConversationArray_arrayLcom_applozic_mobicommons_people_channel_Conversation_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processConversationArray", "([Lcom/applozic/mobicommons/people/channel/Conversation;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Service.ConversationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTopicLocalImageUri (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateTopicLocalImageUri_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.service']/class[@name='ConversationService']/method[@name='updateTopicLocalImageUri' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
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
