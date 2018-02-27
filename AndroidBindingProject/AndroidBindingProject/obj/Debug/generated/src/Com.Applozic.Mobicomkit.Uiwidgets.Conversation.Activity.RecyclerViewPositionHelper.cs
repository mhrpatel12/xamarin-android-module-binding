using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/RecyclerViewPositionHelper", DoNotGenerateAcw=true)]
	public partial class RecyclerViewPositionHelper : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/RecyclerViewPositionHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RecyclerViewPositionHelper); }
		}

		protected RecyclerViewPositionHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_support_v7_widget_RecyclerView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/constructor[@name='RecyclerViewPositionHelper' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register (".ctor", "(Landroid/support/v7/widget/RecyclerView;)V", "")]
		public unsafe RecyclerViewPositionHelper (global::Android.Support.V7.Widget.RecyclerView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (RecyclerViewPositionHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/support/v7/widget/RecyclerView;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/support/v7/widget/RecyclerView;)V", __args);
					return;
				}

				if (id_ctor_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
					id_ctor_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/widget/RecyclerView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_widget_RecyclerView_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_support_v7_widget_RecyclerView_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_LinearLayoutManager_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/constructor[@name='RecyclerViewPositionHelper' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView'] and parameter[2][@type='android.support.v7.widget.LinearLayoutManager']]"
		[Register (".ctor", "(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/LinearLayoutManager;)V", "")]
		public unsafe RecyclerViewPositionHelper (global::Android.Support.V7.Widget.RecyclerView p0, global::Android.Support.V7.Widget.LinearLayoutManager p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (RecyclerViewPositionHelper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/LinearLayoutManager;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/LinearLayoutManager;)V", __args);
					return;
				}

				if (id_ctor_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_LinearLayoutManager_ == IntPtr.Zero)
					id_ctor_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_LinearLayoutManager_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/support/v7/widget/RecyclerView;Landroid/support/v7/widget/LinearLayoutManager;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_LinearLayoutManager_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_support_v7_widget_RecyclerView_Landroid_support_v7_widget_LinearLayoutManager_, __args);
			} finally {
			}
		}

		static Delegate cb_getItemCount;
#pragma warning disable 0169
		static Delegate GetGetItemCountHandler ()
		{
			if (cb_getItemCount == null)
				cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
			return cb_getItemCount;
		}

		static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemCount;
		}
