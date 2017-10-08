using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/SntpClient", DoNotGenerateAcw=true)]
	public partial class SntpClient : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/SntpClient", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SntpClient); }
		}

		protected SntpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']/constructor[@name='SntpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SntpClient ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SntpClient)) {
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

		static Delegate cb_getNtpTime;
#pragma warning disable 0169
		static Delegate GetGetNtpTimeHandler ()
		{
			if (cb_getNtpTime == null)
				cb_getNtpTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNtpTime);
			return cb_getNtpTime;
		}

		static long n_GetNtpTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NtpTime;
		}
#pragma warning restore 0169

		static IntPtr id_getNtpTime;
		public virtual unsafe long NtpTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']/method[@name='getNtpTime' and count(parameter)=0]"
			[Register ("getNtpTime", "()J", "GetGetNtpTimeHandler")]
			get {
				if (id_getNtpTime == IntPtr.Zero)
					id_getNtpTime = JNIEnv.GetMethodID (class_ref, "getNtpTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNtpTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNtpTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getNtpTimeReference;
#pragma warning disable 0169
		static Delegate GetGetNtpTimeReferenceHandler ()
		{
			if (cb_getNtpTimeReference == null)
				cb_getNtpTimeReference = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetNtpTimeReference);
			return cb_getNtpTimeReference;
		}

		static long n_GetNtpTimeReference (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NtpTimeReference;
		}
#pragma warning restore 0169

		static IntPtr id_getNtpTimeReference;
		public virtual unsafe long NtpTimeReference {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']/method[@name='getNtpTimeReference' and count(parameter)=0]"
			[Register ("getNtpTimeReference", "()J", "GetGetNtpTimeReferenceHandler")]
			get {
				if (id_getNtpTimeReference == IntPtr.Zero)
					id_getNtpTimeReference = JNIEnv.GetMethodID (class_ref, "getNtpTimeReference", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getNtpTimeReference);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNtpTimeReference", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getRoundTripTime;
#pragma warning disable 0169
		static Delegate GetGetRoundTripTimeHandler ()
		{
			if (cb_getRoundTripTime == null)
				cb_getRoundTripTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetRoundTripTime);
			return cb_getRoundTripTime;
		}

		static long n_GetRoundTripTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RoundTripTime;
		}
#pragma warning restore 0169

		static IntPtr id_getRoundTripTime;
		public virtual unsafe long RoundTripTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']/method[@name='getRoundTripTime' and count(parameter)=0]"
			[Register ("getRoundTripTime", "()J", "GetGetRoundTripTimeHandler")]
			get {
				if (id_getRoundTripTime == IntPtr.Zero)
					id_getRoundTripTime = JNIEnv.GetMethodID (class_ref, "getRoundTripTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getRoundTripTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRoundTripTime", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_requestTime_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetRequestTime_Ljava_lang_String_IHandler ()
		{
			if (cb_requestTime_Ljava_lang_String_I == null)
				cb_requestTime_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_RequestTime_Ljava_lang_String_I);
			return cb_requestTime_Ljava_lang_String_I;
		}

		static bool n_RequestTime_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.SntpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RequestTime (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_requestTime_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='SntpClient']/method[@name='requestTime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("requestTime", "(Ljava/lang/String;I)Z", "GetRequestTime_Ljava_lang_String_IHandler")]
		public virtual unsafe bool RequestTime (string p0, int p1)
		{
			if (id_requestTime_Ljava_lang_String_I == IntPtr.Zero)
				id_requestTime_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "requestTime", "(Ljava/lang/String;I)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_requestTime_Ljava_lang_String_I, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestTime", "(Ljava/lang/String;I)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
