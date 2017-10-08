using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Selfdestruct {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.selfdestruct']/class[@name='DisappearingMessageTask']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/selfdestruct/DisappearingMessageTask", DoNotGenerateAcw=true)]
	public partial class DisappearingMessageTask : global::Java.Util.TimerTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/selfdestruct/DisappearingMessageTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DisappearingMessageTask); }
		}

		protected DisappearingMessageTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_MobiComConversationService_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.selfdestruct']/class[@name='DisappearingMessageTask']/constructor[@name='DisappearingMessageTask' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.MobiComConversationService'] and parameter[3][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "")]
		public unsafe DisappearingMessageTask (global::Android.Content.Context p0, global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComConversationService p1, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (DisappearingMessageTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;Lcom/applozic/mobicomkit/api/conversation/Message;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;Lcom/applozic/mobicomkit/api/conversation/Message;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_MobiComConversationService_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_MobiComConversationService_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/applozic/mobicomkit/api/conversation/MobiComConversationService;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_MobiComConversationService_Lcom_applozic_mobicomkit_api_conversation_Message_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_applozic_mobicomkit_api_conversation_MobiComConversationService_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Selfdestruct.DisappearingMessageTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Selfdestruct.DisappearingMessageTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.selfdestruct']/class[@name='DisappearingMessageTask']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public override unsafe void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
			} finally {
			}
		}

	}
}
