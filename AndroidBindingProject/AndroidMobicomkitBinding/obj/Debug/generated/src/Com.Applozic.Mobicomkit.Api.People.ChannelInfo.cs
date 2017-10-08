using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.People {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/people/ChannelInfo", DoNotGenerateAcw=true)]
	public partial class ChannelInfo : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/people/ChannelInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelInfo); }
		}

		protected ChannelInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/constructor[@name='ChannelInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public unsafe ChannelInfo (string p0, global::System.Collections.Generic.IList<string> p1)
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
				if (((object) this).GetType () != typeof (ChannelInfo)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/constructor[@name='ChannelInfo' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe ChannelInfo (string p0, global::System.Collections.Generic.IList<string> p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (ChannelInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getChannelMetadata;
#pragma warning disable 0169
		static Delegate GetGetChannelMetadataHandler ()
		{
			if (cb_getChannelMetadata == null)
				cb_getChannelMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelMetadata);
			return cb_getChannelMetadata;
		}

		static IntPtr n_GetChannelMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChannelMetadata);
		}
#pragma warning restore 0169

		static Delegate cb_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_;
#pragma warning disable 0169
		static Delegate GetSetChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_Handler ()
		{
			if (cb_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_ == null)
				cb_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_);
			return cb_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_;
		}

		static void n_SetChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChannelMetadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelMetadata;
		static IntPtr id_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata ChannelMetadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getChannelMetadata' and count(parameter)=0]"
			[Register ("getChannelMetadata", "()Lcom/applozic/mobicommons/people/channel/ChannelMetadata;", "GetGetChannelMetadataHandler")]
			get {
				if (id_getChannelMetadata == IntPtr.Zero)
					id_getChannelMetadata = JNIEnv.GetMethodID (class_ref, "getChannelMetadata", "()Lcom/applozic/mobicommons/people/channel/ChannelMetadata;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelMetadata", "()Lcom/applozic/mobicommons/people/channel/ChannelMetadata;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setChannelMetadata' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.ChannelMetadata']]"
			[Register ("setChannelMetadata", "(Lcom/applozic/mobicommons/people/channel/ChannelMetadata;)V", "GetSetChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_Handler")]
			set {
				if (id_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_ == IntPtr.Zero)
					id_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_ = JNIEnv.GetMethodID (class_ref, "setChannelMetadata", "(Lcom/applozic/mobicommons/people/channel/ChannelMetadata;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChannelMetadata_Lcom_applozic_mobicommons_people_channel_ChannelMetadata_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChannelMetadata", "(Lcom/applozic/mobicommons/people/channel/ChannelMetadata;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getClientGroupId;
#pragma warning disable 0169
		static Delegate GetGetClientGroupIdHandler ()
		{
			if (cb_getClientGroupId == null)
				cb_getClientGroupId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClientGroupId);
			return cb_getClientGroupId;
		}

		static IntPtr n_GetClientGroupId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientGroupId);
		}
#pragma warning restore 0169

		static Delegate cb_setClientGroupId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientGroupId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientGroupId_Ljava_lang_String_ == null)
				cb_setClientGroupId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetClientGroupId_Ljava_lang_String_);
			return cb_setClientGroupId_Ljava_lang_String_;
		}

		static void n_SetClientGroupId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getClientGroupId' and count(parameter)=0]"
			[Register ("getClientGroupId", "()Ljava/lang/String;", "GetGetClientGroupIdHandler")]
			get {
				if (id_getClientGroupId == IntPtr.Zero)
					id_getClientGroupId = JNIEnv.GetMethodID (class_ref, "getClientGroupId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getClientGroupId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getClientGroupId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientGroupId", "(Ljava/lang/String;)V", "GetSetClientGroupId_Ljava_lang_String_Handler")]
			set {
				if (id_setClientGroupId_Ljava_lang_String_ == IntPtr.Zero)
					id_setClientGroupId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setClientGroupId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClientGroupId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClientGroupId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupMemberList = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupMemberList;
		static IntPtr id_setGroupMemberList_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> GroupMemberList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getGroupMemberList' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setGroupMemberList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
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
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupName;
		static IntPtr id_setGroupName_Ljava_lang_String_;
		public virtual unsafe string GroupName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getGroupName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setGroupName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getImageUrl;
#pragma warning disable 0169
		static Delegate GetGetImageUrlHandler ()
		{
			if (cb_getImageUrl == null)
				cb_getImageUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageUrl);
			return cb_getImageUrl;
		}

		static IntPtr n_GetImageUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setImageUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setImageUrl_Ljava_lang_String_ == null)
				cb_setImageUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageUrl_Ljava_lang_String_);
			return cb_setImageUrl_Ljava_lang_String_;
		}

		static void n_SetImageUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		static IntPtr id_setImageUrl_Ljava_lang_String_;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getImageUrl' and count(parameter)=0]"
			[Register ("getImageUrl", "()Ljava/lang/String;", "GetGetImageUrlHandler")]
			get {
				if (id_getImageUrl == IntPtr.Zero)
					id_getImageUrl = JNIEnv.GetMethodID (class_ref, "getImageUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageUrl", "(Ljava/lang/String;)V", "GetSetImageUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setImageUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		static Delegate cb_setMetadata_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetMetadata_Ljava_util_Map_Handler ()
		{
			if (cb_setMetadata_Ljava_util_Map_ == null)
				cb_setMetadata_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMetadata_Ljava_util_Map_);
			return cb_setMetadata_Ljava_util_Map_;
		}

		static void n_SetMetadata_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Ljava/util/Map;", "GetGetMetadataHandler")]
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMetadata", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
			[Register ("setMetadata", "(Ljava/util/Map;)V", "GetSetMetadata_Ljava_util_Map_Handler")]
			set {
				if (id_setMetadata_Ljava_util_Map_ == IntPtr.Zero)
					id_setMetadata_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setMetadata", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMetadata_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMetadata", "(Ljava/util/Map;)V"), __args);
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
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetType);
			return cb_getType;
		}

		static int n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_I;
#pragma warning disable 0169
		static Delegate GetSetType_IHandler ()
		{
			if (cb_setType_I == null)
				cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
			return cb_setType_I;
		}

		static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_I;
		public virtual unsafe int Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()I", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.people']/class[@name='ChannelInfo']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			set {
				if (id_setType_I == IntPtr.Zero)
					id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
