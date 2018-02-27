using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Contact.Database {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/contact/database/ContactDatabase", DoNotGenerateAcw=true)]
	public partial class ContactDatabase : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/field[@name='CONTACT']"
		[Register ("CONTACT")]
		public const string Contact = (string) "contact";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/contact/database/ContactDatabase", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactDatabase); }
		}

		protected ContactDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/constructor[@name='ContactDatabase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ContactDatabase (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ContactDatabase)) {
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

		static Delegate cb_getAllContact;
#pragma warning disable 0169
		static Delegate GetGetAllContactHandler ()
		{
			if (cb_getAllContact == null)
				cb_getAllContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllContact);
			return cb_getAllContact;
		}

		static IntPtr n_GetAllContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.AllContact);
		}
#pragma warning restore 0169

		static IntPtr id_getAllContact;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> AllContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getAllContact' and count(parameter)=0]"
			[Register ("getAllContact", "()Ljava/util/List;", "GetGetAllContactHandler")]
			get {
				if (id_getAllContact == IntPtr.Zero)
					id_getAllContact = JNIEnv.GetMethodID (class_ref, "getAllContact", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllContact), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllContact", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAllContactListExcludingLoggedInUser;
#pragma warning disable 0169
		static Delegate GetGetAllContactListExcludingLoggedInUserHandler ()
		{
			if (cb_getAllContactListExcludingLoggedInUser == null)
				cb_getAllContactListExcludingLoggedInUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllContactListExcludingLoggedInUser);
			return cb_getAllContactListExcludingLoggedInUser;
		}

		static IntPtr n_GetAllContactListExcludingLoggedInUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.AllContactListExcludingLoggedInUser);
		}
#pragma warning restore 0169

		static IntPtr id_getAllContactListExcludingLoggedInUser;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> AllContactListExcludingLoggedInUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getAllContactListExcludingLoggedInUser' and count(parameter)=0]"
			[Register ("getAllContactListExcludingLoggedInUser", "()Ljava/util/List;", "GetGetAllContactListExcludingLoggedInUserHandler")]
			get {
				if (id_getAllContactListExcludingLoggedInUser == IntPtr.Zero)
					id_getAllContactListExcludingLoggedInUser = JNIEnv.GetMethodID (class_ref, "getAllContactListExcludingLoggedInUser", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAllContactListExcludingLoggedInUser), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAllContactListExcludingLoggedInUser", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChatUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetChatUnreadCountHandler ()
		{
			if (cb_getChatUnreadCount == null)
				cb_getChatUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChatUnreadCount);
			return cb_getChatUnreadCount;
		}

		static int n_GetChatUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChatUnreadCount;
		}
