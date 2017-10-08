using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStatClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/stat/MessageStatClientService", DoNotGenerateAcw=true)]
	public partial class MessageStatClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/stat/MessageStatClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageStatClientService); }
		}

		protected MessageStatClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStatClientService']/constructor[@name='MessageStatClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MessageStatClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MessageStatClientService)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getMessageStatUrl;
#pragma warning disable 0169
		static Delegate GetGetMessageStatUrlHandler ()
		{
			if (cb_getMessageStatUrl == null)
				cb_getMessageStatUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageStatUrl);
			return cb_getMessageStatUrl;
		}

		static IntPtr n_GetMessageStatUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStatClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStatClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageStatUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageStatUrl;
		public virtual unsafe string MessageStatUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStatClientService']/method[@name='getMessageStatUrl' and count(parameter)=0]"
			[Register ("getMessageStatUrl", "()Ljava/lang/String;", "GetGetMessageStatUrlHandler")]
			get {
				if (id_getMessageStatUrl == IntPtr.Zero)
					id_getMessageStatUrl = JNIEnv.GetMethodID (class_ref, "getMessageStatUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageStatUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageStatUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_;
#pragma warning disable 0169
		static Delegate GetSendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_Handler ()
		{
			if (cb_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_ == null)
				cb_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_);
			return cb_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_;
		}

		static IntPtr n_SendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStatClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStatClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SendMessageStat (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStatClientService']/method[@name='sendMessageStat' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.stat.MessageStat']]"
		[Register ("sendMessageStat", "(Lcom/applozic/mobicomkit/api/conversation/stat/MessageStat;)Ljava/lang/String;", "GetSendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_Handler")]
		public virtual unsafe string SendMessageStat (global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat p0)
		{
			if (id_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_ == IntPtr.Zero)
				id_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_ = JNIEnv.GetMethodID (class_ref, "sendMessageStat", "(Lcom/applozic/mobicomkit/api/conversation/stat/MessageStat;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_sendMessageStat_Lcom_applozic_mobicomkit_api_conversation_stat_MessageStat_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendMessageStat", "(Lcom/applozic/mobicomkit/api/conversation/stat/MessageStat;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
