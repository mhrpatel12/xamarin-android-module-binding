using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Listners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MessageListHandler']"
	[Register ("com/applozic/mobicomkit/listners/MessageListHandler", "", "Com.Applozic.Mobicomkit.Listners.IMessageListHandlerInvoker")]
	public partial interface IMessageListHandler : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.listners']/interface[@name='MessageListHandler']/method[@name='onResult' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.conversation.Message&gt;'] and parameter[2][@type='com.applozic.mobicomkit.exception.ApplozicException']]"
		[Register ("onResult", "(Ljava/util/List;Lcom/applozic/mobicomkit/exception/ApplozicException;)V", "GetOnResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler:Com.Applozic.Mobicomkit.Listners.IMessageListHandlerInvoker, AndroidMobicomkitBinding")]
		void OnResult (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/listners/MessageListHandler", DoNotGenerateAcw=true)]
	internal class IMessageListHandlerInvoker : global::Java.Lang.Object, IMessageListHandler {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/listners/MessageListHandler");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMessageListHandlerInvoker); }
		}

		IntPtr class_ref;

		public static IMessageListHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMessageListHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.listners.MessageListHandler"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMessageListHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_;
#pragma warning disable 0169
		static Delegate GetOnResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_Handler ()
		{
			if (cb_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_ == null)
				cb_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_);
			return cb_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		}

		static void n_OnResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Listners.IMessageListHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Exception.ApplozicException> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnResult (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_;
		public unsafe void OnResult (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message> p0, global::Com.Applozic.Mobicomkit.Exception.ApplozicException p1)
		{
			if (id_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_ == IntPtr.Zero)
				id_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_ = JNIEnv.GetMethodID (class_ref, "onResult", "(Ljava/util/List;Lcom/applozic/mobicomkit/exception/ApplozicException;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.Conversation.Message>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResult_Ljava_util_List_Lcom_applozic_mobicomkit_exception_ApplozicException_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
