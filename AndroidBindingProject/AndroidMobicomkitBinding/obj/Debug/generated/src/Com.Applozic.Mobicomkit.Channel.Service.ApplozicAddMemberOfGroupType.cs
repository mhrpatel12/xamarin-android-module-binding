using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Channel.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/channel/service/ApplozicAddMemberOfGroupType", DoNotGenerateAcw=true)]
	public partial class ApplozicAddMemberOfGroupType : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/channel/service/ApplozicAddMemberOfGroupType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplozicAddMemberOfGroupType); }
		}

		protected ApplozicAddMemberOfGroupType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']/constructor[@name='ApplozicAddMemberOfGroupType' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplozicAddMemberOfGroupType ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApplozicAddMemberOfGroupType)) {
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
			global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupMemberList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupMemberList;
		static IntPtr id_setGroupMemberList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> GroupMemberList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']/method[@name='getGroupMemberList' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']/method[@name='setGroupMemberList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
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

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetType);
			return cb_getType;
		}

		static IntPtr n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Type);
		}
#pragma warning restore 0169

		static Delegate cb_setType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetType_Ljava_lang_String_Handler ()
		{
			if (cb_setType_Ljava_lang_String_ == null)
				cb_setType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetType_Ljava_lang_String_);
			return cb_setType_Ljava_lang_String_;
		}

		static void n_SetType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ApplozicAddMemberOfGroupType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_Ljava_lang_String_;
		public virtual unsafe string Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/String;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ApplozicAddMemberOfGroupType']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setType", "(Ljava/lang/String;)V", "GetSetType_Ljava_lang_String_Handler")]
			set {
				if (id_setType_Ljava_lang_String_ == IntPtr.Zero)
					id_setType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setType", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
