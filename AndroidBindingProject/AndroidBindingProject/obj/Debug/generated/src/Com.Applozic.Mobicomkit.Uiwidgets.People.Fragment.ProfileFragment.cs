using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment", DoNotGenerateAcw=true)]
	public partial class ProfileFragment : global::Android.Support.V4.App.Fragment {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='LEFT_MARGIN']"
		[Register ("LEFT_MARGIN")]
		public const float LeftMargin = (float) 7.000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='LINE_WIDTH']"
		[Register ("LINE_WIDTH")]
		public const int LineWidth = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='PROFILE_UPDATED']"
		[Register ("PROFILE_UPDATED")]
		public const int ProfileUpdated = (int) 1001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='ProfileFragmentTag']"
		[Register ("ProfileFragmentTag")]
		public const string ProfileFragmentTag = (string) "ProfileFragment";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='REQUEST_CODE_ATTACH_PHOTO']"
		[Register ("REQUEST_CODE_ATTACH_PHOTO")]
		public const int RequestCodeAttachPhoto = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='REQUEST_CODE_TAKE_PHOTO']"
		[Register ("REQUEST_CODE_TAKE_PHOTO")]
		public const int RequestCodeTakePhoto = (int) 102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/field[@name='REQUEST_REMOVE_PHOTO']"
		[Register ("REQUEST_REMOVE_PHOTO")]
		public const int RequestRemovePhoto = (int) 102;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']"
		[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment$ProfilePictureUpload", DoNotGenerateAcw=true)]
		public partial class ProfilePictureUpload : global::Android.OS.AsyncTask {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment$ProfilePictureUpload", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ProfilePictureUpload); }
			}

			protected ProfilePictureUpload (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_ZLandroid_net_Uri_Ljava_io_File_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']/constructor[@name='ProfileFragment.ProfilePictureUpload' and count(parameter)=5 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.people.fragment.ProfileFragment'] and parameter[2][@type='boolean'] and parameter[3][@type='android.net.Uri'] and parameter[4][@type='java.io.File'] and parameter[5][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment;ZLandroid/net/Uri;Ljava/io/File;Landroid/content/Context;)V", "")]
			public unsafe ProfilePictureUpload (global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __self, bool p1, global::Android.Net.Uri p2, global::Java.IO.File p3, global::Android.Content.Context p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (((object) this).GetType () != typeof (ProfilePictureUpload)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ZLandroid/net/Uri;Ljava/io/File;Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";ZLandroid/net/Uri;Ljava/io/File;Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_ZLandroid_net_Uri_Ljava_io_File_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_ZLandroid_net_Uri_Ljava_io_File_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment;ZLandroid/net/Uri;Ljava/io/File;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_ZLandroid_net_Uri_Ljava_io_File_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_ZLandroid_net_Uri_Ljava_io_File_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_Lcom_applozic_mobicommons_people_contact_Contact_Landroid_content_Context_Landroid_widget_TextView_Landroid_widget_TextView_Landroid_widget_TextView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']/constructor[@name='ProfileFragment.ProfilePictureUpload' and count(parameter)=6 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.people.fragment.ProfileFragment'] and parameter[2][@type='com.applozic.mobicommons.people.contact.Contact'] and parameter[3][@type='android.content.Context'] and parameter[4][@type='android.widget.TextView'] and parameter[5][@type='android.widget.TextView'] and parameter[6][@type='android.widget.TextView']]"
			[Register (".ctor", "(Lcom/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment;Lcom/applozic/mobicommons/people/contact/Contact;Landroid/content/Context;Landroid/widget/TextView;Landroid/widget/TextView;Landroid/widget/TextView;)V", "")]
			public unsafe ProfilePictureUpload (global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __self, global::Com.Applozic.Mobicommons.People.Contact.Contact p1, global::Android.Content.Context p2, global::Android.Widget.TextView p3, global::Android.Widget.TextView p4, global::Android.Widget.TextView p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [6];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					if (((object) this).GetType () != typeof (ProfilePictureUpload)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/applozic/mobicommons/people/contact/Contact;Landroid/content/Context;Landroid/widget/TextView;Landroid/widget/TextView;Landroid/widget/TextView;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Lcom/applozic/mobicommons/people/contact/Contact;Landroid/content/Context;Landroid/widget/TextView;Landroid/widget/TextView;Landroid/widget/TextView;)V", __args);
						return;
					}

					if (id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_Lcom_applozic_mobicommons_people_contact_Contact_Landroid_content_Context_Landroid_widget_TextView_Landroid_widget_TextView_Landroid_widget_TextView_ == IntPtr.Zero)
						id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_Lcom_applozic_mobicommons_people_contact_Contact_Landroid_content_Context_Landroid_widget_TextView_Landroid_widget_TextView_Landroid_widget_TextView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment;Lcom/applozic/mobicommons/people/contact/Contact;Landroid/content/Context;Landroid/widget/TextView;Landroid/widget/TextView;Landroid/widget/TextView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_Lcom_applozic_mobicommons_people_contact_Contact_Landroid_content_Context_Landroid_widget_TextView_Landroid_widget_TextView_Landroid_widget_TextView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicomkit_uiwidgets_people_fragment_ProfileFragment_Lcom_applozic_mobicommons_people_contact_Contact_Landroid_content_Context_Landroid_widget_TextView_Landroid_widget_TextView_Landroid_widget_TextView_, __args);
				} finally {
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object[]']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override unsafe global::Java.Lang.Object DoInBackground (global::Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Void_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Void_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Void_ == null)
					cb_doInBackground_arrayLjava_lang_Void_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Void_);
				return cb_doInBackground_arrayLjava_lang_Void_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Void_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Void[] p0 = (global::Java.Lang.Void[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Void));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Void_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Void...']]"
			[Register ("doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;", "GetDoInBackground_arrayLjava_lang_Void_Handler")]
			protected virtual unsafe global::Java.Lang.Boolean DoInBackground (params global:: Java.Lang.Void[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Void_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Void_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					global::Java.Lang.Boolean __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doInBackground_arrayLjava_lang_Void_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Void;)Ljava/lang/Boolean;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_onPostExecute_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Ljava_lang_Boolean_Handler ()
			{
				if (cb_onPostExecute_Ljava_lang_Boolean_ == null)
					cb_onPostExecute_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Ljava_lang_Boolean_);
				return cb_onPostExecute_Ljava_lang_Boolean_;
			}

			static void n_OnPostExecute_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment.ProfilePictureUpload> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Ljava_lang_Boolean_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment.ProfilePictureUpload']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("onPostExecute", "(Ljava/lang/Boolean;)V", "GetOnPostExecute_Ljava_lang_Boolean_Handler")]
			protected virtual unsafe void OnPostExecute (global::Java.Lang.Boolean p0)
			{
				if (id_onPostExecute_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_onPostExecute_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPostExecute_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/people/fragment/ProfileFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ProfileFragment); }
		}

		protected ProfileFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/constructor[@name='ProfileFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProfileFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ProfileFragment)) {
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

		static Delegate cb_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetHandleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_Handler ()
		{
			if (cb_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_ == null)
				cb_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_HandleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_);
			return cb_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_;
		}

		static void n_HandleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File p2 = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.HandleProfileimageUpload (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/method[@name='handleProfileimageUpload' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='java.io.File']]"
		[Register ("handleProfileimageUpload", "(ZLandroid/net/Uri;Ljava/io/File;)V", "GetHandleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_Handler")]
		public virtual unsafe void HandleProfileimageUpload (bool p0, global::Android.Net.Uri p1, global::Java.IO.File p2)
		{
			if (id_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_ == IntPtr.Zero)
				id_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "handleProfileimageUpload", "(ZLandroid/net/Uri;Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handleProfileimageUpload_ZLandroid_net_Uri_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "handleProfileimageUpload", "(ZLandroid/net/Uri;Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processPhotoOption;
#pragma warning disable 0169
		static Delegate GetProcessPhotoOptionHandler ()
		{
			if (cb_processPhotoOption == null)
				cb_processPhotoOption = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ProcessPhotoOption);
			return cb_processPhotoOption;
		}

		static void n_ProcessPhotoOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ProcessPhotoOption ();
		}
