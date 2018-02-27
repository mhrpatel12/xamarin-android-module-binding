using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/ChannelMetadata", DoNotGenerateAcw=true)]
	public partial class ChannelMetadata : global::Com.Applozic.Mobicommons.Json.JsonMarker {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/field[@name='ADMIN_NAME']"
		[Register ("ADMIN_NAME")]
		public const string AdminName = (string) ":adminName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/field[@name='GROUP_NAME']"
		[Register ("GROUP_NAME")]
		public const string GroupName = (string) ":groupName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/field[@name='HIDE_METADATA_NOTIFICATION']"
		[Register ("HIDE_METADATA_NOTIFICATION")]
		public const string HideMetadataNotification = (string) "HIDE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/field[@name='MUTE']"
		[Register ("MUTE")]
		public const string Mute = (string) "MUTE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/field[@name='USER_NAME']"
		[Register ("USER_NAME")]
		public const string UserName = (string) ":userName";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/ChannelMetadata", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ChannelMetadata); }
		}

		protected ChannelMetadata (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/constructor[@name='ChannelMetadata' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChannelMetadata ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ChannelMetadata)) {
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

		static Delegate cb_getAddMemberMessage;
#pragma warning disable 0169
		static Delegate GetGetAddMemberMessageHandler ()
		{
			if (cb_getAddMemberMessage == null)
				cb_getAddMemberMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAddMemberMessage);
			return cb_getAddMemberMessage;
		}

		static IntPtr n_GetAddMemberMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AddMemberMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setAddMemberMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddMemberMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setAddMemberMessage_Ljava_lang_String_ == null)
				cb_setAddMemberMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddMemberMessage_Ljava_lang_String_);
			return cb_setAddMemberMessage_Ljava_lang_String_;
		}

		static void n_SetAddMemberMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMemberMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAddMemberMessage;
		static IntPtr id_setAddMemberMessage_Ljava_lang_String_;
		public virtual unsafe string AddMemberMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getAddMemberMessage' and count(parameter)=0]"
			[Register ("getAddMemberMessage", "()Ljava/lang/String;", "GetGetAddMemberMessageHandler")]
			get {
				if (id_getAddMemberMessage == IntPtr.Zero)
					id_getAddMemberMessage = JNIEnv.GetMethodID (class_ref, "getAddMemberMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAddMemberMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAddMemberMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setAddMemberMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddMemberMessage", "(Ljava/lang/String;)V", "GetSetAddMemberMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setAddMemberMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setAddMemberMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddMemberMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddMemberMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddMemberMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCreateGroupMessage;
#pragma warning disable 0169
		static Delegate GetGetCreateGroupMessageHandler ()
		{
			if (cb_getCreateGroupMessage == null)
				cb_getCreateGroupMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCreateGroupMessage);
			return cb_getCreateGroupMessage;
		}

		static IntPtr n_GetCreateGroupMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreateGroupMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setCreateGroupMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCreateGroupMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setCreateGroupMessage_Ljava_lang_String_ == null)
				cb_setCreateGroupMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCreateGroupMessage_Ljava_lang_String_);
			return cb_setCreateGroupMessage_Ljava_lang_String_;
		}

		static void n_SetCreateGroupMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CreateGroupMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCreateGroupMessage;
		static IntPtr id_setCreateGroupMessage_Ljava_lang_String_;
		public virtual unsafe string CreateGroupMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getCreateGroupMessage' and count(parameter)=0]"
			[Register ("getCreateGroupMessage", "()Ljava/lang/String;", "GetGetCreateGroupMessageHandler")]
			get {
				if (id_getCreateGroupMessage == IntPtr.Zero)
					id_getCreateGroupMessage = JNIEnv.GetMethodID (class_ref, "getCreateGroupMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCreateGroupMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCreateGroupMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setCreateGroupMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCreateGroupMessage", "(Ljava/lang/String;)V", "GetSetCreateGroupMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setCreateGroupMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setCreateGroupMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCreateGroupMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreateGroupMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreateGroupMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isDefaultMute;
#pragma warning disable 0169
		static Delegate GetIsDefaultMuteHandler ()
		{
			if (cb_isDefaultMute == null)
				cb_isDefaultMute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDefaultMute);
			return cb_isDefaultMute;
		}

		static bool n_IsDefaultMute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultMute;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultMute_Z;
#pragma warning disable 0169
		static Delegate GetSetDefaultMute_ZHandler ()
		{
			if (cb_setDefaultMute_Z == null)
				cb_setDefaultMute_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDefaultMute_Z);
			return cb_setDefaultMute_Z;
		}

		static void n_SetDefaultMute_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultMute = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDefaultMute;
		static IntPtr id_setDefaultMute_Z;
		public virtual unsafe bool DefaultMute {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='isDefaultMute' and count(parameter)=0]"
			[Register ("isDefaultMute", "()Z", "GetIsDefaultMuteHandler")]
			get {
				if (id_isDefaultMute == IntPtr.Zero)
					id_isDefaultMute = JNIEnv.GetMethodID (class_ref, "isDefaultMute", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDefaultMute);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDefaultMute", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setDefaultMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDefaultMute", "(Z)V", "GetSetDefaultMute_ZHandler")]
			set {
				if (id_setDefaultMute_Z == IntPtr.Zero)
					id_setDefaultMute_Z = JNIEnv.GetMethodID (class_ref, "setDefaultMute", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultMute_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultMute", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDeletedGroupMessage;
#pragma warning disable 0169
		static Delegate GetGetDeletedGroupMessageHandler ()
		{
			if (cb_getDeletedGroupMessage == null)
				cb_getDeletedGroupMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeletedGroupMessage);
			return cb_getDeletedGroupMessage;
		}

		static IntPtr n_GetDeletedGroupMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeletedGroupMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setDeletedGroupMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeletedGroupMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setDeletedGroupMessage_Ljava_lang_String_ == null)
				cb_setDeletedGroupMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDeletedGroupMessage_Ljava_lang_String_);
			return cb_setDeletedGroupMessage_Ljava_lang_String_;
		}

		static void n_SetDeletedGroupMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeletedGroupMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDeletedGroupMessage;
		static IntPtr id_setDeletedGroupMessage_Ljava_lang_String_;
		public virtual unsafe string DeletedGroupMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getDeletedGroupMessage' and count(parameter)=0]"
			[Register ("getDeletedGroupMessage", "()Ljava/lang/String;", "GetGetDeletedGroupMessageHandler")]
			get {
				if (id_getDeletedGroupMessage == IntPtr.Zero)
					id_getDeletedGroupMessage = JNIEnv.GetMethodID (class_ref, "getDeletedGroupMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeletedGroupMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeletedGroupMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setDeletedGroupMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeletedGroupMessage", "(Ljava/lang/String;)V", "GetSetDeletedGroupMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setDeletedGroupMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setDeletedGroupMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDeletedGroupMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeletedGroupMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeletedGroupMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGroupIconChangeMessage;
#pragma warning disable 0169
		static Delegate GetGetGroupIconChangeMessageHandler ()
		{
			if (cb_getGroupIconChangeMessage == null)
				cb_getGroupIconChangeMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupIconChangeMessage);
			return cb_getGroupIconChangeMessage;
		}

		static IntPtr n_GetGroupIconChangeMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupIconChangeMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupIconChangeMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupIconChangeMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupIconChangeMessage_Ljava_lang_String_ == null)
				cb_setGroupIconChangeMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupIconChangeMessage_Ljava_lang_String_);
			return cb_setGroupIconChangeMessage_Ljava_lang_String_;
		}

		static void n_SetGroupIconChangeMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupIconChangeMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupIconChangeMessage;
		static IntPtr id_setGroupIconChangeMessage_Ljava_lang_String_;
		public virtual unsafe string GroupIconChangeMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getGroupIconChangeMessage' and count(parameter)=0]"
			[Register ("getGroupIconChangeMessage", "()Ljava/lang/String;", "GetGetGroupIconChangeMessageHandler")]
			get {
				if (id_getGroupIconChangeMessage == IntPtr.Zero)
					id_getGroupIconChangeMessage = JNIEnv.GetMethodID (class_ref, "getGroupIconChangeMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupIconChangeMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupIconChangeMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setGroupIconChangeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupIconChangeMessage", "(Ljava/lang/String;)V", "GetSetGroupIconChangeMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupIconChangeMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupIconChangeMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupIconChangeMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupIconChangeMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupIconChangeMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGroupLeftMessage;
#pragma warning disable 0169
		static Delegate GetGetGroupLeftMessageHandler ()
		{
			if (cb_getGroupLeftMessage == null)
				cb_getGroupLeftMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupLeftMessage);
			return cb_getGroupLeftMessage;
		}

		static IntPtr n_GetGroupLeftMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupLeftMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupLeftMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupLeftMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupLeftMessage_Ljava_lang_String_ == null)
				cb_setGroupLeftMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupLeftMessage_Ljava_lang_String_);
			return cb_setGroupLeftMessage_Ljava_lang_String_;
		}

		static void n_SetGroupLeftMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupLeftMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupLeftMessage;
		static IntPtr id_setGroupLeftMessage_Ljava_lang_String_;
		public virtual unsafe string GroupLeftMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getGroupLeftMessage' and count(parameter)=0]"
			[Register ("getGroupLeftMessage", "()Ljava/lang/String;", "GetGetGroupLeftMessageHandler")]
			get {
				if (id_getGroupLeftMessage == IntPtr.Zero)
					id_getGroupLeftMessage = JNIEnv.GetMethodID (class_ref, "getGroupLeftMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupLeftMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupLeftMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setGroupLeftMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupLeftMessage", "(Ljava/lang/String;)V", "GetSetGroupLeftMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupLeftMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupLeftMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupLeftMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupLeftMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupLeftMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getGroupNameChangeMessage;
#pragma warning disable 0169
		static Delegate GetGetGroupNameChangeMessageHandler ()
		{
			if (cb_getGroupNameChangeMessage == null)
				cb_getGroupNameChangeMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupNameChangeMessage);
			return cb_getGroupNameChangeMessage;
		}

		static IntPtr n_GetGroupNameChangeMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupNameChangeMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setGroupNameChangeMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGroupNameChangeMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setGroupNameChangeMessage_Ljava_lang_String_ == null)
				cb_setGroupNameChangeMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGroupNameChangeMessage_Ljava_lang_String_);
			return cb_setGroupNameChangeMessage_Ljava_lang_String_;
		}

		static void n_SetGroupNameChangeMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupNameChangeMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupNameChangeMessage;
		static IntPtr id_setGroupNameChangeMessage_Ljava_lang_String_;
		public virtual unsafe string GroupNameChangeMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getGroupNameChangeMessage' and count(parameter)=0]"
			[Register ("getGroupNameChangeMessage", "()Ljava/lang/String;", "GetGetGroupNameChangeMessageHandler")]
			get {
				if (id_getGroupNameChangeMessage == IntPtr.Zero)
					id_getGroupNameChangeMessage = JNIEnv.GetMethodID (class_ref, "getGroupNameChangeMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupNameChangeMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupNameChangeMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setGroupNameChangeMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setGroupNameChangeMessage", "(Ljava/lang/String;)V", "GetSetGroupNameChangeMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setGroupNameChangeMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setGroupNameChangeMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGroupNameChangeMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGroupNameChangeMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGroupNameChangeMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHideMetaDataNotification;
#pragma warning disable 0169
		static Delegate GetGetHideMetaDataNotificationHandler ()
		{
			if (cb_getHideMetaDataNotification == null)
				cb_getHideMetaDataNotification = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHideMetaDataNotification);
			return cb_getHideMetaDataNotification;
		}

		static bool n_GetHideMetaDataNotification (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideMetaDataNotification;
		}
#pragma warning restore 0169

		static Delegate cb_setHideMetaDataNotification_Z;
#pragma warning disable 0169
		static Delegate GetSetHideMetaDataNotification_ZHandler ()
		{
			if (cb_setHideMetaDataNotification_Z == null)
				cb_setHideMetaDataNotification_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideMetaDataNotification_Z);
			return cb_setHideMetaDataNotification_Z;
		}

		static void n_SetHideMetaDataNotification_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideMetaDataNotification = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getHideMetaDataNotification;
		static IntPtr id_setHideMetaDataNotification_Z;
		public virtual unsafe bool HideMetaDataNotification {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getHideMetaDataNotification' and count(parameter)=0]"
			[Register ("getHideMetaDataNotification", "()Z", "GetGetHideMetaDataNotificationHandler")]
			get {
				if (id_getHideMetaDataNotification == IntPtr.Zero)
					id_getHideMetaDataNotification = JNIEnv.GetMethodID (class_ref, "getHideMetaDataNotification", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getHideMetaDataNotification);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHideMetaDataNotification", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setHideMetaDataNotification' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHideMetaDataNotification", "(Z)V", "GetSetHideMetaDataNotification_ZHandler")]
			set {
				if (id_setHideMetaDataNotification_Z == IntPtr.Zero)
					id_setHideMetaDataNotification_Z = JNIEnv.GetMethodID (class_ref, "setHideMetaDataNotification", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHideMetaDataNotification_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideMetaDataNotification", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getJoinMemberMessage;
#pragma warning disable 0169
		static Delegate GetGetJoinMemberMessageHandler ()
		{
			if (cb_getJoinMemberMessage == null)
				cb_getJoinMemberMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJoinMemberMessage);
			return cb_getJoinMemberMessage;
		}

		static IntPtr n_GetJoinMemberMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JoinMemberMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setJoinMemberMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetJoinMemberMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setJoinMemberMessage_Ljava_lang_String_ == null)
				cb_setJoinMemberMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetJoinMemberMessage_Ljava_lang_String_);
			return cb_setJoinMemberMessage_Ljava_lang_String_;
		}

		static void n_SetJoinMemberMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.JoinMemberMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getJoinMemberMessage;
		static IntPtr id_setJoinMemberMessage_Ljava_lang_String_;
		public virtual unsafe string JoinMemberMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getJoinMemberMessage' and count(parameter)=0]"
			[Register ("getJoinMemberMessage", "()Ljava/lang/String;", "GetGetJoinMemberMessageHandler")]
			get {
				if (id_getJoinMemberMessage == IntPtr.Zero)
					id_getJoinMemberMessage = JNIEnv.GetMethodID (class_ref, "getJoinMemberMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJoinMemberMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJoinMemberMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setJoinMemberMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setJoinMemberMessage", "(Ljava/lang/String;)V", "GetSetJoinMemberMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setJoinMemberMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setJoinMemberMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setJoinMemberMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setJoinMemberMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setJoinMemberMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRemoveMemberMessage;
#pragma warning disable 0169
		static Delegate GetGetRemoveMemberMessageHandler ()
		{
			if (cb_getRemoveMemberMessage == null)
				cb_getRemoveMemberMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRemoveMemberMessage);
			return cb_getRemoveMemberMessage;
		}

		static IntPtr n_GetRemoveMemberMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RemoveMemberMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setRemoveMemberMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRemoveMemberMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setRemoveMemberMessage_Ljava_lang_String_ == null)
				cb_setRemoveMemberMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRemoveMemberMessage_Ljava_lang_String_);
			return cb_setRemoveMemberMessage_Ljava_lang_String_;
		}

		static void n_SetRemoveMemberMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.ChannelMetadata> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMemberMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRemoveMemberMessage;
		static IntPtr id_setRemoveMemberMessage_Ljava_lang_String_;
		public virtual unsafe string RemoveMemberMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='getRemoveMemberMessage' and count(parameter)=0]"
			[Register ("getRemoveMemberMessage", "()Ljava/lang/String;", "GetGetRemoveMemberMessageHandler")]
			get {
				if (id_getRemoveMemberMessage == IntPtr.Zero)
					id_getRemoveMemberMessage = JNIEnv.GetMethodID (class_ref, "getRemoveMemberMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRemoveMemberMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRemoveMemberMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='ChannelMetadata']/method[@name='setRemoveMemberMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRemoveMemberMessage", "(Ljava/lang/String;)V", "GetSetRemoveMemberMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setRemoveMemberMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setRemoveMemberMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRemoveMemberMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRemoveMemberMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRemoveMemberMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
