using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/contact/Contact", DoNotGenerateAcw=true)]
	public partial class Contact : global::Com.Applozic.Mobicommons.Json.JsonMarker {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/field[@name='R_DRAWABLE']"
		[Register ("R_DRAWABLE")]
		public const string RDrawable = (string) "R.drawable";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/contact/Contact", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Contact); }
		}

		protected Contact (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe Contact (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (Contact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Contact (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (Contact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[4][@type='long']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;J)V", "")]
		public unsafe Contact (string p0, global::System.Collections.Generic.IList<string> p1, global::System.Collections.Generic.IList<string> p2, long p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (Contact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;J)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_J == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_J = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;Ljava/util/List;J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_util_List_J, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Contact ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Contact)) {
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

		static IntPtr id_ctor_J;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe Contact (long p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (Contact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(J)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(J)V", __args);
					return;
				}

				if (id_ctor_J == IntPtr.Zero)
					id_ctor_J = JNIEnv.GetMethodID (class_ref, "<init>", "(J)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_J, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_J, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/constructor[@name='Contact' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe Contact (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (Contact)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getApplicationId;
#pragma warning disable 0169
		static Delegate GetGetApplicationIdHandler ()
		{
			if (cb_getApplicationId == null)
				cb_getApplicationId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationId);
			return cb_getApplicationId;
		}

		static IntPtr n_GetApplicationId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationId);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationId_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationId_Ljava_lang_String_ == null)
				cb_setApplicationId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationId_Ljava_lang_String_);
			return cb_setApplicationId_Ljava_lang_String_;
		}

		static void n_SetApplicationId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationId;
		static IntPtr id_setApplicationId_Ljava_lang_String_;
		public virtual unsafe string ApplicationId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getApplicationId' and count(parameter)=0]"
			[Register ("getApplicationId", "()Ljava/lang/String;", "GetGetApplicationIdHandler")]
			get {
				if (id_getApplicationId == IntPtr.Zero)
					id_getApplicationId = JNIEnv.GetMethodID (class_ref, "getApplicationId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setApplicationId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationId", "(Ljava/lang/String;)V", "GetSetApplicationId_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationId_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isBlocked;
#pragma warning disable 0169
		static Delegate GetIsBlockedHandler ()
		{
			if (cb_isBlocked == null)
				cb_isBlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlocked);
			return cb_isBlocked;
		}

		static bool n_IsBlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Blocked;
		}
#pragma warning restore 0169

		static Delegate cb_setBlocked_Z;
#pragma warning disable 0169
		static Delegate GetSetBlocked_ZHandler ()
		{
			if (cb_setBlocked_Z == null)
				cb_setBlocked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBlocked_Z);
			return cb_setBlocked_Z;
		}

		static void n_SetBlocked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Blocked = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBlocked;
		static IntPtr id_setBlocked_Z;
		public virtual unsafe bool Blocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isBlocked' and count(parameter)=0]"
			[Register ("isBlocked", "()Z", "GetIsBlockedHandler")]
			get {
				if (id_isBlocked == IntPtr.Zero)
					id_isBlocked = JNIEnv.GetMethodID (class_ref, "isBlocked", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBlocked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBlocked", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setBlocked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBlocked", "(Z)V", "GetSetBlocked_ZHandler")]
			set {
				if (id_setBlocked_Z == IntPtr.Zero)
					id_setBlocked_Z = JNIEnv.GetMethodID (class_ref, "setBlocked", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlocked_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlocked", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBlockedBy;
#pragma warning disable 0169
		static Delegate GetIsBlockedByHandler ()
		{
			if (cb_isBlockedBy == null)
				cb_isBlockedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlockedBy);
			return cb_isBlockedBy;
		}

		static bool n_IsBlockedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockedBy;
		}
#pragma warning restore 0169

		static Delegate cb_setBlockedBy_Z;
#pragma warning disable 0169
		static Delegate GetSetBlockedBy_ZHandler ()
		{
			if (cb_setBlockedBy_Z == null)
				cb_setBlockedBy_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBlockedBy_Z);
			return cb_setBlockedBy_Z;
		}

		static void n_SetBlockedBy_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockedBy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBlockedBy;
		static IntPtr id_setBlockedBy_Z;
		public virtual unsafe bool BlockedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isBlockedBy' and count(parameter)=0]"
			[Register ("isBlockedBy", "()Z", "GetIsBlockedByHandler")]
			get {
				if (id_isBlockedBy == IntPtr.Zero)
					id_isBlockedBy = JNIEnv.GetMethodID (class_ref, "isBlockedBy", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBlockedBy);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBlockedBy", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setBlockedBy' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBlockedBy", "(Z)V", "GetSetBlockedBy_ZHandler")]
			set {
				if (id_setBlockedBy_Z == IntPtr.Zero)
					id_setBlockedBy_Z = JNIEnv.GetMethodID (class_ref, "setBlockedBy", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockedBy_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockedBy", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isChecked;
#pragma warning disable 0169
		static Delegate GetIsCheckedHandler ()
		{
			if (cb_isChecked == null)
				cb_isChecked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsChecked);
			return cb_isChecked;
		}

		static bool n_IsChecked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Checked;
		}
