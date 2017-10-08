using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/ChannelFeed", DoNotGenerateAcw=true)]
	public partial class ChannelFeed : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/ChannelFeed", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelFeed); }
		}

		protected ChannelFeed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Integer_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/constructor[@name='ChannelFeed' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Integer;Ljava/lang/String;)V", "")]
		public unsafe ChannelFeed (global::Java.Lang.Integer p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ChannelFeed)) {
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

		static IntPtr id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/constructor[@name='ChannelFeed' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register (".ctor", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "")]
		public unsafe ChannelFeed (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ChannelFeed)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/applozic/mobicommons/people/channel/Channel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/applozic/mobicommons/people/channel/Channel;)V", __args);
					return;
				}

				if (id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_ == IntPtr.Zero)
					id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/applozic/mobicommons/people/channel/Channel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_, __args);
			} finally {
			}
		}

		static Delegate cb_getAdminId;
#pragma warning disable 0169
		static Delegate GetGetAdminIdHandler ()
		{
			if (cb_getAdminId == null)
				cb_getAdminId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminId);
			return cb_getAdminId;
		}

		static IntPtr n_GetAdminId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminId);
		}
#pragma warning restore 0169

		static Delegate cb_setAdminId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdminId_Ljava_lang_String_Handler ()
		{
			if (cb_setAdminId_Ljava_lang_String_ == null)
				cb_setAdminId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdminId_Ljava_lang_String_);
			return cb_setAdminId_Ljava_lang_String_;
		}

		static void n_SetAdminId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdminId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdminId;
		static IntPtr id_setAdminId_Ljava_lang_String_;
		public virtual unsafe string AdminId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getAdminId' and count(parameter)=0]"
			[Register ("getAdminId", "()Ljava/lang/String;", "GetGetAdminIdHandler")]
			get {
				if (id_getAdminId == IntPtr.Zero)
					id_getAdminId = JNIEnv.GetMethodID (class_ref, "getAdminId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setAdminId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminId", "(Ljava/lang/String;)V", "GetSetAdminId_Ljava_lang_String_Handler")]
			set {
				if (id_setAdminId_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdminId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdminId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdminId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdminId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAdminName;
#pragma warning disable 0169
		static Delegate GetGetAdminNameHandler ()
		{
			if (cb_getAdminName == null)
				cb_getAdminName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminName);
			return cb_getAdminName;
		}

		static IntPtr n_GetAdminName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminName);
		}
#pragma warning restore 0169

		static Delegate cb_setAdminName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAdminName_Ljava_lang_String_Handler ()
		{
			if (cb_setAdminName_Ljava_lang_String_ == null)
				cb_setAdminName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAdminName_Ljava_lang_String_);
			return cb_setAdminName_Ljava_lang_String_;
		}

		static void n_SetAdminName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AdminName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAdminName;
		static IntPtr id_setAdminName_Ljava_lang_String_;
		public virtual unsafe string AdminName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getAdminName' and count(parameter)=0]"
			[Register ("getAdminName", "()Ljava/lang/String;", "GetGetAdminNameHandler")]
			get {
				if (id_getAdminName == IntPtr.Zero)
					id_getAdminName = JNIEnv.GetMethodID (class_ref, "getAdminName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setAdminName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAdminName", "(Ljava/lang/String;)V", "GetSetAdminName_Ljava_lang_String_Handler")]
			set {
				if (id_setAdminName_Ljava_lang_String_ == IntPtr.Zero)
					id_setAdminName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAdminName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAdminName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAdminName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getClientGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContactGroupMembersId;
#pragma warning disable 0169
		static Delegate GetGetContactGroupMembersIdHandler ()
		{
			if (cb_getContactGroupMembersId == null)
				cb_getContactGroupMembersId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContactGroupMembersId);
			return cb_getContactGroupMembersId;
		}

		static IntPtr n_GetContactGroupMembersId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.ContactGroupMembersId);
		}
