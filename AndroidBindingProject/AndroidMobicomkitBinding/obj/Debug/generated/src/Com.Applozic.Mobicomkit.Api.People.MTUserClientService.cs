using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.People {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='MTUserClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/people/MTUserClientService", DoNotGenerateAcw=true)]
	public partial class MTUserClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/people/MTUserClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MTUserClientService); }
		}

		protected MTUserClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='MTUserClientService']/constructor[@name='MTUserClientService' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MTUserClientService (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MTUserClientService)) {
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

		static Delegate cb_getCheckForMtUser;
#pragma warning disable 0169
		static Delegate GetGetCheckForMtUserHandler ()
		{
			if (cb_getCheckForMtUser == null)
				cb_getCheckForMtUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCheckForMtUser);
			return cb_getCheckForMtUser;
		}

		static IntPtr n_GetCheckForMtUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.MTUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.MTUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CheckForMtUser);
		}
#pragma warning restore 0169

		static IntPtr id_getCheckForMtUser;
		public virtual unsafe string CheckForMtUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='MTUserClientService']/method[@name='getCheckForMtUser' and count(parameter)=0]"
			[Register ("getCheckForMtUser", "()Ljava/lang/String;", "GetGetCheckForMtUserHandler")]
			get {
				if (id_getCheckForMtUser == IntPtr.Zero)
					id_getCheckForMtUser = JNIEnv.GetMethodID (class_ref, "getCheckForMtUser", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCheckForMtUser), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCheckForMtUser", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContactContent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetContactContent_Ljava_lang_String_Handler ()
		{
			if (cb_getContactContent_Ljava_lang_String_ == null)
				cb_getContactContent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetContactContent_Ljava_lang_String_);
			return cb_getContactContent_Ljava_lang_String_;
		}

		static IntPtr n_GetContactContent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.MTUserClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.MTUserClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetContactContent (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getContactContent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='MTUserClientService']/method[@name='getContactContent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getContactContent", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/people/ContactContent;", "GetGetContactContent_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Api.People.ContactContent GetContactContent (string p0)
		{
			if (id_getContactContent_Ljava_lang_String_ == IntPtr.Zero)
				id_getContactContent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getContactContent", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/people/ContactContent;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Api.People.ContactContent __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ContactContent> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactContent_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ContactContent> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactContent", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/api/people/ContactContent;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