#pragma warning restore 0169

		static Delegate cb_setChecked_Z;
#pragma warning disable 0169
		static Delegate GetSetChecked_ZHandler ()
		{
			if (cb_setChecked_Z == null)
				cb_setChecked_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetChecked_Z);
			return cb_setChecked_Z;
		}

		static void n_SetChecked_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Checked = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isChecked;
		static IntPtr id_setChecked_Z;
		public virtual unsafe bool Checked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isChecked' and count(parameter)=0]"
			[Register ("isChecked", "()Z", "GetIsCheckedHandler")]
			get {
				if (id_isChecked == IntPtr.Zero)
					id_isChecked = JNIEnv.GetMethodID (class_ref, "isChecked", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isChecked);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isChecked", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setChecked' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setChecked", "(Z)V", "GetSetChecked_ZHandler")]
			set {
				if (id_setChecked_Z == IntPtr.Zero)
					id_setChecked_Z = JNIEnv.GetMethodID (class_ref, "setChecked", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChecked_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChecked", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connected;
		}
#pragma warning restore 0169

		static Delegate cb_setConnected_Z;
#pragma warning disable 0169
		static Delegate GetSetConnected_ZHandler ()
		{
			if (cb_setConnected_Z == null)
				cb_setConnected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConnected_Z);
			return cb_setConnected_Z;
		}

		static void n_SetConnected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		static IntPtr id_setConnected_Z;
		public virtual unsafe bool Connected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setConnected", "(Z)V", "GetSetConnected_ZHandler")]
			set {
				if (id_setConnected_Z == IntPtr.Zero)
					id_setConnected_Z = JNIEnv.GetMethodID (class_ref, "setConnected", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnected_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnected", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContactId;
#pragma warning disable 0169
		static Delegate GetGetContactIdHandler ()
		{
			if (cb_getContactId == null)
				cb_getContactId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetContactId);
			return cb_getContactId;
		}

		static long n_GetContactId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContactId;
		}
#pragma warning restore 0169

		static Delegate cb_setContactId_J;
#pragma warning disable 0169
		static Delegate GetSetContactId_JHandler ()
		{
			if (cb_setContactId_J == null)
				cb_setContactId_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetContactId_J);
			return cb_setContactId_J;
		}

		static void n_SetContactId_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContactId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactId;
		static IntPtr id_setContactId_J;
		public virtual unsafe long ContactId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getContactId' and count(parameter)=0]"
			[Register ("getContactId", "()J", "GetGetContactIdHandler")]
			get {
				if (id_getContactId == IntPtr.Zero)
					id_getContactId = JNIEnv.GetMethodID (class_ref, "getContactId", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getContactId);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactId", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setContactId' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setContactId", "(J)V", "GetSetContactId_JHandler")]
			set {
				if (id_setContactId_J == IntPtr.Zero)
					id_setContactId_J = JNIEnv.GetMethodID (class_ref, "setContactId", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactId_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactId", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContactIds;
#pragma warning disable 0169
		static Delegate GetGetContactIdsHandler ()
		{
			if (cb_getContactIds == null)
				cb_getContactIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactIds);
			return cb_getContactIds;
		}

		static IntPtr n_GetContactIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContactIds);
		}
#pragma warning restore 0169

		static IntPtr id_getContactIds;
		public virtual unsafe string ContactIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getContactIds' and count(parameter)=0]"
			[Register ("getContactIds", "()Ljava/lang/String;", "GetGetContactIdsHandler")]
			get {
				if (id_getContactIds == IntPtr.Zero)
					id_getContactIds = JNIEnv.GetMethodID (class_ref, "getContactIds", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactIds), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactIds", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumber;
		static IntPtr id_setContactNumber_Ljava_lang_String_;
		public virtual unsafe string ContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getContactNumber' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContactNumbers;
#pragma warning disable 0169
		static Delegate GetGetContactNumbersHandler ()
		{
			if (cb_getContactNumbers == null)
				cb_getContactNumbers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactNumbers);
			return cb_getContactNumbers;
		}

		static IntPtr n_GetContactNumbers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ContactNumbers);
		}
