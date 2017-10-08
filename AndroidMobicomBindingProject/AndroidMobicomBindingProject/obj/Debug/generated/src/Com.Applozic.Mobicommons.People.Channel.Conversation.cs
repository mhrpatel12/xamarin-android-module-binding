using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicommons.People.Channel {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']"
	[global::Android.Runtime.Register ("com/applozic/mobicommons/people/channel/Conversation", DoNotGenerateAcw=true)]
	public partial class Conversation : global::Com.Applozic.Mobicommons.Json.JsonMarker {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/field[@name='FALL_BACK_TEMPLATE_KEY']"
		[Register ("FALL_BACK_TEMPLATE_KEY")]
		public const string FallBackTemplateKey = (string) "fallBackTemplate";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/field[@name='USER_ID_KEY']"
		[Register ("USER_ID_KEY")]
		public const string UserIdKey = (string) "userId";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicommons/people/channel/Conversation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Conversation); }
		}

		protected Conversation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/constructor[@name='Conversation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Conversation ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Conversation)) {
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

		static Delegate cb_getApplicationKey;
#pragma warning disable 0169
		static Delegate GetGetApplicationKeyHandler ()
		{
			if (cb_getApplicationKey == null)
				cb_getApplicationKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationKey);
			return cb_getApplicationKey;
		}

		static IntPtr n_GetApplicationKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApplicationKey);
		}
#pragma warning restore 0169

		static Delegate cb_setApplicationKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetApplicationKey_Ljava_lang_String_Handler ()
		{
			if (cb_setApplicationKey_Ljava_lang_String_ == null)
				cb_setApplicationKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetApplicationKey_Ljava_lang_String_);
			return cb_setApplicationKey_Ljava_lang_String_;
		}

		static void n_SetApplicationKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ApplicationKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getApplicationKey;
		static IntPtr id_setApplicationKey_Ljava_lang_String_;
		public virtual unsafe string ApplicationKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getApplicationKey' and count(parameter)=0]"
			[Register ("getApplicationKey", "()Ljava/lang/String;", "GetGetApplicationKeyHandler")]
			get {
				if (id_getApplicationKey == IntPtr.Zero)
					id_getApplicationKey = JNIEnv.GetMethodID (class_ref, "getApplicationKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApplicationKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApplicationKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setApplicationKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setApplicationKey", "(Ljava/lang/String;)V", "GetSetApplicationKey_Ljava_lang_String_Handler")]
			set {
				if (id_setApplicationKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setApplicationKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setApplicationKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setApplicationKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setApplicationKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Closed;
		}
#pragma warning restore 0169

		static Delegate cb_setClosed_Z;
#pragma warning disable 0169
		static Delegate GetSetClosed_ZHandler ()
		{
			if (cb_setClosed_Z == null)
				cb_setClosed_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetClosed_Z);
			return cb_setClosed_Z;
		}

		static void n_SetClosed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Closed = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isClosed;
		static IntPtr id_setClosed_Z;
		public virtual unsafe bool Closed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isClosed", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setClosed' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setClosed", "(Z)V", "GetSetClosed_ZHandler")]
			set {
				if (id_setClosed_Z == IntPtr.Zero)
					id_setClosed_Z = JNIEnv.GetMethodID (class_ref, "setClosed", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setClosed_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setClosed", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCreated;
#pragma warning disable 0169
		static Delegate GetIsCreatedHandler ()
		{
			if (cb_isCreated == null)
				cb_isCreated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCreated);
			return cb_isCreated;
		}

		static bool n_IsCreated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Created;
		}
#pragma warning restore 0169

		static Delegate cb_setCreated_Z;
