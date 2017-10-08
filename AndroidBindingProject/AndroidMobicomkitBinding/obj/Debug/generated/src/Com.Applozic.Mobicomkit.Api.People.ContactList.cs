using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.People {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ContactList']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/people/ContactList", DoNotGenerateAcw=true)]
	public partial class ContactList : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/people/ContactList", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ContactList); }
		}

		protected ContactList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ContactList']/constructor[@name='ContactList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ContactList ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ContactList)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ContactList']/constructor[@name='ContactList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe ContactList (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ContactList)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getContacts;
#pragma warning disable 0169
		static Delegate GetGetContactsHandler ()
		{
			if (cb_getContacts == null)
				cb_getContacts = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContacts);
			return cb_getContacts;
		}

		static IntPtr n_GetContacts (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ContactList __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ContactList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (__this.Contacts);
		}
#pragma warning restore 0169

		static Delegate cb_setContacts_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContacts_Ljava_util_List_Handler ()
		{
			if (cb_setContacts_Ljava_util_List_ == null)
				cb_setContacts_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContacts_Ljava_util_List_);
			return cb_setContacts_Ljava_util_List_;
		}

		static void n_SetContacts_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ContactList __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ContactList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Contacts = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContacts;
		static IntPtr id_setContacts_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicommons.People.Contact.Contact> Contacts {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ContactList']/method[@name='getContacts' and count(parameter)=0]"
			[Register ("getContacts", "()Ljava/util/List;", "GetGetContactsHandler")]
			get {
				if (id_getContacts == IntPtr.Zero)
					id_getContacts = JNIEnv.GetMethodID (class_ref, "getContacts", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContacts), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContacts", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ContactList']/method[@name='setContacts' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicommons.people.contact.Contact&gt;']]"
			[Register ("setContacts", "(Ljava/util/List;)V", "GetSetContacts_Ljava_util_List_Handler")]
			set {
				if (id_setContacts_Ljava_util_List_ == IntPtr.Zero)
					id_setContacts_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContacts", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicommons.People.Contact.Contact>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContacts_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContacts", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