#pragma warning restore 0169

		static Delegate cb_setContactNumbers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetContactNumbers_Ljava_util_List_Handler ()
		{
			if (cb_setContactNumbers_Ljava_util_List_ == null)
				cb_setContactNumbers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactNumbers_Ljava_util_List_);
			return cb_setContactNumbers_Ljava_util_List_;
		}

		static void n_SetContactNumbers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactNumbers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactNumbers;
		static IntPtr id_setContactNumbers_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> ContactNumbers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getContactNumbers' and count(parameter)=0]"
			[Register ("getContactNumbers", "()Ljava/util/List;", "GetGetContactNumbersHandler")]
			get {
				if (id_getContactNumbers == IntPtr.Zero)
					id_getContactNumbers = JNIEnv.GetMethodID (class_ref, "getContactNumbers", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactNumbers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactNumbers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setContactNumbers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setContactNumbers", "(Ljava/util/List;)V", "GetSetContactNumbers_Ljava_util_List_Handler")]
			set {
				if (id_setContactNumbers_Ljava_util_List_ == IntPtr.Zero)
					id_setContactNumbers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setContactNumbers", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactNumbers_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactNumbers", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getContactType;
#pragma warning disable 0169
		static Delegate GetGetContactTypeHandler ()
		{
			if (cb_getContactType == null)
				cb_getContactType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetContactType);
			return cb_getContactType;
		}

		static short n_GetContactType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContactType;
		}
#pragma warning restore 0169

		static Delegate cb_setContactType_S;
#pragma warning disable 0169
		static Delegate GetSetContactType_SHandler ()
		{
			if (cb_setContactType_S == null)
				cb_setContactType_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetContactType_S);
			return cb_setContactType_S;
		}

		static void n_SetContactType_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContactType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactType;
		static IntPtr id_setContactType_S;
		public virtual unsafe short ContactType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getContactType' and count(parameter)=0]"
			[Register ("getContactType", "()S", "GetGetContactTypeHandler")]
			get {
				if (id_getContactType == IntPtr.Zero)
					id_getContactType = JNIEnv.GetMethodID (class_ref, "getContactType", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getContactType);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactType", "()S"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setContactType' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setContactType", "(S)V", "GetSetContactType_SHandler")]
			set {
				if (id_setContactType_S == IntPtr.Zero)
					id_setContactType_S = JNIEnv.GetMethodID (class_ref, "setContactType", "(S)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactType_S, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactType", "(S)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayName;
#pragma warning disable 0169
		static Delegate GetGetDisplayNameHandler ()
		{
			if (cb_getDisplayName == null)
				cb_getDisplayName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayName);
			return cb_getDisplayName;
		}

		static IntPtr n_GetDisplayName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DisplayName);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayName;
		public virtual unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "GetGetDisplayNameHandler")]
			get {
				if (id_getDisplayName == IntPtr.Zero)
					id_getDisplayName = JNIEnv.GetMethodID (class_ref, "getDisplayName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDisplayName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEmailId;
#pragma warning disable 0169
		static Delegate GetGetEmailIdHandler ()
		{
			if (cb_getEmailId == null)
				cb_getEmailId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailId);
			return cb_getEmailId;
		}

		static IntPtr n_GetEmailId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EmailId);
		}
#pragma warning restore 0169

		static Delegate cb_setEmailId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmailId_Ljava_lang_String_Handler ()
		{
			if (cb_setEmailId_Ljava_lang_String_ == null)
				cb_setEmailId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmailId_Ljava_lang_String_);
			return cb_setEmailId_Ljava_lang_String_;
		}

		static void n_SetEmailId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmailId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmailId;
		static IntPtr id_setEmailId_Ljava_lang_String_;
		public virtual unsafe string EmailId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getEmailId' and count(parameter)=0]"
			[Register ("getEmailId", "()Ljava/lang/String;", "GetGetEmailIdHandler")]
			get {
				if (id_getEmailId == IntPtr.Zero)
					id_getEmailId = JNIEnv.GetMethodID (class_ref, "getEmailId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmailId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setEmailId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmailId", "(Ljava/lang/String;)V", "GetSetEmailId_Ljava_lang_String_Handler")]
			set {
				if (id_setEmailId_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmailId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmailId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEmailIds;
#pragma warning disable 0169
		static Delegate GetGetEmailIdsHandler ()
		{
			if (cb_getEmailIds == null)
				cb_getEmailIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmailIds);
			return cb_getEmailIds;
		}

		static IntPtr n_GetEmailIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.EmailIds);
		}
