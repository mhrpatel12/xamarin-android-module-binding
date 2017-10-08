using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/AttachmentTask", DoNotGenerateAcw=true)]
	public partial class AttachmentTask : global::Java.Lang.Object, global::Com.Applozic.Mobicommons.Commons.Image.PhotoDecodeRunnable.ITaskRunnableDecodeMethods {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/AttachmentTask", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachmentTask); }
		}

		protected AttachmentTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getContentType;
#pragma warning disable 0169
		static Delegate GetGetContentTypeHandler ()
		{
			if (cb_getContentType == null)
				cb_getContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentType);
			return cb_getContentType;
		}

		static IntPtr n_GetContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getContentType;
		public virtual unsafe string ContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getContentType' and count(parameter)=0]"
			[Register ("getContentType", "()Ljava/lang/String;", "GetGetContentTypeHandler")]
			get {
				if (id_getContentType == IntPtr.Zero)
					id_getContentType = JNIEnv.GetMethodID (class_ref, "getContentType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCurrentThread;
#pragma warning disable 0169
		static Delegate GetGetCurrentThreadHandler ()
		{
			if (cb_getCurrentThread == null)
				cb_getCurrentThread = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentThread);
			return cb_getCurrentThread;
		}

		static IntPtr n_GetCurrentThread (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentThread);
		}
#pragma warning restore 0169

		static Delegate cb_setCurrentThread_Ljava_lang_Thread_;
#pragma warning disable 0169
		static Delegate GetSetCurrentThread_Ljava_lang_Thread_Handler ()
		{
			if (cb_setCurrentThread_Ljava_lang_Thread_ == null)
				cb_setCurrentThread_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCurrentThread_Ljava_lang_Thread_);
			return cb_setCurrentThread_Ljava_lang_Thread_;
		}

		static void n_SetCurrentThread_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CurrentThread = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentThread;
		static IntPtr id_setCurrentThread_Ljava_lang_Thread_;
		public virtual unsafe global::Java.Lang.Thread CurrentThread {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getCurrentThread' and count(parameter)=0]"
			[Register ("getCurrentThread", "()Ljava/lang/Thread;", "GetGetCurrentThreadHandler")]
			get {
				if (id_getCurrentThread == IntPtr.Zero)
					id_getCurrentThread = JNIEnv.GetMethodID (class_ref, "getCurrentThread", "()Ljava/lang/Thread;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentThread), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentThread", "()Ljava/lang/Thread;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='setCurrentThread' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
			[Register ("setCurrentThread", "(Ljava/lang/Thread;)V", "GetSetCurrentThread_Ljava_lang_Thread_Handler")]
			set {
				if (id_setCurrentThread_Ljava_lang_Thread_ == IntPtr.Zero)
					id_setCurrentThread_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "setCurrentThread", "(Ljava/lang/Thread;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCurrentThread_Ljava_lang_Thread_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCurrentThread", "(Ljava/lang/Thread;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageURL;
#pragma warning disable 0169
		static Delegate GetGetImageURLHandler ()
		{
			if (cb_getImageURL == null)
				cb_getImageURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageURL);
			return cb_getImageURL;
		}

		static IntPtr n_GetImageURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		static IntPtr id_getImageURL;
		public virtual unsafe string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getImageURL' and count(parameter)=0]"
			[Register ("getImageURL", "()Ljava/lang/String;", "GetGetImageURLHandler")]
			get {
				if (id_getImageURL == IntPtr.Zero)
					id_getImageURL = JNIEnv.GetMethodID (class_ref, "getImageURL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalPath);
		}
#pragma warning restore 0169

		static IntPtr id_getLocalPath;
		public virtual unsafe string LocalPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getLocalPath' and count(parameter)=0]"
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
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Message);
		}
#pragma warning restore 0169

		static IntPtr id_getMessage;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getMessage' and count(parameter)=0]"
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
		}

		static Delegate cb_getMessageDetail;
#pragma warning disable 0169
		static Delegate GetGetMessageDetailHandler ()
		{
			if (cb_getMessageDetail == null)
				cb_getMessageDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageDetail);
			return cb_getMessageDetail;
		}

		static IntPtr n_GetMessageDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageDetail);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageDetail;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Conversation.Message MessageDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getMessageDetail' and count(parameter)=0]"
			[Register ("getMessageDetail", "()Lcom/applozic/mobicomkit/api/conversation/Message;", "GetGetMessageDetailHandler")]
			get {
				if (id_getMessageDetail == IntPtr.Zero)
					id_getMessageDetail = JNIEnv.GetMethodID (class_ref, "getMessageDetail", "()Lcom/applozic/mobicomkit/api/conversation/Message;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageDetail), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageDetail", "()Lcom/applozic/mobicomkit/api/conversation/Message;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPhotoView;
#pragma warning disable 0169
		static Delegate GetGetPhotoViewHandler ()
		{
			if (cb_getPhotoView == null)
				cb_getPhotoView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhotoView);
			return cb_getPhotoView;
		}

		static IntPtr n_GetPhotoView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PhotoView);
		}
