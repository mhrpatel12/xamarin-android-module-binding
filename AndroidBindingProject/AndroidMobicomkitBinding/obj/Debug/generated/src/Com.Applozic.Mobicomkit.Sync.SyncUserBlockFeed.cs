using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/sync/SyncUserBlockFeed", DoNotGenerateAcw=true)]
	public partial class SyncUserBlockFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/sync/SyncUserBlockFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncUserBlockFeed); }
		}

		protected SyncUserBlockFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/constructor[@name='SyncUserBlockFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncUserBlockFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SyncUserBlockFeed)) {
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

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationKey_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationKey_Ljava_lang_String_ == null)
				cb_setApplicationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationKey_Ljava_lang_String_);
			return cb_setApplicationKey_Ljava_lang_String_;
		}

		static void n_SetApplicationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		static IntPtr id_setApplicationKey_Ljava_lang_String_;
		public virtual unsafe string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setApplicationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationKey", "(Ljava/lang/String;)V", "GetSetApplicationKey_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBlockedBy;
#pragma warning disable 0169
		static Delegate GetGetBlockedByHandler ()
		{
			if (cb_getBlockedBy == null)
				cb_getBlockedBy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockedBy);
			return cb_getBlockedBy;
		}

		static IntPtr n_GetBlockedBy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BlockedBy);
		}
#pragma warning restore 0169

		static Delegate cb_setBlockedBy_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBlockedBy_Ljava_lang_String_Handler ()
		{
			if (cb_setBlockedBy_Ljava_lang_String_ == null)
				cb_setBlockedBy_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBlockedBy_Ljava_lang_String_);
			return cb_setBlockedBy_Ljava_lang_String_;
		}

		static void n_SetBlockedBy_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BlockedBy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockedBy;
		static IntPtr id_setBlockedBy_Ljava_lang_String_;
		public virtual unsafe string BlockedBy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getBlockedBy' and count(parameter)=0]"
			[Register ("getBlockedBy", "()Ljava/lang/String;", "GetGetBlockedByHandler")]
			get {
				if (id_getBlockedBy == IntPtr.Zero)
					id_getBlockedBy = JNIEnv.GetMethodID (class_ref, "getBlockedBy", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockedBy), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockedBy", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setBlockedBy' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBlockedBy", "(Ljava/lang/String;)V", "GetSetBlockedBy_Ljava_lang_String_Handler")]
			set {
				if (id_setBlockedBy_Ljava_lang_String_ == IntPtr.Zero)
					id_setBlockedBy_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBlockedBy", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockedBy_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockedBy", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBlockedTo;
#pragma warning disable 0169
		static Delegate GetGetBlockedToHandler ()
		{
			if (cb_getBlockedTo == null)
				cb_getBlockedTo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockedTo);
			return cb_getBlockedTo;
		}

		static IntPtr n_GetBlockedTo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BlockedTo);
		}
