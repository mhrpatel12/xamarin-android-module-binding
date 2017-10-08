using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Sync {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/sync/SyncUserBlockListFeed", DoNotGenerateAcw=true)]
	public partial class SyncUserBlockListFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/sync/SyncUserBlockListFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SyncUserBlockListFeed); }
		}

		protected SyncUserBlockListFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']/constructor[@name='SyncUserBlockListFeed' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncUserBlockListFeed ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (SyncUserBlockListFeed)) {
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

		static Delegate cb_getBlockedByUserList;
#pragma warning disable 0169
		static Delegate GetGetBlockedByUserListHandler ()
		{
			if (cb_getBlockedByUserList == null)
				cb_getBlockedByUserList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockedByUserList);
			return cb_getBlockedByUserList;
		}

		static IntPtr n_GetBlockedByUserList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.ToLocalJniHandle (__this.BlockedByUserList);
		}
#pragma warning restore 0169

		static Delegate cb_setBlockedByUserList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBlockedByUserList_Ljava_util_List_Handler ()
		{
			if (cb_setBlockedByUserList_Ljava_util_List_ == null)
				cb_setBlockedByUserList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBlockedByUserList_Ljava_util_List_);
			return cb_setBlockedByUserList_Ljava_util_List_;
		}

		static void n_SetBlockedByUserList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BlockedByUserList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockedByUserList;
		static IntPtr id_setBlockedByUserList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> BlockedByUserList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']/method[@name='getBlockedByUserList' and count(parameter)=0]"
			[Register ("getBlockedByUserList", "()Ljava/util/List;", "GetGetBlockedByUserListHandler")]
			get {
				if (id_getBlockedByUserList == IntPtr.Zero)
					id_getBlockedByUserList = JNIEnv.GetMethodID (class_ref, "getBlockedByUserList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockedByUserList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockedByUserList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']/method[@name='setBlockedByUserList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.sync.SyncUserBlockFeed&gt;']]"
			[Register ("setBlockedByUserList", "(Ljava/util/List;)V", "GetSetBlockedByUserList_Ljava_util_List_Handler")]
			set {
				if (id_setBlockedByUserList_Ljava_util_List_ == IntPtr.Zero)
					id_setBlockedByUserList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setBlockedByUserList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockedByUserList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockedByUserList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBlockedToUserList;
#pragma warning disable 0169
		static Delegate GetGetBlockedToUserListHandler ()
		{
			if (cb_getBlockedToUserList == null)
				cb_getBlockedToUserList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBlockedToUserList);
			return cb_getBlockedToUserList;
		}

		static IntPtr n_GetBlockedToUserList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.ToLocalJniHandle (__this.BlockedToUserList);
		}
#pragma warning restore 0169

		static Delegate cb_setBlockedToUserList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetBlockedToUserList_Ljava_util_List_Handler ()
		{
			if (cb_setBlockedToUserList_Ljava_util_List_ == null)
				cb_setBlockedToUserList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBlockedToUserList_Ljava_util_List_);
			return cb_setBlockedToUserList_Ljava_util_List_;
		}

		static void n_SetBlockedToUserList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockListFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BlockedToUserList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBlockedToUserList;
		static IntPtr id_setBlockedToUserList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed> BlockedToUserList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']/method[@name='getBlockedToUserList' and count(parameter)=0]"
			[Register ("getBlockedToUserList", "()Ljava/util/List;", "GetGetBlockedToUserListHandler")]
			get {
				if (id_getBlockedToUserList == IntPtr.Zero)
					id_getBlockedToUserList = JNIEnv.GetMethodID (class_ref, "getBlockedToUserList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBlockedToUserList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBlockedToUserList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.sync']/class[@name='SyncUserBlockListFeed']/method[@name='setBlockedToUserList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.sync.SyncUserBlockFeed&gt;']]"
			[Register ("setBlockedToUserList", "(Ljava/util/List;)V", "GetSetBlockedToUserList_Ljava_util_List_Handler")]
			set {
				if (id_setBlockedToUserList_Ljava_util_List_ == IntPtr.Zero)
					id_setBlockedToUserList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setBlockedToUserList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Sync.SyncUserBlockFeed>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockedToUserList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockedToUserList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