#pragma warning restore 0169

		static Delegate cb_setEmailIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEmailIds_Ljava_util_List_Handler ()
		{
			if (cb_setEmailIds_Ljava_util_List_ == null)
				cb_setEmailIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmailIds_Ljava_util_List_);
			return cb_setEmailIds_Ljava_util_List_;
		}

		static void n_SetEmailIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EmailIds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmailIds;
		static IntPtr id_setEmailIds_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> EmailIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getEmailIds' and count(parameter)=0]"
			[Register ("getEmailIds", "()Ljava/util/List;", "GetGetEmailIdsHandler")]
			get {
				if (id_getEmailIds == IntPtr.Zero)
					id_getEmailIds = JNIEnv.GetMethodID (class_ref, "getEmailIds", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmailIds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmailIds", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setEmailIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setEmailIds", "(Ljava/util/List;)V", "GetSetEmailIds_Ljava_util_List_Handler")]
			set {
				if (id_setEmailIds_Ljava_util_List_ == IntPtr.Zero)
					id_setEmailIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setEmailIds", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmailIds_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmailIds", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFirstName;
#pragma warning disable 0169
		static Delegate GetGetFirstNameHandler ()
		{
			if (cb_getFirstName == null)
				cb_getFirstName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstName);
			return cb_getFirstName;
		}

		static IntPtr n_GetFirstName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FirstName);
		}
#pragma warning restore 0169

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FirstName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstName;
		static IntPtr id_setFirstName_Ljava_lang_String_;
		public virtual unsafe string FirstName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getFirstName' and count(parameter)=0]"
			[Register ("getFirstName", "()Ljava/lang/String;", "GetGetFirstNameHandler")]
			get {
				if (id_getFirstName == IntPtr.Zero)
					id_getFirstName = JNIEnv.GetMethodID (class_ref, "getFirstName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirstName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
			set {
				if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFormattedContactNumber;
#pragma warning disable 0169
		static Delegate GetGetFormattedContactNumberHandler ()
		{
			if (cb_getFormattedContactNumber == null)
				cb_getFormattedContactNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormattedContactNumber);
			return cb_getFormattedContactNumber;
		}

		static IntPtr n_GetFormattedContactNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FormattedContactNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setFormattedContactNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFormattedContactNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setFormattedContactNumber_Ljava_lang_String_ == null)
				cb_setFormattedContactNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormattedContactNumber_Ljava_lang_String_);
			return cb_setFormattedContactNumber_Ljava_lang_String_;
		}

		static void n_SetFormattedContactNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FormattedContactNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFormattedContactNumber;
		static IntPtr id_setFormattedContactNumber_Ljava_lang_String_;
		public virtual unsafe string FormattedContactNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getFormattedContactNumber' and count(parameter)=0]"
			[Register ("getFormattedContactNumber", "()Ljava/lang/String;", "GetGetFormattedContactNumberHandler")]
			get {
				if (id_getFormattedContactNumber == IntPtr.Zero)
					id_getFormattedContactNumber = JNIEnv.GetMethodID (class_ref, "getFormattedContactNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedContactNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFormattedContactNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setFormattedContactNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFormattedContactNumber", "(Ljava/lang/String;)V", "GetSetFormattedContactNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setFormattedContactNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setFormattedContactNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFormattedContactNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFormattedContactNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFormattedContactNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getFullName;
#pragma warning disable 0169
		static Delegate GetGetFullNameHandler ()
		{
			if (cb_getFullName == null)
				cb_getFullName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFullName);
			return cb_getFullName;
		}

		static IntPtr n_GetFullName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FullName);
		}
#pragma warning restore 0169

		static Delegate cb_setFullName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFullName_Ljava_lang_String_Handler ()
		{
			if (cb_setFullName_Ljava_lang_String_ == null)
				cb_setFullName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFullName_Ljava_lang_String_);
			return cb_setFullName_Ljava_lang_String_;
		}

		static void n_SetFullName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FullName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFullName;
		static IntPtr id_setFullName_Ljava_lang_String_;
		public virtual unsafe string FullName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getFullName' and count(parameter)=0]"
			[Register ("getFullName", "()Ljava/lang/String;", "GetGetFullNameHandler")]
			get {
				if (id_getFullName == IntPtr.Zero)
					id_getFullName = JNIEnv.GetMethodID (class_ref, "getFullName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFullName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFullName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setFullName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFullName", "(Ljava/lang/String;)V", "GetSetFullName_Ljava_lang_String_Handler")]
			set {
				if (id_setFullName_Ljava_lang_String_ == IntPtr.Zero)
					id_setFullName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFullName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_hasMultiplePhoneNumbers;
#pragma warning disable 0169
		static Delegate GetHasMultiplePhoneNumbersHandler ()
		{
			if (cb_hasMultiplePhoneNumbers == null)
				cb_hasMultiplePhoneNumbers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasMultiplePhoneNumbers);
			return cb_hasMultiplePhoneNumbers;
		}

		static bool n_HasMultiplePhoneNumbers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasMultiplePhoneNumbers;
		}
