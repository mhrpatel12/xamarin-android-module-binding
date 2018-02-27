using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/contact/ContactUtils", DoNotGenerateAcw=true)]
	public partial class ContactUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/field[@name='UNKNOWN_NUMBER']"
		[Register ("UNKNOWN_NUMBER")]
		public const string UnknownNumber = (string) "UNKNOWN";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/contact/ContactUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactUtils); }
		}

		protected ContactUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/constructor[@name='ContactUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ContactUtils)) {
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

		static IntPtr id_getContact_Landroid_content_Context_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContact' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.Long']]"
		[Register ("getContact", "(Landroid/content/Context;Ljava/lang/Long;)Lcom/applozic/mobicommons/people/contact/Contact;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContact (global::Android.Content.Context p0, global::Java.Lang.Long p1)
		{
			if (id_getContact_Landroid_content_Context_Ljava_lang_Long_ == IntPtr.Zero)
				id_getContact_Landroid_content_Context_Ljava_lang_Long_ = JNIEnv.GetStaticMethodID (class_ref, "getContact", "(Landroid/content/Context;Ljava/lang/Long;)Lcom/applozic/mobicommons/people/contact/Contact;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContact_Landroid_content_Context_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getContact_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContact' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getContact", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContact (global::Android.Content.Context p0, string p1)
		{
			if (id_getContact_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getContact_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getContact", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContact_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContact' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getContact", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContact (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getContact", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContact_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getContactByEmailId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContactByEmailId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getContactByEmailId", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;", "")]
		public static unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContactByEmailId (global::Android.Content.Context p0, string p1)
		{
			if (id_getContactByEmailId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getContactByEmailId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getContactByEmailId", "(Landroid/content/Context;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContactByEmailId_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getContactId_Landroid_content_ContentResolver_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContactId' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.net.Uri']]"
		[Register ("getContactId", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long GetContactId (global::Android.Content.ContentResolver p0, global::Android.Net.Uri p1)
		{
			if (id_getContactId_Landroid_content_ContentResolver_Landroid_net_Uri_ == IntPtr.Zero)
				id_getContactId_Landroid_content_ContentResolver_Landroid_net_Uri_ = JNIEnv.GetStaticMethodID (class_ref, "getContactId", "(Landroid/content/ContentResolver;Landroid/net/Uri;)Ljava/lang/Long;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Long __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContactId_Landroid_content_ContentResolver_Landroid_net_Uri_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getContactId_Ljava_lang_String_Landroid_content_ContentResolver_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContactId' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.ContentResolver']]"
		[Register ("getContactId", "(Ljava/lang/String;Landroid/content/ContentResolver;)Ljava/lang/String;", "")]
		public static unsafe string GetContactId (string p0, global::Android.Content.ContentResolver p1)
		{
			if (id_getContactId_Ljava_lang_String_Landroid_content_ContentResolver_ == IntPtr.Zero)
				id_getContactId_Ljava_lang_String_Landroid_content_ContentResolver_ = JNIEnv.GetStaticMethodID (class_ref, "getContactId", "(Ljava/lang/String;Landroid/content/ContentResolver;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContactId_Ljava_lang_String_Landroid_content_ContentResolver_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getContactNumberByContactId_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContactNumberByContactId' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getContactNumberByContactId", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetContactNumberByContactId (global::Android.Content.Context p0, string p1)
		{
			if (id_getContactNumberByContactId_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_getContactNumberByContactId_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getContactNumberByContactId", "(Landroid/content/Context;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContactNumberByContactId_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getContacts_Landroid_content_ContentResolver_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getContacts' and count(parameter)=2 and parameter[1][@type='android.content.ContentResolver'] and parameter[2][@type='android.content.Context']]"
		[Register ("getContacts", "(Landroid/content/ContentResolver;Landroid/content/Context;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> GetContacts (global::Android.Content.ContentResolver p0, global::Android.Content.Context p1)
		{
			if (id_getContacts_Landroid_content_ContentResolver_Landroid_content_Context_ == IntPtr.Zero)
				id_getContacts_Landroid_content_ContentResolver_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getContacts", "(Landroid/content/ContentResolver;Landroid/content/Context;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getContacts_Landroid_content_ContentResolver_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getPhoneNumbers_Landroid_content_Context_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='getPhoneNumbers' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='long']]"
		[Register ("getPhoneNumbers", "(Landroid/content/Context;J)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetPhoneNumbers (global::Android.Content.Context p0, long p1)
		{
			if (id_getPhoneNumbers_Landroid_content_Context_J == IntPtr.Zero)
				id_getPhoneNumbers_Landroid_content_Context_J = JNIEnv.GetStaticMethodID (class_ref, "getPhoneNumbers", "(Landroid/content/Context;J)Ljava/util/Map;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::System.Collections.Generic.IDictionary<string, string> __ret = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_getPhoneNumbers_Landroid_content_Context_J, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadContactPhoto_Landroid_net_Uri_ILandroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='loadContactPhoto' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='android.app.Activity']]"
		[Register ("loadContactPhoto", "(Landroid/net/Uri;ILandroid/app/Activity;)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap LoadContactPhoto (global::Android.Net.Uri p0, int p1, global::Android.App.Activity p2)
		{
			if (id_loadContactPhoto_Landroid_net_Uri_ILandroid_app_Activity_ == IntPtr.Zero)
				id_loadContactPhoto_Landroid_net_Uri_ILandroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "loadContactPhoto", "(Landroid/net/Uri;ILandroid/app/Activity;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadContactPhoto_Landroid_net_Uri_ILandroid_app_Activity_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_startContactAddActivity_Landroid_support_v4_app_FragmentActivity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='ContactUtils']/method[@name='startContactAddActivity' and count(parameter)=1 and parameter[1][@type='android.support.v4.app.FragmentActivity']]"
		[Register ("startContactAddActivity", "(Landroid/support/v4/app/FragmentActivity;)V", "")]
		public static unsafe void StartContactAddActivity (global::Android.Support.V4.App.FragmentActivity p0)
		{
			if (id_startContactAddActivity_Landroid_support_v4_app_FragmentActivity_ == IntPtr.Zero)
				id_startContactAddActivity_Landroid_support_v4_app_FragmentActivity_ = JNIEnv.GetStaticMethodID (class_ref, "startContactAddActivity", "(Landroid/support/v4/app/FragmentActivity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_startContactAddActivity_Landroid_support_v4_app_FragmentActivity_, __args);
			} finally {
			}
		}

	}
}
