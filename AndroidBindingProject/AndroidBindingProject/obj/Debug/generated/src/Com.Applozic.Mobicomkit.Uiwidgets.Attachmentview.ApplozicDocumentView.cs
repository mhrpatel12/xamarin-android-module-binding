using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicDocumentView", DoNotGenerateAcw=true)]
	public partial class ApplozicDocumentView : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/attachmentview/ApplozicDocumentView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicDocumentView); }
		}

		protected ApplozicDocumentView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/constructor[@name='ApplozicDocumentView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ApplozicDocumentView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ApplozicDocumentView)) {
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

		static Delegate cb_getDownloadProgressLayout;
#pragma warning disable 0169
		static Delegate GetGetDownloadProgressLayoutHandler ()
		{
			if (cb_getDownloadProgressLayout == null)
				cb_getDownloadProgressLayout = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDownloadProgressLayout);
			return cb_getDownloadProgressLayout;
		}

		static IntPtr n_GetDownloadProgressLayout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadProgressLayout);
		}
#pragma warning restore 0169

		static IntPtr id_getDownloadProgressLayout;
		public virtual unsafe global::Android.Views.View DownloadProgressLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='getDownloadProgressLayout' and count(parameter)=0]"
			[Register ("getDownloadProgressLayout", "()Landroid/view/View;", "GetGetDownloadProgressLayoutHandler")]
			get {
				if (id_getDownloadProgressLayout == IntPtr.Zero)
					id_getDownloadProgressLayout = JNIEnv.GetMethodID (class_ref, "getDownloadProgressLayout", "()Landroid/view/View;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDownloadProgressLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDownloadProgressLayout", "()Landroid/view/View;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDownloadRequire;
#pragma warning disable 0169
		static Delegate GetIsDownloadRequireHandler ()
		{
			if (cb_isDownloadRequire == null)
				cb_isDownloadRequire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDownloadRequire);
			return cb_isDownloadRequire;
		}

		static bool n_IsDownloadRequire (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDownloadRequire;
		}
#pragma warning restore 0169

		static IntPtr id_isDownloadRequire;
		public virtual unsafe bool IsDownloadRequire {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='isDownloadRequire' and count(parameter)=0]"
			[Register ("isDownloadRequire", "()Z", "GetIsDownloadRequireHandler")]
			get {
				if (id_isDownloadRequire == IntPtr.Zero)
					id_isDownloadRequire = JNIEnv.GetMethodID (class_ref, "isDownloadRequire", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDownloadRequire);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDownloadRequire", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUploadRequire;
#pragma warning disable 0169
		static Delegate GetIsUploadRequireHandler ()
		{
			if (cb_isUploadRequire == null)
				cb_isUploadRequire = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUploadRequire);
			return cb_isUploadRequire;
		}

		static bool n_IsUploadRequire (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUploadRequire;
		}
#pragma warning restore 0169

		static IntPtr id_isUploadRequire;
		public virtual unsafe bool IsUploadRequire {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='isUploadRequire' and count(parameter)=0]"
			[Register ("isUploadRequire", "()Z", "GetIsUploadRequireHandler")]
			get {
				if (id_isUploadRequire == IntPtr.Zero)
					id_isUploadRequire = JNIEnv.GetMethodID (class_ref, "isUploadRequire", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUploadRequire);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUploadRequire", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancelDownload;
#pragma warning disable 0169
		static Delegate GetCancelDownloadHandler ()
		{
			if (cb_cancelDownload == null)
				cb_cancelDownload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelDownload);
			return cb_cancelDownload;
		}

		static void n_CancelDownload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDownload ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelDownload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='cancelDownload' and count(parameter)=0]"
		[Register ("cancelDownload", "()V", "GetCancelDownloadHandler")]
		public virtual unsafe void CancelDownload ()
		{
			if (id_cancelDownload == IntPtr.Zero)
				id_cancelDownload = JNIEnv.GetMethodID (class_ref, "cancelDownload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelDownload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelDownload", "()V"));
			} finally {
			}
		}

		static Delegate cb_hideView_Z;
