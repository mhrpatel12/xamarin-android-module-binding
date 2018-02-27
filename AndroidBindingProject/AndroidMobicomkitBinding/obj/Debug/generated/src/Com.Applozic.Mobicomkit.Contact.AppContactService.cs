using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/contact/AppContactService", DoNotGenerateAcw=true)]
	public partial class AppContactService : global::Java.Lang.Object, global::Com.Applozic.Mobicomkit.Contact.IBaseContactService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/contact/AppContactService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppContactService); }
		}

		protected AppContactService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/constructor[@name='AppContactService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppContactService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AppContactService)) {
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

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		static IntPtr id_getAll;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/List;", "GetGetAllHandler")]
			get {
				if (id_getAll == IntPtr.Zero)
					id_getAll = JNIEnv.GetMethodID (class_ref, "getAll", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAll), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAll", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.AllContactListExcludingLoggedInUser);
		}
#pragma warning restore 0169

		static IntPtr id_getAllContactListExcludingLoggedInUser;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> AllContactListExcludingLoggedInUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getAllContactListExcludingLoggedInUser' and count(parameter)=0]"
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

		static Delegate cb_getChatConversationCount;
#pragma warning disable 0169
		static Delegate GetGetChatConversationCountHandler ()
		{
			if (cb_getChatConversationCount == null)
				cb_getChatConversationCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetChatConversationCount);
			return cb_getChatConversationCount;
		}

		static int n_GetChatConversationCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChatConversationCount;
		}
