using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/WearableNotificationWithVoice", DoNotGenerateAcw=true)]
	public partial class WearableNotificationWithVoice : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/field[@name='EXTRA_VOICE_REPLY']"
		[Register ("EXTRA_VOICE_REPLY")]
		public const string ExtraVoiceReply = (string) "extra_voice_reply";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/WearableNotificationWithVoice", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (WearableNotificationWithVoice); }
		}

		protected WearableNotificationWithVoice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_support_v4_app_NotificationCompat_Builder_IIII;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/constructor[@name='WearableNotificationWithVoice' and count(parameter)=5 and parameter[1][@type='android.support.v4.app.NotificationCompat.Builder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/support/v4/app/NotificationCompat$Builder;IIII)V", "")]
		public unsafe WearableNotificationWithVoice (global::Android.Support.V4.App.NotificationCompat.Builder p0, int p1, int p2, int p3, int p4)
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
				if (((object) this).GetType () != typeof (WearableNotificationWithVoice)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/support/v4/app/NotificationCompat$Builder;IIII)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/support/v4/app/NotificationCompat$Builder;IIII)V", __args);
					return;
				}

				if (id_ctor_Landroid_support_v4_app_NotificationCompat_Builder_IIII == IntPtr.Zero)
					id_ctor_Landroid_support_v4_app_NotificationCompat_Builder_IIII = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v4/app/NotificationCompat$Builder;IIII)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v4_app_NotificationCompat_Builder_IIII, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_support_v4_app_NotificationCompat_Builder_IIII, __args);
			} finally {
			}
		}

		static Delegate cb_sendNotification;
#pragma warning disable 0169
		static Delegate GetSendNotificationHandler ()
		{
			if (cb_sendNotification == null)
				cb_sendNotification = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SendNotification);
			return cb_sendNotification;
		}

		static void n_SendNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SendNotification ();
		}
#pragma warning restore 0169

		static IntPtr id_sendNotification;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/method[@name='sendNotification' and count(parameter)=0]"
		[Register ("sendNotification", "()V", "GetSendNotificationHandler")]
		public virtual unsafe void SendNotification ()
		{
			if (id_sendNotification == IntPtr.Zero)
				id_sendNotification = JNIEnv.GetMethodID (class_ref, "sendNotification", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendNotification);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendNotification", "()V"));
			} finally {
			}
		}

		static Delegate cb_setCurrentContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetCurrentContext_Landroid_content_Context_Handler ()
		{
			if (cb_setCurrentContext_Landroid_content_Context_ == null)
				cb_setCurrentContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentContext_Landroid_content_Context_);
			return cb_setCurrentContext_Landroid_content_Context_;
		}

		static void n_SetCurrentContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCurrentContext (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCurrentContext_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/method[@name='setCurrentContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setCurrentContext", "(Landroid/content/Context;)V", "GetSetCurrentContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetCurrentContext (global::Android.Content.Context p0)
		{
			if (id_setCurrentContext_Landroid_content_Context_ == IntPtr.Zero)
				id_setCurrentContext_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "setCurrentContext", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentContext_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentContext", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setNotificationHandler_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSetNotificationHandler_Ljava_lang_Class_Handler ()
		{
			if (cb_setNotificationHandler_Ljava_lang_Class_ == null)
				cb_setNotificationHandler_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationHandler_Ljava_lang_Class_);
			return cb_setNotificationHandler_Ljava_lang_Class_;
		}

		static void n_SetNotificationHandler_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetNotificationHandler (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setNotificationHandler_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/method[@name='setNotificationHandler' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("setNotificationHandler", "(Ljava/lang/Class;)V", "GetSetNotificationHandler_Ljava_lang_Class_Handler")]
		public virtual unsafe void SetNotificationHandler (global::Java.Lang.Class p0)
		{
			if (id_setNotificationHandler_Ljava_lang_Class_ == IntPtr.Zero)
				id_setNotificationHandler_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "setNotificationHandler", "(Ljava/lang/Class;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationHandler_Ljava_lang_Class_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationHandler", "(Ljava/lang/Class;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetPendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setPendingIntent_Landroid_app_PendingIntent_ == null)
				cb_setPendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPendingIntent_Landroid_app_PendingIntent_);
			return cb_setPendingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetPendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.WearableNotificationWithVoice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.PendingIntent p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPendingIntent (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPendingIntent_Landroid_app_PendingIntent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='WearableNotificationWithVoice']/method[@name='setPendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
		[Register ("setPendingIntent", "(Landroid/app/PendingIntent;)V", "GetSetPendingIntent_Landroid_app_PendingIntent_Handler")]
		public virtual unsafe void SetPendingIntent (global::Android.App.PendingIntent p0)
		{
			if (id_setPendingIntent_Landroid_app_PendingIntent_ == IntPtr.Zero)
				id_setPendingIntent_Landroid_app_PendingIntent_ = JNIEnv.GetMethodID (class_ref, "setPendingIntent", "(Landroid/app/PendingIntent;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPendingIntent_Landroid_app_PendingIntent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPendingIntent", "(Landroid/app/PendingIntent;)V"), __args);
			} finally {
			}
		}

	}
}
