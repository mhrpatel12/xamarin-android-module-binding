using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ContactSelectionActivity", DoNotGenerateAcw=true)]
	public partial class ContactSelectionActivity : global::Android.Support.V7.App.AppCompatActivity, global::Android.Support.V7.Widget.SearchView.IOnQueryTextListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='CHANNEL']"
		[Register ("CHANNEL")]
		public const string Channel = (string) "CHANNEL_NAME";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='CHANNEL_OBJECT']"
		[Register ("CHANNEL_OBJECT")]
		public const string ChannelObject = (string) "CHANNEL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='CHECK_BOX']"
		[Register ("CHECK_BOX")]
		public const string CheckBox = (string) "CHECK_BOX";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='GROUP_TYPE']"
		[Register ("GROUP_TYPE")]
		public const string GroupType = (string) "GROUP_TYPE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='IMAGE_LINK']"
		[Register ("IMAGE_LINK")]
		public const string ImageLink = (string) "IMAGE_LINK";

		static IntPtr isSearching_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='isSearching']"
		[Register ("isSearching")]
		public static bool IsSearching {
			get {
				if (isSearching_jfieldId == IntPtr.Zero)
					isSearching_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isSearching", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isSearching_jfieldId);
			}
			set {
				if (isSearching_jfieldId == IntPtr.Zero)
					isSearching_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isSearching", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isSearching_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr searchView_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/field[@name='searchView']"
		[Register ("searchView")]
		protected global::Android.Support.V7.Widget.SearchView SearchView {
			get {
				if (searchView_jfieldId == IntPtr.Zero)
					searchView_jfieldId = JNIEnv.GetFieldID (class_ref, "searchView", "Landroid/support/v7/widget/SearchView;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, searchView_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.SearchView> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (searchView_jfieldId == IntPtr.Zero)
					searchView_jfieldId = JNIEnv.GetFieldID (class_ref, "searchView", "Landroid/support/v7/widget/SearchView;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, searchView_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/conversation/activity/ContactSelectionActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactSelectionActivity); }
		}

		protected ContactSelectionActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/constructor[@name='ContactSelectionActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactSelectionActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ContactSelectionActivity)) {
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

		static Delegate cb_getSearchListFragment;
#pragma warning disable 0169
		static Delegate GetGetSearchListFragmentHandler ()
		{
			if (cb_getSearchListFragment == null)
				cb_getSearchListFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSearchListFragment);
			return cb_getSearchListFragment;
		}

		static IntPtr n_GetSearchListFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SearchListFragment);
		}
#pragma warning restore 0169

		static Delegate cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
#pragma warning disable 0169
		static Delegate GetSetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_Handler ()
		{
			if (cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ == null)
				cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_);
			return cb_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
		}

		static void n_SetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.ISearchListFragment p0 = (global::Com.Applozic.Mobicommons.People.ISearchListFragment)global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SearchListFragment = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSearchListFragment;
		static IntPtr id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.ISearchListFragment SearchListFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/method[@name='getSearchListFragment' and count(parameter)=0]"
			[Register ("getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;", "GetGetSearchListFragmentHandler")]
			get {
				if (id_getSearchListFragment == IntPtr.Zero)
					id_getSearchListFragment = JNIEnv.GetMethodID (class_ref, "getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSearchListFragment), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSearchListFragment", "()Lcom/applozic/mobicommons/people/SearchListFragment;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/method[@name='setSearchListFragment' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.SearchListFragment']]"
			[Register ("setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V", "GetSetSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_Handler")]
			set {
				if (id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ == IntPtr.Zero)
					id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_ = JNIEnv.GetMethodID (class_ref, "setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSearchListFragment_Lcom_applozic_mobicommons_people_SearchListFragment_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSearchListFragment", "(Lcom/applozic/mobicommons/people/SearchListFragment;)V"), __args);
				} finally {
				}
			}
		}

		static IntPtr id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/method[@name='addFragment' and count(parameter)=3 and parameter[1][@type='android.support.v4.app.FragmentActivity'] and parameter[2][@type='android.support.v4.app.Fragment'] and parameter[3][@type='java.lang.String']]"
		[Register ("addFragment", "(Landroid/support/v4/app/FragmentActivity;Landroid/support/v4/app/Fragment;Ljava/lang/String;)V", "")]
		public static unsafe void AddFragment (global::Android.Support.V4.App.FragmentActivity p0, global::Android.Support.V4.App.Fragment p1, string p2)
		{
			if (id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_ == IntPtr.Zero)
				id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "addFragment", "(Landroid/support/v4/app/FragmentActivity;Landroid/support/v4/app/Fragment;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_addFragment_Landroid_support_v4_app_FragmentActivity_Landroid_support_v4_app_Fragment_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onQueryTextChange_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnQueryTextChange_Ljava_lang_String_Handler ()
		{
			if (cb_onQueryTextChange_Ljava_lang_String_ == null)
				cb_onQueryTextChange_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextChange_Ljava_lang_String_);
			return cb_onQueryTextChange_Ljava_lang_String_;
		}

		static bool n_OnQueryTextChange_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnQueryTextChange (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onQueryTextChange_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/method[@name='onQueryTextChange' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onQueryTextChange", "(Ljava/lang/String;)Z", "GetOnQueryTextChange_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnQueryTextChange (string p0)
		{
			if (id_onQueryTextChange_Ljava_lang_String_ == IntPtr.Zero)
				id_onQueryTextChange_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextChange", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextChange_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQueryTextChange", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onQueryTextSubmit_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnQueryTextSubmit_Ljava_lang_String_Handler ()
		{
			if (cb_onQueryTextSubmit_Ljava_lang_String_ == null)
				cb_onQueryTextSubmit_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnQueryTextSubmit_Ljava_lang_String_);
			return cb_onQueryTextSubmit_Ljava_lang_String_;
		}

		static bool n_OnQueryTextSubmit_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.Activity.ContactSelectionActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnQueryTextSubmit (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onQueryTextSubmit_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets.conversation.activity']/class[@name='ContactSelectionActivity']/method[@name='onQueryTextSubmit' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onQueryTextSubmit", "(Ljava/lang/String;)Z", "GetOnQueryTextSubmit_Ljava_lang_String_Handler")]
		public virtual unsafe bool OnQueryTextSubmit (string p0)
		{
			if (id_onQueryTextSubmit_Ljava_lang_String_ == IntPtr.Zero)
				id_onQueryTextSubmit_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextSubmit", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextSubmit_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onQueryTextSubmit", "(Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