#pragma warning disable 0169
		static Delegate GetHideView_ZHandler ()
		{
			if (cb_hideView_Z == null)
				cb_hideView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_HideView_Z);
			return cb_hideView_Z;
		}

		static void n_HideView_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_hideView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='hideView' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("hideView", "(Z)V", "GetHideView_ZHandler")]
		public virtual unsafe void HideView (bool p0)
		{
			if (id_hideView_Z == IntPtr.Zero)
				id_hideView_Z = JNIEnv.GetMethodID (class_ref, "hideView", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_hideView_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideView", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetInflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_InflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_InflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.InflateViewWithMessage (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='inflateViewWithMessage' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("inflateViewWithMessage", "(Landroid/view/View;Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetInflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
		public virtual unsafe void InflateViewWithMessage (global::Android.Views.View p0, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p1)
		{
			if (id_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "inflateViewWithMessage", "(Landroid/view/View;Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_inflateViewWithMessage_Landroid_view_View_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "inflateViewWithMessage", "(Landroid/view/View;Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_registerEvents;
#pragma warning disable 0169
		static Delegate GetRegisterEventsHandler ()
		{
			if (cb_registerEvents == null)
				cb_registerEvents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RegisterEvents);
			return cb_registerEvents;
		}

		static void n_RegisterEvents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RegisterEvents ();
		}
#pragma warning restore 0169

		static IntPtr id_registerEvents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='registerEvents' and count(parameter)=0]"
		[Register ("registerEvents", "()V", "GetRegisterEventsHandler")]
		public virtual unsafe void RegisterEvents ()
		{
			if (id_registerEvents == IntPtr.Zero)
				id_registerEvents = JNIEnv.GetMethodID (class_ref, "registerEvents", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerEvents);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "registerEvents", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAudioIcons;
#pragma warning disable 0169
		static Delegate GetSetAudioIconsHandler ()
		{
			if (cb_setAudioIcons == null)
				cb_setAudioIcons = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetAudioIcons);
			return cb_setAudioIcons;
		}

		static void n_SetAudioIcons (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioIcons ();
		}
#pragma warning restore 0169

		static IntPtr id_setAudioIcons;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='setAudioIcons' and count(parameter)=0]"
		[Register ("setAudioIcons", "()V", "GetSetAudioIconsHandler")]
		public virtual unsafe void SetAudioIcons ()
		{
			if (id_setAudioIcons == IntPtr.Zero)
				id_setAudioIcons = JNIEnv.GetMethodID (class_ref, "setAudioIcons", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAudioIcons);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAudioIcons", "()V"));
			} finally {
			}
		}

		static Delegate cb_showDownloadInProgress;
#pragma warning disable 0169
		static Delegate GetShowDownloadInProgressHandler ()
		{
			if (cb_showDownloadInProgress == null)
				cb_showDownloadInProgress = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowDownloadInProgress);
			return cb_showDownloadInProgress;
		}

		static void n_ShowDownloadInProgress (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDownloadInProgress ();
		}
#pragma warning restore 0169

		static IntPtr id_showDownloadInProgress;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='showDownloadInProgress' and count(parameter)=0]"
		[Register ("showDownloadInProgress", "()V", "GetShowDownloadInProgressHandler")]
		public virtual unsafe void ShowDownloadInProgress ()
		{
			if (id_showDownloadInProgress == IntPtr.Zero)
				id_showDownloadInProgress = JNIEnv.GetMethodID (class_ref, "showDownloadInProgress", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showDownloadInProgress);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showDownloadInProgress", "()V"));
			} finally {
			}
		}

		static Delegate cb_showDownloaded;
#pragma warning disable 0169
		static Delegate GetShowDownloadedHandler ()
		{
			if (cb_showDownloaded == null)
				cb_showDownloaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowDownloaded);
			return cb_showDownloaded;
		}

		static void n_ShowDownloaded (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowDownloaded ();
		}
#pragma warning restore 0169

		static IntPtr id_showDownloaded;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='showDownloaded' and count(parameter)=0]"
		[Register ("showDownloaded", "()V", "GetShowDownloadedHandler")]
		public virtual unsafe void ShowDownloaded ()
		{
			if (id_showDownloaded == IntPtr.Zero)
				id_showDownloaded = JNIEnv.GetMethodID (class_ref, "showDownloaded", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showDownloaded);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showDownloaded", "()V"));
			} finally {
			}
		}

		static Delegate cb_showPreview;
#pragma warning disable 0169
		static Delegate GetShowPreviewHandler ()
		{
			if (cb_showPreview == null)
				cb_showPreview = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowPreview);
			return cb_showPreview;
		}

		static void n_ShowPreview (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowPreview ();
		}
#pragma warning restore 0169

		static IntPtr id_showPreview;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='showPreview' and count(parameter)=0]"
		[Register ("showPreview", "()V", "GetShowPreviewHandler")]
		public virtual unsafe void ShowPreview ()
		{
			if (id_showPreview == IntPtr.Zero)
				id_showPreview = JNIEnv.GetMethodID (class_ref, "showPreview", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_showPreview);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showPreview", "()V"));
			} finally {
			}
		}

		static Delegate cb_updateApplozicSeekBar;
#pragma warning disable 0169
		static Delegate GetUpdateApplozicSeekBarHandler ()
		{
			if (cb_updateApplozicSeekBar == null)
				cb_updateApplozicSeekBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateApplozicSeekBar);
			return cb_updateApplozicSeekBar;
		}

		static void n_UpdateApplozicSeekBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Attachmentview.ApplozicDocumentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateApplozicSeekBar ();
		}
#pragma warning restore 0169

		static IntPtr id_updateApplozicSeekBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.attachmentview']/class[@name='ApplozicDocumentView']/method[@name='updateApplozicSeekBar' and count(parameter)=0]"
		[Register ("updateApplozicSeekBar", "()V", "GetUpdateApplozicSeekBarHandler")]
		public virtual unsafe void UpdateApplozicSeekBar ()
		{
			if (id_updateApplozicSeekBar == IntPtr.Zero)
				id_updateApplozicSeekBar = JNIEnv.GetMethodID (class_ref, "updateApplozicSeekBar", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateApplozicSeekBar);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateApplozicSeekBar", "()V"));
			} finally {
			}
		}

	}
}