#pragma warning restore 0169

		static IntPtr id_processPhotoOption;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/method[@name='processPhotoOption' and count(parameter)=0]"
		[Register ("processPhotoOption", "()V", "GetProcessPhotoOptionHandler")]
		public virtual unsafe void ProcessPhotoOption ()
		{
			if (id_processPhotoOption == IntPtr.Zero)
				id_processPhotoOption = JNIEnv.GetMethodID (class_ref, "processPhotoOption", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processPhotoOption);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processPhotoOption", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
#pragma warning disable 0169
		static Delegate GetSetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_Handler ()
		{
			if (cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ == null)
				cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_);
			return cb_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
		}

		static void n_SetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAlCustomizationSettings (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/method[@name='setAlCustomizationSettings' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.AlCustomizationSettings']]"
		[Register ("setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V", "GetSetAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_Handler")]
		public virtual unsafe void SetAlCustomizationSettings (global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings p0)
		{
			if (id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ == IntPtr.Zero)
				id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_ = JNIEnv.GetMethodID (class_ref, "setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlCustomizationSettings_Lcom_applozic_mobicomkit_uiwidgets_AlCustomizationSettings_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlCustomizationSettings", "(Lcom/applozic/mobicomkit/uiwidgets/AlCustomizationSettings;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_;
#pragma warning disable 0169
		static Delegate GetSetApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_Handler ()
		{
			if (cb_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_ == null)
				cb_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_);
			return cb_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_;
		}

		static void n_SetApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.People.Fragment.ProfileFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetApplozicPermissions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.people.fragment']/class[@name='ProfileFragment']/method[@name='setApplozicPermissions' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.instruction.ApplozicPermissions']]"
		[Register ("setApplozicPermissions", "(Lcom/applozic/mobicomkit/uiwidgets/instruction/ApplozicPermissions;)V", "GetSetApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_Handler")]
		public virtual unsafe void SetApplozicPermissions (global::Com.Applozic.Mobicomkit.Uiwidgets.Instruction.ApplozicPermissions p0)
		{
			if (id_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_ == IntPtr.Zero)
				id_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_ = JNIEnv.GetMethodID (class_ref, "setApplozicPermissions", "(Lcom/applozic/mobicomkit/uiwidgets/instruction/ApplozicPermissions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplozicPermissions_Lcom_applozic_mobicomkit_uiwidgets_instruction_ApplozicPermissions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplozicPermissions", "(Lcom/applozic/mobicomkit/uiwidgets/instruction/ApplozicPermissions;)V"), __args);
			} finally {
			}
		}

	}
}
