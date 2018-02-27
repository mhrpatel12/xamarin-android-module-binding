using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/interface[@name='OnClickReplyInterface']"
	[Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/OnClickReplyInterface", "", "Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IOnClickReplyInterfaceInvoker")]
	public partial interface IOnClickReplyInterface : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/interface[@name='OnClickReplyInterface']/method[@name='onClickOnMessageReply' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("onClickOnMessageReply", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetOnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_Handler:Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IOnClickReplyInterfaceInvoker, AndroidBindingProject")]
		void OnClickOnMessageReply (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/OnClickReplyInterface", DoNotGenerateAcw=true)]
	internal class IOnClickReplyInterfaceInvoker : global::Java.Lang.Object, IOnClickReplyInterface {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/OnClickReplyInterface");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnClickReplyInterfaceInvoker); }
		}

		IntPtr class_ref;

		public static IOnClickReplyInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnClickReplyInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.uiwidgets.conversation.activity.OnClickReplyInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnClickReplyInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetOnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_OnClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IOnClickReplyInterface __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IOnClickReplyInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClickOnMessageReply (p0);
		}
#pragma warning restore 0169

		IntPtr id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public unsafe void OnClickOnMessageReply (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "onClickOnMessageReply", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClickOnMessageReply_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
		}

	}

}