#pragma warning restore 0169

		static IntPtr id_getChatConversationCount;
		public virtual unsafe int ChatConversationCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getChatConversationCount' and count(parameter)=0]"
			[Register ("getChatConversationCount", "()I", "GetGetChatConversationCountHandler")]
			get {
				if (id_getChatConversationCount == IntPtr.Zero)
					id_getChatConversationCount = JNIEnv.GetMethodID (class_ref, "getChatConversationCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getChatConversationCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChatConversationCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getGroupConversationCount;
#pragma warning disable 0169
		static Delegate GetGetGroupConversationCountHandler ()
		{
			if (cb_getGroupConversationCount == null)
				cb_getGroupConversationCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGroupConversationCount);
			return cb_getGroupConversationCount;
		}

		static int n_GetGroupConversationCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GroupConversationCount;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupConversationCount;
		public virtual unsafe int GroupConversationCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getGroupConversationCount' and count(parameter)=0]"
			[Register ("getGroupConversationCount", "()I", "GetGetGroupConversationCountHandler")]
			get {
				if (id_getGroupConversationCount == IntPtr.Zero)
					id_getGroupConversationCount = JNIEnv.GetMethodID (class_ref, "getGroupConversationCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getGroupConversationCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupConversationCount", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_add_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_add_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_add_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_Add_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("add", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetAdd_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void Add (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_add_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_add_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_addAll_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_List_Handler ()
		{
			if (cb_addAll_Ljava_util_List_ == null)
				cb_addAll_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAll_Ljava_util_List_);
			return cb_addAll_Ljava_util_List_;
		}

		static void n_AddAll_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addAll_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
		[Register ("addAll", "(Ljava/util/List;)V", "GetAddAll_Ljava_util_List_Handler")]
		public virtual unsafe void AddAll (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> p0)
		{
			if (id_addAll_Ljava_util_List_ == IntPtr.Zero)
				id_addAll_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAll_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addAll", "(Ljava/util/List;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='deleteContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteContactById (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteContactById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='deleteContactById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetDownloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static IntPtr n_DownloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadContactImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='downloadContactImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("downloadContactImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/graphics/Bitmap;", "GetDownloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap DownloadContactImage (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Contact.Contact p1)
		{
			if (id_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "downloadContactImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_downloadContactImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_contact_Contact_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadContactImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/contact/Contact;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_;
#pragma warning disable 0169
		static Delegate GetDownloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Handler ()
		{
			if (cb_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_ == null)
				cb_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DownloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_);
			return cb_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_;
		}

		static IntPtr n_DownloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Channel p1 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Channel> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DownloadGroupImage (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='downloadGroupImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register ("downloadGroupImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;", "GetDownloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap DownloadGroupImage (global::Android.Content.Context p0, global::Com.Applozic.Mobicommons.People.Channel.Channel p1)
		{
			if (id_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
				id_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "downloadGroupImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_downloadGroupImage_Landroid_content_Context_Lcom_applozic_mobicommons_people_channel_Channel_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "downloadGroupImage", "(Landroid/content/Context;Lcom/applozic/mobicommons/people/channel/Channel;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContactById (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContactById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getContactById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContactReceiver_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetContactReceiver_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_getContactReceiver_Ljava_util_List_Ljava_util_List_ == null)
				cb_getContactReceiver_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContactReceiver_Ljava_util_List_Ljava_util_List_);
			return cb_getContactReceiver_Ljava_util_List_Ljava_util_List_;
		}

		static IntPtr n_GetContactReceiver_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContactReceiver (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContactReceiver_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='getContactReceiver' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getContactReceiver", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicommons/people/contact/Contact;", "GetGetContactReceiver_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Contact.Contact GetContactReceiver (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_getContactReceiver_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_getContactReceiver_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getContactReceiver", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicommons/people/contact/Contact;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicommons.People.Contact.Contact __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactReceiver_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactReceiver", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicommons/people/contact/Contact;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_isContactExists_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetIsContactExists_Ljava_lang_String_Handler ()
		{
			if (cb_isContactExists_Ljava_lang_String_ == null)
				cb_isContactExists_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsContactExists_Ljava_lang_String_);
			return cb_isContactExists_Ljava_lang_String_;
		}

		static bool n_IsContactExists_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsContactExists (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isContactExists_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='isContactExists' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("isContactExists", "(Ljava/lang/String;)Z", "GetIsContactExists_Ljava_lang_String_Handler")]
		public virtual unsafe bool IsContactExists (string p0)
		{
			if (id_isContactExists_Ljava_lang_String_ == IntPtr.Zero)
				id_isContactExists_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "isContactExists", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContactExists_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContactExists", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsContactPresent (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isContactPresent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='isContactPresent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
#pragma warning disable 0169
		static Delegate GetUpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler ()
		{
			if (cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == null)
				cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_UpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z);
			return cb_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		}

		static void n_UpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UpdateConnectedStatus (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='updateConnectedStatus' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Date'] and parameter[3][@type='boolean']]"
		[Register ("updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V", "GetUpdateConnectedStatus_Ljava_lang_String_Ljava_util_Date_ZHandler")]
		public virtual unsafe void UpdateConnectedStatus (string p0, global::Java.Util.Date p1, bool p2)
		{
			if (id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z == IntPtr.Zero)
				id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z = JNIEnv.GetMethodID (class_ref, "updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateConnectedStatus_Ljava_lang_String_Ljava_util_Date_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateConnectedStatus", "(Ljava/lang/String;Ljava/util/Date;Z)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateContact (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateContact_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='updateContact' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
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
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateLocalImageUri (p0);
		}
#pragma warning restore 0169

		static IntPtr id_updateLocalImageUri_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='updateLocalImageUri' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
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

		static Delegate cb_updateUserBlocked_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlocked_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlocked_Ljava_lang_String_Z == null)
				cb_updateUserBlocked_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlocked_Ljava_lang_String_Z);
			return cb_updateUserBlocked_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlocked_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlocked (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlocked_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='updateUserBlocked' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlocked", "(Ljava/lang/String;Z)V", "GetUpdateUserBlocked_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlocked (string p0, bool p1)
		{
			if (id_updateUserBlocked_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlocked_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlocked", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlocked_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlocked", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_updateUserBlockedBy_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetUpdateUserBlockedBy_Ljava_lang_String_ZHandler ()
		{
			if (cb_updateUserBlockedBy_Ljava_lang_String_Z == null)
				cb_updateUserBlockedBy_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_UpdateUserBlockedBy_Ljava_lang_String_Z);
			return cb_updateUserBlockedBy_Ljava_lang_String_Z;
		}

		static void n_UpdateUserBlockedBy_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUserBlockedBy (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_updateUserBlockedBy_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='updateUserBlockedBy' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("updateUserBlockedBy", "(Ljava/lang/String;Z)V", "GetUpdateUserBlockedBy_Ljava_lang_String_ZHandler")]
		public virtual unsafe void UpdateUserBlockedBy (string p0, bool p1)
		{
			if (id_updateUserBlockedBy_Ljava_lang_String_Z == IntPtr.Zero)
				id_updateUserBlockedBy_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "updateUserBlockedBy", "(Ljava/lang/String;Z)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUserBlockedBy_Ljava_lang_String_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUserBlockedBy", "(Ljava/lang/String;Z)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_upsert_Lcom_applozic_mobicommons_people_contact_Contact_;
#pragma warning disable 0169
		static Delegate GetUpsert_Lcom_applozic_mobicommons_people_contact_Contact_Handler ()
		{
			if (cb_upsert_Lcom_applozic_mobicommons_people_contact_Contact_ == null)
				cb_upsert_Lcom_applozic_mobicommons_people_contact_Contact_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Upsert_Lcom_applozic_mobicommons_people_contact_Contact_);
			return cb_upsert_Lcom_applozic_mobicommons_people_contact_Contact_;
		}

		static void n_Upsert_Lcom_applozic_mobicommons_people_contact_Contact_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.AppContactService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.AppContactService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Contact.Contact p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Upsert (p0);
		}
#pragma warning restore 0169

		static IntPtr id_upsert_Lcom_applozic_mobicommons_people_contact_Contact_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='AppContactService']/method[@name='upsert' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.contact.Contact']]"
		[Register ("upsert", "(Lcom/applozic/mobicommons/people/contact/Contact;)V", "GetUpsert_Lcom_applozic_mobicommons_people_contact_Contact_Handler")]
		public virtual unsafe void Upsert (global::Com.Applozic.Mobicommons.People.Contact.Contact p0)
		{
			if (id_upsert_Lcom_applozic_mobicommons_people_contact_Contact_ == IntPtr.Zero)
				id_upsert_Lcom_applozic_mobicommons_people_contact_Contact_ = JNIEnv.GetMethodID (class_ref, "upsert", "(Lcom/applozic/mobicommons/people/contact/Contact;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_upsert_Lcom_applozic_mobicommons_people_contact_Contact_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "upsert", "(Lcom/applozic/mobicommons/people/contact/Contact;)V"), __args);
			} finally {
			}
		}

	}
}
