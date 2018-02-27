using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ChannelUsersFeed", DoNotGenerateAcw=true)]
	public partial class ChannelUsersFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ChannelUsersFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelUsersFeed); }
		}

		protected ChannelUsersFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/constructor[@name='ChannelUsersFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelUsersFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelUsersFeed)) {
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

		static Delegate cb_getParentGroupKey;
#pragma warning disable 0169
		static Delegate GetGetParentGroupKeyHandler ()
		{
			if (cb_getParentGroupKey == null)
				cb_getParentGroupKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentGroupKey);
			return cb_getParentGroupKey;
		}

		static IntPtr n_GetParentGroupKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParentGroupKey);
		}
#pragma warning restore 0169

		static Delegate cb_setParentGroupKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetParentGroupKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_setParentGroupKey_Ljava_lang_Integer_ == null)
				cb_setParentGroupKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParentGroupKey_Ljava_lang_Integer_);
			return cb_setParentGroupKey_Ljava_lang_Integer_;
		}

		static void n_SetParentGroupKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentGroupKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentGroupKey;
		static IntPtr id_setParentGroupKey_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ParentGroupKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='getParentGroupKey' and count(parameter)=0]"
			[Register ("getParentGroupKey", "()Ljava/lang/Integer;", "GetGetParentGroupKeyHandler")]
			get {
				if (id_getParentGroupKey == IntPtr.Zero)
					id_getParentGroupKey = JNIEnv.GetMethodID (class_ref, "getParentGroupKey", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentGroupKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentGroupKey", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='setParentGroupKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setParentGroupKey", "(Ljava/lang/Integer;)V", "GetSetParentGroupKey_Ljava_lang_Integer_Handler")]
			set {
				if (id_setParentGroupKey_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setParentGroupKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setParentGroupKey", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParentGroupKey_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentGroupKey", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRole;
#pragma warning disable 0169
		static Delegate GetGetRoleHandler ()
		{
			if (cb_getRole == null)
				cb_getRole = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRole);
			return cb_getRole;
		}

		static IntPtr n_GetRole (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Role);
		}
#pragma warning restore 0169

		static Delegate cb_setRole_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetRole_Ljava_lang_Integer_Handler ()
		{
			if (cb_setRole_Ljava_lang_Integer_ == null)
				cb_setRole_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRole_Ljava_lang_Integer_);
			return cb_setRole_Ljava_lang_Integer_;
		}

		static void n_SetRole_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Role = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRole;
		static IntPtr id_setRole_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Role {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='getRole' and count(parameter)=0]"
			[Register ("getRole", "()Ljava/lang/Integer;", "GetGetRoleHandler")]
			get {
				if (id_getRole == IntPtr.Zero)
					id_getRole = JNIEnv.GetMethodID (class_ref, "getRole", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRole), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRole", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='setRole' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setRole", "(Ljava/lang/Integer;)V", "GetSetRole_Ljava_lang_Integer_Handler")]
			set {
				if (id_setRole_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setRole_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setRole", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRole_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRole", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='getUserId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelUsersFeed']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