#pragma warning disable 0169
		static Delegate GetSetCreated_ZHandler ()
		{
			if (cb_setCreated_Z == null)
				cb_setCreated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCreated_Z);
			return cb_setCreated_Z;
		}

		static void n_SetCreated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Created = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isCreated;
		static IntPtr id_setCreated_Z;
		public virtual unsafe bool Created {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='isCreated' and count(parameter)=0]"
			[Register ("isCreated", "()Z", "GetIsCreatedHandler")]
			get {
				if (id_isCreated == IntPtr.Zero)
					id_isCreated = JNIEnv.GetMethodID (class_ref, "isCreated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCreated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCreated", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setCreated' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setCreated", "(Z)V", "GetSetCreated_ZHandler")]
			set {
				if (id_setCreated_Z == IntPtr.Zero)
					id_setCreated_Z = JNIEnv.GetMethodID (class_ref, "setCreated", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCreated_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCreated", "(Z)V"), __args);
				} finally {
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
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GroupId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getGroupId;
		static IntPtr id_setGroupId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getGroupId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setGroupId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getId;
		static IntPtr id_setId_Ljava_lang_Integer_;
		public virtual unsafe global::Java.Lang.Integer Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
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

		static Delegate cb_getSenderUserName;
#pragma warning disable 0169
		static Delegate GetGetSenderUserNameHandler ()
		{
			if (cb_getSenderUserName == null)
				cb_getSenderUserName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSenderUserName);
			return cb_getSenderUserName;
		}

		static IntPtr n_GetSenderUserName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SenderUserName);
		}
#pragma warning restore 0169

		static Delegate cb_setSenderUserName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenderUserName_Ljava_lang_String_Handler ()
		{
			if (cb_setSenderUserName_Ljava_lang_String_ == null)
				cb_setSenderUserName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSenderUserName_Ljava_lang_String_);
			return cb_setSenderUserName_Ljava_lang_String_;
		}

		static void n_SetSenderUserName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SenderUserName = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSenderUserName;
		static IntPtr id_setSenderUserName_Ljava_lang_String_;
		public virtual unsafe string SenderUserName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getSenderUserName' and count(parameter)=0]"
			[Register ("getSenderUserName", "()Ljava/lang/String;", "GetGetSenderUserNameHandler")]
			get {
				if (id_getSenderUserName == IntPtr.Zero)
					id_getSenderUserName = JNIEnv.GetMethodID (class_ref, "getSenderUserName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSenderUserName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSenderUserName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setSenderUserName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSenderUserName", "(Ljava/lang/String;)V", "GetSetSenderUserName_Ljava_lang_String_Handler")]
			set {
				if (id_setSenderUserName_Ljava_lang_String_ == IntPtr.Zero)
					id_setSenderUserName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderUserName", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderUserName_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderUserName", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSupportIds;
#pragma warning disable 0169
		static Delegate GetGetSupportIdsHandler ()
		{
			if (cb_getSupportIds == null)
				cb_getSupportIds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSupportIds);
			return cb_getSupportIds;
		}

		static IntPtr n_GetSupportIds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.SupportIds);
		}
#pragma warning restore 0169

		static Delegate cb_setSupportIds_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSupportIds_Ljava_util_List_Handler ()
		{
			if (cb_setSupportIds_Ljava_util_List_ == null)
				cb_setSupportIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSupportIds_Ljava_util_List_);
			return cb_setSupportIds_Ljava_util_List_;
		}

		static void n_SetSupportIds_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SupportIds = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSupportIds;
		static IntPtr id_setSupportIds_Ljava_util_List_;
		public virtual unsafe global::System.Collections.Generic.IList<string> SupportIds {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getSupportIds' and count(parameter)=0]"
			[Register ("getSupportIds", "()Ljava/util/List;", "GetGetSupportIdsHandler")]
			get {
				if (id_getSupportIds == IntPtr.Zero)
					id_getSupportIds = JNIEnv.GetMethodID (class_ref, "getSupportIds", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportIds), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSupportIds", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setSupportIds' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setSupportIds", "(Ljava/util/List;)V", "GetSetSupportIds_Ljava_util_List_Handler")]
			set {
				if (id_setSupportIds_Ljava_util_List_ == IntPtr.Zero)
					id_setSupportIds_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setSupportIds", "(Ljava/util/List;)V");
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSupportIds_Ljava_util_List_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSupportIds", "(Ljava/util/List;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTopicDetail;
#pragma warning disable 0169
		static Delegate GetGetTopicDetailHandler ()
		{
			if (cb_getTopicDetail == null)
				cb_getTopicDetail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopicDetail);
			return cb_getTopicDetail;
		}

		static IntPtr n_GetTopicDetail (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TopicDetail);
		}
