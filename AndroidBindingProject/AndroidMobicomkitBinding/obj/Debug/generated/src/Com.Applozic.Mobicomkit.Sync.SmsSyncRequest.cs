using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SmsSyncRequest']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/sync/SmsSyncRequest", DoNotGenerateAcw=true)]
	public partial class SmsSyncRequest : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/sync/SmsSyncRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SmsSyncRequest); }
		}

		protected SmsSyncRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SmsSyncRequest']/constructor[@name='SmsSyncRequest' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SmsSyncRequest ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SmsSyncRequest)) {
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

		static Delegate cb_getSmsList;
#pragma warning disable 0169
		static Delegate GetGetSmsListHandler ()
		{
			if (cb_getSmsList == null)
				cb_getSmsList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSmsList);
			return cb_getSmsList;
		}

		static IntPtr n_GetSmsList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (__this.SmsList);
		}
#pragma warning restore 0169

		static Delegate cb_setSmsList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSmsList_Ljava_util_List_Handler ()
		{
			if (cb_setSmsList_Ljava_util_List_ == null)
				cb_setSmsList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSmsList_Ljava_util_List_);
			return cb_setSmsList_Ljava_util_List_;
		}

		static void n_SetSmsList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SmsSyncRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SmsList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSmsList;
		static IntPtr id_setSmsList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> SmsList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SmsSyncRequest']/method[@name='getSmsList' and count(parameter)=0]"
			[Register ("getSmsList", "()Ljava/util/List;", "GetGetSmsListHandler")]
			get {
				if (id_getSmsList == IntPtr.Zero)
					id_getSmsList = JNIEnv.GetMethodID (class_ref, "getSmsList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSmsList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSmsList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SmsSyncRequest']/method[@name='setSmsList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;']]"
			[Register ("setSmsList", "(Ljava/util/List;)V", "GetSetSmsList_Ljava_util_List_Handler")]
			set {
				if (id_setSmsList_Ljava_util_List_ == IntPtr.Zero)
					id_setSmsList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSmsList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmsList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmsList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
