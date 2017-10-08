using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Channel.Service {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/channel/service/ChannelClientService", DoNotGenerateAcw=true)]
	public partial class ChannelClientService : global::Com.Applozic.Mobicomkit.Api.MobiComKitClientService {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/channel/service/ChannelClientService", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelClientService); }
		}

		protected ChannelClientService (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAddMemberToGroup;
#pragma warning disable 0169
		static Delegate GetGetAddMemberToGroupHandler ()
		{
			if (cb_getAddMemberToGroup == null)
				cb_getAddMemberToGroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddMemberToGroup);
			return cb_getAddMemberToGroup;
		}

		static IntPtr n_GetAddMemberToGroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddMemberToGroup);
		}
#pragma warning restore 0169

		static IntPtr id_getAddMemberToGroup;
		public virtual unsafe string AddMemberToGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getAddMemberToGroup' and count(parameter)=0]"
			[Register ("getAddMemberToGroup", "()Ljava/lang/String;", "GetGetAddMemberToGroupHandler")]
			get {
				if (id_getAddMemberToGroup == IntPtr.Zero)
					id_getAddMemberToGroup = JNIEnv.GetMethodID (class_ref, "getAddMemberToGroup", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddMemberToGroup), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddMemberToGroup", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAddMemberToMultipleChannelsUrl;
#pragma warning disable 0169
		static Delegate GetGetAddMemberToMultipleChannelsUrlHandler ()
		{
			if (cb_getAddMemberToMultipleChannelsUrl == null)
				cb_getAddMemberToMultipleChannelsUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddMemberToMultipleChannelsUrl);
			return cb_getAddMemberToMultipleChannelsUrl;
		}

		static IntPtr n_GetAddMemberToMultipleChannelsUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddMemberToMultipleChannelsUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAddMemberToMultipleChannelsUrl;
		public virtual unsafe string AddMemberToMultipleChannelsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getAddMemberToMultipleChannelsUrl' and count(parameter)=0]"
			[Register ("getAddMemberToMultipleChannelsUrl", "()Ljava/lang/String;", "GetGetAddMemberToMultipleChannelsUrlHandler")]
			get {
				if (id_getAddMemberToMultipleChannelsUrl == IntPtr.Zero)
					id_getAddMemberToMultipleChannelsUrl = JNIEnv.GetMethodID (class_ref, "getAddMemberToMultipleChannelsUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddMemberToMultipleChannelsUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddMemberToMultipleChannelsUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelDeleteUrl;
#pragma warning disable 0169
		static Delegate GetGetChannelDeleteUrlHandler ()
		{
			if (cb_getChannelDeleteUrl == null)
				cb_getChannelDeleteUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelDeleteUrl);
			return cb_getChannelDeleteUrl;
		}

		static IntPtr n_GetChannelDeleteUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelDeleteUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelDeleteUrl;
		public virtual unsafe string ChannelDeleteUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelDeleteUrl' and count(parameter)=0]"
			[Register ("getChannelDeleteUrl", "()Ljava/lang/String;", "GetGetChannelDeleteUrlHandler")]
			get {
				if (id_getChannelDeleteUrl == IntPtr.Zero)
					id_getChannelDeleteUrl = JNIEnv.GetMethodID (class_ref, "getChannelDeleteUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelDeleteUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelDeleteUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelInfoUrl;
#pragma warning disable 0169
		static Delegate GetGetChannelInfoUrlHandler ()
		{
			if (cb_getChannelInfoUrl == null)
				cb_getChannelInfoUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelInfoUrl);
			return cb_getChannelInfoUrl;
		}

		static IntPtr n_GetChannelInfoUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelInfoUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfoUrl;
		public virtual unsafe string ChannelInfoUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelInfoUrl' and count(parameter)=0]"
			[Register ("getChannelInfoUrl", "()Ljava/lang/String;", "GetGetChannelInfoUrlHandler")]
			get {
				if (id_getChannelInfoUrl == IntPtr.Zero)
					id_getChannelInfoUrl = JNIEnv.GetMethodID (class_ref, "getChannelInfoUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfoUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfoUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelLeftUrl;
#pragma warning disable 0169
		static Delegate GetGetChannelLeftUrlHandler ()
		{
			if (cb_getChannelLeftUrl == null)
				cb_getChannelLeftUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelLeftUrl);
			return cb_getChannelLeftUrl;
		}

		static IntPtr n_GetChannelLeftUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelLeftUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelLeftUrl;
		public virtual unsafe string ChannelLeftUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelLeftUrl' and count(parameter)=0]"
			[Register ("getChannelLeftUrl", "()Ljava/lang/String;", "GetGetChannelLeftUrlHandler")]
			get {
				if (id_getChannelLeftUrl == IntPtr.Zero)
					id_getChannelLeftUrl = JNIEnv.GetMethodID (class_ref, "getChannelLeftUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelLeftUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelLeftUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelSyncUrl;
#pragma warning disable 0169
		static Delegate GetGetChannelSyncUrlHandler ()
		{
			if (cb_getChannelSyncUrl == null)
				cb_getChannelSyncUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelSyncUrl);
			return cb_getChannelSyncUrl;
		}

		static IntPtr n_GetChannelSyncUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelSyncUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelSyncUrl;
		public virtual unsafe string ChannelSyncUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelSyncUrl' and count(parameter)=0]"
			[Register ("getChannelSyncUrl", "()Ljava/lang/String;", "GetGetChannelSyncUrlHandler")]
			get {
				if (id_getChannelSyncUrl == IntPtr.Zero)
					id_getChannelSyncUrl = JNIEnv.GetMethodID (class_ref, "getChannelSyncUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelSyncUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelSyncUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelUpdateUrl;
#pragma warning disable 0169
		static Delegate GetGetChannelUpdateUrlHandler ()
		{
			if (cb_getChannelUpdateUrl == null)
				cb_getChannelUpdateUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelUpdateUrl);
			return cb_getChannelUpdateUrl;
		}

		static IntPtr n_GetChannelUpdateUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelUpdateUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelUpdateUrl;
		public virtual unsafe string ChannelUpdateUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelUpdateUrl' and count(parameter)=0]"
			[Register ("getChannelUpdateUrl", "()Ljava/lang/String;", "GetGetChannelUpdateUrlHandler")]
			get {
				if (id_getChannelUpdateUrl == IntPtr.Zero)
					id_getChannelUpdateUrl = JNIEnv.GetMethodID (class_ref, "getChannelUpdateUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelUpdateUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelUpdateUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreateChannelUrl;
#pragma warning disable 0169
		static Delegate GetGetCreateChannelUrlHandler ()
		{
			if (cb_getCreateChannelUrl == null)
				cb_getCreateChannelUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateChannelUrl);
			return cb_getCreateChannelUrl;
		}

		static IntPtr n_GetCreateChannelUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateChannelUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateChannelUrl;
		public virtual unsafe string CreateChannelUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getCreateChannelUrl' and count(parameter)=0]"
			[Register ("getCreateChannelUrl", "()Ljava/lang/String;", "GetGetCreateChannelUrlHandler")]
			get {
				if (id_getCreateChannelUrl == IntPtr.Zero)
					id_getCreateChannelUrl = JNIEnv.GetMethodID (class_ref, "getCreateChannelUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateChannelUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateChannelUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreateMultipleChannelUrl;
#pragma warning disable 0169
		static Delegate GetGetCreateMultipleChannelUrlHandler ()
		{
			if (cb_getCreateMultipleChannelUrl == null)
				cb_getCreateMultipleChannelUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateMultipleChannelUrl);
			return cb_getCreateMultipleChannelUrl;
		}

		static IntPtr n_GetCreateMultipleChannelUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateMultipleChannelUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getCreateMultipleChannelUrl;
		public virtual unsafe string CreateMultipleChannelUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getCreateMultipleChannelUrl' and count(parameter)=0]"
			[Register ("getCreateMultipleChannelUrl", "()Ljava/lang/String;", "GetGetCreateMultipleChannelUrlHandler")]
			get {
				if (id_getCreateMultipleChannelUrl == IntPtr.Zero)
					id_getCreateMultipleChannelUrl = JNIEnv.GetMethodID (class_ref, "getCreateMultipleChannelUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateMultipleChannelUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateMultipleChannelUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupInfoFromGroupIdsUrl;
#pragma warning disable 0169
		static Delegate GetGetGroupInfoFromGroupIdsUrlHandler ()
		{
			if (cb_getGroupInfoFromGroupIdsUrl == null)
				cb_getGroupInfoFromGroupIdsUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupInfoFromGroupIdsUrl);
			return cb_getGroupInfoFromGroupIdsUrl;
		}

		static IntPtr n_GetGroupInfoFromGroupIdsUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupInfoFromGroupIdsUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getGroupInfoFromGroupIdsUrl;
		public virtual unsafe string GroupInfoFromGroupIdsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getGroupInfoFromGroupIdsUrl' and count(parameter)=0]"
			[Register ("getGroupInfoFromGroupIdsUrl", "()Ljava/lang/String;", "GetGetGroupInfoFromGroupIdsUrlHandler")]
			get {
				if (id_getGroupInfoFromGroupIdsUrl == IntPtr.Zero)
					id_getGroupInfoFromGroupIdsUrl = JNIEnv.GetMethodID (class_ref, "getGroupInfoFromGroupIdsUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupInfoFromGroupIdsUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupInfoFromGroupIdsUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMembersFromContactGroupOfTypeUrl;
#pragma warning disable 0169
		static Delegate GetGetMembersFromContactGroupOfTypeUrlHandler ()
		{
			if (cb_getMembersFromContactGroupOfTypeUrl == null)
				cb_getMembersFromContactGroupOfTypeUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembersFromContactGroupOfTypeUrl);
			return cb_getMembersFromContactGroupOfTypeUrl;
		}

		static IntPtr n_GetMembersFromContactGroupOfTypeUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MembersFromContactGroupOfTypeUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMembersFromContactGroupOfTypeUrl;
		public virtual unsafe string MembersFromContactGroupOfTypeUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getMembersFromContactGroupOfTypeUrl' and count(parameter)=0]"
			[Register ("getMembersFromContactGroupOfTypeUrl", "()Ljava/lang/String;", "GetGetMembersFromContactGroupOfTypeUrlHandler")]
			get {
				if (id_getMembersFromContactGroupOfTypeUrl == IntPtr.Zero)
					id_getMembersFromContactGroupOfTypeUrl = JNIEnv.GetMethodID (class_ref, "getMembersFromContactGroupOfTypeUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersFromContactGroupOfTypeUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersFromContactGroupOfTypeUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMembersFromContactGroupUrl;
#pragma warning disable 0169
		static Delegate GetGetMembersFromContactGroupUrlHandler ()
		{
			if (cb_getMembersFromContactGroupUrl == null)
				cb_getMembersFromContactGroupUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembersFromContactGroupUrl);
			return cb_getMembersFromContactGroupUrl;
		}

		static IntPtr n_GetMembersFromContactGroupUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MembersFromContactGroupUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMembersFromContactGroupUrl;
		public virtual unsafe string MembersFromContactGroupUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getMembersFromContactGroupUrl' and count(parameter)=0]"
			[Register ("getMembersFromContactGroupUrl", "()Ljava/lang/String;", "GetGetMembersFromContactGroupUrlHandler")]
			get {
				if (id_getMembersFromContactGroupUrl == IntPtr.Zero)
					id_getMembersFromContactGroupUrl = JNIEnv.GetMethodID (class_ref, "getMembersFromContactGroupUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersFromContactGroupUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersFromContactGroupUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMuteChannelUrl;
#pragma warning disable 0169
		static Delegate GetGetMuteChannelUrlHandler ()
		{
			if (cb_getMuteChannelUrl == null)
				cb_getMuteChannelUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMuteChannelUrl);
			return cb_getMuteChannelUrl;
		}

		static IntPtr n_GetMuteChannelUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MuteChannelUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getMuteChannelUrl;
		public virtual unsafe string MuteChannelUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getMuteChannelUrl' and count(parameter)=0]"
			[Register ("getMuteChannelUrl", "()Ljava/lang/String;", "GetGetMuteChannelUrlHandler")]
			get {
				if (id_getMuteChannelUrl == IntPtr.Zero)
					id_getMuteChannelUrl = JNIEnv.GetMethodID (class_ref, "getMuteChannelUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMuteChannelUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMuteChannelUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoveMemberUrl;
#pragma warning disable 0169
		static Delegate GetGetRemoveMemberUrlHandler ()
		{
			if (cb_getRemoveMemberUrl == null)
				cb_getRemoveMemberUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoveMemberUrl);
			return cb_getRemoveMemberUrl;
		}

		static IntPtr n_GetRemoveMemberUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoveMemberUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getRemoveMemberUrl;
		public virtual unsafe string RemoveMemberUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getRemoveMemberUrl' and count(parameter)=0]"
			[Register ("getRemoveMemberUrl", "()Ljava/lang/String;", "GetGetRemoveMemberUrlHandler")]
			get {
				if (id_getRemoveMemberUrl == IntPtr.Zero)
					id_getRemoveMemberUrl = JNIEnv.GetMethodID (class_ref, "getRemoveMemberUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoveMemberUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoveMemberUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRemoveMembersFromMultipChannels;
#pragma warning disable 0169
		static Delegate GetGetRemoveMembersFromMultipChannelsHandler ()
		{
			if (cb_getRemoveMembersFromMultipChannels == null)
				cb_getRemoveMembersFromMultipChannels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoveMembersFromMultipChannels);
			return cb_getRemoveMembersFromMultipChannels;
		}

		static IntPtr n_GetRemoveMembersFromMultipChannels (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoveMembersFromMultipChannels);
		}
#pragma warning restore 0169

		static IntPtr id_getRemoveMembersFromMultipChannels;
		public virtual unsafe string RemoveMembersFromMultipChannels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getRemoveMembersFromMultipChannels' and count(parameter)=0]"
			[Register ("getRemoveMembersFromMultipChannels", "()Ljava/lang/String;", "GetGetRemoveMembersFromMultipChannelsHandler")]
			get {
				if (id_getRemoveMembersFromMultipChannels == IntPtr.Zero)
					id_getRemoveMembersFromMultipChannels = JNIEnv.GetMethodID (class_ref, "getRemoveMembersFromMultipChannels", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoveMembersFromMultipChannels), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoveMembersFromMultipChannels", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToChannel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannel (global::Java.Lang.Integer p0, string p1)
		{
			if (id_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannel_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannel (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToChannel' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register ("addMemberToChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannel (string p0, global::Java.Lang.Integer p1, string p2)
		{
			if (id_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToChannel_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToChannel_Ljava_lang_String_Ljava_lang_String_);
			return cb_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToChannel_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToChannel_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToChannel (string p0, string p1)
		{
			if (id_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToChannel_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddMemberToContactGroup_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_ == null)
				cb_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToContactGroup_Ljava_lang_String_Ljava_util_List_);
			return cb_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_AddMemberToContactGroup_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToContactGroup (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToContactGroup' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addMemberToContactGroup", "(Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToContactGroup_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToContactGroup (string p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addMemberToContactGroup", "(Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToContactGroup_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToContactGroup", "(Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler ()
		{
			if (cb_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == null)
				cb_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_);
			return cb_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		}

		static IntPtr n_AddMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToContactGroupOfType (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToContactGroupOfType' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("addMemberToContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToContactGroupOfType (string p0, string p1, global::System.Collections.Generic.IList<string> p2)
		{
			if (id_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addMemberToContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_);
			return cb_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToMultipleChannels (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToMultipleChannels' and count(parameter)=3 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[3][@type='java.lang.String']]"
		[Register ("addMemberToMultipleChannels", "(Ljava/util/Set;Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToMultipleChannels (global::System.Collections.Generic.ICollection<string> p0, global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p1, string p2)
		{
			if (id_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToMultipleChannels", "(Ljava/util/Set;Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToMultipleChannels_Ljava_util_Set_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToMultipleChannels", "(Ljava/util/Set;Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_);
			return cb_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToMultipleChannelsByChannelKey (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToMultipleChannelsByChannelKey' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToMultipleChannelsByChannelKey", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToMultipleChannelsByChannelKey (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0, string p1)
		{
			if (id_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToMultipleChannelsByChannelKey", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToMultipleChannelsByChannelKey_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToMultipleChannelsByChannelKey", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_Handler ()
		{
			if (cb_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_ == null)
				cb_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_);
			return cb_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_;
		}

		static IntPtr n_AddMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMemberToMultipleChannelsByClientGroupIds (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMemberToMultipleChannelsByClientGroupIds' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("addMemberToMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetAddMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse AddMemberToMultipleChannelsByClientGroupIds (global::System.Collections.Generic.ICollection<string> p0, string p1)
		{
			if (id_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_ == IntPtr.Zero)
				id_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMemberToMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMemberToMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMemberToMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_addMembersToContactGroupOfTypeUrl;
#pragma warning disable 0169
		static Delegate GetAddMembersToContactGroupOfTypeUrlHandler ()
		{
			if (cb_addMembersToContactGroupOfTypeUrl == null)
				cb_addMembersToContactGroupOfTypeUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AddMembersToContactGroupOfTypeUrl);
			return cb_addMembersToContactGroupOfTypeUrl;
		}

		static IntPtr n_AddMembersToContactGroupOfTypeUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddMembersToContactGroupOfTypeUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_addMembersToContactGroupOfTypeUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMembersToContactGroupOfTypeUrl' and count(parameter)=0]"
		[Register ("addMembersToContactGroupOfTypeUrl", "()Ljava/lang/String;", "GetAddMembersToContactGroupOfTypeUrlHandler")]
		public virtual unsafe string AddMembersToContactGroupOfTypeUrl ()
		{
			if (id_addMembersToContactGroupOfTypeUrl == IntPtr.Zero)
				id_addMembersToContactGroupOfTypeUrl = JNIEnv.GetMethodID (class_ref, "addMembersToContactGroupOfTypeUrl", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMembersToContactGroupOfTypeUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMembersToContactGroupOfTypeUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMembersToContactGroupUrl;
#pragma warning disable 0169
		static Delegate GetAddMembersToContactGroupUrlHandler ()
		{
			if (cb_addMembersToContactGroupUrl == null)
				cb_addMembersToContactGroupUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AddMembersToContactGroupUrl);
			return cb_addMembersToContactGroupUrl;
		}

		static IntPtr n_AddMembersToContactGroupUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddMembersToContactGroupUrl ());
		}
#pragma warning restore 0169

		static IntPtr id_addMembersToContactGroupUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='addMembersToContactGroupUrl' and count(parameter)=0]"
		[Register ("addMembersToContactGroupUrl", "()Ljava/lang/String;", "GetAddMembersToContactGroupUrlHandler")]
		public virtual unsafe string AddMembersToContactGroupUrl ()
		{
			if (id_addMembersToContactGroupUrl == IntPtr.Zero)
				id_addMembersToContactGroupUrl = JNIEnv.GetMethodID (class_ref, "addMembersToContactGroupUrl", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addMembersToContactGroupUrl), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMembersToContactGroupUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
#pragma warning disable 0169
		static Delegate GetCreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler ()
		{
			if (cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == null)
				cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_);
			return cb_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		}

		static IntPtr n_CreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='createChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.people.ChannelInfo']]"
		[Register ("createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetCreateChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed CreateChannel (global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0)
		{
			if (id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == IntPtr.Zero)
				id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNIEnv.GetMethodID (class_ref, "createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createChannel_Lcom_applozic_mobicomkit_api_people_ChannelInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createChannel", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
#pragma warning disable 0169
		static Delegate GetCreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler ()
		{
			if (cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == null)
				cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_);
			return cb_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		}

		static IntPtr n_CreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateChannelWithResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='createChannelWithResponse' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.people.ChannelInfo']]"
		[Register ("createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;", "GetCreateChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse CreateChannelWithResponse (global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo p0)
		{
			if (id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ == IntPtr.Zero)
				id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_ = JNIEnv.GetMethodID (class_ref, "createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createChannelWithResponse_Lcom_applozic_mobicomkit_api_people_ChannelInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createChannelWithResponse", "(Lcom/applozic/mobicomkit/api/people/ChannelInfo;)Lcom/applozic/mobicomkit/feed/ChannelFeedApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_createMultipleChannels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetCreateMultipleChannels_Ljava_util_List_Handler ()
		{
			if (cb_createMultipleChannels_Ljava_util_List_ == null)
				cb_createMultipleChannels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateMultipleChannels_Ljava_util_List_);
			return cb_createMultipleChannels_Ljava_util_List_;
		}

		static IntPtr n_CreateMultipleChannels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.ToLocalJniHandle (__this.CreateMultipleChannels (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_createMultipleChannels_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='createMultipleChannels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.api.people.ChannelInfo&gt;']]"
		[Register ("createMultipleChannels", "(Ljava/util/List;)Ljava/util/List;", "GetCreateMultipleChannels_Ljava_util_List_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> CreateMultipleChannels (global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo> p0)
		{
			if (id_createMultipleChannels_Ljava_util_List_ == IntPtr.Zero)
				id_createMultipleChannels_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "createMultipleChannels", "(Ljava/util/List;)Ljava/util/List;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Api.People.ChannelInfo>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createMultipleChannels_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createMultipleChannels", "(Ljava/util/List;)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetDeleteChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_deleteChannel_Ljava_lang_Integer_ == null)
				cb_deleteChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DeleteChannel_Ljava_lang_Integer_);
			return cb_deleteChannel_Ljava_lang_Integer_;
		}

		static IntPtr n_DeleteChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DeleteChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_deleteChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='deleteChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("deleteChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetDeleteChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse DeleteChannel (global::Java.Lang.Integer p0)
		{
			if (id_deleteChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_deleteChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "deleteChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deleteChannel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelFeed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelFeed_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelFeed_Ljava_lang_String_ == null)
				cb_getChannelFeed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelFeed_Ljava_lang_String_);
			return cb_getChannelFeed_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelFeed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelFeed (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelFeed_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelFeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncChannelFeed;", "GetGetChannelFeed_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Sync.SyncChannelFeed GetChannelFeed (string p0)
		{
			if (id_getChannelFeed_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelFeed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Sync.SyncChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelFeed_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Sync.SyncChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelFeed", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/sync/SyncChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannelInfo_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfo_Ljava_lang_Integer_Handler ()
		{
			if (cb_getChannelInfo_Ljava_lang_Integer_ == null)
				cb_getChannelInfo_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfo_Ljava_lang_Integer_);
			return cb_getChannelInfo_Ljava_lang_Integer_;
		}

		static IntPtr n_GetChannelInfo_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfo_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelInfo' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetChannelInfo_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetChannelInfo (global::Java.Lang.Integer p0)
		{
			if (id_getChannelInfo_Ljava_lang_Integer_ == IntPtr.Zero)
				id_getChannelInfo_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfo_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfo", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getChannelInfo_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfo_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelInfo_Ljava_lang_String_ == null)
				cb_getChannelInfo_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfo_Ljava_lang_String_);
			return cb_getChannelInfo_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelInfo_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfo_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetChannelInfo_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetChannelInfo (string p0)
		{
			if (id_getChannelInfo_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelInfo_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfo_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfo", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getChannelInfoByParameters_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetChannelInfoByParameters_Ljava_lang_String_Handler ()
		{
			if (cb_getChannelInfoByParameters_Ljava_lang_String_ == null)
				cb_getChannelInfoByParameters_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetChannelInfoByParameters_Ljava_lang_String_);
			return cb_getChannelInfoByParameters_Ljava_lang_String_;
		}

		static IntPtr n_GetChannelInfoByParameters_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetChannelInfoByParameters (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getChannelInfoByParameters_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getChannelInfoByParameters' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getChannelInfoByParameters", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetChannelInfoByParameters_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetChannelInfoByParameters (string p0)
		{
			if (id_getChannelInfoByParameters_Ljava_lang_String_ == IntPtr.Zero)
				id_getChannelInfoByParameters_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getChannelInfoByParameters", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelInfoByParameters_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelInfoByParameters", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ == null)
				cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_);
			return cb_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
		}

		static IntPtr n_GetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetGroupInfoFromGroupIds (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getGroupInfoFromGroupIds' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ChannelFeedListResponse;", "GetGetGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeedListResponse GetGroupInfoFromGroupIds (global::System.Collections.Generic.IList<string> p0, global::System.Collections.Generic.IList<string> p1)
		{
			if (id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ == IntPtr.Zero)
				id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ChannelFeedListResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeedListResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedListResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupInfoFromGroupIds_Ljava_util_List_Ljava_util_List_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeedListResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupInfoFromGroupIds", "(Ljava/util/List;Ljava/util/List;)Lcom/applozic/mobicomkit/feed/ChannelFeedListResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/service/ChannelClientService;", "")]
		public static unsafe global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/applozic/mobicomkit/channel/service/ChannelClientService;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getMembersFromContactGroup_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMembersFromContactGroup_Ljava_lang_String_Handler ()
		{
			if (cb_getMembersFromContactGroup_Ljava_lang_String_ == null)
				cb_getMembersFromContactGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMembersFromContactGroup_Ljava_lang_String_);
			return cb_getMembersFromContactGroup_Ljava_lang_String_;
		}

		static IntPtr n_GetMembersFromContactGroup_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMembersFromContactGroup (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMembersFromContactGroup_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getMembersFromContactGroup' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMembersFromContactGroup", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetMembersFromContactGroup_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetMembersFromContactGroup (string p0)
		{
			if (id_getMembersFromContactGroup_Ljava_lang_String_ == IntPtr.Zero)
				id_getMembersFromContactGroup_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMembersFromContactGroup", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersFromContactGroup_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersFromContactGroup", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_);
			return cb_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetMembersFromContactGroupOfType (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='getMembersFromContactGroupOfType' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMembersFromContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;", "GetGetMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ChannelFeed GetMembersFromContactGroupOfType (string p0, string p1)
		{
			if (id_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getMembersFromContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersFromContactGroupOfType_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersFromContactGroupOfType", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ChannelFeed;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_leaveMemberFromChannel_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannel_Ljava_lang_Integer_Handler ()
		{
			if (cb_leaveMemberFromChannel_Ljava_lang_Integer_ == null)
				cb_leaveMemberFromChannel_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LeaveMemberFromChannel_Ljava_lang_Integer_);
			return cb_leaveMemberFromChannel_Ljava_lang_Integer_;
		}

		static IntPtr n_LeaveMemberFromChannel_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LeaveMemberFromChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannel_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='leaveMemberFromChannel' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("leaveMemberFromChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetLeaveMemberFromChannel_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse LeaveMemberFromChannel (global::Java.Lang.Integer p0)
		{
			if (id_leaveMemberFromChannel_Ljava_lang_Integer_ == IntPtr.Zero)
				id_leaveMemberFromChannel_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannel_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannel", "(Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_leaveMemberFromChannel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannel_Ljava_lang_String_Handler ()
		{
			if (cb_leaveMemberFromChannel_Ljava_lang_String_ == null)
				cb_leaveMemberFromChannel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_LeaveMemberFromChannel_Ljava_lang_String_);
			return cb_leaveMemberFromChannel_Ljava_lang_String_;
		}

		static IntPtr n_LeaveMemberFromChannel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LeaveMemberFromChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannel_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='leaveMemberFromChannel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("leaveMemberFromChannel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetLeaveMemberFromChannel_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse LeaveMemberFromChannel (string p0)
		{
			if (id_leaveMemberFromChannel_Ljava_lang_String_ == IntPtr.Zero)
				id_leaveMemberFromChannel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannel_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannel", "(Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetLeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_LeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static IntPtr n_LeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LeaveMemberFromChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='leaveMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetLeaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse LeaveMemberFromChannel (string p0, global::Java.Lang.Integer p1)
		{
			if (id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_ == IntPtr.Zero)
				id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_leaveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "leaveMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
#pragma warning disable 0169
		static Delegate GetMuteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_Handler ()
		{
			if (cb_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ == null)
				cb_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MuteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_);
			return cb_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
		}

		static IntPtr n_MuteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MuteNotification (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='muteNotification' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.api.notification.MuteNotificationRequest']]"
		[Register ("muteNotification", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetMuteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse MuteNotification (global::Com.Applozic.Mobicomkit.Api.Notification.MuteNotificationRequest p0)
		{
			if (id_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ == IntPtr.Zero)
				id_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_ = JNIEnv.GetMethodID (class_ref, "muteNotification", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_muteNotification_Lcom_applozic_mobicomkit_api_notification_MuteNotificationRequest_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "muteNotification", "(Lcom/applozic/mobicomkit/api/notification/MuteNotificationRequest;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_RemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveMemberFromChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='removeMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetRemoveMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse RemoveMemberFromChannel (global::Java.Lang.Integer p0, string p1)
		{
			if (id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannel_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannel", "(Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == null)
				cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_);
			return cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		}

		static IntPtr n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveMemberFromChannel (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='removeMemberFromChannel' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer'] and parameter[3][@type='java.lang.String']]"
		[Register ("removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse RemoveMemberFromChannel (string p0, global::Java.Lang.Integer p1, string p2)
		{
			if (id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_Integer_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/Integer;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_RemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveMemberFromChannel (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='removeMemberFromChannel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetRemoveMemberFromChannel_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse RemoveMemberFromChannel (string p0, string p1)
		{
			if (id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMemberFromChannel_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMemberFromChannel", "(Ljava/lang/String;Ljava/lang/String;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetRemoveMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_Handler ()
		{
			if (cb_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_ == null)
				cb_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_);
			return cb_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_;
		}

		static IntPtr n_RemoveMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveMembersFromMultipleChannelsByChannelKeys (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='removeMembersFromMultipleChannelsByChannelKeys' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("removeMembersFromMultipleChannelsByChannelKeys", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetRemoveMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse RemoveMembersFromMultipleChannelsByChannelKeys (global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> p0, global::System.Collections.Generic.ICollection<string> p1)
		{
			if (id_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_ == IntPtr.Zero)
				id_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "removeMembersFromMultipleChannelsByChannelKeys", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMembersFromMultipleChannelsByChannelKeys_Ljava_util_Set_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMembersFromMultipleChannelsByChannelKeys", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetRemoveMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_Handler ()
		{
			if (cb_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_ == null)
				cb_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_);
			return cb_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_;
		}

		static IntPtr n_RemoveMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RemoveMembersFromMultipleChannelsByClientGroupIds (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='removeMembersFromMultipleChannelsByClientGroupIds' and count(parameter)=2 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;'] and parameter[2][@type='java.util.Set&lt;java.lang.String&gt;']]"
		[Register ("removeMembersFromMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetRemoveMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse RemoveMembersFromMultipleChannelsByClientGroupIds (global::System.Collections.Generic.ICollection<string> p0, global::System.Collections.Generic.ICollection<string> p1)
		{
			if (id_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_ == IntPtr.Zero)
				id_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "removeMembersFromMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			IntPtr native_p0 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_removeMembersFromMultipleChannelsByClientGroupIds_Ljava_util_Set_Ljava_util_Set_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMembersFromMultipleChannelsByClientGroupIds", "(Ljava/util/Set;Ljava/util/Set;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
#pragma warning disable 0169
		static Delegate GetUpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_Handler ()
		{
			if (cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == null)
				cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_);
			return cb_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		}

		static IntPtr n_UpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Channel.Service.ChannelClientService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.UpdateChannel (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.channel.service']/class[@name='ChannelClientService']/method[@name='updateChannel' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.feed.GroupInfoUpdate']]"
		[Register ("updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Lcom/applozic/mobicomkit/feed/ApiResponse;", "GetUpdateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_Handler")]
		public virtual unsafe global::Com.Applozic.Mobicomkit.Feed.ApiResponse UpdateChannel (global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate p0)
		{
			if (id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ == IntPtr.Zero)
				id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_ = JNIEnv.GetMethodID (class_ref, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Lcom/applozic/mobicomkit/feed/ApiResponse;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Applozic.Mobicomkit.Feed.ApiResponse __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_updateChannel_Lcom_applozic_mobicomkit_feed_GroupInfoUpdate_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ApiResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateChannel", "(Lcom/applozic/mobicomkit/feed/GroupInfoUpdate;)Lcom/applozic/mobicomkit/feed/ApiResponse;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
