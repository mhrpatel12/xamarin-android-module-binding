using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/RegisteredUsersApiResponse", DoNotGenerateAcw=true)]
	public partial class RegisteredUsersApiResponse : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/RegisteredUsersApiResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RegisteredUsersApiResponse); }
		}

		protected RegisteredUsersApiResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/constructor[@name='RegisteredUsersApiResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RegisteredUsersApiResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (RegisteredUsersApiResponse)) {
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

		static Delegate cb_getLastFetchTime;
#pragma warning disable 0169
		static Delegate GetGetLastFetchTimeHandler ()
		{
			if (cb_getLastFetchTime == null)
				cb_getLastFetchTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetLastFetchTime);
			return cb_getLastFetchTime;
		}

		static long n_GetLastFetchTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastFetchTime;
		}
#pragma warning restore 0169

		static Delegate cb_setLastFetchTime_J;
#pragma warning disable 0169
		static Delegate GetSetLastFetchTime_JHandler ()
		{
			if (cb_setLastFetchTime_J == null)
				cb_setLastFetchTime_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetLastFetchTime_J);
			return cb_setLastFetchTime_J;
		}

		static void n_SetLastFetchTime_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastFetchTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastFetchTime;
		static IntPtr id_setLastFetchTime_J;
		public virtual unsafe long LastFetchTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='getLastFetchTime' and count(parameter)=0]"
			[Register ("getLastFetchTime", "()J", "GetGetLastFetchTimeHandler")]
			get {
				if (id_getLastFetchTime == IntPtr.Zero)
					id_getLastFetchTime = JNIEnv.GetMethodID (class_ref, "getLastFetchTime", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getLastFetchTime);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastFetchTime", "()J"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='setLastFetchTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setLastFetchTime", "(J)V", "GetSetLastFetchTime_JHandler")]
			set {
				if (id_setLastFetchTime_J == IntPtr.Zero)
					id_setLastFetchTime_J = JNIEnv.GetMethodID (class_ref, "setLastFetchTime", "(J)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastFetchTime_J, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastFetchTime", "(J)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalUnreadCount;
#pragma warning disable 0169
		static Delegate GetGetTotalUnreadCountHandler ()
		{
			if (cb_getTotalUnreadCount == null)
				cb_getTotalUnreadCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTotalUnreadCount);
			return cb_getTotalUnreadCount;
		}

		static IntPtr n_GetTotalUnreadCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TotalUnreadCount);
		}
#pragma warning restore 0169

		static Delegate cb_setTotalUnreadCount_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetTotalUnreadCount_Ljava_lang_Integer_Handler ()
		{
			if (cb_setTotalUnreadCount_Ljava_lang_Integer_ == null)
				cb_setTotalUnreadCount_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTotalUnreadCount_Ljava_lang_Integer_);
			return cb_setTotalUnreadCount_Ljava_lang_Integer_;
		}

		static void n_SetTotalUnreadCount_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TotalUnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalUnreadCount;
		static IntPtr id_setTotalUnreadCount_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer TotalUnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='getTotalUnreadCount' and count(parameter)=0]"
			[Register ("getTotalUnreadCount", "()Ljava/lang/Integer;", "GetGetTotalUnreadCountHandler")]
			get {
				if (id_getTotalUnreadCount == IntPtr.Zero)
					id_getTotalUnreadCount = JNIEnv.GetMethodID (class_ref, "getTotalUnreadCount", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTotalUnreadCount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalUnreadCount", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='setTotalUnreadCount' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setTotalUnreadCount", "(Ljava/lang/Integer;)V", "GetSetTotalUnreadCount_Ljava_lang_Integer_Handler")]
			set {
				if (id_setTotalUnreadCount_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setTotalUnreadCount_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setTotalUnreadCount", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTotalUnreadCount_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTotalUnreadCount", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUsers;
#pragma warning disable 0169
		static Delegate GetGetUsersHandler ()
		{
			if (cb_getUsers == null)
				cb_getUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsers);
			return cb_getUsers;
		}

		static IntPtr n_GetUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.ToLocalJniHandle (__this.Users);
		}
#pragma warning restore 0169

		static Delegate cb_setUsers_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetUsers_Ljava_util_Set_Handler ()
		{
			if (cb_setUsers_Ljava_util_Set_ == null)
				cb_setUsers_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsers_Ljava_util_Set_);
			return cb_setUsers_Ljava_util_Set_;
		}

		static void n_SetUsers_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.RegisteredUsersApiResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Users = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsers;
		static IntPtr id_setUsers_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> Users {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='getUsers' and count(parameter)=0]"
			[Register ("getUsers", "()Ljava/util/Set;", "GetGetUsersHandler")]
			get {
				if (id_getUsers == IntPtr.Zero)
					id_getUsers = JNIEnv.GetMethodID (class_ref, "getUsers", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsers", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='RegisteredUsersApiResponse']/method[@name='setUsers' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.applozic.mobicomkit.api.account.user.UserDetail&gt;']]"
			[Register ("setUsers", "(Ljava/util/Set;)V", "GetSetUsers_Ljava_util_Set_Handler")]
			set {
				if (id_setUsers_Ljava_util_Set_ == IntPtr.Zero)
					id_setUsers_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setUsers", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUsers_Ljava_util_Set_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsers", "(Ljava/util/Set;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
