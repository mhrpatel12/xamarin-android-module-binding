using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='ScheduledMessageUtil']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/schedule/ScheduledMessageUtil", DoNotGenerateAcw=true)]
	public partial class ScheduledMessageUtil : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/schedule/ScheduledMessageUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScheduledMessageUtil); }
		}

		protected ScheduledMessageUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='ScheduledMessageUtil']/constructor[@name='ScheduledMessageUtil' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Class']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/Class;)V", "")]
		public unsafe ScheduledMessageUtil (global::Android.Content.Context p0, global::Java.Lang.Class p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ScheduledMessageUtil)) {
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

		static Delegate cb_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCreateScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_Handler ()
		{
			if (cb_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_ == null)
				cb_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_);
			return cb_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_;
		}

		static void n_CreateScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Schedule.ScheduledMessageUtil __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Schedule.ScheduledMessageUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CreateScheduleMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.schedule']/class[@name='ScheduledMessageUtil']/method[@name='createScheduleMessage' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='android.content.Context']]"
		[Register ("createScheduleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Landroid/content/Context;)V", "GetCreateScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_Handler")]
		public virtual unsafe void CreateScheduleMessage (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Android.Content.Context p1)
		{
			if (id_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_ == IntPtr.Zero)
				id_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "createScheduleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_createScheduleMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createScheduleMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

	}
}