#pragma warning restore 0169

		static IntPtr id_getItemCount;
		public virtual unsafe int ItemCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='getItemCount' and count(parameter)=0]"
			[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
			get {
				if (id_getItemCount == IntPtr.Zero)
					id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_createHelper_Landroid_support_v7_widget_RecyclerView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='createHelper' and count(parameter)=1 and parameter[1][@type='android.support.v7.widget.RecyclerView']]"
		[Register ("createHelper", "(Landroid/support/v7/widget/RecyclerView;)Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/RecyclerViewPositionHelper;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper CreateHelper (global::Android.Support.V7.Widget.RecyclerView p0)
		{
			if (id_createHelper_Landroid_support_v7_widget_RecyclerView_ == IntPtr.Zero)
				id_createHelper_Landroid_support_v7_widget_RecyclerView_ = JNIEnv.GetStaticMethodID (class_ref, "createHelper", "(Landroid/support/v7/widget/RecyclerView;)Lcom/applozic/mobicomkit/uiwidgets/conversation/activity/RecyclerViewPositionHelper;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (JNIEnv.CallStaticObjectMethod  (class_ref, id_createHelper_Landroid_support_v7_widget_RecyclerView_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_findFirstCompletelyVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetFindFirstCompletelyVisibleItemPositionHandler ()
		{
			if (cb_findFirstCompletelyVisibleItemPosition == null)
				cb_findFirstCompletelyVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FindFirstCompletelyVisibleItemPosition);
			return cb_findFirstCompletelyVisibleItemPosition;
		}

		static int n_FindFirstCompletelyVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindFirstCompletelyVisibleItemPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_findFirstCompletelyVisibleItemPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='findFirstCompletelyVisibleItemPosition' and count(parameter)=0]"
		[Register ("findFirstCompletelyVisibleItemPosition", "()I", "GetFindFirstCompletelyVisibleItemPositionHandler")]
		public virtual unsafe int FindFirstCompletelyVisibleItemPosition ()
		{
			if (id_findFirstCompletelyVisibleItemPosition == IntPtr.Zero)
				id_findFirstCompletelyVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "findFirstCompletelyVisibleItemPosition", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findFirstCompletelyVisibleItemPosition);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findFirstCompletelyVisibleItemPosition", "()I"));
			} finally {
			}
		}

		static Delegate cb_findFirstVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetFindFirstVisibleItemPositionHandler ()
		{
			if (cb_findFirstVisibleItemPosition == null)
				cb_findFirstVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FindFirstVisibleItemPosition);
			return cb_findFirstVisibleItemPosition;
		}

		static int n_FindFirstVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindFirstVisibleItemPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_findFirstVisibleItemPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='findFirstVisibleItemPosition' and count(parameter)=0]"
		[Register ("findFirstVisibleItemPosition", "()I", "GetFindFirstVisibleItemPositionHandler")]
		public virtual unsafe int FindFirstVisibleItemPosition ()
		{
			if (id_findFirstVisibleItemPosition == IntPtr.Zero)
				id_findFirstVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "findFirstVisibleItemPosition", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findFirstVisibleItemPosition);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findFirstVisibleItemPosition", "()I"));
			} finally {
			}
		}

		static Delegate cb_findLastCompletelyVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetFindLastCompletelyVisibleItemPositionHandler ()
		{
			if (cb_findLastCompletelyVisibleItemPosition == null)
				cb_findLastCompletelyVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FindLastCompletelyVisibleItemPosition);
			return cb_findLastCompletelyVisibleItemPosition;
		}

		static int n_FindLastCompletelyVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindLastCompletelyVisibleItemPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_findLastCompletelyVisibleItemPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='findLastCompletelyVisibleItemPosition' and count(parameter)=0]"
		[Register ("findLastCompletelyVisibleItemPosition", "()I", "GetFindLastCompletelyVisibleItemPositionHandler")]
		public virtual unsafe int FindLastCompletelyVisibleItemPosition ()
		{
			if (id_findLastCompletelyVisibleItemPosition == IntPtr.Zero)
				id_findLastCompletelyVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "findLastCompletelyVisibleItemPosition", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findLastCompletelyVisibleItemPosition);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findLastCompletelyVisibleItemPosition", "()I"));
			} finally {
			}
		}

		static Delegate cb_findLastVisibleItemPosition;
#pragma warning disable 0169
		static Delegate GetFindLastVisibleItemPositionHandler ()
		{
			if (cb_findLastVisibleItemPosition == null)
				cb_findLastVisibleItemPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FindLastVisibleItemPosition);
			return cb_findLastVisibleItemPosition;
		}

		static int n_FindLastVisibleItemPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.RecyclerViewPositionHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindLastVisibleItemPosition ();
		}
#pragma warning restore 0169

		static IntPtr id_findLastVisibleItemPosition;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='RecyclerViewPositionHelper']/method[@name='findLastVisibleItemPosition' and count(parameter)=0]"
		[Register ("findLastVisibleItemPosition", "()I", "GetFindLastVisibleItemPositionHandler")]
		public virtual unsafe int FindLastVisibleItemPosition ()
		{
			if (id_findLastVisibleItemPosition == IntPtr.Zero)
				id_findLastVisibleItemPosition = JNIEnv.GetMethodID (class_ref, "findLastVisibleItemPosition", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_findLastVisibleItemPosition);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "findLastVisibleItemPosition", "()I"));
			} finally {
			}
		}

	}
}
