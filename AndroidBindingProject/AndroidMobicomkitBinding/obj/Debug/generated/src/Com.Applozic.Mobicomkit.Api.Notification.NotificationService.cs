using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/NotificationService", DoNotGenerateAcw=true)]
	public partial class NotificationService : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/field[@name='NOTIFICATION_ID']"
		[Register ("NOTIFICATION_ID")]
		public const int NotificationId = (int) 1000;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/NotificationService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NotificationService); }
		}

		protected NotificationService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_ILandroid_content_Context_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/constructor[@name='NotificationService' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(ILandroid/content/Context;III)V", "")]
		public unsafe NotificationService (int p0, global::Android.Content.Context p1, int p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (NotificationService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(ILandroid/content/Context;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(ILandroid/content/Context;III)V", __args);
					return;
				}

				if (id_ctor_ILandroid_content_Context_III == IntPtr.Zero)
					id_ctor_ILandroid_content_Context_III = JNIEnv.GetMethodID (class_ref, "<init>", "(ILandroid/content/Context;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILandroid_content_Context_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_ILandroid_content_Context_III, __args);
			} finally {
			}
		}

		static Delegate cb_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetGetMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_GetMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p3 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = CharSequence.ToLocalJniHandle (__this.GetMessageBodyFormatted (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/method[@name='getMessageBody' and count(parameter)=4 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='int'] and parameter[3][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[4][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("getMessageBody", "(Lcom/applozic/mobicomkit/api/conversation/Message;ILcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/CharSequence;", "GetGetMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe global::Java.Lang.ICharSequence GetMessageBodyFormatted (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, int p1, global::Com.Applozic.Mobicommons.People.Channel.Channel p2, global::Com.Applozic.Mobicommons.People.Contact.Contact p3)
		{
			if (id_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "getMessageBody", "(Lcom/applozic/mobicomkit/api/conversation/Message;ILcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				global::Java.Lang.ICharSequence __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageBody_Lcom_applozic_mobicomkit_api_conversation_Message_ILcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageBody", "(Lcom/applozic/mobicomkit/api/conversation/Message;ILcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		public string GetMessageBody (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, int p1, global::Com.Applozic.Mobicommons.People.Channel.Channel p2, global::Com.Applozic.Mobicommons.People.Contact.Contact p3)
		{
			global::Java.Lang.ICharSequence __result = GetMessageBodyFormatted (p0, p1, p2, p3);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		static Delegate cb_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetGetNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static IntPtr n_GetNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = CharSequence.ToLocalJniHandle (__this.GetNotificationTitleFormatted (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/method[@name='getNotificationTitle' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[3][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("getNotificationTitle", "(ILcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/CharSequence;", "GetGetNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe global::Java.Lang.ICharSequence GetNotificationTitleFormatted (int p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1, global::Com.Applozic.Mobicommons.People.Channel.Channel p2)
		{
			if (id_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "getNotificationTitle", "(ILcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/CharSequence;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::Java.Lang.ICharSequence __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationTitle_ILcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationTitle", "(ILcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		public string GetNotificationTitle (int p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1, global::Com.Applozic.Mobicommons.People.Channel.Channel p2)
		{
			global::Java.Lang.ICharSequence __result = GetNotificationTitleFormatted (p0, p1, p2);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		static Delegate cb_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetNotifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_NotifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUser (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/method[@name='notifyUser' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("notifyUser", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetNotifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void NotifyUser (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2)
		{
			if (id_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "notifyUser", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyUser_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyUser", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetNotifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_NotifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_NotifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.NotificationService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.NotifyUserForNormalMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='NotificationService']/method[@name='notifyUserForNormalMessage' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel'] and parameter[3][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("notifyUserForNormalMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetNotifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void NotifyUserForNormalMessage (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2)
		{
			if (id_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "notifyUserForNormalMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyUserForNormalMessage_Lcom_applozic_mobicommons_people_contact_Contact_Lcom_applozic_mobicommons_people_channel_Channel_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "notifyUserForNormalMessage", "(Lcom/applozic/mobicommons/people/contact/Contact;Lcom/applozic/mobicommons/people/channel/Channel;Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

	}
}