#pragma warning restore 0169

		static IntPtr id_hasMultiplePhoneNumbers;
		public virtual unsafe bool HasMultiplePhoneNumbers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='hasMultiplePhoneNumbers' and count(parameter)=0]"
			[Register ("hasMultiplePhoneNumbers", "()Z", "GetHasMultiplePhoneNumbersHandler")]
			get {
				if (id_hasMultiplePhoneNumbers == IntPtr.Zero)
					id_hasMultiplePhoneNumbers = JNIEnv.GetMethodID (class_ref, "hasMultiplePhoneNumbers", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasMultiplePhoneNumbers);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasMultiplePhoneNumbers", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getImageURL;
#pragma warning disable 0169
		static Delegate GetGetImageURLHandler ()
		{
			if (cb_getImageURL == null)
				cb_getImageURL = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageURL);
			return cb_getImageURL;
		}

		static IntPtr n_GetImageURL (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageURL);
		}
#pragma warning restore 0169

		static Delegate cb_setImageURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageURL_Ljava_lang_String_Handler ()
		{
			if (cb_setImageURL_Ljava_lang_String_ == null)
				cb_setImageURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageURL_Ljava_lang_String_);
			return cb_setImageURL_Ljava_lang_String_;
		}

		static void n_SetImageURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageURL = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageURL;
		static IntPtr id_setImageURL_Ljava_lang_String_;
		public virtual unsafe string ImageURL {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getImageURL' and count(parameter)=0]"
			[Register ("getImageURL", "()Ljava/lang/String;", "GetGetImageURLHandler")]
			get {
				if (id_getImageURL == IntPtr.Zero)
					id_getImageURL = JNIEnv.GetMethodID (class_ref, "getImageURL", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageURL), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageURL", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setImageURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageURL", "(Ljava/lang/String;)V", "GetSetImageURL_Ljava_lang_String_Handler")]
			set {
				if (id_setImageURL_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageURL", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageURL_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageURL", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isDrawableResources;
#pragma warning disable 0169
		static Delegate GetIsDrawableResourcesHandler ()
		{
			if (cb_isDrawableResources == null)
				cb_isDrawableResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawableResources);
			return cb_isDrawableResources;
		}

		static bool n_IsDrawableResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawableResources;
		}
#pragma warning restore 0169

		static IntPtr id_isDrawableResources;
		public virtual unsafe bool IsDrawableResources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isDrawableResources' and count(parameter)=0]"
			[Register ("isDrawableResources", "()Z", "GetIsDrawableResourcesHandler")]
			get {
				if (id_isDrawableResources == IntPtr.Zero)
					id_isDrawableResources = JNIEnv.GetMethodID (class_ref, "isDrawableResources", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawableResources);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDrawableResources", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOnline;
#pragma warning disable 0169
		static Delegate GetIsOnlineHandler ()
		{
			if (cb_isOnline == null)
				cb_isOnline = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnline);
			return cb_isOnline;
		}

		static bool n_IsOnline (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnline;
		}
#pragma warning restore 0169

		static IntPtr id_isOnline;
		public virtual unsafe bool IsOnline {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='isOnline' and count(parameter)=0]"
			[Register ("isOnline", "()Z", "GetIsOnlineHandler")]
			get {
				if (id_isOnline == IntPtr.Zero)
					id_isOnline = JNIEnv.GetMethodID (class_ref, "isOnline", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnline);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnline", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLastName;
#pragma warning disable 0169
		static Delegate GetGetLastNameHandler ()
		{
			if (cb_getLastName == null)
				cb_getLastName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastName);
			return cb_getLastName;
		}

		static IntPtr n_GetLastName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LastName);
		}
