using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/DateUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateUtils); }
		}

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateUtils)) {
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

		static IntPtr id_getTimeDiffFromUtc;
		public static unsafe long TimeDiffFromUtc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getTimeDiffFromUtc' and count(parameter)=0]"
			[Register ("getTimeDiffFromUtc", "()J", "GetGetTimeDiffFromUtcHandler")]
			get {
				if (id_getTimeDiffFromUtc == IntPtr.Zero)
					id_getTimeDiffFromUtc = JNIEnv.GetStaticMethodID (class_ref, "getTimeDiffFromUtc", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getTimeDiffFromUtc);
				} finally {
				}
			}
		}

		static IntPtr id_daysBetween_Ljava_util_Date_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='daysBetween' and count(parameter)=2 and parameter[1][@type='java.util.Date'] and parameter[2][@type='java.util.Date']]"
		[Register ("daysBetween", "(Ljava/util/Date;Ljava/util/Date;)J", "")]
		public static unsafe long DaysBetween (global::Java.Util.Date p0, global::Java.Util.Date p1)
		{
			if (id_daysBetween_Ljava_util_Date_Ljava_util_Date_ == IntPtr.Zero)
				id_daysBetween_Ljava_util_Date_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "daysBetween", "(Ljava/util/Date;Ljava/util/Date;)J");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				long __ret = JNIEnv.CallStaticLongMethod  (class_ref, id_daysBetween_Ljava_util_Date_Ljava_util_Date_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDate_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getDate' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getDate", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static unsafe string GetDate (global::Java.Lang.Long p0)
		{
			if (id_getDate_Ljava_lang_Long_ == IntPtr.Zero)
				id_getDate_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getDate", "(Ljava/lang/Long;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDate_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateAndTimeForLastSeen_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getDateAndTimeForLastSeen' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getDateAndTimeForLastSeen", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static unsafe string GetDateAndTimeForLastSeen (global::Java.Lang.Long p0)
		{
			if (id_getDateAndTimeForLastSeen_Ljava_lang_Long_ == IntPtr.Zero)
				id_getDateAndTimeForLastSeen_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getDateAndTimeForLastSeen", "(Ljava/lang/Long;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateAndTimeForLastSeen_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDateAndTimeInDefaultFormat_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getDateAndTimeInDefaultFormat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDateAndTimeInDefaultFormat", "(J)Ljava/lang/String;", "")]
		public static unsafe string GetDateAndTimeInDefaultFormat (long p0)
		{
			if (id_getDateAndTimeInDefaultFormat_J == IntPtr.Zero)
				id_getDateAndTimeInDefaultFormat_J = JNIEnv.GetStaticMethodID (class_ref, "getDateAndTimeInDefaultFormat", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateAndTimeInDefaultFormat_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDatePart_Ljava_util_Date_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getDatePart' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("getDatePart", "(Ljava/util/Date;)Ljava/util/Calendar;", "")]
		public static unsafe global::Java.Util.Calendar GetDatePart (global::Java.Util.Date p0)
		{
			if (id_getDatePart_Ljava_util_Date_ == IntPtr.Zero)
				id_getDatePart_Ljava_util_Date_ = JNIEnv.GetStaticMethodID (class_ref, "getDatePart", "(Ljava/util/Date;)Ljava/util/Calendar;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Util.Calendar __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDatePart_Ljava_util_Date_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFormattedDate_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getFormattedDate' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getFormattedDate", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedDate (global::Java.Lang.Long p0)
		{
			if (id_getFormattedDate_Ljava_lang_Long_ == IntPtr.Zero)
				id_getFormattedDate_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedDate", "(Ljava/lang/Long;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedDate_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getFormattedDateAndTime_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='getFormattedDateAndTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getFormattedDateAndTime", "(Ljava/lang/Long;)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedDateAndTime (global::Java.Lang.Long p0)
		{
			if (id_getFormattedDateAndTime_Ljava_lang_Long_ == IntPtr.Zero)
				id_getFormattedDateAndTime_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedDateAndTime", "(Ljava/lang/Long;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedDateAndTime_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isSameDay_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='isSameDay' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("isSameDay", "(Ljava/lang/Long;)Z", "")]
		public static unsafe bool IsSameDay (global::Java.Lang.Long p0)
		{
			if (id_isSameDay_Ljava_lang_Long_ == IntPtr.Zero)
				id_isSameDay_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "isSameDay", "(Ljava/lang/Long;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSameDay_Ljava_lang_Long_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isYesterday_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='DateUtils']/method[@name='isYesterday' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("isYesterday", "(Ljava/lang/Long;)Z", "")]
		public static unsafe bool IsYesterday (global::Java.Lang.Long p0)
		{
			if (id_isYesterday_Ljava_lang_Long_ == IntPtr.Zero)
				id_isYesterday_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "isYesterday", "(Ljava/lang/Long;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isYesterday_Ljava_lang_Long_, __args);
				return __ret;
			} finally {
			}
		}

	}
}
