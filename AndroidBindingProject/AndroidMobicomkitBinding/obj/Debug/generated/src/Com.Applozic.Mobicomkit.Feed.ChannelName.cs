using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ChannelName", DoNotGenerateAcw=true)]
	public partial class ChannelName : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ChannelName", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelName); }
		}

		protected ChannelName (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']/constructor[@name='ChannelName' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Integer;)V", "")]
		public unsafe ChannelName (string p0, global::Java.Lang.Integer p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ChannelName)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Integer_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGroupId;
#pragma warning disable 0169
		static Delegate GetGetGroupIdHandler ()
		{
			if (cb_getGroupId == null)
				cb_getGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupId);
			return cb_getGroupId;
		}

		static IntPtr n_GetGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelName __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetGroupId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setGroupId_Ljava_lang_Integer_ == null)
				cb_setGroupId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupId_Ljava_lang_Integer_);
			return cb_setGroupId_Ljava_lang_Integer_;
		}

		static void n_SetGroupId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelName __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupId;
		static IntPtr id_setGroupId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']/method[@name='getGroupId' and count(parameter)=0]"
			[Register ("getGroupId", "()Ljava/lang/Integer;", "GetGetGroupIdHandler")]
			get {
				if (id_getGroupId == IntPtr.Zero)
					id_getGroupId = JNIEnv.GetMethodID (class_ref, "getGroupId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setGroupId", "(Ljava/lang/Integer;)V", "GetSetGroupId_Ljava_lang_Integer_Handler")]
			set {
				if (id_setGroupId_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setGroupId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setGroupId", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupId_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupId", "(Ljava/lang/Integer;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNewName;
#pragma warning disable 0169
		static Delegate GetGetNewNameHandler ()
		{
			if (cb_getNewName == null)
				cb_getNewName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewName);
			return cb_getNewName;
		}

		static IntPtr n_GetNewName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelName __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewName);
		}
#pragma warning restore 0169

		static Delegate cb_setNewName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNewName_Ljava_lang_String_Handler ()
		{
			if (cb_setNewName_Ljava_lang_String_ == null)
				cb_setNewName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNewName_Ljava_lang_String_);
			return cb_setNewName_Ljava_lang_String_;
		}

		static void n_SetNewName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelName __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelName> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewName;
		static IntPtr id_setNewName_Ljava_lang_String_;
		public virtual unsafe string NewName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']/method[@name='getNewName' and count(parameter)=0]"
			[Register ("getNewName", "()Ljava/lang/String;", "GetGetNewNameHandler")]
			get {
				if (id_getNewName == IntPtr.Zero)
					id_getNewName = JNIEnv.GetMethodID (class_ref, "getNewName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelName']/method[@name='setNewName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNewName", "(Ljava/lang/String;)V", "GetSetNewName_Ljava_lang_String_Handler")]
			set {
				if (id_setNewName_Ljava_lang_String_ == IntPtr.Zero)
					id_setNewName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNewName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNewName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