#pragma warning restore 0169

		static Delegate cb_setLastName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastName_Ljava_lang_String_Handler ()
		{
			if (cb_setLastName_Ljava_lang_String_ == null)
				cb_setLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastName_Ljava_lang_String_);
			return cb_setLastName_Ljava_lang_String_;
		}

		static void n_SetLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LastName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastName;
		static IntPtr id_setLastName_Ljava_lang_String_;
		public virtual unsafe string LastName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getLastName' and count(parameter)=0]"
			[Register ("getLastName", "()Ljava/lang/String;", "GetGetLastNameHandler")]
			get {
				if (id_getLastName == IntPtr.Zero)
					id_getLastName = JNIEnv.GetMethodID (class_ref, "getLastName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLastName", "(Ljava/lang/String;)V", "GetSetLastName_Ljava_lang_String_Handler")]
			set {
				if (id_setLastName_Ljava_lang_String_ == IntPtr.Zero)
					id_setLastName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getLastSeenAt;
#pragma warning disable 0169
		static Delegate GetGetLastSeenAtHandler ()
		{
			if (cb_getLastSeenAt == null)
				cb_getLastSeenAt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastSeenAt);
			return cb_getLastSeenAt;
		}

		static long n_GetLastSeenAt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastSeenAt;
		}
#pragma warning restore 0169

		static IntPtr id_getLastSeenAt;
		public virtual unsafe long LastSeenAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getLastSeenAt' and count(parameter)=0]"
			[Register ("getLastSeenAt", "()J", "GetGetLastSeenAtHandler")]
			get {
				if (id_getLastSeenAt == IntPtr.Zero)
					id_getLastSeenAt = JNIEnv.GetMethodID (class_ref, "getLastSeenAt", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastSeenAt);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastSeenAt", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getLocalImageUrl;
#pragma warning disable 0169
		static Delegate GetGetLocalImageUrlHandler ()
		{
			if (cb_getLocalImageUrl == null)
				cb_getLocalImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalImageUrl);
			return cb_getLocalImageUrl;
		}

		static IntPtr n_GetLocalImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalImageUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalImageUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocalImageUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setLocalImageUrl_Ljava_lang_String_ == null)
				cb_setLocalImageUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalImageUrl_Ljava_lang_String_);
			return cb_setLocalImageUrl_Ljava_lang_String_;
		}

		static void n_SetLocalImageUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalImageUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalImageUrl;
		static IntPtr id_setLocalImageUrl_Ljava_lang_String_;
		public virtual unsafe string LocalImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getLocalImageUrl' and count(parameter)=0]"
			[Register ("getLocalImageUrl", "()Ljava/lang/String;", "GetGetLocalImageUrlHandler")]
			get {
				if (id_getLocalImageUrl == IntPtr.Zero)
					id_getLocalImageUrl = JNIEnv.GetMethodID (class_ref, "getLocalImageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setLocalImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocalImageUrl", "(Ljava/lang/String;)V", "GetSetLocalImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setLocalImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocalImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocalImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalImageUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalImageUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMiddleName;
#pragma warning disable 0169
		static Delegate GetGetMiddleNameHandler ()
		{
			if (cb_getMiddleName == null)
				cb_getMiddleName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMiddleName);
			return cb_getMiddleName;
		}

		static IntPtr n_GetMiddleName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MiddleName);
		}
#pragma warning restore 0169

		static Delegate cb_setMiddleName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMiddleName_Ljava_lang_String_Handler ()
		{
			if (cb_setMiddleName_Ljava_lang_String_ == null)
				cb_setMiddleName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMiddleName_Ljava_lang_String_);
			return cb_setMiddleName_Ljava_lang_String_;
		}

		static void n_SetMiddleName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MiddleName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMiddleName;
		static IntPtr id_setMiddleName_Ljava_lang_String_;
		public virtual unsafe string MiddleName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getMiddleName' and count(parameter)=0]"
			[Register ("getMiddleName", "()Ljava/lang/String;", "GetGetMiddleNameHandler")]
			get {
				if (id_getMiddleName == IntPtr.Zero)
					id_getMiddleName = JNIEnv.GetMethodID (class_ref, "getMiddleName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMiddleName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMiddleName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setMiddleName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setMiddleName", "(Ljava/lang/String;)V", "GetSetMiddleName_Ljava_lang_String_Handler")]
			set {
				if (id_setMiddleName_Ljava_lang_String_ == IntPtr.Zero)
					id_setMiddleName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setMiddleName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMiddleName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMiddleName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPhoneNumbers;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumbersHandler ()
		{
			if (cb_getPhoneNumbers == null)
				cb_getPhoneNumbers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumbers);
			return cb_getPhoneNumbers;
		}

		static IntPtr n_GetPhoneNumbers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.PhoneNumbers);
		}
