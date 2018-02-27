using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Schedule {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/schedule/ScheduledTimeHolder", DoNotGenerateAcw=true)]
	public partial class ScheduledTimeHolder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/schedule/ScheduledTimeHolder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScheduledTimeHolder); }
		}

		protected ScheduledTimeHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/constructor[@name='ScheduledTimeHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScheduledTimeHolder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ScheduledTimeHolder)) {
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

		static Delegate cb_getDate;
#pragma warning disable 0169
		static Delegate GetGetDateHandler ()
		{
			if (cb_getDate == null)
				cb_getDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDate);
			return cb_getDate;
		}

		static IntPtr n_GetDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Date);
		}
#pragma warning restore 0169

		static Delegate cb_setDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_lang_String_Handler ()
		{
			if (cb_setDate_Ljava_lang_String_ == null)
				cb_setDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_lang_String_);
			return cb_setDate_Ljava_lang_String_;
		}

		static void n_SetDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Date = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDate;
		static IntPtr id_setDate_Ljava_lang_String_;
		public virtual unsafe string Date {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='getDate' and count(parameter)=0]"
			[Register ("getDate", "()Ljava/lang/String;", "GetGetDateHandler")]
			get {
				if (id_getDate == IntPtr.Zero)
					id_getDate = JNIEnv.GetMethodID (class_ref, "getDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDate", "(Ljava/lang/String;)V", "GetSetDate_Ljava_lang_String_Handler")]
			set {
				if (id_setDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTime;
#pragma warning disable 0169
		static Delegate GetGetTimeHandler ()
		{
			if (cb_getTime == null)
				cb_getTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTime);
			return cb_getTime;
		}

		static IntPtr n_GetTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Time);
		}
#pragma warning restore 0169

		static Delegate cb_setTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTime_Ljava_lang_String_Handler ()
		{
			if (cb_setTime_Ljava_lang_String_ == null)
				cb_setTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTime_Ljava_lang_String_);
			return cb_setTime_Ljava_lang_String_;
		}

		static void n_SetTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Time = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTime;
		static IntPtr id_setTime_Ljava_lang_String_;
		public virtual unsafe string Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/String;", "GetGetTimeHandler")]
			get {
				if (id_getTime == IntPtr.Zero)
					id_getTime = JNIEnv.GetMethodID (class_ref, "getTime", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTime), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTime", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTime", "(Ljava/lang/String;)V", "GetSetTime_Ljava_lang_String_Handler")]
			set {
				if (id_setTime_Ljava_lang_String_ == IntPtr.Zero)
					id_setTime_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTime", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTime_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTime", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTimestamp;
#pragma warning disable 0169
		static Delegate GetGetTimestampHandler ()
		{
			if (cb_getTimestamp == null)
				cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTimestamp);
			return cb_getTimestamp;
		}

		static IntPtr n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Timestamp);
		}
#pragma warning restore 0169

		static Delegate cb_setTimestamp_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetTimestamp_Ljava_lang_Long_Handler ()
		{
			if (cb_setTimestamp_Ljava_lang_Long_ == null)
				cb_setTimestamp_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTimestamp_Ljava_lang_Long_);
			return cb_setTimestamp_Ljava_lang_Long_;
		}

		static void n_SetTimestamp_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Timestamp = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTimestamp;
		static IntPtr id_setTimestamp_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long Timestamp {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='getTimestamp' and count(parameter)=0]"
			[Register ("getTimestamp", "()Ljava/lang/Long;", "GetGetTimestampHandler")]
			get {
				if (id_getTimestamp == IntPtr.Zero)
					id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setTimestamp", "(Ljava/lang/Long;)V", "GetSetTimestamp_Ljava_lang_Long_Handler")]
			set {
				if (id_setTimestamp_Ljava_lang_Long_ == IntPtr.Zero)
					id_setTimestamp_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestamp_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestamp", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_resetScheduledTimeHolder;
#pragma warning disable 0169
		static Delegate GetResetScheduledTimeHolderHandler ()
		{
			if (cb_resetScheduledTimeHolder == null)
				cb_resetScheduledTimeHolder = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetScheduledTimeHolder);
			return cb_resetScheduledTimeHolder;
		}

		static void n_ResetScheduledTimeHolder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Schedule.ScheduledTimeHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetScheduledTimeHolder ();
		}
#pragma warning restore 0169

		static IntPtr id_resetScheduledTimeHolder;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.schedule']/class[@name='ScheduledTimeHolder']/method[@name='resetScheduledTimeHolder' and count(parameter)=0]"
		[Register ("resetScheduledTimeHolder", "()V", "GetResetScheduledTimeHolderHandler")]
		public virtual unsafe void ResetScheduledTimeHolder ()
		{
			if (id_resetScheduledTimeHolder == IntPtr.Zero)
				id_resetScheduledTimeHolder = JNIEnv.GetMethodID (class_ref, "resetScheduledTimeHolder", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetScheduledTimeHolder);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetScheduledTimeHolder", "()V"));
			} finally {
			}
		}

	}
}
