using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MessageDeleteContent", DoNotGenerateAcw=true)]
	public partial class MessageDeleteContent : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MessageDeleteContent", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MessageDeleteContent); }
		}

		protected MessageDeleteContent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']/constructor[@name='MessageDeleteContent' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MessageDeleteContent ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MessageDeleteContent)) {
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

		static Delegate cb_getContactNumber;
#pragma warning disable 0169
		static Delegate GetGetContactNumberHandler ()
		{
			if (cb_getContactNumber == null)
				cb_getContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactNumber);
			return cb_getContactNumber;
		}

		static IntPtr n_GetContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setContactNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContactNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setContactNumber_Ljava_lang_String_ == null)
				cb_setContactNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactNumber_Ljava_lang_String_);
			return cb_setContactNumber_Ljava_lang_String_;
		}

		static void n_SetContactNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']/method[@name='getContactNumber' and count(parameter)=0]"
			[Register ("getContactNumber", "()Ljava/lang/String;", "GetGetContactNumberHandler")]
			get {
				if (id_getContactNumber == IntPtr.Zero)
					id_getContactNumber = JNIEnv.GetMethodID (class_ref, "getContactNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContactNumber", "(Ljava/lang/String;)V", "GetSetContactNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setContactNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setContactNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContactNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDeleteKeyStrings;
#pragma warning disable 0169
		static Delegate GetGetDeleteKeyStringsHandler ()
		{
			if (cb_getDeleteKeyStrings == null)
				cb_getDeleteKeyStrings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeleteKeyStrings);
			return cb_getDeleteKeyStrings;
		}

		static IntPtr n_GetDeleteKeyStrings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.DeleteKeyStrings);
		}
#pragma warning restore 0169

		static Delegate cb_setDeleteKeyStrings_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDeleteKeyStrings_Ljava_util_List_Handler ()
		{
			if (cb_setDeleteKeyStrings_Ljava_util_List_ == null)
				cb_setDeleteKeyStrings_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeleteKeyStrings_Ljava_util_List_);
			return cb_setDeleteKeyStrings_Ljava_util_List_;
		}

		static void n_SetDeleteKeyStrings_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MessageDeleteContent> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteKeyStrings = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeleteKeyStrings;
		static IntPtr id_setDeleteKeyStrings_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> DeleteKeyStrings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']/method[@name='getDeleteKeyStrings' and count(parameter)=0]"
			[Register ("getDeleteKeyStrings", "()Ljava/util/List;", "GetGetDeleteKeyStringsHandler")]
			get {
				if (id_getDeleteKeyStrings == IntPtr.Zero)
					id_getDeleteKeyStrings = JNIEnv.GetMethodID (class_ref, "getDeleteKeyStrings", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeleteKeyStrings), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeleteKeyStrings", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MessageDeleteContent']/method[@name='setDeleteKeyStrings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setDeleteKeyStrings", "(Ljava/util/List;)V", "GetSetDeleteKeyStrings_Ljava_util_List_Handler")]
			set {
				if (id_setDeleteKeyStrings_Ljava_util_List_ == IntPtr.Zero)
					id_setDeleteKeyStrings_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setDeleteKeyStrings", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeleteKeyStrings_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeleteKeyStrings", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
