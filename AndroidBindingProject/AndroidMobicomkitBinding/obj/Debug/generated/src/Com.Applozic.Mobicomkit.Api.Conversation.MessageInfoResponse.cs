using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/MessageInfoResponse", DoNotGenerateAcw=true)]
	public partial class MessageInfoResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/MessageInfoResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageInfoResponse); }
		}

		protected MessageInfoResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']/constructor[@name='MessageInfoResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageInfoResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageInfoResponse)) {
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

		static Delegate cb_getDeliverdToUserList;
#pragma warning disable 0169
		static Delegate GetGetDeliverdToUserListHandler ()
		{
			if (cb_getDeliverdToUserList == null)
				cb_getDeliverdToUserList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeliverdToUserList);
			return cb_getDeliverdToUserList;
		}

		static IntPtr n_GetDeliverdToUserList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.ToLocalJniHandle (__this.DeliverdToUserList);
		}
#pragma warning restore 0169

		static IntPtr id_getDeliverdToUserList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo> DeliverdToUserList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']/method[@name='getDeliverdToUserList' and count(parameter)=0]"
			[Register ("getDeliverdToUserList", "()Ljava/util/List;", "GetGetDeliverdToUserListHandler")]
			get {
				if (id_getDeliverdToUserList == IntPtr.Zero)
					id_getDeliverdToUserList = JNIEnv.GetMethodID (class_ref, "getDeliverdToUserList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeliverdToUserList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeliverdToUserList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageInfoList;
#pragma warning disable 0169
		static Delegate GetGetMessageInfoListHandler ()
		{
			if (cb_getMessageInfoList == null)
				cb_getMessageInfoList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageInfoList);
			return cb_getMessageInfoList;
		}

		static IntPtr n_GetMessageInfoList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.ToLocalJniHandle (__this.MessageInfoList);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageInfoList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetMessageInfoList_Ljava_util_List_Handler ()
		{
			if (cb_setMessageInfoList_Ljava_util_List_ == null)
				cb_setMessageInfoList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageInfoList_Ljava_util_List_);
			return cb_setMessageInfoList_Ljava_util_List_;
		}

		static void n_SetMessageInfoList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageInfoList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageInfoList;
		static IntPtr id_setMessageInfoList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo> MessageInfoList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']/method[@name='getMessageInfoList' and count(parameter)=0]"
			[Register ("getMessageInfoList", "()Ljava/util/List;", "GetGetMessageInfoListHandler")]
			get {
				if (id_getMessageInfoList == IntPtr.Zero)
					id_getMessageInfoList = JNIEnv.GetMethodID (class_ref, "getMessageInfoList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageInfoList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageInfoList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']/method[@name='setMessageInfoList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.MessageInfo&gt;']]"
			[Register ("setMessageInfoList", "(Ljava/util/List;)V", "GetSetMessageInfoList_Ljava_util_List_Handler")]
			set {
				if (id_setMessageInfoList_Ljava_util_List_ == IntPtr.Zero)
					id_setMessageInfoList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setMessageInfoList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageInfoList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageInfoList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getReadByUserList;
#pragma warning disable 0169
		static Delegate GetGetReadByUserListHandler ()
		{
			if (cb_getReadByUserList == null)
				cb_getReadByUserList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReadByUserList);
			return cb_getReadByUserList;
		}

		static IntPtr n_GetReadByUserList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfoResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.ToLocalJniHandle (__this.ReadByUserList);
		}
#pragma warning restore 0169

		static IntPtr id_getReadByUserList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo> ReadByUserList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation']/class[@name='MessageInfoResponse']/method[@name='getReadByUserList' and count(parameter)=0]"
			[Register ("getReadByUserList", "()Ljava/util/List;", "GetGetReadByUserListHandler")]
			get {
				if (id_getReadByUserList == IntPtr.Zero)
					id_getReadByUserList = JNIEnv.GetMethodID (class_ref, "getReadByUserList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReadByUserList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.MessageInfo>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReadByUserList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
