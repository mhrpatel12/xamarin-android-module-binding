using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/interface[@name='RemoveInterfaceListener']"
	[Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/RemoveInterfaceListener", "", "Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IRemoveInterfaceListenerInvoker")]
	public partial interface IRemoveInterfaceListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/interface[@name='RemoveInterfaceListener']/method[@name='removeCallBack' and count(parameter)=0]"
		[Register ("removeCallBack", "()V", "GetRemoveCallBackHandler:Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IRemoveInterfaceListenerInvoker, AndroidBindingProject")]
		void RemoveCallBack ();

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/RemoveInterfaceListener", DoNotGenerateAcw=true)]
	internal class IRemoveInterfaceListenerInvoker : global::Java.Lang.Object, IRemoveInterfaceListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/RemoveInterfaceListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IRemoveInterfaceListenerInvoker); }
		}

		IntPtr class_ref;

		public static IRemoveInterfaceListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRemoveInterfaceListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.uiwidgets.conversation.activity.RemoveInterfaceListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRemoveInterfaceListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_removeCallBack;
#pragma warning disable 0169
		static Delegate GetRemoveCallBackHandler ()
		{
			if (cb_removeCallBack == null)
				cb_removeCallBack = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveCallBack);
			return cb_removeCallBack;
		}

		static void n_RemoveCallBack (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IRemoveInterfaceListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.IRemoveInterfaceListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveCallBack ();
		}
#pragma warning restore 0169

		IntPtr id_removeCallBack;
		public unsafe void RemoveCallBack ()
		{
			if (id_removeCallBack == IntPtr.Zero)
				id_removeCallBack = JNIEnv.GetMethodID (class_ref, "removeCallBack", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeCallBack);
		}

	}

	[global::Android.Runtime.Register ("mono/com/applozic/mobicomkit/uiwidgets/conversation/activity/RemoveInterfaceListenerImplementor")]
	internal sealed partial class IRemoveInterfaceListenerImplementor : global::Java.Lang.Object, IRemoveInterfaceListener {

		object sender;

		public IRemoveInterfaceListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicomkit/uiwidgets/conversation/activity/RemoveInterfaceListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void RemoveCallBack ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IRemoveInterfaceListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
