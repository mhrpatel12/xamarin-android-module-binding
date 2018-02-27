using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/interface[@name='MessageCommunicator']"
	[Register ("com/applozic/mobicomkit/uiwidgets/conversation/MessageCommunicator", "", "Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicatorInvoker")]
	public partial interface IMessageCommunicator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/interface[@name='MessageCommunicator']/method[@name='removeConversation' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeConversation", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetRemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicatorInvoker, AndroidBindingProject")]
		void RemoveConversation (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation']/interface[@name='MessageCommunicator']/method[@name='updateLatestMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='java.lang.String']]"
		[Register ("updateLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "GetUpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler:Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicatorInvoker, AndroidBindingProject")]
		void UpdateLatestMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/MessageCommunicator", DoNotGenerateAcw=true)]
	internal class IMessageCommunicatorInvoker : global::Java.Lang.Object, IMessageCommunicator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/MessageCommunicator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessageCommunicatorInvoker); }
		}

		IntPtr class_ref;

		public static IMessageCommunicator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageCommunicator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.uiwidgets.conversation.MessageCommunicator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageCommunicatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_RemoveConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConversation (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		public unsafe void RemoveConversation (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeConversation", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeConversation_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_Handler ()
		{
			if (cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == null)
				cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_);
			return cb_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		}

		static void n_UpdateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicator __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.IMessageCommunicator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLatestMessage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		public unsafe void UpdateLatestMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, string p1)
		{
			if (id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
				id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateLatestMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLatestMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
