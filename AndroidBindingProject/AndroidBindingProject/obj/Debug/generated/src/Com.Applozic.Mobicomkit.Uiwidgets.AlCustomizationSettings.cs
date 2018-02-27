using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Applozic.Mobicomkit.Uiwidgets {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']"
	[global::Android.Runtime.Register ("com/applozic/mobicomkit/uiwidgets/AlCustomizationSettings", DoNotGenerateAcw=true)]
	public partial class AlCustomizationSettings : global::Com.Applozic.Mobicommons.Json.JsonMarker {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/applozic/mobicomkit/uiwidgets/AlCustomizationSettings", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AlCustomizationSettings); }
		}

		protected AlCustomizationSettings (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/constructor[@name='AlCustomizationSettings' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AlCustomizationSettings ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AlCustomizationSettings)) {
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

		static Delegate cb_getAdminBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetAdminBackgroundColorHandler ()
		{
			if (cb_getAdminBackgroundColor == null)
				cb_getAdminBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminBackgroundColor);
			return cb_getAdminBackgroundColor;
		}

		static IntPtr n_GetAdminBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getAdminBackgroundColor;
		public virtual unsafe string AdminBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAdminBackgroundColor' and count(parameter)=0]"
			[Register ("getAdminBackgroundColor", "()Ljava/lang/String;", "GetGetAdminBackgroundColorHandler")]
			get {
				if (id_getAdminBackgroundColor == IntPtr.Zero)
					id_getAdminBackgroundColor = JNIEnv.GetMethodID (class_ref, "getAdminBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdminBorderColor;
#pragma warning disable 0169
		static Delegate GetGetAdminBorderColorHandler ()
		{
			if (cb_getAdminBorderColor == null)
				cb_getAdminBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminBorderColor);
			return cb_getAdminBorderColor;
		}

		static IntPtr n_GetAdminBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminBorderColor);
		}
#pragma warning restore 0169

		static IntPtr id_getAdminBorderColor;
		public virtual unsafe string AdminBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAdminBorderColor' and count(parameter)=0]"
			[Register ("getAdminBorderColor", "()Ljava/lang/String;", "GetGetAdminBorderColorHandler")]
			get {
				if (id_getAdminBorderColor == IntPtr.Zero)
					id_getAdminBorderColor = JNIEnv.GetMethodID (class_ref, "getAdminBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAdminTextColor;
#pragma warning disable 0169
		static Delegate GetGetAdminTextColorHandler ()
		{
			if (cb_getAdminTextColor == null)
				cb_getAdminTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAdminTextColor);
			return cb_getAdminTextColor;
		}

		static IntPtr n_GetAdminTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdminTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getAdminTextColor;
		public virtual unsafe string AdminTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAdminTextColor' and count(parameter)=0]"
			[Register ("getAdminTextColor", "()Ljava/lang/String;", "GetGetAdminTextColorHandler")]
			get {
				if (id_getAdminTextColor == IntPtr.Zero)
					id_getAdminTextColor = JNIEnv.GetMethodID (class_ref, "getAdminTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdminTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAdminTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttachCameraIconName;
#pragma warning disable 0169
		static Delegate GetGetAttachCameraIconNameHandler ()
		{
			if (cb_getAttachCameraIconName == null)
				cb_getAttachCameraIconName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachCameraIconName);
			return cb_getAttachCameraIconName;
		}

		static IntPtr n_GetAttachCameraIconName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AttachCameraIconName);
		}
#pragma warning restore 0169

		static IntPtr id_getAttachCameraIconName;
		public virtual unsafe string AttachCameraIconName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAttachCameraIconName' and count(parameter)=0]"
			[Register ("getAttachCameraIconName", "()Ljava/lang/String;", "GetGetAttachCameraIconNameHandler")]
			get {
				if (id_getAttachCameraIconName == IntPtr.Zero)
					id_getAttachCameraIconName = JNIEnv.GetMethodID (class_ref, "getAttachCameraIconName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttachCameraIconName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttachCameraIconName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttachmentIconsBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetAttachmentIconsBackgroundColorHandler ()
		{
			if (cb_getAttachmentIconsBackgroundColor == null)
				cb_getAttachmentIconsBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachmentIconsBackgroundColor);
			return cb_getAttachmentIconsBackgroundColor;
		}

		static IntPtr n_GetAttachmentIconsBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AttachmentIconsBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getAttachmentIconsBackgroundColor;
		public virtual unsafe string AttachmentIconsBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAttachmentIconsBackgroundColor' and count(parameter)=0]"
			[Register ("getAttachmentIconsBackgroundColor", "()Ljava/lang/String;", "GetGetAttachmentIconsBackgroundColorHandler")]
			get {
				if (id_getAttachmentIconsBackgroundColor == IntPtr.Zero)
					id_getAttachmentIconsBackgroundColor = JNIEnv.GetMethodID (class_ref, "getAttachmentIconsBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttachmentIconsBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttachmentIconsBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAttachmentOptions;
#pragma warning disable 0169
		static Delegate GetGetAttachmentOptionsHandler ()
		{
			if (cb_getAttachmentOptions == null)
				cb_getAttachmentOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttachmentOptions);
			return cb_getAttachmentOptions;
		}

		static IntPtr n_GetAttachmentOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (__this.AttachmentOptions);
		}
#pragma warning restore 0169

		static Delegate cb_setAttachmentOptions_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSetAttachmentOptions_Ljava_util_Map_Handler ()
		{
			if (cb_setAttachmentOptions_Ljava_util_Map_ == null)
				cb_setAttachmentOptions_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAttachmentOptions_Ljava_util_Map_);
			return cb_setAttachmentOptions_Ljava_util_Map_;
		}

		static void n_SetAttachmentOptions_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AttachmentOptions = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAttachmentOptions;
		static IntPtr id_setAttachmentOptions_Ljava_util_Map_;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Boolean> AttachmentOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAttachmentOptions' and count(parameter)=0]"
			[Register ("getAttachmentOptions", "()Ljava/util/Map;", "GetGetAttachmentOptionsHandler")]
			get {
				if (id_getAttachmentOptions == IntPtr.Zero)
					id_getAttachmentOptions = JNIEnv.GetMethodID (class_ref, "getAttachmentOptions", "()Ljava/util/Map;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAttachmentOptions), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttachmentOptions", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setAttachmentOptions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Boolean&gt;']]"
			[Register ("setAttachmentOptions", "(Ljava/util/Map;)V", "GetSetAttachmentOptions_Ljava_util_Map_Handler")]
			set {
				if (id_setAttachmentOptions_Ljava_util_Map_ == IntPtr.Zero)
					id_setAttachmentOptions_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "setAttachmentOptions", "(Ljava/util/Map;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Boolean>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAttachmentOptions_Ljava_util_Map_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAttachmentOptions", "(Ljava/util/Map;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAudioPermissionNotFoundMsg;
#pragma warning disable 0169
		static Delegate GetGetAudioPermissionNotFoundMsgHandler ()
		{
			if (cb_getAudioPermissionNotFoundMsg == null)
				cb_getAudioPermissionNotFoundMsg = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAudioPermissionNotFoundMsg);
			return cb_getAudioPermissionNotFoundMsg;
		}

		static IntPtr n_GetAudioPermissionNotFoundMsg (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioPermissionNotFoundMsg);
		}
#pragma warning restore 0169

		static IntPtr id_getAudioPermissionNotFoundMsg;
		public virtual unsafe string AudioPermissionNotFoundMsg {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getAudioPermissionNotFoundMsg' and count(parameter)=0]"
			[Register ("getAudioPermissionNotFoundMsg", "()Ljava/lang/String;", "GetGetAudioPermissionNotFoundMsgHandler")]
			get {
				if (id_getAudioPermissionNotFoundMsg == IntPtr.Zero)
					id_getAudioPermissionNotFoundMsg = JNIEnv.GetMethodID (class_ref, "getAudioPermissionNotFoundMsg", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAudioPermissionNotFoundMsg), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAudioPermissionNotFoundMsg", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBlockOption;
#pragma warning disable 0169
		static Delegate GetIsBlockOptionHandler ()
		{
			if (cb_isBlockOption == null)
				cb_isBlockOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBlockOption);
			return cb_isBlockOption;
		}

		static bool n_IsBlockOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BlockOption;
		}
#pragma warning restore 0169

		static Delegate cb_setBlockOption_Z;
#pragma warning disable 0169
		static Delegate GetSetBlockOption_ZHandler ()
		{
			if (cb_setBlockOption_Z == null)
				cb_setBlockOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetBlockOption_Z);
			return cb_setBlockOption_Z;
		}

		static void n_SetBlockOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BlockOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isBlockOption;
		static IntPtr id_setBlockOption_Z;
		public virtual unsafe bool BlockOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isBlockOption' and count(parameter)=0]"
			[Register ("isBlockOption", "()Z", "GetIsBlockOptionHandler")]
			get {
				if (id_isBlockOption == IntPtr.Zero)
					id_isBlockOption = JNIEnv.GetMethodID (class_ref, "isBlockOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBlockOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBlockOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setBlockOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBlockOption", "(Z)V", "GetSetBlockOption_ZHandler")]
			set {
				if (id_setBlockOption_Z == IntPtr.Zero)
					id_setBlockOption_Z = JNIEnv.GetMethodID (class_ref, "setBlockOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlockOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlockOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMessageBgColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMessageBgColorHandler ()
		{
			if (cb_getChannelCustomMessageBgColor == null)
				cb_getChannelCustomMessageBgColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelCustomMessageBgColor);
			return cb_getChannelCustomMessageBgColor;
		}

		static IntPtr n_GetChannelCustomMessageBgColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelCustomMessageBgColor);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMessageBgColor;
		public virtual unsafe string ChannelCustomMessageBgColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getChannelCustomMessageBgColor' and count(parameter)=0]"
			[Register ("getChannelCustomMessageBgColor", "()Ljava/lang/String;", "GetGetChannelCustomMessageBgColorHandler")]
			get {
				if (id_getChannelCustomMessageBgColor == IntPtr.Zero)
					id_getChannelCustomMessageBgColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMessageBgColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMessageBgColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMessageBgColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMessageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMessageBorderColorHandler ()
		{
			if (cb_getChannelCustomMessageBorderColor == null)
				cb_getChannelCustomMessageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelCustomMessageBorderColor);
			return cb_getChannelCustomMessageBorderColor;
		}

		static IntPtr n_GetChannelCustomMessageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelCustomMessageBorderColor);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMessageBorderColor;
		public virtual unsafe string ChannelCustomMessageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getChannelCustomMessageBorderColor' and count(parameter)=0]"
			[Register ("getChannelCustomMessageBorderColor", "()Ljava/lang/String;", "GetGetChannelCustomMessageBorderColorHandler")]
			get {
				if (id_getChannelCustomMessageBorderColor == IntPtr.Zero)
					id_getChannelCustomMessageBorderColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMessageBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMessageBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMessageBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelCustomMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetChannelCustomMessageTextColorHandler ()
		{
			if (cb_getChannelCustomMessageTextColor == null)
				cb_getChannelCustomMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChannelCustomMessageTextColor);
			return cb_getChannelCustomMessageTextColor;
		}

		static IntPtr n_GetChannelCustomMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChannelCustomMessageTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getChannelCustomMessageTextColor;
		public virtual unsafe string ChannelCustomMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getChannelCustomMessageTextColor' and count(parameter)=0]"
			[Register ("getChannelCustomMessageTextColor", "()Ljava/lang/String;", "GetGetChannelCustomMessageTextColorHandler")]
			get {
				if (id_getChannelCustomMessageTextColor == IntPtr.Zero)
					id_getChannelCustomMessageTextColor = JNIEnv.GetMethodID (class_ref, "getChannelCustomMessageTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChannelCustomMessageTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChannelCustomMessageTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChatBackgroundColorOrDrawable;
#pragma warning disable 0169
		static Delegate GetGetChatBackgroundColorOrDrawableHandler ()
		{
			if (cb_getChatBackgroundColorOrDrawable == null)
				cb_getChatBackgroundColorOrDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChatBackgroundColorOrDrawable);
			return cb_getChatBackgroundColorOrDrawable;
		}

		static IntPtr n_GetChatBackgroundColorOrDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChatBackgroundColorOrDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_getChatBackgroundColorOrDrawable;
		public virtual unsafe string ChatBackgroundColorOrDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getChatBackgroundColorOrDrawable' and count(parameter)=0]"
			[Register ("getChatBackgroundColorOrDrawable", "()Ljava/lang/String;", "GetGetChatBackgroundColorOrDrawableHandler")]
			get {
				if (id_getChatBackgroundColorOrDrawable == IntPtr.Zero)
					id_getChatBackgroundColorOrDrawable = JNIEnv.GetMethodID (class_ref, "getChatBackgroundColorOrDrawable", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChatBackgroundColorOrDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChatBackgroundColorOrDrawable", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChatBackgroundImageName;
#pragma warning disable 0169
		static Delegate GetGetChatBackgroundImageNameHandler ()
		{
			if (cb_getChatBackgroundImageName == null)
				cb_getChatBackgroundImageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChatBackgroundImageName);
			return cb_getChatBackgroundImageName;
		}

		static IntPtr n_GetChatBackgroundImageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ChatBackgroundImageName);
		}
