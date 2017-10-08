using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='MessageSenderTimerTask']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/schedule/MessageSenderTimerTask", DoNotGenerateAcw=true)]
	public partial class MessageSenderTimerTask : global::Java.Util.TimerTask {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/schedule/MessageSenderTimerTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageSenderTimerTask); }
		}

		protected MessageSenderTimerTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_applozic_mobicomkit_api_conversation_MobiComMessageService_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='MessageSenderTimerTask']/constructor[@name='MessageSenderTimerTask' and count(parameter)=3 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.MobiComMessageService'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/applozic/mobicomkit/api/conversation/MobiComMessageService;Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", "")]
		public unsafe MessageSenderTimerTask (global::Com.Applozic.Mobicomkit.Api.Conversation.MobiComMessageService p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (MessageSenderTimerTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicomkit/api/conversation/MobiComMessageService;Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicomkit/api/conversation/MobiComMessageService;Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicomkit_api_conversation_MobiComMessageService_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicomkit_api_conversation_MobiComMessageService_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/api/conversation/MobiComMessageService;Lcom/applozic/mobicomkit/api/conversation/Message;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_api_conversation_MobiComMessageService_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_api_conversation_MobiComMessageService_Lcom_applozic_mobicomkit_api_conversation_Message_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
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
			global::Com.Applozic.Mobicomkit.Api.Conversation.Schedule.MessageSenderTimerTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Schedule.MessageSenderTimerTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='MessageSenderTimerTask']/method[@name='run' and count(parameter)=0]"
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
