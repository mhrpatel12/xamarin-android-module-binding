using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Feed {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/feed/GroupInfoUpdate", DoNotGenerateAcw=true)]
	public partial class GroupInfoUpdate : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/feed/GroupInfoUpdate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GroupInfoUpdate); }
		}

		protected GroupInfoUpdate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/constructor[@name='GroupInfoUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GroupInfoUpdate (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (GroupInfoUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/constructor[@name='GroupInfoUpdate' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe GroupInfoUpdate (string p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (GroupInfoUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;I)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_I == IntPtr.Zero)
					id_ctor_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_I, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Lcom_applozic_mobicommons_people_channel_Channel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/constructor[@name='GroupInfoUpdate' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicommons.people.channel.Channel']]"
		[Register (".ctor", "(Lcom/applozic/mobicommons/people/channel/Channel;)V", "")]
		public unsafe GroupInfoUpdate (global::Com.Applozic.Mobicommons.People.Channel.Channel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GroupInfoUpdate)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/constructor[@name='GroupInfoUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GroupInfoUpdate (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (GroupInfoUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_Integer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/constructor[@name='GroupInfoUpdate' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register (".ctor", "(Ljava/lang/Integer;)V", "")]
		public unsafe GroupInfoUpdate (global::Java.Lang.Integer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (GroupInfoUpdate)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Integer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Integer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Integer_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Integer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Integer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Integer_, __args);
			} finally {
			}
		}

		static Delegate cb_getChildKeys;
#pragma warning disable 0169
		static Delegate GetGetChildKeysHandler ()
		{
			if (cb_getChildKeys == null)
				cb_getChildKeys = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChildKeys);
			return cb_getChildKeys;
		}

		static IntPtr n_GetChildKeys (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ChildKeys);
		}
#pragma warning restore 0169

		static Delegate cb_setChildKeys_Ljava_util_Set_;
#pragma warning disable 0169
		static Delegate GetSetChildKeys_Ljava_util_Set_Handler ()
		{
			if (cb_setChildKeys_Ljava_util_Set_ == null)
				cb_setChildKeys_Ljava_util_Set_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChildKeys_Ljava_util_Set_);
			return cb_setChildKeys_Ljava_util_Set_;
		}

		static void n_SetChildKeys_Ljava_util_Set_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ChildKeys = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getChildKeys;
		static IntPtr id_setChildKeys_Ljava_util_Set_;
		public virtual unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ChildKeys {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getChildKeys' and count(parameter)=0]"
			[Register ("getChildKeys", "()Ljava/util/Set;", "GetGetChildKeysHandler")]
			get {
				if (id_getChildKeys == IntPtr.Zero)
					id_getChildKeys = JNIEnv.GetMethodID (class_ref, "getChildKeys", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChildKeys), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChildKeys", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setChildKeys' and count(parameter)=1 and parameter[1][@type='java.util.Set&lt;java.lang.Integer&gt;']]"
			[Register ("setChildKeys", "(Ljava/util/Set;)V", "GetSetChildKeys_Ljava_util_Set_Handler")]
			set {
				if (id_setChildKeys_Ljava_util_Set_ == IntPtr.Zero)
					id_setChildKeys_Ljava_util_Set_ = JNIEnv.GetMethodID (class_ref, "setChildKeys", "(Ljava/util/Set;)V");
				IntPtr native_value = global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChildKeys_Ljava_util_Set_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChildKeys", "(Ljava/util/Set;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientGroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getClientGroupId;
		static IntPtr id_setClientGroupId_Ljava_lang_String_;
		public virtual unsafe string ClientGroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getClientGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setClientGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getContentUri;
#pragma warning disable 0169
		static Delegate GetGetContentUriHandler ()
		{
			if (cb_getContentUri == null)
				cb_getContentUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentUri);
			return cb_getContentUri;
		}

		static IntPtr n_GetContentUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContentUri);
		}
#pragma warning restore 0169

		static Delegate cb_setContentUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContentUri_Ljava_lang_String_Handler ()
		{
			if (cb_setContentUri_Ljava_lang_String_ == null)
				cb_setContentUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContentUri_Ljava_lang_String_);
			return cb_setContentUri_Ljava_lang_String_;
		}

		static void n_SetContentUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContentUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContentUri;
		static IntPtr id_setContentUri_Ljava_lang_String_;
		public virtual unsafe string ContentUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getContentUri' and count(parameter)=0]"
			[Register ("getContentUri", "()Ljava/lang/String;", "GetGetContentUriHandler")]
			get {
				if (id_getContentUri == IntPtr.Zero)
					id_getContentUri = JNIEnv.GetMethodID (class_ref, "getContentUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContentUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setContentUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContentUri", "(Ljava/lang/String;)V", "GetSetContentUri_Ljava_lang_String_Handler")]
			set {
				if (id_setContentUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setContentUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContentUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContentUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContentUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupId;
		static IntPtr id_setGroupId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageUrl;
		static IntPtr id_setImageUrl_Ljava_lang_String_;
		public virtual unsafe string ImageUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getImageUrl' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setImageUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLocalImagePath;
#pragma warning disable 0169
		static Delegate GetGetLocalImagePathHandler ()
		{
			if (cb_getLocalImagePath == null)
				cb_getLocalImagePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLocalImagePath);
			return cb_getLocalImagePath;
		}

		static IntPtr n_GetLocalImagePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LocalImagePath);
		}