#pragma warning restore 0169

		static IntPtr id_getChatBackgroundImageName;
		public virtual unsafe string ChatBackgroundImageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getChatBackgroundImageName' and count(parameter)=0]"
			[Register ("getChatBackgroundImageName", "()Ljava/lang/String;", "GetGetChatBackgroundImageNameHandler")]
			get {
				if (id_getChatBackgroundImageName == IntPtr.Zero)
					id_getChatBackgroundImageName = JNIEnv.GetMethodID (class_ref, "getChatBackgroundImageName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getChatBackgroundImageName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getChatBackgroundImageName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCollapsingToolbarLayoutColor;
#pragma warning disable 0169
		static Delegate GetGetCollapsingToolbarLayoutColorHandler ()
		{
			if (cb_getCollapsingToolbarLayoutColor == null)
				cb_getCollapsingToolbarLayoutColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCollapsingToolbarLayoutColor);
			return cb_getCollapsingToolbarLayoutColor;
		}

		static IntPtr n_GetCollapsingToolbarLayoutColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CollapsingToolbarLayoutColor);
		}
#pragma warning restore 0169

		static IntPtr id_getCollapsingToolbarLayoutColor;
		public virtual unsafe string CollapsingToolbarLayoutColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getCollapsingToolbarLayoutColor' and count(parameter)=0]"
			[Register ("getCollapsingToolbarLayoutColor", "()Ljava/lang/String;", "GetGetCollapsingToolbarLayoutColorHandler")]
			get {
				if (id_getCollapsingToolbarLayoutColor == IntPtr.Zero)
					id_getCollapsingToolbarLayoutColor = JNIEnv.GetMethodID (class_ref, "getCollapsingToolbarLayoutColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCollapsingToolbarLayoutColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCollapsingToolbarLayoutColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationDateTextColor;
#pragma warning disable 0169
		static Delegate GetGetConversationDateTextColorHandler ()
		{
			if (cb_getConversationDateTextColor == null)
				cb_getConversationDateTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationDateTextColor);
			return cb_getConversationDateTextColor;
		}

		static IntPtr n_GetConversationDateTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationDateTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationDateTextColor;
		public virtual unsafe string ConversationDateTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getConversationDateTextColor' and count(parameter)=0]"
			[Register ("getConversationDateTextColor", "()Ljava/lang/String;", "GetGetConversationDateTextColorHandler")]
			get {
				if (id_getConversationDateTextColor == IntPtr.Zero)
					id_getConversationDateTextColor = JNIEnv.GetMethodID (class_ref, "getConversationDateTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationDateTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationDateTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getConversationDayTextColor;
#pragma warning disable 0169
		static Delegate GetGetConversationDayTextColorHandler ()
		{
			if (cb_getConversationDayTextColor == null)
				cb_getConversationDayTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConversationDayTextColor);
			return cb_getConversationDayTextColor;
		}

		static IntPtr n_GetConversationDayTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ConversationDayTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getConversationDayTextColor;
		public virtual unsafe string ConversationDayTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getConversationDayTextColor' and count(parameter)=0]"
			[Register ("getConversationDayTextColor", "()Ljava/lang/String;", "GetGetConversationDayTextColorHandler")]
			get {
				if (id_getConversationDayTextColor == IntPtr.Zero)
					id_getConversationDayTextColor = JNIEnv.GetMethodID (class_ref, "getConversationDayTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConversationDayTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConversationDayTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCustomMessageBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetCustomMessageBackgroundColorHandler ()
		{
			if (cb_getCustomMessageBackgroundColor == null)
				cb_getCustomMessageBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomMessageBackgroundColor);
			return cb_getCustomMessageBackgroundColor;
		}

		static IntPtr n_GetCustomMessageBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CustomMessageBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getCustomMessageBackgroundColor;
		public virtual unsafe string CustomMessageBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getCustomMessageBackgroundColor' and count(parameter)=0]"
			[Register ("getCustomMessageBackgroundColor", "()Ljava/lang/String;", "GetGetCustomMessageBackgroundColorHandler")]
			get {
				if (id_getCustomMessageBackgroundColor == IntPtr.Zero)
					id_getCustomMessageBackgroundColor = JNIEnv.GetMethodID (class_ref, "getCustomMessageBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomMessageBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomMessageBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultGroupType;
#pragma warning disable 0169
		static Delegate GetGetDefaultGroupTypeHandler ()
		{
			if (cb_getDefaultGroupType == null)
				cb_getDefaultGroupType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDefaultGroupType);
			return cb_getDefaultGroupType;
		}

		static int n_GetDefaultGroupType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DefaultGroupType;
		}
#pragma warning restore 0169

		static Delegate cb_setDefaultGroupType_I;
#pragma warning disable 0169
		static Delegate GetSetDefaultGroupType_IHandler ()
		{
			if (cb_setDefaultGroupType_I == null)
				cb_setDefaultGroupType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDefaultGroupType_I);
			return cb_setDefaultGroupType_I;
		}

		static void n_SetDefaultGroupType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DefaultGroupType = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getDefaultGroupType;
		static IntPtr id_setDefaultGroupType_I;
		public virtual unsafe int DefaultGroupType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getDefaultGroupType' and count(parameter)=0]"
			[Register ("getDefaultGroupType", "()I", "GetGetDefaultGroupTypeHandler")]
			get {
				if (id_getDefaultGroupType == IntPtr.Zero)
					id_getDefaultGroupType = JNIEnv.GetMethodID (class_ref, "getDefaultGroupType", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultGroupType);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDefaultGroupType", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setDefaultGroupType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDefaultGroupType", "(I)V", "GetSetDefaultGroupType_IHandler")]
			set {
				if (id_setDefaultGroupType_I == IntPtr.Zero)
					id_setDefaultGroupType_I = JNIEnv.GetMethodID (class_ref, "setDefaultGroupType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDefaultGroupType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDefaultGroupType", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDeleteOption;
#pragma warning disable 0169
		static Delegate GetIsDeleteOptionHandler ()
		{
			if (cb_isDeleteOption == null)
				cb_isDeleteOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDeleteOption);
			return cb_isDeleteOption;
		}

		static bool n_IsDeleteOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeleteOption;
		}
#pragma warning restore 0169

		static Delegate cb_setDeleteOption_Z;
#pragma warning disable 0169
		static Delegate GetSetDeleteOption_ZHandler ()
		{
			if (cb_setDeleteOption_Z == null)
				cb_setDeleteOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDeleteOption_Z);
			return cb_setDeleteOption_Z;
		}

		static void n_SetDeleteOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isDeleteOption;
		static IntPtr id_setDeleteOption_Z;
		public virtual unsafe bool DeleteOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isDeleteOption' and count(parameter)=0]"
			[Register ("isDeleteOption", "()Z", "GetIsDeleteOptionHandler")]
			get {
				if (id_isDeleteOption == IntPtr.Zero)
					id_isDeleteOption = JNIEnv.GetMethodID (class_ref, "isDeleteOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDeleteOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isDeleteOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setDeleteOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDeleteOption", "(Z)V", "GetSetDeleteOption_ZHandler")]
			set {
				if (id_setDeleteOption_Z == IntPtr.Zero)
					id_setDeleteOption_Z = JNIEnv.GetMethodID (class_ref, "setDeleteOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDeleteOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDeleteOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEditTextBackgroundColorOrDrawable;
#pragma warning disable 0169
		static Delegate GetGetEditTextBackgroundColorOrDrawableHandler ()
		{
			if (cb_getEditTextBackgroundColorOrDrawable == null)
				cb_getEditTextBackgroundColorOrDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditTextBackgroundColorOrDrawable);
			return cb_getEditTextBackgroundColorOrDrawable;
		}

		static IntPtr n_GetEditTextBackgroundColorOrDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EditTextBackgroundColorOrDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_getEditTextBackgroundColorOrDrawable;
		public virtual unsafe string EditTextBackgroundColorOrDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getEditTextBackgroundColorOrDrawable' and count(parameter)=0]"
			[Register ("getEditTextBackgroundColorOrDrawable", "()Ljava/lang/String;", "GetGetEditTextBackgroundColorOrDrawableHandler")]
			get {
				if (id_getEditTextBackgroundColorOrDrawable == IntPtr.Zero)
					id_getEditTextBackgroundColorOrDrawable = JNIEnv.GetMethodID (class_ref, "getEditTextBackgroundColorOrDrawable", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditTextBackgroundColorOrDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditTextBackgroundColorOrDrawable", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEditTextHintText;
#pragma warning disable 0169
		static Delegate GetGetEditTextHintTextHandler ()
		{
			if (cb_getEditTextHintText == null)
				cb_getEditTextHintText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditTextHintText);
			return cb_getEditTextHintText;
		}

		static IntPtr n_GetEditTextHintText (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EditTextHintText);
		}
#pragma warning restore 0169

		static IntPtr id_getEditTextHintText;
		public virtual unsafe string EditTextHintText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getEditTextHintText' and count(parameter)=0]"
			[Register ("getEditTextHintText", "()Ljava/lang/String;", "GetGetEditTextHintTextHandler")]
			get {
				if (id_getEditTextHintText == IntPtr.Zero)
					id_getEditTextHintText = JNIEnv.GetMethodID (class_ref, "getEditTextHintText", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditTextHintText), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditTextHintText", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEditTextLayoutBackgroundColorOrDrawable;
#pragma warning disable 0169
		static Delegate GetGetEditTextLayoutBackgroundColorOrDrawableHandler ()
		{
			if (cb_getEditTextLayoutBackgroundColorOrDrawable == null)
				cb_getEditTextLayoutBackgroundColorOrDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEditTextLayoutBackgroundColorOrDrawable);
			return cb_getEditTextLayoutBackgroundColorOrDrawable;
		}

		static IntPtr n_GetEditTextLayoutBackgroundColorOrDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EditTextLayoutBackgroundColorOrDrawable);
		}