#pragma warning restore 0169

		static IntPtr id_getChatUnreadCount;
		public virtual unsafe int ChatUnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getChatUnreadCount' and count(parameter)=0]"
			[Register ("getChatUnreadCount", "()I", "GetGetChatUnreadCountHandler")]
			get {
				if (id_getChatUnreadCount == IntPtr.Zero)
					id_getChatUnreadCount = JNIEnv.GetMethodID (class_ref, "getChatUnreadCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChatUnreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChatUnreadCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getGroupUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetGroupUnreadCountHandler ()
		{
			if (cb_getGroupUnreadCount == null)
				cb_getGroupUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGroupUnreadCount);
			return cb_getGroupUnreadCount;
		}

		static int n_GetGroupUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GroupUnreadCount;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupUnreadCount;
		public virtual unsafe int GroupUnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getGroupUnreadCount' and count(parameter)=0]"
			[Register ("getGroupUnreadCount", "()I", "GetGetGroupUnreadCountHandler")]
			get {
				if (id_getGroupUnreadCount == IntPtr.Zero)
					id_getGroupUnreadCount = JNIEnv.GetMethodID (class_ref, "getGroupUnreadCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGroupUnreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupUnreadCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_addAllContact_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddAllContact_Ljava_util_List_Handler ()
		{
			if (cb_addAllContact_Ljava_util_List_ == null)
				cb_addAllContact_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAllContact_Ljava_util_List_);
			return cb_addAllContact_Ljava_util_List_;
		}

		static void n_AddAllContact_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAllContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAllContact_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='addAllContact' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
		[Register ("addAllContact", "(Ljava/util/List;)V", "GetAddAllContact_Ljava_util_List_Handler")]
		public virtual unsafe void AddAllContact (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> p0)
		{
			if (id_addAllContact_Ljava_util_List_ == IntPtr.Zero)
				id_addAllContact_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addAllContact", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAllContact_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAllContact", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addContact_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetAddContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_addContact_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_addContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddContact_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_addContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_AddContact_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='addContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("addContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetAddContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void AddContact (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_addContact_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_addContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "addContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addContact_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteAllContact_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetDeleteAllContact_Ljava_util_List_Handler ()
		{
			if (cb_deleteAllContact_Ljava_util_List_ == null)
				cb_deleteAllContact_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteAllContact_Ljava_util_List_);
			return cb_deleteAllContact_Ljava_util_List_;
		}

		static void n_DeleteAllContact_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAllContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAllContact_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='deleteAllContact' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
		[Register ("deleteAllContact", "(Ljava/util/List;)V", "GetDeleteAllContact_Ljava_util_List_Handler")]
		public virtual unsafe void DeleteAllContact (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> p0)
		{
			if (id_deleteAllContact_Ljava_util_List_ == IntPtr.Zero)
				id_deleteAllContact_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "deleteAllContact", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAllContact_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAllContact", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetDeleteContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteContact_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_DeleteContact_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='deleteContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("deleteContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetDeleteContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void DeleteContact (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "deleteContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteContactById_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteContactById_Ljava_lang_String_Handler ()
		{
			if (cb_deleteContactById_Ljava_lang_String_ == null)
				cb_deleteContactById_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteContactById_Ljava_lang_String_);
			return cb_deleteContactById_Ljava_lang_String_;
		}

		static void n_DeleteContactById_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteContactById (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteContactById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='deleteContactById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteContactById", "(Ljava/lang/String;)V", "GetDeleteContactById_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteContactById (string p0)
		{
			if (id_deleteContactById_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteContactById_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteContactById", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteContactById_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteContactById", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getContact_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetContact_Landroid_database_Cursor_Handler ()
		{
			if (cb_getContact_Landroid_database_Cursor_ == null)
				cb_getContact_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContact_Landroid_database_Cursor_);
			return cb_getContact_Landroid_database_Cursor_;
		}

		static IntPtr n_GetContact_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContact (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContact_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getContact' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getContact", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContact_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContact (global::Android.Database.ICursor p0)
		{
			if (id_getContact_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getContact_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getContact", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/contact/Contact;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContact_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "(Landroid/database/Cursor;)Lcom/applozic/mobicommons/people/contact/Contact;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getContact_Landroid_database_Cursor_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetContact_Landroid_database_Cursor_Ljava_lang_String_Handler ()
		{
			if (cb_getContact_Landroid_database_Cursor_Ljava_lang_String_ == null)
				cb_getContact_Landroid_database_Cursor_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContact_Landroid_database_Cursor_Ljava_lang_String_);
			return cb_getContact_Landroid_database_Cursor_Ljava_lang_String_;
		}

		static IntPtr n_GetContact_Landroid_database_Cursor_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContact (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContact_Landroid_database_Cursor_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getContact' and count(parameter)=2 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='java.lang.String']]"
		[Register ("getContact", "(Landroid/database/Cursor;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContact_Landroid_database_Cursor_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContact (global::Android.Database.ICursor p0, string p1)
		{
			if (id_getContact_Landroid_database_Cursor_Ljava_lang_String_ == IntPtr.Zero)
				id_getContact_Landroid_database_Cursor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getContact", "(Landroid/database/Cursor;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContact_Landroid_database_Cursor_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContact", "(Landroid/database/Cursor;Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getContactById_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetContactById_Ljava_lang_String_Handler ()
		{
			if (cb_getContactById_Ljava_lang_String_ == null)
				cb_getContactById_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContactById_Ljava_lang_String_);
			return cb_getContactById_Ljava_lang_String_;
		}

		static IntPtr n_GetContactById_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContactById (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContactById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getContactById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContactById", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContactById_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContactById (string p0)
		{
			if (id_getContactById_Ljava_lang_String_ == IntPtr.Zero)
				id_getContactById_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getContactById", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactById_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactById", "(Ljava/lang/String;)Lcom/applozic/mobicommons/people/contact/Contact;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getContactList_Landroid_database_Cursor_;
#pragma warning disable 0169
		static Delegate GetGetContactList_Landroid_database_Cursor_Handler ()
		{
			if (cb_getContactList_Landroid_database_Cursor_ == null)
				cb_getContactList_Landroid_database_Cursor_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContactList_Landroid_database_Cursor_);
			return cb_getContactList_Landroid_database_Cursor_;
		}

		static IntPtr n_GetContactList_Landroid_database_Cursor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.ICursor p0 = (global::Android.Database.ICursor)global::Java.Lang.Object.GetObject<global::Android.Database.ICursor> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.GetContactList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContactList_Landroid_database_Cursor_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getContactList' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register ("getContactList", "(Landroid/database/Cursor;)Ljava/util/List;", "GetGetContactList_Landroid_database_Cursor_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> GetContactList (global::Android.Database.ICursor p0)
		{
			if (id_getContactList_Landroid_database_Cursor_ == IntPtr.Zero)
				id_getContactList_Landroid_database_Cursor_ = JNIEnv.GetMethodID (class_ref, "getContactList", "(Landroid/database/Cursor;)Ljava/util/List;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactList_Landroid_database_Cursor_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactList", "(Landroid/database/Cursor;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_Handler ()
		{
			if (cb_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_ == null)
				cb_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_);
			return cb_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_;
		}

		static IntPtr n_GetSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSearchCursorLoader (p0, p1));
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='getSearchCursorLoader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("getSearchCursorLoader", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/support/v4/content/Loader;", "GetGetSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_Handler")]
		public virtual unsafe global::Android.Support.V4.Content.Loader GetSearchCursorLoader (string p0, string[] p1)
		{
			if (id_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_ == IntPtr.Zero)
				id_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getSearchCursorLoader", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/support/v4/content/Loader;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Android.Support.V4.Content.Loader __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSearchCursorLoader_Ljava_lang_String_arrayLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Support.V4.Content.Loader> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchCursorLoader", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/support/v4/content/Loader;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static Delegate cb_isContactPresent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsContactPresent_Ljava_lang_String_Handler ()
		{
			if (cb_isContactPresent_Ljava_lang_String_ == null)
				cb_isContactPresent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsContactPresent_Ljava_lang_String_);
			return cb_isContactPresent_Ljava_lang_String_;
		}

		static bool n_IsContactPresent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsContactPresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isContactPresent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='isContactPresent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isContactPresent", "(Ljava/lang/String;)Z", "GetIsContactPresent_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsContactPresent (string p0)
		{
			if (id_isContactPresent_Ljava_lang_String_ == IntPtr.Zero)
				id_isContactPresent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isContactPresent", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContactPresent_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContactPresent", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetPrepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PrepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_PrepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PrepareContactValues (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='prepareContactValues' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("prepareContactValues", "(Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/content/ContentValues;", "GetPrepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe global::Android.Content.ContentValues PrepareContactValues (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "prepareContactValues", "(Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/content/ContentValues;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Android.Content.ContentValues __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepareContactValues_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepareContactValues", "(Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/content/ContentValues;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
#pragma warning disable 0169
		static Delegate GetUpdateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler ()
		{
			if (cb_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == null)
				cb_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z);
			return cb_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		}

		static void n_UpdateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConnectedOrDisconnectedStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateConnectedOrDisconnectedStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='boolean']]"
		[Register ("updateConnectedOrDisconnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V", "GetUpdateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler")]
		public virtual unsafe void UpdateConnectedOrDisconnectedStatus (string p0, global::Java.Util.Date p1, bool p2)
		{
			if (id_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == IntPtr.Zero)
				id_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNIEnv.GetMethodID (class_ref, "updateConnectedOrDisconnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConnectedOrDisconnectedStatus_Ljava_lang_String_Ljava_util_Date_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConnectedOrDisconnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetUpdateContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateContact_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_UpdateContact_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("updateContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetUpdateContact_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void UpdateContact (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "updateContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContact", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateContactLocalImageURIToNull_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUpdateContactLocalImageURIToNull_Ljava_lang_String_Handler ()
		{
			if (cb_updateContactLocalImageURIToNull_Ljava_lang_String_ == null)
				cb_updateContactLocalImageURIToNull_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateContactLocalImageURIToNull_Ljava_lang_String_);
			return cb_updateContactLocalImageURIToNull_Ljava_lang_String_;
		}

		static void n_UpdateContactLocalImageURIToNull_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContactLocalImageURIToNull (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContactLocalImageURIToNull_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateContactLocalImageURIToNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("updateContactLocalImageURIToNull", "(Ljava/lang/String;)V", "GetUpdateContactLocalImageURIToNull_Ljava_lang_String_Handler")]
		public virtual unsafe void UpdateContactLocalImageURIToNull (string p0)
		{
			if (id_updateContactLocalImageURIToNull_Ljava_lang_String_ == IntPtr.Zero)
				id_updateContactLocalImageURIToNull_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "updateContactLocalImageURIToNull", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateContactLocalImageURIToNull_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateContactLocalImageURIToNull", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLastSeenTimeAt_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetUpdateLastSeenTimeAt_Ljava_lang_String_JHandler ()
		{
			if (cb_updateLastSeenTimeAt_Ljava_lang_String_J == null)
				cb_updateLastSeenTimeAt_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long>) n_UpdateLastSeenTimeAt_Ljava_lang_String_J);
			return cb_updateLastSeenTimeAt_Ljava_lang_String_J;
		}

		static void n_UpdateLastSeenTimeAt_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLastSeenTimeAt (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateLastSeenTimeAt_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateLastSeenTimeAt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("updateLastSeenTimeAt", "(Ljava/lang/String;J)V", "GetUpdateLastSeenTimeAt_Ljava_lang_String_JHandler")]
		public virtual unsafe void UpdateLastSeenTimeAt (string p0, long p1)
		{
			if (id_updateLastSeenTimeAt_Ljava_lang_String_J == IntPtr.Zero)
				id_updateLastSeenTimeAt_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "updateLastSeenTimeAt", "(Ljava/lang/String;J)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLastSeenTimeAt_Ljava_lang_String_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLastSeenTimeAt", "(Ljava/lang/String;J)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetUpdateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_UpdateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLocalImageUri (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateLocalImageUri' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("updateLocalImageUri", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetUpdateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void UpdateLocalImageUri (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "updateLocalImageUri", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateLocalImageUri", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetUpdateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_);
			return cb_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_;
		}

		static void n_UpdateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNotificationAfterTime (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateNotificationAfterTime' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("updateNotificationAfterTime", "(Ljava/lang/String;Ljava/lang/Long;)V", "GetUpdateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe void UpdateNotificationAfterTime (string p0, global::Java.Lang.Long p1)
		{
			if (id_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_ == IntPtr.Zero)
				id_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "updateNotificationAfterTime", "(Ljava/lang/String;Ljava/lang/Long;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateNotificationAfterTime_Ljava_lang_String_Ljava_lang_Long_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateNotificationAfterTime", "(Ljava/lang/String;Ljava/lang/Long;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateUserBlockByStatus_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlockByStatus_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlockByStatus_Ljava_lang_String_Z == null)
				cb_updateUserBlockByStatus_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlockByStatus_Ljava_lang_String_Z);
			return cb_updateUserBlockByStatus_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlockByStatus_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlockByStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlockByStatus_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateUserBlockByStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlockByStatus", "(Ljava/lang/String;Z)V", "GetUpdateUserBlockByStatus_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlockByStatus (string p0, bool p1)
		{
			if (id_updateUserBlockByStatus_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlockByStatus_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlockByStatus", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlockByStatus_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlockByStatus", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateUserBlockStatus_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlockStatus_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlockStatus_Ljava_lang_String_Z == null)
				cb_updateUserBlockStatus_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlockStatus_Ljava_lang_String_Z);
			return cb_updateUserBlockStatus_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlockStatus_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.Database.ContactDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlockStatus (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlockStatus_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact.database']/class[@name='ContactDatabase']/method[@name='updateUserBlockStatus' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlockStatus", "(Ljava/lang/String;Z)V", "GetUpdateUserBlockStatus_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlockStatus (string p0, bool p1)
		{
			if (id_updateUserBlockStatus_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlockStatus_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlockStatus", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlockStatus_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlockStatus", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
