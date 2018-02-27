using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.Personalization {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.personalization']/class[@name='PersonalizedMessage']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/personalization/PersonalizedMessage", DoNotGenerateAcw=true)]
	public partial class PersonalizedMessage : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/personalization/PersonalizedMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PersonalizedMessage); }
		}

		protected PersonalizedMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.personalization']/class[@name='PersonalizedMessage']/constructor[@name='PersonalizedMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PersonalizedMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PersonalizedMessage)) {
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

		static IntPtr id_isFromTemplate_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.personalization']/class[@name='PersonalizedMessage']/method[@name='isFromTemplate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("isFromTemplate", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool IsFromTemplate (string p0, string p1)
		{
			if (id_isFromTemplate_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_isFromTemplate_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isFromTemplate", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isFromTemplate_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_isPersonalized_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.personalization']/class[@name='PersonalizedMessage']/method[@name='isPersonalized' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isPersonalized", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool IsPersonalized (string p0)
		{
			if (id_isPersonalized_Ljava_lang_String_ == IntPtr.Zero)
				id_isPersonalized_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "isPersonalized", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPersonalized_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_prepareMessageFromTemplate_Ljava_lang_String_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.personalization']/class[@name='PersonalizedMessage']/method[@name='prepareMessageFromTemplate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("prepareMessageFromTemplate", "(Ljava/lang/String;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;", "")]
		public static unsafe string PrepareMessageFromTemplate (string p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1)
		{
			if (id_prepareMessageFromTemplate_Ljava_lang_String_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_prepareMessageFromTemplate_Ljava_lang_String_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetStaticMethodID (class_ref, "prepareMessageFromTemplate", "(Ljava/lang/String;Lcom/applozic/mobicommons/people/contact/Contact;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_prepareMessageFromTemplate_Ljava_lang_String_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
