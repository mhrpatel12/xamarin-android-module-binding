using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaDownloadProgressHandler']"
	[Register ("com/applozic/mobicomkit/listners/MediaDownloadProgressHandler", "", "Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandlerInvoker")]
	public partial interface IMediaDownloadProgressHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaDownloadProgressHandler']/method[@name='onCompleted' and count(parameter)=2 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message'] and parameter[2][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onCompleted", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnCompleted (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaDownloadProgressHandler']/method[@name='onDownloadStarted' and count(parameter)=0]"
		[Register ("onDownloadStarted", "()V", "GetOnDownloadStartedHandler:Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnDownloadStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaDownloadProgressHandler']/method[@name='onProgressUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onProgressUpdate", "(ILcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnProgressUpdate (int p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/MediaDownloadProgressHandler", DoNotGenerateAcw=true)]
	internal class IMediaDownloadProgressHandlerInvoker : global::Java.Lang.Object, IMediaDownloadProgressHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/MediaDownloadProgressHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaDownloadProgressHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaDownloadProgressHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaDownloadProgressHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.MediaDownloadProgressHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaDownloadProgressHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnCompleted (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1)
		{
			if (id_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Lcom/applozic/mobicomkit/api/conversation/Message;Lcom/applozic/mobicomkit/exception/ApplozicException;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_Lcom_applozic_mobicomkit_api_conversation_Message_Lcom_applozic_mobicomkit_exception_ApplozicException_, __args);
		}

		static Delegate cb_onDownloadStarted;
#pragma warning disable 0169
		static Delegate GetOnDownloadStartedHandler ()
		{
			if (cb_onDownloadStarted == null)
				cb_onDownloadStarted = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDownloadStarted);
			return cb_onDownloadStarted;
		}

		static void n_OnDownloadStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDownloadStarted ();
		}
#pragma warning restore 0169

		IntPtr id_onDownloadStarted;
		public unsafe void OnDownloadStarted ()
		{
			if (id_onDownloadStarted == IntPtr.Zero)
				id_onDownloadStarted = JNIEnv.GetMethodID (class_ref, "onDownloadStarted", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDownloadStarted);
		}

		static Delegate cb_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_OnProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaDownloadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnProgressUpdate (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnProgressUpdate (int p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1)
		{
			if (id_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onProgressUpdate", "(ILcom/applozic/mobicomkit/exception/ApplozicException;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_, __args);
		}

	}

}