#pragma warning restore 0169

		static Delegate cb_setPhoneNumbers_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetPhoneNumbers_Ljava_util_Map_Handler ()
		{
			if (cb_setPhoneNumbers_Ljava_util_Map_ == null)
				cb_setPhoneNumbers_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhoneNumbers_Ljava_util_Map_);
			return cb_setPhoneNumbers_Ljava_util_Map_;
		}

		static void n_SetPhoneNumbers_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PhoneNumbers = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumbers;
		static IntPtr id_setPhoneNumbers_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> PhoneNumbers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getPhoneNumbers' and count(parameter)=0]"
			[Register ("getPhoneNumbers", "()Ljava/util/Map;", "GetGetPhoneNumbersHandler")]
			get {
				if (id_getPhoneNumbers == IntPtr.Zero)
					id_getPhoneNumbers = JNIEnv.GetMethodID (class_ref, "getPhoneNumbers", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumbers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumbers", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setPhoneNumbers' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setPhoneNumbers", "(Ljava/util/Map;)V", "GetSetPhoneNumbers_Ljava_util_Map_Handler")]
			set {
				if (id_setPhoneNumbers_Ljava_util_Map_ == IntPtr.Zero)
					id_setPhoneNumbers_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumbers", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumbers_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumbers", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setStatus_Ljava_lang_String_ == null)
				cb_setStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Ljava_lang_String_);
			return cb_setStatus_Ljava_lang_String_;
		}

		static void n_SetStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Ljava_lang_String_;
		public virtual unsafe string Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Ljava/lang/String;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setStatus", "(Ljava/lang/String;)V", "GetSetStatus_Ljava_lang_String_Handler")]
			set {
				if (id_setStatus_Ljava_lang_String_ == IntPtr.Zero)
					id_setStatus_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadCountHandler ()
		{
			if (cb_getUnreadCount == null)
				cb_getUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnreadCount);
			return cb_getUnreadCount;
		}

		static IntPtr n_GetUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UnreadCount);
		}
