using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Uilistener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.uilistener']/interface[@name='ContextMenuClickListener']"
	[Register ("com/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener", "", "Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerInvoker")]
	public partial interface IContextMenuClickListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.uilistener']/interface[@name='ContextMenuClickListener']/method[@name='onItemClick' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.view.MenuItem']]"
		[Register ("onItemClick", "(ILandroid/view/MenuItem;)Z", "GetOnItemClick_ILandroid_view_MenuItem_Handler:Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListenerInvoker, AndroidBindingProject")]
		bool OnItemClick (int p0, global::Android.Views.IMenuItem p1);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener", DoNotGenerateAcw=true)]
	internal class IContextMenuClickListenerInvoker : global::Java.Lang.Object, IContextMenuClickListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IContextMenuClickListenerInvoker); }
		}

		IntPtr class_ref;

		public static IContextMenuClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContextMenuClickListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicomkit.uiwidgets.uilistener.ContextMenuClickListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContextMenuClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onItemClick_ILandroid_view_MenuItem_;
#pragma warning disable 0169
		static Delegate GetOnItemClick_ILandroid_view_MenuItem_Handler ()
		{
			if (cb_onItemClick_ILandroid_view_MenuItem_ == null)
				cb_onItemClick_ILandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnItemClick_ILandroid_view_MenuItem_);
			return cb_onItemClick_ILandroid_view_MenuItem_;
		}

		static bool n_OnItemClick_ILandroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Uilistener.IContextMenuClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.IMenuItem p1 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnItemClick (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onItemClick_ILandroid_view_MenuItem_;
		public unsafe bool OnItemClick (int p0, global::Android.Views.IMenuItem p1)
		{
			if (id_onItemClick_ILandroid_view_MenuItem_ == IntPtr.Zero)
				id_onItemClick_ILandroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(ILandroid/view/MenuItem;)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_ILandroid_view_MenuItem_, __args);
			return __ret;
		}

	}

	public partial class ContextMenuClickEventArgs : global::System.EventArgs {

		public ContextMenuClickEventArgs (bool handled, int p0, global::Android.Views.IMenuItem p1)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}

		int p0;
		public int P0 {
			get { return p0; }
		}

		global::Android.Views.IMenuItem p1;
		public global::Android.Views.IMenuItem P1 {
			get { return p1; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListenerImplementor")]
	internal sealed partial class IContextMenuClickListenerImplementor : global::Java.Lang.Object, IContextMenuClickListener {

		object sender;

		public IContextMenuClickListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applozic/mobicomkit/uiwidgets/uilistener/ContextMenuClickListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<ContextMenuClickEventArgs> Handler;
#pragma warning restore 0649

		public bool OnItemClick (int p0, global::Android.Views.IMenuItem p1)
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new ContextMenuClickEventArgs (true, p0, p1);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IContextMenuClickListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
