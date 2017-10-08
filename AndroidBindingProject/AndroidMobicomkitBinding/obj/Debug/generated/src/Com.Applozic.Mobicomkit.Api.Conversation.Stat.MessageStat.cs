using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Conversation.Stat {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStat']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/conversation/stat/MessageStat", DoNotGenerateAcw=true)]
	public partial class MessageStat : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/conversation/stat/MessageStat", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageStat); }
		}

		protected MessageStat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStat']/constructor[@name='MessageStat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageStat ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageStat)) {
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

		static Delegate cb_getStatList;
#pragma warning disable 0169
		static Delegate GetGetStatListHandler ()
		{
			if (cb_getStatList == null)
				cb_getStatList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatList);
			return cb_getStatList;
		}

		static IntPtr n_GetStatList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat>.ToLocalJniHandle (__this.StatList);
		}
#pragma warning restore 0169

		static IntPtr id_getStatList;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> StatList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStat']/method[@name='getStatList' and count(parameter)=0]"
			[Register ("getStatList", "()Ljava/util/List;", "GetGetStatListHandler")]
			get {
				if (id_getStatList == IntPtr.Zero)
					id_getStatList = JNIEnv.GetMethodID (class_ref, "getStatList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setStat_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetStat_Ljava_util_List_Handler ()
		{
			if (cb_setStat_Ljava_util_List_ == null)
				cb_setStat_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStat_Ljava_util_List_);
			return cb_setStat_Ljava_util_List_;
		}

		static void n_SetStat_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.MessageStat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetStat (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setStat_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.conversation.stat']/class[@name='MessageStat']/method[@name='setStat' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.stat.Stat&gt;']]"
		[Register ("setStat", "(Ljava/util/List;)V", "GetSetStat_Ljava_util_List_Handler")]
		public virtual unsafe void SetStat (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat> p0)
		{
			if (id_setStat_Ljava_util_List_ == IntPtr.Zero)
				id_setStat_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setStat", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Stat.Stat>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStat_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStat", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
