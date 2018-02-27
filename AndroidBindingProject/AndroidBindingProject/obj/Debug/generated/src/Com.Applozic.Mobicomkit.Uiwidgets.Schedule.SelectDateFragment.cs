using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectDateFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/schedule/SelectDateFragment", DoNotGenerateAcw=true)]
	public partial class SelectDateFragment : global::Android.Support.V4.App.DialogFragment, global::Android.App.DatePickerDialog.IOnDateSetListener {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/schedule/SelectDateFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelectDateFragment); }
		}

		protected SelectDateFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectDateFragment']/constructor[@name='SelectDateFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SelectDateFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SelectDateFragment)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_onDateSet_Landroid_widget_DatePicker_III;
#pragma warning disable 0169
		static Delegate GetOnDateSet_Landroid_widget_DatePicker_IIIHandler ()
		{
			if (cb_onDateSet_Landroid_widget_DatePicker_III == null)
				cb_onDateSet_Landroid_widget_DatePicker_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int>) n_OnDateSet_Landroid_widget_DatePicker_III);
			return cb_onDateSet_Landroid_widget_DatePicker_III;
		}

		static void n_OnDateSet_Landroid_widget_DatePicker_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.DatePicker p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.DatePicker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDateSet (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onDateSet_Landroid_widget_DatePicker_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectDateFragment']/method[@name='onDateSet' and count(parameter)=4 and parameter[1][@type='android.widget.DatePicker'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("onDateSet", "(Landroid/widget/DatePicker;III)V", "GetOnDateSet_Landroid_widget_DatePicker_IIIHandler")]
		public virtual unsafe void OnDateSet (global::Android.Widget.DatePicker p0, int p1, int p2, int p3)
		{
			if (id_onDateSet_Landroid_widget_DatePicker_III == IntPtr.Zero)
				id_onDateSet_Landroid_widget_DatePicker_III = JNIEnv.GetMethodID (class_ref, "onDateSet", "(Landroid/widget/DatePicker;III)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDateSet_Landroid_widget_DatePicker_III, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDateSet", "(Landroid/widget/DatePicker;III)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScheduledDateView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetScheduledDateView_Landroid_view_View_Handler ()
		{
			if (cb_setScheduledDateView_Landroid_view_View_ == null)
				cb_setScheduledDateView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheduledDateView_Landroid_view_View_);
			return cb_setScheduledDateView_Landroid_view_View_;
		}

		static void n_SetScheduledDateView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduledDateView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduledDateView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectDateFragment']/method[@name='setScheduledDateView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setScheduledDateView", "(Landroid/view/View;)V", "GetSetScheduledDateView_Landroid_view_View_Handler")]
		public virtual unsafe void SetScheduledDateView (global::Android.Views.View p0)
		{
			if (id_setScheduledDateView_Landroid_view_View_ == IntPtr.Zero)
				id_setScheduledDateView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setScheduledDateView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheduledDateView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheduledDateView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_;
#pragma warning disable 0169
		static Delegate GetSetScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_Handler ()
		{
			if (cb_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_ == null)
				cb_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_);
			return cb_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_;
		}

		static void n_SetScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectDateFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduledTimeHolder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectDateFragment']/method[@name='setScheduledTimeHolder' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.schedule.ScheduledTimeHolder']]"
		[Register ("setScheduledTimeHolder", "(Lcom/applozic/mobicomkit/uiwidgets/schedule/ScheduledTimeHolder;)V", "GetSetScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_Handler")]
		public virtual unsafe void SetScheduledTimeHolder (global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder p0)
		{
			if (id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_ == IntPtr.Zero)
				id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_ = JNIEnv.GetMethodID (class_ref, "setScheduledTimeHolder", "(Lcom/applozic/mobicomkit/uiwidgets/schedule/ScheduledTimeHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheduledTimeHolder", "(Lcom/applozic/mobicomkit/uiwidgets/schedule/ScheduledTimeHolder;)V"), __args);
			} finally {
			}
		}

	}
}
