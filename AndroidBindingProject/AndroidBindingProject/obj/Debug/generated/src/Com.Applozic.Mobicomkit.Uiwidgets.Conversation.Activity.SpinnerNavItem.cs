using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/SpinnerNavItem", DoNotGenerateAcw=true)]
	public partial class SpinnerNavItem : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/SpinnerNavItem", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SpinnerNavItem); }
		}

		protected SpinnerNavItem (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/constructor[@name='SpinnerNavItem' and count(parameter)=4 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;I)V", "")]
		public unsafe SpinnerNavItem (global::Com.Applozic.Mobicommons.People.Contact.Contact p0, string p1, string p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (SpinnerNavItem)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicommons/people/contact/Contact;Ljava/lang/String;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicommons_people_contact_Contact_Ljava_lang_String_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getContact;
#pragma warning disable 0169
		static Delegate GetGetContactHandler ()
		{
			if (cb_getContact == null)
				cb_getContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContact);
			return cb_getContact;
		}

		static IntPtr n_GetContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Contact);
		}
#pragma warning restore 0169

		static Delegate cb_setContact_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetSetContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_setContact_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_setContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContact_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_setContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_SetContact_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contact = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContact;
		static IntPtr id_setContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact Contact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='getContact' and count(parameter)=0]"
			[Register ("getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContactHandler")]
			get {
				if (id_getContact == IntPtr.Zero)
					id_getContact = JNIEnv.GetMethodID (class_ref, "getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContact), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "()Lcom/applozic/mobicommons/people/contact/Contact;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='setContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
			[Register ("setContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetSetContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
			set {
				if (id_setContact_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
					id_setContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "setContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContact_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
				} finally {
				}
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='getContactNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIcon);
			return cb_getIcon;
		}

		static int n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Icon;
		}
#pragma warning restore 0169

		static IntPtr id_getIcon;
		public virtual unsafe int Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()I", "GetGetIconHandler")]
			get {
				if (id_getIcon == IntPtr.Zero)
					id_getIcon = JNIEnv.GetMethodID (class_ref, "getIcon", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIcon);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIcon", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.SpinnerNavItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='SpinnerNavItem']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