#pragma warning restore 0169

		static IntPtr id_getPhotoView;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView PhotoView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getPhotoView' and count(parameter)=0]"
			[Register ("getPhotoView", "()Lcom/applozic/mobicomkit/api/attachment/AttachmentView;", "GetGetPhotoViewHandler")]
			get {
				if (id_getPhotoView == IntPtr.Zero)
					id_getPhotoView = JNIEnv.GetMethodID (class_ref, "getPhotoView", "()Lcom/applozic/mobicomkit/api/attachment/AttachmentView;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhotoView), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhotoView", "()Lcom/applozic/mobicomkit/api/attachment/AttachmentView;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetHeight;
#pragma warning disable 0169
		static Delegate GetGetTargetHeightHandler ()
		{
			if (cb_getTargetHeight == null)
				cb_getTargetHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTargetHeight);
			return cb_getTargetHeight;
		}

		static int n_GetTargetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetHeight;
		public virtual unsafe int TargetHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getTargetHeight' and count(parameter)=0]"
			[Register ("getTargetHeight", "()I", "GetGetTargetHeightHandler")]
			get {
				if (id_getTargetHeight == IntPtr.Zero)
					id_getTargetHeight = JNIEnv.GetMethodID (class_ref, "getTargetHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTargetHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTargetWidth;
#pragma warning disable 0169
		static Delegate GetGetTargetWidthHandler ()
		{
			if (cb_getTargetWidth == null)
				cb_getTargetWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTargetWidth);
			return cb_getTargetWidth;
		}

		static int n_GetTargetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TargetWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getTargetWidth;
		public virtual unsafe int TargetWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='getTargetWidth' and count(parameter)=0]"
			[Register ("getTargetWidth", "()I", "GetGetTargetWidthHandler")]
			get {
				if (id_getTargetWidth == IntPtr.Zero)
					id_getTargetWidth = JNIEnv.GetMethodID (class_ref, "getTargetWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTargetWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTargetWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_handleDecodeState_I;
#pragma warning disable 0169
		static Delegate GetHandleDecodeState_IHandler ()
		{
			if (cb_handleDecodeState_I == null)
				cb_handleDecodeState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_HandleDecodeState_I);
			return cb_handleDecodeState_I;
		}

		static void n_HandleDecodeState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDecodeState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleDecodeState_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='handleDecodeState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("handleDecodeState", "(I)V", "GetHandleDecodeState_IHandler")]
		public virtual unsafe void HandleDecodeState (int p0)
		{
			if (id_handleDecodeState_I == IntPtr.Zero)
				id_handleDecodeState_I = JNIEnv.GetMethodID (class_ref, "handleDecodeState", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDecodeState_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDecodeState", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_handleDownloadState_I;
#pragma warning disable 0169
		static Delegate GetHandleDownloadState_IHandler ()
		{
			if (cb_handleDownloadState_I == null)
				cb_handleDownloadState_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_HandleDownloadState_I);
			return cb_handleDownloadState_I;
		}

		static void n_HandleDownloadState_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HandleDownloadState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_handleDownloadState_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='handleDownloadState' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("handleDownloadState", "(I)V", "GetHandleDownloadState_IHandler")]
		public virtual unsafe void HandleDownloadState (int p0)
		{
			if (id_handleDownloadState_I == IntPtr.Zero)
				id_handleDownloadState_I = JNIEnv.GetMethodID (class_ref, "handleDownloadState", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleDownloadState_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleDownloadState", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_;
#pragma warning disable 0169
		static Delegate GetSetAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Handler ()
		{
			if (cb_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ == null)
				cb_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_);
			return cb_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_;
		}

		static void n_SetAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAttachementView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='setAttachementView' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentView']]"
		[Register ("setAttachementView", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;)V", "GetSetAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Handler")]
		public virtual unsafe void SetAttachementView (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView p0)
		{
			if (id_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ == IntPtr.Zero)
				id_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ = JNIEnv.GetMethodID (class_ref, "setAttachementView", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttachementView_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttachementView", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setDownloadThread_Ljava_lang_Thread_;
#pragma warning disable 0169
		static Delegate GetSetDownloadThread_Ljava_lang_Thread_Handler ()
		{
			if (cb_setDownloadThread_Ljava_lang_Thread_ == null)
				cb_setDownloadThread_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDownloadThread_Ljava_lang_Thread_);
			return cb_setDownloadThread_Ljava_lang_Thread_;
		}

		static void n_SetDownloadThread_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDownloadThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setDownloadThread_Ljava_lang_Thread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='setDownloadThread' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("setDownloadThread", "(Ljava/lang/Thread;)V", "GetSetDownloadThread_Ljava_lang_Thread_Handler")]
		public virtual unsafe void SetDownloadThread (global::Java.Lang.Thread p0)
		{
			if (id_setDownloadThread_Ljava_lang_Thread_ == IntPtr.Zero)
				id_setDownloadThread_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "setDownloadThread", "(Ljava/lang/Thread;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDownloadThread_Ljava_lang_Thread_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDownloadThread", "(Ljava/lang/Thread;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImage_Landroid_graphics_Bitmap_ == null)
				cb_setImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_Bitmap_);
			return cb_setImage_Landroid_graphics_Bitmap_;
		}

		static void n_SetImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImage", "(Landroid/graphics/Bitmap;)V", "GetSetImage_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImage (global::Android.Graphics.Bitmap p0)
		{
			if (id_setImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImageDecodeThread_Ljava_lang_Thread_;
#pragma warning disable 0169
		static Delegate GetSetImageDecodeThread_Ljava_lang_Thread_Handler ()
		{
			if (cb_setImageDecodeThread_Ljava_lang_Thread_ == null)
				cb_setImageDecodeThread_Ljava_lang_Thread_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageDecodeThread_Ljava_lang_Thread_);
			return cb_setImageDecodeThread_Ljava_lang_Thread_;
		}

		static void n_SetImageDecodeThread_Ljava_lang_Thread_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetImageDecodeThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setImageDecodeThread_Ljava_lang_Thread_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentTask']/method[@name='setImageDecodeThread' and count(parameter)=1 and parameter[1][@type='java.lang.Thread']]"
		[Register ("setImageDecodeThread", "(Ljava/lang/Thread;)V", "GetSetImageDecodeThread_Ljava_lang_Thread_Handler")]
		public virtual unsafe void SetImageDecodeThread (global::Java.Lang.Thread p0)
		{
			if (id_setImageDecodeThread_Ljava_lang_Thread_ == IntPtr.Zero)
				id_setImageDecodeThread_Ljava_lang_Thread_ = JNIEnv.GetMethodID (class_ref, "setImageDecodeThread", "(Ljava/lang/Thread;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageDecodeThread_Ljava_lang_Thread_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageDecodeThread", "(Ljava/lang/Thread;)V"), __args);
			} finally {
			}
		}

	}
}
