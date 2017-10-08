using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.People {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/people/PeopleClientService", DoNotGenerateAcw=true)]
	public partial class PeopleClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/people/PeopleClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PeopleClientService); }
		}

		protected PeopleClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/constructor[@name='PeopleClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PeopleClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (PeopleClientService)) {
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

		static Delegate cb_getContactsInCurrentPlatform;
#pragma warning disable 0169
		static Delegate GetGetContactsInCurrentPlatformHandler ()
		{
			if (cb_getContactsInCurrentPlatform == null)
				cb_getContactsInCurrentPlatform = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactsInCurrentPlatform);
			return cb_getContactsInCurrentPlatform;
		}

		static IntPtr n_GetContactsInCurrentPlatform (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactsInCurrentPlatform);
		}
#pragma warning restore 0169

		static IntPtr id_getContactsInCurrentPlatform;
		public virtual unsafe string ContactsInCurrentPlatform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/method[@name='getContactsInCurrentPlatform' and count(parameter)=0]"
			[Register ("getContactsInCurrentPlatform", "()Ljava/lang/String;", "GetGetContactsInCurrentPlatformHandler")]
			get {
				if (id_getContactsInCurrentPlatform == IntPtr.Zero)
					id_getContactsInCurrentPlatform = JNIEnv.GetMethodID (class_ref, "getContactsInCurrentPlatform", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactsInCurrentPlatform), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactsInCurrentPlatform", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGoogleContactUrl;
#pragma warning disable 0169
		static Delegate GetGetGoogleContactUrlHandler ()
		{
			if (cb_getGoogleContactUrl == null)
				cb_getGoogleContactUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGoogleContactUrl);
			return cb_getGoogleContactUrl;
		}

		static IntPtr n_GetGoogleContactUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GoogleContactUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getGoogleContactUrl;
		public virtual unsafe string GoogleContactUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/method[@name='getGoogleContactUrl' and count(parameter)=0]"
			[Register ("getGoogleContactUrl", "()Ljava/lang/String;", "GetGetGoogleContactUrlHandler")]
			get {
				if (id_getGoogleContactUrl == IntPtr.Zero)
					id_getGoogleContactUrl = JNIEnv.GetMethodID (class_ref, "getGoogleContactUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGoogleContactUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGoogleContactUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPlatformContactUrl;
#pragma warning disable 0169
		static Delegate GetGetPlatformContactUrlHandler ()
		{
			if (cb_getPlatformContactUrl == null)
				cb_getPlatformContactUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPlatformContactUrl);
			return cb_getPlatformContactUrl;
		}

		static IntPtr n_GetPlatformContactUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PlatformContactUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatformContactUrl;
		public virtual unsafe string PlatformContactUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/method[@name='getPlatformContactUrl' and count(parameter)=0]"
			[Register ("getPlatformContactUrl", "()Ljava/lang/String;", "GetGetPlatformContactUrlHandler")]
			get {
				if (id_getPlatformContactUrl == IntPtr.Zero)
					id_getPlatformContactUrl = JNIEnv.GetMethodID (class_ref, "getPlatformContactUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformContactUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatformContactUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z;
#pragma warning disable 0169
		static Delegate GetAddContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_ZHandler ()
		{
			if (cb_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z == null)
				cb_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_AddContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z);
			return cb_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z;
		}

		static void n_AddContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ContactList p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ContactList> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddContacts (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/method[@name='addContacts' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.applozic.mobicomkit.api.people.ContactList'] and parameter[3][@type='boolean']]"
		[Register ("addContacts", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/people/ContactList;Z)V", "GetAddContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_ZHandler")]
		public virtual unsafe void AddContacts (string p0, global::Com.Applozic.Mobicomkit.Api.People.ContactList p1, bool p2)
		{
			if (id_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z == IntPtr.Zero)
				id_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z = JNIEnv.GetMethodID (class_ref, "addContacts", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/people/ContactList;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addContacts_Ljava_lang_String_Lcom_applozic_mobicomkit_api_people_ContactList_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addContacts", "(Ljava/lang/String;Lcom/applozic/mobicomkit/api/people/ContactList;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGoogleContacts_I;
#pragma warning disable 0169
		static Delegate GetGetGoogleContacts_IHandler ()
		{
			if (cb_getGoogleContacts_I == null)
				cb_getGoogleContacts_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetGoogleContacts_I);
			return cb_getGoogleContacts_I;
		}

		static IntPtr n_GetGoogleContacts_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.PeopleClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetGoogleContacts (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getGoogleContacts_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='PeopleClientService']/method[@name='getGoogleContacts' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGoogleContacts", "(I)Ljava/lang/String;", "GetGetGoogleContacts_IHandler")]
		public virtual unsafe string GetGoogleContacts (int p0)
		{
			if (id_getGoogleContacts_I == IntPtr.Zero)
				id_getGoogleContacts_I = JNIEnv.GetMethodID (class_ref, "getGoogleContacts", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGoogleContacts_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGoogleContacts", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