#pragma warning restore 0169

		static Delegate cb_setBlockedTo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBlockedTo_Ljava_lang_String_Handler ()
		{
			if (cb_setBlockedTo_Ljava_lang_String_ == null)
				cb_setBlockedTo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBlockedTo_Ljava_lang_String_);
			return cb_setBlockedTo_Ljava_lang_String_;
		}

		static void n_SetBlockedTo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BlockedTo = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockedTo;
		static IntPtr id_setBlockedTo_Ljava_lang_String_;
		public virtual unsafe string BlockedTo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getBlockedTo' and count(parameter)=0]"
			[Register ("getBlockedTo", "()Ljava/lang/String;", "GetGetBlockedToHandler")]
			get {
				if (id_getBlockedTo == IntPtr.Zero)
					id_getBlockedTo = JNIEnv.GetMethodID (class_ref, "getBlockedTo", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockedTo), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockedTo", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setBlockedTo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBlockedTo", "(Ljava/lang/String;)V", "GetSetBlockedTo_Ljava_lang_String_Handler")]
			set {
				if (id_setBlockedTo_Ljava_lang_String_ == IntPtr.Zero)
					id_setBlockedTo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBlockedTo", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockedTo_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockedTo", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCreatedAtTime;
#pragma warning disable 0169
		static Delegate GetGetCreatedAtTimeHandler ()
		{
			if (cb_getCreatedAtTime == null)
				cb_getCreatedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreatedAtTime);
			return cb_getCreatedAtTime;
		}

		static IntPtr n_GetCreatedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreatedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setCreatedAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCreatedAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setCreatedAtTime_Ljava_lang_Long_ == null)
				cb_setCreatedAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreatedAtTime_Ljava_lang_Long_);
			return cb_setCreatedAtTime_Ljava_lang_Long_;
		}

		static void n_SetCreatedAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreatedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreatedAtTime;
		static IntPtr id_setCreatedAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long CreatedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getCreatedAtTime' and count(parameter)=0]"
			[Register ("getCreatedAtTime", "()Ljava/lang/Long;", "GetGetCreatedAtTimeHandler")]
			get {
				if (id_getCreatedAtTime == IntPtr.Zero)
					id_getCreatedAtTime = JNIEnv.GetMethodID (class_ref, "getCreatedAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreatedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreatedAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setCreatedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCreatedAtTime", "(Ljava/lang/Long;)V", "GetSetCreatedAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setCreatedAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setCreatedAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setCreatedAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreatedAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreatedAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUpdatedAtTime;
#pragma warning disable 0169
		static Delegate GetGetUpdatedAtTimeHandler ()
		{
			if (cb_getUpdatedAtTime == null)
				cb_getUpdatedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUpdatedAtTime);
			return cb_getUpdatedAtTime;
		}

		static IntPtr n_GetUpdatedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UpdatedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setUpdatedAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetUpdatedAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setUpdatedAtTime_Ljava_lang_Long_ == null)
				cb_setUpdatedAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUpdatedAtTime_Ljava_lang_Long_);
			return cb_setUpdatedAtTime_Ljava_lang_Long_;
		}

		static void n_SetUpdatedAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdatedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUpdatedAtTime;
		static IntPtr id_setUpdatedAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long UpdatedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getUpdatedAtTime' and count(parameter)=0]"
			[Register ("getUpdatedAtTime", "()Ljava/lang/Long;", "GetGetUpdatedAtTimeHandler")]
			get {
				if (id_getUpdatedAtTime == IntPtr.Zero)
					id_getUpdatedAtTime = JNIEnv.GetMethodID (class_ref, "getUpdatedAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUpdatedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUpdatedAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setUpdatedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setUpdatedAtTime", "(Ljava/lang/Long;)V", "GetSetUpdatedAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setUpdatedAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setUpdatedAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setUpdatedAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpdatedAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpdatedAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserBlocked;
#pragma warning disable 0169
		static Delegate GetGetUserBlockedHandler ()
		{
			if (cb_getUserBlocked == null)
				cb_getUserBlocked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserBlocked);
			return cb_getUserBlocked;
		}

		static IntPtr n_GetUserBlocked (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UserBlocked);
		}
#pragma warning restore 0169

		static Delegate cb_setUserBlocked_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetSetUserBlocked_Ljava_lang_Boolean_Handler ()
		{
			if (cb_setUserBlocked_Ljava_lang_Boolean_ == null)
				cb_setUserBlocked_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserBlocked_Ljava_lang_Boolean_);
			return cb_setUserBlocked_Ljava_lang_Boolean_;
		}

		static void n_SetUserBlocked_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Boolean p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserBlocked = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserBlocked;
		static IntPtr id_setUserBlocked_Ljava_lang_Boolean_;
		public virtual unsafe global::Java.Lang.Boolean UserBlocked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='getUserBlocked' and count(parameter)=0]"
			[Register ("getUserBlocked", "()Ljava/lang/Boolean;", "GetGetUserBlockedHandler")]
			get {
				if (id_getUserBlocked == IntPtr.Zero)
					id_getUserBlocked = JNIEnv.GetMethodID (class_ref, "getUserBlocked", "()Ljava/lang/Boolean;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserBlocked), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserBlocked", "()Ljava/lang/Boolean;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockFeed']/method[@name='setUserBlocked' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
			[Register ("setUserBlocked", "(Ljava/lang/Boolean;)V", "GetSetUserBlocked_Ljava_lang_Boolean_Handler")]
			set {
				if (id_setUserBlocked_Ljava_lang_Boolean_ == IntPtr.Zero)
					id_setUserBlocked_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "setUserBlocked", "(Ljava/lang/Boolean;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserBlocked_Ljava_lang_Boolean_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserBlocked", "(Ljava/lang/Boolean;)V"), __args);
				} finally {
				}
			}
		}

	}
}
