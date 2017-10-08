using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Contact {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/contact/VCFContactData", DoNotGenerateAcw=true)]
	public partial class VCFContactData : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/contact/VCFContactData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (VCFContactData); }
		}

		protected VCFContactData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/constructor[@name='VCFContactData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VCFContactData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (VCFContactData)) {
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

		static Delegate cb_getEmail;
#pragma warning disable 0169
		static Delegate GetGetEmailHandler ()
		{
			if (cb_getEmail == null)
				cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
			return cb_getEmail;
		}

		static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Email);
		}
#pragma warning restore 0169

		static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEmail_Ljava_lang_String_Handler ()
		{
			if (cb_setEmail_Ljava_lang_String_ == null)
				cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
			return cb_setEmail_Ljava_lang_String_;
		}

		static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Email = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEmail;
		static IntPtr id_setEmail_Ljava_lang_String_;
		public virtual unsafe string Email {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='getEmail' and count(parameter)=0]"
			[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
			get {
				if (id_getEmail == IntPtr.Zero)
					id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
			set {
				if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
					id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isValid;
#pragma warning disable 0169
		static Delegate GetIsValidHandler ()
		{
			if (cb_isValid == null)
				cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
			return cb_isValid;
		}

		static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValid;
		}
#pragma warning restore 0169

		static IntPtr id_isValid;
		public virtual unsafe bool IsValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='isValid' and count(parameter)=0]"
			[Register ("isValid", "()Z", "GetIsValidHandler")]
			get {
				if (id_isValid == IntPtr.Zero)
					id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProfilePic;
#pragma warning disable 0169
		static Delegate GetGetProfilePicHandler ()
		{
			if (cb_getProfilePic == null)
				cb_getProfilePic = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProfilePic);
			return cb_getProfilePic;
		}

		static IntPtr n_GetProfilePic (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ProfilePic);
		}
#pragma warning restore 0169

		static Delegate cb_setProfilePic_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetProfilePic_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setProfilePic_Landroid_graphics_Bitmap_ == null)
				cb_setProfilePic_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProfilePic_Landroid_graphics_Bitmap_);
			return cb_setProfilePic_Landroid_graphics_Bitmap_;
		}

		static void n_SetProfilePic_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ProfilePic = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getProfilePic;
		static IntPtr id_setProfilePic_Landroid_graphics_Bitmap_;
		public virtual unsafe global::Android.Graphics.Bitmap ProfilePic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='getProfilePic' and count(parameter)=0]"
			[Register ("getProfilePic", "()Landroid/graphics/Bitmap;", "GetGetProfilePicHandler")]
			get {
				if (id_getProfilePic == IntPtr.Zero)
					id_getProfilePic = JNIEnv.GetMethodID (class_ref, "getProfilePic", "()Landroid/graphics/Bitmap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProfilePic), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProfilePic", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='setProfilePic' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setProfilePic", "(Landroid/graphics/Bitmap;)V", "GetSetProfilePic_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setProfilePic_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setProfilePic_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setProfilePic", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setProfilePic_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setProfilePic", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTelephoneNumber;
#pragma warning disable 0169
		static Delegate GetGetTelephoneNumberHandler ()
		{
			if (cb_getTelephoneNumber == null)
				cb_getTelephoneNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTelephoneNumber);
			return cb_getTelephoneNumber;
		}

		static IntPtr n_GetTelephoneNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TelephoneNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setTelephoneNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTelephoneNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setTelephoneNumber_Ljava_lang_String_ == null)
				cb_setTelephoneNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTelephoneNumber_Ljava_lang_String_);
			return cb_setTelephoneNumber_Ljava_lang_String_;
		}

		static void n_SetTelephoneNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Contact.VCFContactData __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Contact.VCFContactData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TelephoneNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTelephoneNumber;
		static IntPtr id_setTelephoneNumber_Ljava_lang_String_;
		public virtual unsafe string TelephoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='getTelephoneNumber' and count(parameter)=0]"
			[Register ("getTelephoneNumber", "()Ljava/lang/String;", "GetGetTelephoneNumberHandler")]
			get {
				if (id_getTelephoneNumber == IntPtr.Zero)
					id_getTelephoneNumber = JNIEnv.GetMethodID (class_ref, "getTelephoneNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTelephoneNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTelephoneNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.contact']/class[@name='VCFContactData']/method[@name='setTelephoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTelephoneNumber", "(Ljava/lang/String;)V", "GetSetTelephoneNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setTelephoneNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setTelephoneNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTelephoneNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTelephoneNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTelephoneNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