#pragma warning restore 0169

		static Delegate cb_setTopicDetail_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopicDetail_Ljava_lang_String_Handler ()
		{
			if (cb_setTopicDetail_Ljava_lang_String_ == null)
				cb_setTopicDetail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopicDetail_Ljava_lang_String_);
			return cb_setTopicDetail_Ljava_lang_String_;
		}

		static void n_SetTopicDetail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TopicDetail = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopicDetail;
		static IntPtr id_setTopicDetail_Ljava_lang_String_;
		public virtual unsafe string TopicDetail {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getTopicDetail' and count(parameter)=0]"
			[Register ("getTopicDetail", "()Ljava/lang/String;", "GetGetTopicDetailHandler")]
			get {
				if (id_getTopicDetail == IntPtr.Zero)
					id_getTopicDetail = JNIEnv.GetMethodID (class_ref, "getTopicDetail", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopicDetail), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopicDetail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setTopicDetail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopicDetail", "(Ljava/lang/String;)V", "GetSetTopicDetail_Ljava_lang_String_Handler")]
			set {
				if (id_setTopicDetail_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopicDetail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopicDetail", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopicDetail_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopicDetail", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTopicId;
#pragma warning disable 0169
		static Delegate GetGetTopicIdHandler ()
		{
			if (cb_getTopicId == null)
				cb_getTopicId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopicId);
			return cb_getTopicId;
		}

		static IntPtr n_GetTopicId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TopicId);
		}
#pragma warning restore 0169

		static Delegate cb_setTopicId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopicId_Ljava_lang_String_Handler ()
		{
			if (cb_setTopicId_Ljava_lang_String_ == null)
				cb_setTopicId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopicId_Ljava_lang_String_);
			return cb_setTopicId_Ljava_lang_String_;
		}

		static void n_SetTopicId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TopicId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopicId;
		static IntPtr id_setTopicId_Ljava_lang_String_;
		public virtual unsafe string TopicId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getTopicId' and count(parameter)=0]"
			[Register ("getTopicId", "()Ljava/lang/String;", "GetGetTopicIdHandler")]
			get {
				if (id_getTopicId == IntPtr.Zero)
					id_getTopicId = JNIEnv.GetMethodID (class_ref, "getTopicId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopicId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopicId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setTopicId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopicId", "(Ljava/lang/String;)V", "GetSetTopicId_Ljava_lang_String_Handler")]
			set {
				if (id_setTopicId_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopicId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopicId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopicId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopicId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTopicLocalImageUri;
#pragma warning disable 0169
		static Delegate GetGetTopicLocalImageUriHandler ()
		{
			if (cb_getTopicLocalImageUri == null)
				cb_getTopicLocalImageUri = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTopicLocalImageUri);
			return cb_getTopicLocalImageUri;
		}

		static IntPtr n_GetTopicLocalImageUri (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TopicLocalImageUri);
		}
#pragma warning restore 0169

		static Delegate cb_setTopicLocalImageUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTopicLocalImageUri_Ljava_lang_String_Handler ()
		{
			if (cb_setTopicLocalImageUri_Ljava_lang_String_ == null)
				cb_setTopicLocalImageUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTopicLocalImageUri_Ljava_lang_String_);
			return cb_setTopicLocalImageUri_Ljava_lang_String_;
		}

		static void n_SetTopicLocalImageUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TopicLocalImageUri = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getTopicLocalImageUri;
		static IntPtr id_setTopicLocalImageUri_Ljava_lang_String_;
		public virtual unsafe string TopicLocalImageUri {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getTopicLocalImageUri' and count(parameter)=0]"
			[Register ("getTopicLocalImageUri", "()Ljava/lang/String;", "GetGetTopicLocalImageUriHandler")]
			get {
				if (id_getTopicLocalImageUri == IntPtr.Zero)
					id_getTopicLocalImageUri = JNIEnv.GetMethodID (class_ref, "getTopicLocalImageUri", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTopicLocalImageUri), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTopicLocalImageUri", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setTopicLocalImageUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTopicLocalImageUri", "(Ljava/lang/String;)V", "GetSetTopicLocalImageUri_Ljava_lang_String_Handler")]
			set {
				if (id_setTopicLocalImageUri_Ljava_lang_String_ == IntPtr.Zero)
					id_setTopicLocalImageUri_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTopicLocalImageUri", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTopicLocalImageUri_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTopicLocalImageUri", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserId);
			return cb_getUserId;
		}

		static IntPtr n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserId);
		}
#pragma warning restore 0169

		static Delegate cb_setUserId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUserId_Ljava_lang_String_Handler ()
		{
			if (cb_setUserId_Ljava_lang_String_ == null)
				cb_setUserId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUserId_Ljava_lang_String_);
			return cb_setUserId_Ljava_lang_String_;
		}

		static void n_SetUserId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get {
				if (id_getUserId == IntPtr.Zero)
					id_getUserId = JNIEnv.GetMethodID (class_ref, "getUserId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUserId", "(Ljava/lang/String;)V", "GetSetUserId_Ljava_lang_String_Handler")]
			set {
				if (id_setUserId_Ljava_lang_String_ == IntPtr.Zero)
					id_setUserId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setUserId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_);
			return cb_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetReceiverSmsFormat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setReceiverSmsFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setReceiverSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetReceiverSmsFormat (string p0, string p1)
		{
			if (id_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setReceiverSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReceiverSmsFormat_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReceiverSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_);
			return cb_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSenderSmsFormat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setSenderSmsFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSenderSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSenderSmsFormat (string p0, string p1)
		{
			if (id_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSenderSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSenderSmsFormat_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSenderSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_setSmsFormat_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setSmsFormat_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSmsFormat_Ljava_lang_String_Ljava_lang_String_);
			return cb_setSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetSmsFormat_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Applozic.Mobicommons.People.Channel.Conversation __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicommons.People.Channel.Conversation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetSmsFormat (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setSmsFormat_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicommons.people.channel']/class[@name='Conversation']/method[@name='setSmsFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetSmsFormat_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSmsFormat (string p0, string p1)
		{
			if (id_setSmsFormat_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setSmsFormat_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmsFormat_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmsFormat", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