#pragma warning restore 0169

		static IntPtr id_getEditTextLayoutBackgroundColorOrDrawable;
		public virtual unsafe string EditTextLayoutBackgroundColorOrDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getEditTextLayoutBackgroundColorOrDrawable' and count(parameter)=0]"
			[Register ("getEditTextLayoutBackgroundColorOrDrawable", "()Ljava/lang/String;", "GetGetEditTextLayoutBackgroundColorOrDrawableHandler")]
			get {
				if (id_getEditTextLayoutBackgroundColorOrDrawable == IntPtr.Zero)
					id_getEditTextLayoutBackgroundColorOrDrawable = JNIEnv.GetMethodID (class_ref, "getEditTextLayoutBackgroundColorOrDrawable", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEditTextLayoutBackgroundColorOrDrawable), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEditTextLayoutBackgroundColorOrDrawable", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isForwardOption;
#pragma warning disable 0169
		static Delegate GetIsForwardOptionHandler ()
		{
			if (cb_isForwardOption == null)
				cb_isForwardOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsForwardOption);
			return cb_isForwardOption;
		}

		static bool n_IsForwardOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForwardOption;
		}
#pragma warning restore 0169

		static Delegate cb_setForwardOption_Z;
#pragma warning disable 0169
		static Delegate GetSetForwardOption_ZHandler ()
		{
			if (cb_setForwardOption_Z == null)
				cb_setForwardOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetForwardOption_Z);
			return cb_setForwardOption_Z;
		}

		static void n_SetForwardOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ForwardOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isForwardOption;
		static IntPtr id_setForwardOption_Z;
		public virtual unsafe bool ForwardOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isForwardOption' and count(parameter)=0]"
			[Register ("isForwardOption", "()Z", "GetIsForwardOptionHandler")]
			get {
				if (id_isForwardOption == IntPtr.Zero)
					id_isForwardOption = JNIEnv.GetMethodID (class_ref, "isForwardOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isForwardOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isForwardOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setForwardOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setForwardOption", "(Z)V", "GetSetForwardOption_ZHandler")]
			set {
				if (id_setForwardOption_Z == IntPtr.Zero)
					id_setForwardOption_Z = JNIEnv.GetMethodID (class_ref, "setForwardOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setForwardOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setForwardOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupDeleteButtonBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetGroupDeleteButtonBackgroundColorHandler ()
		{
			if (cb_getGroupDeleteButtonBackgroundColor == null)
				cb_getGroupDeleteButtonBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupDeleteButtonBackgroundColor);
			return cb_getGroupDeleteButtonBackgroundColor;
		}

		static IntPtr n_GetGroupDeleteButtonBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupDeleteButtonBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getGroupDeleteButtonBackgroundColor;
		public virtual unsafe string GroupDeleteButtonBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getGroupDeleteButtonBackgroundColor' and count(parameter)=0]"
			[Register ("getGroupDeleteButtonBackgroundColor", "()Ljava/lang/String;", "GetGetGroupDeleteButtonBackgroundColorHandler")]
			get {
				if (id_getGroupDeleteButtonBackgroundColor == IntPtr.Zero)
					id_getGroupDeleteButtonBackgroundColor = JNIEnv.GetMethodID (class_ref, "getGroupDeleteButtonBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupDeleteButtonBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupDeleteButtonBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupExitButtonBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetGroupExitButtonBackgroundColorHandler ()
		{
			if (cb_getGroupExitButtonBackgroundColor == null)
				cb_getGroupExitButtonBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupExitButtonBackgroundColor);
			return cb_getGroupExitButtonBackgroundColor;
		}

		static IntPtr n_GetGroupExitButtonBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupExitButtonBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getGroupExitButtonBackgroundColor;
		public virtual unsafe string GroupExitButtonBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getGroupExitButtonBackgroundColor' and count(parameter)=0]"
			[Register ("getGroupExitButtonBackgroundColor", "()Ljava/lang/String;", "GetGetGroupExitButtonBackgroundColorHandler")]
			get {
				if (id_getGroupExitButtonBackgroundColor == IntPtr.Zero)
					id_getGroupExitButtonBackgroundColor = JNIEnv.GetMethodID (class_ref, "getGroupExitButtonBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupExitButtonBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupExitButtonBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupParticipantsTextColor;
#pragma warning disable 0169
		static Delegate GetGetGroupParticipantsTextColorHandler ()
		{
			if (cb_getGroupParticipantsTextColor == null)
				cb_getGroupParticipantsTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGroupParticipantsTextColor);
			return cb_getGroupParticipantsTextColor;
		}

		static IntPtr n_GetGroupParticipantsTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GroupParticipantsTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getGroupParticipantsTextColor;
		public virtual unsafe string GroupParticipantsTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getGroupParticipantsTextColor' and count(parameter)=0]"
			[Register ("getGroupParticipantsTextColor", "()Ljava/lang/String;", "GetGetGroupParticipantsTextColorHandler")]
			get {
				if (id_getGroupParticipantsTextColor == IntPtr.Zero)
					id_getGroupParticipantsTextColor = JNIEnv.GetMethodID (class_ref, "getGroupParticipantsTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGroupParticipantsTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGroupParticipantsTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isHideAttachmentButton;
#pragma warning disable 0169
		static Delegate GetIsHideAttachmentButtonHandler ()
		{
			if (cb_isHideAttachmentButton == null)
				cb_isHideAttachmentButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideAttachmentButton);
			return cb_isHideAttachmentButton;
		}

		static bool n_IsHideAttachmentButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HideAttachmentButton;
		}
#pragma warning restore 0169

		static Delegate cb_setHideAttachmentButton_Z;
#pragma warning disable 0169
		static Delegate GetSetHideAttachmentButton_ZHandler ()
		{
			if (cb_setHideAttachmentButton_Z == null)
				cb_setHideAttachmentButton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHideAttachmentButton_Z);
			return cb_setHideAttachmentButton_Z;
		}

		static void n_SetHideAttachmentButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideAttachmentButton = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isHideAttachmentButton;
		static IntPtr id_setHideAttachmentButton_Z;
		public virtual unsafe bool HideAttachmentButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isHideAttachmentButton' and count(parameter)=0]"
			[Register ("isHideAttachmentButton", "()Z", "GetIsHideAttachmentButtonHandler")]
			get {
				if (id_isHideAttachmentButton == IntPtr.Zero)
					id_isHideAttachmentButton = JNIEnv.GetMethodID (class_ref, "isHideAttachmentButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideAttachmentButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideAttachmentButton", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setHideAttachmentButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHideAttachmentButton", "(Z)V", "GetSetHideAttachmentButton_ZHandler")]
			set {
				if (id_setHideAttachmentButton_Z == IntPtr.Zero)
					id_setHideAttachmentButton_Z = JNIEnv.GetMethodID (class_ref, "setHideAttachmentButton", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHideAttachmentButton_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHideAttachmentButton", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isBroadcastOption;
#pragma warning disable 0169
		static Delegate GetIsBroadcastOptionHandler ()
		{
			if (cb_isBroadcastOption == null)
				cb_isBroadcastOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBroadcastOption);
			return cb_isBroadcastOption;
		}

		static bool n_IsBroadcastOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBroadcastOption;
		}
#pragma warning restore 0169

		static IntPtr id_isBroadcastOption;
		public virtual unsafe bool IsBroadcastOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isBroadcastOption' and count(parameter)=0]"
			[Register ("isBroadcastOption", "()Z", "GetIsBroadcastOptionHandler")]
			get {
				if (id_isBroadcastOption == IntPtr.Zero)
					id_isBroadcastOption = JNIEnv.GetMethodID (class_ref, "isBroadcastOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBroadcastOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBroadcastOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isConversationContactImageVisibility;
#pragma warning disable 0169
		static Delegate GetIsConversationContactImageVisibilityHandler ()
		{
			if (cb_isConversationContactImageVisibility == null)
				cb_isConversationContactImageVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsConversationContactImageVisibility);
			return cb_isConversationContactImageVisibility;
		}

		static bool n_IsConversationContactImageVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConversationContactImageVisibility;
		}
#pragma warning restore 0169

		static IntPtr id_isConversationContactImageVisibility;
		public virtual unsafe bool IsConversationContactImageVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isConversationContactImageVisibility' and count(parameter)=0]"
			[Register ("isConversationContactImageVisibility", "()Z", "GetIsConversationContactImageVisibilityHandler")]
			get {
				if (id_isConversationContactImageVisibility == IntPtr.Zero)
					id_isConversationContactImageVisibility = JNIEnv.GetMethodID (class_ref, "isConversationContactImageVisibility", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isConversationContactImageVisibility);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isConversationContactImageVisibility", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isCreateAnyContact;
#pragma warning disable 0169
		static Delegate GetIsCreateAnyContactHandler ()
		{
			if (cb_isCreateAnyContact == null)
				cb_isCreateAnyContact = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCreateAnyContact);
			return cb_isCreateAnyContact;
		}

		static bool n_IsCreateAnyContact (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCreateAnyContact;
		}
#pragma warning restore 0169

		static IntPtr id_isCreateAnyContact;
		public virtual unsafe bool IsCreateAnyContact {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isCreateAnyContact' and count(parameter)=0]"
			[Register ("isCreateAnyContact", "()Z", "GetIsCreateAnyContactHandler")]
			get {
				if (id_isCreateAnyContact == IntPtr.Zero)
					id_isCreateAnyContact = JNIEnv.GetMethodID (class_ref, "isCreateAnyContact", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCreateAnyContact);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCreateAnyContact", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isGroupInfoScreenVisible;
#pragma warning disable 0169
		static Delegate GetIsGroupInfoScreenVisibleHandler ()
		{
			if (cb_isGroupInfoScreenVisible == null)
				cb_isGroupInfoScreenVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGroupInfoScreenVisible);
			return cb_isGroupInfoScreenVisible;
		}

		static bool n_IsGroupInfoScreenVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGroupInfoScreenVisible;
		}
#pragma warning restore 0169

		static IntPtr id_isGroupInfoScreenVisible;
		public virtual unsafe bool IsGroupInfoScreenVisible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isGroupInfoScreenVisible' and count(parameter)=0]"
			[Register ("isGroupInfoScreenVisible", "()Z", "GetIsGroupInfoScreenVisibleHandler")]
			get {
				if (id_isGroupInfoScreenVisible == IntPtr.Zero)
					id_isGroupInfoScreenVisible = JNIEnv.GetMethodID (class_ref, "isGroupInfoScreenVisible", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGroupInfoScreenVisible);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGroupInfoScreenVisible", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isGroupUsersOnlineStatus;
#pragma warning disable 0169
		static Delegate GetIsGroupUsersOnlineStatusHandler ()
		{
			if (cb_isGroupUsersOnlineStatus == null)
				cb_isGroupUsersOnlineStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGroupUsersOnlineStatus);
			return cb_isGroupUsersOnlineStatus;
		}

		static bool n_IsGroupUsersOnlineStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGroupUsersOnlineStatus;
		}
#pragma warning restore 0169

		static IntPtr id_isGroupUsersOnlineStatus;
		public virtual unsafe bool IsGroupUsersOnlineStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isGroupUsersOnlineStatus' and count(parameter)=0]"
			[Register ("isGroupUsersOnlineStatus", "()Z", "GetIsGroupUsersOnlineStatusHandler")]
			get {
				if (id_isGroupUsersOnlineStatus == IntPtr.Zero)
					id_isGroupUsersOnlineStatus = JNIEnv.GetMethodID (class_ref, "isGroupUsersOnlineStatus", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGroupUsersOnlineStatus);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGroupUsersOnlineStatus", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupAddMembersButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupAddMembersButtonHandler ()
		{
			if (cb_isHideGroupAddMembersButton == null)
				cb_isHideGroupAddMembersButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupAddMembersButton);
			return cb_isHideGroupAddMembersButton;
		}

		static bool n_IsHideGroupAddMembersButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupAddMembersButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupAddMembersButton;
		public virtual unsafe bool IsHideGroupAddMembersButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isHideGroupAddMembersButton' and count(parameter)=0]"
			[Register ("isHideGroupAddMembersButton", "()Z", "GetIsHideGroupAddMembersButtonHandler")]
			get {
				if (id_isHideGroupAddMembersButton == IntPtr.Zero)
					id_isHideGroupAddMembersButton = JNIEnv.GetMethodID (class_ref, "isHideGroupAddMembersButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupAddMembersButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupAddMembersButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupExitButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupExitButtonHandler ()
		{
			if (cb_isHideGroupExitButton == null)
				cb_isHideGroupExitButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupExitButton);
			return cb_isHideGroupExitButton;
		}

		static bool n_IsHideGroupExitButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupExitButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupExitButton;
		public virtual unsafe bool IsHideGroupExitButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isHideGroupExitButton' and count(parameter)=0]"
			[Register ("isHideGroupExitButton", "()Z", "GetIsHideGroupExitButtonHandler")]
			get {
				if (id_isHideGroupExitButton == IntPtr.Zero)
					id_isHideGroupExitButton = JNIEnv.GetMethodID (class_ref, "isHideGroupExitButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupExitButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupExitButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupNameUpdateButton;
#pragma warning disable 0169
		static Delegate GetIsHideGroupNameUpdateButtonHandler ()
		{
			if (cb_isHideGroupNameUpdateButton == null)
				cb_isHideGroupNameUpdateButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupNameUpdateButton);
			return cb_isHideGroupNameUpdateButton;
		}

		static bool n_IsHideGroupNameUpdateButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupNameUpdateButton;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupNameUpdateButton;
		public virtual unsafe bool IsHideGroupNameUpdateButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isHideGroupNameUpdateButton' and count(parameter)=0]"
			[Register ("isHideGroupNameUpdateButton", "()Z", "GetIsHideGroupNameUpdateButtonHandler")]
			get {
				if (id_isHideGroupNameUpdateButton == IntPtr.Zero)
					id_isHideGroupNameUpdateButton = JNIEnv.GetMethodID (class_ref, "isHideGroupNameUpdateButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupNameUpdateButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupNameUpdateButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHideGroupRemoveMemberOption;
#pragma warning disable 0169
		static Delegate GetIsHideGroupRemoveMemberOptionHandler ()
		{
			if (cb_isHideGroupRemoveMemberOption == null)
				cb_isHideGroupRemoveMemberOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHideGroupRemoveMemberOption);
			return cb_isHideGroupRemoveMemberOption;
		}

		static bool n_IsHideGroupRemoveMemberOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHideGroupRemoveMemberOption;
		}
#pragma warning restore 0169

		static IntPtr id_isHideGroupRemoveMemberOption;
		public virtual unsafe bool IsHideGroupRemoveMemberOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isHideGroupRemoveMemberOption' and count(parameter)=0]"
			[Register ("isHideGroupRemoveMemberOption", "()Z", "GetIsHideGroupRemoveMemberOptionHandler")]
			get {
				if (id_isHideGroupRemoveMemberOption == IntPtr.Zero)
					id_isHideGroupRemoveMemberOption = JNIEnv.GetMethodID (class_ref, "isHideGroupRemoveMemberOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHideGroupRemoveMemberOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHideGroupRemoveMemberOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isImageCompression;
#pragma warning disable 0169
		static Delegate GetIsImageCompressionHandler ()
		{
			if (cb_isImageCompression == null)
				cb_isImageCompression = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsImageCompression);
			return cb_isImageCompression;
		}

		static bool n_IsImageCompression (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsImageCompression;
		}
#pragma warning restore 0169

		static IntPtr id_isImageCompression;
		public virtual unsafe bool IsImageCompression {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isImageCompression' and count(parameter)=0]"
			[Register ("isImageCompression", "()Z", "GetIsImageCompressionHandler")]
			get {
				if (id_isImageCompression == IntPtr.Zero)
					id_isImageCompression = JNIEnv.GetMethodID (class_ref, "isImageCompression", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isImageCompression);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isImageCompression", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInviteFriendsInContactActivity;
#pragma warning disable 0169
		static Delegate GetIsInviteFriendsInContactActivityHandler ()
		{
			if (cb_isInviteFriendsInContactActivity == null)
				cb_isInviteFriendsInContactActivity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInviteFriendsInContactActivity);
			return cb_isInviteFriendsInContactActivity;
		}

		static bool n_IsInviteFriendsInContactActivity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInviteFriendsInContactActivity;
		}
#pragma warning restore 0169

		static IntPtr id_isInviteFriendsInContactActivity;
		public virtual unsafe bool IsInviteFriendsInContactActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isInviteFriendsInContactActivity' and count(parameter)=0]"
			[Register ("isInviteFriendsInContactActivity", "()Z", "GetIsInviteFriendsInContactActivityHandler")]
			get {
				if (id_isInviteFriendsInContactActivity == IntPtr.Zero)
					id_isInviteFriendsInContactActivity = JNIEnv.GetMethodID (class_ref, "isInviteFriendsInContactActivity", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInviteFriendsInContactActivity);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInviteFriendsInContactActivity", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLaunchChatFromProfilePicOrName;
#pragma warning disable 0169
		static Delegate GetIsLaunchChatFromProfilePicOrNameHandler ()
		{
			if (cb_isLaunchChatFromProfilePicOrName == null)
				cb_isLaunchChatFromProfilePicOrName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLaunchChatFromProfilePicOrName);
			return cb_isLaunchChatFromProfilePicOrName;
		}

		static bool n_IsLaunchChatFromProfilePicOrName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLaunchChatFromProfilePicOrName;
		}
#pragma warning restore 0169

		static IntPtr id_isLaunchChatFromProfilePicOrName;
		public virtual unsafe bool IsLaunchChatFromProfilePicOrName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isLaunchChatFromProfilePicOrName' and count(parameter)=0]"
			[Register ("isLaunchChatFromProfilePicOrName", "()Z", "GetIsLaunchChatFromProfilePicOrNameHandler")]
			get {
				if (id_isLaunchChatFromProfilePicOrName == IntPtr.Zero)
					id_isLaunchChatFromProfilePicOrName = JNIEnv.GetMethodID (class_ref, "isLaunchChatFromProfilePicOrName", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLaunchChatFromProfilePicOrName);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLaunchChatFromProfilePicOrName", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLocationShareViaMap;
#pragma warning disable 0169
		static Delegate GetIsLocationShareViaMapHandler ()
		{
			if (cb_isLocationShareViaMap == null)
				cb_isLocationShareViaMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLocationShareViaMap);
			return cb_isLocationShareViaMap;
		}

		static bool n_IsLocationShareViaMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLocationShareViaMap;
		}
#pragma warning restore 0169

		static IntPtr id_isLocationShareViaMap;
		public virtual unsafe bool IsLocationShareViaMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isLocationShareViaMap' and count(parameter)=0]"
			[Register ("isLocationShareViaMap", "()Z", "GetIsLocationShareViaMapHandler")]
			get {
				if (id_isLocationShareViaMap == IntPtr.Zero)
					id_isLocationShareViaMap = JNIEnv.GetMethodID (class_ref, "isLocationShareViaMap", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLocationShareViaMap);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLocationShareViaMap", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isLogoutOption;
#pragma warning disable 0169
		static Delegate GetIsLogoutOptionHandler ()
		{
			if (cb_isLogoutOption == null)
				cb_isLogoutOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLogoutOption);
			return cb_isLogoutOption;
		}

		static bool n_IsLogoutOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLogoutOption;
		}
#pragma warning restore 0169

		static IntPtr id_isLogoutOption;
		public virtual unsafe bool IsLogoutOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isLogoutOption' and count(parameter)=0]"
			[Register ("isLogoutOption", "()Z", "GetIsLogoutOptionHandler")]
			get {
				if (id_isLogoutOption == IntPtr.Zero)
					id_isLogoutOption = JNIEnv.GetMethodID (class_ref, "isLogoutOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLogoutOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLogoutOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMessageSearchOption;
#pragma warning disable 0169
		static Delegate GetIsMessageSearchOptionHandler ()
		{
			if (cb_isMessageSearchOption == null)
				cb_isMessageSearchOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMessageSearchOption);
			return cb_isMessageSearchOption;
		}

		static bool n_IsMessageSearchOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMessageSearchOption;
		}
#pragma warning restore 0169

		static IntPtr id_isMessageSearchOption;
		public virtual unsafe bool IsMessageSearchOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isMessageSearchOption' and count(parameter)=0]"
			[Register ("isMessageSearchOption", "()Z", "GetIsMessageSearchOptionHandler")]
			get {
				if (id_isMessageSearchOption == IntPtr.Zero)
					id_isMessageSearchOption = JNIEnv.GetMethodID (class_ref, "isMessageSearchOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMessageSearchOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMessageSearchOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isMuteUserChatOption;
#pragma warning disable 0169
		static Delegate GetIsMuteUserChatOptionHandler ()
		{
			if (cb_isMuteUserChatOption == null)
				cb_isMuteUserChatOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMuteUserChatOption);
			return cb_isMuteUserChatOption;
		}

		static bool n_IsMuteUserChatOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMuteUserChatOption;
		}
#pragma warning restore 0169

		static IntPtr id_isMuteUserChatOption;
		public virtual unsafe bool IsMuteUserChatOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isMuteUserChatOption' and count(parameter)=0]"
			[Register ("isMuteUserChatOption", "()Z", "GetIsMuteUserChatOptionHandler")]
			get {
				if (id_isMuteUserChatOption == IntPtr.Zero)
					id_isMuteUserChatOption = JNIEnv.GetMethodID (class_ref, "isMuteUserChatOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMuteUserChatOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMuteUserChatOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isOnlineStatusMasterList;
#pragma warning disable 0169
		static Delegate GetIsOnlineStatusMasterListHandler ()
		{
			if (cb_isOnlineStatusMasterList == null)
				cb_isOnlineStatusMasterList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOnlineStatusMasterList);
			return cb_isOnlineStatusMasterList;
		}

		static bool n_IsOnlineStatusMasterList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsOnlineStatusMasterList;
		}
#pragma warning restore 0169

		static IntPtr id_isOnlineStatusMasterList;
		public virtual unsafe bool IsOnlineStatusMasterList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isOnlineStatusMasterList' and count(parameter)=0]"
			[Register ("isOnlineStatusMasterList", "()Z", "GetIsOnlineStatusMasterListHandler")]
			get {
				if (id_isOnlineStatusMasterList == IntPtr.Zero)
					id_isOnlineStatusMasterList = JNIEnv.GetMethodID (class_ref, "isOnlineStatusMasterList", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOnlineStatusMasterList);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOnlineStatusMasterList", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isPriceWidget;
#pragma warning disable 0169
		static Delegate GetIsPriceWidgetHandler ()
		{
			if (cb_isPriceWidget == null)
				cb_isPriceWidget = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPriceWidget);
			return cb_isPriceWidget;
		}

		static bool n_IsPriceWidget (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPriceWidget;
		}
#pragma warning restore 0169

		static IntPtr id_isPriceWidget;
		public virtual unsafe bool IsPriceWidget {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isPriceWidget' and count(parameter)=0]"
			[Register ("isPriceWidget", "()Z", "GetIsPriceWidgetHandler")]
			get {
				if (id_isPriceWidget == IntPtr.Zero)
					id_isPriceWidget = JNIEnv.GetMethodID (class_ref, "isPriceWidget", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isPriceWidget);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isPriceWidget", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isProfileLogoutButton;
#pragma warning disable 0169
		static Delegate GetIsProfileLogoutButtonHandler ()
		{
			if (cb_isProfileLogoutButton == null)
				cb_isProfileLogoutButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProfileLogoutButton);
			return cb_isProfileLogoutButton;
		}

		static bool n_IsProfileLogoutButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfileLogoutButton;
		}
#pragma warning restore 0169

		static IntPtr id_isProfileLogoutButton;
		public virtual unsafe bool IsProfileLogoutButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isProfileLogoutButton' and count(parameter)=0]"
			[Register ("isProfileLogoutButton", "()Z", "GetIsProfileLogoutButtonHandler")]
			get {
				if (id_isProfileLogoutButton == IntPtr.Zero)
					id_isProfileLogoutButton = JNIEnv.GetMethodID (class_ref, "isProfileLogoutButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProfileLogoutButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProfileLogoutButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isProfileOption;
#pragma warning disable 0169
		static Delegate GetIsProfileOptionHandler ()
		{
			if (cb_isProfileOption == null)
				cb_isProfileOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsProfileOption);
			return cb_isProfileOption;
		}

		static bool n_IsProfileOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsProfileOption;
		}
#pragma warning restore 0169

		static IntPtr id_isProfileOption;
		public virtual unsafe bool IsProfileOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isProfileOption' and count(parameter)=0]"
			[Register ("isProfileOption", "()Z", "GetIsProfileOptionHandler")]
			get {
				if (id_isProfileOption == IntPtr.Zero)
					id_isProfileOption = JNIEnv.GetMethodID (class_ref, "isProfileOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isProfileOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isProfileOption", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isRegisteredUserContactListCall;
#pragma warning disable 0169
		static Delegate GetIsRegisteredUserContactListCallHandler ()
		{
			if (cb_isRegisteredUserContactListCall == null)
				cb_isRegisteredUserContactListCall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRegisteredUserContactListCall);
			return cb_isRegisteredUserContactListCall;
		}

		static bool n_IsRegisteredUserContactListCall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRegisteredUserContactListCall;
		}
#pragma warning restore 0169

		static IntPtr id_isRegisteredUserContactListCall;
		public virtual unsafe bool IsRegisteredUserContactListCall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isRegisteredUserContactListCall' and count(parameter)=0]"
			[Register ("isRegisteredUserContactListCall", "()Z", "GetIsRegisteredUserContactListCallHandler")]
			get {
				if (id_isRegisteredUserContactListCall == IntPtr.Zero)
					id_isRegisteredUserContactListCall = JNIEnv.GetMethodID (class_ref, "isRegisteredUserContactListCall", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRegisteredUserContactListCall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRegisteredUserContactListCall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isShowActionDialWithOutCalling;
#pragma warning disable 0169
		static Delegate GetIsShowActionDialWithOutCallingHandler ()
		{
			if (cb_isShowActionDialWithOutCalling == null)
				cb_isShowActionDialWithOutCalling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsShowActionDialWithOutCalling);
			return cb_isShowActionDialWithOutCalling;
		}

		static bool n_IsShowActionDialWithOutCalling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowActionDialWithOutCalling;
		}
#pragma warning restore 0169

		static IntPtr id_isShowActionDialWithOutCalling;
		public virtual unsafe bool IsShowActionDialWithOutCalling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isShowActionDialWithOutCalling' and count(parameter)=0]"
			[Register ("isShowActionDialWithOutCalling", "()Z", "GetIsShowActionDialWithOutCallingHandler")]
			get {
				if (id_isShowActionDialWithOutCalling == IntPtr.Zero)
					id_isShowActionDialWithOutCalling = JNIEnv.GetMethodID (class_ref, "isShowActionDialWithOutCalling", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isShowActionDialWithOutCalling);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isShowActionDialWithOutCalling", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewButton;
#pragma warning disable 0169
		static Delegate GetIsStartNewButtonHandler ()
		{
			if (cb_isStartNewButton == null)
				cb_isStartNewButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewButton);
			return cb_isStartNewButton;
		}

		static bool n_IsStartNewButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewButton;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewButton;
		public virtual unsafe bool IsStartNewButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isStartNewButton' and count(parameter)=0]"
			[Register ("isStartNewButton", "()Z", "GetIsStartNewButtonHandler")]
			get {
				if (id_isStartNewButton == IntPtr.Zero)
					id_isStartNewButton = JNIEnv.GetMethodID (class_ref, "isStartNewButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewFloatingButton;
#pragma warning disable 0169
		static Delegate GetIsStartNewFloatingButtonHandler ()
		{
			if (cb_isStartNewFloatingButton == null)
				cb_isStartNewFloatingButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewFloatingButton);
			return cb_isStartNewFloatingButton;
		}

		static bool n_IsStartNewFloatingButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewFloatingButton;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewFloatingButton;
		public virtual unsafe bool IsStartNewFloatingButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isStartNewFloatingButton' and count(parameter)=0]"
			[Register ("isStartNewFloatingButton", "()Z", "GetIsStartNewFloatingButtonHandler")]
			get {
				if (id_isStartNewFloatingButton == IntPtr.Zero)
					id_isStartNewFloatingButton = JNIEnv.GetMethodID (class_ref, "isStartNewFloatingButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewFloatingButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewFloatingButton", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isStartNewGroup;
#pragma warning disable 0169
		static Delegate GetIsStartNewGroupHandler ()
		{
			if (cb_isStartNewGroup == null)
				cb_isStartNewGroup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStartNewGroup);
			return cb_isStartNewGroup;
		}

		static bool n_IsStartNewGroup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStartNewGroup;
		}
#pragma warning restore 0169

		static IntPtr id_isStartNewGroup;
		public virtual unsafe bool IsStartNewGroup {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isStartNewGroup' and count(parameter)=0]"
			[Register ("isStartNewGroup", "()Z", "GetIsStartNewGroupHandler")]
			get {
				if (id_isStartNewGroup == IntPtr.Zero)
					id_isStartNewGroup = JNIEnv.GetMethodID (class_ref, "isStartNewGroup", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStartNewGroup);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isStartNewGroup", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isUserProfileFragment;
#pragma warning disable 0169
		static Delegate GetIsUserProfileFragmentHandler ()
		{
			if (cb_isUserProfileFragment == null)
				cb_isUserProfileFragment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUserProfileFragment);
			return cb_isUserProfileFragment;
		}

		static bool n_IsUserProfileFragment (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUserProfileFragment;
		}
#pragma warning restore 0169

		static IntPtr id_isUserProfileFragment;
		public virtual unsafe bool IsUserProfileFragment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isUserProfileFragment' and count(parameter)=0]"
			[Register ("isUserProfileFragment", "()Z", "GetIsUserProfileFragmentHandler")]
			get {
				if (id_isUserProfileFragment == IntPtr.Zero)
					id_isUserProfileFragment = JNIEnv.GetMethodID (class_ref, "isUserProfileFragment", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isUserProfileFragment);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isUserProfileFragment", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getLogoutPackage;
#pragma warning disable 0169
		static Delegate GetGetLogoutPackageHandler ()
		{
			if (cb_getLogoutPackage == null)
				cb_getLogoutPackage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLogoutPackage);
			return cb_getLogoutPackage;
		}

		static IntPtr n_GetLogoutPackage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LogoutPackage);
		}
#pragma warning restore 0169

		static IntPtr id_getLogoutPackage;
		public virtual unsafe string LogoutPackage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getLogoutPackage' and count(parameter)=0]"
			[Register ("getLogoutPackage", "()Ljava/lang/String;", "GetGetLogoutPackageHandler")]
			get {
				if (id_getLogoutPackage == IntPtr.Zero)
					id_getLogoutPackage = JNIEnv.GetMethodID (class_ref, "getLogoutPackage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLogoutPackage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLogoutPackage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxAttachmentAllowed;
#pragma warning disable 0169
		static Delegate GetGetMaxAttachmentAllowedHandler ()
		{
			if (cb_getMaxAttachmentAllowed == null)
				cb_getMaxAttachmentAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxAttachmentAllowed);
			return cb_getMaxAttachmentAllowed;
		}

		static int n_GetMaxAttachmentAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAttachmentAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxAttachmentAllowed;
		public virtual unsafe int MaxAttachmentAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMaxAttachmentAllowed' and count(parameter)=0]"
			[Register ("getMaxAttachmentAllowed", "()I", "GetGetMaxAttachmentAllowedHandler")]
			get {
				if (id_getMaxAttachmentAllowed == IntPtr.Zero)
					id_getMaxAttachmentAllowed = JNIEnv.GetMethodID (class_ref, "getMaxAttachmentAllowed", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxAttachmentAllowed);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxAttachmentAllowed", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxAttachmentSizeAllowed;
#pragma warning disable 0169
		static Delegate GetGetMaxAttachmentSizeAllowedHandler ()
		{
			if (cb_getMaxAttachmentSizeAllowed == null)
				cb_getMaxAttachmentSizeAllowed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxAttachmentSizeAllowed);
			return cb_getMaxAttachmentSizeAllowed;
		}

		static int n_GetMaxAttachmentSizeAllowed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAttachmentSizeAllowed;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxAttachmentSizeAllowed;
		public virtual unsafe int MaxAttachmentSizeAllowed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMaxAttachmentSizeAllowed' and count(parameter)=0]"
			[Register ("getMaxAttachmentSizeAllowed", "()I", "GetGetMaxAttachmentSizeAllowedHandler")]
			get {
				if (id_getMaxAttachmentSizeAllowed == IntPtr.Zero)
					id_getMaxAttachmentSizeAllowed = JNIEnv.GetMethodID (class_ref, "getMaxAttachmentSizeAllowed", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxAttachmentSizeAllowed);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxAttachmentSizeAllowed", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getMessageEditTextHintTextColor;
#pragma warning disable 0169
		static Delegate GetGetMessageEditTextHintTextColorHandler ()
		{
			if (cb_getMessageEditTextHintTextColor == null)
				cb_getMessageEditTextHintTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageEditTextHintTextColor);
			return cb_getMessageEditTextHintTextColor;
		}

		static IntPtr n_GetMessageEditTextHintTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageEditTextHintTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageEditTextHintTextColor;
		public virtual unsafe string MessageEditTextHintTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMessageEditTextHintTextColor' and count(parameter)=0]"
			[Register ("getMessageEditTextHintTextColor", "()Ljava/lang/String;", "GetGetMessageEditTextHintTextColorHandler")]
			get {
				if (id_getMessageEditTextHintTextColor == IntPtr.Zero)
					id_getMessageEditTextHintTextColor = JNIEnv.GetMethodID (class_ref, "getMessageEditTextHintTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageEditTextHintTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageEditTextHintTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageEditTextTextColor;
#pragma warning disable 0169
		static Delegate GetGetMessageEditTextTextColorHandler ()
		{
			if (cb_getMessageEditTextTextColor == null)
				cb_getMessageEditTextTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageEditTextTextColor);
			return cb_getMessageEditTextTextColor;
		}

		static IntPtr n_GetMessageEditTextTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageEditTextTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageEditTextTextColor;
		public virtual unsafe string MessageEditTextTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMessageEditTextTextColor' and count(parameter)=0]"
			[Register ("getMessageEditTextTextColor", "()Ljava/lang/String;", "GetGetMessageEditTextTextColorHandler")]
			get {
				if (id_getMessageEditTextTextColor == IntPtr.Zero)
					id_getMessageEditTextTextColor = JNIEnv.GetMethodID (class_ref, "getMessageEditTextTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageEditTextTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageEditTextTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageTemplate;
#pragma warning disable 0169
		static Delegate GetGetMessageTemplateHandler ()
		{
			if (cb_getMessageTemplate == null)
				cb_getMessageTemplate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageTemplate);
			return cb_getMessageTemplate;
		}

		static IntPtr n_GetMessageTemplate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MessageTemplate);
		}
#pragma warning restore 0169

		static Delegate cb_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_;
#pragma warning disable 0169
		static Delegate GetSetMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_Handler ()
		{
			if (cb_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ == null)
				cb_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_);
			return cb_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_;
		}

		static void n_SetMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate p0 = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MessageTemplate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTemplate;
		static IntPtr id_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_;
		public virtual unsafe global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate MessageTemplate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMessageTemplate' and count(parameter)=0]"
			[Register ("getMessageTemplate", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;", "GetGetMessageTemplateHandler")]
			get {
				if (id_getMessageTemplate == IntPtr.Zero)
					id_getMessageTemplate = JNIEnv.GetMethodID (class_ref, "getMessageTemplate", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageTemplate), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.Conversation.MobicomMessageTemplate> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageTemplate", "()Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setMessageTemplate' and count(parameter)=1 and parameter[1][@type='com.applozic.mobicomkit.uiwidgets.conversation.MobicomMessageTemplate']]"
			[Register ("setMessageTemplate", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;)V", "GetSetMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_Handler")]
			set {
				if (id_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ == IntPtr.Zero)
					id_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_ = JNIEnv.GetMethodID (class_ref, "setMessageTemplate", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMessageTemplate_Lcom_applozic_mobicomkit_uiwidgets_conversation_MobicomMessageTemplate_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMessageTemplate", "(Lcom/applozic/mobicomkit/uiwidgets/conversation/MobicomMessageTemplate;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMessageTimeTextColor;
#pragma warning disable 0169
		static Delegate GetGetMessageTimeTextColorHandler ()
		{
			if (cb_getMessageTimeTextColor == null)
				cb_getMessageTimeTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMessageTimeTextColor);
			return cb_getMessageTimeTextColor;
		}

		static IntPtr n_GetMessageTimeTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MessageTimeTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getMessageTimeTextColor;
		public virtual unsafe string MessageTimeTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getMessageTimeTextColor' and count(parameter)=0]"
			[Register ("getMessageTimeTextColor", "()Ljava/lang/String;", "GetGetMessageTimeTextColorHandler")]
			get {
				if (id_getMessageTimeTextColor == IntPtr.Zero)
					id_getMessageTimeTextColor = JNIEnv.GetMethodID (class_ref, "getMessageTimeTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessageTimeTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMessageTimeTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMuteOption;
#pragma warning disable 0169
		static Delegate GetIsMuteOptionHandler ()
		{
			if (cb_isMuteOption == null)
				cb_isMuteOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsMuteOption);
			return cb_isMuteOption;
		}

		static bool n_IsMuteOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MuteOption;
		}
#pragma warning restore 0169

		static Delegate cb_setMuteOption_Z;
#pragma warning disable 0169
		static Delegate GetSetMuteOption_ZHandler ()
		{
			if (cb_setMuteOption_Z == null)
				cb_setMuteOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMuteOption_Z);
			return cb_setMuteOption_Z;
		}

		static void n_SetMuteOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MuteOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isMuteOption;
		static IntPtr id_setMuteOption_Z;
		public virtual unsafe bool MuteOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isMuteOption' and count(parameter)=0]"
			[Register ("isMuteOption", "()Z", "GetIsMuteOptionHandler")]
			get {
				if (id_isMuteOption == IntPtr.Zero)
					id_isMuteOption = JNIEnv.GetMethodID (class_ref, "isMuteOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isMuteOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isMuteOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setMuteOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMuteOption", "(Z)V", "GetSetMuteOption_ZHandler")]
			set {
				if (id_setMuteOption_Z == IntPtr.Zero)
					id_setMuteOption_Z = JNIEnv.GetMethodID (class_ref, "setMuteOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMuteOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMuteOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNoConversationLabel;
#pragma warning disable 0169
		static Delegate GetGetNoConversationLabelHandler ()
		{
			if (cb_getNoConversationLabel == null)
				cb_getNoConversationLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNoConversationLabel);
			return cb_getNoConversationLabel;
		}

		static IntPtr n_GetNoConversationLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NoConversationLabel);
		}
#pragma warning restore 0169

		static IntPtr id_getNoConversationLabel;
		public virtual unsafe string NoConversationLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getNoConversationLabel' and count(parameter)=0]"
			[Register ("getNoConversationLabel", "()Ljava/lang/String;", "GetGetNoConversationLabelHandler")]
			get {
				if (id_getNoConversationLabel == IntPtr.Zero)
					id_getNoConversationLabel = JNIEnv.GetMethodID (class_ref, "getNoConversationLabel", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNoConversationLabel), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoConversationLabel", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNoConversationLabelTextColor;
#pragma warning disable 0169
		static Delegate GetGetNoConversationLabelTextColorHandler ()
		{
			if (cb_getNoConversationLabelTextColor == null)
				cb_getNoConversationLabelTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNoConversationLabelTextColor);
			return cb_getNoConversationLabelTextColor;
		}

		static IntPtr n_GetNoConversationLabelTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NoConversationLabelTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getNoConversationLabelTextColor;
		public virtual unsafe string NoConversationLabelTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getNoConversationLabelTextColor' and count(parameter)=0]"
			[Register ("getNoConversationLabelTextColor", "()Ljava/lang/String;", "GetGetNoConversationLabelTextColorHandler")]
			get {
				if (id_getNoConversationLabelTextColor == IntPtr.Zero)
					id_getNoConversationLabelTextColor = JNIEnv.GetMethodID (class_ref, "getNoConversationLabelTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNoConversationLabelTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoConversationLabelTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNoSearchFoundForChatMessages;
#pragma warning disable 0169
		static Delegate GetGetNoSearchFoundForChatMessagesHandler ()
		{
			if (cb_getNoSearchFoundForChatMessages == null)
				cb_getNoSearchFoundForChatMessages = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNoSearchFoundForChatMessages);
			return cb_getNoSearchFoundForChatMessages;
		}

		static IntPtr n_GetNoSearchFoundForChatMessages (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NoSearchFoundForChatMessages);
		}
#pragma warning restore 0169

		static IntPtr id_getNoSearchFoundForChatMessages;
		public virtual unsafe string NoSearchFoundForChatMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getNoSearchFoundForChatMessages' and count(parameter)=0]"
			[Register ("getNoSearchFoundForChatMessages", "()Ljava/lang/String;", "GetGetNoSearchFoundForChatMessagesHandler")]
			get {
				if (id_getNoSearchFoundForChatMessages == IntPtr.Zero)
					id_getNoSearchFoundForChatMessages = JNIEnv.GetMethodID (class_ref, "getNoSearchFoundForChatMessages", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNoSearchFoundForChatMessages), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNoSearchFoundForChatMessages", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedContactMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedContactMessageTextColorHandler ()
		{
			if (cb_getReceivedContactMessageTextColor == null)
				cb_getReceivedContactMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedContactMessageTextColor);
			return cb_getReceivedContactMessageTextColor;
		}

		static IntPtr n_GetReceivedContactMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivedContactMessageTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedContactMessageTextColor;
		public virtual unsafe string ReceivedContactMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReceivedContactMessageTextColor' and count(parameter)=0]"
			[Register ("getReceivedContactMessageTextColor", "()Ljava/lang/String;", "GetGetReceivedContactMessageTextColorHandler")]
			get {
				if (id_getReceivedContactMessageTextColor == IntPtr.Zero)
					id_getReceivedContactMessageTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedContactMessageTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedContactMessageTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedContactMessageTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageBackgroundColorHandler ()
		{
			if (cb_getReceivedMessageBackgroundColor == null)
				cb_getReceivedMessageBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedMessageBackgroundColor);
			return cb_getReceivedMessageBackgroundColor;
		}

		static IntPtr n_GetReceivedMessageBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivedMessageBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageBackgroundColor;
		public virtual unsafe string ReceivedMessageBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReceivedMessageBackgroundColor' and count(parameter)=0]"
			[Register ("getReceivedMessageBackgroundColor", "()Ljava/lang/String;", "GetGetReceivedMessageBackgroundColorHandler")]
			get {
				if (id_getReceivedMessageBackgroundColor == IntPtr.Zero)
					id_getReceivedMessageBackgroundColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageBorderColorHandler ()
		{
			if (cb_getReceivedMessageBorderColor == null)
				cb_getReceivedMessageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedMessageBorderColor);
			return cb_getReceivedMessageBorderColor;
		}

		static IntPtr n_GetReceivedMessageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivedMessageBorderColor);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageBorderColor;
		public virtual unsafe string ReceivedMessageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReceivedMessageBorderColor' and count(parameter)=0]"
			[Register ("getReceivedMessageBorderColor", "()Ljava/lang/String;", "GetGetReceivedMessageBorderColorHandler")]
			get {
				if (id_getReceivedMessageBorderColor == IntPtr.Zero)
					id_getReceivedMessageBorderColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageLinkTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageLinkTextColorHandler ()
		{
			if (cb_getReceivedMessageLinkTextColor == null)
				cb_getReceivedMessageLinkTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedMessageLinkTextColor);
			return cb_getReceivedMessageLinkTextColor;
		}

		static IntPtr n_GetReceivedMessageLinkTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivedMessageLinkTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageLinkTextColor;
		public virtual unsafe string ReceivedMessageLinkTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReceivedMessageLinkTextColor' and count(parameter)=0]"
			[Register ("getReceivedMessageLinkTextColor", "()Ljava/lang/String;", "GetGetReceivedMessageLinkTextColorHandler")]
			get {
				if (id_getReceivedMessageLinkTextColor == IntPtr.Zero)
					id_getReceivedMessageLinkTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageLinkTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageLinkTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageLinkTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReceivedMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetReceivedMessageTextColorHandler ()
		{
			if (cb_getReceivedMessageTextColor == null)
				cb_getReceivedMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReceivedMessageTextColor);
			return cb_getReceivedMessageTextColor;
		}

		static IntPtr n_GetReceivedMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReceivedMessageTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getReceivedMessageTextColor;
		public virtual unsafe string ReceivedMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReceivedMessageTextColor' and count(parameter)=0]"
			[Register ("getReceivedMessageTextColor", "()Ljava/lang/String;", "GetGetReceivedMessageTextColorHandler")]
			get {
				if (id_getReceivedMessageTextColor == IntPtr.Zero)
					id_getReceivedMessageTextColor = JNIEnv.GetMethodID (class_ref, "getReceivedMessageTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReceivedMessageTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReceivedMessageTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isRecordButton;
#pragma warning disable 0169
		static Delegate GetIsRecordButtonHandler ()
		{
			if (cb_isRecordButton == null)
				cb_isRecordButton = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRecordButton);
			return cb_isRecordButton;
		}

		static bool n_IsRecordButton (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordButton;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordButton_Z;
#pragma warning disable 0169
		static Delegate GetSetRecordButton_ZHandler ()
		{
			if (cb_setRecordButton_Z == null)
				cb_setRecordButton_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRecordButton_Z);
			return cb_setRecordButton_Z;
		}

		static void n_SetRecordButton_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordButton = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRecordButton;
		static IntPtr id_setRecordButton_Z;
		public virtual unsafe bool RecordButton {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isRecordButton' and count(parameter)=0]"
			[Register ("isRecordButton", "()Z", "GetIsRecordButtonHandler")]
			get {
				if (id_isRecordButton == IntPtr.Zero)
					id_isRecordButton = JNIEnv.GetMethodID (class_ref, "isRecordButton", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRecordButton);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRecordButton", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setRecordButton' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRecordButton", "(Z)V", "GetSetRecordButton_ZHandler")]
			set {
				if (id_setRecordButton_Z == IntPtr.Zero)
					id_setRecordButton_Z = JNIEnv.GetMethodID (class_ref, "setRecordButton", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRecordButton_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRecordButton", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRefreshOption;
#pragma warning disable 0169
		static Delegate GetIsRefreshOptionHandler ()
		{
			if (cb_isRefreshOption == null)
				cb_isRefreshOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRefreshOption);
			return cb_isRefreshOption;
		}

		static bool n_IsRefreshOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RefreshOption;
		}
#pragma warning restore 0169

		static Delegate cb_setRefreshOption_Z;
#pragma warning disable 0169
		static Delegate GetSetRefreshOption_ZHandler ()
		{
			if (cb_setRefreshOption_Z == null)
				cb_setRefreshOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetRefreshOption_Z);
			return cb_setRefreshOption_Z;
		}

		static void n_SetRefreshOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isRefreshOption;
		static IntPtr id_setRefreshOption_Z;
		public virtual unsafe bool RefreshOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isRefreshOption' and count(parameter)=0]"
			[Register ("isRefreshOption", "()Z", "GetIsRefreshOptionHandler")]
			get {
				if (id_isRefreshOption == IntPtr.Zero)
					id_isRefreshOption = JNIEnv.GetMethodID (class_ref, "isRefreshOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isRefreshOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isRefreshOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setRefreshOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRefreshOption", "(Z)V", "GetSetRefreshOption_ZHandler")]
			set {
				if (id_setRefreshOption_Z == IntPtr.Zero)
					id_setRefreshOption_Z = JNIEnv.GetMethodID (class_ref, "setRefreshOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefreshOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefreshOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getReplyMessageLayoutReceivedMessageBackground;
#pragma warning disable 0169
		static Delegate GetGetReplyMessageLayoutReceivedMessageBackgroundHandler ()
		{
			if (cb_getReplyMessageLayoutReceivedMessageBackground == null)
				cb_getReplyMessageLayoutReceivedMessageBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReplyMessageLayoutReceivedMessageBackground);
			return cb_getReplyMessageLayoutReceivedMessageBackground;
		}

		static IntPtr n_GetReplyMessageLayoutReceivedMessageBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReplyMessageLayoutReceivedMessageBackground);
		}
#pragma warning restore 0169

		static IntPtr id_getReplyMessageLayoutReceivedMessageBackground;
		public virtual unsafe string ReplyMessageLayoutReceivedMessageBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReplyMessageLayoutReceivedMessageBackground' and count(parameter)=0]"
			[Register ("getReplyMessageLayoutReceivedMessageBackground", "()Ljava/lang/String;", "GetGetReplyMessageLayoutReceivedMessageBackgroundHandler")]
			get {
				if (id_getReplyMessageLayoutReceivedMessageBackground == IntPtr.Zero)
					id_getReplyMessageLayoutReceivedMessageBackground = JNIEnv.GetMethodID (class_ref, "getReplyMessageLayoutReceivedMessageBackground", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReplyMessageLayoutReceivedMessageBackground), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReplyMessageLayoutReceivedMessageBackground", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReplyMessageLayoutSentMessageBackground;
#pragma warning disable 0169
		static Delegate GetGetReplyMessageLayoutSentMessageBackgroundHandler ()
		{
			if (cb_getReplyMessageLayoutSentMessageBackground == null)
				cb_getReplyMessageLayoutSentMessageBackground = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetReplyMessageLayoutSentMessageBackground);
			return cb_getReplyMessageLayoutSentMessageBackground;
		}

		static IntPtr n_GetReplyMessageLayoutSentMessageBackground (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ReplyMessageLayoutSentMessageBackground);
		}
#pragma warning restore 0169

		static IntPtr id_getReplyMessageLayoutSentMessageBackground;
		public virtual unsafe string ReplyMessageLayoutSentMessageBackground {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getReplyMessageLayoutSentMessageBackground' and count(parameter)=0]"
			[Register ("getReplyMessageLayoutSentMessageBackground", "()Ljava/lang/String;", "GetGetReplyMessageLayoutSentMessageBackgroundHandler")]
			get {
				if (id_getReplyMessageLayoutSentMessageBackground == IntPtr.Zero)
					id_getReplyMessageLayoutSentMessageBackground = JNIEnv.GetMethodID (class_ref, "getReplyMessageLayoutSentMessageBackground", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getReplyMessageLayoutSentMessageBackground), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getReplyMessageLayoutSentMessageBackground", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isReplyOption;
#pragma warning disable 0169
		static Delegate GetIsReplyOptionHandler ()
		{
			if (cb_isReplyOption == null)
				cb_isReplyOption = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsReplyOption);
			return cb_isReplyOption;
		}

		static bool n_IsReplyOption (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReplyOption;
		}
#pragma warning restore 0169

		static Delegate cb_setReplyOption_Z;
#pragma warning disable 0169
		static Delegate GetSetReplyOption_ZHandler ()
		{
			if (cb_setReplyOption_Z == null)
				cb_setReplyOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetReplyOption_Z);
			return cb_setReplyOption_Z;
		}

		static void n_SetReplyOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReplyOption = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isReplyOption;
		static IntPtr id_setReplyOption_Z;
		public virtual unsafe bool ReplyOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='isReplyOption' and count(parameter)=0]"
			[Register ("isReplyOption", "()Z", "GetIsReplyOptionHandler")]
			get {
				if (id_isReplyOption == IntPtr.Zero)
					id_isReplyOption = JNIEnv.GetMethodID (class_ref, "isReplyOption", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isReplyOption);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isReplyOption", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setReplyOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setReplyOption", "(Z)V", "GetSetReplyOption_ZHandler")]
			set {
				if (id_setReplyOption_Z == IntPtr.Zero)
					id_setReplyOption_Z = JNIEnv.GetMethodID (class_ref, "setReplyOption", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setReplyOption_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReplyOption", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRestrictedWordMessage;
#pragma warning disable 0169
		static Delegate GetGetRestrictedWordMessageHandler ()
		{
			if (cb_getRestrictedWordMessage == null)
				cb_getRestrictedWordMessage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRestrictedWordMessage);
			return cb_getRestrictedWordMessage;
		}

		static IntPtr n_GetRestrictedWordMessage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RestrictedWordMessage);
		}
#pragma warning restore 0169

		static Delegate cb_setRestrictedWordMessage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRestrictedWordMessage_Ljava_lang_String_Handler ()
		{
			if (cb_setRestrictedWordMessage_Ljava_lang_String_ == null)
				cb_setRestrictedWordMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRestrictedWordMessage_Ljava_lang_String_);
			return cb_setRestrictedWordMessage_Ljava_lang_String_;
		}

		static void n_SetRestrictedWordMessage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RestrictedWordMessage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRestrictedWordMessage;
		static IntPtr id_setRestrictedWordMessage_Ljava_lang_String_;
		public virtual unsafe string RestrictedWordMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getRestrictedWordMessage' and count(parameter)=0]"
			[Register ("getRestrictedWordMessage", "()Ljava/lang/String;", "GetGetRestrictedWordMessageHandler")]
			get {
				if (id_getRestrictedWordMessage == IntPtr.Zero)
					id_getRestrictedWordMessage = JNIEnv.GetMethodID (class_ref, "getRestrictedWordMessage", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRestrictedWordMessage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRestrictedWordMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setRestrictedWordMessage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRestrictedWordMessage", "(Ljava/lang/String;)V", "GetSetRestrictedWordMessage_Ljava_lang_String_Handler")]
			set {
				if (id_setRestrictedWordMessage_Ljava_lang_String_ == IntPtr.Zero)
					id_setRestrictedWordMessage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRestrictedWordMessage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRestrictedWordMessage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRestrictedWordMessage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSendButtonBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetSendButtonBackgroundColorHandler ()
		{
			if (cb_getSendButtonBackgroundColor == null)
				cb_getSendButtonBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSendButtonBackgroundColor);
			return cb_getSendButtonBackgroundColor;
		}

		static IntPtr n_GetSendButtonBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SendButtonBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSendButtonBackgroundColor;
		public virtual unsafe string SendButtonBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSendButtonBackgroundColor' and count(parameter)=0]"
			[Register ("getSendButtonBackgroundColor", "()Ljava/lang/String;", "GetGetSendButtonBackgroundColorHandler")]
			get {
				if (id_getSendButtonBackgroundColor == IntPtr.Zero)
					id_getSendButtonBackgroundColor = JNIEnv.GetMethodID (class_ref, "getSendButtonBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSendButtonBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSendButtonBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSentContactMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentContactMessageTextColorHandler ()
		{
			if (cb_getSentContactMessageTextColor == null)
				cb_getSentContactMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentContactMessageTextColor);
			return cb_getSentContactMessageTextColor;
		}

		static IntPtr n_GetSentContactMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentContactMessageTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSentContactMessageTextColor;
		public virtual unsafe string SentContactMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSentContactMessageTextColor' and count(parameter)=0]"
			[Register ("getSentContactMessageTextColor", "()Ljava/lang/String;", "GetGetSentContactMessageTextColorHandler")]
			get {
				if (id_getSentContactMessageTextColor == IntPtr.Zero)
					id_getSentContactMessageTextColor = JNIEnv.GetMethodID (class_ref, "getSentContactMessageTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSentContactMessageTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentContactMessageTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageBackgroundColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageBackgroundColorHandler ()
		{
			if (cb_getSentMessageBackgroundColor == null)
				cb_getSentMessageBackgroundColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentMessageBackgroundColor);
			return cb_getSentMessageBackgroundColor;
		}

		static IntPtr n_GetSentMessageBackgroundColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentMessageBackgroundColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageBackgroundColor;
		public virtual unsafe string SentMessageBackgroundColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSentMessageBackgroundColor' and count(parameter)=0]"
			[Register ("getSentMessageBackgroundColor", "()Ljava/lang/String;", "GetGetSentMessageBackgroundColorHandler")]
			get {
				if (id_getSentMessageBackgroundColor == IntPtr.Zero)
					id_getSentMessageBackgroundColor = JNIEnv.GetMethodID (class_ref, "getSentMessageBackgroundColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageBackgroundColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageBackgroundColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageBorderColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageBorderColorHandler ()
		{
			if (cb_getSentMessageBorderColor == null)
				cb_getSentMessageBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentMessageBorderColor);
			return cb_getSentMessageBorderColor;
		}

		static IntPtr n_GetSentMessageBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentMessageBorderColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageBorderColor;
		public virtual unsafe string SentMessageBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSentMessageBorderColor' and count(parameter)=0]"
			[Register ("getSentMessageBorderColor", "()Ljava/lang/String;", "GetGetSentMessageBorderColorHandler")]
			get {
				if (id_getSentMessageBorderColor == IntPtr.Zero)
					id_getSentMessageBorderColor = JNIEnv.GetMethodID (class_ref, "getSentMessageBorderColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageBorderColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageBorderColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageLinkTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageLinkTextColorHandler ()
		{
			if (cb_getSentMessageLinkTextColor == null)
				cb_getSentMessageLinkTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentMessageLinkTextColor);
			return cb_getSentMessageLinkTextColor;
		}

		static IntPtr n_GetSentMessageLinkTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentMessageLinkTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageLinkTextColor;
		public virtual unsafe string SentMessageLinkTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSentMessageLinkTextColor' and count(parameter)=0]"
			[Register ("getSentMessageLinkTextColor", "()Ljava/lang/String;", "GetGetSentMessageLinkTextColorHandler")]
			get {
				if (id_getSentMessageLinkTextColor == IntPtr.Zero)
					id_getSentMessageLinkTextColor = JNIEnv.GetMethodID (class_ref, "getSentMessageLinkTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageLinkTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageLinkTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSentMessageTextColor;
#pragma warning disable 0169
		static Delegate GetGetSentMessageTextColorHandler ()
		{
			if (cb_getSentMessageTextColor == null)
				cb_getSentMessageTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSentMessageTextColor);
			return cb_getSentMessageTextColor;
		}

		static IntPtr n_GetSentMessageTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SentMessageTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getSentMessageTextColor;
		public virtual unsafe string SentMessageTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getSentMessageTextColor' and count(parameter)=0]"
			[Register ("getSentMessageTextColor", "()Ljava/lang/String;", "GetGetSentMessageTextColorHandler")]
			get {
				if (id_getSentMessageTextColor == IntPtr.Zero)
					id_getSentMessageTextColor = JNIEnv.GetMethodID (class_ref, "getSentMessageTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSentMessageTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSentMessageTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThemeColorPrimary;
#pragma warning disable 0169
		static Delegate GetGetThemeColorPrimaryHandler ()
		{
			if (cb_getThemeColorPrimary == null)
				cb_getThemeColorPrimary = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThemeColorPrimary);
			return cb_getThemeColorPrimary;
		}

		static IntPtr n_GetThemeColorPrimary (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThemeColorPrimary);
		}
#pragma warning restore 0169

		static IntPtr id_getThemeColorPrimary;
		public virtual unsafe string ThemeColorPrimary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getThemeColorPrimary' and count(parameter)=0]"
			[Register ("getThemeColorPrimary", "()Ljava/lang/String;", "GetGetThemeColorPrimaryHandler")]
			get {
				if (id_getThemeColorPrimary == IntPtr.Zero)
					id_getThemeColorPrimary = JNIEnv.GetMethodID (class_ref, "getThemeColorPrimary", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThemeColorPrimary), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThemeColorPrimary", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThemeColorPrimaryDark;
#pragma warning disable 0169
		static Delegate GetGetThemeColorPrimaryDarkHandler ()
		{
			if (cb_getThemeColorPrimaryDark == null)
				cb_getThemeColorPrimaryDark = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThemeColorPrimaryDark);
			return cb_getThemeColorPrimaryDark;
		}

		static IntPtr n_GetThemeColorPrimaryDark (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ThemeColorPrimaryDark);
		}
#pragma warning restore 0169

		static IntPtr id_getThemeColorPrimaryDark;
		public virtual unsafe string ThemeColorPrimaryDark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getThemeColorPrimaryDark' and count(parameter)=0]"
			[Register ("getThemeColorPrimaryDark", "()Ljava/lang/String;", "GetGetThemeColorPrimaryDarkHandler")]
			get {
				if (id_getThemeColorPrimaryDark == IntPtr.Zero)
					id_getThemeColorPrimaryDark = JNIEnv.GetMethodID (class_ref, "getThemeColorPrimaryDark", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThemeColorPrimaryDark), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThemeColorPrimaryDark", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTotalOnlineUsers;
#pragma warning disable 0169
		static Delegate GetGetTotalOnlineUsersHandler ()
		{
			if (cb_getTotalOnlineUsers == null)
				cb_getTotalOnlineUsers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalOnlineUsers);
			return cb_getTotalOnlineUsers;
		}

		static int n_GetTotalOnlineUsers (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalOnlineUsers;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalOnlineUsers;
		public virtual unsafe int TotalOnlineUsers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getTotalOnlineUsers' and count(parameter)=0]"
			[Register ("getTotalOnlineUsers", "()I", "GetGetTotalOnlineUsersHandler")]
			get {
				if (id_getTotalOnlineUsers == IntPtr.Zero)
					id_getTotalOnlineUsers = JNIEnv.GetMethodID (class_ref, "getTotalOnlineUsers", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalOnlineUsers);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalOnlineUsers", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTotalRegisteredUserToFetch;
#pragma warning disable 0169
		static Delegate GetGetTotalRegisteredUserToFetchHandler ()
		{
			if (cb_getTotalRegisteredUserToFetch == null)
				cb_getTotalRegisteredUserToFetch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTotalRegisteredUserToFetch);
			return cb_getTotalRegisteredUserToFetch;
		}

		static int n_GetTotalRegisteredUserToFetch (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TotalRegisteredUserToFetch;
		}
#pragma warning restore 0169

		static IntPtr id_getTotalRegisteredUserToFetch;
		public virtual unsafe int TotalRegisteredUserToFetch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getTotalRegisteredUserToFetch' and count(parameter)=0]"
			[Register ("getTotalRegisteredUserToFetch", "()I", "GetGetTotalRegisteredUserToFetchHandler")]
			get {
				if (id_getTotalRegisteredUserToFetch == IntPtr.Zero)
					id_getTotalRegisteredUserToFetch = JNIEnv.GetMethodID (class_ref, "getTotalRegisteredUserToFetch", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getTotalRegisteredUserToFetch);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTotalRegisteredUserToFetch", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getTypingTextColor;
#pragma warning disable 0169
		static Delegate GetGetTypingTextColorHandler ()
		{
			if (cb_getTypingTextColor == null)
				cb_getTypingTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTypingTextColor);
			return cb_getTypingTextColor;
		}

		static IntPtr n_GetTypingTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TypingTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getTypingTextColor;
		public virtual unsafe string TypingTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getTypingTextColor' and count(parameter)=0]"
			[Register ("getTypingTextColor", "()Ljava/lang/String;", "GetGetTypingTextColorHandler")]
			get {
				if (id_getTypingTextColor == IntPtr.Zero)
					id_getTypingTextColor = JNIEnv.GetMethodID (class_ref, "getTypingTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTypingTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTypingTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUserNotAbleToChatTextColor;
#pragma warning disable 0169
		static Delegate GetGetUserNotAbleToChatTextColorHandler ()
		{
			if (cb_getUserNotAbleToChatTextColor == null)
				cb_getUserNotAbleToChatTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserNotAbleToChatTextColor);
			return cb_getUserNotAbleToChatTextColor;
		}

		static IntPtr n_GetUserNotAbleToChatTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserNotAbleToChatTextColor);
		}
#pragma warning restore 0169

		static IntPtr id_getUserNotAbleToChatTextColor;
		public virtual unsafe string UserNotAbleToChatTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='getUserNotAbleToChatTextColor' and count(parameter)=0]"
			[Register ("getUserNotAbleToChatTextColor", "()Ljava/lang/String;", "GetGetUserNotAbleToChatTextColorHandler")]
			get {
				if (id_getUserNotAbleToChatTextColor == IntPtr.Zero)
					id_getUserNotAbleToChatTextColor = JNIEnv.GetMethodID (class_ref, "getUserNotAbleToChatTextColor", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUserNotAbleToChatTextColor), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUserNotAbleToChatTextColor", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setLogout_Z;
#pragma warning disable 0169
		static Delegate GetSetLogout_ZHandler ()
		{
			if (cb_setLogout_Z == null)
				cb_setLogout_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLogout_Z);
			return cb_setLogout_Z;
		}

		static void n_SetLogout_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogout (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogout_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setLogout' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setLogout", "(Z)V", "GetSetLogout_ZHandler")]
		public virtual unsafe void SetLogout (bool p0)
		{
			if (id_setLogout_Z == IntPtr.Zero)
				id_setLogout_Z = JNIEnv.GetMethodID (class_ref, "setLogout", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogout_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogout", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLogoutPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLogoutPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setLogoutPackageName_Ljava_lang_String_ == null)
				cb_setLogoutPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLogoutPackageName_Ljava_lang_String_);
			return cb_setLogoutPackageName_Ljava_lang_String_;
		}

		static void n_SetLogoutPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLogoutPackageName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLogoutPackageName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setLogoutPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLogoutPackageName", "(Ljava/lang/String;)V", "GetSetLogoutPackageName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLogoutPackageName (string p0)
		{
			if (id_setLogoutPackageName_Ljava_lang_String_ == IntPtr.Zero)
				id_setLogoutPackageName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLogoutPackageName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLogoutPackageName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLogoutPackageName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setUserChatMuteOption_Z;
#pragma warning disable 0169
		static Delegate GetSetUserChatMuteOption_ZHandler ()
		{
			if (cb_setUserChatMuteOption_Z == null)
				cb_setUserChatMuteOption_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUserChatMuteOption_Z);
			return cb_setUserChatMuteOption_Z;
		}

		static void n_SetUserChatMuteOption_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings __this = global::Java.Lang.Object.GetObject<global::Com.Applozic.Mobicomkit.Uiwidgets.AlCustomizationSettings> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUserChatMuteOption (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setUserChatMuteOption_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.applozic.mobicomkit.uiwidgets']/class[@name='AlCustomizationSettings']/method[@name='setUserChatMuteOption' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUserChatMuteOption", "(Z)V", "GetSetUserChatMuteOption_ZHandler")]
		public virtual unsafe void SetUserChatMuteOption (bool p0)
		{
			if (id_setUserChatMuteOption_Z == IntPtr.Zero)
				id_setUserChatMuteOption_Z = JNIEnv.GetMethodID (class_ref, "setUserChatMuteOption", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUserChatMuteOption_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUserChatMuteOption", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