#pragma warning restore 0169

		static Delegate cb_setLocalImagePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLocalImagePath_Ljava_lang_String_Handler ()
		{
			if (cb_setLocalImagePath_Ljava_lang_String_ == null)
				cb_setLocalImagePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLocalImagePath_Ljava_lang_String_);
			return cb_setLocalImagePath_Ljava_lang_String_;
		}

		static void n_SetLocalImagePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.LocalImagePath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLocalImagePath;
		static IntPtr id_setLocalImagePath_Ljava_lang_String_;
		public virtual unsafe string LocalImagePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getLocalImagePath' and count(parameter)=0]"
			[Register ("getLocalImagePath", "()Ljava/lang/String;", "GetGetLocalImagePathHandler")]
			get {
				if (id_getLocalImagePath == IntPtr.Zero)
					id_getLocalImagePath = JNIEnv.GetMethodID (class_ref, "getLocalImagePath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalImagePath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLocalImagePath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setLocalImagePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocalImagePath", "(Ljava/lang/String;)V", "GetSetLocalImagePath_Ljava_lang_String_Handler")]
			set {
				if (id_setLocalImagePath_Ljava_lang_String_ == IntPtr.Zero)
					id_setLocalImagePath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLocalImagePath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLocalImagePath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLocalImagePath", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getMetadata' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewName;
		static IntPtr id_setNewName_Ljava_lang_String_;
		public virtual unsafe string NewName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getNewName' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setNewName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getNewlocalPath;
#pragma warning disable 0169
		static Delegate GetGetNewlocalPathHandler ()
		{
			if (cb_getNewlocalPath == null)
				cb_getNewlocalPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNewlocalPath);
			return cb_getNewlocalPath;
		}

		static IntPtr n_GetNewlocalPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NewlocalPath);
		}
#pragma warning restore 0169

		static Delegate cb_setNewlocalPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNewlocalPath_Ljava_lang_String_Handler ()
		{
			if (cb_setNewlocalPath_Ljava_lang_String_ == null)
				cb_setNewlocalPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNewlocalPath_Ljava_lang_String_);
			return cb_setNewlocalPath_Ljava_lang_String_;
		}

		static void n_SetNewlocalPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NewlocalPath = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNewlocalPath;
		static IntPtr id_setNewlocalPath_Ljava_lang_String_;
		public virtual unsafe string NewlocalPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getNewlocalPath' and count(parameter)=0]"
			[Register ("getNewlocalPath", "()Ljava/lang/String;", "GetGetNewlocalPathHandler")]
			get {
				if (id_getNewlocalPath == IntPtr.Zero)
					id_getNewlocalPath = JNIEnv.GetMethodID (class_ref, "getNewlocalPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNewlocalPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNewlocalPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setNewlocalPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNewlocalPath", "(Ljava/lang/String;)V", "GetSetNewlocalPath_Ljava_lang_String_Handler")]
			set {
				if (id_setNewlocalPath_Ljava_lang_String_ == IntPtr.Zero)
					id_setNewlocalPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setNewlocalPath", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNewlocalPath_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNewlocalPath", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getParentKey;
#pragma warning disable 0169
		static Delegate GetGetParentKeyHandler ()
		{
			if (cb_getParentKey == null)
				cb_getParentKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParentKey);
			return cb_getParentKey;
		}

		static IntPtr n_GetParentKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ParentKey);
		}
#pragma warning restore 0169

		static Delegate cb_setParentKey_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSetParentKey_Ljava_lang_Integer_Handler ()
		{
			if (cb_setParentKey_Ljava_lang_Integer_ == null)
				cb_setParentKey_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetParentKey_Ljava_lang_Integer_);
			return cb_setParentKey_Ljava_lang_Integer_;
		}

		static void n_SetParentKey_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ParentKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getParentKey;
		static IntPtr id_setParentKey_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer ParentKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getParentKey' and count(parameter)=0]"
			[Register ("getParentKey", "()Ljava/lang/Integer;", "GetGetParentKeyHandler")]
			get {
				if (id_getParentKey == IntPtr.Zero)
					id_getParentKey = JNIEnv.GetMethodID (class_ref, "getParentKey", "()Ljava/lang/Integer;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParentKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParentKey", "()Ljava/lang/Integer;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setParentKey' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
			[Register ("setParentKey", "(Ljava/lang/Integer;)V", "GetSetParentKey_Ljava_lang_Integer_Handler")]
			set {
				if (id_setParentKey_Ljava_lang_Integer_ == IntPtr.Zero)
					id_setParentKey_Ljava_lang_Integer_ = JNIEnv.GetMethodID (class_ref, "setParentKey", "(Ljava/lang/Integer;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setParentKey_Ljava_lang_Integer_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setParentKey", "(Ljava/lang/Integer;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed>.ToLocalJniHandle (__this.Users);
		}
#pragma warning restore 0169

		static Delegate cb_setUsers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetUsers_Ljava_util_List_Handler ()
		{
			if (cb_setUsers_Ljava_util_List_ == null)
				cb_setUsers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUsers_Ljava_util_List_);
			return cb_setUsers_Ljava_util_List_;
		}

		static void n_SetUsers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Feed.GroupInfoUpdate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Users = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUsers;
		static IntPtr id_setUsers_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed> Users {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='getUsers' and count(parameter)=0]"
			[Register ("getUsers", "()Ljava/util/List;", "GetGetUsersHandler")]
			get {
				if (id_getUsers == IntPtr.Zero)
					id_getUsers = JNIEnv.GetMethodID (class_ref, "getUsers", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsers), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUsers", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.feed']/class[@name='GroupInfoUpdate']/method[@name='setUsers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applozic.mobicomkit.feed.ChannelUsersFeed&gt;']]"
			[Register ("setUsers", "(Ljava/util/List;)V", "GetSetUsers_Ljava_util_List_Handler")]
			set {
				if (id_setUsers_Ljava_util_List_ == IntPtr.Zero)
					id_setUsers_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setUsers", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applozic.Mobicomkit.Feed.ChannelUsersFeed>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUsers_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUsers", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