#pragma warning restore 0169

		static Delegate cb_setContactGroupMembersId_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetContactGroupMembersId_Ljava_util_Set_Handler ()
		{
			if (cb_setContactGroupMembersId_Ljava_util_Set_ == null)
				cb_setContactGroupMembersId_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContactGroupMembersId_Ljava_util_Set_);
			return cb_setContactGroupMembersId_Ljava_util_Set_;
		}

		static void n_SetContactGroupMembersId_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContactGroupMembersId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContactGroupMembersId;
		static IntPtr id_setContactGroupMembersId_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> ContactGroupMembersId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getContactGroupMembersId' and count(parameter)=0]"
			[Register ("getContactGroupMembersId", "()Ljava/util/Set;", "GetGetContactGroupMembersIdHandler")]
			get {
				if (id_getContactGroupMembersId == IntPtr.Zero)
					id_getContactGroupMembersId = JNIEnv.GetMethodID (class_ref, "getContactGroupMembersId", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContactGroupMembersId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContactGroupMembersId", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setContactGroupMembersId' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setContactGroupMembersId", "(Ljava/util/Set;)V", "GetSetContactGroupMembersId_Ljava_util_Set_Handler")]
			set {
				if (id_setContactGroupMembersId_Ljava_util_Set_ == IntPtr.Zero)
					id_setContactGroupMembersId_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setContactGroupMembersId", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContactGroupMembersId_Ljava_util_Set_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContactGroupMembersId", "(Ljava/util/Set;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getConversationPxy;
#pragma warning disable 0169
		static Delegate GetGetConversationPxyHandler ()
		{
			if (cb_getConversationPxy == null)
				cb_getConversationPxy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationPxy);
			return cb_getConversationPxy;
		}

		static IntPtr n_GetConversationPxy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ConversationPxy);
		}
#pragma warning restore 0169

		static Delegate cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
#pragma warning disable 0169
		static Delegate GetSetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_Handler ()
		{
			if (cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ == null)
				cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_);
			return cb_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
		}

		static void n_SetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicommons.People.Channel.Conversation p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ConversationPxy = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConversationPxy;
		static IntPtr id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_;
		public virtual unsafe global::Com.Applozic.Mobicommons.People.Channel.Conversation ConversationPxy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getConversationPxy' and count(parameter)=0]"
			[Register ("getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;", "GetGetConversationPxyHandler")]
			get {
				if (id_getConversationPxy == IntPtr.Zero)
					id_getConversationPxy = JNIEnv.GetMethodID (class_ref, "getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationPxy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationPxy", "()Lcom/applozic/mobicommons/people/channel/Conversation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setConversationPxy' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Conversation']]"
			[Register ("setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V", "GetSetConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_Handler")]
			set {
				if (id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ == IntPtr.Zero)
					id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_ = JNIEnv.GetMethodID (class_ref, "setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConversationPxy_Lcom_applozic_mobicommons_people_channel_Conversation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConversationPxy", "(Lcom/applozic/mobicommons/people/channel/Conversation;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeletedAtTime;
#pragma warning disable 0169
		static Delegate GetGetDeletedAtTimeHandler ()
		{
			if (cb_getDeletedAtTime == null)
				cb_getDeletedAtTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeletedAtTime);
			return cb_getDeletedAtTime;
		}

		static IntPtr n_GetDeletedAtTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DeletedAtTime);
		}
#pragma warning restore 0169

		static Delegate cb_setDeletedAtTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetDeletedAtTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setDeletedAtTime_Ljava_lang_Long_ == null)
				cb_setDeletedAtTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeletedAtTime_Ljava_lang_Long_);
			return cb_setDeletedAtTime_Ljava_lang_Long_;
		}

		static void n_SetDeletedAtTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeletedAtTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeletedAtTime;
		static IntPtr id_setDeletedAtTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long DeletedAtTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getDeletedAtTime' and count(parameter)=0]"
			[Register ("getDeletedAtTime", "()Ljava/lang/Long;", "GetGetDeletedAtTimeHandler")]
			get {
				if (id_getDeletedAtTime == IntPtr.Zero)
					id_getDeletedAtTime = JNIEnv.GetMethodID (class_ref, "getDeletedAtTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeletedAtTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeletedAtTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setDeletedAtTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setDeletedAtTime", "(Ljava/lang/Long;)V", "GetSetDeletedAtTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setDeletedAtTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setDeletedAtTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setDeletedAtTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeletedAtTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeletedAtTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_Integer_Handler ()
		{
			if (cb_setId_Ljava_lang_Integer_ == null)
				cb_setId_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetId_Ljava_lang_Integer_);
			return cb_setId_Ljava_lang_Integer_;
		}

		static void n_SetId_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/Integer;", "GetGetIdHandler")]
			get {
				if (id_getId == IntPtr.Zero)
					id_getId = JNIEnv.GetMethodID (class_ref, "getId", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getId", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setId", "(Ljava/lang/Integer;)V", "GetSetId_Ljava_lang_Integer_Handler")]
			set {
				if (id_setId_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setId_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setId", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setId_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setId", "(Ljava/lang/Integer;)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		static IntPtr id_setImageUrl_Ljava_lang_String_;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getImageUrl' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getMembersId;
#pragma warning disable 0169
		static Delegate GetGetMembersIdHandler ()
		{
			if (cb_getMembersId == null)
				cb_getMembersId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembersId);
			return cb_getMembersId;
		}

		static IntPtr n_GetMembersId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.MembersId);
		}
