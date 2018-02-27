using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/UserDetailListFeed", DoNotGenerateAcw=true)]
	public partial class UserDetailListFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/UserDetailListFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UserDetailListFeed); }
		}

		protected UserDetailListFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/constructor[@name='UserDetailListFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UserDetailListFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UserDetailListFeed)) {
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

		static Delegate cb_isContactSync;
#pragma warning disable 0169
		static Delegate GetIsContactSyncHandler ()
		{
			if (cb_isContactSync == null)
				cb_isContactSync = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsContactSync);
			return cb_isContactSync;
		}

		static bool n_IsContactSync (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContactSync;
		}
#pragma warning restore 0169

		static Delegate cb_setContactSync_Z;
#pragma warning disable 0169
		static Delegate GetSetContactSync_ZHandler ()
		{
			if (cb_setContactSync_Z == null)
				cb_setContactSync_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetContactSync_Z);
			return cb_setContactSync_Z;
		}

		static void n_SetContactSync_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ContactSync = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isContactSync;
		static IntPtr id_setContactSync_Z;
		public virtual unsafe bool ContactSync {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='isContactSync' and count(parameter)=0]"
			[Register ("isContactSync", "()Z", "GetIsContactSyncHandler")]
			get {
				if (id_isContactSync == IntPtr.Zero)
					id_isContactSync = JNIEnv.GetMethodID (class_ref, "isContactSync", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isContactSync);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isContactSync", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='setContactSync' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setContactSync", "(Z)V", "GetSetContactSync_ZHandler")]
			set {
				if (id_setContactSync_Z == IntPtr.Zero)
					id_setContactSync_Z = JNIEnv.GetMethodID (class_ref, "setContactSync", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactSync_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactSync", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPhoneNumberList;
#pragma warning disable 0169
		static Delegate GetGetPhoneNumberListHandler ()
		{
			if (cb_getPhoneNumberList == null)
				cb_getPhoneNumberList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPhoneNumberList);
			return cb_getPhoneNumberList;
		}

		static IntPtr n_GetPhoneNumberList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PhoneNumberList);
		}
#pragma warning restore 0169

		static Delegate cb_setPhoneNumberList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPhoneNumberList_Ljava_util_List_Handler ()
		{
			if (cb_setPhoneNumberList_Ljava_util_List_ == null)
				cb_setPhoneNumberList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPhoneNumberList_Ljava_util_List_);
			return cb_setPhoneNumberList_Ljava_util_List_;
		}

		static void n_SetPhoneNumberList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PhoneNumberList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPhoneNumberList;
		static IntPtr id_setPhoneNumberList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> PhoneNumberList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='getPhoneNumberList' and count(parameter)=0]"
			[Register ("getPhoneNumberList", "()Ljava/util/List;", "GetGetPhoneNumberListHandler")]
			get {
				if (id_getPhoneNumberList == IntPtr.Zero)
					id_getPhoneNumberList = JNIEnv.GetMethodID (class_ref, "getPhoneNumberList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPhoneNumberList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPhoneNumberList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='setPhoneNumberList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setPhoneNumberList", "(Ljava/util/List;)V", "GetSetPhoneNumberList_Ljava_util_List_Handler")]
			set {
				if (id_setPhoneNumberList_Ljava_util_List_ == IntPtr.Zero)
					id_setPhoneNumberList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setPhoneNumberList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhoneNumberList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhoneNumberList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserIdList;
#pragma warning disable 0169
		static Delegate GetGetUserIdListHandler ()
		{
			if (cb_getUserIdList == null)
				cb_getUserIdList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserIdList);
			return cb_getUserIdList;
		}

		static IntPtr n_GetUserIdList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.UserIdList);
		}
#pragma warning restore 0169

		static Delegate cb_setUserIdList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUserIdList_Ljava_util_List_Handler ()
		{
			if (cb_setUserIdList_Ljava_util_List_ == null)
				cb_setUserIdList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserIdList_Ljava_util_List_);
			return cb_setUserIdList_Ljava_util_List_;
		}

		static void n_SetUserIdList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.UserDetailListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserIdList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserIdList;
		static IntPtr id_setUserIdList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> UserIdList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='getUserIdList' and count(parameter)=0]"
			[Register ("getUserIdList", "()Ljava/util/List;", "GetGetUserIdListHandler")]
			get {
				if (id_getUserIdList == IntPtr.Zero)
					id_getUserIdList = JNIEnv.GetMethodID (class_ref, "getUserIdList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserIdList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserIdList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='UserDetailListFeed']/method[@name='setUserIdList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setUserIdList", "(Ljava/util/List;)V", "GetSetUserIdList_Ljava_util_List_Handler")]
			set {
				if (id_setUserIdList_Ljava_util_List_ == IntPtr.Zero)
					id_setUserIdList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setUserIdList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserIdList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserIdList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
