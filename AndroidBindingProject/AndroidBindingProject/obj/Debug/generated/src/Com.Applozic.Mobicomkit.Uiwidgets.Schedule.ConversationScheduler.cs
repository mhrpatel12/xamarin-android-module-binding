using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ConversationScheduler']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/schedule/ConversationScheduler", DoNotGenerateAcw=true)]
	public partial class ConversationScheduler : global::Android.Support.V4.App.DialogFragment {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/schedule/ConversationScheduler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationScheduler); }
		}

		protected ConversationScheduler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ConversationScheduler']/constructor[@name='ConversationScheduler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationScheduler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationScheduler)) {
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

		static Delegate cb_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_;
#pragma warning disable 0169
		static Delegate GetResetColor_Landroid_widget_TextView_Landroid_widget_TextView_Handler ()
		{
			if (cb_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_ == null)
				cb_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ResetColor_Landroid_widget_TextView_Landroid_widget_TextView_);
			return cb_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_;
		}

		static void n_ResetColor_Landroid_widget_TextView_Landroid_widget_TextView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.TextView p1 = global::Java.Lang.Object.GetObject<global::Android.Widget.TextView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ResetColor (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ConversationScheduler']/method[@name='resetColor' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='android.widget.TextView']]"
		[Register ("resetColor", "(Landroid/widget/TextView;Landroid/widget/TextView;)V", "GetResetColor_Landroid_widget_TextView_Landroid_widget_TextView_Handler")]
		public virtual unsafe void ResetColor (global::Android.Widget.TextView p0, global::Android.Widget.TextView p1)
		{
			if (id_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_ == IntPtr.Zero)
				id_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_ = JNIEnv.GetMethodID (class_ref, "resetColor", "(Landroid/widget/TextView;Landroid/widget/TextView;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetColor_Landroid_widget_TextView_Landroid_widget_TextView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetColor", "(Landroid/widget/TextView;Landroid/widget/TextView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScheduleOption_Landroid_widget_Button_;
#pragma warning disable 0169
		static Delegate GetSetScheduleOption_Landroid_widget_Button_Handler ()
		{
			if (cb_setScheduleOption_Landroid_widget_Button_ == null)
				cb_setScheduleOption_Landroid_widget_Button_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheduleOption_Landroid_widget_Button_);
			return cb_setScheduleOption_Landroid_widget_Button_;
		}

		static void n_SetScheduleOption_Landroid_widget_Button_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.Button p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.Button> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduleOption (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduleOption_Landroid_widget_Button_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ConversationScheduler']/method[@name='setScheduleOption' and count(parameter)=1 and parameter[1][@type='android.widget.Button']]"
		[Register ("setScheduleOption", "(Landroid/widget/Button;)V", "GetSetScheduleOption_Landroid_widget_Button_Handler")]
		public virtual unsafe void SetScheduleOption (global::Android.Widget.Button p0)
		{
			if (id_setScheduleOption_Landroid_widget_Button_ == IntPtr.Zero)
				id_setScheduleOption_Landroid_widget_Button_ = JNIEnv.GetMethodID (class_ref, "setScheduleOption", "(Landroid/widget/Button;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheduleOption_Landroid_widget_Button_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheduleOption", "(Landroid/widget/Button;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ConversationScheduler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduledTimeHolder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ConversationScheduler']/method[@name='setScheduledTimeHolder' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.schedule.ScheduledTimeHolder']]"
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
