using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='SearchListFragment']"
	[Register ("com/applozic/mobicommons/people/SearchListFragment", "", "Com.Applozic.Mobicommons.People.ISearchListFragmentInvoker")]
	public partial interface ISearchListFragment : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people']/interface[@name='SearchListFragment']/method[@name='onQueryTextChange' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onQueryTextChange", "(Ljava/lang/String;)Z", "GetOnQueryTextChange_Ljava_lang_String_Handler:Com.Applozic.Mobicommons.People.ISearchListFragmentInvoker, AndroidMobicomBindingProject")]
		bool OnQueryTextChange (string p0);

	}

	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/SearchListFragment", DoNotGenerateAcw=true)]
	internal class ISearchListFragmentInvoker : global::Java.Lang.Object, ISearchListFragment {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/applozic/mobicommons/people/SearchListFragment");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISearchListFragmentInvoker); }
		}

		IntPtr class_ref;

		public static ISearchListFragment GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISearchListFragment> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applozic.mobicommons.people.SearchListFragment"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISearchListFragmentInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Applozic.Mobicommons.People.ISearchListFragment __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.ISearchListFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnQueryTextChange (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_onQueryTextChange_Ljava_lang_String_;
		public unsafe bool OnQueryTextChange (string p0)
		{
			if (id_onQueryTextChange_Ljava_lang_String_ == IntPtr.Zero)
				id_onQueryTextChange_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onQueryTextChange", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onQueryTextChange_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
