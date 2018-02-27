using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/AttachmentView", DoNotGenerateAcw=true)]
	public partial class AttachmentView : global::Android.Widget.ImageView {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/AttachmentView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachmentView); }
		}

		protected AttachmentView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/constructor[@name='AttachmentView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AttachmentView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AttachmentView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/constructor[@name='AttachmentView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AttachmentView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AttachmentView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/constructor[@name='AttachmentView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AttachmentView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AttachmentView)) {
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
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DownloadProgressLayout);
		}
#pragma warning restore 0169

		static Delegate cb_setDownloadProgressLayout_Landroid_widget_RelativeLayout_;
#pragma warning disable 0169
		static Delegate GetSetDownloadProgressLayout_Landroid_widget_RelativeLayout_Handler ()
		{
			if (cb_setDownloadProgressLayout_Landroid_widget_RelativeLayout_ == null)
				cb_setDownloadProgressLayout_Landroid_widget_RelativeLayout_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDownloadProgressLayout_Landroid_widget_RelativeLayout_);
			return cb_setDownloadProgressLayout_Landroid_widget_RelativeLayout_;
		}

		static void n_SetDownloadProgressLayout_Landroid_widget_RelativeLayout_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.RelativeLayout p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DownloadProgressLayout = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDownloadProgressLayout;
		static IntPtr id_setDownloadProgressLayout_Landroid_widget_RelativeLayout_;
		public virtual unsafe global::Android.Widget.RelativeLayout DownloadProgressLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='getDownloadProgressLayout' and count(parameter)=0]"
			[Register ("getDownloadProgressLayout", "()Landroid/widget/RelativeLayout;", "GetGetDownloadProgressLayoutHandler")]
			get {
				if (id_getDownloadProgressLayout == IntPtr.Zero)
					id_getDownloadProgressLayout = JNIEnv.GetMethodID (class_ref, "getDownloadProgressLayout", "()Landroid/widget/RelativeLayout;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDownloadProgressLayout), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.RelativeLayout> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDownloadProgressLayout", "()Landroid/widget/RelativeLayout;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='setDownloadProgressLayout' and count(parameter)=1 and parameter[1][@type='android.widget.RelativeLayout']]"
			[Register ("setDownloadProgressLayout", "(Landroid/widget/RelativeLayout;)V", "GetSetDownloadProgressLayout_Landroid_widget_RelativeLayout_Handler")]
			set {
				if (id_setDownloadProgressLayout_Landroid_widget_RelativeLayout_ == IntPtr.Zero)
					id_setDownloadProgressLayout_Landroid_widget_RelativeLayout_ = JNIEnv.GetMethodID (class_ref, "setDownloadProgressLayout", "(Landroid/widget/RelativeLayout;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDownloadProgressLayout_Landroid_widget_RelativeLayout_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDownloadProgressLayout", "(Landroid/widget/RelativeLayout;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				if (id_getImageUrl == IntPtr.Zero)
					id_getImageUrl = JNIEnv.GetMethodID (class_ref, "getImageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLocalPath;
#pragma warning disable 0169
		static Delegate GetGetLocalPathHandler ()
		{
			if (cb_getLocalPath == null)
				cb_getLocalPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalPath);
			return cb_getLocalPath;
		}

		static IntPtr n_GetLocalPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalPath);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalPath;
		public virtual unsafe string LocalPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='getLocalPath' and count(parameter)=0]"
			[Register ("getLocalPath", "()Ljava/lang/String;", "GetGetLocalPathHandler")]
			get {
				if (id_getLocalPath == IntPtr.Zero)
					id_getLocalPath = JNIEnv.GetMethodID (class_ref, "getLocalPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessage;
#pragma warning disable 0169
		static Delegate GetGetMessageHandler ()
		{
			if (cb_getMessage == null)
				cb_getMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessage);
			return cb_getMessage;
		}

		static IntPtr n_GetMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static Delegate cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetSetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_SetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Message = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		static IntPtr id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessage", "()Lcom/applozic/mobicomkit/api/conversation/Message;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='setMessage' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
			[Register ("setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetSetMessage_Lcom_applozic_mobicomkit_api_conversation_Message_Handler")]
			set {
				if (id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
					id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessage_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessage", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProressBar;
#pragma warning disable 0169
		static Delegate GetGetProressBarHandler ()
		{
			if (cb_getProressBar == null)
				cb_getProressBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProressBar);
			return cb_getProressBar;
		}

		static IntPtr n_GetProressBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProressBar);
		}
#pragma warning restore 0169

		static Delegate cb_setProressBar_Landroid_widget_ProgressBar_;
#pragma warning disable 0169
		static Delegate GetSetProressBar_Landroid_widget_ProgressBar_Handler ()
		{
			if (cb_setProressBar_Landroid_widget_ProgressBar_ == null)
				cb_setProressBar_Landroid_widget_ProgressBar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProressBar_Landroid_widget_ProgressBar_);
			return cb_setProressBar_Landroid_widget_ProgressBar_;
		}

		static void n_SetProressBar_Landroid_widget_ProgressBar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ProgressBar p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProressBar = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProressBar;
		static IntPtr id_setProressBar_Landroid_widget_ProgressBar_;
		public virtual unsafe global::Android.Widget.ProgressBar ProressBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='getProressBar' and count(parameter)=0]"
			[Register ("getProressBar", "()Landroid/widget/ProgressBar;", "GetGetProressBarHandler")]
			get {
				if (id_getProressBar == IntPtr.Zero)
					id_getProressBar = JNIEnv.GetMethodID (class_ref, "getProressBar", "()Landroid/widget/ProgressBar;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProressBar), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Widget.ProgressBar> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProressBar", "()Landroid/widget/ProgressBar;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='setProressBar' and count(parameter)=1 and parameter[1][@type='android.widget.ProgressBar']]"
			[Register ("setProressBar", "(Landroid/widget/ProgressBar;)V", "GetSetProressBar_Landroid_widget_ProgressBar_Handler")]
			set {
				if (id_setProressBar_Landroid_widget_ProgressBar_ == IntPtr.Zero)
					id_setProressBar_Landroid_widget_ProgressBar_ = JNIEnv.GetMethodID (class_ref, "setProressBar", "(Landroid/widget/ProgressBar;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProressBar_Landroid_widget_ProgressBar_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProressBar", "(Landroid/widget/ProgressBar;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelDownload ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelDownload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='cancelDownload' and count(parameter)=0]"
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

		static Delegate cb_contentType;
#pragma warning disable 0169
		static Delegate GetContentTypeHandler ()
		{
			if (cb_contentType == null)
				cb_contentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ContentType);
			return cb_contentType;
		}

		static IntPtr n_ContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType ());
		}
#pragma warning restore 0169

		static IntPtr id_contentType;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='contentType' and count(parameter)=0]"
		[Register ("contentType", "()Ljava/lang/String;", "GetContentTypeHandler")]
		public virtual unsafe string ContentType ()
		{
			if (id_contentType == IntPtr.Zero)
				id_contentType = JNIEnv.GetMethodID (class_ref, "contentType", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_contentType), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "contentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMCacheFlag_Z;
#pragma warning disable 0169
		static Delegate GetSetMCacheFlag_ZHandler ()
		{
			if (cb_setMCacheFlag_Z == null)
				cb_setMCacheFlag_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMCacheFlag_Z);
			return cb_setMCacheFlag_Z;
		}

		static void n_SetMCacheFlag_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMCacheFlag (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMCacheFlag_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentView']/method[@name='setMCacheFlag' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMCacheFlag", "(Z)V", "GetSetMCacheFlag_ZHandler")]
		public virtual unsafe void SetMCacheFlag (bool p0)
		{
			if (id_setMCacheFlag_Z == IntPtr.Zero)
				id_setMCacheFlag_Z = JNIEnv.GetMethodID (class_ref, "setMCacheFlag", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMCacheFlag_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMCacheFlag", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
