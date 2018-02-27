using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Commons.Core.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/commons/core/utils/Support", DoNotGenerateAcw=true)]
	public partial class Support : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']/field[@name='SUPPORT_INTENT_KEY']"
		[Register ("SUPPORT_INTENT_KEY")]
		public const string SupportIntentKey = (string) "SUPPORT_INTENT_KEY";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/commons/core/utils/Support", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Support); }
		}

		protected Support (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']/constructor[@name='Support' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Support (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Support)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getSupportContact;
#pragma warning disable 0169
		static Delegate GetGetSupportContactHandler ()
		{
			if (cb_getSupportContact == null)
				cb_getSupportContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportContact);
			return cb_getSupportContact;
		}

		static IntPtr n_GetSupportContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SupportContact);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportContact;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact SupportContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']/method[@name='getSupportContact' and count(parameter)=0]"
			[Register ("getSupportContact", "()Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetSupportContactHandler")]
			get {
				if (id_getSupportContact == IntPtr.Zero)
					id_getSupportContact = JNIEnv.GetMethodID (class_ref, "getSupportContact", "()Lcom/applozic/mobicommons/people/contact/Contact;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportContact), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportContact", "()Lcom/applozic/mobicommons/people/contact/Contact;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportNumber;
#pragma warning disable 0169
		static Delegate GetGetSupportNumberHandler ()
		{
			if (cb_getSupportNumber == null)
				cb_getSupportNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportNumber);
			return cb_getSupportNumber;
		}

		static IntPtr n_GetSupportNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SupportNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getSupportNumber;
		public virtual unsafe string SupportNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']/method[@name='getSupportNumber' and count(parameter)=0]"
			[Register ("getSupportNumber", "()Ljava/lang/String;", "GetGetSupportNumberHandler")]
			get {
				if (id_getSupportNumber == IntPtr.Zero)
					id_getSupportNumber = JNIEnv.GetMethodID (class_ref, "getSupportNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSupportNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsSupportNumber_Ljava_lang_String_Handler ()
		{
			if (cb_isSupportNumber_Ljava_lang_String_ == null)
				cb_isSupportNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupportNumber_Ljava_lang_String_);
			return cb_isSupportNumber_Ljava_lang_String_;
		}

		static bool n_IsSupportNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.Commons.Core.Utils.Support> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupportNumber (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isSupportNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.commons.core.utils']/class[@name='Support']/method[@name='isSupportNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isSupportNumber", "(Ljava/lang/String;)Z", "GetIsSupportNumber_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsSupportNumber (string p0)
		{
			if (id_isSupportNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_isSupportNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isSupportNumber", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportNumber_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupportNumber", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
