using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']"
	[Register ("com/applozic/mobicomkit/listners/MediaUploadProgressHandler", "", "Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker")]
	public partial interface IMediaUploadProgressHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']/method[@name='onCancelled' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onCancelled", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnCancelled (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']/method[@name='onCompleted' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onCompleted", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnCompleted (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']/method[@name='onProgressUpdate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onProgressUpdate", "(ILcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnProgressUpdate_ILcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnProgressUpdate (int p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']/method[@name='onSent' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.conversation.Message']]"
		[Register ("onSent", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V", "GetOnSent_Lcom_applozic_mobicomkit_api_conversation_Message_Handler:Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnSent (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MediaUploadProgressHandler']/method[@name='onUploadStarted' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onUploadStarted", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandlerInvoker, AndroidMobicomkitBinding")]
		void OnUploadStarted (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/MediaUploadProgressHandler", DoNotGenerateAcw=true)]
	internal class IMediaUploadProgressHandlerInvoker : global::Java.Lang.Object, IMediaUploadProgressHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/MediaUploadProgressHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMediaUploadProgressHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMediaUploadProgressHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaUploadProgressHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.MediaUploadProgressHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaUploadProgressHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnCancelled (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0)
		{
			if (id_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onCancelled", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelled_Lcom_applozic_mobicomkit_exception_ApplozicException_, __args);
		}

		static Delegate cb_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCompleted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnCompleted (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0)
		{
			if (id_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onCompleted", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCompleted_Lcom_applozic_mobicomkit_exception_ApplozicException_, __args);
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
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
#pragma warning disable 0169
		static Delegate GetOnSent_Lcom_applozic_mobicomkit_api_conversation_Message_Handler ()
		{
			if (cb_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_ == null)
				cb_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSent_Lcom_applozic_mobicomkit_api_conversation_Message_);
			return cb_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
		}

		static void n_OnSent_Lcom_applozic_mobicomkit_api_conversation_Message_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSent (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_;
		public unsafe void OnSent (global::Com.Applozic.Mobicomkit.Api.Conversation.Message p0)
		{
			if (id_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_ == IntPtr.Zero)
				id_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_ = JNIEnv.GetMethodID (class_ref, "onSent", "(Lcom/applozic/mobicomkit/api/conversation/Message;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSent_Lcom_applozic_mobicomkit_api_conversation_Message_, __args);
		}

		static Delegate cb_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMediaUploadProgressHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUploadStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnUploadStarted (global::Com.Applozic.Mobicomkit.Exception.ApplozicException p0)
		{
			if (id_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onUploadStarted", "(Lcom/applozic/mobicomkit/exception/ApplozicException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUploadStarted_Lcom_applozic_mobicomkit_exception_ApplozicException_, __args);
		}

	}

}
