using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/schedule/SelectTimeFragment", DoNotGenerateAcw=true)]
	public partial class SelectTimeFragment : global::Android.Support.V4.App.DialogFragment, global::Android.Content.IDialogInterfaceOnClickListener {


		static IntPtr mTimeSetListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']/field[@name='mTimeSetListener']"
		[Register ("mTimeSetListener")]
		public global::Android.App.TimePickerDialog.IOnTimeSetListener MTimeSetListener {
			get {
				if (mTimeSetListener_jfieldId == IntPtr.Zero)
					mTimeSetListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimeSetListener", "Landroid/app/TimePickerDialog$OnTimeSetListener;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mTimeSetListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.App.TimePickerDialog.IOnTimeSetListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTimeSetListener_jfieldId == IntPtr.Zero)
					mTimeSetListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mTimeSetListener", "Landroid/app/TimePickerDialog$OnTimeSetListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mTimeSetListener_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/schedule/SelectTimeFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SelectTimeFragment); }
		}

		protected SelectTimeFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']/constructor[@name='SelectTimeFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SelectTimeFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SelectTimeFragment)) {
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

		static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_I == null)
				cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnClick_Landroid_content_DialogInterface_I);
			return cb_onClick_Landroid_content_DialogInterface_I;
		}

		static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterface p0 = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_content_DialogInterface_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
		public virtual unsafe void OnClick (global::Android.Content.IDialogInterface p0, int p1)
		{
			if (id_onClick_Landroid_content_DialogInterface_I == IntPtr.Zero)
				id_onClick_Landroid_content_DialogInterface_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/content/DialogInterface;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onClick_Landroid_content_DialogInterface_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onClick", "(Landroid/content/DialogInterface;I)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduledTimeHolder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduledTimeHolder_Lcom_applozic_mobicomkit_uiwidgets_schedule_ScheduledTimeHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']/method[@name='setScheduledTimeHolder' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.schedule.ScheduledTimeHolder']]"
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

		static Delegate cb_setScheduledTimeView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetScheduledTimeView_Landroid_view_View_Handler ()
		{
			if (cb_setScheduledTimeView_Landroid_view_View_ == null)
				cb_setScheduledTimeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScheduledTimeView_Landroid_view_View_);
			return cb_setScheduledTimeView_Landroid_view_View_;
		}

		static void n_SetScheduledTimeView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.SelectTimeFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScheduledTimeView (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setScheduledTimeView_Landroid_view_View_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='SelectTimeFragment']/method[@name='setScheduledTimeView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("setScheduledTimeView", "(Landroid/view/View;)V", "GetSetScheduledTimeView_Landroid_view_View_Handler")]
		public virtual unsafe void SetScheduledTimeView (global::Android.Views.View p0)
		{
			if (id_setScheduledTimeView_Landroid_view_View_ == IntPtr.Zero)
				id_setScheduledTimeView_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "setScheduledTimeView", "(Landroid/view/View;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScheduledTimeView_Landroid_view_View_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScheduledTimeView", "(Landroid/view/View;)V"), __args);
			} finally {
			}
		}

	}
}
