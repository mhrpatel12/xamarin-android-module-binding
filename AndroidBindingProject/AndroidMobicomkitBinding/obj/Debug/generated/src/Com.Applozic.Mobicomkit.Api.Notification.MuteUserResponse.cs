using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Api.Notification {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/api/notification/MuteUserResponse", DoNotGenerateAcw=true)]
	public partial class MuteUserResponse : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/api/notification/MuteUserResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MuteUserResponse); }
		}

		protected MuteUserResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/constructor[@name='MuteUserResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MuteUserResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MuteUserResponse)) {
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

		static Delegate cb_isActive;
#pragma warning disable 0169
		static Delegate GetIsActiveHandler ()
		{
			if (cb_isActive == null)
				cb_isActive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActive);
			return cb_isActive;
		}

		static bool n_IsActive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Active;
		}
#pragma warning restore 0169

		static Delegate cb_setActive_Z;
#pragma warning disable 0169
		static Delegate GetSetActive_ZHandler ()
		{
			if (cb_setActive_Z == null)
				cb_setActive_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetActive_Z);
			return cb_setActive_Z;
		}

		static void n_SetActive_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Active = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isActive;
		static IntPtr id_setActive_Z;
		public virtual unsafe bool Active {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='isActive' and count(parameter)=0]"
			[Register ("isActive", "()Z", "GetIsActiveHandler")]
			get {
				if (id_isActive == IntPtr.Zero)
					id_isActive = JNIEnv.GetMethodID (class_ref, "isActive", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isActive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isActive", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setActive' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setActive", "(Z)V", "GetSetActive_ZHandler")]
			set {
				if (id_setActive_Z == IntPtr.Zero)
					id_setActive_Z = JNIEnv.GetMethodID (class_ref, "setActive", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActive_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActive", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Connected;
		}
#pragma warning restore 0169

		static Delegate cb_setConnected_Z;
#pragma warning disable 0169
		static Delegate GetSetConnected_ZHandler ()
		{
			if (cb_setConnected_Z == null)
				cb_setConnected_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetConnected_Z);
			return cb_setConnected_Z;
		}

		static void n_SetConnected_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connected = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isConnected;
		static IntPtr id_setConnected_Z;
		public virtual unsafe bool Connected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				if (id_isConnected == IntPtr.Zero)
					id_isConnected = JNIEnv.GetMethodID (class_ref, "isConnected", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConnected);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConnected", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setConnected' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setConnected", "(Z)V", "GetSetConnected_ZHandler")]
			set {
				if (id_setConnected_Z == IntPtr.Zero)
					id_setConnected_Z = JNIEnv.GetMethodID (class_ref, "setConnected", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnected_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnected", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getConnectedClientCount;
#pragma warning disable 0169
		static Delegate GetGetConnectedClientCountHandler ()
		{
			if (cb_getConnectedClientCount == null)
				cb_getConnectedClientCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetConnectedClientCount);
			return cb_getConnectedClientCount;
		}

		static int n_GetConnectedClientCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ConnectedClientCount;
		}
#pragma warning restore 0169

		static Delegate cb_setConnectedClientCount_I;