#pragma warning restore 0169

		static Delegate cb_setMembersId_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetMembersId_Ljava_util_Set_Handler ()
		{
			if (cb_setMembersId_Ljava_util_Set_ == null)
				cb_setMembersId_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMembersId_Ljava_util_Set_);
			return cb_setMembersId_Ljava_util_Set_;
		}

		static void n_SetMembersId_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MembersId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMembersId;
		static IntPtr id_setMembersId_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> MembersId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getMembersId' and count(parameter)=0]"
			[Register ("getMembersId", "()Ljava/util/Set;", "GetGetMembersIdHandler")]
			get {
				if (id_getMembersId == IntPtr.Zero)
					id_getMembersId = JNIEnv.GetMethodID (class_ref, "getMembersId", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersId", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setMembersId' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setMembersId", "(Ljava/util/Set;)V", "GetSetMembersId_Ljava_util_Set_Handler")]
			set {
				if (id_setMembersId_Ljava_util_Set_ == IntPtr.Zero)
					id_setMembersId_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setMembersId", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMembersId_Ljava_util_Set_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMembersId", "(Ljava/util/Set;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMembersName;
#pragma warning disable 0169
		static Delegate GetGetMembersNameHandler ()
		{
			if (cb_getMembersName == null)
				cb_getMembersName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMembersName);
			return cb_getMembersName;
		}

		static IntPtr n_GetMembersName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.MembersName);
		}
#pragma warning restore 0169

		static Delegate cb_setMembersName_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetMembersName_Ljava_util_Set_Handler ()
		{
			if (cb_setMembersName_Ljava_util_Set_ == null)
				cb_setMembersName_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMembersName_Ljava_util_Set_);
			return cb_setMembersName_Ljava_util_Set_;
		}

		static void n_SetMembersName_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MembersName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMembersName;
		static IntPtr id_setMembersName_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> MembersName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getMembersName' and count(parameter)=0]"
			[Register ("getMembersName", "()Ljava/util/Set;", "GetGetMembersNameHandler")]
			get {
				if (id_getMembersName == IntPtr.Zero)
					id_getMembersName = JNIEnv.GetMethodID (class_ref, "getMembersName", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMembersName), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMembersName", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setMembersName' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.String&gt;']]"
			[Register ("setMembersName", "(Ljava/util/Set;)V", "GetSetMembersName_Ljava_util_Set_Handler")]
			set {
				if (id_setMembersName_Ljava_util_Set_ == IntPtr.Zero)
					id_setMembersName_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setMembersName", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMembersName_Ljava_util_Set_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMembersName", "(Ljava/util/Set;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getMetadata' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Name = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		static IntPtr id_setName_Ljava_lang_String_;
		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				if (id_setName_Ljava_lang_String_ == IntPtr.Zero)
					id_setName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getNotificationAfterTime;
#pragma warning disable 0169
		static Delegate GetGetNotificationAfterTimeHandler ()
		{
			if (cb_getNotificationAfterTime == null)
				cb_getNotificationAfterTime = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationAfterTime);
			return cb_getNotificationAfterTime;
		}

		static IntPtr n_GetNotificationAfterTime (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NotificationAfterTime);
		}
