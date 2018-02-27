using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/ApplozicConversation", DoNotGenerateAcw=true)]
	public partial class ApplozicConversation : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/ApplozicConversation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicConversation); }
		}

		protected ApplozicConversation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/constructor[@name='ApplozicConversation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplozicConversation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApplozicConversation)) {
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

		static IntPtr id_addLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='addLatestMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
		[Register ("addLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/util/List;)V", "")]
		public static unsafe void AddLatestMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p1)
		{
			if (id_addLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_util_List_ == IntPtr.Zero)
				id_addLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "addLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/util/List;)V");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_downloadMessage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='downloadMessage' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[3][@type='com.applozic.mobicomkit.listners.MediaDownloadProgressHandler']]"
		[Register ("downloadMessage", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaDownloadProgressHandler;)V", "")]
		public static unsafe void DownloadMessage (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1, global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler p2)
		{
			if (id_downloadMessage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_ == IntPtr.Zero)
				id_downloadMessage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_ = JNIEnv.GetStaticMethodID (class_ref, "downloadMessage", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaDownloadProgressHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_downloadMessage_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getLatestMessageList_Landroid_content_Context_ZLcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getLatestMessageList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getLatestMessageList", "(Landroid/content/Context;ZLcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetLatestMessageList (global::Android.Content.Context p0, bool p1, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p2)
		{
			if (id_getLatestMessageList_Landroid_content_Context_ZLcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getLatestMessageList_Landroid_content_Context_ZLcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getLatestMessageList", "(Landroid/content/Context;ZLcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getLatestMessageList_Landroid_content_Context_ZLcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getLatestMessageList_Landroid_content_Context_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getLatestMessageList' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getLatestMessageList", "(Landroid/content/Context;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetLatestMessageList (global::Android.Content.Context p0, global::Java.Lang.Long p1, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p2)
		{
			if (id_getLatestMessageList_Landroid_content_Context_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getLatestMessageList_Landroid_content_Context_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getLatestMessageList", "(Landroid/content/Context;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getLatestMessageList_Landroid_content_Context_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getMessageListForChannel_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getMessageListForChannel' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getMessageListForChannel", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetMessageListForChannel (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Java.Lang.Long p2, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p3)
		{
			if (id_getMessageListForChannel_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getMessageListForChannel_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageListForChannel", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getMessageListForChannel_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getMessageListForChannel_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getMessageListForChannel' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getMessageListForChannel", "(Landroid/content/Context;Ljava/lang/Integer;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetMessageListForChannel (global::Android.Content.Context p0, global::Java.Lang.Integer p1, global::Java.Lang.Long p2, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p3)
		{
			if (id_getMessageListForChannel_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getMessageListForChannel_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageListForChannel", "(Landroid/content/Context;Ljava/lang/Integer;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getMessageListForChannel_Landroid_content_Context_Ljava_lang_Integer_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getMessageListForContact_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getMessageListForContact' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getMessageListForContact", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetMessageListForContact (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1, global::Java.Lang.Long p2, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p3)
		{
			if (id_getMessageListForContact_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getMessageListForContact_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageListForContact", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getMessageListForContact_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
			}
		}

		static IntPtr id_getMessageListForContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='ApplozicConversation']/method[@name='getMessageListForContact' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='com.applozic.mobicomkit.listners.MessageListHandler']]"
		[Register ("getMessageListForContact", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V", "")]
		public static unsafe void GetMessageListForContact (global::Android.Content.Context p0, string p1, global::Java.Lang.Long p2, global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler p3)
		{
			if (id_getMessageListForContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ == IntPtr.Zero)
				id_getMessageListForContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_ = JNIEnv.GetStaticMethodID (class_ref, "getMessageListForContact", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Long;Lcom/applozic/mobicomkit/listners/MessageListHandler;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getMessageListForContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_Long_Lcom_applozic_mobicomkit_listners_MessageListHandler_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