#pragma warning disable 0169
		static Delegate GetSetConnectedClientCount_IHandler ()
		{
			if (cb_setConnectedClientCount_I == null)
				cb_setConnectedClientCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetConnectedClientCount_I);
			return cb_setConnectedClientCount_I;
		}

		static void n_SetConnectedClientCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectedClientCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getConnectedClientCount;
		static IntPtr id_setConnectedClientCount_I;
		public virtual unsafe int ConnectedClientCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getConnectedClientCount' and count(parameter)=0]"
			[Register ("getConnectedClientCount", "()I", "GetGetConnectedClientCountHandler")]
			get {
				if (id_getConnectedClientCount == IntPtr.Zero)
					id_getConnectedClientCount = JNIEnv.GetMethodID (class_ref, "getConnectedClientCount", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getConnectedClientCount);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConnectedClientCount", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setConnectedClientCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setConnectedClientCount", "(I)V", "GetSetConnectedClientCount_IHandler")]
			set {
				if (id_setConnectedClientCount_I == IntPtr.Zero)
					id_setConnectedClientCount_I = JNIEnv.GetMethodID (class_ref, "setConnectedClientCount", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConnectedClientCount_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConnectedClientCount", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDeactivated;
#pragma warning disable 0169
		static Delegate GetIsDeactivatedHandler ()
		{
			if (cb_isDeactivated == null)
				cb_isDeactivated = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeactivated);
			return cb_isDeactivated;
		}

		static bool n_IsDeactivated (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Deactivated;
		}
#pragma warning restore 0169

		static Delegate cb_setDeactivated_Z;
#pragma warning disable 0169
		static Delegate GetSetDeactivated_ZHandler ()
		{
			if (cb_setDeactivated_Z == null)
				cb_setDeactivated_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeactivated_Z);
			return cb_setDeactivated_Z;
		}

		static void n_SetDeactivated_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Deactivated = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDeactivated;
		static IntPtr id_setDeactivated_Z;
		public virtual unsafe bool Deactivated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='isDeactivated' and count(parameter)=0]"
			[Register ("isDeactivated", "()Z", "GetIsDeactivatedHandler")]
			get {
				if (id_isDeactivated == IntPtr.Zero)
					id_isDeactivated = JNIEnv.GetMethodID (class_ref, "isDeactivated", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeactivated);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeactivated", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setDeactivated' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeactivated", "(Z)V", "GetSetDeactivated_ZHandler")]
			set {
				if (id_setDeactivated_Z == IntPtr.Zero)
					id_setDeactivated_Z = JNIEnv.GetMethodID (class_ref, "setDeactivated", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeactivated_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeactivated", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageLink;
#pragma warning disable 0169
		static Delegate GetGetImageLinkHandler ()
		{
			if (cb_getImageLink == null)
				cb_getImageLink = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageLink);
			return cb_getImageLink;
		}

		static IntPtr n_GetImageLink (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ImageLink);
		}
#pragma warning restore 0169

		static Delegate cb_setImageLink_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImageLink_Ljava_lang_String_Handler ()
		{
			if (cb_setImageLink_Ljava_lang_String_ == null)
				cb_setImageLink_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageLink_Ljava_lang_String_);
			return cb_setImageLink_Ljava_lang_String_;
		}

		static void n_SetImageLink_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ImageLink = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getImageLink;
		static IntPtr id_setImageLink_Ljava_lang_String_;
		public virtual unsafe string ImageLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getImageLink' and count(parameter)=0]"
			[Register ("getImageLink", "()Ljava/lang/String;", "GetGetImageLinkHandler")]
			get {
				if (id_getImageLink == IntPtr.Zero)
					id_getImageLink = JNIEnv.GetMethodID (class_ref, "getImageLink", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getImageLink), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getImageLink", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setImageLink' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setImageLink", "(Ljava/lang/String;)V", "GetSetImageLink_Ljava_lang_String_Handler")]
			set {
				if (id_setImageLink_Ljava_lang_String_ == IntPtr.Zero)
					id_setImageLink_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setImageLink", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageLink_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageLink", "(Ljava/lang/String;)V"), __args);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Metadata = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMetadata;
		static IntPtr id_setMetadata_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getMetadata' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setMetadata' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NotificationAfterTime = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getNotificationAfterTime;
		static IntPtr id_setNotificationAfterTime_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long NotificationAfterTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getNotificationAfterTime' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setNotificationAfterTime' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnreadCount = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUnreadCount;
		static IntPtr id_setUnreadCount_I;
		public virtual unsafe int UnreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getUnreadCount' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setUnreadCount' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Api.Notification.MuteUserResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UserId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getUserId;
		static IntPtr id_setUserId_Ljava_lang_String_;
		public virtual unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='getUserId' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.api.notification']/class[@name='MuteUserResponse']/method[@name='setUserId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

	}
}
