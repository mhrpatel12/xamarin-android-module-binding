using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.People {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/people/ChannelCreate", DoNotGenerateAcw=true)]
	public partial class ChannelCreate : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/people/ChannelCreate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelCreate); }
		}

		protected ChannelCreate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']/constructor[@name='ChannelCreate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe ChannelCreate (string p0, global::System.Collections.Generic.IList<string> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ChannelCreate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getGroupMemberList;
#pragma warning disable 0169
		static Delegate GetGetGroupMemberListHandler ()
		{
			if (cb_getGroupMemberList == null)
				cb_getGroupMemberList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupMemberList);
			return cb_getGroupMemberList;
		}

		static IntPtr n_GetGroupMemberList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.GroupMemberList);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupMemberList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetGroupMemberList_Ljava_util_List_Handler ()
		{
			if (cb_setGroupMemberList_Ljava_util_List_ == null)
				cb_setGroupMemberList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupMemberList_Ljava_util_List_);
			return cb_setGroupMemberList_Ljava_util_List_;
		}

		static void n_SetGroupMemberList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupMemberList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupMemberList;
		static IntPtr id_setGroupMemberList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> GroupMemberList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']/method[@name='getGroupMemberList' and count(parameter)=0]"
			[Register ("getGroupMemberList", "()Ljava/util/List;", "GetGetGroupMemberListHandler")]
			get {
				if (id_getGroupMemberList == IntPtr.Zero)
					id_getGroupMemberList = JNIEnv.GetMethodID (class_ref, "getGroupMemberList", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupMemberList), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupMemberList", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']/method[@name='setGroupMemberList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setGroupMemberList", "(Ljava/util/List;)V", "GetSetGroupMemberList_Ljava_util_List_Handler")]
			set {
				if (id_setGroupMemberList_Ljava_util_List_ == IntPtr.Zero)
					id_setGroupMemberList_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setGroupMemberList", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupMemberList_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupMemberList", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGroupName;
#pragma warning disable 0169
		static Delegate GetGetGroupNameHandler ()
		{
			if (cb_getGroupName == null)
				cb_getGroupName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupName);
			return cb_getGroupName;
		}

		static IntPtr n_GetGroupName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupName);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupName_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupName_Ljava_lang_String_ == null)
				cb_setGroupName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupName_Ljava_lang_String_);
			return cb_setGroupName_Ljava_lang_String_;
		}

		static void n_SetGroupName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelCreate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupName;
		static IntPtr id_setGroupName_Ljava_lang_String_;
		public virtual unsafe string GroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']/method[@name='getGroupName' and count(parameter)=0]"
			[Register ("getGroupName", "()Ljava/lang/String;", "GetGetGroupNameHandler")]
			get {
				if (id_getGroupName == IntPtr.Zero)
					id_getGroupName = JNIEnv.GetMethodID (class_ref, "getGroupName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelCreate']/method[@name='setGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupName", "(Ljava/lang/String;)V", "GetSetGroupName_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupName_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