#pragma warning restore 0169

		static Delegate cb_setUnreadCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetUnreadCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setUnreadCount_Ljava_lang_Integer_ == null)
				cb_setUnreadCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnreadCount_Ljava_lang_Integer_);
			return cb_setUnreadCount_Ljava_lang_Integer_;
		}

		static void n_SetUnreadCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getUnreadCount' and count(parameter)=0]"
			[Register ("getUnreadCount", "()Ljava/lang/Integer;", "GetGetUnreadCountHandler")]
			get {
				if (id_getUnreadCount == IntPtr.Zero)
					id_getUnreadCount = JNIEnv.GetMethodID (class_ref, "getUnreadCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setUnreadCount", "(Ljava/lang/Integer;)V", "GetSetUnreadCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setUnreadCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setUnreadCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setUnreadCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnreadCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnreadCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserTypeId;
#pragma warning disable 0169
		static Delegate GetGetUserTypeIdHandler ()
		{
			if (cb_getUserTypeId == null)
				cb_getUserTypeId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserTypeId);
			return cb_getUserTypeId;
		}

		static IntPtr n_GetUserTypeId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserTypeId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserTypeId_Ljava_lang_Short_;
#pragma warning disable 0169
		static Delegate GetSetUserTypeId_Ljava_lang_Short_Handler ()
		{
			if (cb_setUserTypeId_Ljava_lang_Short_ == null)
				cb_setUserTypeId_Ljava_lang_Short_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserTypeId_Ljava_lang_Short_);
			return cb_setUserTypeId_Ljava_lang_Short_;
		}

		static void n_SetUserTypeId_Ljava_lang_Short_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Short p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserTypeId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserTypeId;
		static IntPtr id_setUserTypeId_Ljava_lang_Short_;
		public virtual unsafe global::Java.Lang.Short UserTypeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getUserTypeId' and count(parameter)=0]"
			[Register ("getUserTypeId", "()Ljava/lang/Short;", "GetGetUserTypeIdHandler")]
			get {
				if (id_getUserTypeId == IntPtr.Zero)
					id_getUserTypeId = JNIEnv.GetMethodID (class_ref, "getUserTypeId", "()Ljava/lang/Short;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserTypeId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Short> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserTypeId", "()Ljava/lang/Short;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setUserTypeId' and count(parameter)=1 and parameter[1][@type='java.lang.Short']]"
			[Register ("setUserTypeId", "(Ljava/lang/Short;)V", "GetSetUserTypeId_Ljava_lang_Short_Handler")]
			set {
				if (id_setUserTypeId_Ljava_lang_Short_ == IntPtr.Zero)
					id_setUserTypeId_Ljava_lang_Short_ = JNIEnv.GetMethodID (class_ref, "setUserTypeId", "(Ljava/lang/Short;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserTypeId_Ljava_lang_Short_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserTypeId", "(Ljava/lang/Short;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getrDrawableName;
#pragma warning disable 0169
		static Delegate GetGetrDrawableNameHandler ()
		{
			if (cb_getrDrawableName == null)
				cb_getrDrawableName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetrDrawableName);
			return cb_getrDrawableName;
		}

		static IntPtr n_GetrDrawableName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetrDrawableName ());
		}
#pragma warning restore 0169

		static IntPtr id_getrDrawableName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='getrDrawableName' and count(parameter)=0]"
		[Register ("getrDrawableName", "()Ljava/lang/String;", "GetGetrDrawableNameHandler")]
		public virtual unsafe string GetrDrawableName ()
		{
			if (id_getrDrawableName == IntPtr.Zero)
				id_getrDrawableName = JNIEnv.GetMethodID (class_ref, "getrDrawableName", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getrDrawableName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getrDrawableName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_processContactNumbers_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetProcessContactNumbers_Landroid_content_Context_Handler ()
		{
			if (cb_processContactNumbers_Landroid_content_Context_ == null)
				cb_processContactNumbers_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessContactNumbers_Landroid_content_Context_);
			return cb_processContactNumbers_Landroid_content_Context_;
		}

		static void n_ProcessContactNumbers_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessContactNumbers (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processContactNumbers_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='processContactNumbers' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("processContactNumbers", "(Landroid/content/Context;)V", "GetProcessContactNumbers_Landroid_content_Context_Handler")]
		public virtual unsafe void ProcessContactNumbers (global::Android.Content.Context p0)
		{
			if (id_processContactNumbers_Landroid_content_Context_ == IntPtr.Zero)
				id_processContactNumbers_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "processContactNumbers", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processContactNumbers_Landroid_content_Context_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processContactNumbers", "(Landroid/content/Context;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_processFullName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetProcessFullName_Ljava_lang_String_Handler ()
		{
			if (cb_processFullName_Ljava_lang_String_ == null)
				cb_processFullName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ProcessFullName_Ljava_lang_String_);
			return cb_processFullName_Ljava_lang_String_;
		}

		static void n_ProcessFullName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProcessFullName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_processFullName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='processFullName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("processFullName", "(Ljava/lang/String;)V", "GetProcessFullName_Ljava_lang_String_Handler")]
		public virtual unsafe void ProcessFullName (string p0)
		{
			if (id_processFullName_Ljava_lang_String_ == IntPtr.Zero)
				id_processFullName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "processFullName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_processFullName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "processFullName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLastSeenAt_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetLastSeenAt_Ljava_lang_Long_Handler ()
		{
			if (cb_setLastSeenAt_Ljava_lang_Long_ == null)
				cb_setLastSeenAt_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastSeenAt_Ljava_lang_Long_);
			return cb_setLastSeenAt_Ljava_lang_Long_;
		}

		static void n_SetLastSeenAt_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLastSeenAt (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastSeenAt_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='setLastSeenAt' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("setLastSeenAt", "(Ljava/lang/Long;)V", "GetSetLastSeenAt_Ljava_lang_Long_Handler")]
		public virtual unsafe void SetLastSeenAt (global::Java.Lang.Long p0)
		{
			if (id_setLastSeenAt_Ljava_lang_Long_ == IntPtr.Zero)
				id_setLastSeenAt_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setLastSeenAt", "(Ljava/lang/Long;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastSeenAt_Ljava_lang_Long_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastSeenAt", "(Ljava/lang/Long;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_toggleChecked;
#pragma warning disable 0169
		static Delegate GetToggleCheckedHandler ()
		{
			if (cb_toggleChecked == null)
				cb_toggleChecked = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ToggleChecked);
			return cb_toggleChecked;
		}

		static void n_ToggleChecked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Contact.Contact __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Contact.Contact> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ToggleChecked ();
		}
#pragma warning restore 0169

		static IntPtr id_toggleChecked;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.contact']/class[@name='Contact']/method[@name='toggleChecked' and count(parameter)=0]"
		[Register ("toggleChecked", "()V", "GetToggleCheckedHandler")]
		public virtual unsafe void ToggleChecked ()
		{
			if (id_toggleChecked == IntPtr.Zero)
				id_toggleChecked = JNIEnv.GetMethodID (class_ref, "toggleChecked", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toggleChecked);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toggleChecked", "()V"));
			} finally {
			}
		}

	}
}
