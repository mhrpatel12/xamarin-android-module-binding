using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/ChannelUserMapper", DoNotGenerateAcw=true)]
	public partial class ChannelUserMapper : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/ChannelUserMapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelUserMapper); }
		}

		protected ChannelUserMapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/constructor[@name='ChannelUserMapper' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe ChannelUserMapper (global::Java.Lang.Integer p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ChannelUserMapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/constructor[@name='ChannelUserMapper' and count(parameter)=3 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;I)V", "")]
		public unsafe ChannelUserMapper (global::Java.Lang.Integer p0, string p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ChannelUserMapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/constructor[@name='ChannelUserMapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelUserMapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelUserMapper)) {
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

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Key);
		}
#pragma warning restore 0169

		static Delegate cb_setKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_setKey_Ljava_lang_Integer_ == null)
				cb_setKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetKey_Ljava_lang_Integer_);
			return cb_setKey_Ljava_lang_Integer_;
		}

		static void n_SetKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Key = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getKey;
		static IntPtr id_setKey_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/Integer;", "GetGetKeyHandler")]
			get {
				if (id_getKey == IntPtr.Zero)
					id_getKey = JNIEnv.GetMethodID (class_ref, "getKey", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKey", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='setKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setKey", "(Ljava/lang/Integer;)V", "GetSetKey_Ljava_lang_Integer_Handler")]
			set {
				if (id_setKey_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setKey", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setKey_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setKey", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetStatus);
			return cb_getStatus;
		}

		static short n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Status;
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_S;
#pragma warning disable 0169
		static Delegate GetSetStatus_SHandler ()
		{
			if (cb_setStatus_S == null)
				cb_setStatus_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetStatus_S);
			return cb_setStatus_S;
		}

		static void n_SetStatus_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_S;
		public virtual unsafe short Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()S", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getStatus);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()S"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setStatus", "(S)V", "GetSetStatus_SHandler")]
			set {
				if (id_setStatus_S == IntPtr.Zero)
					id_setStatus_S = JNIEnv.GetMethodID (class_ref, "setStatus", "(S)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_S, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(S)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetUnreadCountHandler ()
		{
			if (cb_getUnreadCount == null)
				cb_getUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUnreadCount);
			return cb_getUnreadCount;
		}

		static int n_GetUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UnreadCount;
		}
#pragma warning restore 0169

		static Delegate cb_setUnreadCount_I;
#pragma warning disable 0169
		static Delegate GetSetUnreadCount_IHandler ()
		{
			if (cb_setUnreadCount_I == null)
				cb_setUnreadCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUnreadCount_I);
			return cb_setUnreadCount_I;
		}

		static void n_SetUnreadCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_I;
		public virtual unsafe int UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='getUnreadCount' and count(parameter)=0]"
			[Register ("getUnreadCount", "()I", "GetGetUnreadCountHandler")]
			get {
				if (id_getUnreadCount == IntPtr.Zero)
					id_getUnreadCount = JNIEnv.GetMethodID (class_ref, "getUnreadCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUnreadCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnreadCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUnreadCount", "(I)V", "GetSetUnreadCount_IHandler")]
			set {
				if (id_setUnreadCount_I == IntPtr.Zero)
					id_setUnreadCount_I = JNIEnv.GetMethodID (class_ref, "setUnreadCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUnreadCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnreadCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserKey;
#pragma warning disable 0169
		static Delegate GetGetUserKeyHandler ()
		{
			if (cb_getUserKey == null)
				cb_getUserKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserKey);
			return cb_getUserKey;
		}

		static IntPtr n_GetUserKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserKey);
		}
#pragma warning restore 0169

		static Delegate cb_setUserKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserKey_Ljava_lang_String_Handler ()
		{
			if (cb_setUserKey_Ljava_lang_String_ == null)
				cb_setUserKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserKey_Ljava_lang_String_);
			return cb_setUserKey_Ljava_lang_String_;
		}

		static void n_SetUserKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelUserMapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserKey;
		static IntPtr id_setUserKey_Ljava_lang_String_;
		public virtual unsafe string UserKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='getUserKey' and count(parameter)=0]"
			[Register ("getUserKey", "()Ljava/lang/String;", "GetGetUserKeyHandler")]
			get {
				if (id_getUserKey == IntPtr.Zero)
					id_getUserKey = JNIEnv.GetMethodID (class_ref, "getUserKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelUserMapper']/method[@name='setUserKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserKey", "(Ljava/lang/String;)V", "GetSetUserKey_Ljava_lang_String_Handler")]
			set {
				if (id_setUserKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