#pragma warning restore 0169

		static Delegate cb_setNotificationAfterTime_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetNotificationAfterTime_Ljava_lang_Long_Handler ()
		{
			if (cb_setNotificationAfterTime_Ljava_lang_Long_ == null)
				cb_setNotificationAfterTime_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationAfterTime_Ljava_lang_Long_);
			return cb_setNotificationAfterTime_Ljava_lang_Long_;
		}

		static void n_SetNotificationAfterTime_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationAfterTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationAfterTime;
		static IntPtr id_setNotificationAfterTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long NotificationAfterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getNotificationAfterTime' and count(parameter)=0]"
			[Register ("getNotificationAfterTime", "()Ljava/lang/Long;", "GetGetNotificationAfterTimeHandler")]
			get {
				if (id_getNotificationAfterTime == IntPtr.Zero)
					id_getNotificationAfterTime = JNIEnv.GetMethodID (class_ref, "getNotificationAfterTime", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationAfterTime), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationAfterTime", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setNotificationAfterTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setNotificationAfterTime", "(Ljava/lang/Long;)V", "GetSetNotificationAfterTime_Ljava_lang_Long_Handler")]
			set {
				if (id_setNotificationAfterTime_Ljava_lang_Long_ == IntPtr.Zero)
					id_setNotificationAfterTime_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setNotificationAfterTime", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationAfterTime_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationAfterTime", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getType;
#pragma warning disable 0169
		static Delegate GetGetTypeHandler ()
		{
			if (cb_getType == null)
				cb_getType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetType);
			return cb_getType;
		}

		static short n_GetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Type;
		}
#pragma warning restore 0169

		static Delegate cb_setType_S;
#pragma warning disable 0169
		static Delegate GetSetType_SHandler ()
		{
			if (cb_setType_S == null)
				cb_setType_S = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, short>) n_SetType_S);
			return cb_setType_S;
		}

		static void n_SetType_S (IntPtr jnienv, IntPtr native__this, short p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Type = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getType;
		static IntPtr id_setType_S;
		public virtual unsafe short Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()S", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getType);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getType", "()S"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='short']]"
			[Register ("setType", "(S)V", "GetSetType_SHandler")]
			set {
				if (id_setType_S == IntPtr.Zero)
					id_setType_S = JNIEnv.GetMethodID (class_ref, "setType", "(S)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_S, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(S)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_I;
		public virtual unsafe int UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getUnreadCount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getUserCount;
#pragma warning disable 0169
		static Delegate GetGetUserCountHandler ()
		{
			if (cb_getUserCount == null)
				cb_getUserCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserCount);
			return cb_getUserCount;
		}

		static int n_GetUserCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserCount;
		}
#pragma warning restore 0169

		static Delegate cb_setUserCount_I;
#pragma warning disable 0169
		static Delegate GetSetUserCount_IHandler ()
		{
			if (cb_setUserCount_I == null)
				cb_setUserCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetUserCount_I);
			return cb_setUserCount_I;
		}

		static void n_SetUserCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UserCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserCount;
		static IntPtr id_setUserCount_I;
		public virtual unsafe int UserCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getUserCount' and count(parameter)=0]"
			[Register ("getUserCount", "()I", "GetGetUserCountHandler")]
			get {
				if (id_getUserCount == IntPtr.Zero)
					id_getUserCount = JNIEnv.GetMethodID (class_ref, "getUserCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUserCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setUserCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserCount", "(I)V", "GetSetUserCount_IHandler")]
			set {
				if (id_setUserCount_I == IntPtr.Zero)
					id_setUserCount_I = JNIEnv.GetMethodID (class_ref, "setUserCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserCount", "(I)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.ChannelFeed __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.ChannelFeed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Users = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsers;
		static IntPtr id_setUsers_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Com.Applozic.Mobicomkit.Api.Account.User.UserDetail> Users {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='getUsers' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='ChannelFeed']/method[@name='setUsers' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;com.applozic.mobicomkit.api.account.user.UserDetail&gt;']]"
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
