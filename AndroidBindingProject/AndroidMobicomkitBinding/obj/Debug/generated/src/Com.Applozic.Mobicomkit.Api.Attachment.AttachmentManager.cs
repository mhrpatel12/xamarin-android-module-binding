using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Attachment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/attachment/AttachmentManager", DoNotGenerateAcw=true)]
	public partial class AttachmentManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/field[@name='DOWNLOAD_PROGRESS']"
		[Register ("DOWNLOAD_PROGRESS")]
		public const int DownloadProgress = (int) 5;

		static IntPtr attachmentInProgress_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/field[@name='attachmentInProgress']"
		[Register ("attachmentInProgress")]
		public global::System.Collections.IList AttachmentInProgress {
			get {
				if (attachmentInProgress_jfieldId == IntPtr.Zero)
					attachmentInProgress_jfieldId = JNIEnv.GetFieldID (class_ref, "attachmentInProgress", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, attachmentInProgress_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (attachmentInProgress_jfieldId == IntPtr.Zero)
					attachmentInProgress_jfieldId = JNIEnv.GetFieldID (class_ref, "attachmentInProgress", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, attachmentInProgress_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr attachmentTaskList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/field[@name='attachmentTaskList']"
		[Register ("attachmentTaskList")]
		public global::System.Collections.IList AttachmentTaskList {
			get {
				if (attachmentTaskList_jfieldId == IntPtr.Zero)
					attachmentTaskList_jfieldId = JNIEnv.GetFieldID (class_ref, "attachmentTaskList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, attachmentTaskList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (attachmentTaskList_jfieldId == IntPtr.Zero)
					attachmentTaskList_jfieldId = JNIEnv.GetFieldID (class_ref, "attachmentTaskList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, attachmentTaskList_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/attachment/AttachmentManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AttachmentManager); }
		}

		protected AttachmentManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getInstance;
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/applozic/mobicomkit/api/attachment/AttachmentManager;", "GetGetInstanceHandler")]
			get {
				if (id_getInstance == IntPtr.Zero)
					id_getInstance = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "()Lcom/applozic/mobicomkit/api/attachment/AttachmentManager;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_cancelAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='cancelAll' and count(parameter)=0]"
		[Register ("cancelAll", "()V", "")]
		public static unsafe void CancelAll ()
		{
			if (id_cancelAll == IntPtr.Zero)
				id_cancelAll = JNIEnv.GetStaticMethodID (class_ref, "cancelAll", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_cancelAll);
			} finally {
			}
		}

		static IntPtr id_getBGThreadForAttachment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='getBGThreadForAttachment' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBGThreadForAttachment", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask GetBGThreadForAttachment (string p0)
		{
			if (id_getBGThreadForAttachment_Ljava_lang_String_ == IntPtr.Zero)
				id_getBGThreadForAttachment_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getBGThreadForAttachment", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getBGThreadForAttachment_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBitMapFromCache_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBitMapFromCache_Ljava_lang_String_Handler ()
		{
			if (cb_getBitMapFromCache_Ljava_lang_String_ == null)
				cb_getBitMapFromCache_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitMapFromCache_Ljava_lang_String_);
			return cb_getBitMapFromCache_Ljava_lang_String_;
		}

		static IntPtr n_GetBitMapFromCache_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitMapFromCache (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBitMapFromCache_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='getBitMapFromCache' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBitMapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetBitMapFromCache_Ljava_lang_String_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetBitMapFromCache (string p0)
		{
			if (id_getBitMapFromCache_Ljava_lang_String_ == IntPtr.Zero)
				id_getBitMapFromCache_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getBitMapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitMapFromCache_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitMapFromCache", "(Ljava/lang/String;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I;
#pragma warning disable 0169
		static Delegate GetHandleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_IHandler ()
		{
			if (cb_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I == null)
				cb_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_HandleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I);
			return cb_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I;
		}

		static void n_HandleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HandleState (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='handleState' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentTask'] and parameter[2][@type='int']]"
		[Register ("handleState", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;I)V", "GetHandleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_IHandler")]
		public virtual unsafe void HandleState (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask p0, int p1)
		{
			if (id_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I == IntPtr.Zero)
				id_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I = JNIEnv.GetMethodID (class_ref, "handleState", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleState_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleState", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;I)V"), __args);
			} finally {
			}
		}

		static IntPtr id_isAttachmentInProgress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='isAttachmentInProgress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isAttachmentInProgress", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsAttachmentInProgress (string p0)
		{
			if (id_isAttachmentInProgress_Ljava_lang_String_ == IntPtr.Zero)
				id_isAttachmentInProgress_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isAttachmentInProgress", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isAttachmentInProgress_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_removeDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='removeDownload' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentTask'] and parameter[2][@type='boolean']]"
		[Register ("removeDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;Z)V", "")]
		public static unsafe void RemoveDownload (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask p0, bool p1)
		{
			if (id_removeDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_Z == IntPtr.Zero)
				id_removeDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_Z = JNIEnv.GetStaticMethodID (class_ref, "removeDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_removeDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentTask_Z, __args);
			} finally {
			}
		}

		static IntPtr id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='startDownload' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentView'] and parameter[2][@type='boolean']]"
		[Register ("startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;Z)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask StartDownload (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView p0, bool p1)
		{
			if (id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Z == IntPtr.Zero)
				id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Z = JNIEnv.GetStaticMethodID (class_ref, "startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;Z)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ZLcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='startDownload' and count(parameter)=5 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentView'] and parameter[2][@type='boolean'] and parameter[3][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[4][@type='com.applozic.mobicomkit.listners.MediaDownloadProgressHandler'] and parameter[5][@type='android.content.Context']]"
		[Register ("startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;ZLcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaDownloadProgressHandler;Landroid/content/Context;)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask StartDownload (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentView p0, bool p1, global::Com.Applozic.Mobicomkit.Api.Conversation.Message p2, global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler p3, global::Android.Content.Context p4)
		{
			if (id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ZLcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_Landroid_content_Context_ == IntPtr.Zero)
				id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ZLcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentView;ZLcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/listners/MediaDownloadProgressHandler;Landroid/content/Context;)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentView_ZLcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_listners_MediaDownloadProgressHandler_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentViewProperties_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.attachment']/class[@name='AttachmentManager']/method[@name='startDownload' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.attachment.AttachmentViewProperties'] and parameter[2][@type='boolean']]"
		[Register ("startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentViewProperties;Z)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask StartDownload (global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentViewProperties p0, bool p1)
		{
			if (id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentViewProperties_Z == IntPtr.Zero)
				id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentViewProperties_Z = JNIEnv.GetStaticMethodID (class_ref, "startDownload", "(Lcom/applozic/mobicomkit/api/attachment/AttachmentViewProperties;Z)Lcom/applozic/mobicomkit/api/attachment/AttachmentTask;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Attachment.AttachmentTask> (JNIEnv.CallStaticObjectMethod  (class_ref, id_startDownload_Lcom_applozic_mobicomkit_api_attachment_AttachmentViewProperties_Z, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
